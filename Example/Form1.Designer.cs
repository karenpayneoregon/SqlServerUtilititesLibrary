namespace Example
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sqlServerAvailableButton = new System.Windows.Forms.Button();
            this.isSpecificServerAvailableButton = new System.Windows.Forms.Button();
            this.serverNameTextBox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // sqlServerAvailableButton
            // 
            this.sqlServerAvailableButton.Location = new System.Drawing.Point(12, 24);
            this.sqlServerAvailableButton.Name = "sqlServerAvailableButton";
            this.sqlServerAvailableButton.Size = new System.Drawing.Size(145, 23);
            this.sqlServerAvailableButton.TabIndex = 0;
            this.sqlServerAvailableButton.Text = "Is SQL-Server available";
            this.sqlServerAvailableButton.UseVisualStyleBackColor = true;
            this.sqlServerAvailableButton.Click += new System.EventHandler(this.sqlServerAvailableButton_Click);
            // 
            // isSpecificServerAvailableButton
            // 
            this.isSpecificServerAvailableButton.Location = new System.Drawing.Point(12, 53);
            this.isSpecificServerAvailableButton.Name = "isSpecificServerAvailableButton";
            this.isSpecificServerAvailableButton.Size = new System.Drawing.Size(145, 23);
            this.isSpecificServerAvailableButton.TabIndex = 1;
            this.isSpecificServerAvailableButton.Text = "Is Server available";
            this.isSpecificServerAvailableButton.UseVisualStyleBackColor = true;
            this.isSpecificServerAvailableButton.Click += new System.EventHandler(this.isSpecificServerAvailableButton_Click);
            // 
            // serverNameTextBox
            // 
            this.serverNameTextBox.Location = new System.Drawing.Point(163, 55);
            this.serverNameTextBox.Name = "serverNameTextBox";
            this.serverNameTextBox.Size = new System.Drawing.Size(139, 20);
            this.serverNameTextBox.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(17, 95);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(528, 162);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Display name";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Service name";
            this.columnHeader2.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 269);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.serverNameTextBox);
            this.Controls.Add(this.isSpecificServerAvailableButton);
            this.Controls.Add(this.sqlServerAvailableButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL-Server Available sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sqlServerAvailableButton;
        private System.Windows.Forms.Button isSpecificServerAvailableButton;
        private System.Windows.Forms.TextBox serverNameTextBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

