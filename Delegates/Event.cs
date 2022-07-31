using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate string MyDel(string str);
    class Event
    {
        event MyDel MyEvent;
        //using constructor
        public Event()
        {
            this.MyEvent += new MyDel(this.WelcomeUser);
        }
        public string WelcomeUser(string username)
        {
            return "Welcome " + username;
        }
        static void Main(string[] args)
        {
            Event obj1 = new Event();
            string result = obj1.MyEvent("to BridgeLabz");
            Console.WriteLine(result);
        }
    }
}
