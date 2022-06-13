using System.ComponentModel.DataAnnotations.Schema;

namespace nationalHolidays.Model
{
    [Table("Continente")]
    public class Continente : Localidade
    {
        
        public Regiao Regiao { get; set; }
    }
}
