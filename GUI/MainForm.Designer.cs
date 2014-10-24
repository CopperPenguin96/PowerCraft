namespace GUI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.picMainLogo = new System.Windows.Forms.PictureBox();
            this.txtConsoleBox = new System.Windows.Forms.TextBox();
            this.rtbLogBox = new System.Windows.Forms.RichTextBox();
            this.btnGO = new System.Windows.Forms.Button();
            this.UpdaterTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picMainLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picMainLogo
            // 
            this.picMainLogo.Image = ((System.Drawing.Image)(resources.GetObject("picMainLogo.Image")));
            this.picMainLogo.Location = new System.Drawing.Point(13, 13);
            this.picMainLogo.Name = "picMainLogo";
            this.picMainLogo.Size = new System.Drawing.Size(482, 95);
            this.picMainLogo.TabIndex = 0;
            this.picMainLogo.TabStop = false;
            // 
            // txtConsoleBox
            // 
            this.txtConsoleBox.Location = new System.Drawing.Point(13, 423);
            this.txtConsoleBox.Name = "txtConsoleBox";
            this.txtConsoleBox.Size = new System.Drawing.Size(419, 20);
            this.txtConsoleBox.TabIndex = 1;
            // 
            // rtbLogBox
            // 
            this.rtbLogBox.BackColor = System.Drawing.Color.Black;
            this.rtbLogBox.ForeColor = System.Drawing.Color.White;
            this.rtbLogBox.Location = new System.Drawing.Point(13, 115);
            this.rtbLogBox.Name = "rtbLogBox";
            this.rtbLogBox.Size = new System.Drawing.Size(479, 302);
            this.rtbLogBox.TabIndex = 2;
            this.rtbLogBox.Text = "";
            // 
            // btnGO
            // 
            this.btnGO.Location = new System.Drawing.Point(438, 423);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(54, 20);
            this.btnGO.TabIndex = 3;
            this.btnGO.Text = "GO!";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // UpdaterTimer
            // 
            this.UpdaterTimer.Enabled = true;
            this.UpdaterTimer.Interval = 1;
            this.UpdaterTimer.Tick += new System.EventHandler(this.UpdaterTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 455);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.rtbLogBox);
            this.Controls.Add(this.txtConsoleBox);
            this.Controls.Add(this.picMainLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(520, 494);
            this.MinimumSize = new System.Drawing.Size(520, 494);
            this.Name = "MainForm";
            this.Text = "PowerCraft";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMainLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMainLogo;
        private System.Windows.Forms.TextBox txtConsoleBox;
        private System.Windows.Forms.RichTextBox rtbLogBox;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.Timer UpdaterTimer;
    }
}

