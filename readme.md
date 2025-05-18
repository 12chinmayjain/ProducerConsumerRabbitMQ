#  RabbitMQ Producer-Consumer Demo (.NET MVC + Console)

##  Overview

This project demonstrates a simple **Producer-Consumer** setup using **RabbitMQ**:

- **Producer**: ASP.NET MVC application that sends messages to a RabbitMQ queue.
- **Consumer**: Console application that listens to and processes messages from the queue.
- **Message Queue**: RabbitMQ queue named `BasicTest`.

---

##  Technologies Used

- .NET 6/7/8
- ASP.NET MVC (Producer)
- Console App (Consumer)
- RabbitMQ
- Docker (for running RabbitMQ locally)

---

## System Requirements

- [.NET SDK](https://dotnet.microsoft.com/en-us/download) (6 or later)
- [Docker](https://www.docker.com/) (to run RabbitMQ)
- Visual Studio 2022+
- Git

---

## Running RabbitMQ with Docker

```bash
docker run -d --hostname rabbitmq --name rabbitmq -p 5672:5672 -p 15672:15672 rabbitmq:3-management
