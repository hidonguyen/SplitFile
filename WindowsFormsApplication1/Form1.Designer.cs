namespace WindowsFormsApplication1
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
            this.txtBrowsFile = new System.Windows.Forms.TextBox();
            this.btn_Brows = new System.Windows.Forms.Button();
            this.btn_splitFile = new System.Windows.Forms.Button();
            this.btn_mertFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblSendingResult = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtBrowsFile
            // 
            this.txtBrowsFile.Location = new System.Drawing.Point(72, 74);
            this.txtBrowsFile.Name = "txtBrowsFile";
            this.txtBrowsFile.Size = new System.Drawing.Size(227, 20);
            this.txtBrowsFile.TabIndex = 0;
            // 
            // btn_Brows
            // 
            this.btn_Brows.Location = new System.Drawing.Point(319, 73);
            this.btn_Brows.Name = "btn_Brows";
            this.btn_Brows.Size = new System.Drawing.Size(75, 23);
            this.btn_Brows.TabIndex = 1;
            this.btn_Brows.Text = "Brows";
            this.btn_Brows.UseVisualStyleBackColor = true;
            this.btn_Brows.Click += new System.EventHandler(this.brows_Click);
            // 
            // btn_splitFile
            // 
            this.btn_splitFile.Location = new System.Drawing.Point(414, 73);
            this.btn_splitFile.Name = "btn_splitFile";
            this.btn_splitFile.Size = new System.Drawing.Size(75, 23);
            this.btn_splitFile.TabIndex = 1;
            this.btn_splitFile.Text = "Split file";
            this.btn_splitFile.UseVisualStyleBackColor = true;
            this.btn_splitFile.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // btn_mertFile
            // 
            this.btn_mertFile.Location = new System.Drawing.Point(244, 254);
            this.btn_mertFile.Name = "btn_mertFile";
            this.btn_mertFile.Size = new System.Drawing.Size(75, 23);
            this.btn_mertFile.TabIndex = 1;
            this.btn_mertFile.Text = "Merge File";
            this.btn_mertFile.UseVisualStyleBackColor = true;
            this.btn_mertFile.Click += new System.EventHandler(this.btnMergeFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblSendingResult
            // 
            this.lblSendingResult.AutoSize = true;
            this.lblSendingResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSendingResult.Location = new System.Drawing.Point(159, 18);
            this.lblSendingResult.Name = "lblSendingResult";
            this.lblSendingResult.Size = new System.Drawing.Size(259, 25);
            this.lblSendingResult.TabIndex = 2;
            this.lblSendingResult.Text = "Split Files and merge files";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(90, 100);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(379, 134);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 289);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblSendingResult);
            this.Controls.Add(this.btn_mertFile);
            this.Controls.Add(this.btn_splitFile);
            this.Controls.Add(this.btn_Brows);
            this.Controls.Add(this.txtBrowsFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBrowsFile;
        private System.Windows.Forms.Button btn_Brows;
        private System.Windows.Forms.Button btn_splitFile;
        private System.Windows.Forms.Button btn_mertFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblSendingResult;
        private System.Windows.Forms.ListBox listBox1;
    }
}

