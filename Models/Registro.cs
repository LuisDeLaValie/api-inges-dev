
namespace api_inges_dev.Models
{
    public class Registro
    {
        public int id { get; set; }
        public required string nombre_completo { get; set; }
        public required string telefono { get; set; }
        public required string email { get; set; }
        public required string profesion { get; set; }
        public required int experiencia { get; set; }
        public required int fk_technology { get; set; }
        
    }
}