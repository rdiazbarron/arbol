using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbol
{
    internal class TNodoArbol
    {
        public string info;
        public TNodoArbol EnlaceIzquierdo;
        public TNodoArbol EnlaceDerecho;

        public TNodoArbol(string info)
        {
            this.info = info;
            EnlaceDerecho = null;
            EnlaceIzquierdo = null;
        }
    }


   


}
