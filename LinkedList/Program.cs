using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
   public class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddAtStart("Adam");
            list.AddAtStart("Cat");
            list.AddAtStart("Mohammed");
            list.AddAtStart("Shaun");
            list.AddToEnd("Mohammed");
            list.AddToEnd("Jaide");



            string name = "Adam";
            list.RemoveAll(name);


            

        }
    }
}
