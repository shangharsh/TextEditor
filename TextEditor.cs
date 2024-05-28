using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class TextEditor : Form
    {
        public TextEditor()
        {
            InitializeComponent();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TxtTextDocument.TextLength > 0)
            {

                SaveFileDialog sFD = new SaveFileDialog();
                sFD.Filter = "Text (*.txt)|*.txt|Word Doc (*.doc)|*.doc";
                if (sFD.ShowDialog() == DialogResult.OK)
                {
                    string textDoc = this.TxtTextDocument.Text;    
                    System.IO.File.WriteAllText(sFD.FileName, textDoc);
                    MessageBox.Show("File Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtTextDocument.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please Enter FileName or Text you want to Save First.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFD = new OpenFileDialog();
            if (oFD.ShowDialog() == DialogResult.OK)
            {
                string readFile = System.IO.File.ReadAllText(oFD.FileName, Encoding.UTF8);
                this.TxtTextDocument.Text = readFile;
            }
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxtTextDocument.Clear();
        }
    }
}
