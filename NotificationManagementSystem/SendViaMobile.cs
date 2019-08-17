using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotificationManagementSystem
{
          public class SendViaMobile
          {
              private String CellPhone { get; set; }

              public SendViaMobile() { }

              public SendViaMobile(String phone)
              {
                  CellPhone = phone;
              }

              private void sendMessage(TextBox textboxOutput, string msg)
              {
                textboxOutput.Text += "The message" + "\"" + msg + "\" has already sent to " + CellPhone + "\r\n";
              }

              public void Subscribe(Publisher pub)
              {
                  pub.publishmsg += sendMessage;
              }

              public void UnSubscribe(Publisher pub)
              {
                 pub.publishmsg -= sendMessage;
              }

              public override string ToString()
              {
                return string.Format(CellPhone);
              }
         
          }
}
