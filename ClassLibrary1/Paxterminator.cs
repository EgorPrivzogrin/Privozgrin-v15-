using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Paxterminator
    {
        public Ase Ase { get; set; }
        public Opciones Opciones { get; set; }
        public Paxterminator() 
        {
            Opciones = new Opciones();
            Ase = new Ase();
        }
       
    }
}
