
# 🚀 Projeto BlazorVendasTB

O BlazorVendasTB é um sistema de gerenciamento de vendas desenvolvido com o framework Blazor da Microsoft. Este projeto tem como objetivo principal simplificar e otimizar o processo de vendas, permitindo o cadastro e controle de clientes, funcionários, produtos e pedidos. Ele foi construído utilizando tecnologias modernas da plataforma .NET para oferecer uma aplicação web interativa e eficiente. As principais tecnologias utilizadas incluem Blazor (ASP.NET Core) para o frontend, C# para a lógica de negócio e Entity Framework Core para a persistência de dados em um banco de dados SQL Server.

### ✨ Funcionalidades

* **Gestão de Clientes:** 👥 Cadastro, edição, exclusão e visualização de informações de clientes.
* **Gestão de Funcionários:** 👨‍💼👩‍💼 Cadastro, edição, exclusão e visualização de informações de funcionários.
* **Gestão de Produtos:** 📦 Cadastro, edição, exclusão e visualização de produtos com detalhes como nome, descrição, quantidade em estoque, unidade de medida e preço unitário.
* **Gestão de Pedidos:** 🛒 Registro de novos pedidos, associando clientes, funcionários e produtos, com cálculo do valor total.
* **Gestão de Itens de Venda:** 📊 Adição e remoção de produtos em um pedido, controlando a quantidade e o preço unitário.

### 🏗️ Arquitetura

O `BlazorVendasTB` segue uma arquitetura monolítica, onde todos os componentes da aplicação (interface do usuário, lógica de negócios e acesso a dados) estão contidos em uma única base de código e implantados como uma única unidade. A organização do projeto é estruturada em pastas que separam as diferentes responsabilidades, como:

* **Entities:** Contém as classes que representam as entidades de domínio do sistema, como Cliente, Funcionario, Produto, Pedido e ItemVenda.
* **Data/Context:** Inclui o contexto do banco de dados (SQLServerContext.cs), responsável pela interação com o SQL Server usando o Entity Framework Core.
* **Service/Interface:** Define as interfaces para os serviços de aplicação (ex: IClienteService, IProdutoService), estabelecendo contratos para as operações de negócio.
* **Service/Implementation:** Contém as implementações concretas dos serviços definidos nas interfaces, onde a lógica de negócio e a interação com o banco de dados são realizadas.

### 🗄️ Entidades

O banco de dados `bdVendasTB` é composto pelas seguintes entidades principais:

* **`tbCliente`**
    * `id` (int, IDENTITY): Identificador único do cliente.
    * `nome` (nvarchar): Nome completo do cliente.
    * `cpfCnpj` (nvarchar): CPF ou CNPJ do cliente.
    * `email` (nvarchar): Endereço de e-mail do cliente.
    * `telefone` (nvarchar): Número de telefone do cliente.
    * `endereco` (nvarchar): Endereço do cliente.

* **`tbFuncionario`**
    * `id` (int, IDENTITY): Identificador único do funcionário.
    * `cpf` (nvarchar): CPF do funcionário.
    * `email` (nvarchar): Endereço de e-mail do funcionário.
    * `cargo` (nvarchar): Cargo do funcionário.
    * `salario` (decimal): Salário do funcionário.
    * `dataAdmissao` (datetime): Data de admissão do funcionário.

* **`tbItemVenda`**
    * `produtoId` (int, IDENTITY): Identificador do produto na venda (chave primária).
    * `vendaId` (int): Identificador da venda a que o item pertence.
    * `quantidadeProduto` (int): Quantidade do produto vendida.
    * `precoUnitario` (decimal): Preço unitário do produto no momento da venda.

* **`tbPedido`**
    * `id` (int, IDENTITY): Identificador único do pedido.
    * `dataPedido` (datetime): Data em que o pedido foi realizado.
    * `funcionarioId` (int): Identificador do funcionário que registrou o pedido.
    * `clienteId` (int): Identificador do cliente que realizou o pedido.
    * `valorTotal` (decimal): Valor total do pedido.

* **`tbProduto`**
    * `id` (int, IDENTITY): Identificador único do produto.
    * `nome` (nvarchar): Nome do produto.
    * `descricao` (nvarchar): Descrição detalhada do produto.
    * `quantidadeEstoque` (int): Quantidade disponível em estoque.
    * `unidadeMedida` (nvarchar): Unidade de medida do produto (e.g., "unidade", "kg").
    * `precoUnitario` (decimal): Preço unitário de venda do produto.
    * `imgProduto` (nvarchar): Caminho ou nome da imagem do produto.

### 💻 Tecnologias Utilizadas

* **Blazor (ASP.NET Core 8.0):** Framework para construção de interfaces de usuário web interativas.
* **C#:** Linguagem de programação principal utilizada no desenvolvimento.
* **Entity Framework Core 8.0:** ORM (Object-Relational Mapper) para acesso a dados, facilitando a interação com o banco de dados.
* **SQL Server:** Sistema de gerenciamento de banco de dados relacional para armazenamento das informações do sistema.

### ⚙️ Como Configurar e Executar o Projeto

Siga os passos abaixo para configurar e executar o projeto `BlazorVendasTB` em sua máquina local:

1.  **Pré-requisitos:**
    * Instale o [.NET SDK](https://dotnet.microsoft.com/download).
    * Tenha uma instância do [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) configurada (por exemplo, SQL Server Express).
    * Instale o [SQL Server Management Studio (SSMS)](https://docs.microsoft.com/pt-br/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16) ou outra ferramenta para gerenciar seu banco de dados.

2.  **Clonar o Repositório:**
    Abra seu terminal ou Git Bash e execute o seguinte comando para clonar o repositório:
    ```bash
    git clone <URL_DO_SEU_REPOSITORIO_GITHUB>
    cd BlazorVendasTB
    ```

3.  **Configurar o Banco de Dados SQL Server:**
    * Abra o SQL Server Management Studio (SSMS).
    * Conecte-se à sua instância do SQL Server.
    * Execute o script SQL fornecido no projeto (`script 2.sql`). Este script criará o banco de dados `bdVendasTB` e suas tabelas.
    * Crie um login e usuário para o banco de dados, conforme as configurações do seu projeto (o script fornecido cria o usuário `usuario22024` e o adiciona ao role `db_owner`).

4.  **Configurar a String de Conexão:**
    * No projeto `BlazorVendasTB`, localize o arquivo `appsettings.json` (ou `appsettings.Development.json` para ambiente de desenvolvimento).
    * Atualize a string de conexão do banco de dados para apontar para sua instância local do SQL Server. Exemplo:
        ```json
        "ConnectionStrings": {
            "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=bdVendasTB;User ID=usuario22024;Password=SuaSenhaForte;Trusted_Connection=False;MultipleActiveResultSets=true"
        }
        ```
        Substitua `localhost\\SQLEXPRESS` pelo nome da sua instância SQL Server e `SuaSenhaForte` pela senha do usuário `usuario22024` ou do usuário que você configurou.

5.  **Restaurar Pacotes NuGet:**
    Navegue até o diretório raiz do projeto no terminal e execute:
    ```bash
    dotnet restore
    ```

6.  **Executar o Projeto:**
    Para iniciar a aplicação, execute o seguinte comando no terminal, a partir do diretório raiz do projeto:
    ```bash
    dotnet run
    ```
