using System;


namespace Magic{
    class methodReturnTricks{

        private static void addMultiply(int a, int b, ref int add, ref int multiply){
            add      = a + b;
            multiply = a * b;
        }

        public static void testAllTricks(){
            int a = 20;
            int b = 10;
            int add = 0;
            int multiply = 0;
            addMultiply(a, b, ref add, ref multiply);
            Console.WriteLine("add = " + add + ", multiply = {0} ", multiply);
        }
    }
}

