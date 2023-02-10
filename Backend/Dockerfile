# Working from root Backend directory
FROM mcr.microsoft.com/dotnet/sdk:6.0

RUN mkdir -p /backend

WORKDIR /backend/UserBackend/API

EXPOSE 7066

Copy . /backend/

CMD ["dotnet", "run"]
 