using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nationalHolidays.Model
{
    public class Localidade
    {
        [Key]

        public long Id { get; set; }
        public string Nome { get; set; }

    }
}
