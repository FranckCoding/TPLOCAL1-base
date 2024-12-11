using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace TPLOCAL1.Models
{
    public class FormulaireModel
    {
        [Required(ErrorMessage ="Le nom est obligatoire.")]
        public string LastName { get; set; }
        [Required(ErrorMessage ="Le prénom est obligatoire.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="Le sexe est obligatoire.")]
        public string UserGender { get; set; }
        [Required(ErrorMessage ="L'adresse est obligatoire.")]
        public string UserAdress { get; set; }
        [RegularExpression("[0-9]{5}", ErrorMessage ="Le code postale doit être un numéro à 5 chiffres.")]
        [Required(ErrorMessage ="Le code postale est obligatoire.")]
        public string UserZipCode { get; set; }
        [Required(ErrorMessage ="La ville est obligatoire.")]
        public string UserTown { get; set; }
        [RegularExpression("^([\\w]+)@([\\w]+).([\\w]+)$", ErrorMessage ="Merci de respecter le format d'email exemple@exemple.com")]
        [Required(ErrorMessage ="L'adresse email est obligatoire.")]
        public string UserEmail { get; set; }
        [Required(ErrorMessage ="La date de début de formation est obligatoire.")]
        [DataType(DataType.Date, ErrorMessage ="Veuillez sélectionner une date valide.")]
        public DateOnly StartDate { get; set; }
        [Required(ErrorMessage ="Le nom de la formation est obligatoire.")]
        public string CourseName { get; set; }
        public string? OpinionCobol { get; set; }
        public string? OpinionDotnet { get; set; }
    }
}
