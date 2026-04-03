FROM mcr.microsoft.com/dotnet/sdk:10.0-alpine AS build
WORKDIR /src
COPY ["bank-core.csproj", "."]
RUN dotnet restore "bank-core.csproj"
COPY . .
RUN dotnet publish "bank-core.csproj" \
    -c Release \
    -o /app/publish \
    -r linux-musl-x64 \
    --self-contained true

FROM mcr.microsoft.com/dotnet/runtime-deps:10.0-alpine AS final
WORKDIR /app
EXPOSE 80
COPY --from=build /app/publish .
ENTRYPOINT ["./bank-core"]