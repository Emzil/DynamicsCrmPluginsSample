set current_dir=%1
echo %current_dir%Output

If Not Exist "%current_dir%Output" (
	mkdir %current_dir%Output
) else (
	if exist %current_dir%Output\Geddion.MU.Plugins.dll (
		del /q %current_dir%Output\Geddion.MU.Plugins.dll
		del /q %current_dir%Output\Geddion.MU.Plugins.pdb
	)
)

@echo Merging assembly

"%current_dir%"..\..\ILmerge\ILMerge.exe /closed /allowDup /targetplatform:"v4,C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.2" /out:"%current_dir%\Output\Geddion.MU.Plugins.dll" ^
	"Geddion.MU.Plugins.dll"^
	"Twilio.dll"
	

IF %ErrorLevel% EQU 0 (
    @echo assembly merged into "%current_dir%Output\Geddion.MU.Plugins.dll"
)