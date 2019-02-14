namespace FilePractice
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.rchTxBx_stringReader = new System.Windows.Forms.RichTextBox();
            this.btn_showFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // rchTxBx_stringReader
            // 
            this.rchTxBx_stringReader.Location = new System.Drawing.Point(117, 145);
            this.rchTxBx_stringReader.Name = "rchTxBx_stringReader";
            this.rchTxBx_stringReader.Size = new System.Drawing.Size(525, 382);
            this.rchTxBx_stringReader.TabIndex = 0;
            this.rchTxBx_stringReader.Text = "";
            // 
            // btn_showFile
            // 
            this.btn_showFile.Location = new System.Drawing.Point(873, 346);
            this.btn_showFile.Name = "btn_showFile";
            this.btn_showFile.Size = new System.Drawing.Size(348, 181);
            this.btn_showFile.TabIndex = 1;
            this.btn_showFile.Text = "Show File";
            this.btn_showFile.UseVisualStyleBackColor = true;
            this.btn_showFile.Click += new System.EventHandler(this.btn_showFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 1032);
            this.Controls.Add(this.btn_showFile);
            this.Controls.Add(this.rchTxBx_stringReader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox rchTxBx_stringReader;
        private System.Windows.Forms.Button btn_showFile;
    }
}

