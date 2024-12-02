using Application.Commetns.Commands;

namespace Endpoint.Models.ViewModels
{
    public class CommentViewModel
    {
  
        public string Title { get; set; }
        public string Commen { get; set; }
        public string Email { get; set; }
        public int CatalogItemId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Rating { get; set; }

        public string Slug { get; set; }
    }
}
