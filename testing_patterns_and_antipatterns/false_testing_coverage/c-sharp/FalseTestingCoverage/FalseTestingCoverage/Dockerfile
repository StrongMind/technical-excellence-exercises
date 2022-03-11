FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["FalseTestingCoverage/FalseTestingCoverage.csproj", "FalseTestingCoverage/"]
RUN dotnet restore "FalseTestingCoverage/FalseTestingCoverage.csproj"
COPY . .
WORKDIR "/src/FalseTestingCoverage"
RUN dotnet build "FalseTestingCoverage.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FalseTestingCoverage.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FalseTestingCoverage.dll"]
