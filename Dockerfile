FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /App
# Copy everything
COPY . ./
RUN dotnet restore InumentTestApp.csproj
# Build and publish a release
RUN dotnet publish InumentTestApp.csproj -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /App
COPY --from=build-env /App/out .
ENTRYPOINT ["dotnet", "InumentTestApp.dll"]