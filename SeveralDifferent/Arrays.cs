using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ArrayHurray{

    class Paramarray{
        public int AddElements(params int[] arr){
            int sum = 0;

            foreach(int i in arr){
                sum += i;
            }
            return sum;
        }
    }
    class ArrayClass{

        // a multidimensional array is very rigid, but probably very fast
        private static int[,] twoDimArray(int[] a, int[] b){
            int[,] twodim = new int[2,3];
            
            for(int i = 0; i<a.Length; i++){
                twodim[0,i] = a[i];
                twodim[1,i] = b[i];
            }
            return twodim;
        }// END twoDimArray()

        private static void reinventingList(){
            int[,] combi = new int[5,2];

            int cr = combi.Rank;
            int[] combiL = new int[cr];
            Console.WriteLine("Rank: " + cr);
            for(int i = 0; i < cr; i++){
                combiL[i] = combi.GetLength(i);
            }
            //Console.WriteLine(combiL.Length);
            for(int c = 0; c < combiL.Length; c++){
                Console.WriteLine(combiL[c]);
            }
            foreach(int c in combi){
                Console.WriteLine(c);
            }
        }// END reinventingList()

        // A jagged array is an array of arrays
        private static void jaggedArray1(){
            int [][] jagger = new int[5][];
            for(int i = 0; i < jagger.Length; i++){
                jagger[i] = new int[i];
                Console.WriteLine(jagger[i].Length);
            }
            Console.WriteLine(jagger+"\n");
        }

        private static void jaggedArray2(){
            int[][] a = new int[][]{new int[]{0,0}, new int[]{1,2}, new int[]{2,4}, new int[]{3,6}, new int[]{4,8}};

            foreach(int[] x in a){
                foreach(int y in x){
                    Console.WriteLine(y);
                }
            }
        }

        private static double getAverage(int[] arr){
            int i;
            double avg;
            int sum = 0;
            int size = arr.Length;
            for(i = 0; i < size; ++i){
                sum += arr[i];
            }
            avg = (double)sum / size;
            return avg;
        }

        public int AddElements(params int[] arr){
            int sum = 0;

            foreach(int i in arr){
                sum += i;
            }
            return sum;
        }

        public static void readkeyFib(int lvl, int iter1, int iter2){
            int temp = iter1;
            lvl += 1;
            iter1 = iter2;
            iter2 += temp;
            Console.WriteLine("Lvl: {0}, Fib: {1}", lvl, iter2);
            string s = Console.ReadLine();
            if(s == ""){
                // This means continue
                readkeyFib(lvl, iter1, iter2);
            }else{
                Console.WriteLine("Returning from lvl {0} in else. Fib: {1}", lvl, iter2);
                return;
            }
            Console.WriteLine("Returning from lvl {0} in funct. Fib: {1}", lvl, iter2);
            return;
        }

        public static void reqStar(string str, int count, int slice){
            Console.WriteLine(str);
            string str2 = str + str.Substring(0, slice);
            if(count == 10){
                return;
            }else{
                reqStar(str2, count+1, slice);
            }
            Console.WriteLine(str);
            return;
        }

        
        public static List<string> reqStarPerf(int count, List<string> acc){
            string str2 = acc[count] + acc[0];
            if(count == 10){
                return acc;
            }else{
                return reqStarPerf(count+1, acc.Concat(new[] {str2}).ToList())
                    .Concat(new[] {acc[count]})
                    .ToList();
            }
        }

        public static void ArrayClassExecutor(){
            int[] a = {1,2,3};
            int[] b = {4,5,6};
            int[,] combi = twoDimArray(a,b);
            for(int x = 0; x < 2; x++){
                string printstr = "";
                for(int y = 0; y < 3; y++){
                    printstr += combi[x,y]+" ";
                }
                Console.WriteLine(printstr + "\n");
            }
            //reinventingList();
            //jaggedArray1();
            //jaggedArray2();

            //int [] passit = {1,2,3,4,5,6};
            //double avg = getAverage(passit);
            //Console.WriteLine(avg);

            //var app = new Paramarray();
            //int sum = app.AddElements(512, 720, 250, 567, 889);
            //Console.WriteLine("The sum is: {0}", sum);
            //Console.ReadKey();
            //readkeyFib(0, 0, 1);
            string str = "ZXY";
            reqStar(str, 0, str.Length);

            IEnumerable<string> retStr = reqStarPerf(0, new List<string>{str});
            foreach (string v in retStr) {
                Console.WriteLine(v);
            }
        }
    }
}