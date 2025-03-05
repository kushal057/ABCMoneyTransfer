﻿namespace ABC.Client.APIModels
{
    public class ApiResponse
    {
        public bool Success { get; set; } = true;
        public string Data { get; set; } 
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public int TotalCount { get; set; }

        public ApiResponse(string data, string message = null, int statusCode = 200)
        {
            Data = data;
            Message = message;
            StatusCode = statusCode;
        }
    }
}
