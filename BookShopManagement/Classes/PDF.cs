using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShopManagement.Components;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace BookShopManagement.Classes
{
    class PDF
    {
        string orderNo;
        public PDF(string orderNo)
        {
            this.orderNo = orderNo + ".pdf";
            createPDF();
        }

        private void createPDF()
        {
            try
            {
                PdfWriter writer = new PdfWriter(orderNo);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);

               /* Image img = new Image(ImageDataFactory
        .Create(Path.GetParent()))
        .SetTextAlignment(TextAlignment.CENTER);
                document.Add(img);*/

                Paragraph header = new Paragraph("ESOGU BOOKSTORE")
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(20);
                document.Add(header);

                Paragraph subheader = new Paragraph("Invoice for Order No:" + orderNo.Substring(0,15)).
                    SetTextAlignment(TextAlignment.CENTER).
                    SetFontSize(15);
                document.Add(subheader);

                Paragraph newline = new Paragraph(new Text("\n"));
                document.Add(newline);

                LineSeparator ls = new LineSeparator(new SolidLine());
                document.Add(ls);

                Paragraph paragraph1 = new Paragraph("You ordered the following item(s) on " +
                    DateTime.Now.ToString("MM/dd/yy H:mm:ss") + "\n");
                document.Add(paragraph1);

                System.Collections.Generic.List<ItemToPurchase> purchaseItems = new System.Collections.Generic.List<ItemToPurchase>();
                foreach (ItemToPurchase itemm in ShoppingCart.Instance.ItemsToPurchase)
                {                    
                    purchaseItems.Add(itemm);
                }
                               
                Table table = new Table(3, false);
                Cell cell11 = new Cell(1, 1).SetBackgroundColor(ColorConstants.YELLOW).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("QTY"));
                Cell cell12 = new Cell(1, 1).SetBackgroundColor(ColorConstants.YELLOW).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("ITEM"));
                Cell cell13 = new Cell(1, 1).SetBackgroundColor(ColorConstants.YELLOW).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("PRICE"));

                table.AddCell(cell11);
                table.AddCell(cell12);
                table.AddCell(cell13);

            
                for (var i = 0; i < purchaseItems.Count; i++)
                {
                    Cell cell1 = new Cell(1, 1).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(purchaseItems[i].Quantity.ToString()));
                    Cell cell2 = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph(purchaseItems[i].Product.Name.ToString()));
                    Cell cell3 = new Cell(1, 1).SetTextAlignment(TextAlignment.RIGHT).Add(new Paragraph("€ " + purchaseItems[i].Product.Price.ToString("0.00")));
                    
                    table.AddCell(cell1);
                    table.AddCell(cell2);
                    table.AddCell(cell3);
                }
                Cell cellTotal = new Cell(1, 1).SetBackgroundColor(ColorConstants.GREEN).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("TOTAL"));
                Cell cellTotalPrice = new Cell(1, 2).SetBackgroundColor(ColorConstants.GREEN).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("€ " + 
                    ShoppingCart.Instance.PaymentAmount.ToString("0.00")));

                table.AddCell(cellTotal);
                table.AddCell(cellTotalPrice);

                document.Add(newline);
                document.Add(table);
                document.Add(newline);
                document.Add(newline);
                document.Add(ls);

                document.Close();
            }
            catch
            {
                Alert.Create("PDF not exported", Alert.Type.Error);
            }

        }
    }
}
