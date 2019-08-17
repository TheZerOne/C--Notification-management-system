using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotificationManagementSystem
{
          public class Publisher
          {
                    //Declare Delegate
                    public delegate void PublishMessageDel(TextBox textboxOutput,string msg);

                    //Declare an instance variable which is a Delegate object 
                    public PublishMessageDel publishmsg = null;

                    //Method used to Invoke Delegate
                    public void PublishMessage(TextBox textboxOutput, string message)
                    {
                              //Invoke Delegate
                              publishmsg.Invoke(textboxOutput, message);
                    }
          }
}
