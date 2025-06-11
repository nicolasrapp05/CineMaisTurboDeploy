# Usa a imagem do SDK do .NET 8 para o estágio de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /source

# Copia apenas o arquivo de projeto e restaura as dependências primeiro.
# Isso aproveita o cache de camadas do Docker, acelerando builds futuros.
#
# IMPORTANTE: Verifique se o nome do seu arquivo de projeto é realmente "CineMaisTurbo.csproj".
# Se for diferente, ajuste o nome nos comandos COPY e RUN abaixo.
COPY CineTurbo.csproj .
RUN dotnet restore

# Agora, copia todo o resto do código da aplicação.
COPY . .

# Publica a aplicação, especificando o projeto. O --no-restore usa o cache da etapa anterior.
RUN dotnet publish "CineTurbo.csproj" -c Release -o /app/publish --no-restore

# Estágio final de runtime, usando a imagem ASP.NET que é menor e mais segura
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .

# Ponto de entrada para executar a aplicação
ENTRYPOINT ["dotnet", "CineTurbo.dll"]
