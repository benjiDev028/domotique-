namespace Maison
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.F1 = new System.Windows.Forms.Button();
            this.F3 = new System.Windows.Forms.Button();
            this.F2 = new System.Windows.Forms.Button();
            this.F4 = new System.Windows.Forms.Button();
            this.P1 = new System.Windows.Forms.Button();
            this.P2 = new System.Windows.Forms.Button();
            this.P3 = new System.Windows.Forms.Button();
            this.DI1 = new System.Windows.Forms.Button();
            this.DM1 = new System.Windows.Forms.Button();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnHist = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHisto = new System.Windows.Forms.Button();
            this.grpHistorique = new System.Windows.Forms.GroupBox();
            this.lstHist = new System.Windows.Forms.ListBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.securiteBDDataSet = new Maison.securiteBDDataSet();
            this.capteursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.capteursTableAdapter = new Maison.securiteBDDataSetTableAdapters.CapteursTableAdapter();
            this.capteursTableAdapter1 = new Maison.securiteBDDataSetTableAdapters.CapteursTableAdapter();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpHistorique.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.securiteBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capteursBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // F1
            // 
            this.F1.BackColor = System.Drawing.Color.White;
            this.F1.Location = new System.Drawing.Point(71, 40);
            this.F1.Name = "F1";
            this.F1.Size = new System.Drawing.Size(37, 23);
            this.F1.TabIndex = 0;
            this.F1.Text = "F1";
            this.F1.UseVisualStyleBackColor = false;
            this.F1.Click += new System.EventHandler(this.F1_Click);
            // 
            // F3
            // 
            this.F3.BackColor = System.Drawing.Color.White;
            this.F3.Location = new System.Drawing.Point(234, 40);
            this.F3.Name = "F3";
            this.F3.Size = new System.Drawing.Size(37, 23);
            this.F3.TabIndex = 1;
            this.F3.Text = "F3";
            this.F3.UseVisualStyleBackColor = false;
            this.F3.Click += new System.EventHandler(this.F3_Click);
            // 
            // F2
            // 
            this.F2.BackColor = System.Drawing.Color.White;
            this.F2.Location = new System.Drawing.Point(163, 40);
            this.F2.Name = "F2";
            this.F2.Size = new System.Drawing.Size(37, 23);
            this.F2.TabIndex = 2;
            this.F2.Text = "F2";
            this.F2.UseVisualStyleBackColor = false;
            this.F2.Click += new System.EventHandler(this.F2_Click);
            // 
            // F4
            // 
            this.F4.BackColor = System.Drawing.Color.White;
            this.F4.Location = new System.Drawing.Point(324, 40);
            this.F4.Name = "F4";
            this.F4.Size = new System.Drawing.Size(37, 23);
            this.F4.TabIndex = 3;
            this.F4.Text = "F4";
            this.F4.UseVisualStyleBackColor = false;
            this.F4.Click += new System.EventHandler(this.F4_Click);
            // 
            // P1
            // 
            this.P1.BackColor = System.Drawing.Color.White;
            this.P1.Location = new System.Drawing.Point(163, 162);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(40, 27);
            this.P1.TabIndex = 4;
            this.P1.Text = "P1";
            this.P1.UseVisualStyleBackColor = false;
            this.P1.Click += new System.EventHandler(this.P1_Click);
            // 
            // P2
            // 
            this.P2.BackColor = System.Drawing.Color.White;
            this.P2.Location = new System.Drawing.Point(324, 138);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(37, 23);
            this.P2.TabIndex = 5;
            this.P2.Text = "P2";
            this.P2.UseVisualStyleBackColor = false;
            this.P2.Click += new System.EventHandler(this.P2_Click);
            // 
            // P3
            // 
            this.P3.BackColor = System.Drawing.Color.White;
            this.P3.Location = new System.Drawing.Point(307, 362);
            this.P3.Name = "P3";
            this.P3.Size = new System.Drawing.Size(37, 30);
            this.P3.TabIndex = 6;
            this.P3.Text = "P3";
            this.P3.UseVisualStyleBackColor = false;
            this.P3.Click += new System.EventHandler(this.P3_Click);
            // 
            // DI1
            // 
            this.DI1.BackColor = System.Drawing.Color.White;
            this.DI1.Location = new System.Drawing.Point(160, 227);
            this.DI1.Name = "DI1";
            this.DI1.Size = new System.Drawing.Size(40, 27);
            this.DI1.TabIndex = 7;
            this.DI1.Text = "DI1";
            this.DI1.UseVisualStyleBackColor = false;
            this.DI1.Click += new System.EventHandler(this.DI1_Click);
            // 
            // DM1
            // 
            this.DM1.BackColor = System.Drawing.Color.White;
            this.DM1.Location = new System.Drawing.Point(294, 175);
            this.DM1.Name = "DM1";
            this.DM1.Size = new System.Drawing.Size(40, 27);
            this.DM1.TabIndex = 8;
            this.DM1.Text = "DM1";
            this.DM1.UseVisualStyleBackColor = false;
            this.DM1.Click += new System.EventHandler(this.DM1_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 634);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(616, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(118, 17);
            this.status.Text = "connecte sur : COM2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Padding = new System.Windows.Forms.Padding(0, 0, 78, 0);
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(196, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // btnHist
            // 
            this.btnHist.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHist.Location = new System.Drawing.Point(455, 381);
            this.btnHist.Name = "btnHist";
            this.btnHist.Size = new System.Drawing.Size(75, 23);
            this.btnHist.TabIndex = 11;
            this.btnHist.Text = "historique";
            this.btnHist.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.F1);
            this.groupBox1.Controls.Add(this.F2);
            this.groupBox1.Controls.Add(this.F3);
            this.groupBox1.Controls.Add(this.P3);
            this.groupBox1.Controls.Add(this.DM1);
            this.groupBox1.Controls.Add(this.F4);
            this.groupBox1.Controls.Add(this.DI1);
            this.groupBox1.Controls.Add(this.P2);
            this.groupBox1.Controls.Add(this.P1);
            this.groupBox1.Location = new System.Drawing.Point(71, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 405);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnHisto
            // 
            this.btnHisto.Location = new System.Drawing.Point(486, 423);
            this.btnHisto.Name = "btnHisto";
            this.btnHisto.Size = new System.Drawing.Size(75, 23);
            this.btnHisto.TabIndex = 13;
            this.btnHisto.Text = "historique";
            this.btnHisto.UseVisualStyleBackColor = true;
            this.btnHisto.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpHistorique
            // 
            this.grpHistorique.BackColor = System.Drawing.SystemColors.Control;
            this.grpHistorique.Controls.Add(this.lstHist);
            this.grpHistorique.Controls.Add(this.lblInfo);
            this.grpHistorique.Location = new System.Drawing.Point(74, 458);
            this.grpHistorique.Name = "grpHistorique";
            this.grpHistorique.Size = new System.Drawing.Size(487, 152);
            this.grpHistorique.TabIndex = 14;
            this.grpHistorique.TabStop = false;
            this.grpHistorique.Text = "HISTORIQUE";
            // 
            // lstHist
            // 
            this.lstHist.FormattingEnabled = true;
            this.lstHist.Location = new System.Drawing.Point(9, 23);
            this.lstHist.Name = "lstHist";
            this.lstHist.Size = new System.Drawing.Size(447, 108);
            this.lstHist.TabIndex = 1;
            this.lstHist.SelectedIndexChanged += new System.EventHandler(this.lstHist_SelectedIndexChanged);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(3, 16);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 0;
            // 
            // securiteBDDataSet
            // 
            this.securiteBDDataSet.DataSetName = "securiteBDDataSet";
            this.securiteBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // capteursBindingSource
            // 
            this.capteursBindingSource.DataMember = "Capteurs";
            this.capteursBindingSource.DataSource = this.securiteBDDataSet;
            // 
            // capteursTableAdapter
            // 
            this.capteursTableAdapter.ClearBeforeFill = true;
            // 
            // capteursTableAdapter1
            // 
            this.capteursTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(616, 656);
            this.Controls.Add(this.grpHistorique);
            this.Controls.Add(this.btnHisto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHist);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Maison";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grpHistorique.ResumeLayout(false);
            this.grpHistorique.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.securiteBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capteursBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button F1;
        private System.Windows.Forms.Button F3;
        private System.Windows.Forms.Button F2;
        private System.Windows.Forms.Button F4;
        private System.Windows.Forms.Button P1;
        private System.Windows.Forms.Button P2;
        private System.Windows.Forms.Button P3;
        private System.Windows.Forms.Button DI1;
        private System.Windows.Forms.Button DM1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnHist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHisto;
        private System.Windows.Forms.GroupBox grpHistorique;
        private System.Windows.Forms.Label lblInfo;
        private securiteBDDataSet securiteBDDataSet;
        private System.Windows.Forms.BindingSource capteursBindingSource;
        private securiteBDDataSetTableAdapters.CapteursTableAdapter capteursTableAdapter;
        private securiteBDDataSetTableAdapters.CapteursTableAdapter capteursTableAdapter1;
        private System.Windows.Forms.ListBox lstHist;
    }
}

