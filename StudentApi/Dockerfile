FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-bionic
COPY dist /app
WORKDIR /app
EXPOSE 80/tcp
EXPOSE 443/tcp
ENTRYPOINT ["dotnet", "StudentApi.dll"]