using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace QBuild
{
    public partial class Form1 : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Myconnectionstring"].ConnectionString.ToString();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
        }

        public void DataLoad(string str)
        {
            SqlCommand cmdString = new SqlCommand(@"SELECT PARENT_NAME, COMPONENT_NAME, PART_NUMBER, TITLE, QUANTITY, TYPE, ITEM, MATERIAL FROM bom FULL OUTER JOIN part ON bom.COMPONENT_NAME = part.NAME WHERE PARENT_NAME = @str;");
            cmdString.Parameters.AddWithValue("str", str);
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                cmdString.Connection = conn;
                SqlDataAdapter sqlData = new SqlDataAdapter(cmdString); 
                DataSet ds = new DataSet();
                sqlData.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }            
        }

        private void populateDataButton_Click(object sender, EventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["Myconnectionstring"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                SqlCommand cmdString = new SqlCommand("SELECT * FROM bom;");
                SqlDataAdapter sqlData = new SqlDataAdapter(cmdString.CommandText, conn);
                DataSet ds = new DataSet();
                sqlData.Fill(ds);
                
                DataRow lastRow = ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1];
                TreeNode firstNode = new TreeNode();
                firstNode.Text = lastRow["COMPONENT_NAME"].ToString();
                firstNode.Name = lastRow["COMPONENT_NAME"].ToString();
                dataTreeView.Nodes.Add(firstNode);
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                  
                    if (dataTreeView.Nodes.Find(row["PARENT_NAME"].ToString(), true).Length > 0)
                    {
                        TreeNode node = new TreeNode();
                        node.Name = row["COMPONENT_NAME"].ToString();
                        node.Text = row["COMPONENT_NAME"].ToString();
                        //SetChildNode(row, parentNode);
                        dataTreeView.Nodes.Find(row["PARENT_NAME"].ToString(), true)[0].Nodes.Add(node);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            populateDataButton.Enabled = false;
            
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DataLoad(dataTreeView.SelectedNode.Text.ToString());
            CurrentNodeLabel.Text = dataTreeView.SelectedNode.Text.ToString();
            FullPathLabel.Text = dataTreeView.SelectedNode.FullPath.ToString();
        }
    }
}
