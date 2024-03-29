﻿namespace Mumbi.Application.Wrappers
{
    public class PagedResponse<T> : Response<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int Total { get; set; }

        public PagedResponse(T data, int pageNumber, int pageSize)
        {
            PageSize = pageSize;
            PageNumber = pageNumber;
            Succeeded = true;
            Errors = null;
            Message = null;
            Data = data;
        }

        public PagedResponse(T data, int pageNumber, int pageSize, int total)
        {
            PageSize = pageSize;
            PageNumber = pageNumber;
            Total = total;
            Succeeded = true;
            Errors = null;
            Message = null;
            Data = data;
        }

        public PagedResponse(T data, string message)
        {
            Succeeded = true;
            Errors = null;
            Message = message;
            Data = data;
        }
    }
}