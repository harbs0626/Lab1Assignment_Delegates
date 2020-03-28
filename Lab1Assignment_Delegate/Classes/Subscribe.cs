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
    public class Subscribe
    {
        // ** Declare variable(s)
        public static List<string> SubscribersList = new List<string>();
        private int _returnValue = 0;
        private string _returnMessage = string.Empty;

        // ** Using Delegate
        public delegate string SubscribeDel(string _value, string _value2);

        public SubscribeDel GetSubscribeTypeDel(string subscribeType)
        {
            SubscribeDel subscribeDel = null;
            switch (subscribeType.ToLower())
            {
                case "email":
                    subscribeDel = SubscribeEmail;
                    break;
                case "phone":
                    subscribeDel = SubscribePhone;
                    break;
                default: break;
            }
            return subscribeDel;
        }

        // ** 1. Subscribe email method
        private string SubscribeEmail(string _value, string _value2)
        {
            // ** Call SendViaEmail class
            SendViaEmail _sendViaEmail = new SendViaEmail(_value);
           
            switch (_value2.ToLower())
            {
                case "subscribe":
                    this._returnValue = _sendViaEmail.Subscribe(SubscribersList);
                    if (this._returnValue == 1)
                    {
                        this._returnMessage = $"{_value} already exist!";
                    }
                    else
                    {
                        this._returnMessage = $"Successfully {_value2} {_value}.";
                    }
                    break;
                case "unsubscribe":
                    this._returnValue = _sendViaEmail.Unsubscribe(SubscribersList);
                    if (this._returnValue < 0)
                    {
                        this._returnMessage = $"{_value} does not exist!";
                    }
                    else
                    {
                        this._returnMessage = $"Successfully {_value2} {_value}.";
                    }
                    break;
                default:
                    this._returnMessage = "Unable to process request.";
                    break;
            }

            return this._returnMessage;
        }

        // ** 2. Subscribe phone method
        private string SubscribePhone(string _value, string _value2)
        {
            // ** Call SendViaMobile class
            SendViaMobile _sendViaMobile = new SendViaMobile(_value);

            switch (_value2.ToLower())
            {
                case "subscribe":
                    this._returnValue = _sendViaMobile.Subscribe(SubscribersList);
                    if (this._returnValue == 1)
                    {
                        this._returnMessage = $"{_value} already exist!";
                    }
                    else
                    {
                        this._returnMessage = $"Successfully {_value2} {_value}.";
                    }
                    break;
                case "unsubscribe":
                    this._returnValue = _sendViaMobile.Unsubscribe(SubscribersList);
                    if (this._returnValue < 0)
                    {
                        this._returnMessage = $"{_value} does not exist!";
                    }
                    else
                    {
                        this._returnMessage = $"Successfully {_value2} {_value}.";
                    }
                    break;
                default: break;
            }

            return this._returnMessage;
        }
    }
}
