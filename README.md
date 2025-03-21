# Odontoprev API

## Integrantes
- João Vitor de Santana dos Santos
- Willian Daniel Oliveira Dantas
- Ryan Azanha SS

## Descrição do Projeto
Esta API é uma solução simples baseada na proposta do projeto Odontoprev. Ela implementa dois CRUDs, um para gerenciar **Clientes** e outro para **Procedimentos**, utilizando uma abordagem monolítica com ASP.NET Core Web API e integração com Oracle.

## Arquitetura
- **Monolítico:** Projeto único com separação de camadas (Controllers, Services, Repositories e Models).
- **Design Patterns Utilizados:**
    - **Repository Pattern:** Para abstrair o acesso a dados.
    - **Singleton:** Implementado em `ConfigManager` para exemplificar o padrão.

## Pré-requisitos
- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- Oracle Database configurado e acessível.
- EF Core com provedor Oracle (Oracle.ManagedDataAccess.Core e Microsoft.EntityFrameworkCore.Oracle).

## Instruções para Configuração e Execução

1. **Clonar o repositório:**
   ```bash
   git clone <url-do-repositório>
   cd OdontoprevApi
   
### Repositório

https://github.com/jvs4nt/OdontoprevMVC
