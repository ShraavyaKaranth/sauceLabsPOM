@echo off
cd /d "%~dp0"  REM Navigate to the script's directory

:: Find Chrome Path
for /f "delims=" %%i in ('where chrome') do set "CHROME_PATH=%%i"

:: Open Chrome in debugging mode
start "" "%CHROME_PATH%" --remote-debugging-port=9222 --user-data-dir="%TEMP%\ChromeDebug"

:: Wait for Chrome to start
timeout /t 5 >nul

:: Run tests
call :RunTest "LoginPage"
call :RunTest "ViewItem"
call :RunTest "AddToCart"
call :RunTest "Checkout"
call :RunTest "Checkout2"
call :RunTest "CheckoutOverview"
call :RunTest "ConfirmationPage"

:: Wait before closing Chrome
timeout /t 5 >nul

:: Close Chrome Debugging instance
echo Closing Chrome...
taskkill /F /IM chrome.exe >nul 2>&1
taskkill /F /IM chromedriver.exe >nul 2>&1

exit /b

:RunTest
echo Running TestCategory=%~1...
start cmd /c "dotnet test --filter \"(TestCategory=%~1)\""
exit /b
