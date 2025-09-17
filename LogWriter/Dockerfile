# Use .NET 8 SDK to build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copy csproj and restore
COPY *.csproj ./
RUN dotnet restore

# Copy rest of files and build
COPY . ./
RUN dotnet publish -c Release -o /app

# Use runtime image
FROM mcr.microsoft.com/dotnet/runtime:9.0
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "LogWriter.dll"]
