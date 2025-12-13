using SkiaSharp;
using ZXing;
using ZXing.Datamatrix;
using ZXing.Datamatrix.Encoder;
using ZXing.SkiaSharp;

namespace GerarCodigoGS1;

public static class DataMatrix
{
    public static void GerarDataMatrix(string content, string outputPath, int size = 300)
    {
        // FNC1 (ASCII 29)
        char fnc1 = (char)0x1D;

        // Inserir FNC1 ANTES dos AIs
        string payload = fnc1 + content;

        var write = new BarcodeWriter
        {
            Format = BarcodeFormat.DATA_MATRIX,
            Options = new DatamatrixEncodingOptions
            {
                Width = size,
                Height = size,
                Margin = 2,
                SymbolShape = SymbolShapeHint.FORCE_SQUARE,
                GS1Format = true
            }
        };

        var bitmap = write.Write(payload);
        using var image = SKImage.FromBitmap(bitmap);
        using var data = image.Encode(SKEncodedImageFormat.Png, 100);
        using var stream = File.OpenWrite(outputPath);

        data.SaveTo(stream);
    }
}
