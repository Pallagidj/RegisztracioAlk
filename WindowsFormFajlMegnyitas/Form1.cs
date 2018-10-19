using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormFajlMegnyitas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Save.Click += (sender, e) =>
            {
                Mentes();
            };
            Open.Click += (sender, e) =>
            {

                Megnyitas();
            };

        }
        private void Mentes()
        {
            string tartalom = textBox1.Text + ";" + textBox2.Text;
            saveFileDialog.FileName = "Naplo.txt";
            var eredmeny = saveFileDialog.ShowDialog(this);
            if (eredmeny == DialogResult.OK)
            {
                string fileNev = saveFileDialog.FileName;
               /* 
               using (var file = File.CreateText(fileNev))
                {
                    file.Write(tartalom);
                }
                */
                File.WriteAllText(fileNev,tartalom);
            }


        }

        private void Megnyitas()
        {
            if (openFileDialog.ShowDialog(this)==DialogResult.OK)
            {
                Hobbiszveg.Text = File.ReadAllText(openFileDialog.FileName);
            }

        }

        private void Hozzaad_Click(object sender, EventArgs e)
        {
            Hobbi.Items.Add(Hobbiszveg.Text);
        }
    }
}
