using SVRepository.Entities;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace SVPresentation.Utilidades
{
    public static class Util
    {

        public static byte[] GenerarPDFVenta(Negocio oNegocio, Venta oVenta)
        {
            QuestPDF.Settings.License = LicenseType.Community;
            string carpetaImagenes = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)!.Parent!.Parent!.Parent!.FullName, "FotosNego");
            string rutaImagen = Path.Combine(carpetaImagenes, oNegocio.UrlLogo!);
            byte[] imageData = File.ReadAllBytes(rutaImagen);

            var arrayPDF = Document.Create(document =>
            {
                document.Page(page =>
                {
                    page.Margin(30);

                    page.Header().ShowOnce().Row(row =>
                    {
                        row.AutoItem().Height(60).Image(imageData).FitArea();
                        //row.AutoItem().Height(60).Image(imageData, ImageScaling.FitArea);
                        //row.AutoItem().Height(60).Image(imageLogo, ImageScaling.FitArea);

                        row.RelativeItem().Column(col =>
                        {
                            col.Item().AlignCenter().Text(oNegocio.RazonSocial).Bold().FontSize(14);
                            col.Item().AlignCenter().Text(oNegocio.Direccion).FontSize(9);
                            col.Item().AlignCenter().Text(oNegocio.Celular).FontSize(9);
                            col.Item().AlignCenter().Text(oNegocio.Correo).FontSize(9);
                        });

                        row.ConstantItem(140).Column(col =>
                        {
                            col.Item().Border(1).BorderColor("#634883").AlignCenter().Text($"RUC {oNegocio.RUC}");
                            col.Item().Background("#634883").Border(1).BorderColor("#634883").AlignCenter().Text("Boleta de Venta").FontColor("#fff");
                            col.Item().Border(1).BorderColor("#634883").AlignCenter().Text(oVenta.NumeroVenta);
                        });
                    });
                    //fin header
                    page.Content().PaddingVertical(15).Column(col1 =>
                    {
                        col1.Spacing(10);
                        col1.Item().LineHorizontal(0.5f);

                        col1.Item().Row(row =>
                        {
                            row.RelativeItem().Text(txt =>
                            {
                                txt.Span("Cliente: ").SemiBold().FontSize(10);
                                txt.Span(oVenta.NombreCliente).FontSize(10);
                            });

                            row.RelativeItem().Text(txt =>
                            {
                                txt.Span("Fecha Emisión: ").SemiBold().FontSize(10);
                                txt.Span(oVenta.FechaRegistro).FontSize(10);
                            });

                            row.RelativeItem().Text(txt =>
                            {
                                txt.Span("Atendido por: ").SemiBold().FontSize(10);
                                txt.Span(oVenta.UsuarioRegistro!.NombreUsuario).FontSize(10);
                            });

                        });

                        col1.Item().LineHorizontal(0.5f);

                        col1.Item().Table(tabla =>
                        {
                            tabla.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(3);
                                columns.RelativeColumn();
                                columns.RelativeColumn();
                                columns.RelativeColumn();
                            });

                            tabla.Header(header =>
                            {
                                header.Cell().Background("#634883").Padding(2).Text("Producto").FontColor("#fff");
                                header.Cell().Background("#634883").Padding(2).Text("Precio").FontColor("#fff");
                                header.Cell().Background("#634883").Padding(2).Text("Cantidad").FontColor("#fff");
                                header.Cell().Background("#634883").Padding(2).Text("Total").FontColor("#fff");
                            });

                            foreach (DetalleVenta item in oVenta.RefDetalleVenta!)
                            {
                                decimal cantidad = Convert.ToDecimal(item.Cantidad) / Convert.ToDecimal(item.RefProducto!.RefCategoria!.RefMedida!.Valor);
                                string abreviatura = item.RefProducto.RefCategoria.RefMedida.Abreviatura;

                                tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2)
                                    .Text(item.RefProducto.Descripcion).FontSize(10);

                                tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2)
                                    .Text($"{oNegocio.SimboloMoneda} {item.PrecioVenta.ToString("0.00")}").FontSize(10);

                                tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2)
                                    .Text($"{cantidad.ToString()} {abreviatura}").FontSize(10);

                                tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2)
                                    .Text($"{oNegocio.SimboloMoneda} {item.PrecioTotal.ToString("0.00")}").FontSize(10);
                            }
                        });

                        col1.Item().AlignRight().Text($"Total: {oNegocio.SimboloMoneda} {oVenta.PrecioTotal.ToString("0.00")}").FontSize(10);
                        //aqui puedo agregar otro col1 para cantidad
                    });
                    //fin contenido pageContent

                    page.Footer().AlignRight().Text(txt =>
                    {
                        txt.Span("Pagina ").FontSize(10);
                        txt.CurrentPageNumber().FontSize(10);
                        txt.Span(" de ").FontSize(10);
                        txt.TotalPages().FontSize(10);
                    });
                });
            }).GeneratePdf();

            return arrayPDF;
        }
    }
}
