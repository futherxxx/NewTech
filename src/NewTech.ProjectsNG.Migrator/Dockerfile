#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/NewTech.ProjectsNG.Migrator/NewTech.ProjectsNG.Migrator.csproj", "src/NewTech.ProjectsNG.Migrator/"]
COPY ["src/NewTech.ProjectsNG.EntityFrameworkCore/NewTech.ProjectsNG.EntityFrameworkCore.csproj", "src/NewTech.ProjectsNG.EntityFrameworkCore/"]
COPY ["src/NewTech.ProjectsNG.Core/NewTech.ProjectsNG.Core.csproj", "src/NewTech.ProjectsNG.Core/"]
COPY ["src/NewTech.ProjectsNG.Core.Shared/NewTech.ProjectsNG.Core.Shared.csproj", "src/NewTech.ProjectsNG.Core.Shared/"]
RUN dotnet restore "src/NewTech.ProjectsNG.Migrator/NewTech.ProjectsNG.Migrator.csproj"
COPY . .
WORKDIR "/src/src/NewTech.ProjectsNG.Migrator"
RUN dotnet build "NewTech.ProjectsNG.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NewTech.ProjectsNG.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NewTech.ProjectsNG.Migrator.dll"]
