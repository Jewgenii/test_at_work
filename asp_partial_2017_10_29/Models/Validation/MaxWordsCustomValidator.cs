using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp_partial_2017_10_29.Models
{
    public class MaxWordsCustomValidator :ValidationAttribute,IClientValidatable
    {
        public MaxWordsCustomValidator(int MaxWords, int MinWords=0) :base(()=>"{0} has too many words, more than " +
                                                            MaxWords + (MinWords!=0?"and not less than "+ MinWords : ""))
        {
            this.MaxWords = MaxWords;
            this.MinWords = MinWords;
        }
        public int MaxWords { get;private set; }
        public int MinWords { get; set; }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            ModelClientValidationRule rule = new ModelClientValidationRule();
            rule.ErrorMessage = FormatErrorMessage(metadata.GetDisplayName());

            string s = string.Format("{0},{1}", MinWords, MaxWords);
            rule.ValidationParameters.Add("words", s);
            rule.ValidationType = "maxwordscustom";

            yield return rule;
           
        }

        public override string FormatErrorMessage(string name)
        {
            return base.FormatErrorMessage(name);
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var val = value.ToString();
                var words = val.Split(' ').Length;
               
                if (words > MaxWords || words < MinWords)
                {
                    var tmp = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(tmp);
                }
            }
            return ValidationResult.Success;
        }
    }


}