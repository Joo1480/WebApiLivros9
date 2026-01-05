using System.Runtime.CompilerServices;
using System.Text.Json;
using WebApiLivros9.API.Models;

namespace WebApiLivros9.API.Extensions
{
    public static class HttpExtensions
    {
        public static void AddPaginationHeader(this HttpResponse response, PaginationHeader header)
        {
            var jsonOptions = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            response.Headers.Append("Pagination", JsonSerializer.Serialize(header, jsonOptions));
            response.Headers.Append("Acess-Control-Expose-Headers", "Pagination");
        }
    }
}
