using System.ComponentModel.DataAnnotations;

namespace FullCart.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}