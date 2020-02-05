using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binairo
{
    [Serializable]
    public class Contenu
    {
        public int row, col;
        public bool originale;
        public char valeur;
        public Contenu(int r, int c, char v, bool orig)
        {
            col = c; row = r; valeur = v; originale = orig;
        }
    }
}
