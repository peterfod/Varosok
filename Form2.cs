using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var orszagok = Form1.lista.Select(x => x.Orszag).Distinct();
            foreach (var item in orszagok)
            {
                cmbOrszag.Items.Add(item);
            }
        }

        private void cmbOrszag_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            foreach (var item in Form1.lista)
            {
                if (item.Orszag == cmbOrszag.Text)
                {
                    richTextBox1.Text += item.Nev + "\n";
                }
            }
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile("szures.txt", RichTextBoxStreamType.PlainText);
            MessageBox.Show("A lista mentése sikerült.", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
