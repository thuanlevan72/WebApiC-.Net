using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using Spire.Doc.Formatting;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System;

namespace HMS.Reports.Services
{
    public class EditDocumentBuilder
    {
        private readonly Document _doc;

        public EditDocumentBuilder(Document doc)
        {
            _doc = doc;
            string licenseKey = @"Idd65VXxKpEAgBvZ1nVhUN+w7vpItcbvurq9YsmKuDda+JAEE9qF2G4YzR3o0s96HLaSfKKXq8fmv/VifgjLP/ZHrAKRewKyimE+b1l5tI82tdsWa+W3TgkLfepngT3Ui+LuaUc8pxXYEPd/bacNeg6yvWi7xVPzxDsE/m3D+OyD1ifz4S4lkOhjUS4pJ9gIKv6eIx0aXzRyczi4c+55+yRRBjUsB3AUS5C4sGq4LaSbeVLRq52visiCeMQxIkO6G38uTOyJl3mplKPrB3tpSTpmDc0j1WLuce1KIA9GbtKqOgh5vJwnXnwR3qeVgEBY2Lgrt6Gu0RModahYN6N5ODyj526SSOsz50jUQsrjfnk2JYKq3D3GA+lshknDJsSyHHkqYNxXfha7GQ4e11FhxALPu81LBXLXez4l73XCV9n6cdvHnyOerI18clWh/g6lgfEG+N+ugko2oxET/WEeIVKoIvpEw9YMv5bQrD6oWlN5GthgiXawtPQ6kM41r0MKW75+6ojDqRbOqvyVwC4HNRf2MXjni/Bdo0KBG3SD119bQfa+4zBREiEz6X26Mv7Tc0n8YzGTcK7VZcRGqI06bp4RDiFvAMrn4Y83gJaVRX6MbSJqwpKXKugSrmf0ck6XzLmhQcjsznnLkToXxvBS2jh6Vy3JZXvt4l8JUF8zE9CPix+kpDcGedXA1MmN/dju6Ps4sgGGAnjrfl1YLHvbQR8kii+h9tKrUrjTT88xvjjwz5IXmC4MX2A6HjSqabQwLVm8wfwNF22Pp1nMuX5DVP2pyNMMYMHIewGlJRSQz3j/7gVbw264aeBJPGyVpxrZCRO7byu/Z8cKTk02S+vZTazhIjV4jmn8zLOsxH0wsbcEpDLw1XnrH4tUiIRDQxRO+EBtpPklyFx9Q8AYkIv91osUiQZ14MXfysJ8oHG8gqHa7uidcd+YgFc3FRlFlVXYqqQlABFg5/ZvUHUklZdiRLenTb2yfl3RffnzA1aevJcLy2sBoWUrTxZlAFu0u8D2+swu0V3juiLM8pO9VDB4gHtQh3n/cnvShuv8hls2fi0TTZvpxLdfBw==";
            //Spire.Pdf.License.LicenseProvider.SetLicenseKey(licenseKey);
            //Spire.Pdf.License.LicenseProvider.LoadLicense();

            Spire.Doc.License.LicenseProvider.SetLicenseKey(licenseKey);
            Spire.Doc.License.LicenseProvider.LoadLicense();
        }

        // 1. Chèn bảng mới
        public Table InsertTable(string key, int rowCount, int colCount)
        {
            var selection = _doc.FindString(key, true, true);
            if (selection == null)
            {
                throw new ArgumentException($"Không tìm thấy key '{key}' trong tài liệu.", nameof(key));
            }

            var paragraph = selection.GetAsOneRange().OwnerParagraph;
            var body = paragraph.OwnerTextBody;

            var table = _doc.Sections[0].AddTable(true);
            table.ResetCells(rowCount, colCount);

            body.ChildObjects.Insert(body.ChildObjects.IndexOf(paragraph), table);
            body.ChildObjects.Remove(paragraph);

            return table;
        }

        // 2. Thêm dòng mới vào bảng
        public TableRow AddRow(Table table, int rowIndex = -1)
        {
            var row = table.AddRow();
            if (rowIndex >= 0)
            {
                table.Rows.Insert(rowIndex, row);
            }
            return row;
        }

        // 3. Xóa dòng khỏi bảng
        public void DeleteRow(Table table, int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < table.Rows.Count)
            {
                table.Rows.RemoveAt(rowIndex);
            }
        }

