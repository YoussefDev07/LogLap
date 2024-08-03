namespace LogPad
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Control = new System.Windows.Forms.Panel();
            this.CounterToggle = new System.Windows.Forms.Button();
            this.WordWrapButton = new System.Windows.Forms.Button();
            this.Rtl = new System.Windows.Forms.Button();
            this.Ltr = new System.Windows.Forms.Button();
            this.Redo = new System.Windows.Forms.Button();
            this.Undo = new System.Windows.Forms.Button();
            this.SelectAllButton = new System.Windows.Forms.Button();
            this.CutButton = new System.Windows.Forms.Button();
            this.PasteButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.PrintDocument = new System.Drawing.Printing.PrintDocument();
            this.PrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.Counter = new System.Windows.Forms.Panel();
            this.LinesNumber = new System.Windows.Forms.Label();
            this.CharactersNumber = new System.Windows.Forms.Label();
            this.Lines = new System.Windows.Forms.Label();
            this.Characters = new System.Windows.Forms.Label();
            this.LengthNumber = new System.Windows.Forms.Label();
            this.Length = new System.Windows.Forms.Label();
            this.Control.SuspendLayout();
            this.Counter.SuspendLayout();
            this.SuspendLayout();
            // 
            // Control
            // 
            this.Control.Controls.Add(this.CounterToggle);
            this.Control.Controls.Add(this.WordWrapButton);
            this.Control.Controls.Add(this.Rtl);
            this.Control.Controls.Add(this.Ltr);
            this.Control.Controls.Add(this.Redo);
            this.Control.Controls.Add(this.Undo);
            this.Control.Controls.Add(this.SelectAllButton);
            this.Control.Controls.Add(this.CutButton);
            this.Control.Controls.Add(this.PasteButton);
            this.Control.Controls.Add(this.CopyButton);
            this.Control.Controls.Add(this.PrintButton);
            this.Control.Controls.Add(this.SaveButton);
            this.Control.Controls.Add(this.OpenButton);
            this.Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.Control.Location = new System.Drawing.Point(0, 0);
            this.Control.Name = "Control";
            this.Control.Size = new System.Drawing.Size(1023, 39);
            this.Control.TabIndex = 0;
            // 
            // CounterToggle
            // 
            this.CounterToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CounterToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CounterToggle.FlatAppearance.BorderSize = 0;
            this.CounterToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CounterToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CounterToggle.ForeColor = System.Drawing.Color.Black;
            this.CounterToggle.Location = new System.Drawing.Point(947, 0);
            this.CounterToggle.Name = "CounterToggle";
            this.CounterToggle.Size = new System.Drawing.Size(64, 37);
            this.CounterToggle.TabIndex = 13;
            this.CounterToggle.Text = "=0=";
            this.CounterToggle.UseVisualStyleBackColor = true;
            this.CounterToggle.Click += new System.EventHandler(this.CounterToggle_Click);
            this.CounterToggle.MouseHover += new System.EventHandler(this.CounterToggle_MouseHover);
            // 
            // WordWrapButton
            // 
            this.WordWrapButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WordWrapButton.BackgroundImage")));
            this.WordWrapButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WordWrapButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WordWrapButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.WordWrapButton.FlatAppearance.BorderSize = 0;
            this.WordWrapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WordWrapButton.Location = new System.Drawing.Point(419, 3);
            this.WordWrapButton.Name = "WordWrapButton";
            this.WordWrapButton.Size = new System.Drawing.Size(31, 32);
            this.WordWrapButton.TabIndex = 12;
            this.WordWrapButton.UseVisualStyleBackColor = true;
            this.WordWrapButton.Click += new System.EventHandler(this.WordWrapButton_Click);
            this.WordWrapButton.MouseHover += new System.EventHandler(this.WordWrapButton_MouseHover);
            // 
            // Rtl
            // 
            this.Rtl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Rtl.BackgroundImage")));
            this.Rtl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Rtl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rtl.FlatAppearance.BorderSize = 0;
            this.Rtl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rtl.Location = new System.Drawing.Point(382, 4);
            this.Rtl.Name = "Rtl";
            this.Rtl.Size = new System.Drawing.Size(31, 32);
            this.Rtl.TabIndex = 11;
            this.Rtl.UseVisualStyleBackColor = true;
            this.Rtl.Click += new System.EventHandler(this.Rtl_Click);
            this.Rtl.MouseHover += new System.EventHandler(this.Rtl_MouseHover);
            // 
            // Ltr
            // 
            this.Ltr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ltr.BackgroundImage")));
            this.Ltr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Ltr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ltr.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Ltr.FlatAppearance.BorderSize = 0;
            this.Ltr.Location = new System.Drawing.Point(345, 4);
            this.Ltr.Name = "Ltr";
            this.Ltr.Size = new System.Drawing.Size(31, 32);
            this.Ltr.TabIndex = 10;
            this.Ltr.UseVisualStyleBackColor = true;
            this.Ltr.Click += new System.EventHandler(this.Ltr_Click);
            this.Ltr.MouseHover += new System.EventHandler(this.Ltr_MouseHover);
            // 
            // Redo
            // 
            this.Redo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Redo.BackgroundImage")));
            this.Redo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Redo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Redo.FlatAppearance.BorderSize = 0;
            this.Redo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Redo.Location = new System.Drawing.Point(308, 4);
            this.Redo.Name = "Redo";
            this.Redo.Size = new System.Drawing.Size(31, 32);
            this.Redo.TabIndex = 9;
            this.Redo.UseVisualStyleBackColor = true;
            this.Redo.Click += new System.EventHandler(this.Redo_Click);
            this.Redo.MouseHover += new System.EventHandler(this.Redo_MouseHover);
            // 
            // Undo
            // 
            this.Undo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Undo.BackgroundImage")));
            this.Undo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Undo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Undo.FlatAppearance.BorderSize = 0;
            this.Undo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Undo.Location = new System.Drawing.Point(271, 4);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(31, 32);
            this.Undo.TabIndex = 8;
            this.Undo.UseVisualStyleBackColor = true;
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            this.Undo.MouseHover += new System.EventHandler(this.Undo_MouseHover);
            // 
            // SelectAllButton
            // 
            this.SelectAllButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SelectAllButton.BackgroundImage")));
            this.SelectAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SelectAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectAllButton.FlatAppearance.BorderSize = 0;
            this.SelectAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectAllButton.Location = new System.Drawing.Point(234, 4);
            this.SelectAllButton.Name = "SelectAllButton";
            this.SelectAllButton.Size = new System.Drawing.Size(31, 32);
            this.SelectAllButton.TabIndex = 7;
            this.SelectAllButton.UseVisualStyleBackColor = true;
            this.SelectAllButton.Click += new System.EventHandler(this.SelectAllButton_Click);
            this.SelectAllButton.MouseHover += new System.EventHandler(this.SelectAllButton_MouseHover);
            // 
            // CutButton
            // 
            this.CutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CutButton.BackgroundImage")));
            this.CutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CutButton.FlatAppearance.BorderSize = 0;
            this.CutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CutButton.Location = new System.Drawing.Point(197, 4);
            this.CutButton.Name = "CutButton";
            this.CutButton.Size = new System.Drawing.Size(31, 32);
            this.CutButton.TabIndex = 6;
            this.CutButton.UseVisualStyleBackColor = true;
            this.CutButton.Click += new System.EventHandler(this.CutButton_Click);
            this.CutButton.MouseHover += new System.EventHandler(this.CutButton_MouseHover);
            // 
            // PasteButton
            // 
            this.PasteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PasteButton.BackgroundImage")));
            this.PasteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PasteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PasteButton.FlatAppearance.BorderSize = 0;
            this.PasteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasteButton.Location = new System.Drawing.Point(160, 3);
            this.PasteButton.Name = "PasteButton";
            this.PasteButton.Size = new System.Drawing.Size(31, 32);
            this.PasteButton.TabIndex = 5;
            this.PasteButton.UseVisualStyleBackColor = true;
            this.PasteButton.Click += new System.EventHandler(this.PasteButton_Click);
            this.PasteButton.MouseHover += new System.EventHandler(this.PasteButton_MouseHover);
            // 
            // CopyButton
            // 
            this.CopyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CopyButton.BackgroundImage")));
            this.CopyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CopyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CopyButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CopyButton.FlatAppearance.BorderSize = 0;
            this.CopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyButton.Location = new System.Drawing.Point(123, 3);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(31, 32);
            this.CopyButton.TabIndex = 4;
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            this.CopyButton.MouseHover += new System.EventHandler(this.CopyButton_MouseHover);
            // 
            // PrintButton
            // 
            this.PrintButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PrintButton.BackgroundImage")));
            this.PrintButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PrintButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintButton.FlatAppearance.BorderSize = 0;
            this.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintButton.Location = new System.Drawing.Point(86, 3);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(31, 32);
            this.PrintButton.TabIndex = 3;
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            this.PrintButton.MouseHover += new System.EventHandler(this.PrintButton_MouseHover);
            // 
            // SaveButton
            // 
            this.SaveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveButton.BackgroundImage")));
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Location = new System.Drawing.Point(49, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(31, 32);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            this.SaveButton.MouseHover += new System.EventHandler(this.SaveButton_MouseHover);
            // 
            // OpenButton
            // 
            this.OpenButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OpenButton.BackgroundImage")));
            this.OpenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenButton.FlatAppearance.BorderSize = 0;
            this.OpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenButton.Location = new System.Drawing.Point(3, -5);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(47, 48);
            this.OpenButton.TabIndex = 0;
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            this.OpenButton.MouseHover += new System.EventHandler(this.OpenButton_MouseHover);
            // 
            // TextBox
            // 
            this.TextBox.DetectUrls = false;
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox.Location = new System.Drawing.Point(0, 39);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(1023, 489);
            this.TextBox.TabIndex = 1;
            this.TextBox.Text = "";
            this.TextBox.WordWrap = false;
            this.TextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyUp);
            // 
            // PrintDocument
            // 
            this.PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
            // 
            // PrintPreviewDialog
            // 
            this.PrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreviewDialog.Document = this.PrintDocument;
            this.PrintPreviewDialog.Enabled = true;
            this.PrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewDialog.Icon")));
            this.PrintPreviewDialog.Name = "printPreviewDialog1";
            this.PrintPreviewDialog.ShowIcon = false;
            this.PrintPreviewDialog.Visible = false;
            // 
            // Counter
            // 
            this.Counter.Controls.Add(this.LinesNumber);
            this.Counter.Controls.Add(this.CharactersNumber);
            this.Counter.Controls.Add(this.Lines);
            this.Counter.Controls.Add(this.Characters);
            this.Counter.Controls.Add(this.LengthNumber);
            this.Counter.Controls.Add(this.Length);
            this.Counter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Counter.Location = new System.Drawing.Point(0, 504);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(1023, 24);
            this.Counter.TabIndex = 2;
            this.Counter.Visible = false;
            // 
            // LinesNumber
            // 
            this.LinesNumber.AutoSize = true;
            this.LinesNumber.Location = new System.Drawing.Point(291, 4);
            this.LinesNumber.Name = "LinesNumber";
            this.LinesNumber.Size = new System.Drawing.Size(14, 16);
            this.LinesNumber.TabIndex = 5;
            this.LinesNumber.Text = "0";
            // 
            // CharactersNumber
            // 
            this.CharactersNumber.AutoSize = true;
            this.CharactersNumber.Location = new System.Drawing.Point(191, 4);
            this.CharactersNumber.Name = "CharactersNumber";
            this.CharactersNumber.Size = new System.Drawing.Size(14, 16);
            this.CharactersNumber.TabIndex = 4;
            this.CharactersNumber.Text = "0";
            // 
            // Lines
            // 
            this.Lines.AutoSize = true;
            this.Lines.Location = new System.Drawing.Point(252, 4);
            this.Lines.Name = "Lines";
            this.Lines.Size = new System.Drawing.Size(42, 16);
            this.Lines.TabIndex = 3;
            this.Lines.Text = "Lines:";
            this.Lines.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Characters
            // 
            this.Characters.AutoSize = true;
            this.Characters.Location = new System.Drawing.Point(121, 4);
            this.Characters.Name = "Characters";
            this.Characters.Size = new System.Drawing.Size(68, 16);
            this.Characters.TabIndex = 2;
            this.Characters.Text = "Character:";
            this.Characters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LengthNumber
            // 
            this.LengthNumber.AutoSize = true;
            this.LengthNumber.Location = new System.Drawing.Point(52, 4);
            this.LengthNumber.Name = "LengthNumber";
            this.LengthNumber.Size = new System.Drawing.Size(14, 16);
            this.LengthNumber.TabIndex = 1;
            this.LengthNumber.Text = "0";
            // 
            // Length
            // 
            this.Length.AutoSize = true;
            this.Length.Location = new System.Drawing.Point(5, 4);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(50, 16);
            this.Length.TabIndex = 0;
            this.Length.Text = "Length:";
            this.Length.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1023, 528);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.Control);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 150);
            this.Name = "Form1";
            this.Text = "LogPad";
            this.Control.ResumeLayout(false);
            this.Counter.ResumeLayout(false);
            this.Counter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Control;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Drawing.Printing.PrintDocument PrintDocument;
        private System.Windows.Forms.PrintPreviewDialog PrintPreviewDialog;
        private System.Windows.Forms.Button CutButton;
        private System.Windows.Forms.Button PasteButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button SelectAllButton;
        private System.Windows.Forms.Button Redo;
        private System.Windows.Forms.Button Undo;
        private System.Windows.Forms.Button Rtl;
        private System.Windows.Forms.Button Ltr;
        private System.Windows.Forms.Button WordWrapButton;
        private System.Windows.Forms.Panel Counter;
        private System.Windows.Forms.Label Length;
        private System.Windows.Forms.Label LengthNumber;
        private System.Windows.Forms.Label LinesNumber;
        private System.Windows.Forms.Label CharactersNumber;
        private System.Windows.Forms.Label Lines;
        private System.Windows.Forms.Label Characters;
        private System.Windows.Forms.Button CounterToggle;
    }
}

