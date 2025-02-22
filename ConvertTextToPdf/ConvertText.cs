using QuestPDF.Companion;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace ConvertTextToPdf
{
    public class Converter
    {
        public void ConvertToPdf(string text, string fileLocation, string fileNameWithoutExtension)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(12));
                    page.Content()
                    .AlignMiddle()
                    .Column(x =>
                    {
                        x.Spacing(20);
                        x.Item().Text(text);
                    });
                });
            }).GeneratePdf($"{fileLocation}\\{fileNameWithoutExtension}.pdf");
        }
    }
}
