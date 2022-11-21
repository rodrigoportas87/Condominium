namespace Portaria
{
    partial class cadastro
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
            System.Windows.Forms.Label nomeMoradorLabel;
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtApartamento = new System.Windows.Forms.TextBox();
            this.txtBloco = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.dtVisita = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mstxtFone = new System.Windows.Forms.MaskedTextBox();
            this.mstxtRg = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeVisita = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkFechar = new System.Windows.Forms.CheckBox();
            this.txtNomeMorador2 = new System.Windows.Forms.TextBox();
            this.moradorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.portariaDBDataSet = new Portaria.PortariaDBDataSet();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rtxtObsVisita = new System.Windows.Forms.RichTextBox();
            this.moradorTableAdapter = new Portaria.PortariaDBDataSetTableAdapters.MoradorTableAdapter();
            this.tableAdapterManager = new Portaria.PortariaDBDataSetTableAdapters.TableAdapterManager();
            nomeMoradorLabel = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moradorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portariaDBDataSet)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeMoradorLabel
            // 
            nomeMoradorLabel.AutoSize = true;
            nomeMoradorLabel.Location = new System.Drawing.Point(17, 263);
            nomeMoradorLabel.Name = "nomeMoradorLabel";
            nomeMoradorLabel.Size = new System.Drawing.Size(49, 13);
            nomeMoradorLabel.TabIndex = 24;
            nomeMoradorLabel.Text = "Morador:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtApartamento);
            this.groupBox3.Controls.Add(this.txtBloco);
            this.groupBox3.Controls.Add(this.btnSair);
            this.groupBox3.Controls.Add(this.dtVisita);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnLimpar);
            this.groupBox3.Controls.Add(this.btnSalvar);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(14, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(403, 128);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Local";
            // 
            // txtApartamento
            // 
            this.txtApartamento.Location = new System.Drawing.Point(89, 56);
            this.txtApartamento.Name = "txtApartamento";
            this.txtApartamento.Size = new System.Drawing.Size(144, 20);
            this.txtApartamento.TabIndex = 5;
            this.txtApartamento.TextChanged += new System.EventHandler(this.txtApartamento_TextChanged);
            // 
            // txtBloco
            // 
            this.txtBloco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBloco.Location = new System.Drawing.Point(89, 26);
            this.txtBloco.Name = "txtBloco";
            this.txtBloco.Size = new System.Drawing.Size(144, 20);
            this.txtBloco.TabIndex = 4;
            this.txtBloco.TextChanged += new System.EventHandler(this.txtBloco_TextChanged);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(261, 88);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 23);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dtVisita
            // 
            this.dtVisita.CustomFormat = "dd/MM/yyyy  HH:mm";
            this.dtVisita.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtVisita.Location = new System.Drawing.Point(89, 91);
            this.dtVisita.Name = "dtVisita";
            this.dtVisita.Size = new System.Drawing.Size(144, 20);
            this.dtVisita.TabIndex = 9;
            this.dtVisita.Value = new System.DateTime(2017, 8, 6, 18, 17, 24, 0);
            this.dtVisita.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data :";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(261, 54);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(90, 23);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(261, 24);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 23);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bloco :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Apartamento :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mstxtFone);
            this.groupBox2.Controls.Add(this.mstxtRg);
            this.groupBox2.Controls.Add(this.txtNomeVisita);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(14, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 100);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Pessoais";
            // 
            // mstxtFone
            // 
            this.mstxtFone.Location = new System.Drawing.Point(251, 57);
            this.mstxtFone.Mask = "(99) 00000-0000";
            this.mstxtFone.Name = "mstxtFone";
            this.mstxtFone.Size = new System.Drawing.Size(124, 20);
            this.mstxtFone.TabIndex = 3;
            // 
            // mstxtRg
            // 
            this.mstxtRg.Location = new System.Drawing.Point(57, 57);
            this.mstxtRg.Mask = "00,000,000-0";
            this.mstxtRg.Name = "mstxtRg";
            this.mstxtRg.Size = new System.Drawing.Size(100, 20);
            this.mstxtRg.TabIndex = 1;
            this.mstxtRg.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mstxtRg_MaskInputRejected);
            this.mstxtRg.TextChanged += new System.EventHandler(this.mstxtRg_TextChanged);
            // 
            // txtNomeVisita
            // 
            this.txtNomeVisita.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeVisita.Location = new System.Drawing.Point(57, 19);
            this.txtNomeVisita.Name = "txtNomeVisita";
            this.txtNomeVisita.Size = new System.Drawing.Size(318, 20);
            this.txtNomeVisita.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Celular : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RG :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkFechar);
            this.groupBox1.Controls.Add(nomeMoradorLabel);
            this.groupBox1.Controls.Add(this.txtNomeMorador2);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 511);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkFechar
            // 
            this.chkFechar.AutoSize = true;
            this.chkFechar.Checked = true;
            this.chkFechar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFechar.Location = new System.Drawing.Point(27, 488);
            this.chkFechar.Name = "chkFechar";
            this.chkFechar.Size = new System.Drawing.Size(160, 17);
            this.chkFechar.TabIndex = 8;
            this.chkFechar.Text = "Fechar janela após cadastro";
            this.chkFechar.UseVisualStyleBackColor = true;
            this.chkFechar.CheckedChanged += new System.EventHandler(this.chkFechar_CheckedChanged);
            // 
            // txtNomeMorador2
            // 
            this.txtNomeMorador2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeMorador2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moradorBindingSource, "NomeMorador", true));
            this.txtNomeMorador2.Location = new System.Drawing.Point(71, 260);
            this.txtNomeMorador2.Name = "txtNomeMorador2";
            this.txtNomeMorador2.ReadOnly = true;
            this.txtNomeMorador2.Size = new System.Drawing.Size(318, 20);
            this.txtNomeMorador2.TabIndex = 6;
            this.txtNomeMorador2.TextChanged += new System.EventHandler(this.txtNomeMorador2_TextChanged);
            // 
            // moradorBindingSource
            // 
            this.moradorBindingSource.DataMember = "Morador";
            this.moradorBindingSource.DataSource = this.portariaDBDataSet;
            // 
            // portariaDBDataSet
            // 
            this.portariaDBDataSet.DataSetName = "PortariaDBDataSet";
            this.portariaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rtxtObsVisita);
            this.groupBox4.Location = new System.Drawing.Point(14, 296);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(403, 183);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Observação";
            // 
            // rtxtObsVisita
            // 
            this.rtxtObsVisita.Location = new System.Drawing.Point(6, 19);
            this.rtxtObsVisita.Name = "rtxtObsVisita";
            this.rtxtObsVisita.Size = new System.Drawing.Size(391, 153);
            this.rtxtObsVisita.TabIndex = 7;
            this.rtxtObsVisita.Text = "";
            // 
            // moradorTableAdapter
            // 
            this.moradorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LogVisitaTableAdapter = null;
            this.tableAdapterManager.MoradorTableAdapter = this.moradorTableAdapter;
            this.tableAdapterManager.UpdateOrder = Portaria.PortariaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VISITATableAdapter = null;
            // 
            // cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 521);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.cadastro_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moradorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portariaDBDataSet)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mstxtRg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox rtxtObsVisita;
        public System.Windows.Forms.DateTimePicker dtVisita;
        private System.Windows.Forms.Button btnSair;
        private PortariaDBDataSet portariaDBDataSet;
        private System.Windows.Forms.BindingSource moradorBindingSource;
        private PortariaDBDataSetTableAdapters.MoradorTableAdapter moradorTableAdapter;
        private PortariaDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.TextBox txtNomeVisita;
        public System.Windows.Forms.TextBox txtApartamento;
        public System.Windows.Forms.TextBox txtBloco;
        public System.Windows.Forms.TextBox txtNomeMorador2;
        private System.Windows.Forms.CheckBox chkFechar;
        private System.Windows.Forms.MaskedTextBox mstxtFone;

    }
}