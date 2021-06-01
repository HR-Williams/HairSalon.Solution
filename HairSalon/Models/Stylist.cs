using System.Collections.Generic;

namespace HairSalon.Models
{
    public class Stylist
    {
        private static List<Stylist> _instances = new List<Stylist> {};

        public Stylist()
        {
            this.Clients = new HashSet<Client>();
        }

        public int StylistId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}