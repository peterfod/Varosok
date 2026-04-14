using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Varosok
{
    public partial class Form1 : Form
    {
        public static List<Varos> lista = new List<Varos>();
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuMegnyitas_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string elsosor = sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    Varos sor = new Varos(sr.ReadLine());
                    lista.Add(sor);
                }
                sr.Dispose();

                foreach (var item in lista)
                {
                    listBox1.Items.Add(item.Nev);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbOrszag.Text = lista[listBox1.SelectedIndex].Orszag;
            txbNepesseg.Text = lista[listBox1.SelectedIndex].Nepesseg.ToString("#,##0");
        }

        private void rdbLegkisebb_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbLegkisebb.Checked)
            {
                var min = lista.OrderBy(x => x.Nepesseg).First();
                txbVaros.Text = min.Nev;
            }
        }

        private void rdbLegnagyobb_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbLegnagyobb.Checked)
            {
                var max = lista.OrderBy(x => x.Nepesseg).Last();
                txbVaros.Text = max.Nev;
            }
        }

        private void rdbNovekvo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNovekvo.Checked)
            {
                var novekvo = lista.OrderBy(x => x.Nepesseg).ToList();
                listBox1.Items.Clear();
                foreach (var item in novekvo)
                {
                    listBox1.Items.Add(item.Nev);
                }
            }
        }

        private void rdbCsokkeno_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCsokkeno.Checked)
            {
                var csokkeno = lista.OrderByDescending(x => x.Nepesseg).ToList();
                listBox1.Items.Clear();
                foreach (var item in csokkeno)
                {
                    listBox1.Items.Add(item.Nev);
                }
            }
        }

        private void mnuSzures_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 szures = new Form2();
            szures.ShowDialog();
            szures.Dispose();
            this.Show();
        }
    }

    public class Varos
    {
        public string  Helyezes { get; set; }
        public string Nev { get; set; }
        public string Orszag { get; set; }
        public int Nepesseg { get; set; }

        public Varos(string sor)
        {
            string[] reszek = sor.Split(';');
            Helyezes = reszek[0];
            Nev = reszek[1];
            Orszag = reszek[2];
            Nepesseg = int.Parse(reszek[3]);
        } 
    }


}
