# Transação Financeira

Este projeto tem como objetivo realizar a criação e processamento de transações 
financeiras, podendo ser expandido para outros niveis de arquitetura.

Projeto desenvolvido com .Net 6 e utilização de um banco de dados local Sqlite,
possui um swagger para interagir com os enpoints.

## Funcionalidades

- Cadastro de contas
- Cadastro de transações
- Processamento de transações

## Como Rodar

Ao iniciar o projeto use o Package Manager Console e 
navegue até a pasta <b>TransacaoFinanceira.Infrastructure</b>
e execute os comandos:

```bash
Drop-Database
```
Em seguida cria uma nova migration

```bash
Add-Migration nome da sua migration
```
e por fim 

```bash
Update-Database
```

## Contribuição

São bem vindas todas as criticas e sugestões

## License

[MIT](https://choosealicense.com/licenses/mit/)