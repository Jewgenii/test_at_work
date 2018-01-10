using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace asp_partial_2017_10_29.Models
{
    public class MaxWordsValidator :ValidationAttribute
    {
        public MaxWordsValidator(int maxWords):base(()=>"{0} has too many words, more than " + maxWords)
        {
            MaxWords = maxWords;
        }
        public int MaxWords { get;private set; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var val = value.ToString();
                if (val.Split(' ').Length > MaxWords)
                {
                    var tmp = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(tmp);
                }
            }
            return ValidationResult.Success;
        }
    }


}