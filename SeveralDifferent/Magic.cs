using System;

namespace Magic{
    class methodReturnTricks{

        // this struct could as well be a class
        struct Result{
            public double exp;
            public double log;
        } // END struct Result

        private static Result expLog(int a, int b){
            var result = new Result
            {
                exp = Math.Pow(a, b),
                log = Math.Log(a, b)
            };
            return result;
        } // END expLog()

        private static void subDivOut(int a , int b, out int sub, out int div){
            sub = a - b;
            div = a / b;
        } // END subDivOut()

        private static void addMultiplyRef(int a, int b, ref int add, ref int multiply){
            add      = a + b;
            multiply = a * b;
        } // END addMultiplyRef()



        public static void testAllTricks(){
            int a = 20;
            int b = 10;
            int add = 0;
            int multiply = 0;
            
            // ref
            addMultiplyRef(a, b, ref add, ref multiply);
            Console.WriteLine("add = " + add + ", multiply = {0} ", multiply);

            // out
            subDivOut(a, b, out int sub, out int div);
            Console.WriteLine("sub = {0}, div = {1}", sub, div);


            //struct
            var result = expLog(a, b);
            Console.WriteLine("a = {0}, b = {1}, a^b = {2}, log{1}({0}) = {3}", a, b, result.exp, result.log);

            var result2 = expLog(a, 2);
            Console.WriteLine("a = {0}, b = {1}, a^2 = {2} , log{1}({0}) = {3}", a, 2, result2.exp, result2.log);


            //class


        } // END
    } // END
} // END

