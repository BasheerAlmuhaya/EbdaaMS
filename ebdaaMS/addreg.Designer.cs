namespace ebdaaMS
{
    partial class addreg
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
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.altoButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.altoButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lableError = new System.Windows.Forms.Label();
            this.tbprice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("JF Flat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(428, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 37);
            this.label6.TabIndex = 43;
            this.label6.Text = "الطالب";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox2.Font = new System.Drawing.Font("JF Flat", 12.75F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(110, 214);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(312, 38);
            this.comboBox2.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JF Flat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(428, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 37);
            this.label2.TabIndex = 33;
            this.label2.Text = "الدورة ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox1.Font = new System.Drawing.Font("JF Flat", 12.75F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(110, 129);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(312, 38);
            this.comboBox1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JF Flat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 37);
            this.label1.TabIndex = 31;
            this.label1.Text = "تسجيل طالب في دورة";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(87)))));
            this.panel4.Location = new System.Drawing.Point(161, 75);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(201, 5);
            this.panel4.TabIndex = 30;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JF Flat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(428, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 37);
            this.label3.TabIndex = 45;
            this.label3.Text = "السعر";
            // 
            // altoButton1
            // 
            this.altoButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(87)))));
            this.altoButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.altoButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(87)))));
            this.altoButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.altoButton1.BorderRadius = 0;
            this.altoButton1.ButtonText = "حفظ";
            this.altoButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.altoButton1.DisabledColor = System.Drawing.Color.Gray;
            this.altoButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.altoButton1.Iconimage = global::ebdaaMS.Properties.Resources.icons8_Add_File_100px;
            this.altoButton1.Iconimage_right = null;
            this.altoButton1.Iconimage_right_Selected = null;
            this.altoButton1.Iconimage_Selected = null;
            this.altoButton1.IconMarginLeft = 0;
            this.altoButton1.IconMarginRight = 0;
            this.altoButton1.IconRightVisible = true;
            this.altoButton1.IconRightZoom = 0D;
            this.altoButton1.IconVisible = true;
            this.altoButton1.IconZoom = 90D;
            this.altoButton1.IsTab = false;
            this.altoButton1.Location = new System.Drawing.Point(329, 431);
            this.altoButton1.Name = "altoButton1";
            this.altoButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(87)))));
            this.altoButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(203)))), ((int)(((byte)(216)))));
            this.altoButton1.OnHoverTextColor = System.Drawing.Color.Black;
            this.altoButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.altoButton1.selected = false;
            this.altoButton1.Size = new System.Drawing.Size(112, 48);
            this.altoButton1.TabIndex = 47;
            this.altoButton1.Text = "حفظ";
            this.altoButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.altoButton1.Textcolor = System.Drawing.Color.White;
            this.altoButton1.TextFont = new System.Drawing.Font("JF Flat", 13.25F);
            this.altoButton1.Click += new System.EventHandler(this.altoButton1_Click);
            // 
            // altoButton2
            // 
            this.altoButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(87)))));
            this.altoButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.altoButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(87)))));
            this.altoButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.altoButton2.BorderRadius = 0;
            this.altoButton2.ButtonText = "الغاء";
            this.altoButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.altoButton2.DisabledColor = System.Drawing.Color.Gray;
            this.altoButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.altoButton2.Iconimage = global::ebdaaMS.Properties.Resources.icons8_Delete_File_100px;
            this.altoButton2.Iconimage_right = null;
            this.altoButton2.Iconimage_right_Selected = null;
            this.altoButton2.Iconimage_Selected = null;
            this.altoButton2.IconMarginLeft = 0;
            this.altoButton2.IconMarginRight = 0;
            this.altoButton2.IconRightVisible = true;
            this.altoButton2.IconRightZoom = 0D;
            this.altoButton2.IconVisible = true;
            this.altoButton2.IconZoom = 90D;
            this.altoButton2.IsTab = false;
            this.altoButton2.Location = new System.Drawing.Point(101, 431);
            this.altoButton2.Name = "altoButton2";
            this.altoButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(87)))));
            this.altoButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(203)))), ((int)(((byte)(216)))));
            this.altoButton2.OnHoverTextColor = System.Drawing.Color.Black;
            this.altoButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.altoButton2.selected = false;
            this.altoButton2.Size = new System.Drawing.Size(108, 48);
            this.altoButton2.TabIndex = 48;
            this.altoButton2.Text = "الغاء";
            this.altoButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.altoButton2.Textcolor = System.Drawing.Color.White;
            this.altoButton2.TextFont = new System.Drawing.Font("JF Flat", 13.25F);
            this.altoButton2.Click += new System.EventHandler(this.altoButton2_Click);
            // 
            // lableError
            // 
            this.lableError.AutoSize = true;
            this.lableError.Font = new System.Drawing.Font("JF Flat", 10F);
            this.lableError.ForeColor = System.Drawing.Color.Red;
            this.lableError.Location = new System.Drawing.Point(197, 346);
            this.lableError.Name = "lableError";
            this.lableError.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lableError.Size = new System.Drawing.Size(0, 24);
            this.lableError.TabIndex = 121;
            // 
            // tbprice
            // 
            this.tbprice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbprice.Font = new System.Drawing.Font("JF Flat", 10.75F);
            this.tbprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbprice.HintForeColor = System.Drawing.Color.Empty;
            this.tbprice.HintText = "";
            this.tbprice.isPassword = false;
            this.tbprice.LineFocusedColor = System.Drawing.Color.Black;
            this.tbprice.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(87)))));
            this.tbprice.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(87)))));
            this.tbprice.LineThickness = 8;
            this.tbprice.Location = new System.Drawing.Point(255, 283);
            this.tbprice.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbprice.Name = "tbprice";
            this.tbprice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbprice.Size = new System.Drawing.Size(137, 48);
            this.tbprice.TabIndex = 122;
            this.tbprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbprice_KeyPress);
            // 
            // addreg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 535);
            this.ControlBox = false;
            this.Controls.Add(this.tbprice);
            this.Controls.Add(this.lableError);
            this.Controls.Add(this.altoButton1);
            this.Controls.Add(this.altoButton2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Name = "addreg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.addreg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton altoButton1;
        private Bunifu.Framework.UI.BunifuFlatButton altoButton2;
        private System.Windows.Forms.Label lableError;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbprice;
    }
}