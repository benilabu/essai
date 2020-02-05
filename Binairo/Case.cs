using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Binairo
{
    public class Case : Button
    {
        public int row, col;
        public Boolean originale;
        public Case(int x, int y, int row, int col, Panel p,
            bool originale, EventHandler evh)
        {
            Parent = p;
            Top = y; Left = x;
            this.row = row; this.col = col;
            Height = 40; Width = 40;
            Text = " ";
            this.originale = originale;
            this.Font = new Font(this.Font.FontFamily, 12, FontStyle.Bold);
            Click += evh;
            SetValue(" ");
            BackColor = Color.LightCyan;
        }
        public Case() { }
        public void SetValue(string value)
        {
            Text = value;
            if (originale) ForeColor = Color.DarkBlue;
            else switch (value[0])
            {
                case ' ' : break;
                case '1': ForeColor = Color.Red; break;
                case '0': ForeColor = Color.DarkMagenta; break;
            };
        }
    }
}
