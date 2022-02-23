FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ShoppingCartKata/ShoppingCartKata.csproj", "ShoppingCartKata/"]
RUN dotnet restore "ShoppingCartKata/ShoppingCartKata.csproj"
COPY . .
WORKDIR "/src/ShoppingCartKata"
RUN dotnet build "ShoppingCartKata.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ShoppingCartKata.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ShoppingCartKata.dll"]
