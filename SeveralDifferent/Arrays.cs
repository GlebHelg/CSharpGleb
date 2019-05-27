using System;
using System.Collections.Generic;

namespace ArrayHurray{
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



        }
    }
}