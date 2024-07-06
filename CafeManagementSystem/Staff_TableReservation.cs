﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class Staff_TableReservation : Form
    {
        private function fn = new function();
        private string query;
        private DataSet ds;
        int id;
        public Staff_TableReservation()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Staff_TableReservation_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadURTables();
        }
        private void LoadCustomers()
        {
            query = "\r\n\tSELECT r.reservationID,\r\n    CONCAT(c.firstname, ' ', c.lastname) AS Customer_Name,\r\n    t.tableID,\r\n    t.Location,\r\n    CONVERT(DATE, r.reservationDate) AS Reservation_Date,\r\n    CAST(r.reservationTime AS TIME) AS Reservation_Time\r\nFROM \r\n    Reservation r\r\nJOIN \r\n    Customer c ON r.customerID = c.customerID\r\nJOIN \r\n    [Table] t ON r.tableID = t.tableID;\r\n";
            ds = fn.getData(query);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No records found.");
            }
        }

        private void LoadURTables()
        {
            query = "\r\n\r\n\tSELECT *\r\nFROM [Table]\r\nWHERE status != 'Reserved';";

            ds = fn.getData(query);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dataGridView2.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No records found.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FilterCustomers();
        }
        private void FilterCustomers()
        {
            if (!string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                string filterExpression = $"tableID = {textBox1.Text.Trim()}";
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = filterExpression;
                dataGridView1.DataSource = dv;
            }
            else
            {
                // If the text box is empty, load all customers
                LoadCustomers();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FilterURTable()
        {
            if (!string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                string filterExpression = $"tableID = {textBox1.Text.Trim()}";
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = filterExpression;
                dataGridView1.DataSource = dv;
            }
            else
            {
                // If the text box is empty, load all customers
                LoadCustomers();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            FilterURTable();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_Dashboard staff_Dashboard = new Staff_Dashboard();
            staff_Dashboard.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_AddItem staff_AddItem = new Staff_AddItem();
            staff_AddItem.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_UpdateItem staff_UpdateItem=new Staff_UpdateItem();
            staff_UpdateItem.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_DeleteItem staff_DeleteItem = new Staff_DeleteItem();
            staff_DeleteItem.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_HandleOrder staff_HandleOrder = new Staff_HandleOrder();
            staff_HandleOrder.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_Handle_Feedback staff_HandleFeedback = new Staff_Handle_Feedback();
            staff_HandleFeedback.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_CustomerTrends staff_CustomerTrends = new Staff_CustomerTrends();
            staff_CustomerTrends.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_ItemTrends staff_ItemTrends = new Staff_ItemTrends();
            staff_ItemTrends.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            this.Hide();
            Staff_LoginForm staff_LoginForm = new Staff_LoginForm();
            staff_LoginForm.Show();
        }
    }
}
