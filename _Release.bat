C:\Factory\Tools\RDMD.exe /RC out

COPY /B audiofile2mp4\audiofile2mp4\bin\Release\audiofile2mp4.exe out
COPY /B audiofile2mp4\audiofile2mp4\bin\Release\Chocolate.dll out
COPY /B Converter\Converter\bin\Release\Converter.exe out
COPY /B C:\app\Kit\BmpToCsv\BmpToCsv.exe out
COPY /B C:\app\Kit\ImgTools\ImgTools.exe out
COPY /B C:\app\Kit\ImgTools\ImgTools.exe out

C:\Factory\Tools\xcp.exe doc out
ren out\Config.conf audiofile2mp4.conf
ren out\Readme.txt ƒ}ƒjƒ…ƒAƒ‹.txt

C:\Factory\SubTools\zip.exe /O out audiofile2mp4

IF NOT "%1" == "/-P" PAUSE
