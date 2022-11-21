namespace Portaria
{
    partial class CadVisita
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
            System.Windows.Forms.Label nm_VisitaLabel;
            System.Windows.Forms.Label doc_VisitaLabel;
            System.Windows.Forms.Label tel_VisitaLabel;
            System.Windows.Forms.Label carro_VisitaLabel;
            System.Windows.Forms.Label placaCarro_VisitaLabel;
            System.Windows.Forms.Label empresaLabel;
            System.Windows.Forms.Label segmentoLabel;
            this.portariaDBDataSet = new Portaria.PortariaDBDataSet();
            this.vISITABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vISITATableAdapter = new Portaria.PortariaDBDataSetTableAdapters.VISITATableAdapter();
            this.tableAdapterManager = new Portaria.PortariaDBDataSetTableAdapters.TableAdapterManager();
            this.txtNomeVisita = new System.Windows.Forms.TextBox();
            this.txtVeiculo = new System.Windows.Forms.TextBox();
            this.mstxtFoneVisita = new System.Windows.Forms.MaskedTextBox();
            this.mstxtRgVisita = new System.Windows.Forms.MaskedTextBox();
            this.mstxtPlacaVisita = new System.Windows.Forms.MaskedTextBox();
            this.chkPrestador = new System.Windows.Forms.CheckBox();
            this.gpboxPrestador = new System.Windows.Forms.GroupBox();
            this.cmbSegmento = new System.Windows.Forms.ComboBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.rchtxtObs = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkFechar = new System.Windows.Forms.CheckBox();
            nm_VisitaLabel = new System.Windows.Forms.Label();
            doc_VisitaLabel = new System.Windows.Forms.Label();
            tel_VisitaLabel = new System.Windows.Forms.Label();
            carro_VisitaLabel = new System.Windows.Forms.Label();
            placaCarro_VisitaLabel = new System.Windows.Forms.Label();
            empresaLabel = new System.Windows.Forms.Label();
            segmentoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.portariaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vISITABindingSource)).BeginInit();
            this.gpboxPrestador.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nm_VisitaLabel
            // 
            nm_VisitaLabel.AutoSize = true;
            nm_VisitaLabel.Location = new System.Drawing.Point(21, 22);
            nm_VisitaLabel.Name = "nm_VisitaLabel";
            nm_VisitaLabel.Size = new System.Drawing.Size(41, 13);
            nm_VisitaLabel.TabIndex = 1;
            nm_VisitaLabel.Text = "Nome :";
            // 
            // doc_VisitaLabel
            // 
            doc_VisitaLabel.AutoSize = true;
            doc_VisitaLabel.Location = new System.Drawing.Point(33, 59);
            doc_VisitaLabel.Name = "doc_VisitaLabel";
            doc_VisitaLabel.Size = new System.Drawing.Size(29, 13);
            doc_VisitaLabel.TabIndex = 3;
            doc_VisitaLabel.Text = "RG :";
            // 
            // tel_VisitaLabel
            // 
            tel_VisitaLabel.AutoSize = true;
            tel_VisitaLabel.Location = new System.Drawing.Point(279, 59);
            tel_VisitaLabel.Name = "tel_VisitaLabel";
            tel_VisitaLabel.Size = new System.Drawing.Size(55, 13);
            tel_VisitaLabel.TabIndex = 5;
            tel_VisitaLabel.Text = "Telefone :";
            // 
            // carro_VisitaLabel
            // 
            carro_VisitaLabel.AutoSize = true;
            carro_VisitaLabel.Location = new System.Drawing.Point(12, 106);
            carro_VisitaLabel.Name = "carro_VisitaLabel";
            carro_VisitaLabel.Size = new System.Drawing.Size(50, 13);
            carro_VisitaLabel.TabIndex = 7;
            carro_VisitaLabel.Text = "Veículo :";
            carro_VisitaLabel.Click += new System.EventHandler(this.carro_VisitaLabel_Click);
            // 
            // placaCarro_VisitaLabel
            // 
            placaCarro_VisitaLabel.AutoSize = true;
            placaCarro_VisitaLabel.Location = new System.Drawing.Point(318, 106);
            placaCarro_VisitaLabel.Name = "placaCarro_VisitaLabel";
            placaCarro_VisitaLabel.Size = new System.Drawing.Size(40, 13);
            placaCarro_VisitaLabel.TabIndex = 9;
            placaCarro_VisitaLabel.Text = "Placa :";
            // 
            // empresaLabel
            // 
            empresaLabel.AutoSize = true;
            empresaLabel.Location = new System.Drawing.Point(21, 34);
            empresaLabel.Name = "empresaLabel";
            empresaLabel.Size = new System.Drawing.Size(54, 13);
            empresaLabel.TabIndex = 0;
            empresaLabel.Text = "Empresa :";
            // 
            // segmentoLabel
            // 
            segmentoLabel.AutoSize = true;
            segmentoLabel.Location = new System.Drawing.Point(14, 67);
            segmentoLabel.Name = "segmentoLabel";
            segmentoLabel.Size = new System.Drawing.Size(61, 13);
            segmentoLabel.TabIndex = 2;
            segmentoLabel.Text = "Segmento :";
            // 
            // portariaDBDataSet
            // 
            this.portariaDBDataSet.DataSetName = "PortariaDBDataSet";
            this.portariaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vISITABindingSource
            // 
            this.vISITABindingSource.DataMember = "VISITA";
            this.vISITABindingSource.DataSource = this.portariaDBDataSet;
            // 
            // vISITATableAdapter
            // 
            this.vISITATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LogVisitaTableAdapter = null;
            this.tableAdapterManager.MoradorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Portaria.PortariaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VISITATableAdapter = this.vISITATableAdapter;
            // 
            // txtNomeVisita
            // 
            this.txtNomeVisita.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeVisita.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vISITABindingSource, "nm_Visita", true));
            this.txtNomeVisita.Location = new System.Drawing.Point(68, 19);
            this.txtNomeVisita.Name = "txtNomeVisita";
            this.txtNomeVisita.Size = new System.Drawing.Size(358, 20);
            this.txtNomeVisita.TabIndex = 2;
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVeiculo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vISITABindingSource, "carro_Visita", true));
            this.txtVeiculo.Location = new System.Drawing.Point(68, 103);
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.Size = new System.Drawing.Size(221, 20);
            this.txtVeiculo.TabIndex = 4;
            // 
            // mstxtFoneVisita
            // 
            this.mstxtFoneVisita.Location = new System.Drawing.Point(341, 56);
            this.mstxtFoneVisita.Mask = "(99) 00000-0000";
            this.mstxtFoneVisita.Name = "mstxtFoneVisita";
            this.mstxtFoneVisita.Size = new System.Drawing.Size(85, 20);
            this.mstxtFoneVisita.TabIndex = 3;
            // 
            // mstxtRgVisita
            // 
            this.mstxtRgVisita.Location = new System.Drawing.Point(68, 56);
            this.mstxtRgVisita.Mask = "00,000,000->A";
            this.mstxtRgVisita.Name = "mstxtRgVisita";
            this.mstxtRgVisita.Size = new System.Drawing.Size(85, 20);
            this.mstxtRgVisita.TabIndex = 1;
            this.mstxtRgVisita.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mstxtRg_MaskInputRejected);
            this.mstxtRgVisita.TextChanged += new System.EventHandler(this.mstxtRgVisita_TextChanged);
            // 
            // mstxtPlacaVisita
            // 
            this.mstxtPlacaVisita.Location = new System.Drawing.Point(365, 103);
            this.mstxtPlacaVisita.Mask = "AAA-0000";
            this.mstxtPlacaVisita.Name = "mstxtPlacaVisita";
            this.mstxtPlacaVisita.Size = new System.Drawing.Size(61, 20);
            this.mstxtPlacaVisita.TabIndex = 5;
            // 
            // chkPrestador
            // 
            this.chkPrestador.AutoSize = true;
            this.chkPrestador.Location = new System.Drawing.Point(139, 138);
            this.chkPrestador.Name = "chkPrestador";
            this.chkPrestador.Size = new System.Drawing.Size(174, 17);
            this.chkPrestador.TabIndex = 6;
            this.chkPrestador.Text = "Prestador de serviço / Entrega ";
            this.chkPrestador.UseVisualStyleBackColor = true;
            this.chkPrestador.CheckedChanged += new System.EventHandler(this.chkPrestador_CheckedChanged);
            this.chkPrestador.CheckStateChanged += new System.EventHandler(this.chkPrestador_CheckStateChanged);
            // 
            // gpboxPrestador
            // 
            this.gpboxPrestador.Controls.Add(this.cmbSegmento);
            this.gpboxPrestador.Controls.Add(segmentoLabel);
            this.gpboxPrestador.Controls.Add(empresaLabel);
            this.gpboxPrestador.Controls.Add(this.txtEmpresa);
            this.gpboxPrestador.Location = new System.Drawing.Point(12, 166);
            this.gpboxPrestador.Name = "gpboxPrestador";
            this.gpboxPrestador.Size = new System.Drawing.Size(425, 116);
            this.gpboxPrestador.TabIndex = 18;
            this.gpboxPrestador.TabStop = false;
            this.gpboxPrestador.Text = "Dados da Empresa de Serviço/Entrega";
            this.gpboxPrestador.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbSegmento
            // 
            this.cmbSegmento.FormattingEnabled = true;
            this.cmbSegmento.Items.AddRange(new object[] {
            "Construtora ( Elétrica / Hidráulica)",
            "Correios",
            "Moveis (Entrega e Montagem)",
            "Oficiais (Policia/Bombeiro/Oficial de Justiça)",
            "Outras Entregas ",
            "Outros Serviços",
            ""});
            this.cmbSegmento.Location = new System.Drawing.Point(78, 64);
            this.cmbSegmento.Name = "cmbSegmento";
            this.cmbSegmento.Size = new System.Drawing.Size(333, 21);
            this.cmbSegmento.TabIndex = 8;
            this.cmbSegmento.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmpresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vISITABindingSource, "Empresa", true));
            this.txtEmpresa.Location = new System.Drawing.Point(78, 31);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(333, 20);
            this.txtEmpresa.TabIndex = 7;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(336, 557);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(90, 23);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(24, 557);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(136, 557);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 11;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(238, 557);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 13;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // rchtxtObs
            // 
            this.rchtxtObs.Location = new System.Drawing.Point(12, 19);
            this.rchtxtObs.Name = "rchtxtObs";
            this.rchtxtObs.Size = new System.Drawing.Size(399, 201);
            this.rchtxtObs.TabIndex = 9;
            this.rchtxtObs.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rchtxtObs);
            this.groupBox1.Location = new System.Drawing.Point(12, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 243);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Observação";
            // 
            // chkFechar
            // 
            this.chkFechar.AutoSize = true;
            this.chkFechar.Checked = true;
            this.chkFechar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFechar.Location = new System.Drawing.Point(26, 587);
            this.chkFechar.Name = "chkFechar";
            this.chkFechar.Size = new System.Drawing.Size(160, 17);
            this.chkFechar.TabIndex = 29;
            this.chkFechar.Text = "Fechar janela após cadastro";
            this.chkFechar.UseVisualStyleBackColor = true;
            this.chkFechar.CheckedChanged += new System.EventHandler(this.chkFechar_CheckedChanged);
            // 
            // CadVisita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 613);
            this.Controls.Add(this.chkFechar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gpboxPrestador);
            this.Controls.Add(this.chkPrestador);
            this.Controls.Add(this.mstxtPlacaVisita);
            this.Controls.Add(this.mstxtFoneVisita);
            this.Controls.Add(this.mstxtRgVisita);
            this.Controls.Add(placaCarro_VisitaLabel);
            this.Controls.Add(carro_VisitaLabel);
            this.Controls.Add(this.txtVeiculo);
            this.Controls.Add(tel_VisitaLabel);
            this.Controls.Add(doc_VisitaLabel);
            this.Controls.Add(nm_VisitaLabel);
            this.Controls.Add(this.txtNomeVisita);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadVisita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Visitante";
            this.Load += new System.EventHandler(this.CadVisita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.portariaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vISITABindingSource)).EndInit();
            this.gpboxPrestador.ResumeLayout(false);
            this.gpboxPrestador.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PortariaDBDataSet portariaDBDataSet;
        private System.Windows.Forms.BindingSource vISITABindingSource;
        private PortariaDBDataSetTableAdapters.VISITATableAdapter vISITATableAdapter;
        private PortariaDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtNomeVisita;
        private System.Windows.Forms.TextBox txtVeiculo;
        private System.Windows.Forms.MaskedTextBox mstxtFoneVisita;
        private System.Windows.Forms.MaskedTextBox mstxtRgVisita;
        private System.Windows.Forms.MaskedTextBox mstxtPlacaVisita;
        private System.Windows.Forms.CheckBox chkPrestador;
        private System.Windows.Forms.GroupBox gpboxPrestador;
        private System.Windows.Forms.ComboBox cmbSegmento;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.RichTextBox rchtxtObs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkFechar;
    }
}