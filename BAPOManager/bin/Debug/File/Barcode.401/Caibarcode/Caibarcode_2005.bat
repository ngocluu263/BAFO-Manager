@ECHO OFF
Echo Cai bar code
copy .\CRUFLMW6.dll "C:\Program Files\Common Files\Business Objects\2.7\bin\" >null
cd C:\WINDOWS\system32
regsvr32 "C:\Program Files\Common Files\Business Objects\2.7\bin\CRUFLMW6.dll" 
@ECHO ON