namespace Portaria
{
    partial class Relatorio
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
            System.Windows.Forms.Label nomeVisitaLabel;
            System.Windows.Forms.Label responsavelLabel;
            System.Windows.Forms.Label apartamentoVisitaLabel;
            System.Windows.Forms.Label blocoVisitaLabel;
            System.Windows.Forms.Label label1;
            this.portariaDBDataSet = new Portaria.PortariaDBDataSet();
            this.moradorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moradorTableAdapter = new Portaria.PortariaDBDataSetTableAdapters.MoradorTableAdapter();
            this.tableAdapterManager = new Portaria.PortariaDBDataSetTableAdapters.TableAdapterManager();
            this.logVisitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logVisitaTableAdapter = new Portaria.PortariaDBDataSetTableAdapters.LogVisitaTableAdapter();
            this.txtNomeVisitaRel = new System.Windows.Forms.TextBox();
            this.txtRespVisitaRel = new System.Windows.Forms.TextBox();
            this.txtApVisitaRel = new System.Windows.Forms.TextBox();
            this.txtBlocoVisitaRel = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnLimpaRel = new System.Windows.Forms.Button();
            this.btnPesquisaRel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomeVisitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docVisitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blocoVisitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartamentoVisitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsavelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtVisitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            nomeVisitaLabel = new System.Windows.Forms.Label();
            responsavelLabel = new System.Windows.Forms.Label();
            apartamentoVisitaLabel = new System.Windows.Forms.Label();
            blocoVisitaLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.portariaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moradorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logVisitaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeVisitaLabel
            // 
            nomeVisitaLabel.AutoSize = true;
            nomeVisitaLabel.Location = new System.Drawing.Point(237, 35);
            nomeVisitaLabel.Name = "nomeVisitaLabel";
            nomeVisitaLabel.Size = new System.Drawing.Size(66, 13);
            nomeVisitaLabel.TabIndex = 2;
            nomeVisitaLabel.Text = "Nome Visita:";
            // 
            // responsavelLabel
            // 
            responsavelLabel.AutoSize = true;
            responsavelLabel.Location = new System.Drawing.Point(13, 74);
            responsavelLabel.Name = "responsavelLabel";
            responsavelLabel.Size = new System.Drawing.Size(72, 13);
            responsavelLabel.TabIndex = 4;
            responsavelLabel.Text = "Responsavel:";
            // 
            // apartamentoVisitaLabel
            // 
            apartamentoVisitaLabel.AutoSize = true;
            apartamentoVisitaLabel.Location = new System.Drawing.Point(457, 74);
            apartamentoVisitaLabel.Name = "apartamentoVisitaLabel";
            apartamentoVisitaLabel.Size = new System.Drawing.Size(73, 13);
            apartamentoVisitaLabel.TabIndex = 6;
            apartamentoVisitaLabel.Text = "Apartamento :";
            // 
            // blocoVisitaLabel
            // 
            blocoVisitaLabel.AutoSize = true;
            blocoVisitaLabel.Location = new System.Drawing.Point(336, 74);
            blocoVisitaLabel.Name = "blocoVisitaLabel";
            blocoVisitaLabel.Size = new System.Drawing.Size(40, 13);
            blocoVisitaLabel.TabIndex = 8;
            blocoVisitaLabel.Text = "Bloco :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 35);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(79, 13);
            label1.TabIndex = 11;
            label1.Text = "Data da  Visita:";
            // 
            // portariaDBDataSet
            // 
            this.portariaDBDataSet.DataSetName = "PortariaDBDataSet";
            this.portariaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moradorBindingSource
            // 
            this.moradorBindingSource.DataMember = "Morador";
            this.moradorBindingSource.DataSource = this.portariaDBDataSet;
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
            // 
            // logVisitaBindingSource
            // 
            this.logVisitaBindingSource.DataMember = "LogVisita";
            this.logVisitaBindingSource.DataSource = this.portariaDBDataSet;
            // 
            // logVisitaTableAdapter
            // 
            this.logVisitaTableAdapter.ClearBeforeFill = true;
            // 
            // txtNomeVisitaRel
            // 
            this.txtNomeVisitaRel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeVisitaRel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.logVisitaBindingSource, "NomeVisita", true));
            this.txtNomeVisitaRel.Location = new System.Drawing.Point(309, 32);
            this.txtNomeVisitaRel.Name = "txtNomeVisitaRel";
            this.txtNomeVisitaRel.Size = new System.Drawing.Size(287, 20);
            this.txtNomeVisitaRel.TabIndex = 2;
            // 
            // txtRespVisitaRel
            // 
            this.txtRespVisitaRel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRespVisitaRel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.logVisitaBindingSource, "Responsavel", true));
            this.txtRespVisitaRel.Location = new System.Drawing.Point(91, 71);
            this.txtRespVisitaRel.Name = "txtRespVisitaRel";
            this.txtRespVisitaRel.Size = new System.Drawing.Size(233, 20);
            this.txtRespVisitaRel.TabIndex = 3;
            // 
            // txtApVisitaRel
            // 
            this.txtApVisitaRel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApVisitaRel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.logVisitaBindingSource, "ApartamentoVisita", true));
            this.txtApVisitaRel.Location = new System.Drawing.Point(534, 71);
            this.txtApVisitaRel.Name = "txtApVisitaRel";
            this.txtApVisitaRel.Size = new System.Drawing.Size(62, 20);
            this.txtApVisitaRel.TabIndex = 5;
            // 
            // txtBlocoVisitaRel
            // 
            this.txtBlocoVisitaRel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBlocoVisitaRel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.logVisitaBindingSource, "BlocoVisita", true));
            this.txtBlocoVisitaRel.Location = new System.Drawing.Point(378, 71);
            this.txtBlocoVisitaRel.Name = "txtBlocoVisitaRel";
            this.txtBlocoVisitaRel.Size = new System.Drawing.Size(65, 20);
            this.txtBlocoVisitaRel.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.btnLimpaRel);
            this.groupBox1.Controls.Add(this.btnPesquisaRel);
            this.groupBox1.Controls.Add(this.txtBlocoVisitaRel);
            this.groupBox1.Controls.Add(blocoVisitaLabel);
            this.groupBox1.Controls.Add(apartamentoVisitaLabel);
            this.groupBox1.Controls.Add(this.txtApVisitaRel);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.txtNomeVisitaRel);
            this.groupBox1.Controls.Add(nomeVisitaLabel);
            this.groupBox1.Controls.Add(responsavelLabel);
            this.groupBox1.Controls.Add(this.txtRespVisitaRel);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 116);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar por:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(91, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(83, 20);
            this.dateTimePicker1.TabIndex = 21;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(614, 79);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 20;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnLimpaRel
            // 
            this.btnLimpaRel.Location = new System.Drawing.Point(614, 50);
            this.btnLimpaRel.Name = "btnLimpaRel";
            this.btnLimpaRel.Size = new System.Drawing.Size(75, 23);
            this.btnLimpaRel.TabIndex = 19;
            this.btnLimpaRel.Text = "Limpar";
            this.btnLimpaRel.UseVisualStyleBackColor = true;
            this.btnLimpaRel.Click += new System.EventHandler(this.btnLimpaRel_Click);
            // 
            // btnPesquisaRel
            // 
            this.btnPesquisaRel.Location = new System.Drawing.Point(614, 22);
            this.btnPesquisaRel.Name = "btnPesquisaRel";
            this.btnPesquisaRel.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisaRel.TabIndex = 18;
            this.btnPesquisaRel.Text = "Pesquisar";
            this.btnPesquisaRel.UseVisualStyleBackColor = true;
            this.btnPesquisaRel.Click += new System.EventHandler(this.btnPesquisaRel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeVisitaDataGridViewTextBoxColumn,
            this.docVisitaDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.blocoVisitaDataGridViewTextBoxColumn,
            this.apartamentoVisitaDataGridViewTextBoxColumn,
            this.responsavelDataGridViewTextBoxColumn,
            this.dtVisitaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.logVisitaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(704, 207);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nomeVisitaDataGridViewTextBoxColumn
            // 
            this.nomeVisitaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nomeVisitaDataGridViewTextBoxColumn.DataPropertyName = "NomeVisita";
            this.nomeVisitaDataGridViewTextBoxColumn.HeaderText = "Nome:";
            this.nomeVisitaDataGridViewTextBoxColumn.Name = "nomeVisitaDataGridViewTextBoxColumn";
            this.nomeVisitaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeVisitaDataGridViewTextBoxColumn.Width = 63;
            // 
            // docVisitaDataGridViewTextBoxColumn
            // 
            this.docVisitaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.docVisitaDataGridViewTextBoxColumn.DataPropertyName = "DocVisita";
            this.docVisitaDataGridViewTextBoxColumn.HeaderText = "RG:";
            this.docVisitaDataGridViewTextBoxColumn.Name = "docVisitaDataGridViewTextBoxColumn";
            this.docVisitaDataGridViewTextBoxColumn.ReadOnly = true;
            this.docVisitaDataGridViewTextBoxColumn.Width = 51;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone:";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneDataGridViewTextBoxColumn.Width = 77;
            // 
            // blocoVisitaDataGridViewTextBoxColumn
            // 
            this.blocoVisitaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.blocoVisitaDataGridViewTextBoxColumn.DataPropertyName = "BlocoVisita";
            this.blocoVisitaDataGridViewTextBoxColumn.HeaderText = "Bloco:";
            this.blocoVisitaDataGridViewTextBoxColumn.Name = "blocoVisitaDataGridViewTextBoxColumn";
            this.blocoVisitaDataGridViewTextBoxColumn.ReadOnly = true;
            this.blocoVisitaDataGridViewTextBoxColumn.Width = 62;
            // 
            // apartamentoVisitaDataGridViewTextBoxColumn
            // 
            this.apartamentoVisitaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.apartamentoVisitaDataGridViewTextBoxColumn.DataPropertyName = "ApartamentoVisita";
            this.apartamentoVisitaDataGridViewTextBoxColumn.HeaderText = "Apartamento:";
            this.apartamentoVisitaDataGridViewTextBoxColumn.Name = "apartamentoVisitaDataGridViewTextBoxColumn";
            this.apartamentoVisitaDataGridViewTextBoxColumn.ReadOnly = true;
            this.apartamentoVisitaDataGridViewTextBoxColumn.Width = 95;
            // 
            // responsavelDataGridViewTextBoxColumn
            // 
            this.responsavelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.responsavelDataGridViewTextBoxColumn.DataPropertyName = "Responsavel";
            this.responsavelDataGridViewTextBoxColumn.HeaderText = "Responsavel:";
            this.responsavelDataGridViewTextBoxColumn.Name = "responsavelDataGridViewTextBoxColumn";
            this.responsavelDataGridViewTextBoxColumn.ReadOnly = true;
            this.responsavelDataGridViewTextBoxColumn.Width = 97;
            // 
            // dtVisitaDataGridViewTextBoxColumn
            // 
            this.dtVisitaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dtVisitaDataGridViewTextBoxColumn.DataPropertyName = "DtVisita";
            this.dtVisitaDataGridViewTextBoxColumn.HeaderText = "Data:";
            this.dtVisitaDataGridViewTextBoxColumn.Name = "dtVisitaDataGridViewTextBoxColumn";
            this.dtVisitaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtVisitaDataGridViewTextBoxColumn.Width = 58;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 354);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Relatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio";
            this.Load += new System.EventHandler(this.Relatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.portariaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moradorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logVisitaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PortariaDBDataSet portariaDBDataSet;
        private System.Windows.Forms.BindingSource moradorBindingSource;
        private PortariaDBDataSetTableAdapters.MoradorTableAdapter moradorTableAdapter;
        private PortariaDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource logVisitaBindingSource;
        private PortariaDBDataSetTableAdapters.LogVisitaTableAdapter logVisitaTableAdapter;
        private System.Windows.Forms.TextBox txtNomeVisitaRel;
        private System.Windows.Forms.TextBox txtRespVisitaRel;
        private System.Windows.Forms.TextBox txtApVisitaRel;
        private System.Windows.Forms.TextBox txtBlocoVisitaRel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpaRel;
        private System.Windows.Forms.Button btnPesquisaRel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeVisitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docVisitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blocoVisitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartamentoVisitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsavelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtVisitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnImprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}