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
    public class Publish
    {
        public delegate void PublishMessageDel(string msg, string value);

        public PublishMessageDel publishMsg = null;

        public void PublishMessage(string message, string value)
        {
            publishMsg.Invoke(message, value);
        }

    }
}
