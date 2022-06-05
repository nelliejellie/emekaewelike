FROM mcr.microsoft.com/dotnet/sdk:5.0-alpine AS base
WORKDIR /src/
COPY Portfolio.csproj ./
RUN dotnet restore ./Portfolio.csproj
COPY ./ ./
RUN dotnet build -c Release -o ./app/build
RUN dotnet publish -c Release -o ./app/publish

FROM mcr.microsoft.com/dotnet/aspnet:5.0-alpine AS final
WORKDIR /app
COPY --from=base ./src/app/publish ./

EXPOSE 80
EXPOSE 443
CMD ["dotnet", "Portfolio.dll"]