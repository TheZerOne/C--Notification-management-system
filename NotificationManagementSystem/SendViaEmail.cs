using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotificationManagementSystem
{
          public class SendViaEmail
          {
                     private String _EmailAddr;
                    public String EmailAddr { get => _EmailAddr; set=>_EmailAddr=value; }

                    public SendViaEmail() { }

                    public SendViaEmail(String emailAddr)
                    {
                        EmailAddr = emailAddr;
                    }

                    public void sendEmail(TextBox textboxOutput,string msg)
                    {
                     textboxOutput.Text+= "The message" + "\""+ msg+ "\" has already sent to "+ EmailAddr+"\r\n";
                    }

                    public void Subscribe(Publisher pub)
                    {
                              pub.publishmsg += sendEmail;
                    }

        public void UnSubscribe(Publisher pub)
        {
            pub.publishmsg -= sendEmail;
        }
    }
}
