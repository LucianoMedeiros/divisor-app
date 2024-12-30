# Divisor APP

> **Objetivo**: Um cliente precisa de um sistema que seja capaz de decompor um número em todos os seus divisores, enumerando também aqueles que forem primos e permitir que seja usada por outros sistemas.

## Roadmap

- Construir a aplicação principal
- Criar testes da aplicação
- Criar Console para utilizar a aplicação
- Criar uma API para disponibilizar a aplicação
- Criar web app para utilizar a aplicação

## Projetos da Solution

| Projeto       | Stack               | Dependência |
| :------------ | :------------------ | :---------- |
| `Application` | `C# e  .NET 8.0`    | -           |
| `Tests`       | `C# e  .NET 8.0`    | Application |
| `API`         | `C# e  .NET 8.0`    | Application |
| `ConsoleApp`  | `C# e  .NET 8.0`    | Application |
| `ReactApp`    | `ReactJS e  ViteJS` | API         |

## Documentação da API

```http
  GET /api/divisor/${number}
```

| Parâmetro | Tipo     | Descrição                           |
| :-------- | :------- | :---------------------------------- |
| `api_key` | `string` | **Obrigatório**. A chave da sua API |

#### Retorna um item

| Parâmetro | Tipo   | Descrição       |
| :-------- | :----- | :-------------- |
| `number`  | `long` | **Obrigatório** |

#### Retorna seus divisores, números primos e ele mesmo

```json
{
  "number": 0,
  "divisors": [],
  "primeDivisors": []
}
```

#### Verifica disponibilidade da API

```http
  GET /api/health
```
