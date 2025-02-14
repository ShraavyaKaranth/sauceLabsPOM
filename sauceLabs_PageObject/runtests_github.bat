@echo off
cd /d "%~dp0"

:: Open Chrome in debugging mode
start "" "C:\Program Files\Google\Chrome\Application\chrome.exe" --remote-debugging-port=9222 --user-data-dir="C:\ChromeDebug"

:: Wait for Chrome to start
choice /T 5 /D Y /N >nul

:: Run all tests sequentially
call :RunTest "LoginPage"
call :RunTest "ViewItem"
call :RunTest "AddToCart"
call :RunTest "Checkout"
call :RunTest "Checkout2"
call :RunTest "CheckoutOverview"
call :RunTest "ConfirmationPage"

:: Wait before closing Chrome
choice /T 5 /D Y /N >nul

:: Close Chrome Debugging instance
echo Closing Chrome...
taskkill /F /IM chrome.exe >nul 2>&1
taskkill /F /IM chromedriver.exe >nul 2>&1

exit /b

:: Function Definition
:RunTest
echo Running TestCategory=%~1...
cmd /c "dotnet test --filter \"(TestCategory=%~1)\""
choice /T 10 /D Y /N >nul
exit /b
