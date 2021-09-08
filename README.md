# User Manual
## Installation:
1) Follow the link: https://github.com/Ziggchik/Who_wants_to_be_a_millionaire_show
2) Press green button "Code"
3) In the drop-down list that opens, select how you want to install the project
### Download Zip:
1) Download Visual Studio. link for download: https://visualstudio.microsoft.com/ru/downloads
2) Press button "Download Zip"
3) The "download" folder will contain the downloaded archive, unzip it to any place on your computer
4) In Unzip files open  "Calculator.sln"
6) Save open project (Ctrl+Shift+S) in any place on you computer
7) Press buttons combination "Shift+F5" to launch application
### Open with Visual Stido:
1) Download Visual Studio. link for download: https://visualstudio.microsoft.com/ru/downloads
2) Press button "Open with Visual Studio"
3) In Visual Studio click to button "Clone repository"
4) Solution will donwload from repository and you can save project (Ctrl+Shift+S) in any place on you computer
### Download with command:
1) Press button combination "Win+R" and write "cmd"
2) Write this commands:
* git clonehttps://github.com/Ziggchik/Who_wants_to_be_a_millionaire_show.git
* cd Who_wants_to_be_a_millionaire_show
* dotnet build
* dotnet run
3) After that application will start
## How to use:
1) Run application
2) Choose you answers for questions.
3) Press button "Отправить ответы"
4) In the window that opens, you can view the results of your game
## Architecture:
1) The project create with ASP.NET Core 2.1 MVK and using language C#.
2) The project uses Microsoft.EntityFrameworkCore 2.1.1
3) The project uses addons for Microsoft.EntityFrameworkCore (Tools, Proxies, SqlServer)
4) Database create on SqlServer and use query language T-sql
5) Database connection release in .json file appsettings.json
## Application Updates:
In the near future in application new features will be added to the application:
1) Class with new unit-tests
2) Application structure Question-Answer
3) Tip 50/50
4) New design
5) User function non-combustible amount, random questions and questions ammount.
