using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Response
{
    public class PagedResponse<T>
    {
        /// <summary>
        ///  Thông tin của phân trang
        /// </summary>
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public int TotalRecords { get; set; }
        public List<T> Datas { get; set; }
        public bool HasPreviousPage => PageNumber > 1;

        public PagedResponse(List<T> data, int pageNumber, int pageSize, int totalRecords)
        {
            Datas = data;
            PageNumber = pageNumber;
            PageSize = pageSize;
            TotalRecords = totalRecords;
            TotalPages = (int)Math.Ceiling(totalRecords / (double)pageSize);
        }

        public static PagedResponse<T> CreatePagedResponse(List<T> data, int pageNumber, int pageSize, int totalRecords)
        {
            return new PagedResponse<T>(data, pageNumber, pageSize, totalRecords);
        }
    }
}
