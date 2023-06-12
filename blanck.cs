﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LR21
{
    public partial class blanck : Form
    {
        public bool IsSaved = false;
        public string DocName = " ";
        private string BufferText = "";
        public void Cut()
        {
            this.BufferText = richTextBox1.SelectedText;
            richTextBox1.SelectedText = "";
        }
        public void Copy()
        {
            this.BufferText = richTextBox1.SelectedText;
        }
        public void Paste()
        {
            richTextBox1.SelectedText = this.BufferText;
        }
        public void SelectAll()
        {
            richTextBox1.SelectAll();
        }
        public void Delete()
        {
            richTextBox1.SelectedText = "";
            this.BufferText = "";
        }

        public void Open(string OpenFileName)
        {
            if (OpenFileName == " ")
            {
                return;
            }
            else
            {
                StreamReader sr = new StreamReader(OpenFileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
                DocName = OpenFileName;
            }
        }

        public void Save(string SaveFileName)
        {
            if(SaveFileName==" ")
            {
                return;
            }
            else
            {
                StreamWriter sw = new StreamWriter(SaveFileName);
                sw.WriteLine(richTextBox1.Text);
                sw.Close();
                DocName = SaveFileName;

            }
        }


        public blanck()
        {
            InitializeComponent();
            sbTime.Text = Convert.ToString(System.DateTime.Now.ToLongTimeString());
            sbTime.ToolTipText = Convert.ToString(System.DateTime.Today.ToLongDateString());

        }

        private void blanck_Load(object sender, EventArgs e)
        {

        }

        private void cmnuCut_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void cmnuCopy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void cmnuPaste_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void cmnuDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void blanck_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsSaved == true)
            {
                if (MessageBox.Show("Do you want save changes in " + this.DocName + "?","Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                {
                    this.Save(this.DocName);
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            sbAmount.Text = "Аmount of symbols" + richTextBox1.Text.Length.ToString();
        }
    }
}
