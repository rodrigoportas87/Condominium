namespace Portaria
{
    partial class mainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moradorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn1A = new System.Windows.Forms.Button();
            this.btn1B = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn2A = new System.Windows.Forms.Button();
            this.btn2B = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn3B = new System.Windows.Forms.Button();
            this.btn3A = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn4A = new System.Windows.Forms.Button();
            this.btn4B = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn5B = new System.Windows.Forms.Button();
            this.btn5A = new System.Windows.Forms.Button();
            this.portariaDBDataSet = new Portaria.PortariaDBDataSet();
            this.moradorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moradorTableAdapter = new Portaria.PortariaDBDataSetTableAdapters.MoradorTableAdapter();
            this.tableAdapterManager = new Portaria.PortariaDBDataSetTableAdapters.TableAdapterManager();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portariaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moradorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.relatórioToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moradoresToolStripMenuItem,
            this.moradorToolStripMenuItem1});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            resources.ApplyResources(this.cadastroToolStripMenuItem, "cadastroToolStripMenuItem");
            // 
            // moradoresToolStripMenuItem
            // 
            this.moradoresToolStripMenuItem.Name = "moradoresToolStripMenuItem";
            resources.ApplyResources(this.moradoresToolStripMenuItem, "moradoresToolStripMenuItem");
            this.moradoresToolStripMenuItem.Click += new System.EventHandler(this.moradoresToolStripMenuItem_Click);
            // 
            // moradorToolStripMenuItem1
            // 
            this.moradorToolStripMenuItem1.Name = "moradorToolStripMenuItem1";
            resources.ApplyResources(this.moradorToolStripMenuItem1, "moradorToolStripMenuItem1");
            this.moradorToolStripMenuItem1.Click += new System.EventHandler(this.moradorToolStripMenuItem1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn1A);
            this.groupBox1.Controls.Add(this.btn1B);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btn1A
            // 
            this.btn1A.BackgroundImage = global::Portaria.Properties.Resources.building_512;
            resources.ApplyResources(this.btn1A, "btn1A");
            this.btn1A.Name = "btn1A";
            this.btn1A.UseVisualStyleBackColor = true;
            this.btn1A.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn1B
            // 
            this.btn1B.BackgroundImage = global::Portaria.Properties.Resources.building_512;
            resources.ApplyResources(this.btn1B, "btn1B");
            this.btn1B.Name = "btn1B";
            this.btn1B.UseVisualStyleBackColor = true;
            this.btn1B.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn2A);
            this.groupBox2.Controls.Add(this.btn2B);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // btn2A
            // 
            this.btn2A.BackgroundImage = global::Portaria.Properties.Resources.building_512;
            resources.ApplyResources(this.btn2A, "btn2A");
            this.btn2A.Name = "btn2A";
            this.btn2A.UseVisualStyleBackColor = true;
            this.btn2A.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn2B
            // 
            this.btn2B.BackgroundImage = global::Portaria.Properties.Resources.building_512;
            resources.ApplyResources(this.btn2B, "btn2B");
            this.btn2B.Name = "btn2B";
            this.btn2B.UseVisualStyleBackColor = true;
            this.btn2B.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn3B);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btn3A);
            this.groupBox3.Controls.Add(this.label5);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // btn3B
            // 
            this.btn3B.BackgroundImage = global::Portaria.Properties.Resources.building_512;
            resources.ApplyResources(this.btn3B, "btn3B");
            this.btn3B.Name = "btn3B";
            this.btn3B.UseVisualStyleBackColor = true;
            this.btn3B.Click += new System.EventHandler(this.button10_Click);
            // 
            // btn3A
            // 
            this.btn3A.BackgroundImage = global::Portaria.Properties.Resources.building_512;
            resources.ApplyResources(this.btn3A, "btn3A");
            this.btn3A.Name = "btn3A";
            this.btn3A.UseVisualStyleBackColor = true;
            this.btn3A.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn4A);
            this.groupBox4.Controls.Add(this.btn4B);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // btn4A
            // 
            this.btn4A.BackgroundImage = global::Portaria.Properties.Resources.building_512;
            resources.ApplyResources(this.btn4A, "btn4A");
            this.btn4A.Name = "btn4A";
            this.btn4A.UseVisualStyleBackColor = true;
            this.btn4A.Click += new System.EventHandler(this.button9_Click);
            // 
            // btn4B
            // 
            this.btn4B.BackgroundImage = global::Portaria.Properties.Resources.building_512;
            resources.ApplyResources(this.btn4B, "btn4B");
            this.btn4B.Name = "btn4B";
            this.btn4B.UseVisualStyleBackColor = true;
            this.btn4B.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn5B);
            this.groupBox5.Controls.Add(this.btn5A);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // btn5B
            // 
            this.btn5B.BackgroundImage = global::Portaria.Properties.Resources.building_512;
            resources.ApplyResources(this.btn5B, "btn5B");
            this.btn5B.Name = "btn5B";
            this.btn5B.UseVisualStyleBackColor = true;
            this.btn5B.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn5A
            // 
            this.btn5A.BackgroundImage = global::Portaria.Properties.Resources.building_512;
            resources.ApplyResources(this.btn5A, "btn5A");
            this.btn5A.Name = "btn5A";
            this.btn5A.UseVisualStyleBackColor = true;
            this.btn5A.Click += new System.EventHandler(this.button7_Click);
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
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            resources.ApplyResources(this.relatórioToolStripMenuItem, "relatórioToolStripMenuItem");
            this.relatórioToolStripMenuItem.Click += new System.EventHandler(this.relatórioToolStripMenuItem_Click);
            // 
            // mainMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainMenu";
            this.Load += new System.EventHandler(this.mainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portariaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moradorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btn1A;
        private System.Windows.Forms.Button btn1B;
        private System.Windows.Forms.Button btn2A;
        private System.Windows.Forms.Button btn2B;
        private System.Windows.Forms.Button btn3A;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn5B;
        private System.Windows.Forms.Button btn5A;
        private System.Windows.Forms.Button btn4B;
        private System.Windows.Forms.Button btn4A;
        private System.Windows.Forms.Button btn3B;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moradoresToolStripMenuItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ToolStripMenuItem moradorToolStripMenuItem1;
        private PortariaDBDataSet portariaDBDataSet;
        private System.Windows.Forms.BindingSource moradorBindingSource;
        private PortariaDBDataSetTableAdapters.MoradorTableAdapter moradorTableAdapter;
        private PortariaDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
    }
}