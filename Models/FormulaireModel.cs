using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace TPLOCAL1.Models
{
    public class FormulaireModel
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string UserGender { get; set; }
        public string UserAdress { get; set; }
        public string UserZipCode { get; set; }
        public string UserTown { get; set; }
        public string UserEmail { get; set; }
        [DataType(DataType.Date)]
        public DateOnly StartDate { get; set; }
        public string CourseName { get; set; }
        public string OpinionCobol { get; set; }
        public string OpinionDotnet { get; set; }
    }
}
