using System.ComponentModel.DataAnnotations;

namespace AspDotNetRazorDemoProject.Models
{
    public class BaseViewModel
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.DateTime)]

        public DateTime? Created_at { get; set; }=DateTime.Now;
    }
}
