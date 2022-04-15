using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace EZftp
{
    public partial class Form : System.Windows.Forms.Form
    {
        public string ADRESSE;
        public string PORT;

        public string SaveFilePath = "save.txt";

        public Form()
        {
            InitializeComponent();

            if(File.Exists(SaveFilePath))
            {
                RefreshList();
            }
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBoxAdresse.Text) || !string.IsNullOrEmpty(textBoxPort.Text))
            {
                Start();
            }
            else
            {
                MessageBox.Show("Erreur. Aucune adresse et/ou aucun port entrée.", "EZftp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Start()
        {
            ADRESSE = textBoxAdresse.Text;
            PORT = textBoxPort.Text;

            Process.Start("explorer.exe", "ftp://" + ADRESSE + ":" + PORT);

            textBoxAdresse.Text = "";
            textBoxPort.Text = "";

            if (checkSave.Checked)
            {
                SAVE();
            }

            checkSave.Checked = false;

            RefreshList();
        }

        public void RefreshList()
        {
            if (File.Exists(SaveFilePath))
            {
                listBoxSave.Items.Clear();
                string[] lines = File.ReadAllLines(SaveFilePath);
                listBoxSave.Items.AddRange(lines);
            }
        }

        public void SAVE()
        {
            if(!listBoxSave.Items.Contains(ADRESSE + ":" + PORT))
            {
                using (StreamWriter sw = File.AppendText(SaveFilePath))
                {
                    sw.WriteLine(ADRESSE + ":" + PORT);
                }
            }
            else
            {
                MessageBox.Show("Erreur. L'adresse existe déja parmis les serveurs sauvegardé", "EZftp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void listBoxSave_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxAdresse.Text = listBoxSave.SelectedItem.ToString().Split(':')[0];
            textBoxPort.Text = listBoxSave.SelectedItem.ToString().Split(':')[1];
        }

        private void lblDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment suprimer les serveurs sauvgardé ?", "EZtfp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                File.Delete(SaveFilePath);
                listBoxSave.Items.Clear();
            }
        }
    }
}
