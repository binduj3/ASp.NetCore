using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebCore_Validation.CustomAttributes
{
    public class ValidateCheckBox : ValidationAttribute, IClientModelValidator
    {
        //Client side validation
            public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val-validateCheckbox", ErrorMessage);
        }

        // Server side validation
        public override bool IsValid(object value)
        {
            return (bool)value;
        }
    }
    }

