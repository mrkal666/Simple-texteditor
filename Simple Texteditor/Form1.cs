using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Simple_Texteditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Dialog for saving
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            }
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Dialog for opening
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // exit button
            Application.Exit();
        }

        private void AboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // About button
            new AboutBox1().Show();
        }

        private void WebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Website button
            System.Diagnostics.Process.Start("https://mrkal.fi");
        }

        private void DarkModeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Dark mode button
            this.BackColor = Color.Gray;
            richTextBox1.BackColor = Color.DarkSlateGray;
            richTextBox1.ForeColor = Color.White;
        }

        private void DefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Default theme button
            this.BackColor = Color.White;
            richTextBox1.BackColor = Color.White;
            richTextBox1.ForeColor = Color.Black;
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Help page button
            System.Diagnostics.Process.Start("https://mrkal.fi/simple/help");
        }



    }
}
