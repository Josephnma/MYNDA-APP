using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mynda.Shared.DTOs
{
    public class ExecutionResponse<T> where T : class
    {
        public bool HasResult { get; set; }

        public string Message { get; set; }

        public int StatusCode { get; set; }

        public T Data { get; set; }
    }

    public class PagedExecutionResponse<T> where T : class
    {
        public bool HasResult { get; set; }
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public long TotalRecords { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public int CurrentPage { get; set; }
        public T Data { get; set; }
    }
}
