using System;
using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nume Student")]
        public string Nume { get; set; }

        [Display(Name = "Admis")]
        public bool Admis { get; set; }

        [Display(Name = "Numar laboratoare")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a valid number")]
        public int NumarLaboratoare { get; set; }

        [Required(ErrorMessage = "Indica Grupa Studentului")]
        [RegularExpression("MI[A-Z]230[1-2]", ErrorMessage = "Grupa trebuie sa fie MIA2301 sau MIA2302")]
        public string Grupa { get; set; }
    }
}
