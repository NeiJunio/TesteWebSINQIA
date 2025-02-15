# Teste Web - SINQIA

## Descrição
<p style="text-align: justify; margin-bottom:3rem">
Este é um projeto ASP.NET Core MVC desenvolvido para o Teste Técnico da SINQIA. Consiste em um sistema para gerenciamento de pontos turísticos, sendo possível cadastrar, listar, editar, ver detalhes e excluir pontos turísticos, garantindo um controle eficiente dessas informações.
</p>

<hr style="margin-bottom:3rem"/>

## Tecnologias Utilizadas
- .NET 8.0

- ASP.NET Core MVC

- Entity Framework Core

- SQL Server

- Bootstrap

- CSS (Cascading Style Sheets)

- jQuery

<hr style="margin:3rem 0"/>


## 📁 Estrutura do Projeto

<!-- ```bash
neijunio-testewebsinqia/
├── README.md
├── TesteWebSINQIA.sln
└── TesteWebSINQIA/
    ├── Program.cs
    ├── TesteWebSINQIA.csproj
    ├── appsettings.Development.json
    ├── appsettings.json
    ├── Controllers/
    │   ├── HomeController.cs
    │   └── ListaPontosTuristicosController.cs
    ├── Data/
    │   └── AppDbContext.cs
    ├── Migrations/
    │   ├── 20250211133835_CriacaoDoBanco.Designer.cs
    │   ├── 20250211133835_CriacaoDoBanco.cs
    │   └── AppDbContextModelSnapshot.cs
    ├── Models/
    │   ├── ErrorViewModel.cs
    │   └── PontosTuristicosModel.cs
    ├── Views/
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
    ├── wwwroot/
    │   ├── css/
    │   ├── js/
    │   └── lib/
    └── Properties/
        └── launchSettings.json
``` -->

<hr style="margin:3rem 0"/>

# 🛠️ Pré-requisitos para rodar o programa

- .NET 8 SDK ( [Download](https://dotnet.microsoft.com/en-us/download) )

- SQL Server ( [Download](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads) )

- SQL Server Management Studio ( [Download](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16) )

- Visual Studio 2022 (recomendado) ( [Download](https://visualstudio.microsoft.com/pt-br/vs/community/) )

<hr style="margin:3rem 0"/>

# 🚀 Como rodar o projeto

### 1. Clonar o repositório
   ```bash
    git clone https://github.com/NeiJunio/TesteWebSINQIA.git
   ```

### 2. Acesse a pasta do projeto
   ```bash
   cd .\TesteWebSINQIA\
   ```
<!-- <br> -->

### 3. Configurar o banco de dados
* 1-  No arquivo appsettings.json, configure a string de conexão:
   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Server=SEU_SERVIDOR;Database=TesteWebSINQIA;User Id=SEU_USUARIO;Password=SUA_SENHA;Trusted_Connection=True;TrustServerCertificate=True;"

    // UserId e Senha somente se for exigência do banco
   }
   ```

* 2- No terminal, instalar todas as dependências do projeto:
   ```bash
    dotnet restore
   ```

* 3- Aplicar as migrations e atualizar o banco de dados:
   ```bash
    dotnet ef database update
   ```

* 4- Rodar o projeto:
   ```bash
    dotnet run
   ```

    ou se estiver usando o Visual Studio, pressione  `F5`




* <p>OBSERVAÇÃO: Se o comando "<i>dotnet restore</i>" não instalar as dependências do Entity Framework, execute os seguintes comandos no terminal:</p>
  
   ```sh
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer
    dotnet add package Microsoft.EntityFrameworkCore.Tools
    dotnet add package Microsoft.EntityFrameworkCore.Design
   ```