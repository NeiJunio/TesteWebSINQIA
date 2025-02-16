# <p style="text-align: center; font-size: 40px; color:rgb(255, 114, 62);">Teste Web - SINQIA</p>

## 📝 Descrição
<p style="text-align: justify;">
Este é um projeto ASP.NET Core MVC desenvolvido para o Teste Técnico da SINQIA. Consiste em um sistema para gerenciamento de pontos turísticos, sendo possível cadastrar, listar, editar, ver detalhes e excluir pontos turísticos, garantindo um controle eficiente dessas informações.
</p>

<br>

## 💻 Tecnologias Utilizadas
- .NET 8.0

- ASP.NET Core MVC

- Entity Framework Core

- SQL Server

- Bootstrap

- CSS (Cascading Style Sheets)

- jQuery

<br>

## 📁 Estrutura do Projeto

```bash
neijunio-testewebsinqia/
├── README.md
├── TesteWebSINQIA.sln
└── TesteWebSINQIA/
    ├── Program.cs
    ├── TesteWebSINQIA.csproj
    ├── appsettings.Development.json
    ├── appsettings.json
    ├── Controllers/
    │   ├── HomeController.cs    // Controla a página inicial
    │   └── ListaPontosTuristicosController.cs    // CRUD dos pontos turísticos
    ├── Data/
    │   └── AppDbContext.cs     // Contexto do banco de dados.
    ├── Migrations/
    │   ├── 20250211133835_CriacaoDoBanco.Designer.cs
    │   ├── 20250211133835_CriacaoDoBanco.cs
    │   └── AppDbContextModelSnapshot.cs
    ├── Models/
    │   ├── ErrorViewModel.cs
    │   └── PontosTuristicosModel.cs    // Representa um ponto turístico.
    ├── Views/    // Contém as views (páginas HTML).
    │   ├── Home/
    │   │   ├── Index.cshtml
    │   │   └── Privacy.cshtml
    │   ├── ListaPontosTuristicos/
    │   │   ├── Cadastrar.cshtml
    │   │   ├── Detalhes.cshtml
    │   │   ├── Editar.cshtml
    │   │   └── Excluir.cshtml
    │   └── Shared/
    │       ├── Error.cshtml
    │       ├── _Layout.cshtml
    │       └── _ValidationScriptsPartial.cshtml
    ├── wwwroot/    // Arquivos estáticos, como CSS, Js e libs externas.
    │   ├── css/
    │   ├── js/
    │   └── lib/
    └── Properties/
        └── launchSettings.json
```

<br>

## 🛠️ Pré-requisitos para rodar o programa

- .NET 8 SDK ou .NET 9 SDK ( [Download](https://dotnet.microsoft.com/en-us/download) )

- SQL Server ( [Download](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads) )

- SQL Server Management Studio ( [Download](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16) )

- Visual Studio 2022 (recomendado) ( [Download](https://visualstudio.microsoft.com/pt-br/vs/community/) )

<br>
<br>

## 🚀 Como rodar o projeto

### 1. Clone o repositório
   ```bash
    git clone https://github.com/NeiJunio/TesteWebSINQIA.git
   ```

### 2. Acesse a pasta do projeto
   ```bash
   cd .\TesteWebSINQIA\
   ```

### 3. Configure o banco de dados
* 1-  No arquivo <strong><i>appsettings.json<i></strong>, configure a string de conexão:
   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Server=SEU_SERVIDOR;Database=TesteWebSINQIA;User Id=SEU_USUARIO;Password=SUA_SENHA;Trusted_Connection=True;TrustServerCertificate=True;"

    // UserId e Senha somente se for exigência do banco
   }
   ```

* 2- No terminal, instale todas as dependências do projeto:
   ```bash
    dotnet restore
   ```

* 3- Instale a Ferramenta CLI dotnet-ef (gloabalmente)
   ```bash
    dotnet tool install --global dotnet-ef
   ```

    se necessário, restaure as ferramentas locais com  `dotnet tool restore`
    <br>
    <!-- <br> -->

* 4- Aplique as migrations e atualize o banco de dados:
   ```bash
    dotnet ef database update
   ```

* 5- Rode o projeto:
   ```bash
    dotnet run
   ```

    ou pressione  `F5`

<br>

* <p>OBSERVAÇÃO: Se o comando "<i>dotnet restore</i>" não instalar as dependências completas, execute os seguintes comandos no terminal:</p>
  
   ```sh
    dotnet add package Microsoft.EntityFrameworkCore
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer
    dotnet add package Microsoft.EntityFrameworkCore.Tools
    dotnet add package Microsoft.EntityFrameworkCore.Design
   ```

<br>

## 🔧 Funcionalidades

* Listagem de pontos turísticos.

* Visualização de detalhes de um determinado ponto turístico

* Cadastro de novos pontos turísticos.

* Edição e exclusão de registros.

* Validação de formulários.

<br>

## 🤝 Contribuição

Se quiser contribuir, siga os passos:

1. Fork este repositório.

2. Crie uma branch com sua funcionalidade (`git checkout -b minha-feature`).

3. Commit suas mudanças (`git commit -m 'feat: minha nova feature'`).

4. Envie para o repositório (`git push origin minha-feature`).

5. Abra um <strong><i>Pull Request.</i></strong>
