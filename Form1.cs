using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        Stack<int> cartas = new Stack<int>();
        Random rnd = new Random();
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            inicializarTabla();
            carta = new PictureBox[54];
            tabla = new PictureBox[25];
            inicializarTabla();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.listView1.View = View.LargeIcon;
            this.imageList1.ImageSize = new Size(150, 220);
            this.listView1.LargeImageList = this.imageList1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = (54 - cartas.Count()).ToString();
            bool bandera = false;
            if (cartas.Count() == 54)
            {
                bandera = true;
                MessageBox.Show("Son Todas Las Cartas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            while (!bandera)
            {
                int num = rnd.Next(1, 54);
                if (!cartas.Contains(num))
                {
                    PictureBox1.Image = Image.FromFile(@"C:\Users\josel\OneDrive\Escritorio\Loteria-proyecto\Cartas\" + num + ".jpg");
                    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    cartas.Push(num);
                    this.imageList1.Images.Add(Image.FromFile(@"C:\Users\josel\OneDrive\Escritorio\Loteria-proyecto\Cartas\" + num + ".jpg"));

                    ListViewItem Item = new ListViewItem();
                    Item.ImageIndex = i;
                    this.listView1.Items.Add(Item);
                    bandera = true;
                    i++;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cartas.Clear();
            imageList1.Images.Clear();
            listView1.Items.Clear();
            PictureBox1.Image = null;
            i = 0;
            label1.Text = "";
        }

          private PictureBox[] carta;
          private PictureBox[] tabla;
       
        private void inicializarTabla()
        {
            int r = 0, c = 0;

            for (int i = 0; i < tabla.Length; i++)
            {
                tabla[i] = new PictureBox();
                tabla[i].Location = new System.Drawing.Point(100 + (c * 90), 25 + (r * 125));
                tabla[i].Name = "picTabla" + i;
                tabla[i].Size = new System.Drawing.Size(85, 120);
                tabla[i].TabIndex = 0 + i;
                tabla[i].TabStop = false;
                tabla[i].SizeMode = PictureBoxSizeMode.StretchImage;
                tabla[i].Image = Image.FromFile(@"C:\Users\josel\OneDrive\Escritorio\Loteria-proyecto\Cartas\" + (i + 1) + ".jpg");
                this.Controls.Add(tabla[i]);
                c++;
                if (c == 5)
                {
                    r++;
                    c = 0;
                }
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void Button3_Click(object sender, EventArgs e)
        {
            int[] cartas = new int[34];
            int[,] tabla = new int[5, 5];
            for (int i = 0; i < cartas.Length; i++) ;
            {
                cartas[i] = i + 1;
            }
            Random r = new Random();
            int a, aux;
            for (int i = 0; i < cartas.Length; i++) ;
            {
                a = r.Next(cartas.Length);
                aux = cartas[i];
                cartas[i] = cartas[a];
                cartas[a] = aux;            
            }

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    
    }
}