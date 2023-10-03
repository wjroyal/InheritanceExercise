using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            
        }
        public bool IsColdBlooded { get; set; }
        public bool IsScaly { get; set; }
        public string Habitat { get; set; }
        public bool CanRegenTail { get; set; }

    }
}
