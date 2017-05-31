using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DB_Maker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.clientViewTableAdapter.Fill(this.busherDataSet.ClientView);
            dataGridView_Client.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button_InsertClient_Click(object sender, EventArgs e)
        {
            if (queriesTableAdapter_Client.ClientInsert(textBox_FIO.Text, textBox_Firm.Text, textBox_Town.Text, textBox_Phone.Text) != 1)
                MessageBox.Show("Ошибка вставки!");
            clientViewTableAdapter.Fill(this.busherDataSet.ClientView);
        }

        private void button_UpdateClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (queriesTableAdapter_Client.ClientUpdate(int.Parse(textBox_ID.Text), textBox_FIO.Text, textBox_Firm.Text, textBox_Town.Text, textBox_Phone.Text) != 1)
                    throw new ArgumentException("Ошибка обновления!");
                clientViewTableAdapter.Fill(this.busherDataSet.ClientView);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_Client_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_Client.Rows.Count == 0)
                return;

            foreach (TextBox t in new TextBox[] { textBox_ID, textBox_FIO, textBox_Firm, textBox_Town, textBox_Phone })
                t.Text = dataGridView_Client.Rows[dataGridView_Client.CurrentRow.Index].Cells[t.TabIndex - 4].Value.ToString().Trim();
        }

        private void button_DeleteClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (queriesTableAdapter_Client.ClientDelete(int.Parse(textBox_ID.Text)) != 1)
                    throw new ArgumentException("Ошибка удаления!");
                clientViewTableAdapter.Fill(this.busherDataSet.ClientView);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_find_Click(object sender, EventArgs e)
        {
            foreach (Button bt in new Button[] { button_UpdateClient, button_DeleteClient, button_InsertClient })
                bt.Enabled = false;

            dataGridView_Client.SelectionChanged -= dataGridView_Client_SelectionChanged;
            dataGridView_Client.DataSource = null;
            dataGridView_Client.Rows.Clear();
            dataGridView_Client.SelectionChanged += dataGridView_Client_SelectionChanged;

            try
            {
                using (var sqlConn = new SqlConnection(Properties.Settings.Default.BusherConnectionString))
                {
                    var sqlCmd = new SqlCommand("sampleSelect", sqlConn) { CommandType = CommandType.StoredProcedure };
                    sqlCmd.Parameters.AddWithValue("@fio", textBox_FIO.Text);
                    sqlConn.Open();

                    using (SqlDataReader dr = sqlCmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            object[] obj = new object[dr.FieldCount];
                            dr.GetValues(obj);
                            dataGridView_Client.Rows.Add(obj);
                        }

                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_rest_Click(object sender, EventArgs e)
        {
            dataGridView_Client.DataSource = busherDataSet.ClientView;
            foreach (Button bt in new Button[] { button_UpdateClient, button_DeleteClient, button_InsertClient })
                bt.Enabled = true;
        }
    }
}