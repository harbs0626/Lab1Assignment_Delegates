using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// ** Student Name     : Harbin Ramo
/// ** Student Number   : 301046044
/// ** Lab Assignment   : #1 - Delegate
/// ** Date (MM/dd/yyy) : 01/12/2020
/// </summary>
namespace Lab1Assignment_Delegate.Classes
{
    public class SendViaEmail
    {
        // ** Declare variable(s)
        private string EmailAddress { get; set; }
        private int i = 1;

        // ** Constructor(s)
        public SendViaEmail() { }
        public SendViaEmail(string emailAddress)
        {
            this.EmailAddress = emailAddress;
        }

        // ** Subscribe method
        public int Subscribe(List<string> _subscriberList)
        {
            bool _checkEmail = _subscriberList.Contains(this.EmailAddress);
            int i = 0;

            if (_checkEmail)
            {
                i = 1; // ** Return 1 since it already exist from the list of subscribers
            }
            else
            {
                _subscriberList.Add(this.EmailAddress);
                //this.ShowSubscribers(_subscriberList);
            }

            return i;            
        }

        // ** Unsubscribe method
        public int Unsubscribe(List<string> _subscriberList)
        {
            int i = _subscriberList.IndexOf(this.EmailAddress);

            if (i > 0 || i == 0)
            {
                _subscriberList.RemoveAt(i);
                //this.ShowSubscribers(_subscriberList);
            }

            return i;
        }

        // ** Optional: For test only
        //private void ShowSubscribers(List<string> subscriberList)
        //{
        //    Console.WriteLine($"> # of email subscribers: {subscriberList.Count()}");

        //    Console.WriteLine("> Email Subscribers:");
        //    foreach (string _str in subscriberList)
        //    {
        //        Console.WriteLine($"{i++}. {_str}");
        //    }
        //}
    }
}
