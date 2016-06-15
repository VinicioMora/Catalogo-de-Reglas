namespace Catalogo_de_reglas
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.catalogoDataSet = new Catalogo_de_reglas.catalogoDataSet();
            this.catalogoCompletoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catalogoCompletoTableAdapter = new Catalogo_de_reglas.catalogoDataSetTableAdapters.catalogoCompletoTableAdapter();
            this.nOMBREREGLADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDREGLADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPCIONFORMALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPCIONINFORMALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREGRUPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREENTIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREATRIBUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoCompletoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nOMBREREGLADataGridViewTextBoxColumn,
            this.iDREGLADataGridViewTextBoxColumn,
            this.dESCRIPCIONFORMALDataGridViewTextBoxColumn,
            this.dESCRIPCIONINFORMALDataGridViewTextBoxColumn,
            this.nOMBREGRUPODataGridViewTextBoxColumn,
            this.nOMBREENTIDADDataGridViewTextBoxColumn,
            this.nOMBREATRIBUTODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.catalogoCompletoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(735, 406);
            this.dataGridView1.TabIndex = 0;
            // 
            // catalogoDataSet
            // 
            this.catalogoDataSet.DataSetName = "catalogoDataSet";
            this.catalogoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // catalogoCompletoBindingSource
            // 
            this.catalogoCompletoBindingSource.DataMember = "catalogoCompleto";
            this.catalogoCompletoBindingSource.DataSource = this.catalogoDataSet;
            // 
            // catalogoCompletoTableAdapter
            // 
            this.catalogoCompletoTableAdapter.ClearBeforeFill = true;
            // 
            // nOMBREREGLADataGridViewTextBoxColumn
            // 
            this.nOMBREREGLADataGridViewTextBoxColumn.DataPropertyName = "NOMBREREGLA";
            this.nOMBREREGLADataGridViewTextBoxColumn.HeaderText = "NOMBREREGLA";
            this.nOMBREREGLADataGridViewTextBoxColumn.Name = "nOMBREREGLADataGridViewTextBoxColumn";
            this.nOMBREREGLADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDREGLADataGridViewTextBoxColumn
            // 
            this.iDREGLADataGridViewTextBoxColumn.DataPropertyName = "IDREGLA";
            this.iDREGLADataGridViewTextBoxColumn.HeaderText = "IDREGLA";
            this.iDREGLADataGridViewTextBoxColumn.Name = "iDREGLADataGridViewTextBoxColumn";
            this.iDREGLADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESCRIPCIONFORMALDataGridViewTextBoxColumn
            // 
            this.dESCRIPCIONFORMALDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCIONFORMAL";
            this.dESCRIPCIONFORMALDataGridViewTextBoxColumn.HeaderText = "DESCRIPCIONFORMAL";
            this.dESCRIPCIONFORMALDataGridViewTextBoxColumn.Name = "dESCRIPCIONFORMALDataGridViewTextBoxColumn";
            this.dESCRIPCIONFORMALDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESCRIPCIONINFORMALDataGridViewTextBoxColumn
            // 
            this.dESCRIPCIONINFORMALDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCIONINFORMAL";
            this.dESCRIPCIONINFORMALDataGridViewTextBoxColumn.HeaderText = "DESCRIPCIONINFORMAL";
            this.dESCRIPCIONINFORMALDataGridViewTextBoxColumn.Name = "dESCRIPCIONINFORMALDataGridViewTextBoxColumn";
            this.dESCRIPCIONINFORMALDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBREGRUPODataGridViewTextBoxColumn
            // 
            this.nOMBREGRUPODataGridViewTextBoxColumn.DataPropertyName = "NOMBREGRUPO";
            this.nOMBREGRUPODataGridViewTextBoxColumn.HeaderText = "NOMBREGRUPO";
            this.nOMBREGRUPODataGridViewTextBoxColumn.Name = "nOMBREGRUPODataGridViewTextBoxColumn";
            this.nOMBREGRUPODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBREENTIDADDataGridViewTextBoxColumn
            // 
            this.nOMBREENTIDADDataGridViewTextBoxColumn.DataPropertyName = "NOMBREENTIDAD";
            this.nOMBREENTIDADDataGridViewTextBoxColumn.HeaderText = "NOMBREENTIDAD";
            this.nOMBREENTIDADDataGridViewTextBoxColumn.Name = "nOMBREENTIDADDataGridViewTextBoxColumn";
            this.nOMBREENTIDADDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBREATRIBUTODataGridViewTextBoxColumn
            // 
            this.nOMBREATRIBUTODataGridViewTextBoxColumn.DataPropertyName = "NOMBREATRIBUTO";
            this.nOMBREATRIBUTODataGridViewTextBoxColumn.HeaderText = "NOMBREATRIBUTO";
            this.nOMBREATRIBUTODataGridViewTextBoxColumn.Name = "nOMBREATRIBUTODataGridViewTextBoxColumn";
            this.nOMBREATRIBUTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 406);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoCompletoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private catalogoDataSet catalogoDataSet;
        private System.Windows.Forms.BindingSource catalogoCompletoBindingSource;
        private catalogoDataSetTableAdapters.catalogoCompletoTableAdapter catalogoCompletoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREREGLADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDREGLADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPCIONFORMALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPCIONINFORMALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREGRUPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREENTIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREATRIBUTODataGridViewTextBoxColumn;
    }
}