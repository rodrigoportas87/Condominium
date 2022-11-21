namespace Portaria
{
    partial class CadastroMorador
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
            System.Windows.Forms.Label lblNomeMorador;
            System.Windows.Forms.Label blocoLabel;
            System.Windows.Forms.Label observacaoMoradorLabel;
            System.Windows.Forms.Label apartamentoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroMorador));
            this.PortariaDBDataSet = new Portaria.PortariaDBDataSet();
            this.moradorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moradorTableAdapter = new Portaria.PortariaDBDataSetTableAdapters.MoradorTableAdapter();
            this.tableAdapterManager = new Portaria.PortariaDBDataSetTableAdapters.TableAdapterManager();
            this.txtNomeMorador = new System.Windows.Forms.TextBox();
            this.txtBlocoMorador = new System.Windows.Forms.TextBox();
            this.txtApMorador = new System.Windows.Forms.TextBox();
            this.rtxtObs = new System.Windows.Forms.RichTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.logVisitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logVisitaTableAdapter = new Portaria.PortariaDBDataSetTableAdapters.LogVisitaTableAdapter();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.moradorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            lblNomeMorador = new System.Windows.Forms.Label();
            blocoLabel = new System.Windows.Forms.Label();
            observacaoMoradorLabel = new System.Windows.Forms.Label();
            apartamentoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PortariaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moradorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logVisitaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moradorBindingNavigator)).BeginInit();
            this.moradorBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeMorador
            // 
            lblNomeMorador.AutoSize = true;
            lblNomeMorador.Location = new System.Drawing.Point(24, 35);
            lblNomeMorador.Name = "lblNomeMorador";
            lblNomeMorador.Size = new System.Drawing.Size(41, 13);
            lblNomeMorador.TabIndex = 2;
            lblNomeMorador.Text = "Nome :";
            lblNomeMorador.Click += new System.EventHandler(this.lblNomeMorador_Click);
            // 
            // blocoLabel
            // 
            blocoLabel.AutoSize = true;
            blocoLabel.Location = new System.Drawing.Point(25, 61);
            blocoLabel.Name = "blocoLabel";
            blocoLabel.Size = new System.Drawing.Size(40, 13);
            blocoLabel.TabIndex = 4;
            blocoLabel.Text = "Bloco :";
            // 
            // observacaoMoradorLabel
            // 
            observacaoMoradorLabel.AutoSize = true;
            observacaoMoradorLabel.Location = new System.Drawing.Point(25, 92);
            observacaoMoradorLabel.Name = "observacaoMoradorLabel";
            observacaoMoradorLabel.Size = new System.Drawing.Size(71, 13);
            observacaoMoradorLabel.TabIndex = 6;
            observacaoMoradorLabel.Text = "Observação :";
            // 
            // apartamentoLabel
            // 
            apartamentoLabel.AutoSize = true;
            apartamentoLabel.Location = new System.Drawing.Point(246, 64);
            apartamentoLabel.Name = "apartamentoLabel";
            apartamentoLabel.Size = new System.Drawing.Size(73, 13);
            apartamentoLabel.TabIndex = 8;
            apartamentoLabel.Text = "Apartamento :";
            // 
            // PortariaDBDataSet
            // 
            this.PortariaDBDataSet.DataSetName = "PortariaDBDataSet";
            this.PortariaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moradorBindingSource
            // 
            this.moradorBindingSource.DataMember = "Morador";
            this.moradorBindingSource.DataSource = this.PortariaDBDataSet;
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
            // txtNomeMorador
            // 
            this.txtNomeMorador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeMorador.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moradorBindingSource, "NomeMorador", true));
            this.txtNomeMorador.Location = new System.Drawing.Point(72, 32);
            this.txtNomeMorador.Name = "txtNomeMorador";
            this.txtNomeMorador.Size = new System.Drawing.Size(350, 20);
            this.txtNomeMorador.TabIndex = 1;
            // 
            // txtBlocoMorador
            // 
            this.txtBlocoMorador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBlocoMorador.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moradorBindingSource, "Bloco", true));
            this.txtBlocoMorador.Location = new System.Drawing.Point(72, 58);
            this.txtBlocoMorador.MaxLength = 2;
            this.txtBlocoMorador.Name = "txtBlocoMorador";
            this.txtBlocoMorador.Size = new System.Drawing.Size(100, 20);
            this.txtBlocoMorador.TabIndex = 2;
            // 
            // txtApMorador
            // 
            this.txtApMorador.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moradorBindingSource, "Apartamento", true));
            this.txtApMorador.Location = new System.Drawing.Point(322, 61);
            this.txtApMorador.MaxLength = 3;
            this.txtApMorador.Name = "txtApMorador";
            this.txtApMorador.Size = new System.Drawing.Size(100, 20);
            this.txtApMorador.TabIndex = 3;
            // 
            // rtxtObs
            // 
            this.rtxtObs.Location = new System.Drawing.Point(28, 108);
            this.rtxtObs.Name = "rtxtObs";
            this.rtxtObs.Size = new System.Drawing.Size(394, 199);
            this.rtxtObs.TabIndex = 4;
            this.rtxtObs.Text = "";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(28, 326);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(266, 326);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(185, 326);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 7;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(347, 326);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // logVisitaBindingSource
            // 
            this.logVisitaBindingSource.DataMember = "LogVisita";
            this.logVisitaBindingSource.DataSource = this.PortariaDBDataSet;
            // 
            // logVisitaTableAdapter
            // 
            this.logVisitaTableAdapter.ClearBeforeFill = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(107, 326);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // moradorBindingNavigator
            // 
            this.moradorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.moradorBindingNavigator.BindingSource = this.moradorBindingSource;
            this.moradorBindingNavigator.CountItem = this.bindingNavigatorCountItem1;
            this.moradorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.moradorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.moradorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.moradorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.moradorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.moradorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.moradorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.moradorBindingNavigator.Name = "moradorBindingNavigator";
            this.moradorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem1;
            this.moradorBindingNavigator.Size = new System.Drawing.Size(442, 25);
            this.moradorBindingNavigator.TabIndex = 16;
            this.moradorBindingNavigator.Text = "bindingNavigator1";
            this.moradorBindingNavigator.RefreshItems += new System.EventHandler(this.moradorBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            this.bindingNavigatorCountItem1.Click += new System.EventHandler(this.bindingNavigatorCountItem1_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // CadastroMorador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 369);
            this.Controls.Add(this.moradorBindingNavigator);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.rtxtObs);
            this.Controls.Add(apartamentoLabel);
            this.Controls.Add(this.txtApMorador);
            this.Controls.Add(observacaoMoradorLabel);
            this.Controls.Add(blocoLabel);
            this.Controls.Add(this.txtBlocoMorador);
            this.Controls.Add(lblNomeMorador);
            this.Controls.Add(this.txtNomeMorador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroMorador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Moradores";
            this.Load += new System.EventHandler(this.CadastroMorador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PortariaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moradorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logVisitaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moradorBindingNavigator)).EndInit();
            this.moradorBindingNavigator.ResumeLayout(false);
            this.moradorBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PortariaDBDataSet PortariaDBDataSet;
        private System.Windows.Forms.BindingSource moradorBindingSource;
        private PortariaDBDataSetTableAdapters.MoradorTableAdapter moradorTableAdapter;
        private PortariaDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtNomeMorador;
        private System.Windows.Forms.TextBox txtBlocoMorador;
        private System.Windows.Forms.TextBox txtApMorador;
        private System.Windows.Forms.RichTextBox rtxtObs;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.BindingSource logVisitaBindingSource;
        private PortariaDBDataSetTableAdapters.LogVisitaTableAdapter logVisitaTableAdapter;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.BindingNavigator moradorBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
    }
}