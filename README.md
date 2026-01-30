# GerarCodigoGS1

Gerador de imagem Data Matrix (GS1) em .NET 10 usando `ZXing.Net` e `SkiaSharp`.

Este projeto cria uma imagem JPG contendo um código Data Matrix a partir do conteúdo informado via linha de comando.

## Download

Você pode baixar o executável compilado clicando no link abaixo:

[Download do GerarCodigoGS1](https://github.com/mayconwisley/GerarCodigoGS1/raw/refs/heads/master/Download/GerarCodigoGS1.7z)

Arquivos principais:
- `Program.cs` – entrada da aplicação e parsing de argumentos.
- `DataMatrix.cs` – geração do Data Matrix e gravação em JPG.
- `GerarCodigoGS1.csproj` – referência ao `.NET 10` e pacotes NuGet (`ZXing.Net`, `ZXing.Net.Bindings.SkiaSharp`).

Requisitos
- .NET 10 SDK
- Ferramenta `dotnet` (ou Visual Studio 2026)

Como compilar
- Pela CLI:
  - `dotnet build`

- No Visual Studio 2026:
  - Abra o projeto (`GerarCodigoGS1.csproj`) e compile.

Uso (linha de comando)
Sintaxe:
`dotnet run -- <conteudo> <caminho_de_saida> <nome_do_arquivo> [size]`

Parâmetros:
- `<conteudo>` (obrigatório) — texto ou dados que serão codificados no Data Matrix.
- `<caminho_de_saida>` (obrigatório) — diretório onde o arquivo será salvo (deve existir).
- `<nome_do_arquivo>` (obrigatório) — nome do arquivo (veja observação abaixo sobre extensão).
- `[size]` (opcional) — tamanho em pixels (padrão: 300).

Exemplos
- Usando `dotnet run`:
  - `dotnet run -- "010460123456789012" "C:\Temp" "meu_datamatrix" 400`
    - Gera `C:\Temp\meu_datamatrix.JPG` com 400x400 px.

- Executando o binário gerado:
  - `GerarCodigoGS1.exe "010460123456789012" "C:\Temp" "meu_datamatrix" 300`

Observações importantes
- O programa valida se o `caminho_de_saida` existe. Se não existir, ele retornará erro.
- O `Program.cs` acrescenta `.JPG` ao `nome_do_arquivo` automaticamente. Para evitar `nome.JPG.JPG`, forneça o nome do arquivo sem extensão (ex.: `meu_datamatrix`).
- Se não informar `size`, o tamanho padrão é `300` (px).

Erros e mensagens
- Mensagens de erro são exibidas no console (por exemplo, parâmetros inválidos ou caminho inexistente).

Licença
- Projeto simples de exemplo; adapte conforme necessário para uso em produção.

Contato
- Abra uma issue no repositório ou modifique diretamente o código para ajustar comportamentos (por exemplo, validação de extensão do arquivo).