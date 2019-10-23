namespace TestePratico.API.domain.Models
{
    public class Passanger
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int IdPassangerToAirplane { get; set; }

        public PassangerToAirplane PassangerToAirplane { get; set; }
    }
}
