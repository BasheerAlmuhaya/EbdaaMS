namespace ebdaaMS
{
    partial class tUserControl1
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
            this.tdataGridView1 = new System.Windows.Forms.DataGridView();
            this.tpanel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tpanel2 = new System.Windows.Forms.Panel();
            this.tpanel3 = new System.Windows.Forms.Panel();
            this.tdeleteFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.taddFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tupdateFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tbunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tsearchTextBox1 = new AltoControls.AltoTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tdataGridView1)).BeginInit();
            this.tpanel1.SuspendLayout();
            this.tpanel2.SuspendLayout();
            this.tpanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tdataGridView1
            // 
            this.tdataGridView1.AllowUserToAddRows = false;
            this.tdataGridView1.AllowUserToDeleteRows = false;
            this.tdataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tdataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            this.tdataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.tdataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.tdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tdataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tdataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(176)))), ((int)(((byte)(196)))));
            this.tdataGridView1.Location = new System.Drawing.Point(0, 0);
            this.tdataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tdataGridView1.Name = "tdataGridView1";
            this.tdataGridView1.ReadOnly = true;
            this.tdataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tdataGridView1.RowTemplate.Height = 26;
            this.tdataGridView1.Size = new System.Drawing.Size(801, 212);
            this.tdataGridView1.TabIndex = 0;
            this.tdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tdataGridView1_CellContentClick);
            // 
            // tpanel1
            // 
            this.tpanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tpanel1.Controls.Add(this.pictureBox1);
            this.tpanel1.Controls.Add(this.tsearchTextBox1);
            this.tpanel1.Controls.Add(this.label1);
            this.tpanel1.Controls.Add(this.panel4);
            this.tpanel1.Controls.Add(this.tbunifuImageButton3);
            this.tpanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tpanel1.Location = new System.Drawing.Point(0, 0);
            this.tpanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpanel1.Name = "tpanel1";
            this.tpanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tpanel1.Size = new System.Drawing.Size(801, 194);
            this.tpanel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JF Flat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(581, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "شؤون الموظفين";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(87)))));
            this.panel4.Location = new System.Drawing.Point(566, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(201, 5);
            this.panel4.TabIndex = 15;
            // 
            // tpanel2
            // 
            this.tpanel2.Controls.Add(this.tdataGridView1);
            this.tpanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpanel2.Location = new System.Drawing.Point(0, 194);
            this.tpanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpanel2.Name = "tpanel2";
            this.tpanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tpanel2.Size = new System.Drawing.Size(801, 212);
            this.tpanel2.TabIndex = 10;
            // 
            // tpanel3
            // 
            this.tpanel3.BackColor = System.Drawing.SystemColors.Control;
            this.tpanel3.Controls.Add(this.tdeleteFlatButton3);
            this.tpanel3.Controls.Add(this.taddFlatButton2);
            this.tpanel3.Controls.Add(this.tupdateFlatButton4);
            this.tpanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tpanel3.Location = new System.Drawing.Point(0, 406);
            this.tpanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpanel3.Name = "tpanel3";
            this.tpanel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tpanel3.Size = new System.Drawing.Size(801, 101);
            this.tpanel3.TabIndex = 10;
            this.tpanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tpanel3_Paint);
            // 
            // tdeleteFlatButton3
            // 
            this.tdeleteFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(203)))), ((int)(((byte)(216)))));
            this.tdeleteFlatButton3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tdeleteFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(203)))), ((int)(((byte)(216)))));
            this.tdeleteFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tdeleteFlatButton3.BorderRadius = 0;
            this.tdeleteFlatButton3.ButtonText = "حذف";
            this.tdeleteFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tdeleteFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.tdeleteFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.tdeleteFlatButton3.Iconimage = global::ebdaaMS.Properties.Resources.icons8_Delete_File_96px1;
            this.tdeleteFlatButton3.Iconimage_right = null;
            this.tdeleteFlatButton3.Iconimage_right_Selected = null;
            this.tdeleteFlatButton3.Iconimage_Selected = null;
            this.tdeleteFlatButton3.IconMarginLeft = 0;
            this.tdeleteFlatButton3.IconMarginRight = 0;
            this.tdeleteFlatButton3.IconRightVisible = true;
            this.tdeleteFlatButton3.IconRightZoom = 0D;
            this.tdeleteFlatButton3.IconVisible = true;
            this.tdeleteFlatButton3.IconZoom = 90D;
            this.tdeleteFlatButton3.IsTab = false;
            this.tdeleteFlatButton3.Location = new System.Drawing.Point(120, 24);
            this.tdeleteFlatButton3.Name = "tdeleteFlatButton3";
            this.tdeleteFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(203)))), ((int)(((byte)(216)))));
            this.tdeleteFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(203)))), ((int)(((byte)(216)))));
            this.tdeleteFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.tdeleteFlatButton3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tdeleteFlatButton3.selected = false;
            this.tdeleteFlatButton3.Size = new System.Drawing.Size(168, 48);
            this.tdeleteFlatButton3.TabIndex = 8;
            this.tdeleteFlatButton3.Text = "حذف";
            this.tdeleteFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tdeleteFlatButton3.Textcolor = System.Drawing.Color.Black;
            this.tdeleteFlatButton3.TextFont = new System.Drawing.Font("JF Flat", 11.25F);
            this.tdeleteFlatButton3.Click += new System.EventHandler(this.tdeleteFlatButton3_Click);
            // 
            // taddFlatButton2
            // 
            this.taddFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(203)))), ((int)(((byte)(216)))));
            this.taddFlatButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.taddFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(203)))), ((int)(((byte)(216)))));
            this.taddFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.taddFlatButton2.BorderRadius = 0;
            this.taddFlatButton2.ButtonText = "إضافة";
            this.taddFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.taddFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.taddFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.taddFlatButton2.Iconimage = global::ebdaaMS.Properties.Resources.icons8_Add_File_104px;
            this.taddFlatButton2.Iconimage_right = null;
            this.taddFlatButton2.Iconimage_right_Selected = null;
            this.taddFlatButton2.Iconimage_Selected = null;
            this.taddFlatButton2.IconMarginLeft = 0;
            this.taddFlatButton2.IconMarginRight = 0;
            this.taddFlatButton2.IconRightVisible = true;
            this.taddFlatButton2.IconRightZoom = 0D;
            this.taddFlatButton2.IconVisible = true;
            this.taddFlatButton2.IconZoom = 90D;
            this.taddFlatButton2.IsTab = false;
            this.taddFlatButton2.Location = new System.Drawing.Point(500, 24);
            this.taddFlatButton2.Name = "taddFlatButton2";
            this.taddFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(203)))), ((int)(((byte)(216)))));
            this.taddFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(203)))), ((int)(((byte)(216)))));
            this.taddFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.taddFlatButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.taddFlatButton2.selected = false;
            this.taddFlatButton2.Size = new System.Drawing.Size(197, 48);
            this.taddFlatButton2.TabIndex = 6;
            this.taddFlatButton2.Text = "إضافة";
            this.taddFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.taddFlatButton2.Textcolor = System.Drawing.Color.Black;
            this.taddFlatButton2.TextFont = new System.Drawing.Font("JF Flat", 11.25F);
            this.taddFlatButton2.Click += new System.EventHandler(this.taddFlatButton2_Click);
            // 
            // tupdateFlatButton4
            // 
            this.tupdateFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(203)))), ((int)(((byte)(216)))));
            this.tupdateFlatButton4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tupdateFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(203)))), ((int)(((byte)(216)))));
            this.tupdateFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tupdateFlatButton4.BorderRadius = 0;
            this.tupdateFlatButton4.ButtonText = "تعديل";
            this.tupdateFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tupdateFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.tupdateFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.tupdateFlatButton4.Iconimage = global::ebdaaMS.Properties.Resources.icons8_Edit_File_100px;
            this.tupdateFlatButton4.Iconimage_right = null;
            this.tupdateFlatButton4.Iconimage_right_Selected = null;
            this.tupdateFlatButton4.Iconimage_Selected = null;
            this.tupdateFlatButton4.IconMarginLeft = 0;
            this.tupdateFlatButton4.IconMarginRight = 0;
            this.tupdateFlatButton4.IconRightVisible = true;
            this.tupdateFlatButton4.IconRightZoom = 0D;
            this.tupdateFlatButton4.IconVisible = true;
            this.tupdateFlatButton4.IconZoom = 90D;
            this.tupdateFlatButton4.IsTab = false;
            this.tupdateFlatButton4.Location = new System.Drawing.Point(309, 24);
            this.tupdateFlatButton4.Name = "tupdateFlatButton4";
            this.tupdateFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(203)))), ((int)(((byte)(216)))));
            this.tupdateFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(203)))), ((int)(((byte)(216)))));
            this.tupdateFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.tupdateFlatButton4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tupdateFlatButton4.selected = false;
            this.tupdateFlatButton4.Size = new System.Drawing.Size(168, 48);
            this.tupdateFlatButton4.TabIndex = 7;
            this.tupdateFlatButton4.Text = "تعديل";
            this.tupdateFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tupdateFlatButton4.Textcolor = System.Drawing.Color.Black;
            this.tupdateFlatButton4.TextFont = new System.Drawing.Font("JF Flat", 11.25F);
            this.tupdateFlatButton4.Click += new System.EventHandler(this.tupdateFlatButton4_Click);
            // 
            // tbunifuImageButton3
            // 
            this.tbunifuImageButton3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.tbunifuImageButton3.Image = global::ebdaaMS.Properties.Resources.icons8_Refresh_64;
            this.tbunifuImageButton3.ImageActive = null;
            this.tbunifuImageButton3.InitialImage = global::ebdaaMS.Properties.Resources.icons8_Chevron_Right_64;
            this.tbunifuImageButton3.Location = new System.Drawing.Point(734, 134);
            this.tbunifuImageButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbunifuImageButton3.Name = "tbunifuImageButton3";
            this.tbunifuImageButton3.Size = new System.Drawing.Size(44, 46);
            this.tbunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tbunifuImageButton3.TabIndex = 14;
            this.tbunifuImageButton3.TabStop = false;
            this.tbunifuImageButton3.Zoom = 10;
            this.tbunifuImageButton3.Click += new System.EventHandler(this.tbunifuImageButton3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(87)))));
            this.pictureBox1.Image = global::ebdaaMS.Properties.Resources.icons8_Search_64;
            this.pictureBox1.Location = new System.Drawing.Point(214, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // tsearchTextBox1
            // 
            this.tsearchTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.tsearchTextBox1.Br = System.Drawing.Color.White;
            this.tsearchTextBox1.Font = new System.Drawing.Font("JF Flat", 12.75F);
            this.tsearchTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.tsearchTextBox1.Location = new System.Drawing.Point(23, 134);
            this.tsearchTextBox1.Name = "tsearchTextBox1";
            this.tsearchTextBox1.Size = new System.Drawing.Size(185, 42);
            this.tsearchTextBox1.TabIndex = 21;
            this.tsearchTextBox1.TextChanged += new System.EventHandler(this.tsearchTextBox1_TextChanged);
            // 
            // tUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tpanel2);
            this.Controls.Add(this.tpanel3);
            this.Controls.Add(this.tpanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "tUserControl1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(801, 507);
            ((System.ComponentModel.ISupportInitialize)(this.tdataGridView1)).EndInit();
            this.tpanel1.ResumeLayout(false);
            this.tpanel1.PerformLayout();
            this.tpanel2.ResumeLayout(false);
            this.tpanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tdataGridView1;
        private System.Windows.Forms.Panel tpanel1;
        private System.Windows.Forms.Panel tpanel2;
        private System.Windows.Forms.Panel tpanel3;
        private Bunifu.Framework.UI.BunifuImageButton tbunifuImageButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton tdeleteFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton tupdateFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton taddFlatButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AltoControls.AltoTextBox tsearchTextBox1;
    }
}