        // 4. Gộp ô theo chiều ngang
        public void MergeCellsHorizontally(Table table, int rowIndex, int startCellIndex, int endCellIndex)
        {
            if (rowIndex >= 0 && rowIndex < table.Rows.Count &&
                startCellIndex >= 0 && endCellIndex < table.Rows[rowIndex].Cells.Count &&
                startCellIndex <= endCellIndex)
            {
                table.ApplyHorizontalMerge(rowIndex, startCellIndex, endCellIndex);
            }
        }

        // 5. Gộp ô theo chiều dọc
        public void MergeCellsVertically(Table table, int columnIndex, int startRowIndex, int endRowIndex)
        {
            if (columnIndex >= 0 && columnIndex < table.Rows[0].Cells.Count &&
                startRowIndex >= 0 && endRowIndex < table.Rows.Count &&
                startRowIndex <= endRowIndex)
            {
                table.ApplyVerticalMerge(columnIndex, startRowIndex, endRowIndex);
            }
        }

        // 6. Thiết lập độ rộng cho cột
        public void SetColumnWidth(Table table, int columnIndex, float width, CellWidthType widthType)
        {
            if (columnIndex >= 0 && columnIndex < table.Rows[0].Cells.Count)
            {
                table.Rows[0].Cells[columnIndex].SetCellWidth(width, widthType);
            }
        }

        // 7. Thiết lập chiều cao cho dòng
        public void SetRowHeight(TableRow row, float height)
        {
            row.Height = height;
        }

        // 8. Thêm văn bản vào ô
        public void AddTextToCell(TableCell cell, string text, string fontStyle = "Normal", float fontSize = 12f)
        {
            cell.ChildObjects.Clear();
            var paragraph = cell.AddParagraph();
            SetFontStyle(paragraph, fontStyle, fontSize);
            paragraph.AppendText(text);
            SetTextAlignment(paragraph, text);
        }

        // 9. Thêm hình ảnh vào ô
        public void AddImageToCell(TableCell cell, string base64Image, float? width = null, float? height = null)
        {
            AddImageToParagraph(cell.AddParagraph(), base64Image, width, height);
        }

        // 10. Thiết lập căn lề cho văn bản trong ô
        public void SetCellTextAlignment(TableCell cell, HorizontalAlignment alignment)
        {
            foreach (Paragraph paragraph in cell.Paragraphs)
            {
                paragraph.Format.HorizontalAlignment = alignment;
            }
        }

        // 11. Thiết lập màu nền cho ô
        public void SetCellBackgroundColor(TableCell cell, Color color)
        {
            cell.CellFormat.BackColor = color;
        }

        // 12. Thiết lập viền cho ô
        public void SetCellBorder(TableCell cell, BorderStyle borderStyle, float borderWidth, Color borderColor)
        {
            var borders = cell.CellFormat.Borders;
            borders.Top.BorderType = borderStyle;
            borders.Top.LineWidth = borderWidth;
            borders.Top.Color = borderColor;
            borders.Bottom.BorderType = borderStyle;
            borders.Bottom.LineWidth = borderWidth;
            borders.Bottom.Color = borderColor;
            borders.Left.BorderType = borderStyle;
            borders.Left.LineWidth = borderWidth;
            borders.Left.Color = borderColor;
            borders.Right.BorderType = borderStyle;
            borders.Right.LineWidth = borderWidth;
            borders.Right.Color = borderColor;
        }

        // 13. Thiết lập kiểu chữ cho đoạn văn bản
        public void SetFontStyle(Paragraph paragraph, string fontStyle = "Normal", float fontSize = 12f)
        {
            if (_doc.Styles.FindByName(fontStyle) != null)
            {
                paragraph.ApplyStyle(fontStyle);
            }
            paragraph.BreakCharacterFormat.FontSize = fontSize;
        }

        // 14. Thiết lập căn lề cho đoạn văn bản
        public void SetTextAlignment(Paragraph paragraph, string text)
        {
            bool isNumber = Regex.IsMatch(text, @"^[0-9]*$");
            if (isNumber)
            {
                paragraph.Format.HorizontalAlignment = HorizontalAlignment.Right;
            }
            else
            {
                var tempValue = text.Split('.');
                if (tempValue.Length > 1)
                {
                    string valueRaw = text.Replace(".", "");
                    isNumber = decimal.TryParse(valueRaw, out _);
                    if (isNumber)
                    {
                        paragraph.Format.HorizontalAlignment = HorizontalAlignment.Right;
                    }
                    else
                    {
                        paragraph.Format.HorizontalAlignment = HorizontalAlignment.Left;
                    }
                }
            }
        }

