namespace DB_Maker
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView_Client = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фирмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.городDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.busherDataSet = new DB_Maker.BusherDataSet();
            this.button_InsertClient = new System.Windows.Forms.Button();
            this.button_DeleteClient = new System.Windows.Forms.Button();
            this.button_UpdateClient = new System.Windows.Forms.Button();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_FIO = new System.Windows.Forms.TextBox();
            this.textBox_Firm = new System.Windows.Forms.TextBox();
            this.textBox_Town = new System.Windows.Forms.TextBox();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clientViewTableAdapter = new DB_Maker.BusherDataSetTableAdapters.ClientViewTableAdapter();
            this.queriesTableAdapter_Client = new DB_Maker.BusherDataSetTableAdapters.QueriesTableAdapter();
            this.button_find = new System.Windows.Forms.Button();
            this.button_rest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busherDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Client
            // 
            this.dataGridView_Client.AllowUserToAddRows = false;
            this.dataGridView_Client.AllowUserToDeleteRows = false;
            this.dataGridView_Client.AutoGenerateColumns = false;
            this.dataGridView_Client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Client.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.фирмаDataGridViewTextBoxColumn,
            this.городDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn});
            this.dataGridView_Client.DataSource = this.clientViewBindingSource;
            this.dataGridView_Client.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Client.MultiSelect = false;
            this.dataGridView_Client.Name = "dataGridView_Client";
            this.dataGridView_Client.ReadOnly = true;
            this.dataGridView_Client.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Client.Size = new System.Drawing.Size(663, 428);
            this.dataGridView_Client.TabIndex = 0;
            this.dataGridView_Client.SelectionChanged += new System.EventHandler(this.dataGridView_Client_SelectionChanged);
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фирмаDataGridViewTextBoxColumn
            // 
            this.фирмаDataGridViewTextBoxColumn.DataPropertyName = "Фирма";
            this.фирмаDataGridViewTextBoxColumn.HeaderText = "Фирма";
            this.фирмаDataGridViewTextBoxColumn.Name = "фирмаDataGridViewTextBoxColumn";
            this.фирмаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // городDataGridViewTextBoxColumn
            // 
            this.городDataGridViewTextBoxColumn.DataPropertyName = "Город";
            this.городDataGridViewTextBoxColumn.HeaderText = "Город";
            this.городDataGridViewTextBoxColumn.Name = "городDataGridViewTextBoxColumn";
            this.городDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientViewBindingSource
            // 
            this.clientViewBindingSource.DataMember = "ClientView";
            this.clientViewBindingSource.DataSource = this.busherDataSet;
            // 
            // busherDataSet
            // 
            this.busherDataSet.DataSetName = "BusherDataSet";
            this.busherDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button_InsertClient
            // 
            this.button_InsertClient.Location = new System.Drawing.Point(12, 446);
            this.button_InsertClient.Name = "button_InsertClient";
            this.button_InsertClient.Size = new System.Drawing.Size(75, 23);
            this.button_InsertClient.TabIndex = 1;
            this.button_InsertClient.Text = "Insert";
            this.button_InsertClient.UseVisualStyleBackColor = true;
            this.button_InsertClient.Click += new System.EventHandler(this.button_InsertClient_Click);
            // 
            // button_DeleteClient
            // 
            this.button_DeleteClient.Location = new System.Drawing.Point(12, 504);
            this.button_DeleteClient.Name = "button_DeleteClient";
            this.button_DeleteClient.Size = new System.Drawing.Size(75, 23);
            this.button_DeleteClient.TabIndex = 2;
            this.button_DeleteClient.Text = "Delete";
            this.button_DeleteClient.UseVisualStyleBackColor = true;
            this.button_DeleteClient.Click += new System.EventHandler(this.button_DeleteClient_Click);
            // 
            // button_UpdateClient
            // 
            this.button_UpdateClient.Location = new System.Drawing.Point(12, 475);
            this.button_UpdateClient.Name = "button_UpdateClient";
            this.button_UpdateClient.Size = new System.Drawing.Size(75, 23);
            this.button_UpdateClient.TabIndex = 3;
            this.button_UpdateClient.Text = "Update";
            this.button_UpdateClient.UseVisualStyleBackColor = true;
            this.button_UpdateClient.Click += new System.EventHandler(this.button_UpdateClient_Click);
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(93, 475);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(100, 20);
            this.textBox_ID.TabIndex = 4;
            // 
            // textBox_FIO
            // 
            this.textBox_FIO.Location = new System.Drawing.Point(199, 475);
            this.textBox_FIO.Name = "textBox_FIO";
            this.textBox_FIO.Size = new System.Drawing.Size(100, 20);
            this.textBox_FIO.TabIndex = 5;
            // 
            // textBox_Firm
            // 
            this.textBox_Firm.Location = new System.Drawing.Point(305, 475);
            this.textBox_Firm.Name = "textBox_Firm";
            this.textBox_Firm.Size = new System.Drawing.Size(100, 20);
            this.textBox_Firm.TabIndex = 6;
            // 
            // textBox_Town
            // 
            this.textBox_Town.Location = new System.Drawing.Point(411, 475);
            this.textBox_Town.Name = "textBox_Town";
            this.textBox_Town.Size = new System.Drawing.Size(100, 20);
            this.textBox_Town.TabIndex = 7;
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(517, 475);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(158, 20);
            this.textBox_Phone.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Код:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ФИО:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Фирма:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Город:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(514, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Телефон:";
            // 
            // clientViewTableAdapter
            // 
            this.clientViewTableAdapter.ClearBeforeFill = true;
            // 
            // button_find
            // 
            this.button_find.Location = new System.Drawing.Point(199, 501);
            this.button_find.Name = "button_find";
            this.button_find.Size = new System.Drawing.Size(75, 23);
            this.button_find.TabIndex = 14;
            this.button_find.Text = "Find";
            this.button_find.UseVisualStyleBackColor = true;
            this.button_find.Click += new System.EventHandler(this.button_find_Click);
            // 
            // button_rest
            // 
            this.button_rest.Location = new System.Drawing.Point(305, 504);
            this.button_rest.Name = "button_rest";
            this.button_rest.Size = new System.Drawing.Size(75, 23);
            this.button_rest.TabIndex = 15;
            this.button_rest.Text = "Rest";
            this.button_rest.UseVisualStyleBackColor = true;
            this.button_rest.Click += new System.EventHandler(this.button_rest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 535);
            this.Controls.Add(this.button_rest);
            this.Controls.Add(this.button_find);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Phone);
            this.Controls.Add(this.textBox_Town);
            this.Controls.Add(this.textBox_Firm);
            this.Controls.Add(this.textBox_FIO);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.button_UpdateClient);
            this.Controls.Add(this.button_DeleteClient);
            this.Controls.Add(this.button_InsertClient);
            this.Controls.Add(this.dataGridView_Client);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busherDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Client;
        private BusherDataSet busherDataSet;
        private System.Windows.Forms.BindingSource clientViewBindingSource;
        private BusherDataSetTableAdapters.ClientViewTableAdapter clientViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фирмаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn городDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_InsertClient;
        private System.Windows.Forms.Button button_DeleteClient;
        private System.Windows.Forms.Button button_UpdateClient;
        private BusherDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter_Client;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_FIO;
        private System.Windows.Forms.TextBox textBox_Firm;
        private System.Windows.Forms.TextBox textBox_Town;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_find;
        private System.Windows.Forms.Button button_rest;
    }
}

