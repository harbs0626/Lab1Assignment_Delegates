namespace Lab1Assignment_Delegate
{
    partial class PublishNotificationForm
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
            this.NotificationContentTextBox = new System.Windows.Forms.TextBox();
            this.notificationContentLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PublishButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NotificationContentTextBox);
            this.groupBox1.Controls.Add(this.notificationContentLabel);
            this.groupBox1.Controls.Add(this.ExitButton);
            this.groupBox1.Controls.Add(this.PublishButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 148);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // NotificationContentTextBox
            // 
            this.NotificationContentTextBox.Location = new System.Drawing.Point(196, 41);
            this.NotificationContentTextBox.Name = "NotificationContentTextBox";
            this.NotificationContentTextBox.Size = new System.Drawing.Size(317, 27);
            this.NotificationContentTextBox.TabIndex = 4;
            // 
            // notificationContentLabel
            // 
            this.notificationContentLabel.AutoSize = true;
            this.notificationContentLabel.Location = new System.Drawing.Point(48, 44);
            this.notificationContentLabel.Name = "notificationContentLabel";
            this.notificationContentLabel.Size = new System.Drawing.Size(152, 19);
            this.notificationContentLabel.TabIndex = 3;
            this.notificationContentLabel.Text = "Notification Content - ";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(284, 85);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 34);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PublishButton
            // 
            this.PublishButton.Location = new System.Drawing.Point(176, 85);
            this.PublishButton.Margin = new System.Windows.Forms.Padding(4);
            this.PublishButton.Name = "PublishButton";
            this.PublishButton.Size = new System.Drawing.Size(100, 34);
            this.PublishButton.TabIndex = 1;
            this.PublishButton.Text = "Publish";
            this.PublishButton.UseVisualStyleBackColor = true;
            this.PublishButton.Click += new System.EventHandler(this.PublishButton_Click);
            // 
            // PublishNotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 161);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PublishNotificationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Publish Notification";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button PublishButton;
        private System.Windows.Forms.TextBox NotificationContentTextBox;
        private System.Windows.Forms.Label notificationContentLabel;
    }
}