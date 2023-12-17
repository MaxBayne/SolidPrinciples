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
        public InterfaceSegregation()
        {
            
        }

        public interface ICanPrintSingle
        {
            void PrintSingle(string content);
        }

        public interface ICanFax
        {
            void Fax(string content);
        }

        public interface ICanCopy
        {
            void Copy(string content);
        }

        public interface ICanPrintDuplex
        {
            void PrintDuplex(string content);
        }


        public class HpPrinter : ICanPrintSingle, ICanFax, ICanCopy
        {
            public void Copy(string content)
            {
                Console.WriteLine($"Copy = {content}");
            }

            public void Fax(string content)
            {
                Console.WriteLine($"Fax = {content}");
            }

            public void PrintSingle(string content)
            {
                Console.WriteLine($"PrintSingle = {content}");
            }
        }

        public class CannonPrinter : ICanPrintSingle, ICanFax, ICanCopy,ICanPrintDuplex
        {
            public void Copy(string content)
            {
                Console.WriteLine($"Copy = {content}");
            }

            public void Fax(string content)
            {
                Console.WriteLine($"Fax = {content}");
            }

            public void PrintDuplex(string content)
            {
                Console.WriteLine($"PrintDuplex = {content}");
            }

            public void PrintSingle(string content)
            {
                Console.WriteLine($"PrintSingle = {content}");
            }
        }

        public class SUVJetPrinter:ICanPrintSingle,ICanCopy
        {
            public void Copy(string content)
            {
                Console.WriteLine($"Copy = {content}");
            }

            public void PrintSingle(string content)
            {
                Console.WriteLine($"PrintSingle = {content}");
            }
        }

    }
}
