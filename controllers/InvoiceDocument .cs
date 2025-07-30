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
using StockIt_2.services.GestionCoords;



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
                    column.Item().Text(text =>
                    {
                        text.Span("EURL GUEMOURI SOFIANE");
                    });

                    //column.Item().AlignRight().Text($"Freha le: {bon.Date:d}").SemiBold();

                    column.Item()
                        .Text($"Bon de récéption N°{bon.Id}/{bon.Date:yyyy}")
                        .FontSize(20).SemiBold().FontColor(Colors.Blue.Medium);
                });

                row.RelativeItem().Column(column =>
                {
                    column.Item().AlignRight().Text($"Freha le: {bon.Date:d}").SemiBold();
                });

            });
        }

        void ComposeContent(IContainer container)
        {

            container.PaddingVertical(40).Column(column =>
            {
                column.Item().Row(row =>
                {
                    row.RelativeItem().Component(new FournisseurComponent(bon.fournisseur));
                    row.ConstantItem(50);
                    row.RelativeItem().Component(new TransporteurComponent(bon.transporteur));

                });


                column.Spacing(5);
                column.Item().Element(ComposeTable);
                column.Item().Element(ComposeTableTransport);
                column.Item().AlignRight().Text($"TG: {bon.total_amount} DZD").FontSize(14);

                column.Item().PaddingTop(25).Element(ComposeComments);
            });
        }

        void ComposeTable(IContainer container)
        {
            container.Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.RelativeColumn(25);
                    columns.RelativeColumn(10);
                    columns.RelativeColumn(10);
                    columns.RelativeColumn(10);
                    columns.RelativeColumn(10);
                });

                table.Header(header =>
                {
                    header.Cell().Element(CellStyle).Text("Designation");
                    header.Cell().Element(CellStyle).AlignCenter().Text("NBR");
                    header.Cell().Element(CellStyle).AlignCenter().Text("KG");
                    header.Cell().Element(CellStyle).AlignCenter().Text("PU");
                    header.Cell().Element(CellStyle).AlignCenter().Text("TTC");

                    static IContainer CellStyle(IContainer container)
                    {
                        return container.DefaultTextStyle(x => x.SemiBold()).PaddingVertical(5).BorderBottom(1).BorderColor(Colors.Black);
                    }
                });

                foreach (var item in bon.Items)
                {
                    string poids = item.poids_kg.ToString("F2");
                    if (item.poids_kg == 0)
                    {
                        poids = " "; // or any other placeholder
                    }
                    table.Cell().Element(CellStyle).Text(item.designation);
                    table.Cell().Element(CellStyle).AlignCenter().Text(item.nbr);
                    table.Cell().Element(CellStyle).AlignCenter().Text($"{poids}");
                    table.Cell().Element(CellStyle).AlignCenter().Text(item.prix_unitaire);
                    table.Cell().Element(CellStyle).AlignCenter().Text($"{item.ttc}");

                    static IContainer CellStyle(IContainer container)
                    {
                        return container.BorderBottom(1).BorderColor(Colors.Grey.Lighten2).PaddingVertical(5);
                    }
                }
            });
        }

        void ComposeTableTransport(IContainer container)
        {
            container.Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.RelativeColumn(25);
                    columns.RelativeColumn(10);
                    columns.RelativeColumn(10);
                    columns.RelativeColumn(10);
                    columns.RelativeColumn(10);
                });

                    string total_transport = (bon.Items[0].nbr * bon.prix_transport_unitaire).ToString("F2");
                table.Cell().Element(CellStyle).Text("Transport"); //designation
                    table.Cell().Element(CellStyle).AlignCenter().Text(bon.Items[0].nbr); //nbr
                    table.Cell().Element(CellStyle).AlignCenter().Text(" "); //kg
                    table.Cell().Element(CellStyle).AlignCenter().Text(bon.prix_transport_unitaire); //pu transport
                    table.Cell().Element(CellStyle).AlignCenter().Text($"{total_transport}"); //ttc

                    static IContainer CellStyle(IContainer container)
                    {
                        return container.BorderBottom(1).BorderColor(Colors.Grey.Lighten2).PaddingVertical(5);
                    }
                
            });
        }

        void ComposeComments(IContainer container)
        {
            
                GestionCoords gestionCoords = new GestionCoords();
                Coords coords = gestionCoords.GetCoords();

            container.Row(row =>
            {
                row.RelativeItem().Column(column =>
                {
                        column.Spacing(5);
                        column.Item().Text("Coordonnées").FontSize(14);
                        column.Item().Text("Tel: ");
                        column.Item().Text("Email: ");
                        column.Item().Text("Adresse: ");
                        column.Item().Text("AI: ");
                        column.Item().Text("NIF: ");
                        column.Item().Text("NIS: ");
                   
                });
                row.ConstantItem(50);
                row.RelativeItem().Column(column =>
                {
                    column.Spacing(5);
                    column.Item().Text(" ").FontSize(14);
                    column.Item().Text(coords.tel);
                    column.Item().Text(coords.email);
                    column.Item().Text(coords.adresse);
                    column.Item().Text(coords.ai);
                    column.Item().Text(coords.nif);
                    column.Item().Text(coords.nis); 
                });
            });
        }
    }
}
