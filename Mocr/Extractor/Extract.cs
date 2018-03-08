using Patagames.Ocr;
using Patagames.Ocr.Enums;
using System.Drawing;

namespace Mocr.Extractor
{
    public class Extract
    {
        public static string ExtractTextFromImage(string path)
        {
            using (var api = OcrApi.Create())
            {
                api.Init(Languages.English);
                using (var bmp = Bitmap.FromFile(path) as Bitmap)
                {
                    string plainText = api.GetTextFromImage(bmp);

                    return plainText;
                }
            }
        }
    }
}
