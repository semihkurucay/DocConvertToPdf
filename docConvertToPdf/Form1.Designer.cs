namespace docConvertToPdf
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSelectOpenFile = new System.Windows.Forms.TextBox();
            this.txtSelectOutFile = new System.Windows.Forms.TextBox();
            this.btnSelectOpenFile = new System.Windows.Forms.Button();
            this.btnSelectOutFile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dönüştürülecek Dosya :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(56, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dosya Çıktısı Yolu :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::docConvertToPdf.Properties.Resources.Covert_Word_to_PDF_Graphic_2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(490, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtSelectOpenFile
            // 
            this.txtSelectOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtSelectOpenFile.Location = new System.Drawing.Point(249, 196);
            this.txtSelectOpenFile.Name = "txtSelectOpenFile";
            this.txtSelectOpenFile.Size = new System.Drawing.Size(184, 29);
            this.txtSelectOpenFile.TabIndex = 3;
            // 
            // txtSelectOutFile
            // 
            this.txtSelectOutFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtSelectOutFile.Location = new System.Drawing.Point(249, 241);
            this.txtSelectOutFile.Name = "txtSelectOutFile";
            this.txtSelectOutFile.Size = new System.Drawing.Size(184, 29);
            this.txtSelectOutFile.TabIndex = 4;
            // 
            // btnSelectOpenFile
            // 
            this.btnSelectOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSelectOpenFile.Location = new System.Drawing.Point(439, 198);
            this.btnSelectOpenFile.Name = "btnSelectOpenFile";
            this.btnSelectOpenFile.Size = new System.Drawing.Size(63, 29);
            this.btnSelectOpenFile.TabIndex = 5;
            this.btnSelectOpenFile.Text = "SEÇ";
            this.btnSelectOpenFile.UseVisualStyleBackColor = true;
            this.btnSelectOpenFile.Click += new System.EventHandler(this.btnSelectOpenFile_Click);
            // 
            // btnSelectOutFile
            // 
            this.btnSelectOutFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSelectOutFile.Location = new System.Drawing.Point(439, 243);
            this.btnSelectOutFile.Name = "btnSelectOutFile";
            this.btnSelectOutFile.Size = new System.Drawing.Size(63, 29);
            this.btnSelectOutFile.TabIndex = 6;
            this.btnSelectOutFile.Text = "SEÇ";
            this.btnSelectOutFile.UseVisualStyleBackColor = true;
            this.btnSelectOutFile.Click += new System.EventHandler(this.btnSelectOutFile_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(106, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 54);
            this.button1.TabIndex = 7;
            this.button1.Text = "DÖNÜŞTÜR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(514, 397);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSelectOutFile);
            this.Controls.Add(this.btnSelectOpenFile);
            this.Controls.Add(this.txtSelectOutFile);
            this.Controls.Add(this.txtSelectOpenFile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "PDF Dosyasına Dönüştür";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSelectOpenFile;
        private System.Windows.Forms.TextBox txtSelectOutFile;
        private System.Windows.Forms.Button btnSelectOpenFile;
        private System.Windows.Forms.Button btnSelectOutFile;
        private System.Windows.Forms.Button button1;
    }
}

