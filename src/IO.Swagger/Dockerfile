FROM microsoft/dotnet:2.2-sdk AS build-env

ENV DOTNET_CLI_TELEMETRY_OPTOUT 1

WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN ["dotnet", "restore"]

# Copy everything else and build
COPY . ./

RUN ["dotnet", "publish", "-c", "Release", "-o", "out"]

# Build runtime image
FROM microsoft/dotnet:2.2-aspnetcore-runtime
WORKDIR /app
COPY --from=build-env /app/out .

ENTRYPOINT ["dotnet", "IO.Swagger.dll"]