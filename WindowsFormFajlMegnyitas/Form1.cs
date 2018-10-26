﻿using System;
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
            if (NEV.Text!="" && (FERFI.Checked || NOSTENY.Checked ) && Hobbi.SelectedItem != null)
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
                tartalom += Hobbi.SelectedItem.ToString() + Environment.NewLine;


                for (int i = 0; i < Hobbi.Items.Count -1; i++)
                {
                    tartalom += Hobbi.Items[i] + ";" ;
                }
                tartalom += Hobbi.Items[Hobbi.Items.Count - 1];



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
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                {
                    
                    sr.ReadLine();
                    
                   
                }
            }
        }

        private void Hozzaad_Click(object sender, EventArgs e)
        {
            Hobbi.Items.Add(Hobbiszveg.Text);
        }


    }
}
