using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Firefall_DISASM_Name_Manager
{
    public static class Globals
    {
        public const int DATABASEVERSION = 1;
        public const int BASEADDRESS = 0x400000;
        public static string TargetClientVersion = "";
    }

    public enum ENameStatus
    {
        Accurate = 0,
        Suggested = 1,
        Potential = 2,
        Placeholder = 3
    }

    public interface ICloneable<T>
    {
        T Clone();
    }

    public class NameClass : ICloneable<NameClass>
    {
        public string Category;
        public string Address;
        public string Name;
        public int Status;
        public string Comment;

        public NameClass() { }

        public NameClass(string Category, string Address, string Name, int Status, string Comment)
        {
            this.Category = Category;
            this.Address = Address;
            this.Name = Name;
            this.Status = Status;
            this.Comment = Comment;
        }

        public NameClass Clone()
        {
            return new NameClass(Category, Address, Name, Status, Comment);
        }
    }

    static class Extensions
    {
        public static IList<T> Clone<T>(this IList<T> listToClone) where T : ICloneable
        {
            return listToClone.Select(item => (T)item.Clone()).ToList();
        }
    }

    class NameManager
    {
        private string GetFinalAddress(string OriginalAddress, int LocalBaseAddress = 0x400000)
        {
            int OffsetAddress = LocalBaseAddress - Globals.BASEADDRESS;

            int NameAddress = Int32.Parse(OriginalAddress.Substring(2), System.Globalization.NumberStyles.HexNumber);

            string FinalAddress = $"0x{(NameAddress - OffsetAddress):X}";

            return FinalAddress;
        }

        public string ToIDAPython(List<NameClass> Names, int EnabledStatusLevel, int LocalBaseAddress = 0x400000)
        {
            StringBuilder result = new StringBuilder();

            result.Append($"# IDA Python MakeName Script for FirefallClient.exe V{ Globals.TargetClientVersion + Environment.NewLine + Environment.NewLine }");

            string CurrentCategory = "__CurrentCategory__INVALID";

            foreach (NameClass item in Names)
            {
                if (CurrentCategory != item.Category)
                {
                    if (item.Category.EndsWith("_Comment"))
                    {
                        result.Append(Environment.NewLine + $"# Category: {item.Category.Substring(0, item.Category.IndexOf("_Comment"))}" + Environment.NewLine);
                        CurrentCategory = item.Category.Substring(0, item.Category.IndexOf("_Comment"));

                        result.Append($"# Category_Comment{ Environment.NewLine }# { item.Comment.Replace("\n", "\n# ") }{ Environment.NewLine + Environment.NewLine }");

                        continue;
                    }
                    else
                    {
                        result.Append(Environment.NewLine + $"# Category: { item.Category + Environment.NewLine }");
                        CurrentCategory = item.Category;
                    }
                }

                string FinalAddress = item.Address;
                if (LocalBaseAddress != 0x400000)
                {
                    FinalAddress = GetFinalAddress(item.Address, LocalBaseAddress);
                }

                string Status = (EnabledStatusLevel < item.Status ? new string('#', item.Status) : "");
                string Comment = (item.Comment.Length > 0 ? $" # { item.Comment }" : "");

                result.Append($"{ Status }MakeName({ FinalAddress }, \"{ item.Name }\"){ Comment }" + Environment.NewLine);
            }

            return result.ToString();
        }

        public List<NameClass> FromIDAPython(string[] Lines, int LocalBaseAddress = 0x400000)
        {
            List<NameClass> Names = new List<NameClass>();

            string CurrentCategory = "";
            bool CategoryCommenting = false;
            string CategoryComment = "";

            foreach (string line in Lines)
            {
                if (line.StartsWith("# Category:") && CategoryCommenting == false)
                {
                    CurrentCategory = line.Substring(line.IndexOf(":") + 1).Trim();
                }
                else if (line.StartsWith("# Category_Comment"))
                {
                    CategoryCommenting = true;
                }
                else if (line.StartsWith("# ") && CategoryCommenting)
                {
                    CategoryComment += line.Substring(2) + Environment.NewLine;
                }
                else if (line.Length == 0 && CategoryCommenting)
                {
                    NameClass Name = new NameClass();

                    Name.Category = CurrentCategory + "_Comment";
                    Name.Comment = CategoryComment.TrimEnd();

                    Names.Add(Name);

                    CategoryCommenting = false;
                    CategoryComment = "";
                }
                else if(line.Contains("MakeName(") && CategoryCommenting == false)
                {
                    NameClass Name = new NameClass();

                    int Status = 0;
                    if (line.StartsWith("#MakeName"))
                    {
                        Status = 1;
                    }
                    else if (line.StartsWith("##MakeName"))
                    {
                        Status = 2;
                    }
                    else if (line.StartsWith("###MakeName"))
                    {
                        Status = 3;
                    }

                    int AddressStart = line.IndexOf("(") + 1;
                    int AddressEnd = line.IndexOf(",");
                    string Address = line.Substring(AddressStart, AddressEnd - AddressStart).Trim();

                    string FinalAddress = Address;
                    if (LocalBaseAddress != 0x400000)
                    {
                        FinalAddress = GetFinalAddress(Address, LocalBaseAddress);
                    }

                    int NameStart = AddressEnd + 1;
                    int NameEnd = line.IndexOf(")");
                    string NameString = line.Substring(NameStart, NameEnd - NameStart).Trim().Trim('\"');

                    string Comment = line.Substring(NameEnd + 1).Trim().TrimStart('#').Trim();

                    Name.Category = CurrentCategory;
                    Name.Address = FinalAddress;
                    Name.Name = NameString;
                    Name.Status = Status;
                    Name.Comment = Comment;

                    Names.Add(Name);
                }
            }

            return Names;
        }

        public string ToJSON(List<NameClass> Names, int LocalBaseAddress = 0x400000)
        {
            List<NameClass> _Names = Names.ConvertAll(obj => obj.Clone());

            StringBuilder result = new StringBuilder();

            result.Append($"// Version #{Globals.DATABASEVERSION + Environment.NewLine}");
            result.Append("// Firefall DISASM Name Manager Database" + Environment.NewLine);
            result.Append($"// FirefallClient.exe V{Globals.TargetClientVersion + Environment.NewLine}");

            if (LocalBaseAddress != 0x400000)
            {
                foreach (NameClass item in _Names)
                {
                    item.Address = GetFinalAddress(item.Address, LocalBaseAddress);
                }
            }

            result.Append(JsonSerializer.Serialize<List<NameClass>>(_Names, new JsonSerializerOptions { IncludeFields = true, WriteIndented = true }));

            return result.ToString();
        }

        public List<NameClass> FromJSON(string[] Lines, int LocalBaseAddress = 0x400000)
        {
            List<NameClass> Names = new List<NameClass>();

            Names = JsonSerializer.Deserialize<List<NameClass>>(string.Join(Environment.NewLine, Lines), new JsonSerializerOptions { ReadCommentHandling = JsonCommentHandling.Skip, IncludeFields = true });

            if (LocalBaseAddress != 0x400000)
            {
                foreach (NameClass item in Names)
                {
                    item.Address = GetFinalAddress(item.Address, LocalBaseAddress);
                }
            }

            return Names;
        }

        public string ToGhidraPython(List<NameClass> Names, int EnabledStatusLevel, int LocalBaseAddress = 0x400000)
        {
            StringBuilder result = new StringBuilder();

            result.Append($"# Ghidra Python MakeName Script for FirefallClient.exe V{ Globals.TargetClientVersion + Environment.NewLine + Environment.NewLine }");

            string CurrentCategory = "__CurrentCategory__INVALID";

            foreach (NameClass item in Names)
            {
                if (CurrentCategory != item.Category)
                {
                    if (item.Category.EndsWith("_Comment"))
                    {
                        result.Append(Environment.NewLine + $"# Category: {item.Category.Substring(0, item.Category.IndexOf("_Comment"))}" + Environment.NewLine);
                        CurrentCategory = item.Category.Substring(0, item.Category.IndexOf("_Comment"));

                        result.Append($"# Category_Comment{ Environment.NewLine }# { item.Comment.Replace("\n", "\n# ") }{ Environment.NewLine + Environment.NewLine }");

                        continue;
                    }
                    else
                    {
                        result.Append(Environment.NewLine + $"# Category: { item.Category + Environment.NewLine }");
                        CurrentCategory = item.Category;
                    }
                }

                string FinalAddress = item.Address;
                if (LocalBaseAddress != 0x400000)
                {
                    FinalAddress = GetFinalAddress(item.Address, LocalBaseAddress);
                }

                string Status = (EnabledStatusLevel < item.Status ? new string('#', item.Status) : "");
                string Comment = (item.Comment.Length > 0 ? $" # { item.Comment }" : "");

                result.Append($"{ Status }getFunctionContaining(toAddr({ FinalAddress })).setName(\"{ item.Name }\", ghidra.program.model.symbol.SourceType.USER_DEFINED){ Comment }" + Environment.NewLine);
            }

            return result.ToString();
        }

        public List<NameClass> FromGhidraPython(string[] Lines, int LocalBaseAddress = 0x400000)
        {
            List<NameClass> Names = new List<NameClass>();

            string CurrentCategory = "";
            bool CategoryCommenting = false;
            string CategoryComment = "";

            foreach (string line in Lines)
            {
                if (line.StartsWith("# Category:") && CategoryCommenting == false)
                {
                    CurrentCategory = line.Substring(line.IndexOf(":") + 1).Trim();
                }
                else if (line.StartsWith("# Category_Comment"))
                {
                    CategoryCommenting = true;
                }
                else if (line.StartsWith("# ") && CategoryCommenting)
                {
                    CategoryComment += line.Substring(2) + Environment.NewLine;
                }
                else if (line.Length == 0 && CategoryCommenting)
                {
                    NameClass Name = new NameClass();

                    Name.Category = CurrentCategory + "_Comment";
                    Name.Comment = CategoryComment.TrimEnd();

                    Names.Add(Name);

                    CategoryCommenting = false;
                    CategoryComment = "";
                }
                else if (line.Contains("getFunctionContaining(") && CategoryCommenting == false)
                {
                    NameClass Name = new NameClass();

                    int Status = 0;
                    if (line.StartsWith("#getFunctionContaining"))
                    {
                        Status = 1;
                    }
                    else if (line.StartsWith("##getFunctionContaining"))
                    {
                        Status = 2;
                    }
                    else if (line.StartsWith("###getFunctionContaining"))
                    {
                        Status = 3;
                    }

                    int AddressStart = line.IndexOf("toAddr(") + 7;
                    int AddressEnd = line.IndexOf(")");
                    string Address = line.Substring(AddressStart, AddressEnd - AddressStart).Trim();

                    string FinalAddress = Address;
                    if (LocalBaseAddress != 0x400000)
                    {
                        FinalAddress = GetFinalAddress(Address, LocalBaseAddress);
                    }

                    int NameStart = line.IndexOf("setName(") + 8;
                    int NameEnd = line.IndexOf(",");
                    string NameString = line.Substring(NameStart, NameEnd - NameStart).Trim().Trim('\"');

                    string Comment = line.Substring(line.IndexOf("USER_DEFINED)") + 14).Trim().TrimStart('#').Trim();

                    Name.Category = CurrentCategory;
                    Name.Address = FinalAddress;
                    Name.Name = NameString;
                    Name.Status = Status;
                    Name.Comment = Comment;

                    Names.Add(Name);
                }
            }

            return Names;
        }

        public string ToJEBPython(List<NameClass> Names, int EnabledStatusLevel, int LocalBaseAddress = 0x400000)
        {
            StringBuilder result = new StringBuilder();

            result.Append($"#?description=JEB Python MakeName Script for FirefallClient.exe V{ Globals.TargetClientVersion + Environment.NewLine }");
            result.Append($"#?shortcut={ Environment.NewLine + Environment.NewLine}");

            result.AppendLine("# !==IMPORTANT==!");
            result.AppendLine($"# Filename must be \"JEBScript_FFC_MakeNames_{ Globals.TargetClientVersion }.py\"{ Environment.NewLine }");

            result.AppendLine("from com.pnfsoftware.jeb.client.api import IScript");
            result.AppendLine("from com.pnfsoftware.jeb.core.units import INativeCodeUnit");
            result.AppendLine("from com.pnfsoftware.jeb.core.units.code import ICodeUnit" + Environment.NewLine);

            result.AppendLine($"class JEBScript_FFC_MakeNames_{ Globals.TargetClientVersion }(IScript):");
            result.AppendLine("\tdef run(self, ctx):");
            result.AppendLine("\t\tprj = ctx.getMainProject()");
            result.AppendLine("\t\tcode = prj.findUnit(INativeCodeUnit)");

            string CurrentCategory = "__CurrentCategory__INVALID";

            foreach (NameClass item in Names)
            {
                if (CurrentCategory != item.Category)
                {
                    if (item.Category.EndsWith("_Comment"))
                    {
                        result.Append(Environment.NewLine + $"\t\t# Category: {item.Category.Substring(0, item.Category.IndexOf("_Comment"))}" + Environment.NewLine);
                        CurrentCategory = item.Category.Substring(0, item.Category.IndexOf("_Comment"));

                        result.Append($"\t\t# Category_Comment{ Environment.NewLine }\t\t# { item.Comment.Replace("\n", "\n\t\t# ") }{ Environment.NewLine + Environment.NewLine }");

                        continue;
                    }
                    else
                    {
                        result.Append(Environment.NewLine + $"\t\t# Category: { item.Category + Environment.NewLine }");
                        CurrentCategory = item.Category;
                    }
                }

                string FinalAddress = item.Address;
                if (LocalBaseAddress != 0x400000)
                {
                    FinalAddress = GetFinalAddress(item.Address, LocalBaseAddress);
                }

                string Status = (EnabledStatusLevel < item.Status ? new string('#', item.Status) : "");
                string Comment = (item.Comment.Length > 0 ? $" # { item.Comment }" : "");

                result.Append($"\t\t{ Status }code.getNativeItemAt({ FinalAddress }).setName(\"{ item.Name }\"){ Comment }" + Environment.NewLine);
            }

            return result.ToString();
        }

        public string ToPlainText(List<NameClass> Names)
        {
            string result = "";

            result += $"Version #{Globals.DATABASEVERSION}" + Environment.NewLine;
            result += "Firefall DISASM Name Manager Database" + Environment.NewLine;
            result += $"FirefallClient.exe V{Globals.TargetClientVersion}" + Environment.NewLine;

            return result;
        }
    }
}
