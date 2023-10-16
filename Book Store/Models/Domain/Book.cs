using System.ComponentModel.DataAnnotations;

namespace Book_Store.Models.Domain
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Isbn { get; set; }
        [Required]
        public string TotalPages { get; set; }
        [Required]
        public string AuthorId { get; set; }
        [Required]
        public string PublisherId { get; set; }
        [Required]
        public string GenreId { get; set; }

    }
}
