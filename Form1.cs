using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;

namespace LR21
{
    public partial class frmmain : Form
    {
        private int openDocuments = 0;
        public frmmain()
        {
            InitializeComponent();
            saveToolStripMenuItem.Enabled = false;
            
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("uk-UA");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blanck frm = new blanck();
            frm.DocName = "Untitled " + ++openDocuments;
            frm.Text = frm.DocName;
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuArrange_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void mnuCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuTileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuTileVerticale_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuCut_Click(object sender, EventArgs e)
        {
            blanck frm = (blanck)this.ActiveMdiChild;
            frm.Cut();
        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            blanck frm = (blanck)this.ActiveMdiChild;
            frm.Copy();
        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            blanck frm = (blanck)this.ActiveMdiChild;
            frm.Paste();
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            blanck frm = (blanck)this.ActiveMdiChild;
            frm.Delete();

        }

        private void mnuSelectAll_Click(object sender, EventArgs e)
        {
            blanck frm = (blanck)this.ActiveMdiChild;
            frm.SelectAll();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                blanck frm = new blanck();
                frm.Open(openFileDialog1.FileName);
                frm.MdiParent = this;
                frm.DocName = openFileDialog1.FileName;
                frm.Text = frm.DocName;
                frm.Show();
                saveToolStripMenuItem.Enabled = true;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                blanck frm = (blanck)this.ActiveMdiChild;
                frm.Save(saveFileDialog1.FileName);
                frm.MdiParent = this;
                frm.DocName = saveFileDialog1.FileName;
                frm.Text = frm.DocName;
                frm.Save(frm.DocName);
                frm.IsSaved = true;

            }
        }

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                blanck frm = (blanck)this.ActiveMdiChild;
                frm.Save(saveFileDialog1.FileName);
                frm.MdiParent = this;
                frm.DocName = saveFileDialog1.FileName;
                frm.Text = frm.DocName;
                saveToolStripMenuItem.Enabled = true;
                frm.IsSaved = true;
            }
        }

        private void mnuFont_Click(object sender, EventArgs e)
        {
            blanck frm = (blanck)this.ActiveMdiChild;
            frm.MdiParent = this;
            fontDialog1.ShowColor = true;
            fontDialog1.Font = frm.richTextBox1.SelectionFont;
            fontDialog1.Color = frm.richTextBox1.SelectionColor;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                frm.richTextBox1.SelectionFont = fontDialog1.Font;
                frm.richTextBox1.SelectionColor = fontDialog1.Color;
            }
            frm.Show();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blanck frm = (blanck)this.ActiveMdiChild;
            frm.MdiParent = this;
            colorDialog1.Color = frm.richTextBox1.SelectionColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                frm.richTextBox1.SelectionColor = colorDialog1.Color;
            }
            frm.Show();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuFind_Click(object sender, EventArgs e)
        {
            FindForm frm = new FindForm();
            if (frm.ShowDialog(this) == DialogResult.Cancel) return;
            blanck form = (blanck)this.ActiveMdiChild;
            form.MdiParent = this;
            int start = form.richTextBox1.SelectionStart;
            form.richTextBox1.Find(frm.FindText, start, frm.FindCondition);
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            blanck frm = new blanck();
            frm.DocName = "Untitled " + ++openDocuments;
            frm.Text = frm.DocName;
            frm.MdiParent = this;
            frm.Show();
        }

        private void tbOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                blanck frm = new blanck();
                frm.Open(openFileDialog1.FileName);
                frm.MdiParent = this;
                frm.DocName = openFileDialog1.FileName;
                frm.Text = frm.DocName;
                frm.Show();
                saveToolStripMenuItem.Enabled = true;
            }
        }

        private void tbSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                blanck frm = (blanck)this.ActiveMdiChild;
                frm.Save(saveFileDialog1.FileName);
                frm.MdiParent = this;
                frm.DocName = saveFileDialog1.FileName;
                frm.Text = frm.DocName;
                saveToolStripMenuItem.Enabled = true;
                frm.IsSaved = true;
            }
        }

        private void tbCut_Click(object sender, EventArgs e)
        {
            blanck frm = (blanck)this.ActiveMdiChild;
            frm.Cut();
        }

        private void tbCopy_Click(object sender, EventArgs e)
        {
            blanck frm = (blanck)this.ActiveMdiChild;
            frm.Copy();
        }

        private void tbPaste_Click(object sender, EventArgs e)
        {
            blanck frm = (blanck)this.ActiveMdiChild;
            frm.Paste();
        }

        private void ukraineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tsAlignLeft_Click(object sender, EventArgs e)
        {
            blanck frm = (blanck)this.ActiveMdiChild;
            frm.richTextBox1.SelectionAlignment = HorizontalAlignment.Left;

        }

        private void tsCenter_Click(object sender, EventArgs e)
        {
            blanck frm = (blanck)this.ActiveMdiChild;
            frm.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void tsRight_Click(object sender, EventArgs e)
        {
            blanck frm = (blanck)this.ActiveMdiChild;
            frm.richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void tsAddImage_Click(object sender, EventArgs e)
        {
            blanck frm = (blanck)this.ActiveMdiChild;
            // Показуємо діалогове вікно вибору файлу
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Завантажуємо зображення з вибраного файлу
                Image image = Image.FromFile(openFileDialog.FileName);

                // Відображаємо зображення в PictureBox
                frm.pictureBox1.Image = image;
            }
            
            if (frm.pictureBox1.Image != null)
            {
                // Вставляємо зображення з PictureBox в RichTextBox
                Clipboard.SetDataObject(frm.pictureBox1.Image, true);
                frm.richTextBox1.Paste();
            }

        }
    }
}
