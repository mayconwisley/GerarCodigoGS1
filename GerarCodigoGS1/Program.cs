using GerarCodigoGS1;

try
{
    if (args.Length <= 0)
    {
        ShowUsage();
        return;
    }

    var nameDataMatrixDefault = $"{DateTime.Now:yyyy-MM-dd_HH:mm:ss}_datamatrix.png";
    var outputPathDefault = Path.Combine(AppContext.BaseDirectory);

    var content = args[0];
    if (string.IsNullOrWhiteSpace(content))
        throw new ArgumentException("Conteúdo inválido. Paramentro 1");

    var outputPath = args.Length > 1 ? args[1] : outputPathDefault;
    if (!Directory.Exists(outputPath))
        throw new ArgumentException("Caminho de saída inválido. Paramentro 2");

    var fileName = args.Length > 2 ? args[2] : nameDataMatrixDefault;
    if (string.IsNullOrWhiteSpace(fileName))
        throw new ArgumentException("Nome do arquivo inválido. Paramentro 3");

    var size = args.Length > 3 ? int.Parse(args[3]) : 300;

    outputPath = Path.Combine(outputPath, $"{fileName}.png");

    DataMatrix.GerarDataMatrix(content, outputPath, size);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
    Console.ReadKey();
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
    Console.ReadKey();
}

static void ShowUsage()
{
    Console.WriteLine("Gerar Codigo GS1 Data Matrix - Use:");
    Console.WriteLine("  <conteudo> <caminho de saida> <nome do arquivo> [size]    Criar a imagem Data Matrix");
    Console.WriteLine("Por padrão o size é 300px");
    Console.ReadKey();
}