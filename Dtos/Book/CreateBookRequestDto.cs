using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Book
{
    public class CreateBookRequestDto
    {
        [Required]
        [MaxLength(20, ErrorMessage = "Klucz nie może być dłuższy niż 20 znaków")]
        public string Key { get; set; } = string.Empty;
        [Required]
        [MaxLength(50, ErrorMessage = "Tytuł nie może być dłuższy niż 50 znaków")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MaxLength(100, ErrorMessage = "Autor nie może być dłuższy niż 100 znaków")]
        public string Author { get; set; } = string.Empty;
        [Required]
        [Range(0,3000)]
        public int PublishYear { get; set; }
        [Required]
        public int Cover { get; set; }
        [Required]
        public string Subjects { get; set; } = string.Empty;
        [Required]
        public string SubjectPlace { get; set; } = string.Empty;
        [Required]
        public string SubjectTimes { get; set; } = string.Empty;
    }
}