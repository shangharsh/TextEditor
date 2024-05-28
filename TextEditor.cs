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
            if (TxtFileName.TextLength > 0 && TxtTextDocument.TextLength > 0)
            {
                string fn;
                string textDoc;
                fn = "C:\\Users\\shang\\OneDrive\\Desktop\\" + TxtFileName.Text + ".txt";
                textDoc = this.TxtTextDocument.Text;    
                System.IO.File.WriteAllText(fn, textDoc);
                MessageBox.Show("File Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtFileName.Clear();
                TxtTextDocument.Clear();
            }
            else
            {
                MessageBox.Show("Please Enter FileName or Text you want to Save First.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //this.ShowDialog();
            //string fn = "C:\\Users\\shang\\OneDrive\\Desktop" + +".txt";
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
