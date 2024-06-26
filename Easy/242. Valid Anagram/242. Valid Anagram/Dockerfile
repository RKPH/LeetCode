FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["242. Valid Anagram/242. Valid Anagram.csproj", "242. Valid Anagram/"]
RUN dotnet restore "242. Valid Anagram/242. Valid Anagram.csproj"
COPY . .
WORKDIR "/src/242. Valid Anagram"
RUN dotnet build "242. Valid Anagram.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "242. Valid Anagram.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "242. Valid Anagram.dll"]
