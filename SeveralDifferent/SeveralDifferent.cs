using System;

namespace SeveralDifferent{
    class ObjectFun{
        public int a = 2;

        public static void ObjectFuncStatic(){
            // When a value type is converted to object type, it is called boxing. On the other hand, when an object type is 
            //converted to a value type, it is called unboxing.
            object obj;
            obj = 100;
            Console.WriteLine("[in ObjectFuncStatic()] obj = " + obj);
            return;
        }
        public void ObjectFunc(){
            // When a value type is converted to object type, it is called boxing. On the other hand, when an object type is 
            //converted to a value type, it is called unboxing.
            object obj;
            obj = 100;
            Console.WriteLine("[in ObjectFunc()] obj = " + obj);
            //Must be inside Class to run Static 
            ObjectFuncStatic();
            return;
        }
    }
    // Not possible in this language...
    //int function(){
    //    Console.ReadLine();
    //}

    class AllTheMethods{
        public int sizeOfChar(){
            int a = sizeof(char);
            return a;
        }
        public int sizeOfInt(){
            int a = sizeof(int);
            return a;
        }

        public int sizeOfString(String str){
            int strLen   = str.Length;
            int charsize = sizeof(char);

            return strLen * charsize;
        }
    }
    class Program{

        static void Main(string[] args){

            AllTheMethods atm = new AllTheMethods();

            Console.WriteLine("[in Main()] Size of Int: " + atm.sizeOfInt());
            Console.ReadLine();

            ObjectFun obj2 = new ObjectFun();
            Console.WriteLine("[in Main()] obj2.a = " + obj2.a);
            //obj2.ObjectFuncStatic(); will not run because static
            obj2.ObjectFunc();
            Console.ReadLine();

            Console.Write("[in Main()] Size of Char: " + atm.sizeOfChar());
            Console.ReadLine();

            // Impossible to call a function outside of a Class
            // function();

            String strToSend = "String theory!";
            Console.WriteLine("[in Main()] Size of String: \"{0}\" : " + atm.sizeOfString(strToSend), strToSend);
            Console.ReadLine();

        }
    }
}