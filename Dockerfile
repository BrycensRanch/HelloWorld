# Learn about building .NET container images:
# https://github.com/dotnet/dotnet-docker/blob/main/samples/README.md
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:9.0-alpine AS build
RUN apk add --no-cache clang build-base zlib-dev
ARG TARGETARCH
WORKDIR /source

# Bring the project into the container with beautiful grace...
COPY . . 

RUN dotnet restore -a $TARGETARCH

RUN dotnet publish -a $TARGETARCH -o /app


# Enable globalization and time zones:
# https://github.com/dotnet/dotnet-docker/blob/main/samples/enable-globalization.md
# final stage/image
FROM alpine
WORKDIR /app

COPY --from=build /app .

RUN apk add --no-cache icu tini

ENTRYPOINT ["/sbin/tini", "./HelloWorld"]