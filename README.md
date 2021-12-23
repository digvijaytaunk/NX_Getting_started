# NXOpen with C#

## References
Add references from 
`C:\Program Files\Siemens\NX 12.0\NXBIN\managed\`

`NXOpen.dll`

`NXOpen.Guide.dll`

`NXOpen.UF.dll`

`NXOpen.Utilities.dll`

`NXOpenUI.dll`

## Run dll

In NX App goto

File -> Execute -> NX Open 


## Attach a debuger in Visual Studio

1. Set breakpoint(s) in in your NX Open code in the Visual Studio editor
2. Compile your NX Open code into a .dll
3. Start NX
4. In Visual Studio, pick Tools, Attach to Process
5. Find the NX process (ugraf.exe) and select it as the process to attach to
6. Run the NX Open dll in NX (File, Execute NXOpen)

The code will run until hitting the first break point, then it will pause and you can interrogate variables, etc. in Visual Studio.

## References

https://docs.plm.automation.siemens.com/tdoc/nx/10/nx_api#uid:index_nxopen_prog_guide:id1142156:purpose

https://docs.plm.automation.siemens.com/data_services/resources/nx/1872/nx_api/common/en_US/graphics/fileLibrary/nx/nxopen/NXOpen_Getting_Started.pdf
