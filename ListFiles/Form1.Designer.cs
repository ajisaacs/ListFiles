namespace ListFiles
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.directoryBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.showFileExtensionsBox = new System.Windows.Forms.CheckBox();
            this.showFullPathsBox = new System.Windows.Forms.CheckBox();
            this.searchPatternBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.filesBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.directoryBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.browseButton, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(633, 29);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directory :";
            // 
            // directoryBox
            // 
            this.directoryBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.directoryBox.Location = new System.Drawing.Point(64, 4);
            this.directoryBox.Name = "directoryBox";
            this.directoryBox.Size = new System.Drawing.Size(480, 20);
            this.directoryBox.TabIndex = 1;
            this.directoryBox.TextChanged += new System.EventHandler(this.directoryBox_TextChanged);
            // 
            // browseButton
            // 
            this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButton.Location = new System.Drawing.Point(550, 3);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(80, 23);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // showFileExtensionsBox
            // 
            this.showFileExtensionsBox.AutoSize = true;
            this.showFileExtensionsBox.Location = new System.Drawing.Point(148, 70);
            this.showFileExtensionsBox.Name = "showFileExtensionsBox";
            this.showFileExtensionsBox.Size = new System.Drawing.Size(126, 17);
            this.showFileExtensionsBox.TabIndex = 1;
            this.showFileExtensionsBox.Text = "Show File Extensions";
            this.showFileExtensionsBox.UseVisualStyleBackColor = true;
            this.showFileExtensionsBox.CheckedChanged += new System.EventHandler(this.showFileExtensionsBox_CheckedChanged);
            // 
            // showFullPathsBox
            // 
            this.showFullPathsBox.AutoSize = true;
            this.showFullPathsBox.Location = new System.Drawing.Point(12, 70);
            this.showFullPathsBox.Name = "showFullPathsBox";
            this.showFullPathsBox.Size = new System.Drawing.Size(102, 17);
            this.showFullPathsBox.TabIndex = 1;
            this.showFullPathsBox.Text = "Show Full Paths";
            this.showFullPathsBox.UseVisualStyleBackColor = true;
            this.showFullPathsBox.CheckedChanged += new System.EventHandler(this.showFullPathsBox_CheckedChanged);
            // 
            // searchPatternBox
            // 
            this.searchPatternBox.Location = new System.Drawing.Point(401, 67);
            this.searchPatternBox.Name = "searchPatternBox";
            this.searchPatternBox.Size = new System.Drawing.Size(100, 20);
            this.searchPatternBox.TabIndex = 3;
            this.searchPatternBox.TextChanged += new System.EventHandler(this.searchPatternBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search Pattern :";
            // 
            // filesBox
            // 
            this.filesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesBox.Location = new System.Drawing.Point(12, 93);
            this.filesBox.Name = "filesBox";
            this.filesBox.Size = new System.Drawing.Size(633, 400);
            this.filesBox.TabIndex = 5;
            this.filesBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 505);
            this.Controls.Add(this.filesBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchPatternBox);
            this.Controls.Add(this.showFullPathsBox);
            this.Controls.Add(this.showFileExtensionsBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListFiles";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox directoryBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.CheckBox showFileExtensionsBox;
        private System.Windows.Forms.CheckBox showFullPathsBox;
        private System.Windows.Forms.TextBox searchPatternBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox filesBox;
    }
}

