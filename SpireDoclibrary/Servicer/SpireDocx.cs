using Spire.Doc.Documents;
using Spire.Doc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Spire.Doc.Fields;
using Spire.Doc.Interface;

namespace SpireDoclibrary.Servicer
{
    public class SpireDocx
    {
        private readonly Document document; 

        public SpireDocx()
        {
            document = new Document("D:\\codeLean\\c# bassic\\WebUserDemoApi\\SpireDoclibrary\\Template\\Template.docx");
        }

        public byte[] GetDocument()
        {
            // Get the current section
            Section section = document.Sections[0];
            // Điều chỉnh khoảng cách header và lề
            section.PageSetup.HeaderDistance = 10; // Tăng khoảng cách giữa header và phần nội dung
            section.PageSetup.FooterDistance = 3;
     

            section.PageSetup.Margins.Top = 0;
            section.PageSetup.Margins.Right = 0;
            section.PageSetup.Margins.Left = 0;
            section.PageSetup.Margins.Bottom = 0;

            
            // Thêm header
            HeaderFooter header = section.HeadersFooters.Header;
            
            Paragraph headerParagraph = header.AddParagraph();

           
            headerParagraph.Format.AfterAutoSpacing = false;
            headerParagraph.Format.BeforeAutoSpacing = false;
            headerParagraph.Format.AfterSpacing = 0;
            headerParagraph.Format.BeforeSpacing = 0;

            // Thêm bảng HTML
            string htmlTable = @"
<table style='width:100%; border:none;'>
    <tr>
        <td style='width:25%; text-align:center; vertical-align:middle; border-bottom: 1px solid red;'>
            <img src='D:\codeLean\c# bassic\WebUserDemoApi\SpireDoclibrary\Images\IconPhenikaaMec.jpg' width='145' height='65' style='object-fit: cover;'/>
        </td>
        <td style='width:40%; text-align:center; vertical-align:middle; border-bottom: 1px solid red;'>
            <div style='font-family: Times New Roman; font-size: 11pt;'>
                <span style=""color: #267FB8;"">SỞ Y TẾ THÀNH PHỐ HÀ NỘI</span><br/>
                <strong style='text-align: end;'>
                   <span style='font-size: 10px; vertical-align: middle; color: #057eca;'>•</span>&nbsp;
                        <span style='font-size: 25x; vertical-align:middle;color: #057eca;'>•</span>&nbsp;
                        <span style='font-size: 10px; vertical-align: middle;color: #057eca;'>•</span>
                </strong><br/>
                <strong style=""color: #057eca; font-size: 11pt;"">PHÒNG KHÁM ĐA KHOA</strong><br/>
                <strong style=""color: #057eca; font-size: 11pt;"">ĐẠI HỌC PHENIKAA HOÀNG NGÂN</strong>
            </div>
        </td>
        <td style='width:35%; text-align:left; vertical-align:middle;border-bottom: 3px solid black;'>
            <div style='font-family: Times New Roman; font-size: 8pt; color: #000000;'>
                 <span ><img src=""D:\codeLean\c# bassic\WebUserDemoApi\SpireDoclibrary\Images\placeholder.png"" alt=""""></span>&nbsp;<span style='color: #213A6E;'> Số 167 Hoàng Ngân, P. Trung Hòa, Q. Cầu Giấy, TP.HN</span><br/>
                <span ><img src=""D:\codeLean\c# bassic\WebUserDemoApi\SpireDoclibrary\Images\email.png"" alt=""""></span>&nbsp;<span style='color: #213A6E;'>pkdkhoangngan@phenikaa.com</span><br/>
                <span ><img src=""D:\codeLean\c# bassic\WebUserDemoApi\SpireDoclibrary\Images\internet.png"" alt=""""></span>&nbsp;<span style='color: #213A6E;'>phenikaamec.vn</span><br/>
                <span ><img src=""D:\codeLean\c# bassic\WebUserDemoApi\SpireDoclibrary\Images\phone-call.png"" alt=""""></span>&nbsp;<span style='color: #213A6E;'>(024) 2222 6699</span><br/>
            </div>
        </td>
    </tr>
</table>
<span><img src='D:\codeLean\c# bassic\WebUserDemoApi\SpireDoclibrary\Images\line.png' width='100%' height='5' /></span>
";
            headerParagraph.AppendHTML(htmlTable);
            
            headerParagraph.Format.LineSpacing = 0;


            // Thêm footer
            HeaderFooter footer = section.HeadersFooters.Footer;
            
            
            Paragraph paragraph2 = footer.AddParagraph();
            paragraph2.Format.HorizontalAlignment = HorizontalAlignment.Right;
            DocPicture footerimage = paragraph2.AppendPicture(Image.FromFile(@"D:\codeLean\c# bassic\WebUserDemoApi\SpireDoclibrary\Images\footer.jpg"));
            footerimage.SetScale(50);

            

            // Thêm watermark hình ảnh
            PictureWatermark picWatermark = new PictureWatermark();
            picWatermark.Picture = Image.FromFile(@"D:\codeLean\c# bassic\WebUserDemoApi\SpireDoclibrary\Images\watermarkLogo.jpg");

            picWatermark.Scaling = 65;
            picWatermark.IsWashout = true;
            document.Watermark = picWatermark;
            headerParagraph.Format.AfterSpacing = 0;
            headerParagraph.Format.BeforeSpacing = 0;
            document.SaveToFile("Header.docx", FileFormat.Docx);

            // Lưu tài liệu vào MemoryStream
            using (MemoryStream ms = new MemoryStream())
            {
                document.SaveToStream(ms, FileFormat.PDF);
                ms.Position = 0; // Đặt lại vị trí của stream để đọc từ đầu
                return ms.ToArray();
            }
        }
    }
}
