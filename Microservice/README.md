# Microsserviço: Catalogo

- dotner sdk: 5.0
- Docker

## 1 - Criando Projeto:

    dotnet new webapi -o Microservice --no-https

## 2 - Docker:

    docker build -t microservice . 

    docker container run -it --rm -p 3000:80 --name microservicecontainer microservice

    
