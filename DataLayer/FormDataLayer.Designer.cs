namespace DataLayer
{
    partial class FormDataLayer
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
            this.label_Employee_Id = new System.Windows.Forms.Label();
            this.label_first_name = new System.Windows.Forms.Label();
            this.label_last_name = new System.Windows.Forms.Label();
            this.textBoxEmployeeID = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label_Employee_Id
            // 
            this.label_Employee_Id.AutoSize = true;
            this.label_Employee_Id.Location = new System.Drawing.Point(42, 44);
            this.label_Employee_Id.Name = "label_Employee_Id";
            this.label_Employee_Id.Size = new System.Drawing.Size(80, 16);
            this.label_Employee_Id.TabIndex = 0;
            this.label_Employee_Id.Text = "EmployeeId";
            // 
            // label_first_name
            // 
            this.label_first_name.AutoSize = true;
            this.label_first_name.Location = new System.Drawing.Point(290, 44);
            this.label_first_name.Name = "label_first_name";
            this.label_first_name.Size = new System.Drawing.Size(69, 16);
            this.label_first_name.TabIndex = 1;
            this.label_first_name.Text = "FirstName";
            // 
            // label_last_name
            // 
            this.label_last_name.AutoSize = true;
            this.label_last_name.Location = new System.Drawing.Point(535, 44);
            this.label_last_name.Name = "label_last_name";
            this.label_last_name.Size = new System.Drawing.Size(69, 16);
            this.label_last_name.TabIndex = 2;
            this.label_last_name.Text = "LastName";
            // 
            // textBoxEmployeeID
            // 
            this.textBoxEmployeeID.Location = new System.Drawing.Point(45, 90);
            this.textBoxEmployeeID.Name = "textBoxEmployeeID";
            this.textBoxEmployeeID.Size = new System.Drawing.Size(100, 22);
            this.textBoxEmployeeID.TabIndex = 3;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(293, 90);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 22);
            this.textBoxFirstName.TabIndex = 4;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(538, 90);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 22);
            this.textBoxLastName.TabIndex = 5;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(167, 191);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(87, 33);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(444, 191);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(92, 29);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(68, 263);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(661, 143);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "EmployeeId";
            this.columnHeader1.Width = 158;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "FirstName";
            this.columnHeader2.Width = 220;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "LastName";
            this.columnHeader3.Width = 332;
            // 
            // FormDataLayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxEmployeeID);
            this.Controls.Add(this.label_last_name);
            this.Controls.Add(this.label_first_name);
            this.Controls.Add(this.label_Employee_Id);
            this.Name = "FormDataLayer";
            this.Text = "EmployeeId";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Employee_Id;
        private System.Windows.Forms.Label label_first_name;
        private System.Windows.Forms.Label label_last_name;
        private System.Windows.Forms.TextBox textBoxEmployeeID;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

