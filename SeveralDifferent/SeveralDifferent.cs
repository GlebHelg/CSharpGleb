using System;

namespace SeveralDifferent{
    class ObjectFun{
        public int a = 2;

        public static void ObjectFuncStatic(){
            // When a value type is converted to object type, it is called boxing. On the other hand, when an object type is 
            //converted to a value type, it is called unboxing.
            object obj;
            obj = 100;
            Console.WriteLine("Static " + obj);
            return;
        }
        public void ObjectFunc(){
            // When a value type is converted to object type, it is called boxing. On the other hand, when an object type is 
            //converted to a value type, it is called unboxing.
            object obj;
            obj = 100;
            Console.WriteLine(obj);
            ObjectFuncStatic();
            return;
        }
    }
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Size of Int: {0}", sizeof(int));
            Console.ReadLine();

            ObjectFun obj2 = new ObjectFun();
            Console.WriteLine(obj2.a);
            //obj2.ObjectFuncStatic(); will not run because static
            obj2.ObjectFunc();
            Console.ReadLine();

        }
    }
}