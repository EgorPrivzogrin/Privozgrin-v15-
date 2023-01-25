using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Item : Elementos
    {
        public int Tipo;
        public int Trigger;
        public  Proyectiles Proyectiles { get; set; }
        public Item(Proyectiles proyectiles) 
        { 
            Proyectiles= proyectiles;
        }

    }
}
