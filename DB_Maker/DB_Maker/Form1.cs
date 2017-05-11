using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "busherDataSet.ClientView". При необходимости она может быть перемещена или удалена.
            this.clientViewTableAdapter.Fill(this.busherDataSet.ClientView);
        }

        private void button_InsertClient_Click(object sender, EventArgs e)
        {
            //TODO: а вернет ли 1 код ошибки?
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

            foreach (TextBox t in new TextBox[] { textBox_ID, textBox_FIO, textBox_Firm, textBox_Town, textBox_Phone })//int cnt = 0;
                t.Text = dataGridView_Client.Rows[dataGridView_Client.CurrentRow.Index].Cells[/*cnt++*/t.TabIndex - 4].Value.ToString().Trim();
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
    }
}
