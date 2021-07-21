# Firefall DISASM Name Manager

*Firefall DISASM Name Manager is an application to easily manage Firefall subroutine names for disassemblers*

The goal of this tool is to allow for improving the ability to share research while reverse engineering the client. Utilizing a simple file format for data transfer and supporting the ability to import from and export to common tools, sharing work is faster.

## Supported Formats
See the table below for the supported format matrix of what formats can be used for importing and exporting:

| Format | Import | Export |
| ------ | ------ | ------ |
| `JSON` | :heavy_check_mark: | :heavy_check_mark: |
| `IDA Python` | :heavy_check_mark: | :heavy_check_mark: |
| `Ghidra Python` | :heavy_check_mark: | :heavy_check_mark: |
| `Ghidra Script (Java)` | :x: | :x: |
| `JEB Script (Python)` | :x: | :heavy_check_mark: |
| `JEB Plugin (Java)` | :x: | :x: |

The support for additional formats will be determined based on projects needs.
* JEB Script support is based on [JEB Decompiler](https://www.pnfsoftware.com/) 4.3 which only supports Python 2.7.

The latest public database files can be found on the [NameManagerDatabases](https://github.com/themeldingwars/NameManagerDatabases) repo.

This tool is built with [.NET 5.0](https://dotnet.microsoft.com/download).

![](https://i.imgur.com/ghD8irG.png)

## Two Interaction Modes
There are two primary interaction modes, Edit Mode and Add Mode. To switch between these modes, click either the Edit Mode or Add Mode buttons in the center of the window.

### Edit Mode
While in Edit Mode, default, whenever a Name is selected from the list, it will be reflected in the bottom half of the interface. When these fields are edited they will immediately modify the data in the list for that entry.

### Add Mode
While in Add Mode, the Add New Name button will become enabled. Clicking this will insert the current data into the top list of Names for the database.

The database stores all Names with the `Base Address` of `0x400000` however since some disassemblers may have a different base, there is a Base Address field which can be adjusted to match your own base. When a name is added with a different base address it will be automatically adjusted to match the standard base address of the database.

#### Delete Names
Regardless of the interaction mode, Names can be selected in the list and right clicked to access the Delete option.

## Data Fields
The database format stores 5 fields of information for each Name entry.

* Category
  * What namespace or area does the function belong to.
* Address
  * Where is the function offset in the disassembler. Note: The Base Address for `FirefallClient.exe` is `0x400000` and all addresses will be displayed as such.
* Name
  * Assumed name of the function.
* Status
  * Accuracy of the assumed name. Level 0 is most accurate while Level 3 is least accurate.
* Comment
  * Additional information about this function.

## Database Format
This tool stores client version specific subroutine Name information in a json file. Database files have a few commented lines at the top to create a header which the tool can easily read back.

Format:
```js
// Version #{DatabaseFormatVersion}
// Firefall DISASM Name Manager Database
// FirefallClient.exe V{TargetClientVersion}
[{ArrayOfObjects}]
```

Example:
```js
// Version #1
// Firefall DISASM Name Manager Database
// FirefallClient.exe V1962
[
  {
    "Category": "tfApplication",
    "Address": "0x6EBA70",
    "Name": "tfApplication::Run",
    "Status": 0,
    "Comment": ""
  },
  {
    "Category": "D3DRenderer",
    "Address": "0x1308500",
    "Name": "d3drenderer::Initialize",
    "Status": 0,
    "Comment": "D3D Renderer Initialize function"
  },
  {
    "Category": "fsDataPaths",
    "Address": "0x16B84F0",
    "Name": "fsDataPaths::FileExists",
    "Status": 0,
    "Comment": "May be part of slFileSystem instead of fsDataPaths"
  },
  {
    "Category": "slini",
    "Address": "0x16DD290",
    "Name": "slini::GetStringWithResult",
    "Status": 1,
    "Comment": "May be part of slParser. (SectionName, VariableName, Found); Found is set to 1 if value is found, 0 if using default"
  }
]
```

## Name Status Level
Names are assigned a "Status" level to help indicate how reliable the given Name might be. Currently these Status Levels do not have official names associated with them. However, the closer to 0 the level the more "accurate" the name is presumed to be. When exporting a database there is an option to select what level of accuracy you want "enabled" in the exported script. In the case of MakeName scripts like IDA Python, this will control when a MakeName statement is commented out or not. All MakeName statements will still be included.

Working table of Status Level meanings:
```
Accurate = 0
Suggested = 1
Potential = 2
Placeholder = 3
```

While most Names will never truly be 100% accurate, any that are essentially "the name" should be considered as Status Level 0.

## Creating A Database
A new database can be created from the `Database > New Database` menu. When creating a database the Base Address will be displayed that all addresses will be stored as. This value cannot be changed and is only displayed as a reminder in the event your own disassembler is using a different base address.

When entering the client version number for the database, it currently is intended to only support for the 4 digit build identifier (ex: `1962`), not the complete version such as `1.7.1962.0`, `Firefall (v1.5.1962`), `beta-1962`, or anything else. This however may be changed at a later date.

## Importing Name Data
This tool supports importing properly formatted JSON files (typically other database files) along with IDA Python and Ghidra Python scripts. These can be imported either as an actual file or as raw text. See the [Supported Formats](#supported-formats) section for a full list of import and export options.

When importing Name data, there is an option to specify the `Base Address` that the source data is using. This is useful for when the source data was made with a disassembler that did not have the client loaded at the standard base address. Data which has a different base address will have the Names automatically updated to be based off the standard `0x400000` address.

### Importing IDA Python Scripts
This tool supports a unique format for these scripts to allow them to be imported and preserve as much useful information as possible.

Format:
```py
# Category: {Name}
# Category_Comment
# {Comment Text}
# {Comment Text Continued} There is no limit to how many lines are included as long as they are not separated by a blank line
# End the Category_Comment block with at least 1 blank line

MakeName(0x{offset}, "{name}") # {Comment for name}
```

The `# Category: {Name}` section will apply to all `MakeName`'s under it until another Category is specified. Leave the `{Name}` field blank to clear a Category and assign the following Names to no Category. Category names are allowed to be reused. However, if multiple contain Category Comments, only the last one will be stored. This will result in the database moving them all next to each other when it imports the script. Exporting the database will then have all of them under a single instance of the Category.

Example:
```py
# Category: tfApplication
# Category_Comment
# Subroutines related to the tfApplication class

MakeName(0x6EBA70, "tfApplication::Run")
MakeName(0x6EB2B0, "tfApplication::DetermineRedhandedBitness")
MakeName(0x6EB590, "tfApplication::ExecuteRedhandedWrapper")
MakeName(0x15E8B30, "tfApplication::InitializeRedhanded")

# Category: Libraries
MakeName(0x6FD280, "tfYouxi::Initialize")
MakeName(0x6FDC20, "tf369::Initialize")
MakeName(0x6FBF90, "tfSteamworks::Initialize")
MakeName(0x6FC180, "tfSteamworks::Shutdown")
MakeName(0x6FE130, "tf369::Shutdown")
MakeName(0x6FD5F0, "tfYouxi::Shutdown")
```

Additionally, `Status Levels` are indicated by prepending a `#` in front of the `MakeName` statement (commenting it out). These can be added up to 3 times to indicate the Status of the name is Level 3. Including more than 3 will result in the line being entirely ignored.

Example:
```py
MakeName(0x6EBA70, "tfApplication::Run") # Status Level 0 name
#MakeName(0x16DD350, "slini::GetInt") # Status Level 1 name
##MakeName(0x11D95B0, "slText::fmt") # Status Level 2 name
###MakeName(0x126E480, "platform_poll_queued_messages") # Status Level 3 name
```

### Importing Ghidra Python Scripts
Just like IDA Python Scripts, Ghidra Python Scripts are supported using a near identical unique format. The only difference is the actual functions used for Ghidra.

Format:
```py
# Category: {Name}
# Category_Comment
# {Comment Text}
# {Comment Text Continued} There is no limit to how many lines are included as long as they are not separated by a blank line
# End the Category_Comment block with at least 1 blank line

getFunctionContaining(toAddr(0x{offset})).setName("{name}", ghidra.program.model.symbol.SourceType.USER_DEFINED) # {Comment for name}
```

Example:
```py
# Category: tfApplication
# Category_Comment
# Subroutines related to the tfApplication class

getFunctionContaining(toAddr(0x6EBA70)).setName("tfApplication::Run", ghidra.program.model.symbol.SourceType.USER_DEFINED)
getFunctionContaining(toAddr(0x6EB2B0)).setName("tfApplication::DetermineRedhandedBitness", ghidra.program.model.symbol.SourceType.USER_DEFINED)

# Category: Libraries
getFunctionContaining(toAddr(0x6FD280)).setName("tfYouxi::Initialize", ghidra.program.model.symbol.SourceType.USER_DEFINED)
getFunctionContaining(toAddr(0x6FDC20)).setName("tf369::Initialize", ghidra.program.model.symbol.SourceType.USER_DEFINED)
```

Ghidra Python Script support is designed to allow using individual lines instead of requiring a complete file. As such, the entire namespace for the `USER_DEFINED` SourceType is used in each line. To reduce the line length, the following modifications can be made to the script file:

1. Add the following import to the top of the file
  * `from ghidra.program.model.symbol.SourceType import *`
2. Replace the fully qualified name (`ghidra.program.model.symbol.SourceType.USER_DEFINED`) in each line to be only `USER_DEFINED`.

## Exporting Name Data
In addition to saving the Names to a database file, this tool will allow you to export the Names to supported formats. Exporting has two key settings to get the correct expected results.

First is the `Enabled Status Level`, this will determine which Names are not commented out based on their Status level. When set to 0, only Names with a Status level of 0 will not be commented out. When set to 1, Names with Status levels 0 or 1 will not be commented out. This only applies to export formats which are scripts. Exporting to JSON will not have any changes based on this setting.

The second setting is the `Base Address`. If the intention is to use this data with a disassembler which has the client loaded at a different base address, set this value to match it. The Update button must be pressed after modifying the value for it to be applied. The current Base Address being used can be found in the window title bar.

Export data is displayed in the text box exactly as it would be written to a file if the "Save to File" button is used. This allows you to copy/paste the content for using in another program without having to write it to a file.

### Exporting JEB Python Scripts
Unlike other supported disassemblers and decompilers, JEB Decompiler will compile Python Scripts into Java before executing them. This results in having the additional requirement that their script entry point's must be named identically to the filename in order to be run. To help ensure this requirement is met, when exporting to this format the script that is generated is a complete file that is ready to use as-is but cannot have sections of it copy/pasted out and easily reused like other supported formats. When saving this export the tool will auto-fill a filename that matches the entry point name of the script.

Example:
```py
#?description=JEB Python MakeName Script for FirefallClient.exe V1962
#?shortcut=

# !==IMPORTANT==!
# Filename must be "JEBScript_FFC_MakeNames_1962.py"

from com.pnfsoftware.jeb.client.api import IScript
from com.pnfsoftware.jeb.core.units import INativeCodeUnit
from com.pnfsoftware.jeb.core.units.code import ICodeUnit

class JEBScript_FFC_MakeNames_1962(IScript):
	def run(self, ctx):
		prj = ctx.getMainProject()
		code = prj.findUnit(INativeCodeUnit)

        # Category: tfApplication
        # Category_Comment
        # Subroutines related to the tfApplication class

        code.getNativeItemAt(0x6EBA70).setName("tfApplication::Run")
        code.getNativeItemAt(0x6EB2B0).setName("tfApplication::DetermineRedhandedBitness")

        # Category: Libraries
		code.getNativeItemAt(0x6FD280).setName("tfYouxi::Initialize")
		code.getNativeItemAt(0x6FDC20).setName("tf369::Initialize")
```
