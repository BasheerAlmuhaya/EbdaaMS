namespace ebdaaMS
{
    partial class dscours_add
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cOURSESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ebdaaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Ebda_aDataSet = new ebdaaMS._Ebda_aDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tEACHERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tEACHERSTableAdapter = new ebdaaMS._Ebda_aDataSetTableAdapters.TEACHERSTableAdapter();
            this.tableAdapterManager = new ebdaaMS._Ebda_aDataSetTableAdapters.TableAdapterManager();
            this.cOURSESTableAdapter = new ebdaaMS._Ebda_aDataSetTableAdapters.COURSESTableAdapter();
            this.tEACHERSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.altoButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.altoButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ebdaaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Ebda_aDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEACHERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEACHERSBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JF Flat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "تسجيل الدورة ";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(87)))));
            this.panel4.Location = new System.Drawing.Point(132, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(201, 5);
            this.panel4.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DataSource = this.cOURSESBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(100, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 33);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cOURSESBindingSource
            // 
            this.cOURSESBindingSource.DataMember = "COURSES";
            this.cOURSESBindingSource.DataSource = this.ebdaaDataSetBindingSource;
            // 
            // ebdaaDataSetBindingSource
            // 
            this.ebdaaDataSetBindingSource.DataSource = this._Ebda_aDataSet;
            this.ebdaaDataSetBindingSource.Position = 0;
            // 
            // _Ebda_aDataSet
            // 
            this._Ebda_aDataSet.DataSetName = "_Ebda_aDataSet";
            this._Ebda_aDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JF Flat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(394, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "الدورة ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("JF Flat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(331, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 37);
            this.label4.TabIndex = 9;
            this.label4.Text = "تاريخ بداية الدورة";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("JF Flat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(331, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 37);
            this.label5.TabIndex = 11;
            this.label5.Text = "تاريخ نهاية الدورة";
            // 
            // tEACHERSBindingSource
            // 
            this.tEACHERSBindingSource.DataMember = "TEACHERS";
            this.tEACHERSBindingSource.DataSource = this._Ebda_aDataSet;
            // 
            // tEACHERSTableAdapter
            // 
            this.tEACHERSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ABSENTSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CIRTIFICATETableAdapter = null;
            this.tableAdapterManager.course_dissTableAdapter = null;
            this.tableAdapterManager.COURSESTableAdapter = this.cOURSESTableAdapter;
            this.tableAdapterManager.DEGREETableAdapter = null;
            this.tableAdapterManager.DEPLOMSTableAdapter = null;
            this.tableAdapterManager.ENROLLMENTTableAdapter = null;
            this.tableAdapterManager.NATIONALATYTableAdapter = null;
            this.tableAdapterManager.sessionTableAdapter = null;
            this.tableAdapterManager.student_acconTableAdapter = null;
            this.tableAdapterManager.STUDENTSTableAdapter = null;
            this.tableAdapterManager.teacher_acconTableAdapter = null;
            this.tableAdapterManager.TEACHERSTableAdapter = this.tEACHERSTableAdapter;
            this.tableAdapterManager.UpdateOrder = ebdaaMS._Ebda_aDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // cOURSESTableAdapter
            // 
            this.cOURSESTableAdapter.ClearBeforeFill = true;
            // 
            // tEACHERSBindingSource1
            // 
            this.tEACHERSBindingSource1.DataMember = "TEACHERS";
            this.tEACHERSBindingSource1.DataSource = this.ebdaaDataSetBindingSource;
            // 
            // idComboBox
            // 
            this.idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tEACHERSBindingSource, "id", true));
            this.idComboBox.DataSource = this.tEACHERSBindingSource1;
            this.idComboBox.DisplayMember = "name";
            this.idComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.idComboBox.FormattingEnabled = true;
            this.idComboBox.Location = new System.Drawing.Point(100, 188);
            this.idComboBox.Name = "idComboBox";
            this.idComboBox.Size = new System.Drawing.Size(215, 33);
            this.idComboBox.TabIndex = 18;
            this.idComboBox.ValueMember = "id";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JF Flat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(390, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 37);
            this.label3.TabIndex = 17;
            this.label3.Text = "المدرس";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 287);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(195, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(120, 363);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(195, 20);
            this.dateTimePicker2.TabIndex = 20;
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
            this.altoButton1.Location = new System.Drawing.Point(298, 461);
            this.altoButton1.Name = "altoButton1";
            this.altoButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(87)))));
            this.altoButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(203)))), ((int)(((byte)(216)))));
            this.altoButton1.OnHoverTextColor = System.Drawing.Color.Black;
            this.altoButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.altoButton1.selected = false;
            this.altoButton1.Size = new System.Drawing.Size(112, 48);
            this.altoButton1.TabIndex = 49;
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
            this.altoButton2.Location = new System.Drawing.Point(100, 461);
            this.altoButton2.Name = "altoButton2";
            this.altoButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(87)))));
            this.altoButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(203)))), ((int)(((byte)(216)))));
            this.altoButton2.OnHoverTextColor = System.Drawing.Color.Black;
            this.altoButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.altoButton2.selected = false;
            this.altoButton2.Size = new System.Drawing.Size(108, 48);
            this.altoButton2.TabIndex = 50;
            this.altoButton2.Text = "الغاء";
            this.altoButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.altoButton2.Textcolor = System.Drawing.Color.White;
            this.altoButton2.TextFont = new System.Drawing.Font("JF Flat", 13.25F);
            this.altoButton2.Click += new System.EventHandler(this.altoButton2_Click);
            // 
            // dscours_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 546);
            this.ControlBox = false;
            this.Controls.Add(this.altoButton1);
            this.Controls.Add(this.altoButton2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.idComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dscours_add";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.dscours_add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cOURSESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ebdaaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Ebda_aDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEACHERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEACHERSBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private _Ebda_aDataSet _Ebda_aDataSet;
        private System.Windows.Forms.BindingSource tEACHERSBindingSource;
        private _Ebda_aDataSetTableAdapters.TEACHERSTableAdapter tEACHERSTableAdapter;
        private _Ebda_aDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private _Ebda_aDataSetTableAdapters.COURSESTableAdapter cOURSESTableAdapter;
        private System.Windows.Forms.BindingSource tEACHERSBindingSource1;
        private System.Windows.Forms.BindingSource ebdaaDataSetBindingSource;
        private System.Windows.Forms.BindingSource cOURSESBindingSource;
        private System.Windows.Forms.ComboBox idComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private Bunifu.Framework.UI.BunifuFlatButton altoButton1;
        private Bunifu.Framework.UI.BunifuFlatButton altoButton2;
    }
}