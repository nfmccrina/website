using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Website.Models
{
    public sealed class UserRegistrationFormModel : IValidatableObject
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Password != ConfirmPassword)
            {
                yield return new ValidationResult(
                    "Passwords do not match",
                    new List<string>() { nameof(ConfirmPassword)}
                );
            }
        }
    }
}