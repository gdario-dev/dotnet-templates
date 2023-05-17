# --- builder ------------------------------------------------------------------
FROM mcr.microsoft.com/dotnet/sdk:7.0-alpine AS builder
RUN mkdir app
RUN mkdir app/src
COPY src app/src
COPY banking-challenge.sln app
WORKDIR app

RUN dotnet restore
RUN dotnet publish -c Release -o out

# --- second stage -------------------------------------------------------------
FROM mcr.microsoft.com/dotnet/aspnet:7.0-alpine as runner
WORKDIR app
COPY --from=builder app/out .

ENV ASPNETCORE_URLS=http://*:6000
ENV ASPNETCORE_ENVIRONMENT="Production"
EXPOSE 6000

ENTRYPOINT [ "dotnet", "Application.Api.dll" ]