using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetWars.Server
{
    public class Player
    {
        public string AuthToken { get; set; }
        public string PlayerName { get; set; }
        // this is the public Id not used for authentication and can be shared
        public int Id { get; set; }
        public int Score { get; set; }
    }
}
