using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDBTestApp
{
    public partial class FrmMongoDBTest : Form
    {
        MongoClient m_dbClient;
        IMongoDatabase m_SelectedDatabase;

        public FrmMongoDBTest()
        {
            InitializeComponent();
        }

        private void showExceptonMessage(Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            string _connectionString = "mongodb://";
            if (!String.IsNullOrWhiteSpace(txtUserName.Text.Trim()))
                _connectionString += (txtUserName.Text.Trim() + ":" + txtPassword.Text + "@");

            _connectionString += txtServer.Text + ":" + ((int)numPort.Value);

            m_dbClient = new MongoClient(_connectionString);
        }

        private void btnListDatabases_Click(object sender, EventArgs e)
        {
            lbxDatabases.Items.Clear();

            try
            {
                lbxDatabases.DataSource = m_dbClient.ListDatabaseNames().ToList();
            }
            catch (Exception ex)
            {
                showExceptonMessage(ex);
            }
        }

        private void lbxDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxDatabases.SelectedItem != null)
            {
                txtDbName.Text = (string)lbxDatabases.SelectedItem;
            }
        }

        private void btnGetDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                m_SelectedDatabase = m_dbClient.GetDatabase(txtDbName.Text);
            }
            catch (Exception ex)
            {
                showExceptonMessage(ex);
            }
        }

        private void btnListCollections_Click(object sender, EventArgs e)
        {
            lbxCollections.Items.Clear();
            try
            {
                lbxCollections.DataSource = m_SelectedDatabase.ListCollectionNames().ToList();
            }
            catch (Exception ex)
            {
                showExceptonMessage(ex);
            }
        }

        private void lbxCollections_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbxCollections.SelectedItem != null)
            {
                txtCollectionName.Text = (string)lbxCollections.SelectedItem;
            }
        }
    }
}
