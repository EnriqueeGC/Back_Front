using System.ComponentModel.DataAnnotations;
namespace web_api.Models{
    public class Empleados{
        [Key]
        public int idEmpleado { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public int idPuesto { get; set; }
        public string fecha_nacimiento { get; set; }
        public string fecha_registro { get; set; }
    }
}