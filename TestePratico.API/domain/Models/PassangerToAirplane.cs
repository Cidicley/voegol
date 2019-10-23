using System.Collections.Generic;

namespace TestePratico.API.domain.Models
{
    public class PassangerToAirplane
    {
        public int Id { get; set; }
        public int IdAirplane { get; set; }
        public int IdPassanger { get; set; }

        public IList<Airplane> Airplanes { get; set; } = new List<Airplane>();
        public IList<Passanger> Passangers { get; set; } = new List<Passanger>();
    }
}
