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

                var fD = new System.Windows.Forms.SaveFileDialog();
                fD.Filter = "Text (*.txt)|*.txt|Word Doc (*.doc)|*.doc";
                if (fD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string textDoc = this.TxtTextDocument.Text;    
                    System.IO.File.WriteAllText(fD.FileName, textDoc);
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
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(FD.FileName);
                TxtTextDocument.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
    }
}
