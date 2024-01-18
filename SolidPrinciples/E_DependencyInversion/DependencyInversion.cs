using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.E_DependencyInversion
{
    /// <summary>
    /// High Level Modules should not depend on low leve Modules both should depend on abstractions (using interfaces)
    /// </summary>
    public class DependencyInversion
    {

        /// <summary>
        /// High Level
        /// </summary>
        public class Notification
        {
            private IMessage messageService;

            public Notification(IMessage messageService)
            {
                this.messageService = messageService;
            }

            public void SendMessage(string message)
            {
                messageService.SendMessage(message);
            }
        }

        /// <summary>
        /// Abstraction
        /// </summary>
        public interface IMessage
        {
            void SendMessage(string message);
        }

        /// <summary>
        /// Low Level
        /// </summary>
        public class Hotmail : IMessage
        {
            public void SendMessage(string message)
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Low Level
        /// </summary>
        public class Gmail : IMessage
        {
            public void SendMessage(string message)
            {
                throw new NotImplementedException();
            }
        }

    }
}
