using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.A_SingleResponsibility
{
    /// <summary>
    /// Single Responsibility For Class . One Reasone to modifiy class
    /// اجعل للكلاس مهمة واحدة وليست متعددة حتي يسهل صيانتها واختبارها فيما بعد
    /// اجعل محتوي الكلاس من اجراءات تعكس اسمها والهدف منها ولا تجعل للكلاس الواحد مهام متعددة او تخدم اكثر من مجال
    /// </summary>
    public class SingleResponsibility
    {

        public class Invoice
        {
            public void CreateInvoice()
            {

            }

            public void UpdateInvoice(Invoice invoice)
            {

            }

            public void RemoveInvoice(int invoiceId)
            {

            }
        }

        public class Report
        {
            public void PrintInvoice(Invoice invoice)
            {

            }
        }




        public class User
        {
            public string Name { get; set; }
            public string Password { get; set; }
            public string Address { get; set; }
        }

        public class Email
        {
            public void SendEmail(string email, string content)
            {

            }
        }

        public class Logger
        {
            public void LogMessage(string message)
            {

            }
        }

        public class UserLogin
        {
            public void Login(string userName, string password)
            {

            }
        }

        public class UserRegisteration
        {
            public void Register(string userName,string password)
            {

            }
        }



    }

    }




}
