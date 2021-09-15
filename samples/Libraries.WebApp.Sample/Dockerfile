#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["samples/Libraries.WebApp.Sample/Libraries.WebApp.Sample.csproj", "samples/Libraries.WebApp.Sample/"]
RUN dotnet restore "samples/Libraries.WebApp.Sample/Libraries.WebApp.Sample.csproj"
COPY . .
WORKDIR "/src/samples/Libraries.WebApp.Sample"
RUN dotnet build "Libraries.WebApp.Sample.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Libraries.WebApp.Sample.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Libraries.WebApp.Sample.dll"]