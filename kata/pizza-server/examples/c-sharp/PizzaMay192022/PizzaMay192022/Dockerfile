﻿FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["PizzaMay192022/PizzaMay192022.csproj", "PizzaMay192022/"]
RUN dotnet restore "PizzaMay192022/PizzaMay192022.csproj"
COPY . .
WORKDIR "/src/PizzaMay192022"
RUN dotnet build "PizzaMay192022.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PizzaMay192022.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PizzaMay192022.dll"]
