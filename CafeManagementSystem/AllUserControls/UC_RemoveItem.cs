﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem.AllUserControls
{
    public partial class UC_RemoveItem : UserControl
    {
        function fn = new function();
        String query;
        public UC_RemoveItem()
        {
            InitializeComponent();
        }

        private void UC_RemoveItem_Load(object sender, EventArgs e)
        {
            DelLabel.Text = "How to Delete?";
            DelLabel.ForeColor = Color.Indigo;
            loadData();
        }
        public void loadData()
        {
            query = "select * from items";
            DataSet ds = fn.getData(query);
            gunaDataGridView1.DataSource = ds.Tables[0];

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where name like '" + txtSearch + "%'";
            DataSet ds = fn.getData(query);
            gunaDataGridView1.DataSource = ds.Tables[0];
        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(
                MessageBox.Show("Delete item?","Important Message",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
                    {
                int id = int.Parse(gunaDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from items where id = " + id + "";
                fn.setData(query);
                loadData();
            }
}

        private void DelLabel_Click(object sender, EventArgs e)
        {
            DelLabel.ForeColor = Color.Red;
            DelLabel.Text = "Click on Row to Delete the Item. ";
        }

        private void UC_RemoveItem_Enter(object sender, EventArgs e)
        {
            loadData();
        }
    }
    }

