FROM ubuntu:22.04

WORKDIR /app

RUN apt-get update && apt-get install -y dotnet-sdk-8.0

WORKDIR /src
 
COPY ./DockerHelloWorld/ .

RUN dotnet restore "DockerHelloWorld.csproj" -r linux-x64
RUN dotnet build "DockerHelloWorld.csproj" -r linux-x64 -c Release -o /app/build
RUN dotnet publish "DockerHelloWorld.csproj" -r linux-x64 --no-restore --self-contained false -c Release -o /app/publish

WORKDIR /app/publish

ENTRYPOINT ["dotnet", "DockerHelloWorld.dll"]