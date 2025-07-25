using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestPDF.Drawing;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using StockIt_2.models;



namespace StockIt_2.controllers
{
    public class InvoiceDocument : IDocument
    {

        public Bon bon { get; }

        public InvoiceDocument(Bon model)
        {
            bon = model;
        }



        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;
        public DocumentSettings GetSettings() => DocumentSettings.Default;
        public void Compose(IDocumentContainer container)
        {
            container
                .Page(page =>
                {
                    page.Margin(50);

                    page.Header().Height(100).Background(Colors.Grey.Lighten1);
                    page.Content().Background(Colors.Grey.Lighten3);
                    page.Footer().Height(50).Background(Colors.Grey.Lighten1);
                });
       
            container
                .Page(page =>
                {
                    page.Margin(50);

                    page.Header().Element(ComposeHeader);
                    page.Content().Element(ComposeContent);

                    page.Footer().AlignCenter().Text(x =>
                    {
                        x.CurrentPageNumber();
                        x.Span(" / ");
                        x.TotalPages();
                    });
                });
        }

        void ComposeHeader(IContainer container)
        {
            container.Row(row =>
            {
                row.RelativeItem().Column(column =>
                {
                    column.Item()
                        .Text($"Bon de récéption #{bon.Id}/{bon.Date:y}")
                        .FontSize(20).SemiBold().FontColor(Colors.Blue.Medium);

                    column.Item().Text(text =>
                    {
                        text.Span("Freha Le: ").SemiBold();
                        text.Span($"{bon.Date:d}");
                    });

                    
                });

                row.ConstantItem(100).Height(50).Placeholder();
            });
        }

        void ComposeContent(IContainer container)
        {
            container
                .PaddingVertical(40)
                .Height(250)
                .Background(Colors.Grey.Lighten3)
                .AlignCenter()
                .AlignMiddle()
                .Text("Content").FontSize(16);
            container.PaddingVertical(40).Column(column =>
            {
                column.Spacing(5);

                column.Item().Element(ComposeTable);

                //if (!string.IsNullOrWhiteSpace(bon.Comments))
                //    column.Item().PaddingTop(25).Element(ComposeComments);
            });
        }

        void ComposeTable(IContainer container)
        {
            container
                .Height(250)
                .Background(Colors.Grey.Lighten3)
                .AlignCenter()
                .AlignMiddle()
                .Text("Table").FontSize(16);

            
            container.Table(table =>
            {
            table.ColumnsDefinition(columns =>
                    {
                        columns.ConstantColumn(25);
                        columns.RelativeColumn(3);
                        columns.RelativeColumn();
                        columns.RelativeColumn();
                        columns.RelativeColumn();
                    });

                    table.Header(header =>
                    {
                        header.Cell().Element(CellStyle).Text("Designation");
                        header.Cell().Element(CellStyle).Text("NBR");
                        header.Cell().Element(CellStyle).AlignRight().Text("KG");
                        header.Cell().Element(CellStyle).AlignRight().Text("PU");
                        header.Cell().Element(CellStyle).AlignRight().Text("TTC");

                        static IContainer CellStyle(IContainer container)
                        {
                            return container.DefaultTextStyle(x => x.SemiBold()).PaddingVertical(5).BorderBottom(1).BorderColor(Colors.Black);
                        }
                    });

                static IContainer CellStyle(IContainer container)
                    {
                        return container.BorderBottom(1).BorderColor(Colors.Grey.Lighten2).PaddingVertical(5);
                    }


                //table.Cell().Element(CellStyle).Text(bon.designation);
                //table.Cell().Element(CellStyle).Text(bon.nbr.ToString());
                //table.Cell().Element(CellStyle).AlignRight().Text($"{bon.poids_kg} kg");
                //table.Cell().Element(CellStyle).AlignRight().Text($"{bon.prix_unitaire}$");
                //table.Cell().Element(CellStyle).AlignRight().Text($"{bon.total_amount}$");
                //foreach (var item in bon.Items)
                //{
                //    table.Cell().Element(CellStyle).Text(Model.Items.IndexOf(item) + 1);
                //    table.Cell().Element(CellStyle).Text(item.Name);
                //    table.Cell().Element(CellStyle).AlignRight().Text($"{item.Price}$");
                //    table.Cell().Element(CellStyle).AlignRight().Text(item.Quantity);
                //    table.Cell().Element(CellStyle).AlignRight().Text($"{item.Price * item.Quantity}$");

                //    static IContainer CellStyle(IContainer container)
                //    {
                //        return container.BorderBottom(1).BorderColor(Colors.Grey.Lighten2).PaddingVertical(5);
                //    }
                //}
            });
            
        }

        void ComposeComments(IContainer container)
        {
            container.Background(Colors.Grey.Lighten3).Padding(10).Column(column =>
            {
                column.Spacing(5);
                column.Item().Text("Comments").FontSize(14);
                //column.Item().Text(Model.Comments);
            });
        }
    }
}
