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
using System.Text.RegularExpressions;
/// <summary>
/// ** Student Name     : Harbin Ramo
/// ** Student Number   : 301046044
/// ** Lab Assignment   : #1 - Delegate
/// ** Date (MM/dd/yyy) : 01/12/2020
/// </summary>
namespace Lab1Assignment_Delegate
{
    public partial class ManageSubscriptionForm : Form
    {
        public ManageSubscriptionForm()
        {
            InitializeComponent();
        }

        public bool _isEmailChecked;
        public bool _isPhoneChecked;

        // ** Closes the program
        private void ExitButton_Click(object sender, EventArgs e)
        {
            NotificationManagerForm notificationManagerForm = new NotificationManagerForm();
            notificationManagerForm.Show();
            this.Close();
        }

        // ** Get checkbox status
        private void NotificationSentByEmailCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            this._isEmailChecked = this.NotificationSentByEmailCheckbox.Checked;
            this.ClearFields(this._isEmailChecked, this.NotificationSentByEmailTextBox,
                "xxxx@xxx.xx | xxxx@xxx.xx.xx");
        }
        private void NotificationSentBySMSCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            this._isPhoneChecked = this.NotificationSentByPhoneCheckbox.Checked;
            this.ClearFields(this._isPhoneChecked, this.NotificationSentByPhoneTextBox,
                "xxx xxx-xxxx");
        }

        // ** Subscribe button
        private void SubscribeButton_Click(object sender, EventArgs e)
        {
            TextBox _emailValue = this.NotificationSentByEmailTextBox;
            TextBox _phoneValue = this.NotificationSentByPhoneTextBox;

            if (this._isEmailChecked || this._isPhoneChecked)
            {
                Subscribe _subscribe = new Subscribe();
                this.NotificationSentByEmail(this._isEmailChecked, _emailValue, "SUBSCRIBE", _subscribe);
                this.NotificationSentByPhone(this._isPhoneChecked, _phoneValue, "SUBSCRIBE", _subscribe);
            }
            else
            {
                MessageBox.Show("Please check a box to begin subscription process.");
                return;
            }
        }

        // ** Unsubscribe button
        private void UnsubscribeButton_Click(object sender, EventArgs e)
        {
            TextBox _emailValue = this.NotificationSentByEmailTextBox;
            TextBox _phoneValue = this.NotificationSentByPhoneTextBox;

            if (this._isEmailChecked || this._isPhoneChecked)
            {
                Subscribe _subscribe = new Subscribe();
                this.NotificationSentByEmail(this._isEmailChecked, _emailValue, "UNSUBSCRIBE", _subscribe);
                this.NotificationSentByPhone(this._isPhoneChecked, _phoneValue, "UNSUBSCRIBE", _subscribe);
            }
            else
            {
                MessageBox.Show("Please check a box to begin unsubscription process.");
                return;
            }
        }

        // ** Notification email method
        private void NotificationSentByEmail(bool isChecked, TextBox emailValue,
            string subscribeType, Subscribe subscribe)
        {
            if (isChecked)
            {
                if (emailValue.Text != "")
                {
                    if (!this.IsInputValid(emailValue.Text, "EMAIL"))
                    {
                        this.errorMessage1Label.Text = string.Empty;
                        this.errorMessage1Label.Text = "Invalid email. Format should be xxxxx@xxx.xx";
                        emailValue.SelectAll();
                        return;
                    }

                    string returnMessage = subscribe.GetSubscribeTypeDel("EMAIL")
                        .Invoke(emailValue.Text, subscribeType);
                    MessageBox.Show(returnMessage);
                    return;
                }
                else
                {
                    MessageBox.Show("Please enter email address.");
                    return;
                }
            }
            else
            {
                emailValue.Enabled = false;
                emailValue.Clear();
            }
        }

        // ** Notification phone method
        private void NotificationSentByPhone(bool isChecked, TextBox phonevalue,
            string subscribeType, Subscribe _subscribe)
        {
            if (isChecked)
            {
                if (phonevalue.Text != "")
                {
                    if (!this.IsInputValid(phonevalue.Text, "PHONE"))
                    {
                        this.errorMessage2Label.Text = string.Empty;
                        this.errorMessage2Label.Text = "Invalid phone. Format should be xxx xxx-xxxx";
                        phonevalue.SelectAll();
                        return;
                    }

                    string _returnMessage = _subscribe.GetSubscribeTypeDel("PHONE")
                        .Invoke(phonevalue.Text, subscribeType);
                    MessageBox.Show(_returnMessage);
                }
                else
                {
                    MessageBox.Show("Please enter phone number.");
                    return;
                }
            }
            else
            {
                phonevalue.Enabled = false;
                phonevalue.Clear();
            }
        }

        // ** Validate both email and phone
        private bool IsInputValid(string _inputValue, string _value)
        {
            bool isValid = true;

            switch (_value.ToLower())
            {
                case "email":
                    isValid = Regex.IsMatch(_inputValue,
                        "^(\\D)+(\\w)*((\\.(\\w)+)?)+@(\\D)+(\\w)*((\\.(\\D)+(\\w)*)+)?(\\.)[a-z]{2,}$");
                    break;
                case "phone":
                    isValid = Regex.IsMatch(_inputValue,
                        "^(\\d{3}) \\d{3}-\\d{2}\\d{2}$");
                    break;
            }

            return isValid;
        }

        // ** Clear Textboxes
        private void ClearFields(bool _isChecked, TextBox _textBox, string _value)
        {
            if (_isChecked)
            {
                _textBox.Clear();
                _textBox.Enabled = _isChecked;
            }
            else
            {
                _textBox.Text = _value;
                _textBox.Enabled = _isChecked;
            }
        }

    }
}
