#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/NewTech.ProjectsNG.Web.Mvc/NewTech.ProjectsNG.Web.Mvc.csproj", "src/NewTech.ProjectsNG.Web.Mvc/"]
COPY ["src/NewTech.ProjectsNG.Web.Core/NewTech.ProjectsNG.Web.Core.csproj", "src/NewTech.ProjectsNG.Web.Core/"]
COPY ["src/NewTech.ProjectsNG.Application/NewTech.ProjectsNG.Application.csproj", "src/NewTech.ProjectsNG.Application/"]
COPY ["src/NewTech.ProjectsNG.Application.Shared/NewTech.ProjectsNG.Application.Shared.csproj", "src/NewTech.ProjectsNG.Application.Shared/"]
COPY ["src/NewTech.ProjectsNG.Core.Shared/NewTech.ProjectsNG.Core.Shared.csproj", "src/NewTech.ProjectsNG.Core.Shared/"]
COPY ["src/NewTech.ProjectsNG.Core/NewTech.ProjectsNG.Core.csproj", "src/NewTech.ProjectsNG.Core/"]
COPY ["src/NewTech.ProjectsNG.EntityFrameworkCore/NewTech.ProjectsNG.EntityFrameworkCore.csproj", "src/NewTech.ProjectsNG.EntityFrameworkCore/"]
COPY ["src/NewTech.ProjectsNG.GraphQL/NewTech.ProjectsNG.GraphQL.csproj", "src/NewTech.ProjectsNG.GraphQL/"]
RUN dotnet restore "src/NewTech.ProjectsNG.Web.Mvc/NewTech.ProjectsNG.Web.Mvc.csproj"
COPY . .
WORKDIR "/src/src/NewTech.ProjectsNG.Web.Mvc"
RUN dotnet build "NewTech.ProjectsNG.Web.Mvc.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NewTech.ProjectsNG.Web.Mvc.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NewTech.ProjectsNG.Web.Mvc.dll"]
