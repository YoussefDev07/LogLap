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

namespace LogPad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Titles Of Buttons
        ToolTip Title = new ToolTip();

        private void OpenButton_MouseHover(object sender, EventArgs e)
        {
            Title.SetToolTip(OpenButton, "Open File");
        }

        private void SaveButton_MouseHover(object sender, EventArgs e)
        {
            Title.SetToolTip(SaveButton, "Save");
        }

        private void PrintButton_MouseHover(object sender, EventArgs e)
        {
            Title.SetToolTip(PrintButton, "Print");
        }

        private void CopyButton_MouseHover(object sender, EventArgs e)
        {
            Title.SetToolTip(CopyButton, "Copy");
        }

        private void PasteButton_MouseHover(object sender, EventArgs e)
        {
            Title.SetToolTip(PasteButton, "Paste");
        }

        private void CutButton_MouseHover(object sender, EventArgs e)
        {
            Title.SetToolTip(CutButton, "Cut");
        }

        private void SelectAllButton_MouseHover(object sender, EventArgs e)
        {
            Title.SetToolTip(SelectAllButton, "Select All");
        }

        private void Undo_MouseHover(object sender, EventArgs e)
        {
            Title.SetToolTip(Undo, "Undo");
        }

        private void Redo_MouseHover(object sender, EventArgs e)
        {
            Title.SetToolTip(Redo, "Redo");
        }

        private void Ltr_MouseHover(object sender, EventArgs e)
        {
            Title.SetToolTip(Ltr, "Left to Right");
        }

        private void Rtl_MouseHover(object sender, EventArgs e)
        {
            Title.SetToolTip(Rtl, "Right to Left");
        }

        private void WordWrapButton_MouseHover(object sender, EventArgs e)
        {
            Title.SetToolTip(WordWrapButton, "Word Wrap");
        }

        private void CounterToggle_MouseHover(object sender, EventArgs e)
        {
            if (CounterVisible)
            {
                Title.SetToolTip(CounterToggle, "Hide Counter");
            }
            else
            {
                Title.SetToolTip(CounterToggle, "Show Counter");
            }
        }

        string FilePath = String.Empty;

        // Open File
        private void OpenButton_Click(object sender, EventArgs e)
        {
            var Open = new OpenFileDialog();
            Open.Filter = "Logs Files|*.log";
            Open.FileName = "" + ".log";

            var Result = Open.ShowDialog();

            if (Result == DialogResult.OK)
            {
                FilePath = Open.FileName;
                TextBox.Text = File.ReadAllText(FilePath);
                LengthCounter();
            }
        }

        // Save File
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(FilePath))
            {
                var Dialog = new SaveFileDialog();
                Dialog.Filter = "Logs Files|*.log";
                Dialog.FileName = "" + ".log";

                var Result = Dialog.ShowDialog();

                if (Result == DialogResult.OK)
                {
                    File.WriteAllText(Dialog.FileName, TextBox.Text);
                    FilePath = Dialog.FileName;
                }
            }
            else
            {
                var FileWrite = new StreamWriter(FilePath);
                FileWrite.WriteLine(TextBox.Text);
                FileWrite.Close();

                MessageBox.Show("Saved!");
            }
        }

        // Print File
        private void PrintButton_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog.Show();
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(TextBox.Text, TextBox.Font, Brushes.Black, new Point(100, 100));
        }

        // Copy
        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            TextBox.Copy();
        }

        // Paste
        private void PasteButton_Click(object sender, EventArgs e)
        {
            TextBox.Paste();
        }

        // Cut
        private void CutButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            TextBox.Cut();
        }

        // SelectAll
        private void SelectAllButton_Click(object sender, EventArgs e)
        {
            TextBox.SelectAll();
            TextBox.Focus();
        }

        // Undo
        private void Undo_Click(object sender, EventArgs e)
        {
            TextBox.Undo();
        }

        // Redo
        private void Redo_Click(object sender, EventArgs e)
        {
            TextBox.Redo();
        }

        // Ltr
        private void Ltr_Click(object sender, EventArgs e)
        {
            TextBox.RightToLeft = RightToLeft.No;
            Ltr.FlatStyle = FlatStyle.Standard;
            Rtl.FlatStyle = FlatStyle.Flat;
        }

        // Rtl
        private void Rtl_Click(object sender, EventArgs e)
        {
            TextBox.RightToLeft = RightToLeft.Yes;
            Rtl.FlatStyle = FlatStyle.Standard;
            Ltr.FlatStyle = FlatStyle.Flat;
        }

        // WordWrap
        bool actvated = false;

        private void WordWrapButton_Click(object sender, EventArgs e)
        {
            if (actvated)
            {
                TextBox.WordWrap = false;
                actvated = false;
                WordWrapButton.FlatStyle = FlatStyle.Flat;
            }
            else
            {
                TextBox.WordWrap = true;
                actvated = true;
                WordWrapButton.FlatStyle = FlatStyle.Standard;
            }
        }

        // Counter
        void LengthCounter()
        {
            int c = 0, l = 0;

            foreach (char T in TextBox.Text)
            {
                if (T == ' ' || T == '\t')
                {
                    continue;
                }

                c += 1;

                if (T == '\n')
                {
                    l += 1;
                    c -= 1;
                }
            }

            LengthNumber.Text = Convert.ToString(TextBox.Text.Length);
            CharactersNumber.Text = c.ToString();
            LinesNumber.Text = l.ToString();
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            LengthCounter();
        }

        // CounterToggle
        bool CounterVisible = false;

        private void CounterToggle_Click(object sender, EventArgs e)
        {
            if (CounterVisible)
            {
                Counter.Visible = false;
                CounterToggle.FlatStyle = FlatStyle.Flat;
                CounterVisible = false;
            }
            else
            {
                Counter.Visible = true;
                CounterToggle.FlatStyle = FlatStyle.Standard;
                CounterVisible = true;
            }
        }
    }
}
