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
            if (NEV.Text!="" && (FERFI.Checked || NOSTENY.Checked))
            {
                string tartalom = NEV.Text + ";" + IDOZITO.Value + ";";
                if (FERFI.Checked == true)
                {
                    tartalom += "F;";
                }
                else
                {
                    tartalom += "N;";
                }
                tartalom += Hobbi.SelectedItem.ToString() + ";";
                List<String> list = new List<string>();

                foreach (String items in Hobbi.Items)
                {
                    list.Add(items);
                }
                foreach (string item in list)
                {
                    if (item != "") ;
                    {
                        tartalom += item + ";";
                    }
                }


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
                    File.WriteAllText(fileNev, tartalom);
                }
            }


        }

        private void Megnyitas()
        {
            if (openFileDialog.ShowDialog(this)==DialogResult.OK)
            {
                NEV.Text = File.ReadAllText(openFileDialog.FileName);
            }
            else
            {
                FERFI.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void Hozzaad_Click(object sender, EventArgs e)
        {
            Hobbi.Items.Add(Hobbiszveg.Text);
        }


    }
}