        // 15. Thêm hình ảnh vào đoạn văn bản
        public void AddImageToParagraph(Paragraph paragraph, string base64Image, float? width = null, float? height = null)
        {
            var image = Image.FromStream(new MemoryStream(Convert.FromBase64String(base64Image)));
            var picture = paragraph.AppendPicture(image);
            picture.Width = width ?? picture.Width;
            picture.Height = height ?? picture.Height;
        }

        // 16. Sao chép dòng trong table
        public TableRow CloneRow(Table table, int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < table.Rows.Count)
            {
                return table.Rows[rowIndex].Clone() as TableRow;
            }
            return null;
        }

        // 17. Xóa bảng
        public void DeleteTable(Table table)
        {
            var section = table.Owner as Section;
            if (section != null)
            {
                section.Body.ChildObjects.Remove(table);
            }
        }

        // 18. Lấy số lượng dòng của table
        public int GetRowCount(Table table)
        {
            return table.Rows.Count;
        }

        // 19. Lấy số lượng cột của table
        public int GetColumnCount(Table table)
        {
            return table.Rows[0].Cells.Count;
        }

        // 20. Lấy giá trị của ô 
        public string GetCellValue(Table table, int rowIndex, int columnIndex)
        {
            if (rowIndex >= 0 && rowIndex < table.Rows.Count &&
                columnIndex >= 0 && columnIndex < table.Rows[rowIndex].Cells.Count)
            {
                return table.Rows[rowIndex].Cells[columnIndex].Paragraphs[0].Text;
            }
            return null;
        }

        // 21. Thêm nhiều dòng vào bảng từ mảng dữ liệu
        public void AddRowsFromDataArray(Table table, int rowIndex, string[][] dataArray)
        {
            foreach (var rowData in dataArray)
            {
                var row = AddRow(table, rowIndex++);
                for (int i = 0; i < rowData.Length && i < row.Cells.Count; i++)
                {
                    AddTextToCell(row.Cells[i], rowData[i]);
                }
            }
        }

        // 22. Thêm nhiều dòng vào bảng từ list object
        public void AddRowsFromList<T>(Table table, int rowIndex, List<T> dataList)
        {
            foreach (var data in dataList)
            {
                var row = AddRow(table, rowIndex++);
                var properties = typeof(T).GetProperties();
                for (int i = 0; i < properties.Length && i < row.Cells.Count; i++)
                {
                    AddTextToCell(row.Cells[i], properties[i].GetValue(data)?.ToString());
                }
            }
        }

        // 23. Thêm dòng tổng hợp
        public void AddSummaryRow(Table table, int rowIndex, string[] summaryData, bool mergeCells = true)
        {
            var row = AddRow(table, rowIndex);
            for (int i = 0; i < summaryData.Length && i < row.Cells.Count; i++)
            {
                AddTextToCell(row.Cells[i], summaryData[i], "Bold");
                SetCellTextAlignment(row.Cells[i], HorizontalAlignment.Center);
            }

            if (mergeCells && summaryData.Length > 1)
            {
                MergeCellsHorizontally(table, rowIndex, 0, summaryData.Length - 1);
            }
        }

        // 24. Xóa toàn bộ dòng trong bảng
        public void ClearTableRows(Table table)
        {
            table.Rows.Clear();
        }

        // 25. Tìm kiếm text trong table và trả về danh sách cell chứa text
        public List<TableCell> FindTextInTable(Table table, string text)
        {
            var foundCells = new List<TableCell>();
            foreach (TableRow row in table.Rows)
            {
                foreach (TableCell cell in row.Cells)
                {
                    if (cell.ToString().Contains(text))
                    {
                        foundCells.Add(cell);
                    }
                }
            }
            return foundCells;
        }

        // 26. Tìm kiếm text trong table và trả về cell đầu tiên chứa text
        public TableCell FindFirstCellContainingText(Table table, string text)
        {
            foreach (TableRow row in table.Rows)
            {
                foreach (TableCell cell in row.Cells)
                {
                    if (cell.ToString().Contains(text))
                    {
                        return cell;
                    }
                }
            }
            return null;
        }

        // 27. Thêm một cột mới vào bảng ở vị trí chỉ định
        public void AddColumn(Table table, int columnIndex)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                table.Rows[i].Cells.Insert(columnIndex, new TableCell(_doc));
            }
        }

        // 28. Xóa một cột khỏi bảng
        public void DeleteColumn(Table table, int columnIndex)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (columnIndex >= 0 && columnIndex < table.Rows[i].Cells.Count)
                {
                    table.Rows[i].Cells.RemoveAt(columnIndex);
                }
            }
        }

        // 29. Sao chép toàn bộ bảng
        public Table CloneTable(Table table)
        {
            return table.Clone() as Table;
        }

        // 30. Di chuyển bảng đến vị trí khác trong document
        public void MoveTable(Table table, Section targetSection, int targetIndex)
        {
            var sourceSection = table.Owner as Section;
            sourceSection.Body.ChildObjects.Remove(table);
            targetSection.Body.ChildObjects.Insert(targetIndex, table);
        }

        // 31. In đậm dòng đầu tiên của table
        public void BoldFirstRow(Table table)
        {
            if (table.Rows.Count > 0)
            {
                foreach (TableCell cell in table.Rows[0].Cells)
                {
                    foreach (Paragraph paragraph in cell.Paragraphs)
                    {
                        paragraph.BreakCharacterFormat.Bold = true;
                    }
                }
            }
        }

        // 32. In đậm dòng cuối cùng của table
        public void BoldLastRow(Table table)
        {
            if (table.Rows.Count > 0)
            {
                foreach (TableCell cell in table.Rows[table.Rows.Count - 1].Cells)
                {
                    foreach (Paragraph paragraph in cell.Paragraphs)
                    {
                        paragraph.BreakCharacterFormat.Bold = true;
                    }
                }
            }
        }

        // 33. Thiết lập lề cho toàn bộ table
        public void SetTableMargins(Table table, float top, float bottom, float left, float right)
        {
            table.TableFormat.Paddings.Top = top;
            table.TableFormat.Paddings.Bottom = bottom;
            table.TableFormat.Paddings.Left = left;
            table.TableFormat.Paddings.Right = right;
        }

        // 34. Thiết lập căn chỉnh cho toàn bộ bảng
        public void SetTableAlignment(Table table, HorizontalAlignment alignment)
        {
            table.TableFormat.HorizontalAlignment = (RowAlignment)alignment;
        }

        // 35. Thiết lập chiều rộng cho toàn bộ bảng
        public void SetTableWidth(Table table, short width, WidthType widthType)
        {
            table.PreferredWidth = new PreferredWidth(widthType, width);
        }

        // 36. Tìm kiếm và thay thế text trong toàn bộ bảng
        public void ReplaceTextInTable(Table table, string oldText, string newText)
        {
            foreach (TableRow row in table.Rows)
            {
                foreach (TableCell cell in row.Cells)
                {
                    foreach (Paragraph paragraph in cell.Paragraphs)
                    {
                        paragraph.Text = paragraph.Text.Replace(oldText, newText);
                    }
                }
            }
        }

        // 37. Thêm một đoạn xuống dòng trong ô
        public void AddLineBreakToCell(TableCell cell)
        {
            cell.AddParagraph().AppendBreak(BreakType.LineBreak);
        }

        // 38. Tạo một bảng mới từ một mảng dữ liệu
        public Table CreateTableFromDataArray(string[][] dataArray)
        {
            var table = _doc.Sections[0].AddTable(true);
            table.ResetCells(dataArray.Length, dataArray[0].Length);

            for (int i = 0; i < dataArray.Length; i++)
            {
                for (int j = 0; j < dataArray[i].Length; j++)
                {
                    AddTextToCell(table.Rows[i].Cells[j], dataArray[i][j]);
                }
            }

            return table;
        }

        // 39. Đặt màu viền cho toàn bộ bảng
        public void SetTableBorderColor(Table table, Color color)
        {
            table.TableFormat.Borders.Top.Color = color;
            table.TableFormat.Borders.Bottom.Color = color;
            table.TableFormat.Borders.Left.Color = color;
            table.TableFormat.Borders.Right.Color = color;
            table.TableFormat.Borders.Horizontal.Color = color;
            table.TableFormat.Borders.Vertical.Color = color;
        }

        // 40. Đặt độ rộng viền cho toàn bộ bảng
        public void SetTableBorderWidth(Table table, float width)
        {
            table.TableFormat.Borders.Top.LineWidth = width;
            table.TableFormat.Borders.Bottom.LineWidth = width;
            table.TableFormat.Borders.Left.LineWidth = width;
            table.TableFormat.Borders.Right.LineWidth = width;
            table.TableFormat.Borders.Horizontal.LineWidth = width;
            table.TableFormat.Borders.Vertical.LineWidth = width;
        }
    }
}