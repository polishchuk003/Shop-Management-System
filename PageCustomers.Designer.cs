namespace Shop_Management_System
{
    partial class PageCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageCustomers));
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.labelLogout = new System.Windows.Forms.Label();
            this.pictureBoxLogout = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridViewCustomersList = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelItems = new System.Windows.Forms.Label();
            this.labelDashboard = new System.Windows.Forms.Label();
            this.labelBills = new System.Windows.Forms.Label();
            this.labelCustomers = new System.Windows.Forms.Label();
            this.labelCategories = new System.Windows.Forms.Label();
            this.pictureBoxItems = new System.Windows.Forms.PictureBox();
            this.pictureBoxDashboard = new System.Windows.Forms.PictureBox();
            this.pictureBoxBills = new System.Windows.Forms.PictureBox();
            this.pictureBoxCustomers = new System.Windows.Forms.PictureBox();
            this.pictureBoxCategories = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCloseWindow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomersList)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCategories)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "-"});
            this.comboBoxGender.Location = new System.Drawing.Point(526, 220);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(133, 27);
            this.comboBoxGender.TabIndex = 32;
            // 
            // labelLogout
            // 
            this.labelLogout.AutoSize = true;
            this.labelLogout.BackColor = System.Drawing.Color.White;
            this.labelLogout.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogout.Location = new System.Drawing.Point(94, 41);
            this.labelLogout.Name = "labelLogout";
            this.labelLogout.Size = new System.Drawing.Size(76, 22);
            this.labelLogout.TabIndex = 8;
            this.labelLogout.Text = "Logout";
            this.labelLogout.Click += new System.EventHandler(this.labelLogout_Click);
            // 
            // pictureBoxLogout
            // 
            this.pictureBoxLogout.BackColor = System.Drawing.Color.White;
            this.pictureBoxLogout.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogout.Image")));
            this.pictureBoxLogout.Location = new System.Drawing.Point(12, 7);
            this.pictureBoxLogout.Name = "pictureBoxLogout";
            this.pictureBoxLogout.Size = new System.Drawing.Size(87, 81);
            this.pictureBoxLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLogout.TabIndex = 9;
            this.pictureBoxLogout.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(310, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(344, 32);
            this.label15.TabIndex = 42;
            this.label15.Text = "Customers Management:";
            // 
            // dataGridViewCustomersList
            // 
            this.dataGridViewCustomersList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewCustomersList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewCustomersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomersList.Location = new System.Drawing.Point(241, 444);
            this.dataGridViewCustomersList.Name = "dataGridViewCustomersList";
            this.dataGridViewCustomersList.Size = new System.Drawing.Size(733, 382);
            this.dataGridViewCustomersList.TabIndex = 40;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Red;
            this.buttonDelete.Location = new System.Drawing.Point(729, 322);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(111, 31);
            this.buttonDelete.TabIndex = 39;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(548, 323);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(111, 31);
            this.buttonAdd.TabIndex = 38;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.Color.Green;
            this.buttonEdit.Location = new System.Drawing.Point(368, 323);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(111, 31);
            this.buttonEdit.TabIndex = 37;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(488, 409);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(216, 32);
            this.label14.TabIndex = 41;
            this.label14.Text = "Customers List";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(346, 220);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(133, 26);
            this.textBoxName.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(703, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 22);
            this.label8.TabIndex = 29;
            this.label8.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(522, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 22);
            this.label7.TabIndex = 28;
            this.label7.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(342, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 22);
            this.label6.TabIndex = 27;
            this.label6.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.labelItems);
            this.panel2.Controls.Add(this.labelDashboard);
            this.panel2.Controls.Add(this.labelBills);
            this.panel2.Controls.Add(this.labelCustomers);
            this.panel2.Controls.Add(this.labelCategories);
            this.panel2.Controls.Add(this.pictureBoxItems);
            this.panel2.Controls.Add(this.pictureBoxDashboard);
            this.panel2.Controls.Add(this.pictureBoxBills);
            this.panel2.Controls.Add(this.pictureBoxCustomers);
            this.panel2.Controls.Add(this.pictureBoxCategories);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 745);
            this.panel2.TabIndex = 26;
            // 
            // labelItems
            // 
            this.labelItems.AutoSize = true;
            this.labelItems.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelItems.ForeColor = System.Drawing.Color.White;
            this.labelItems.Location = new System.Drawing.Point(98, 78);
            this.labelItems.Name = "labelItems";
            this.labelItems.Size = new System.Drawing.Size(60, 22);
            this.labelItems.TabIndex = 21;
            this.labelItems.Text = "Items";
            this.labelItems.Click += new System.EventHandler(this.labelItems_Click);
            // 
            // labelDashboard
            // 
            this.labelDashboard.AutoSize = true;
            this.labelDashboard.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDashboard.ForeColor = System.Drawing.Color.White;
            this.labelDashboard.Location = new System.Drawing.Point(98, 431);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(113, 22);
            this.labelDashboard.TabIndex = 18;
            this.labelDashboard.Text = "Dashboard";
            this.labelDashboard.Click += new System.EventHandler(this.labelDashboard_Click);
            // 
            // labelBills
            // 
            this.labelBills.AutoSize = true;
            this.labelBills.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBills.ForeColor = System.Drawing.Color.White;
            this.labelBills.Location = new System.Drawing.Point(98, 344);
            this.labelBills.Name = "labelBills";
            this.labelBills.Size = new System.Drawing.Size(50, 22);
            this.labelBills.TabIndex = 20;
            this.labelBills.Text = "Bills";
            this.labelBills.Click += new System.EventHandler(this.labelBills_Click);
            // 
            // labelCustomers
            // 
            this.labelCustomers.AutoSize = true;
            this.labelCustomers.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCustomers.ForeColor = System.Drawing.Color.White;
            this.labelCustomers.Location = new System.Drawing.Point(98, 257);
            this.labelCustomers.Name = "labelCustomers";
            this.labelCustomers.Size = new System.Drawing.Size(112, 22);
            this.labelCustomers.TabIndex = 19;
            this.labelCustomers.Text = "Customers";
            this.labelCustomers.Click += new System.EventHandler(this.labelCustomers_Click);
            // 
            // labelCategories
            // 
            this.labelCategories.AutoSize = true;
            this.labelCategories.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCategories.ForeColor = System.Drawing.Color.White;
            this.labelCategories.Location = new System.Drawing.Point(98, 170);
            this.labelCategories.Name = "labelCategories";
            this.labelCategories.Size = new System.Drawing.Size(111, 22);
            this.labelCategories.TabIndex = 17;
            this.labelCategories.Text = "Categories";
            this.labelCategories.Click += new System.EventHandler(this.labelCategories_Click);
            // 
            // pictureBoxItems
            // 
            this.pictureBoxItems.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxItems.Image")));
            this.pictureBoxItems.Location = new System.Drawing.Point(12, 50);
            this.pictureBoxItems.Name = "pictureBoxItems";
            this.pictureBoxItems.Size = new System.Drawing.Size(87, 81);
            this.pictureBoxItems.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxItems.TabIndex = 16;
            this.pictureBoxItems.TabStop = false;
            // 
            // pictureBoxDashboard
            // 
            this.pictureBoxDashboard.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDashboard.Image")));
            this.pictureBoxDashboard.Location = new System.Drawing.Point(12, 403);
            this.pictureBoxDashboard.Name = "pictureBoxDashboard";
            this.pictureBoxDashboard.Size = new System.Drawing.Size(87, 81);
            this.pictureBoxDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxDashboard.TabIndex = 13;
            this.pictureBoxDashboard.TabStop = false;
            // 
            // pictureBoxBills
            // 
            this.pictureBoxBills.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBills.Image")));
            this.pictureBoxBills.Location = new System.Drawing.Point(12, 316);
            this.pictureBoxBills.Name = "pictureBoxBills";
            this.pictureBoxBills.Size = new System.Drawing.Size(87, 81);
            this.pictureBoxBills.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxBills.TabIndex = 15;
            this.pictureBoxBills.TabStop = false;
            // 
            // pictureBoxCustomers
            // 
            this.pictureBoxCustomers.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCustomers.Image")));
            this.pictureBoxCustomers.Location = new System.Drawing.Point(12, 229);
            this.pictureBoxCustomers.Name = "pictureBoxCustomers";
            this.pictureBoxCustomers.Size = new System.Drawing.Size(87, 81);
            this.pictureBoxCustomers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCustomers.TabIndex = 14;
            this.pictureBoxCustomers.TabStop = false;
            // 
            // pictureBoxCategories
            // 
            this.pictureBoxCategories.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCategories.Image")));
            this.pictureBoxCategories.Location = new System.Drawing.Point(12, 142);
            this.pictureBoxCategories.Name = "pictureBoxCategories";
            this.pictureBoxCategories.Size = new System.Drawing.Size(87, 81);
            this.pictureBoxCategories.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCategories.TabIndex = 12;
            this.pictureBoxCategories.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.pictureBoxLogout);
            this.panel3.Controls.Add(this.labelLogout);
            this.panel3.Location = new System.Drawing.Point(0, 645);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 100);
            this.panel3.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("3ds", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(245, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(522, 44);
            this.label5.TabIndex = 8;
            this.label5.Text = "Shop Managment System 2.0";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(116, 6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(111, 81);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPhone.Location = new System.Drawing.Point(707, 221);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(133, 26);
            this.textBoxPhone.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.labelCloseWindow);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 93);
            this.panel1.TabIndex = 25;
            // 
            // labelCloseWindow
            // 
            this.labelCloseWindow.AutoSize = true;
            this.labelCloseWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCloseWindow.Location = new System.Drawing.Point(963, 6);
            this.labelCloseWindow.Name = "labelCloseWindow";
            this.labelCloseWindow.Size = new System.Drawing.Size(20, 20);
            this.labelCloseWindow.TabIndex = 11;
            this.labelCloseWindow.Text = "X";
            this.labelCloseWindow.Click += new System.EventHandler(this.labelCloseWindow_Click);
            // 
            // PageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 838);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dataGridViewCustomersList);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(986, 838);
            this.MinimumSize = new System.Drawing.Size(986, 838);
            this.Name = "PageCustomers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomersList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCategories)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label labelLogout;
        private System.Windows.Forms.PictureBox pictureBoxLogout;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridViewCustomersList;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxItems;
        private System.Windows.Forms.PictureBox pictureBoxDashboard;
        private System.Windows.Forms.PictureBox pictureBoxBills;
        private System.Windows.Forms.PictureBox pictureBoxCustomers;
        private System.Windows.Forms.PictureBox pictureBoxCategories;
        private System.Windows.Forms.Label labelItems;
        private System.Windows.Forms.Label labelDashboard;
        private System.Windows.Forms.Label labelBills;
        private System.Windows.Forms.Label labelCustomers;
        private System.Windows.Forms.Label labelCategories;
        private System.Windows.Forms.Label labelCloseWindow;
        private System.Windows.Forms.Panel panel3;
    }
}