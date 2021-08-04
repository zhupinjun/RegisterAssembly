using System;
using System.Reflection;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dd= Encoding.Default.GetBytes("21");
            ASYNC.TestMain();

            RsaDa rsaDa = new RsaDa();
            rsaDa.DDD();
            System.Console.WriteLine("列出程序集中的所有类型");
            Assembly a = Assembly.LoadFrom("ConsoleApp1.dll");

            Type[] mytypes = a.GetTypes();

            foreach (Type t in mytypes)
            {
                System.Console.WriteLine(t.Name);
            }
            System.Console.ReadLine();

            System.Console.WriteLine("列出HelloWorld中的所有方法");

            Type ht = typeof(HelloWorld);

            MethodInfo[] mif = ht.GetMethods();

            foreach (MethodInfo mf in mif)
            {
                System.Console.WriteLine(mf.Name);
            }

            System.Console.ReadLine();

            System.Console.WriteLine("实例化HelloWorld,并调用SayHello方法");

            Object obj = Activator.CreateInstance(ht);

            string[] s = { "ZhenLei" };

            Object objName = Activator.CreateInstance(ht, s);

            MethodInfo msayhello = ht.GetMethod("SayHello");

            msayhello.Invoke(obj, null);

            msayhello.Invoke(objName, null);

            System.Console.ReadLine();
            //IChinese chinese = new See();
            //chinese.Speak();
            //chinese.SCora();
            //Point3D point3D = new Point3D(1,2,3);
            //Point point = point3D;
            //Ess.ss();
            //Console.WriteLine("Hello World!");
        }
    }
    //隐藏式实现例子
    public interface IChinese : IEnglish
    {
        string Speak();
        string SCora() => "cc";
    }
    public class Speaker : IChinese
    {
        public string Speak()
        {
            return "中文";
        }
        public string SpeakEnglish()
        {
            return "英文";
        }
        public string SCora()
        {
            return "cce";
        }
    }
    public class See : Speaker
    {
        public string Seec()
        {
            return "see";
        }
    }
    public interface IEnglish
    {
        string SpeakEnglish();
    }
}
