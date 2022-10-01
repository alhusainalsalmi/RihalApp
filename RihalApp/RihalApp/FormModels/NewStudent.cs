using System.ComponentModel.DataAnnotations;

namespace RihalApp.FormModels
{
    public sealed class NewStudent
    {
        [Required]
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; } = DateTime.Now;
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please Select Country")]
        public int CountryId { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please Select Class")]
        public int ClassId { get; set; }

    }
}
