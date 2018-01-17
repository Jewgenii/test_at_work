using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp_partial_2017_10_29.Models
{
    public class MaxWordsValidator :ValidationAttribute,IClientValidatable
    {
        public MaxWordsValidator(int WordCount, int MinWords=0) :base(()=>"{0} has too many words, more than " +
                                                            WordCount + (MinWords!=0?"and not less than "+ MinWords : ""))
        {
            this.WordCount = WordCount;
            this.MinWords = MinWords;
        }
        public int WordCount { get;private set; }
        public int MinWords { get; set; }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            ModelClientValidationRule rule = new ModelClientValidationRule();
            rule.ErrorMessage = FormatErrorMessage(metadata.GetDisplayName());
          
            rule.ValidationParameters.Add("wordcount", this.WordCount);
            rule.ValidationParameters.Add("minwords", this.MinWords);
            rule.ValidationType = "maxwords";

            yield return rule;

        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var val = value.ToString();
                var words = val.Split(' ').Length;
               
                if (words > WordCount || words < MinWords)
                {
                    var tmp = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(tmp);
                }
            }
            return ValidationResult.Success;
        }
    }


}