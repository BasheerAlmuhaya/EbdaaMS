namespace ebdaaMS
{
    partial class CertificateFormcs
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.altoTextBox1 = new AltoControls.AltoTextBox();
            this.altoTextBox2 = new AltoControls.AltoTextBox();
            this.altoTextBox3 = new AltoControls.AltoTextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(28, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(340, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // altoTextBox1
            // 
            this.altoTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.altoTextBox1.Br = System.Drawing.Color.White;
            this.altoTextBox1.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.altoTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.altoTextBox1.Location = new System.Drawing.Point(447, 112);
            this.altoTextBox1.Name = "altoTextBox1";
            this.altoTextBox1.Size = new System.Drawing.Size(135, 33);
            this.altoTextBox1.TabIndex = 1;
            this.altoTextBox1.Text = "altoTextBox1";
            // 
            // altoTextBox2
            // 
            this.altoTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.altoTextBox2.Br = System.Drawing.Color.White;
            this.altoTextBox2.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.altoTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.altoTextBox2.Location = new System.Drawing.Point(233, 112);
            this.altoTextBox2.Name = "altoTextBox2";
            this.helpProvider1.SetShowHelp(this.altoTextBox2, true);
            this.altoTextBox2.Size = new System.Drawing.Size(135, 33);
            this.altoTextBox2.TabIndex = 2;
            this.altoTextBox2.Text = "altoTextBox2";
            this.altoTextBox2.Click += new System.EventHandler(this.altoTextBox2_Click);
            // 
            // altoTextBox3
            // 
            this.altoTextBox3.BackColor = System.Drawing.Color.Transparent;
            this.altoTextBox3.Br = System.Drawing.Color.White;
            this.altoTextBox3.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.altoTextBox3.ForeColor = System.Drawing.Color.DimGray;
            this.altoTextBox3.Location = new System.Drawing.Point(28, 112);
            this.altoTextBox3.Name = "altoTextBox3";
            this.altoTextBox3.Size = new System.Drawing.Size(135, 33);
            this.altoTextBox3.TabIndex = 3;
            this.altoTextBox3.Text = "altoTextBox3";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Awsan\\Desktop\\Untitled-1.html";
            // 
            // CertificateFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 420);
            this.Controls.Add(this.altoTextBox3);
            this.Controls.Add(this.altoTextBox2);
            this.Controls.Add(this.altoTextBox1);
            this.Controls.Add(this.comboBox1);
            this.HelpButton = true;
            this.helpProvider1.SetHelpKeyword(this, "g");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.helpProvider1.SetHelpString(this, "gg");
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CertificateFormcs";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "CertificateFormcs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private AltoControls.AltoTextBox altoTextBox1;
        private AltoControls.AltoTextBox altoTextBox2;
        private AltoControls.AltoTextBox altoTextBox3;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}