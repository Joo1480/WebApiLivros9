using System.ComponentModel.DataAnnotations;

namespace WebApiLivros9.API.Models
{
    public class PaginationParams
    {
        [Range(1, int.MaxValue)]
        public int PageNumber { get; set; }
        [Range(1, 50, ErrorMessage = "O máximo de item é 50")]
        public int PageSize { get; set; }
    }
}
