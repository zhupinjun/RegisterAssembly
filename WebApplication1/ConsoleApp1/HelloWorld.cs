using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /// <summary>
    /// HelloWorld 的摘要说明。
    /// </summary>
    public class HelloWorld
    {
        string myName = null;

        public HelloWorld(string name)
        {
            myName = name;
        }
        public HelloWorld() : this(null)
        {

        }

        public string Name
        {
            get
            { return myName; }
        }

        public void SayHello()
        {
            if (myName == null)
                System.Console.WriteLine("Hello World");
            else
                System.Console.WriteLine("Hello," + myName);
        }
    }
}
