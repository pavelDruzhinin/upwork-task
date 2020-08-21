FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS publish
WORKDIR /src

COPY . .
RUN dotnet publish "UpworkTask.Console/UpworkTask.Console.csproj" -c Release -o /app

FROM mcr.microsoft.com/dotnet/core/runtime:3.1 AS base

WORKDIR /app
COPY --from=publish /app .

ENTRYPOINT ["dotnet", "UpworkTask.Console.dll"]