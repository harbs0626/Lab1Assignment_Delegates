namespace Lab1Assignment_Delegate
{
    partial class NotificationManagerForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ManageSubscriptionButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PublishNotificationButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ManageSubscriptionButton);
            this.groupBox1.Controls.Add(this.ExitButton);
            this.groupBox1.Controls.Add(this.PublishNotificationButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 148);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // ManageSubscriptionButton
            // 
            this.ManageSubscriptionButton.Location = new System.Drawing.Point(21, 61);
            this.ManageSubscriptionButton.Margin = new System.Windows.Forms.Padding(4);
            this.ManageSubscriptionButton.Name = "ManageSubscriptionButton";
            this.ManageSubscriptionButton.Size = new System.Drawing.Size(200, 34);
            this.ManageSubscriptionButton.TabIndex = 0;
            this.ManageSubscriptionButton.Text = "Manage Subscription";
            this.ManageSubscriptionButton.UseVisualStyleBackColor = true;
            this.ManageSubscriptionButton.Click += new System.EventHandler(this.ManageSubscriptionButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(437, 61);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 34);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PublishNotificationButton
            // 
            this.PublishNotificationButton.Enabled = false;
            this.PublishNotificationButton.Location = new System.Drawing.Point(229, 61);
            this.PublishNotificationButton.Margin = new System.Windows.Forms.Padding(4);
            this.PublishNotificationButton.Name = "PublishNotificationButton";
            this.PublishNotificationButton.Size = new System.Drawing.Size(200, 34);
            this.PublishNotificationButton.TabIndex = 1;
            this.PublishNotificationButton.Text = "Publish Notification";
            this.PublishNotificationButton.UseVisualStyleBackColor = true;
            this.PublishNotificationButton.Click += new System.EventHandler(this.PublishNotificationButton_Click);
            // 
            // NotificationManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 161);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "NotificationManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notification Manager";
            this.Load += new System.EventHandler(this.NotificationManagerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ManageSubscriptionButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button PublishNotificationButton;
    }
}