namespace DataBaseKomut
{
    partial class Form1
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
            this.ürünAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.müşteriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proje6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hareketsDataSet = new DataBaseKomut.HareketsDataSet();
            this.proje6TableAdapter = new DataBaseKomut.HareketsDataSetTableAdapters.Proje6TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hareketsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ürünAdDataGridViewTextBoxColumn,
            this.müşteriDataGridViewTextBoxColumn,
            this.personelDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.proje6BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(623, 346);
            this.dataGridView1.TabIndex = 0;
            // 
            // ürünAdDataGridViewTextBoxColumn
            // 
            this.ürünAdDataGridViewTextBoxColumn.DataPropertyName = "Ürün Ad";
            this.ürünAdDataGridViewTextBoxColumn.HeaderText = "Ürün Ad";
            this.ürünAdDataGridViewTextBoxColumn.Name = "ürünAdDataGridViewTextBoxColumn";
            // 
            // müşteriDataGridViewTextBoxColumn
            // 
            this.müşteriDataGridViewTextBoxColumn.DataPropertyName = "Müşteri";
            this.müşteriDataGridViewTextBoxColumn.HeaderText = "Müşteri";
            this.müşteriDataGridViewTextBoxColumn.Name = "müşteriDataGridViewTextBoxColumn";
            // 
            // personelDataGridViewTextBoxColumn
            // 
            this.personelDataGridViewTextBoxColumn.DataPropertyName = "Personel";
            this.personelDataGridViewTextBoxColumn.HeaderText = "Personel";
            this.personelDataGridViewTextBoxColumn.Name = "personelDataGridViewTextBoxColumn";
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = " Fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = " Fiyat";
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            // 
            // proje6BindingSource
            // 
            this.proje6BindingSource.DataMember = "Proje6";
            this.proje6BindingSource.DataSource = this.hareketsDataSet;
            // 
            // hareketsDataSet
            // 
            this.hareketsDataSet.DataSetName = "HareketsDataSet";
            this.hareketsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proje6TableAdapter
            // 
            this.proje6TableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 346);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hareketsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HareketsDataSet hareketsDataSet;
        private System.Windows.Forms.BindingSource proje6BindingSource;
        private HareketsDataSetTableAdapters.Proje6TableAdapter proje6TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn müşteriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
    }
}

