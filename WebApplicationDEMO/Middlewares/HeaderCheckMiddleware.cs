﻿namespace WebApplicationDEMO.Middlewares
{
    public class HeaderCheckMiddleware
    {

        private readonly RequestDelegate _next;
        private readonly string _headerName;

        public HeaderCheckMiddleware(RequestDelegate next, string headerName)
        {
            _next = next;
            _headerName = headerName;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (!context.Request.Headers.ContainsKey(_headerName))
            {
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                await context.Response.WriteAsync($"Missing requeired header: {_headerName}");
                return;
            }
            await _next(context);

        }
    }
}
