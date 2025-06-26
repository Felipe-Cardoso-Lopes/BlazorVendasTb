# 🚀 Projeto BlazorVendasTB

Este projeto é um sistema de gerenciamento de vendas construído com Blazor, focado na organização e otimização das operações comerciais. Ele oferece uma interface robusta para gerenciar clientes, produtos, funcionários e todo o fluxo de pedidos, desde a criação até a finalização da venda. O objetivo principal é fornecer uma ferramenta eficiente para o controle de vendas, facilitando a tomada de decisões e melhorando a produtividade.

### ✨ Funcionalidades

* **Gestão de Clientes:** 👥 Cadastro, consulta, edição e exclusão de informações de clientes.
* **Gestão de Produtos:** 📦 Controle de estoque, detalhes de produtos, preços e descrições.
* **Gestão de Funcionários:** 👨‍💼👩‍💼 Registro e gerenciamento de dados dos colaboradores, incluindo cargos e salários.
* **Gestão de Pedidos/Vendas:** 🛒 Criação e acompanhamento de pedidos, incluindo itens de venda e cálculo de valor total.
* **Relatórios Simplificados:** 📊 Visão geral das vendas e produtos.

### 🏗️ Arquitetura

O `BlazorVendasTB` segue uma arquitetura monolítica, onde todos os componentes da aplicação (interface do usuário, lógica de negócios e acesso a dados) estão contidos em uma única base de código e implantados como uma única unidade. A organização do projeto é estruturada em pastas que separam as diferentes responsabilidades, como:

* **Models:** Contém as classes que representam as entidades do banco de dados.
* **Data (ou Services):** Lida com a lógica de acesso a dados e operações de banco de dados.
* **Pages (ou Components):** Inclui os componentes da interface do usuário Blazor.
* **Shared:** Componentes reutilizáveis entre as páginas.

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

* **Blazor:** Framework para construção de interfaces de usuário web interativas com .NET e C#.
* **.NET:** Plataforma de desenvolvimento.
* **C#:** Linguagem de programação.
* **SQL Server:** Sistema de gerenciamento de banco de dados relacional.

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
