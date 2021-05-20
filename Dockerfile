FROM mcr.microsoft.com/dotnet/sdk:5.0

WORKDIR /src
COPY /add add
COPY /addtests addtests
WORKDIR /src/addtests

CMD ["dotnet","test"]
