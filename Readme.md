# Sample Entity Framework CLI project
## Set up


1. Clone the project
2. Start up a sql server instance by running this:

```
sudo docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=<YourStrong@Passw0rd>" \
   -p 1433:1433 --name sql1 \
   -d mcr.microsoft.com/mssql/server:2019-CU5-ubuntu-18.04
```

3. Run `dotnet restore` to get all the dependencies installed.
4. Run `dotnet ef database update` to apply the migrations to the database