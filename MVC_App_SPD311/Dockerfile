﻿# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /source

# copy csproj and restore as distinct layers
COPY *.sln .
COPY MVC_App_SPD311/*.csproj ./MVC_App_SPD311/
COPY DLL*/.csproj ./DLL/
RUN dotnet restore

# copy everything else and build app
COPY MVC_App_SPD311/. ./MVC_App_SPD311/
WORKDIR /source/MVC_App_SPD311
RUN dotnet publish -c release -o /app --no-restore

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "MVC_App_SPD311.dll"]