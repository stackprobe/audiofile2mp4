IF NOT EXIST audiofile2mp4\. GOTO END
CLS
rem �����[�X���� qrum ���܂��B
PAUSE

CALL newcsrr

CALL qq
cx **

CALL _Release.bat /-P

MOVE out\audiofile2mp4.zip S:\�����[�X��\.

START "" /B /WAIT /DC:\home\bat syncRev

CALL qrumauto rel

rem **** AUTO RELEASE COMPLETED ****

:END
