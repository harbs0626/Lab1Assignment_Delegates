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
    public class SendViaMobile
    {
        // ** Declare variable(s)
        private string PhoneNumber { get; set; }
        private int i = 1;

        // ** Constructor(s)
        public SendViaMobile() { }
        public SendViaMobile(string phoneNumber)
        {
            this.PhoneNumber = phoneNumber;
        }

        // ** Subscribe method
        public int Subscribe(List<string> _subscriberList)
        {
            bool _checkPhone = _subscriberList.Contains(this.PhoneNumber);
            int i = 0;

            if (_checkPhone)
            {
                i = 0; // ** Return 1 since it already exist from the list of subscribers
            }
            else
            {
                _subscriberList.Add(this.PhoneNumber);
                //this.ShowSubscribers(_subscriberList);
            }

            return i;
        }

        // ** Unsubscribe method
        public int Unsubscribe(List<string> _subscriberList)
        {
            int i = _subscriberList.IndexOf(this.PhoneNumber);

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
        //    Console.WriteLine($"> # of phone subscribers: {subscriberList.Count()}");

        //    Console.WriteLine("> Phone Subscribers:");
        //    foreach (string _str in subscriberList)
        //    {
        //        Console.WriteLine($"{i++}. {_str}");
        //    }
        //}
    }
}
