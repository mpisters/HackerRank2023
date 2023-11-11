FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["HackerRank/HackerRank.csproj", "HackerRank/"]
RUN dotnet restore "HackerRank/HackerRank.csproj"
COPY . .
WORKDIR "/src/HackerRank"
RUN dotnet build "HackerRank.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HackerRank.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HackerRank.dll"]
