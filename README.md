# Projeto Teste Target

Este é um projeto de exemplo para rodar questões de programação, onde você pode escolher entre diferentes tarefas, como cálculo de soma, Fibonacci, análise de faturamento e mais.

## Instruções para rodar o projeto

### Pré-requisitos

- .NET SDK 6.0 ou superior instalado. Para verificar, use o comando:

  ```bash
  dotnet --version
  ```

## Como rodar o projeto

### Clone o repositório para o seu computador:

```bash
git clone https://github.com/USERNAME/REPO_NAME.git
```

Navegue até o diretório do projeto:

```bash
cd REPO_NAME
```

Restaure os pacotes NuGet necessários:

```bash
dotnet restore
```

Execute o projeto:

```bash
dotnet run
```

## Funcionalidade

### O programa oferece um menu com as seguintes opções:

##### Soma com laço: Calcula a soma dos números de 1 até 13.

##### Fibonacci: Verifica se um número informado pertence à sequência de Fibonacci.

##### Análise de faturamento diário: Analisa dados de faturamento diário a partir de um arquivo JSON.

##### Percentual por estado: Exibe o percentual de faturamento por estado.

##### Inversão de string: Inverte uma string fornecida pelo usuário.

#### Arquivos de dados

O arquivo dados.json contém os dados necessários para a análise de faturamento diário e está localizado na mesma pasta do arquivo principal.
