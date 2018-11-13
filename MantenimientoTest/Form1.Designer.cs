namespace MantenimientoTest
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMant_table = new System.Windows.Forms.DataGridView();
            this.CodeTypeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.sdsTextBox3 = new MantenimientoTest.SdsTextBox();
            this.sdsTextBox2 = new MantenimientoTest.SdsTextBox();
            this.sdsTextBox1 = new MantenimientoTest.SdsTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMant_table)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMant_table
            // 
            this.dgvMant_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMant_table.Location = new System.Drawing.Point(314, 160);
            this.dgvMant_table.Name = "dgvMant_table";
            this.dgvMant_table.Size = new System.Drawing.Size(406, 278);
            this.dgvMant_table.TabIndex = 0;
            // 
            // CodeTypeLabel
            // 
            this.CodeTypeLabel.AutoSize = true;
            this.CodeTypeLabel.Location = new System.Drawing.Point(56, 124);
            this.CodeTypeLabel.Name = "CodeTypeLabel";
            this.CodeTypeLabel.Size = new System.Drawing.Size(56, 13);
            this.CodeTypeLabel.TabIndex = 4;
            this.CodeTypeLabel.Text = "CodeType";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "DescType";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "LevelAcces";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Añadir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(138, 378);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // sdsTextBox3
            // 
            this.sdsTextBox3.ColumnName = "LevelAcces";
            this.sdsTextBox3.Location = new System.Drawing.Point(56, 243);
            this.sdsTextBox3.Name = "sdsTextBox3";
            this.sdsTextBox3.Nom = "";
            this.sdsTextBox3.Size = new System.Drawing.Size(100, 20);
            this.sdsTextBox3.TabIndex = 3;
            // 
            // sdsTextBox2
            // 
            this.sdsTextBox2.ColumnName = "DescType";
            this.sdsTextBox2.Location = new System.Drawing.Point(56, 192);
            this.sdsTextBox2.Name = "sdsTextBox2";
            this.sdsTextBox2.Nom = "";
            this.sdsTextBox2.Size = new System.Drawing.Size(100, 20);
            this.sdsTextBox2.TabIndex = 2;
            // 
            // sdsTextBox1
            // 
            this.sdsTextBox1.ColumnName = "CodeType";
            this.sdsTextBox1.Location = new System.Drawing.Point(56, 143);
            this.sdsTextBox1.Name = "sdsTextBox1";
            this.sdsTextBox1.Nom = "";
            this.sdsTextBox1.Size = new System.Drawing.Size(100, 20);
            this.sdsTextBox1.TabIndex = 1;
            this.sdsTextBox1.Tag = "CodeType";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CodeTypeLabel);
            this.Controls.Add(this.sdsTextBox3);
            this.Controls.Add(this.sdsTextBox2);
            this.Controls.Add(this.sdsTextBox1);
            this.Controls.Add(this.dgvMant_table);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMant_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMant_table;
        private SdsTextBox sdsTextBox1;
        private SdsTextBox sdsTextBox2;
        private SdsTextBox sdsTextBox3;
        private System.Windows.Forms.Label CodeTypeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnModificar;
    }
}

