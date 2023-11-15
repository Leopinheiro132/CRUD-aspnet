# Minha API de Usuários em ASP.NET

Minha primeira API em ASP.NET Esta é uma aplicação muito simples que realiza operações CRUD (Create, Read, Update, Delete) em uma coleção de usuários armazenada em um banco de dados MongoDB.

## Rotas Disponíveis

- **GET /api/usuario**: Obtém todos os usuários.
- **GET /api/usuario/{id}**: Obtém um usuário específico por ID.
- **POST /api/usuario**: Adiciona um novo usuário.
- **PUT /api/usuario/{id}**: Atualiza um usuário existente por ID.
- **DELETE /api/usuario/{id}**: Deleta um usuário por ID.

## Como Usar

1. **Instalação e Configuração:**
   - Certifique-se de ter o [ASP.NET Core SDK](https://dotnet.microsoft.com/download) instalado.
   - Clone este repositório em seu ambiente local.

2. **Configuração do Banco de Dados:**
   - Certifique-se de ter um servidor MongoDB em execução.
   - Atualize a string de conexão no arquivo `appsettings.json` com os detalhes do seu banco de dados.

3. **Execução da Aplicação:**
   - Abra um terminal na pasta do projeto e execute o comando `dotnet run`.
   - A API estará acessível em `https://localhost:5001` por padrão.

4. **Testando as Rotas:**
   - Use uma ferramenta como [Postman](https://www.postman.com/) ou [cURL](https://curl.se/) para testar as rotas da API.
   - Exemplos:
     - Para obter todos os usuários: `GET https://localhost:5001/api/usuario`
     - Para adicionar um usuário: `POST https://localhost:5001/api/usuario` com corpo JSON contendo os detalhes do usuário.

5. **Observações Importantes:**
   - Esta é uma API muito simples destinada apenas para fins educacionais.
   - Certifique-se de entender as implicações de segurança ao desenvolver aplicações mais complexas.

## Contribuições
Contribuições são bem-vindas! Sinta-se à vontade para abrir issues, enviar pull requests ou fornecer feedback.

## Licença
Este projeto está licenciado sob a Licença MIT - veja o arquivo [LICENSE](LICENSE) para detalhes.
