using System.ComponentModel.DataAnnotations;
namespace web_api.Models{
    public class Puestos{
        [Key]
        public int idPuesto { get; set; }
        public string puesto { get; set; }
    }
}