using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.D_InterfaceSegregation
{
    /// <summary>
    /// Mean Dont Make Interface have All Members just sepreate all to some of interfaces
    /// </summary>
    public class InterfaceSegregation
    {

        public interface ICashOrder
        {
            void ProcessOrder();
        }

        public interface ICreditOrder
        {
            void ProcessOrder();
        }

        public interface IOnlineOrder
        {
            void ProcessOrder();
        }

        public class CashOrder : ICashOrder
        {
            public void ProcessOrder()
            {
                throw new NotImplementedException();
            }
        }

        public class CreditOrder : ICreditOrder
        {
            public void ProcessOrder()
            {
                throw new NotImplementedException();
            }
        }

        public class OnlineOrder : IOnlineOrder
        {
            public void ProcessOrder()
            {
                throw new NotImplementedException();
            }
        }
    }
}
