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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 96);
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
    }
}

