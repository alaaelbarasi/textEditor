using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.SelectedText);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.SelectedText);
            richTextBox1.SelectedText = "";
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = Clipboard.GetText();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            label1.Text = "None ..";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()==DialogResult.OK){
                label1.Text = saveFileDialog1.FileName;
                richTextBox1.SaveFile(saveFileDialog1.FileName,RichTextBoxStreamType.PlainText);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK){
                label1.Text = openFileDialog1.FileName;
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(fontDialog1.ShowDialog()==DialogResult.OK){
               richTextBox1.Font = fontDialog1.Font;
           }
        }

        private void foreColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()==DialogResult.OK){
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }


      
    }
}
