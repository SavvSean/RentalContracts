namespace PrototypeRent.UserControls
{
    partial class MenuPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPanel));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HouseRules = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contractDBHistory = new PrototypeRent.ContractDBHistory();
            this.contractsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractsTableTableAdapter = new PrototypeRent.ContractDBHistoryTableAdapters.ContractsTableTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insertedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isTerminatedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.HouseRules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDBHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Location = new System.Drawing.Point(661, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Records";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label2.Location = new System.Drawing.Point(126, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "House Rules";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // HouseRules
            // 
            this.HouseRules.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HouseRules.BackgroundImage")));
            this.HouseRules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HouseRules.Location = new System.Drawing.Point(132, 137);
            this.HouseRules.Name = "HouseRules";
            this.HouseRules.Size = new System.Drawing.Size(678, 370);
            this.HouseRules.TabIndex = 2;
            this.HouseRules.TabStop = false;
            this.HouseRules.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.contactNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.buildingNumberDataGridViewTextBoxColumn,
            this.roomNumberDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.pendingDataGridViewTextBoxColumn,
            this.insertedDateDataGridViewTextBoxColumn,
            this.isTerminatedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.contractsTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(132, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(696, 385);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Visible = false;
            // 
            // contractDBHistory
            // 
            this.contractDBHistory.DataSetName = "ContractDBHistory";
            this.contractDBHistory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contractsTableBindingSource
            // 
            this.contractsTableBindingSource.DataMember = "ContractsTable";
            this.contractsTableBindingSource.DataSource = this.contractDBHistory;
            // 
            // contractsTableTableAdapter
            // 
            this.contractsTableTableAdapter.ClearBeforeFill = true;
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
            // insertedDateDataGridViewTextBoxColumn
            // 
            this.insertedDateDataGridViewTextBoxColumn.DataPropertyName = "InsertedDate";
            this.insertedDateDataGridViewTextBoxColumn.HeaderText = "InsertedDate";
            this.insertedDateDataGridViewTextBoxColumn.Name = "insertedDateDataGridViewTextBoxColumn";
            // 
            // isTerminatedDataGridViewCheckBoxColumn
            // 
            this.isTerminatedDataGridViewCheckBoxColumn.DataPropertyName = "IsTerminated";
            this.isTerminatedDataGridViewCheckBoxColumn.HeaderText = "IsTerminated";
            this.isTerminatedDataGridViewCheckBoxColumn.Name = "isTerminatedDataGridViewCheckBoxColumn";
            // 
            // MenuPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.HouseRules);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "MenuPanel";
            this.Size = new System.Drawing.Size(943, 590);
            this.Load += new System.EventHandler(this.MenuPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HouseRules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDBHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox HouseRules;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pendingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insertedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isTerminatedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource contractsTableBindingSource;
        private ContractDBHistory contractDBHistory;
        private ContractDBHistoryTableAdapters.ContractsTableTableAdapter contractsTableTableAdapter;
    }
}
