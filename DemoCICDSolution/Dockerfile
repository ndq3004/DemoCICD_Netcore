FROM mcr.microsoft.com/dotnet/aspnet:5.0
COPY /bin/Release/net6.0 app/
WORKDIR /app
ENTRYPOINT ["dotnet", "aspnetapp.dll"]