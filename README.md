# Gerar Codigo GS1

Gerador de imagem Data Matrix (GS1) em .NET 10 usando `ZXing.Net` e `SkiaSharp`.

Este projeto cria uma imagem PNG contendo um c�digo Data Matrix a partir do conte�do informado via linha de comando.

## Download

Você pode baixar o executável compilado clicando no link abaixo:

[Download do GerarCodigoGS1](hhttps://github.com/mayconwisley/GerarCodigoGS1/blob/master/Download/GerarCodigoGS1.7z)


Arquivos principais:
- `Program.cs` � entrada da aplica��o e parsing de argumentos.
- `DataMatrix.cs` � gera��o do Data Matrix e grava��o em PNG.
- `GerarCodigoGS1.csproj` � refer�ncia ao `.NET 10` e pacotes NuGet (`ZXing.Net`, `ZXing.Net.Bindings.SkiaSharp`).

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

Par�metros:
- `<conteudo>` (obrigat�rio) � texto ou dados que ser�o codificados no Data Matrix.
- `<caminho_de_saida>` (obrigat�rio) � diret�rio onde o arquivo ser� salvo (deve existir).
- `<nome_do_arquivo>` (obrigat�rio) � nome do arquivo (veja observa��o abaixo sobre extens�o).
- `[size]` (opcional) � tamanho em pixels (padr�o: 300).

Exemplos
- Usando `dotnet run`:
  - `dotnet run -- "010460123456789012" "C:\Temp" "meu_datamatrix" 400`
    - Gera `C:\Temp\meu_datamatrix.png` com 400x400 px.

- Executando o bin�rio gerado:
  - `GerarCodigoGS1.exe "010460123456789012" "C:\Temp" "meu_datamatrix" 300`

Observa��es importantes
- O programa valida se o `caminho_de_saida` existe. Se n�o existir, ele retornar� erro.
- O `Program.cs` acrescenta `.png` ao `nome_do_arquivo` automaticamente. Para evitar `nome.png.png`, forne�a o nome do arquivo sem extens�o (ex.: `meu_datamatrix`).
- Se n�o informar `size`, o tamanho padr�o � `300` (px).

Erros e mensagens
- Mensagens de erro s�o exibidas no console (por exemplo, par�metros inv�lidos ou caminho inexistente).

Licen�a
- Projeto simples de exemplo; adapte conforme necess�rio para uso em produ��o.

Contato
- Abra uma issue no reposit�rio ou modifique diretamente o c�digo para ajustar comportamentos (por exemplo, valida��o de extens�o do arquivo).