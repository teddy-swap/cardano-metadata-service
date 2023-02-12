FROM mcr.microsoft.com/dotnet/sdk:7.0 AS builder
COPY src/ /build/src
WORKDIR /build/src

RUN dotnet restore
RUN dotnet publish -c Release -o /build/bin

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=builder /build/bin .
EXPOSE 3337
ENTRYPOINT ["dotnet", "TeddySwapCardanoMetadataService.dll"]