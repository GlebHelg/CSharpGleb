using System;
//using RectangleApplication;

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
        static int add(int int1, int int2){
            return int1 + int2;
        }

        public void controller(){

            bool toContinue = true;
            do{
                Console.WriteLine("You are inside controller function in Arithmetics class.\nWanna do some math? ;)\n[y/n]");
                string answer = Console.ReadLine();
                if(answer == "y"){
                    Console.WriteLine("Sweet! Welcome aboard!! [press any key to continue]");
                    Console.ReadKey();
                    string quitter2;
                    do{
                        Console.WriteLine("Do you want to add, subtract, multiply or divide? [the choise is yours a/s/m/d or anything else, and you might exit]");
                        quitter2 = "";
                        string inp = Console.ReadLine();
                        char operation = inp[0];
                        switch(operation){
                            case 'a' :
                                Console.WriteLine("For now you can only add 2 ints.\nInt1: ");
                                int int1  = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Int2: ");
                                int int2  = Convert.ToInt32(Console.ReadLine());
                                int added = add(int2, int1);//haha, trolling
                                Console.WriteLine("Seems like the addition went well! The answer is 42, jk, it's: {0}", added);
                                break;
                            case 's' :
                                Console.WriteLine("Not implemented yet...");
                                break;
                            case 'm' :
                                Console.WriteLine("Not implemented yet...");
                                break;
                            case 'd' :
                                Console.WriteLine("Not implemented yet...");
                                break;
                            default  :
                                Console.WriteLine("Do you even type bro?...Thats not the question.\nThe question is, are you a quitter?[y]");
                                quitter2 = Console.ReadLine();
                                break;
                        }
                    }while(quitter2 != "y");
                }else if (answer == "n"){
                    Console.WriteLine("So you don't like math and want to quit? :(\n[i only accept \"y\" as an answer]\n");
                    string quitter = Console.ReadLine();
                    if(quitter == "y"){
                        return;
                    }
                }else{
                    Console.WriteLine("I do not understand... I'm just a stupid program...");
                }
            }while(toContinue == true);
            return;
        }
    }

    class GuidGenerator{
        public Guid[] GuidBuilder(String[] ean){
            Guid[] g = new Guid[ean.Length];
            for(int i = 0; i < ean.Length; i += 1){
                g[i] = Guid.NewGuid();
            }
            return g;
        }
    }

    class NumberManipulator{
        public int factorial(int num){
            int result;
            if(num == 1){
                return 1;
            }else{
                result = factorial(num - 1) * num;
                return result;
            }
        }

    }

    class Program{

        static void Main(string[] args){

 //           AllTheMethods atm = new AllTheMethods();
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

//            var ari = new Arithmetics();
//            ari.controller();
//            var g          = new GuidGenerator();
//            string[] eans  = {"400638133391", "400638133392", "400638133393"};
//            foreach(Guid x in g.GuidBuilder(eans)){
//                Console.WriteLine(x);
//            }
//            var r = new RectangleApplication.Rectangle();
//            r.length = 4.5;
//            r.width = 3.5;
//            r.Display();
//            Console.ReadLine();
//            
            var nm = new NumberManipulator();
            Console.WriteLine((ulong)nm.factorial(22));

        }
    }
}