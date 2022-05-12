# TestApp2

Требования
Необходимо чтобы был установлен рантайм 
ASP.NET Core Runtime 6.0.5

Для того что бы развернуть приложение нужно выполнить 

1.Для сборки приложения 

dotnet build TestApp2.sln

2. Установить глобально dotnet-ef

dotnet tool install --global dotnet-ef


3.Для создания базы

dotnet ef database update --project ./TestApp2/TestApp2.csproj


4. Для запуска проекта выполнить

dotnet run --project ./TestApp2/TestApp2.csproj


Приложение будет доступно по адресу 
https://localhost:7283
http://localhost:5283
