namespace ebdaaMS
{
    partial class ADDC
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.texthoursec = new AltoControls.AltoTextBox();
            this.textnamec = new AltoControls.AltoTextBox();
            this.texttypec = new AltoControls.AltoTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deplomeidComboBox = new System.Windows.Forms.ComboBox();
            this.dEPLOMSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ebdaaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Ebda_aDataSet = new ebdaaMS._Ebda_aDataSet();
            this.requiresComboBox = new System.Windows.Forms.ComboBox();
            this.cOURSESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textnotes = new AltoControls.AltoTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cancel = new AltoControls.AltoButton();
            this.savec = new AltoControls.AltoButton();
            this.cOURSESTableAdapter = new ebdaaMS._Ebda_aDataSetTableAdapters.COURSESTableAdapter();
            this.dEPLOMSTableAdapter = new ebdaaMS._Ebda_aDataSetTableAdapters.DEPLOMSTableAdapter();
            this.cOURSESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dEPLOMSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dEPLOMSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ebdaaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Ebda_aDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSESBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSESBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPLOMSBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JF Flat", 12.75F);
            this.label1.Location = new System.Drawing.Point(319, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "نوع الدورة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JF Flat", 12.75F);
            this.label2.Location = new System.Drawing.Point(153, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم الدورة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JF Flat", 12.75F);
            this.label3.Location = new System.Drawing.Point(-5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "عدد الساعات";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("JF Flat", 12.75F);
            this.label4.Location = new System.Drawing.Point(14, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "ملاحظات";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("JF Flat", 12.75F);
            this.label5.Location = new System.Drawing.Point(283, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "المتطلبات السابقة ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("JF Flat", 12.75F);
            this.label6.Location = new System.Drawing.Point(156, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "اسم الدبلوم";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            this.panel1.Controls.Add(this.texthoursec);
            this.panel1.Controls.Add(this.textnamec);
            this.panel1.Controls.Add(this.texttypec);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(25, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 68);
            this.panel1.TabIndex = 6;
            // 
            // texthoursec
            // 
            this.texthoursec.BackColor = System.Drawing.Color.Transparent;
            this.texthoursec.Br = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(176)))), ((int)(((byte)(196)))));
            this.texthoursec.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.texthoursec.ForeColor = System.Drawing.Color.DimGray;
            this.texthoursec.Location = new System.Drawing.Point(0, 35);
            this.texthoursec.Name = "texthoursec";
            this.texthoursec.Size = new System.Drawing.Size(125, 33);
            this.texthoursec.TabIndex = 9;
            // 
            // textnamec
            // 
            this.textnamec.BackColor = System.Drawing.Color.Transparent;
            this.textnamec.Br = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(176)))), ((int)(((byte)(196)))));
            this.textnamec.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.textnamec.ForeColor = System.Drawing.Color.DimGray;
            this.textnamec.Location = new System.Drawing.Point(140, 35);
            this.textnamec.Name = "textnamec";
            this.textnamec.Size = new System.Drawing.Size(125, 33);
            this.textnamec.TabIndex = 9;
            // 
            // texttypec
            // 
            this.texttypec.BackColor = System.Drawing.Color.Transparent;
            this.texttypec.Br = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(176)))), ((int)(((byte)(196)))));
            this.texttypec.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.texttypec.ForeColor = System.Drawing.Color.DimGray;
            this.texttypec.Location = new System.Drawing.Point(287, 35);
            this.texttypec.Name = "texttypec";
            this.texttypec.Size = new System.Drawing.Size(125, 33);
            this.texttypec.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.deplomeidComboBox);
            this.panel2.Controls.Add(this.requiresComboBox);
            this.panel2.Controls.Add(this.textnotes);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(25, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 72);
            this.panel2.TabIndex = 3;
            // 
            // deplomeidComboBox
            // 
            this.deplomeidComboBox.DataSource = this.dEPLOMSBindingSource1;
            this.deplomeidComboBox.DisplayMember = "name";
            this.deplomeidComboBox.Font = new System.Drawing.Font("JF Flat", 11.75F);
            this.deplomeidComboBox.FormattingEnabled = true;
            this.deplomeidComboBox.Location = new System.Drawing.Point(134, 33);
            this.deplomeidComboBox.Name = "deplomeidComboBox";
            this.deplomeidComboBox.Size = new System.Drawing.Size(121, 36);
            this.deplomeidComboBox.TabIndex = 14;
            this.deplomeidComboBox.ValueMember = "id";
            // 
            // dEPLOMSBindingSource
            // 
            this.dEPLOMSBindingSource.DataMember = "DEPLOMS";
            this.dEPLOMSBindingSource.DataSource = this.ebdaaDataSetBindingSource;
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
            // requiresComboBox
            // 
            this.requiresComboBox.DataSource = this.cOURSESBindingSource1;
            this.requiresComboBox.DisplayMember = "name";
            this.requiresComboBox.Font = new System.Drawing.Font("JF Flat", 11.75F);
            this.requiresComboBox.FormattingEnabled = true;
            this.requiresComboBox.Location = new System.Drawing.Point(286, 33);
            this.requiresComboBox.Name = "requiresComboBox";
            this.requiresComboBox.Size = new System.Drawing.Size(121, 36);
            this.requiresComboBox.TabIndex = 13;
            this.requiresComboBox.ValueMember = "id";
            // 
            // cOURSESBindingSource
            // 
            this.cOURSESBindingSource.DataMember = "COURSES";
            this.cOURSESBindingSource.DataSource = this._Ebda_aDataSet;
            // 
            // textnotes
            // 
            this.textnotes.BackColor = System.Drawing.Color.Transparent;
            this.textnotes.Br = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(176)))), ((int)(((byte)(196)))));
            this.textnotes.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.textnotes.ForeColor = System.Drawing.Color.DimGray;
            this.textnotes.Location = new System.Drawing.Point(0, 39);
            this.textnotes.Name = "textnotes";
            this.textnotes.Size = new System.Drawing.Size(125, 33);
            this.textnotes.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("JF Flat", 15.75F);
            this.label7.Location = new System.Drawing.Point(165, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 37);
            this.label7.TabIndex = 7;
            this.label7.Text = "إضافة دورات";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(203)))), ((int)(((byte)(216)))));
            this.panel3.Controls.Add(this.cancel);
            this.panel3.Controls.Add(this.savec);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 267);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(477, 53);
            this.panel3.TabIndex = 9;
            // 
            // cancel
            // 
            this.cancel.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.cancel.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.cancel.BackColor = System.Drawing.Color.Transparent;
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cancel.Font = new System.Drawing.Font("JF Flat", 13.75F);
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(87)))));
            this.cancel.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(87)))));
            this.cancel.Location = new System.Drawing.Point(91, 11);
            this.cancel.Name = "cancel";
            this.cancel.Radius = 10;
            this.cancel.Size = new System.Drawing.Size(94, 31);
            this.cancel.Stroke = false;
            this.cancel.StrokeColor = System.Drawing.Color.Gray;
            this.cancel.TabIndex = 9;
            this.cancel.Text = "إلغاء";
            this.cancel.Transparency = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // savec
            // 
            this.savec.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.savec.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.savec.BackColor = System.Drawing.Color.Transparent;
            this.savec.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.savec.Font = new System.Drawing.Font("JF Flat", 13.75F);
            this.savec.ForeColor = System.Drawing.Color.White;
            this.savec.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(87)))));
            this.savec.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(87)))));
            this.savec.Location = new System.Drawing.Point(316, 10);
            this.savec.Name = "savec";
            this.savec.Radius = 10;
            this.savec.Size = new System.Drawing.Size(94, 31);
            this.savec.Stroke = false;
            this.savec.StrokeColor = System.Drawing.Color.Gray;
            this.savec.TabIndex = 9;
            this.savec.Text = "حفظ";
            this.savec.Transparency = false;
            this.savec.Click += new System.EventHandler(this.savec_Click);
            // 
            // cOURSESTableAdapter
            // 
            this.cOURSESTableAdapter.ClearBeforeFill = true;
            // 
            // dEPLOMSTableAdapter
            // 
            this.dEPLOMSTableAdapter.ClearBeforeFill = true;
            // 
            // cOURSESBindingSource1
            // 
            this.cOURSESBindingSource1.DataMember = "COURSES";
            this.cOURSESBindingSource1.DataSource = this._Ebda_aDataSet;
            // 
            // dEPLOMSBindingSource1
            // 
            this.dEPLOMSBindingSource1.DataMember = "DEPLOMS";
            this.dEPLOMSBindingSource1.DataSource = this.ebdaaDataSetBindingSource;
            // 
            // ADDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(477, 320);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ADDC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ",541";
            this.Load += new System.EventHandler(this.ADDC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dEPLOMSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ebdaaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Ebda_aDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSESBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cOURSESBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPLOMSBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private AltoControls.AltoTextBox texthoursec;
        private AltoControls.AltoTextBox textnamec;
        private AltoControls.AltoTextBox texttypec;
        private AltoControls.AltoTextBox textnotes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private AltoControls.AltoButton savec;
        private AltoControls.AltoButton cancel;
        private System.Windows.Forms.ComboBox deplomeidComboBox;
        private System.Windows.Forms.ComboBox requiresComboBox;
        private System.Windows.Forms.BindingSource ebdaaDataSetBindingSource;
        private _Ebda_aDataSet _Ebda_aDataSet;
        private System.Windows.Forms.BindingSource cOURSESBindingSource;
        private _Ebda_aDataSetTableAdapters.COURSESTableAdapter cOURSESTableAdapter;
        private System.Windows.Forms.BindingSource dEPLOMSBindingSource;
        private _Ebda_aDataSetTableAdapters.DEPLOMSTableAdapter dEPLOMSTableAdapter;
        private System.Windows.Forms.BindingSource dEPLOMSBindingSource1;
        private System.Windows.Forms.BindingSource cOURSESBindingSource1;
    }
}