# Person CRUD API

Este projeto implementa uma API de CRUD usando ASP.NET Core, C# e SQLite. A API permite criar, ler, atualizar e excluir pessoas, com um **soft delete** (marcando as pessoas como inativas em vez de removê-las).

## Funcionalidades
- Criar uma pessoa
- Listar todas as pessoas
- Atualizar o nome de uma pessoa
- Excluir (soft delete) uma pessoa
***
  ![Tela Geral](Imagens/1.png)

## Endpoints

### 1. Criar Pessoa
- Método: `POST`
- URL: `/person`
- Corpo: `{ "name": "Nome" }`
- Resposta: `{ "id": "guid", "name": "Nome", "isActive": true }`
  
### 2. Listar Pessoas
- Método: `GET`
- URL: `/person`
- Resposta: Lista de pessoas com `id`, `name` e `isActive`.

### 3. Atualizar Pessoa
- Método: `PUT`
- URL: `/person/{id}`
- Corpo: `{ "name": "Novo Nome" }`
- Resposta: `{ "id": "guid", "name": "Novo Nome", "isActive": true }`

### 4. Excluir Pessoa (Soft Delete)
- Método: `DELETE`
- URL: `/person/{id}`
- Resposta: `{ "message": "Person marked as inactive" }`
***

![Soft Delete](Imagens/2.png)
## Banco de Dados
Usa **SQLite** como banco de dados. O campo `isActive` é alterado para `false` quando uma pessoa é excluída (soft delete).

## Instalação

1. Clone o repositório:  
   `git clone https://github.com/usuario/repositorio.git`

2. Navegue até o projeto:  
   `cd nome-do-projeto`

3. Restaure as dependências:  
   `dotnet restore`

4. Aplique as migrações:  
   `dotnet ef migrations add InitialCreate`  
   `dotnet ef database update`

5. Execute o projeto:  
   `dotnet run`

A API estará disponível em `https://localhost:5001`.


