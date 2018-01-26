using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace asp_partial_2017_10_29.Models
{
    [Bind(Include = "Name,Info,Price,Picture")]
    public class Product //:IValidatableObject
    {
        public int id { get; set; }
        //[Required]
        //[StringLength(maximumLength: 10)]
        //[Display(Order =1,Name ="Name")]
        //[MaxWordsCustomValidator(MaxWords:4,MinWords:1)]
        public string Name { get; set; }

        //[RegularExpression(pattern:@"[A-Z]",ErrorMessage ="type capital letters")]
        //[MaxWordsValidator(maxWords: 2)]//custom
        //[Remote(action: "StringInfo", controller: "Check", ErrorMessage = "must be not 'ME'",HttpMethod ="GET")]

        //[MaxWordsSingleValidator(WordCount:2)]
        public string Info { get; set; }
       
        //[Range(minimum:100, maximum:1000)]
        public int Price { get; set; }
        public byte[] Picture { get; set; }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    if (Name.Split(' ').Length > 2)
        //        yield return new ValidationResult(" {0} too many words", new[] { "Name" });
        //    else
        //        yield return ValidationResult.Success;
        //}
    }
}