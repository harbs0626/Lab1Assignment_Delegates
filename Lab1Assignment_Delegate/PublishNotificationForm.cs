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
    public partial class PublishNotificationForm : Form
    {
        public PublishNotificationForm()
        {
            InitializeComponent();
        }

        // ** Button click event for Publish Button
        private void PublishButton_Click(object sender, EventArgs e)
        {
            string _publishMessage = this.NotificationContentTextBox.Text;
            string _builderMessage = string.Empty;

            foreach (string _subscriber in Subscribe.SubscribersList)
            {
                _builderMessage += 
                    $"{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")} - " +
                    $"The message {_publishMessage} has notified subscriber {_subscriber}." + 
                    Environment.NewLine;
            }

            MessageBox.Show(_builderMessage);
        }

        // ** Button exit
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
