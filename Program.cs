using System;

namespace EventsExplained
{
    class Program
    {
        public delegate void DelMethod(string message);

        public delegate string Method2del(string value);
        static void Main(string[] args)
        {
            // A delegate is a type safe function pointer
            DelMethod del = new DelMethod(Methoddel);
            del("Hello Humphry");

            Method2del meth2=new Method2del(Method2);
            string companyname = meth2.Invoke("Shiktech");
            Console.WriteLine(companyname);

            Callbacks callbacks=new Callbacks();
             callbacks.Longrunningloop(Callbackmethod);
        }

        public static void Methoddel(string message)
        {
            Console.WriteLine(message);
        }

        public static string Method2(string value)
        {
            
         return   value;
        }

        public static void Callbackmethod(int number)
        {
            Console.WriteLine(number);
        }
    }
    class Callbacks
    {
        // Many people just say delegates are type safe function pointer , but does it make sense , I mean does it make sense . What if we just call the 
        // method ?
        //The main funtion for delegates are callbacks , callbacks , callbacks
        public delegate void Callback(int currentnumber);

        public void Longrunningloop(Callback callback)
        {
            for (int i = 0; i <= 5000; i++)
            {
                 // do something eg
                 callback(i);
            }
        }
    }

}
