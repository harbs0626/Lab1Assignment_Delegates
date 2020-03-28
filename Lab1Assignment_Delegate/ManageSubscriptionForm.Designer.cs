namespace Lab1Assignment_Delegate
{
    partial class ManageSubscriptionForm
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
            this.errorMessage2Label = new System.Windows.Forms.Label();
            this.errorMessage1Label = new System.Windows.Forms.Label();
            this.NotificationSentByPhoneTextBox = new System.Windows.Forms.TextBox();
            this.NotificationSentByPhoneCheckbox = new System.Windows.Forms.CheckBox();
            this.NotificationSentByEmailTextBox = new System.Windows.Forms.TextBox();
            this.NotificationSentByEmailCheckbox = new System.Windows.Forms.CheckBox();
            this.UnsubscribeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SubscribeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.errorMessage2Label);
            this.groupBox1.Controls.Add(this.errorMessage1Label);
            this.groupBox1.Controls.Add(this.NotificationSentByPhoneTextBox);
            this.groupBox1.Controls.Add(this.NotificationSentByPhoneCheckbox);
            this.groupBox1.Controls.Add(this.NotificationSentByEmailTextBox);
            this.groupBox1.Controls.Add(this.NotificationSentByEmailCheckbox);
            this.groupBox1.Controls.Add(this.UnsubscribeButton);
            this.groupBox1.Controls.Add(this.ExitButton);
            this.groupBox1.Controls.Add(this.SubscribeButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 227);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // errorMessage2Label
            // 
            this.errorMessage2Label.AutoSize = true;
            this.errorMessage2Label.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage2Label.ForeColor = System.Drawing.Color.Red;
            this.errorMessage2Label.Location = new System.Drawing.Point(251, 130);
            this.errorMessage2Label.Name = "errorMessage2Label";
            this.errorMessage2Label.Size = new System.Drawing.Size(0, 15);
            this.errorMessage2Label.TabIndex = 10;
            // 
            // errorMessage1Label
            // 
            this.errorMessage1Label.AutoSize = true;
            this.errorMessage1Label.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage1Label.ForeColor = System.Drawing.Color.Red;
            this.errorMessage1Label.Location = new System.Drawing.Point(251, 69);
            this.errorMessage1Label.Name = "errorMessage1Label";
            this.errorMessage1Label.Size = new System.Drawing.Size(0, 15);
            this.errorMessage1Label.TabIndex = 9;
            // 
            // NotificationSentByPhoneTextBox
            // 
            this.NotificationSentByPhoneTextBox.Enabled = false;
            this.NotificationSentByPhoneTextBox.Location = new System.Drawing.Point(255, 100);
            this.NotificationSentByPhoneTextBox.Name = "NotificationSentByPhoneTextBox";
            this.NotificationSentByPhoneTextBox.Size = new System.Drawing.Size(251, 27);
            this.NotificationSentByPhoneTextBox.TabIndex = 7;
            this.NotificationSentByPhoneTextBox.Text = "xxx xxx-xxxx";
            // 
            // NotificationSentByPhoneCheckbox
            // 
            this.NotificationSentByPhoneCheckbox.AutoSize = true;
            this.NotificationSentByPhoneCheckbox.Location = new System.Drawing.Point(54, 102);
            this.NotificationSentByPhoneCheckbox.Name = "NotificationSentByPhoneCheckbox";
            this.NotificationSentByPhoneCheckbox.Size = new System.Drawing.Size(199, 23);
            this.NotificationSentByPhoneCheckbox.TabIndex = 8;
            this.NotificationSentByPhoneCheckbox.Text = "Notification Sent By SMS - ";
            this.NotificationSentByPhoneCheckbox.UseVisualStyleBackColor = true;
            this.NotificationSentByPhoneCheckbox.CheckedChanged += new System.EventHandler(this.NotificationSentBySMSCheckbox_CheckedChanged);
            // 
            // NotificationSentByEmailTextBox
            // 
            this.NotificationSentByEmailTextBox.Enabled = false;
            this.NotificationSentByEmailTextBox.Location = new System.Drawing.Point(255, 39);
            this.NotificationSentByEmailTextBox.Name = "NotificationSentByEmailTextBox";
            this.NotificationSentByEmailTextBox.Size = new System.Drawing.Size(251, 27);
            this.NotificationSentByEmailTextBox.TabIndex = 4;
            this.NotificationSentByEmailTextBox.Text = "xxxx@xxx.xx | xxxx@xxx.xx.xx";
            // 
            // NotificationSentByEmailCheckbox
            // 
            this.NotificationSentByEmailCheckbox.AutoSize = true;
            this.NotificationSentByEmailCheckbox.Location = new System.Drawing.Point(54, 41);
            this.NotificationSentByEmailCheckbox.Name = "NotificationSentByEmailCheckbox";
            this.NotificationSentByEmailCheckbox.Size = new System.Drawing.Size(208, 23);
            this.NotificationSentByEmailCheckbox.TabIndex = 6;
            this.NotificationSentByEmailCheckbox.Text = "Notification Sent By Email - ";
            this.NotificationSentByEmailCheckbox.UseVisualStyleBackColor = true;
            this.NotificationSentByEmailCheckbox.CheckedChanged += new System.EventHandler(this.NotificationSentByEmailCheckbox_CheckedChanged);
            // 
            // UnsubscribeButton
            // 
            this.UnsubscribeButton.Location = new System.Drawing.Point(230, 164);
            this.UnsubscribeButton.Margin = new System.Windows.Forms.Padding(4);
            this.UnsubscribeButton.Name = "UnsubscribeButton";
            this.UnsubscribeButton.Size = new System.Drawing.Size(100, 34);
            this.UnsubscribeButton.TabIndex = 5;
            this.UnsubscribeButton.Text = "Unsubscribe";
            this.UnsubscribeButton.UseVisualStyleBackColor = true;
            this.UnsubscribeButton.Click += new System.EventHandler(this.UnsubscribeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(338, 164);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 34);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Cancel";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SubscribeButton
            // 
            this.SubscribeButton.Location = new System.Drawing.Point(122, 164);
            this.SubscribeButton.Margin = new System.Windows.Forms.Padding(4);
            this.SubscribeButton.Name = "SubscribeButton";
            this.SubscribeButton.Size = new System.Drawing.Size(100, 34);
            this.SubscribeButton.TabIndex = 1;
            this.SubscribeButton.Text = "Subscribe";
            this.SubscribeButton.UseVisualStyleBackColor = true;
            this.SubscribeButton.Click += new System.EventHandler(this.SubscribeButton_Click);
            // 
            // ManageSubscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 241);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageSubscriptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Subscription";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label errorMessage2Label;
        private System.Windows.Forms.Label errorMessage1Label;
        private System.Windows.Forms.TextBox NotificationSentByPhoneTextBox;
        private System.Windows.Forms.CheckBox NotificationSentByPhoneCheckbox;
        private System.Windows.Forms.TextBox NotificationSentByEmailTextBox;
        private System.Windows.Forms.CheckBox NotificationSentByEmailCheckbox;
        private System.Windows.Forms.Button UnsubscribeButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SubscribeButton;
    }
}