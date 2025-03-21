﻿namespace PrototypeRent.UserControls
{
    partial class RenewPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenewPanel));
            this.contractDBDataSet = new PrototypeRent.ContractDBDataSet();
            this.contractDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractDBDataSet3 = new PrototypeRent.ContractDBDataSet3();
            this.contractDBDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractsTableTableAdapter = new PrototypeRent.ContractDBDataSet3TableAdapters.ContractsTableTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractsTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.contractDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDBDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsTableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // contractDBDataSet
            // 
            this.contractDBDataSet.DataSetName = "ContractDBDataSet";
            this.contractDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contractDBDataSetBindingSource
            // 
            this.contractDBDataSetBindingSource.DataSource = this.contractDBDataSet;
            this.contractDBDataSetBindingSource.Position = 0;
            // 
            // contractDBDataSet3
            // 
            this.contractDBDataSet3.DataSetName = "ContractDBDataSet3";
            this.contractDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contractDBDataSet3BindingSource
            // 
            this.contractDBDataSet3BindingSource.DataSource = this.contractDBDataSet3;
            this.contractDBDataSet3BindingSource.Position = 0;
            // 
            // contractsTableBindingSource
            // 
            this.contractsTableBindingSource.DataMember = "ContractsTable";
            this.contractsTableBindingSource.DataSource = this.contractDBDataSet3BindingSource;
            // 
            // contractsTableTableAdapter
            // 
            this.contractsTableTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.contactNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.buildingNumberDataGridViewTextBoxColumn,
            this.roomNumberDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.pendingDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contractsTableBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.Red;
            this.dataGridView1.Location = new System.Drawing.Point(79, 124);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(802, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            this.contactNumberDataGridViewTextBoxColumn.DataPropertyName = "Contact_Number";
            this.contactNumberDataGridViewTextBoxColumn.HeaderText = "Contact_Number";
            this.contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // buildingNumberDataGridViewTextBoxColumn
            // 
            this.buildingNumberDataGridViewTextBoxColumn.DataPropertyName = "Building_Number";
            this.buildingNumberDataGridViewTextBoxColumn.HeaderText = "Building_Number";
            this.buildingNumberDataGridViewTextBoxColumn.Name = "buildingNumberDataGridViewTextBoxColumn";
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "Room_Number";
            this.roomNumberDataGridViewTextBoxColumn.HeaderText = "Room_Number";
            this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // pendingDataGridViewTextBoxColumn
            // 
            this.pendingDataGridViewTextBoxColumn.DataPropertyName = "Pending";
            this.pendingDataGridViewTextBoxColumn.HeaderText = "Pending";
            this.pendingDataGridViewTextBoxColumn.Name = "pendingDataGridViewTextBoxColumn";
            // 
            // contractsTableBindingSource1
            // 
            this.contractsTableBindingSource1.DataMember = "ContractsTable";
            this.contractsTableBindingSource1.DataSource = this.contractDBDataSet3BindingSource;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(534, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Paid";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(702, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Unpaid";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RenewPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RenewPanel";
            this.Size = new System.Drawing.Size(943, 590);
            this.Load += new System.EventHandler(this.RenewPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contractDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDBDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsTableBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource contractDBDataSetBindingSource;
        private ContractDBDataSet contractDBDataSet;
        private System.Windows.Forms.BindingSource contractsTableBindingSource;
        private System.Windows.Forms.BindingSource contractDBDataSet3BindingSource;
        private ContractDBDataSet3 contractDBDataSet3;
        private ContractDBDataSet3TableAdapters.ContractsTableTableAdapter contractsTableTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pendingDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource contractsTableBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
