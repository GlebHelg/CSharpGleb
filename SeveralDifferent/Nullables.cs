using System;


namespace Nullables{

    class Test{

        public static int changeTo3IfNull(int ? a){
            // coalescing operator : ??
            return a ?? 3;
        }
        public static string mightBeNull(int? a){
            
            return "a is " + a;
        }
    }
}