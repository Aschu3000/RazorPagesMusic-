using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMusic.Models
{
    public class Music
    {
        public int ID { get; set; }

        [Required, StringLength(60, MinimumLength = 3)]
        public string Title { get; set; } = string.Empty;

        [Required, StringLength(60, MinimumLength = 3)]
        public string Artist { get; set; } = string.Empty;

        [Required, StringLength(30, MinimumLength = 3), RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string Genre { get; set; } = string.Empty;

        [Required, Display(Name = "Release Date"), DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required, StringLength(30, MinimumLength = 3), RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        public string Rating { get; set; } = string.Empty;
    }
}
