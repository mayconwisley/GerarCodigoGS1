using SkiaSharp;
using ZXing;
using ZXing.SkiaSharp;

namespace GerarCodigoGS1;

public static class DataMatrix
{
    public static void GerarDataMatrix(string content, string outputPath, int size = 300)
    {
        var write = new BarcodeWriter
        {
            Format = BarcodeFormat.DATA_MATRIX,
            Options = new ZXing.Common.EncodingOptions
            {
                Width = size,
                Height = size,
                Margin = 1
            }
        };

        var bitmap = write.Write(content);
        using var image = SKImage.FromBitmap(bitmap);
        using var data = image.Encode(SKEncodedImageFormat.Png, 100);
        using var stream = File.OpenWrite(outputPath);

        data.SaveTo(stream);
    }
}
