using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiImoveis.Models
{
    public class CustomValidator : ValidationAttribute
    {
        private string FildName { get; set; }

        public CustomValidator(string field)
        {
            FildName = field;
        }
        MigrationContext db = new MigrationContext();

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            if (FildName == "Nome")
            {
                if (db.Proprietarios.FirstOrDefault(x => x.Nome == value.ToString()) != null)
                    return new ValidationResult("Usúario já cadastrado");
            }

            if (FildName == "DataNasc")
            {
                DateTime valueData = Convert.ToDateTime(value); //DownCast

                
                if (DateTime.Now.Year - valueData.Year < 18 || DateTime.Now.Year - valueData.Year > 150)
                {
                     return new ValidationResult("Idade Incorreta");
                }

            }
          


            return ValidationResult.Success;
        }
    }
}
  
