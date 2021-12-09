using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Tabla
    {
        private PictureBox[] carta;
        private PictureBox[] tabla;
        public Form2()
        {
            InitializeComponent();
            carta = new PictureBox[54];
            tabla = new PictureBox[25];
            creartabla();
        }

        private void creartabla()
        {
            int r = 0, c = 0;

            for (int i = 0; i < tabla.Length; i++)
            {
                tabla[i] = new pictur();
                tabla[i].Location = new System.Drawing.Point(100 + (c * 90), 25 + (r * 125));
                tabla[i].Name = "picTabla" + i;
                tabla[i].Size = new System.Drawing.Size(85, 120);
                tabla[i].TabIndex = 0 + i;
                tabla[i].TabStop = false;
                tabla[i].SizeMode = PictureBoxSizeMode.StretchImage;
                tabla[i].Image = Image.FromFile(@"C:\Users\josel\OneDrive\Escritorio\Cartas\" + (i + 1) + ".jpg");
                this.Controls.Add(tabla[i]);
                c++;
                if (c == 5)
                {
                    r++;
                    c = 0;
                }
            }
        }
    }
}
