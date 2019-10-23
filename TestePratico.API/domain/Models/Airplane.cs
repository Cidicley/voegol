using System.Collections.Generic;

namespace TestePratico.API.domain.Models
{
    public class Airplane
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public IList<Airplane> Airplanes { get; set; } = new List<Airplane>();

        public int IdPassangerToAirplane { get; set; }

        public PassangerToAirplane PassangerToAirplane { get; set; }
    }
}
