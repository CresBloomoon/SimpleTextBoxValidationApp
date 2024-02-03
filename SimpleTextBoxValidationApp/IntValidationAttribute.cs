using System.ComponentModel.DataAnnotations;

namespace SimpleTextBoxValidationApp {
    public class IntValidationAttribute : ValidationAttribute {
        public override bool IsValid(object value) => int.TryParse(value.ToString(), out var _);
    }
}
