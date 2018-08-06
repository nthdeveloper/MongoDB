namespace MongoDBTestApp
{
    partial class FrmMongoDBTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.btnCreateClient = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGetDatabase = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDbName = new System.Windows.Forms.TextBox();
            this.lbxDatabases = new System.Windows.Forms.ListBox();
            this.btnListDatabases = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnGetCollection = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCollectionName = new System.Windows.Forms.TextBox();
            this.lbxCollections = new System.Windows.Forms.ListBox();
            this.btnListCollections = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "User name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Server";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Port";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(103, 31);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(133, 21);
            this.txtServer.TabIndex = 4;
            this.txtServer.Text = "127.0.0.1";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(103, 86);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(133, 21);
            this.txtUserName.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(103, 113);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(133, 21);
            this.txtPassword.TabIndex = 6;
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(103, 58);
            this.numPort.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(133, 21);
            this.numPort.TabIndex = 7;
            this.numPort.Value = new decimal(new int[] {
            27017,
            0,
            0,
            0});
            // 
            // btnCreateClient
            // 
            this.btnCreateClient.Location = new System.Drawing.Point(103, 145);
            this.btnCreateClient.Name = "btnCreateClient";
            this.btnCreateClient.Size = new System.Drawing.Size(133, 28);
            this.btnCreateClient.TabIndex = 8;
            this.btnCreateClient.Text = "Create Client";
            this.btnCreateClient.UseVisualStyleBackColor = true;
            this.btnCreateClient.Click += new System.EventHandler(this.btnCreateClient_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnCreateClient);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.txtServer);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 186);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "(1) Connection";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.lbxDatabases);
            this.groupBox2.Controls.Add(this.btnListDatabases);
            this.groupBox2.Location = new System.Drawing.Point(12, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 321);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "(2) Database";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGetDatabase);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtDbName);
            this.groupBox3.Location = new System.Drawing.Point(5, 212);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 100);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Create or Get Database";
            // 
            // btnGetDatabase
            // 
            this.btnGetDatabase.Location = new System.Drawing.Point(7, 58);
            this.btnGetDatabase.Name = "btnGetDatabase";
            this.btnGetDatabase.Size = new System.Drawing.Size(224, 28);
            this.btnGetDatabase.TabIndex = 9;
            this.btnGetDatabase.Text = "Get / Create Database";
            this.btnGetDatabase.UseVisualStyleBackColor = true;
            this.btnGetDatabase.Click += new System.EventHandler(this.btnGetDatabase_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Db name";
            // 
            // txtDbName
            // 
            this.txtDbName.Location = new System.Drawing.Point(97, 27);
            this.txtDbName.Name = "txtDbName";
            this.txtDbName.Size = new System.Drawing.Size(133, 21);
            this.txtDbName.TabIndex = 7;
            // 
            // lbxDatabases
            // 
            this.lbxDatabases.FormattingEnabled = true;
            this.lbxDatabases.ItemHeight = 15;
            this.lbxDatabases.Location = new System.Drawing.Point(8, 63);
            this.lbxDatabases.Name = "lbxDatabases";
            this.lbxDatabases.Size = new System.Drawing.Size(228, 139);
            this.lbxDatabases.TabIndex = 10;
            this.lbxDatabases.SelectedIndexChanged += new System.EventHandler(this.lbxDatabases_SelectedIndexChanged);
            // 
            // btnListDatabases
            // 
            this.btnListDatabases.Location = new System.Drawing.Point(8, 29);
            this.btnListDatabases.Name = "btnListDatabases";
            this.btnListDatabases.Size = new System.Drawing.Size(228, 28);
            this.btnListDatabases.TabIndex = 9;
            this.btnListDatabases.Text = "List All Databases";
            this.btnListDatabases.UseVisualStyleBackColor = true;
            this.btnListDatabases.Click += new System.EventHandler(this.btnListDatabases_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.lbxCollections);
            this.groupBox4.Controls.Add(this.btnListCollections);
            this.groupBox4.Location = new System.Drawing.Point(266, 204);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(248, 321);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "(3) Collections";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnGetCollection);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txtCollectionName);
            this.groupBox5.Location = new System.Drawing.Point(5, 212);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(236, 100);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Create or Get Collection";
            // 
            // btnGetCollection
            // 
            this.btnGetCollection.Location = new System.Drawing.Point(7, 58);
            this.btnGetCollection.Name = "btnGetCollection";
            this.btnGetCollection.Size = new System.Drawing.Size(224, 28);
            this.btnGetCollection.TabIndex = 9;
            this.btnGetCollection.Text = "Get Collection";
            this.btnGetCollection.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Collection name";
            // 
            // txtCollectionName
            // 
            this.txtCollectionName.Location = new System.Drawing.Point(107, 27);
            this.txtCollectionName.Name = "txtCollectionName";
            this.txtCollectionName.Size = new System.Drawing.Size(123, 21);
            this.txtCollectionName.TabIndex = 7;
            // 
            // lbxCollections
            // 
            this.lbxCollections.FormattingEnabled = true;
            this.lbxCollections.ItemHeight = 15;
            this.lbxCollections.Location = new System.Drawing.Point(8, 63);
            this.lbxCollections.Name = "lbxCollections";
            this.lbxCollections.Size = new System.Drawing.Size(228, 139);
            this.lbxCollections.TabIndex = 10;
            this.lbxCollections.SelectedIndexChanged += new System.EventHandler(this.lbxCollections_SelectedIndexChanged);
            // 
            // btnListCollections
            // 
            this.btnListCollections.Location = new System.Drawing.Point(8, 29);
            this.btnListCollections.Name = "btnListCollections";
            this.btnListCollections.Size = new System.Drawing.Size(228, 28);
            this.btnListCollections.TabIndex = 9;
            this.btnListCollections.Text = "List Collections";
            this.btnListCollections.UseVisualStyleBackColor = true;
            this.btnListCollections.Click += new System.EventHandler(this.btnListCollections_Click);
            // 
            // FrmMongoDBTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 592);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FrmMongoDBTest";
            this.Text = "MongoDB Test";
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.Button btnCreateClient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGetDatabase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDbName;
        private System.Windows.Forms.ListBox lbxDatabases;
        private System.Windows.Forms.Button btnListDatabases;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnGetCollection;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCollectionName;
        private System.Windows.Forms.ListBox lbxCollections;
        private System.Windows.Forms.Button btnListCollections;
    }
}

