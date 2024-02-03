using System.ComponentModel.DataAnnotations;

namespace SimpleTextBoxValidationApp {
    public class DoubleValidationAttribute : ValidationAttribute {
        public override bool IsValid(object value) => double.TryParse(value.ToString(), out var _);
    }
}
