using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.A_SingleResponsibility
{
    /// <summary>
    /// Single Responsibility For Class . One Reasone to modifiy class
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


    }




}
