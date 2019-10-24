using System.Collections.Generic;

namespace TestePratico.API.domain.Models
{
    public class Passanger
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public IList<Passanger> Airplanes { get; set; } = new List<Passanger>();

        public int IdPassangerToAirplane { get; set; }

        public PassangerToAirplane PassangerToAirplane { get; set; }
    }
}
