using System.ComponentModel.DataAnnotations;

namespace Calculator.Models
{
    public class OperationViewModel
    {
        [Required(ErrorMessage = "This field is required.")]
        public OperationType? Type { get; set; }

        [Required(ErrorMessage= "This field is required.")]
        [Display(Name = "Number 1")]
        public long? Number1 { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [Display(Name = "Number 2")]
        public long? Number2 { get; set; }
        public double? Result { get; set; }
    }

    public enum OperationType
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    } 
}
