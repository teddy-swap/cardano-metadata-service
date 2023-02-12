<!-- Improved compatibility of back to top link: See: https://github.com/othneildrew/Best-README-Template/pull/73 -->
<a name="readme-top"></a>
<!--
*** Thanks for checking out the Best-README-Template. If you have a suggestion
*** that would make this better, please fork the repo and create a pull request
*** or simply open an issue with the tag "enhancement".
*** Don't forget to give the project a star!
*** Thanks again! Now go create something AMAZING! :D
-->


<!-- PROJECT LOGO -->
<br />
<div align="center">

  <h3 align="center">Cardano Token Metadata Service API</h3>

  <p align="center">
    A .NET/C# based Cardano Token Registry that is compatible with the <a href="https://github.com/cardano-foundation/cardano-token-registry" target="_blank">Cardano Foundation Token Registry</a> format and <a href="https://github.com/cardano-foundation/CIPs/tree/master/CIP-0026">CIP26 metadata standard</a>.
  </p>
</div>



<!-- ABOUT THE PROJECT -->
## About The Project

This ia simple Cardano Offchain Token Registry API Server implementation written in .NET/C#. For more information about the Cardano Offchain Token Registry, check out the official Cardano Foundation repository: https://github.com/cardano-foundation/cardano-token-registry.

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- GETTING STARTED -->
## Getting Started

### Prerequisites

You will need to install .NET 7 from here: https://dotnet.microsoft.com/en-us/download/dotnet/7.0

We only tested it with this specific version:
```
dotnet --version
7.0.102
```

### Build and Run

Download the source code:

```bash
git clone https://github.com/teddy-swap/cardano-metadata-service.git
cd cardano-metadata-service/src
```

Set config via environment variables:

```bash
# Add your postgres connection details
export CONNECTIONSTRINGS__TOKENMETADATASERVICE="Host=postgres-host;Database=postgres;Username=postgres;Password=postgres;Port=5432"

# The repository details where the token metadata is hosted
export REGISTRYOWNER="cardano-foundation"
export REGISTRYREPO="cardano-token-registry"

# Github access token to pull data from Github API, this is used to check for new commits in the token metadata repository
# Check documentation for more information: https://docs.github.com/en/authentication/keeping-your-account-and-data-secure/creating-a-personal-access-token
export GITHUBPAT=""
```

Run the app:

```bash
dotnet restore
dotnet run
```

We also provide a Dockerfile for production deployment.

```Dockerfile
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS builder
COPY src/ /build/src
WORKDIR /build/src

RUN dotnet restore
RUN dotnet publish -c Release -o /build/bin

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=builder /build/bin .
EXPOSE 1337
ENTRYPOINT ["dotnet", "TeddySwapCardanoMetadataService.dll"]
```

<p align="right">(<a href="#readme-top">back to top</a>)</p>


