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
    // public int function(){
    //     Console.ReadLine();
    // }

    class AllTheMethods{
        public string sizeOfChar(){
            int a = sizeof(char);
            return a + "\n";
        }
        public int sizeOfInt(){
            int a = sizeof(int);
            return a;
        }

        public int sizeOfString(string str){
            int strLen   = str.Length;
            int charsize = sizeof(char);

            return strLen * charsize;
        }

        public int doubleToInt(double d){
            int i;
            i = (int)d;

            return i;
        }

        public void readIntFromUserMultiplyByTwo(){
            Console.WriteLine("Enter an int, and we will multiply it by 2: ");
            String userInput = Console.ReadLine();
            int input = Convert.ToInt32(userInput);
            Console.WriteLine("User entered {0}, multiply this by 2 and you get: " + input * 2 + "\n\a", input);
            Console.ReadKey();
            return;
        }

        public void wannaHearPling(){
            //const string answer = "y"; will make build fail, because referenced further down as a variable, but a onstant is not a variable
            string answer = "y";
            do{
                Console.WriteLine("Wanna hear a pling? [y/ * != y]: ");
                answer = Console.ReadLine();
                if(answer == "y"){
                    Console.WriteLine("\a");
                }
            }while(answer == "y");

            return;
        }

        public void circleArea(){
            const double pi = 3.14159;
            Console.WriteLine("Enter Radius: ");
            double rad = Convert.ToDouble(Console.ReadLine());
            double areaCircle = pi * rad * rad;
            Console.WriteLine("Radius: {0}, Area: {1}", rad, areaCircle);
            Console.ReadLine();
        }
    }
    class Arithmetics{
        static add(int[] ints){
            
        }
    }
    class Program{

        static void Main(string[] args){

//            AllTheMethods atm = new AllTheMethods();
//
//            Console.WriteLine("[in Main()] Size of Int: " + atm.sizeOfInt());
//            Console.ReadLine();
//
//            ObjectFun obj2 = new ObjectFun();
//            Console.WriteLine("[in Main()] obj2.a = " + obj2.a);
//            //obj2.ObjectFuncStatic(); will not run because static
//            obj2.ObjectFunc();
//            Console.ReadLine();
//
//            Console.Write("[in Main()] Size of Char: " + atm.sizeOfChar());
//            Console.ReadLine();
//
//            // Impossible to call a function outside of a Class
//            //function();
//
//            // Difference between a lowercase or uppercase first literal in type specification, when doing variable declaration, is that lowercase are primitive types, while uppercase is object declaration.
//            String strToSend = "String theory!";
//            Console.WriteLine("[in Main()] Size of String: \"{0}\" : " + atm.sizeOfString(strToSend), strToSend);
//            Console.ReadLine();
//
//            double doubleToSend = 42.424242;
//            Console.WriteLine("[in Main()] Now we will convert following double to an int: {0} : " + atm.doubleToInt(doubleToSend)  + "\n", doubleToSend);
//            Console.WriteLine("[in Main()] Now let's check the lengthof this double, when it becomes a string: " + atm.sizeOfString(doubleToSend.ToString()));
//            Console.ReadLine();
//
//            // User Input
//            atm.readIntFromUserMultiplyByTwo();
//            atm.wannaHearPling();
//            atm.circleArea();

            Arithmetics ari = new Arithmetics();



        }
    }
}