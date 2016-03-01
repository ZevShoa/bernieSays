namespace bernieSays
{
    partial class playScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonChoose2 = new System.Windows.Forms.Button();
            this.buttonChoose0 = new System.Windows.Forms.Button();
            this.buttonChoose1 = new System.Windows.Forms.Button();
            this.buttonChoose3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChoose2
            // 
            this.buttonChoose2.BackColor = System.Drawing.Color.Transparent;
            this.buttonChoose2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonChoose2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonChoose2.Location = new System.Drawing.Point(22, 461);
            this.buttonChoose2.Name = "buttonChoose2";
            this.buttonChoose2.Size = new System.Drawing.Size(230, 136);
            this.buttonChoose2.TabIndex = 0;
            this.buttonChoose2.Text = "Socialized Medicare";
            this.buttonChoose2.UseVisualStyleBackColor = false;
            this.buttonChoose2.Click += new System.EventHandler(this.buttonChoose2_Click);
            // 
            // buttonChoose0
            // 
            this.buttonChoose0.BackColor = System.Drawing.Color.Transparent;
            this.buttonChoose0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonChoose0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonChoose0.Location = new System.Drawing.Point(22, 273);
            this.buttonChoose0.Name = "buttonChoose0";
            this.buttonChoose0.Size = new System.Drawing.Size(230, 136);
            this.buttonChoose0.TabIndex = 1;
            this.buttonChoose0.Text = "Save the Enviroment";
            this.buttonChoose0.UseVisualStyleBackColor = false;
            this.buttonChoose0.Click += new System.EventHandler(this.buttonChoose0_Click);
            // 
            // buttonChoose1
            // 
            this.buttonChoose1.BackColor = System.Drawing.Color.Transparent;
            this.buttonChoose1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonChoose1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonChoose1.Location = new System.Drawing.Point(336, 273);
            this.buttonChoose1.Name = "buttonChoose1";
            this.buttonChoose1.Size = new System.Drawing.Size(230, 136);
            this.buttonChoose1.TabIndex = 2;
            this.buttonChoose1.Text = "Fight Against the Richest One Percent";
            this.buttonChoose1.UseVisualStyleBackColor = false;
            this.buttonChoose1.Click += new System.EventHandler(this.buttonChoose1_Click);
            // 
            // buttonChoose3
            // 
            this.buttonChoose3.BackColor = System.Drawing.Color.Transparent;
            this.buttonChoose3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonChoose3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonChoose3.Location = new System.Drawing.Point(336, 461);
            this.buttonChoose3.Name = "buttonChoose3";
            this.buttonChoose3.Size = new System.Drawing.Size(230, 136);
            this.buttonChoose3.TabIndex = 3;
            this.buttonChoose3.Text = "Social Justice";
            this.buttonChoose3.UseVisualStyleBackColor = false;
            this.buttonChoose3.Click += new System.EventHandler(this.buttonChoose3_Click);
            // 
            // playScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::bernieSays.Properties.Resources.flag;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.buttonChoose3);
            this.Controls.Add(this.buttonChoose1);
            this.Controls.Add(this.buttonChoose0);
            this.Controls.Add(this.buttonChoose2);
            this.DoubleBuffered = true;
            this.Name = "playScreen";
            this.Size = new System.Drawing.Size(600, 600);
            this.Load += new System.EventHandler(this.playScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonChoose2;
        private System.Windows.Forms.Button buttonChoose0;
        private System.Windows.Forms.Button buttonChoose1;
        private System.Windows.Forms.Button buttonChoose3;
    }
}
