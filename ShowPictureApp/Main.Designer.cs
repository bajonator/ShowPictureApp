namespace ShowPictureApp
{
    partial class Main
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
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.tbSourceImage = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClearPicture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbImage.Location = new System.Drawing.Point(0, 0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(1046, 512);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.Location = new System.Drawing.Point(0, 0);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(92, 47);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "Otwórz obraz";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // tbSourceImage
            // 
            this.tbSourceImage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbSourceImage.Enabled = false;
            this.tbSourceImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSourceImage.Location = new System.Drawing.Point(0, 571);
            this.tbSourceImage.Name = "tbSourceImage";
            this.tbSourceImage.ReadOnly = true;
            this.tbSourceImage.Size = new System.Drawing.Size(1046, 26);
            this.tbSourceImage.TabIndex = 2;
            this.tbSourceImage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnClearPicture);
            this.panel1.Controls.Add(this.btnOpenFile);
            this.panel1.Location = new System.Drawing.Point(12, 518);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 47);
            this.panel1.TabIndex = 3;
            // 
            // btnClearPicture
            // 
            this.btnClearPicture.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClearPicture.Enabled = false;
            this.btnClearPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearPicture.Location = new System.Drawing.Point(930, 0);
            this.btnClearPicture.Name = "btnClearPicture";
            this.btnClearPicture.Size = new System.Drawing.Size(92, 47);
            this.btnClearPicture.TabIndex = 2;
            this.btnClearPicture.Text = "Usuń obraz";
            this.btnClearPicture.UseVisualStyleBackColor = true;
            this.btnClearPicture.Click += new System.EventHandler(this.btnClearPicture_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 597);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbSourceImage);
            this.Controls.Add(this.pbImage);
            this.MaximumSize = new System.Drawing.Size(1062, 636);
            this.MinimumSize = new System.Drawing.Size(1062, 636);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Obrazki";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox tbSourceImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClearPicture;
    }
}

