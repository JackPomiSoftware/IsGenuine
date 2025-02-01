namespace IsGenuine
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNOT = new System.Windows.Forms.Label();
            this.picN = new System.Windows.Forms.PictureBox();
            this.labelN = new System.Windows.Forms.Label();
            this.linkSLUI = new System.Windows.Forms.LinkLabel();
            this.labelOS = new System.Windows.Forms.Label();
            this.labelKey = new System.Windows.Forms.Label();
            this.linkEULA = new System.Windows.Forms.LinkLabel();
            this.picY = new System.Windows.Forms.PictureBox();
            this.labelGEN = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.linkMIT = new System.Windows.Forms.LinkLabel();
            this.linkWeb = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picY)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(447, 40);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelNOT);
            this.panel1.Controls.Add(this.picN);
            this.panel1.Controls.Add(this.labelN);
            this.panel1.Controls.Add(this.linkSLUI);
            this.panel1.Controls.Add(this.labelOS);
            this.panel1.Controls.Add(this.labelKey);
            this.panel1.Controls.Add(this.linkEULA);
            this.panel1.Controls.Add(this.picY);
            this.panel1.Controls.Add(this.labelGEN);
            this.panel1.Controls.Add(this.labelY);
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 236);
            this.panel1.TabIndex = 1;
            // 
            // labelNOT
            // 
            this.labelNOT.AutoSize = true;
            this.labelNOT.Location = new System.Drawing.Point(13, 43);
            this.labelNOT.Name = "labelNOT";
            this.labelNOT.Size = new System.Drawing.Size(243, 13);
            this.labelNOT.TabIndex = 27;
            this.labelNOT.Text = "Windows running on your PC may be not genuine.";
            // 
            // picN
            // 
            this.picN.Image = ((System.Drawing.Image)(resources.GetObject("picN.Image")));
            this.picN.Location = new System.Drawing.Point(16, 18);
            this.picN.Name = "picN";
            this.picN.Size = new System.Drawing.Size(16, 16);
            this.picN.TabIndex = 26;
            this.picN.TabStop = false;
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelN.ForeColor = System.Drawing.Color.Firebrick;
            this.labelN.Location = new System.Drawing.Point(32, 15);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(256, 21);
            this.labelN.TabIndex = 25;
            this.labelN.Text = "Your Windows copy is not activated";
            // 
            // linkSLUI
            // 
            this.linkSLUI.AutoSize = true;
            this.linkSLUI.BackColor = System.Drawing.Color.Transparent;
            this.linkSLUI.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkSLUI.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.linkSLUI.Location = new System.Drawing.Point(13, 197);
            this.linkSLUI.Name = "linkSLUI";
            this.linkSLUI.Size = new System.Drawing.Size(139, 13);
            this.linkSLUI.TabIndex = 24;
            this.linkSLUI.TabStop = true;
            this.linkSLUI.Text = "Open the activation window";
            this.linkSLUI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkSLUI.Visible = false;
            this.linkSLUI.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSLUI_LinkClicked);
            // 
            // labelOS
            // 
            this.labelOS.AutoSize = true;
            this.labelOS.Location = new System.Drawing.Point(13, 66);
            this.labelOS.Name = "labelOS";
            this.labelOS.Size = new System.Drawing.Size(81, 13);
            this.labelOS.TabIndex = 23;
            this.labelOS.Text = "Current edition: ";
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(13, 97);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(106, 13);
            this.labelKey.TabIndex = 22;
            this.labelKey.Text = "Current product key: ";
            // 
            // linkEULA
            // 
            this.linkEULA.AutoSize = true;
            this.linkEULA.BackColor = System.Drawing.Color.Transparent;
            this.linkEULA.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkEULA.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.linkEULA.Location = new System.Drawing.Point(13, 214);
            this.linkEULA.Name = "linkEULA";
            this.linkEULA.Size = new System.Drawing.Size(214, 13);
            this.linkEULA.TabIndex = 21;
            this.linkEULA.TabStop = true;
            this.linkEULA.Text = "Read the Microsoft Software License Terms";
            this.linkEULA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkEULA.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEULA_LinkClicked);
            // 
            // picY
            // 
            this.picY.Image = ((System.Drawing.Image)(resources.GetObject("picY.Image")));
            this.picY.Location = new System.Drawing.Point(16, 18);
            this.picY.Name = "picY";
            this.picY.Size = new System.Drawing.Size(16, 16);
            this.picY.TabIndex = 2;
            this.picY.TabStop = false;
            // 
            // labelGEN
            // 
            this.labelGEN.AutoSize = true;
            this.labelGEN.Location = new System.Drawing.Point(13, 43);
            this.labelGEN.Name = "labelGEN";
            this.labelGEN.Size = new System.Drawing.Size(198, 13);
            this.labelGEN.TabIndex = 1;
            this.labelGEN.Text = "Windows running on your PC is genuine.";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelY.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelY.Location = new System.Drawing.Point(32, 15);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(229, 21);
            this.labelY.TabIndex = 0;
            this.labelY.Text = "Your Windows copy is activated";
            // 
            // linkMIT
            // 
            this.linkMIT.AutoSize = true;
            this.linkMIT.Location = new System.Drawing.Point(301, 279);
            this.linkMIT.Name = "linkMIT";
            this.linkMIT.Size = new System.Drawing.Size(142, 13);
            this.linkMIT.TabIndex = 2;
            this.linkMIT.TabStop = true;
            this.linkMIT.Text = "Available under MIT License";
            this.linkMIT.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMIT_LinkClicked);
            // 
            // linkWeb
            // 
            this.linkWeb.AutoSize = true;
            this.linkWeb.Location = new System.Drawing.Point(3, 279);
            this.linkWeb.Name = "linkWeb";
            this.linkWeb.Size = new System.Drawing.Size(143, 13);
            this.linkWeb.TabIndex = 3;
            this.linkWeb.TabStop = true;
            this.linkWeb.Text = "(c) 2025 Jack Pomi Software\r\n";
            this.linkWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkWeb_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 296);
            this.Controls.Add(this.linkWeb);
            this.Controls.Add(this.linkMIT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "IsGenuine";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkMIT;
        private System.Windows.Forms.LinkLabel linkWeb;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelGEN;
        private System.Windows.Forms.PictureBox picY;
        private System.Windows.Forms.LinkLabel linkEULA;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Label labelOS;
        private System.Windows.Forms.LinkLabel linkSLUI;
        private System.Windows.Forms.PictureBox picN;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelNOT;
    }
}

