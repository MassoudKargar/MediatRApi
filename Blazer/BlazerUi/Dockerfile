#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Blazer/BlazerUi/BlazerUi.csproj", "Blazer/BlazerUi/"]
RUN dotnet restore "Blazer/BlazerUi/BlazerUi.csproj"
COPY . .
WORKDIR "/src/Blazer/BlazerUi"
RUN dotnet build "BlazerUi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BlazerUi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BlazerUi.dll"]