using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab1Assignment_Delegate.Classes;
/// <summary>
/// ** Student Name     : Harbin Ramo
/// ** Student Number   : 301046044
/// ** Lab Assignment   : #1 - Delegate
/// ** Date (MM/dd/yyy) : 01/12/2020
/// </summary>
namespace Lab1Assignment_Delegate
{
    public partial class NotificationManagerForm : Form
    {
        public NotificationManagerForm()
        {
            InitializeComponent();
        }

        // ** Load event
        private void NotificationManagerForm_Load(object sender, EventArgs e)
        {
            this.PublishNotificationButton.Enabled = false;
            if (Subscribe.SubscribersList.Count > 0)
            {
                this.PublishNotificationButton.Enabled = true;
            }
        }

        // ** Button click event for Manage Subscription
        private void ManageSubscriptionButton_Click(object sender, EventArgs e)
        {
            ManageSubscriptionForm manageSubscriptionForm = new ManageSubscriptionForm();
            manageSubscriptionForm.Show();
            this.Hide();
        }

        // ** Button click event for Publish Notification
        private void PublishNotificationButton_Click(object sender, EventArgs e)
        {
            PublishNotificationForm publishNotificationForm = new PublishNotificationForm();
            publishNotificationForm.Show();
            this.Hide();
        }

        // ** Button exit
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
