using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Ase
    {
        public Paxterminator Paxterminator { get; set; }
        public Pantalla? Pantalla { get; set; }
        public Ase()
        {
            Paxterminator = new Paxterminator(); 
        }
    }
}
