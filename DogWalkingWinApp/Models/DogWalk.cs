using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogWalkingWinApp.Models
{
    public class DogWalk
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string Phone { get; set; }
        public string DogName { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public string AgeSufix { get; set; }
        public DateTime DateAndTime { get; set; }
        public int DurationInMinutes { get; set; }
    }
}
