# GameRunner API

## Starting the MySQL Server
```powershell
  $password = "root"
  docker run --name mysql -p 3306:3306 -e MYSQL_ROOT_PASSWORD=$password -d -v sqlvolume:/var/opt/mysql mysql:latest
```

## Starting the MSSQL (Optional)
```powershell
  $password = "root"
  docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=root" -p 1433:1433 -v sqlvolume:/var/opt/mssql --name mssql -d --rm mcr.microsoft.com/mssql/server:2022-latest
```

## Setting the Connection string to secret manager
```powershell
$sa_password="root"
dotnet user-secrets set "ConnectionStrings:GameStoreContext" "Server=localhost; Port=3306; Database=GameStore; User=root; Password=root;"
```

## How to run Migrations ?
```powershell
  dotnet ef migrations add migrationName --output-dir Data/Migrations
```
## How to update the Database
```powershell
  dotnet ef database update
```