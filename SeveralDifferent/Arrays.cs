using System;
using System.Collections.Generic;

namespace ArrayHurray{
    class ArrayClass{

        private static int[,] twoDimArray(int[] a, int[] b){
            int[,] twodim = new int[2,3];
            
            for(int i = 0; i<a.Length; i++){
                twodim[0,i] = a[i];
                twodim[1,i] = b[i];
            }
            return twodim;
        }

        private static void reinventingList(){
            int[,] combi = new int[5,2];

            int cr = combi.Rank;
            int[] combiL = new int[cr];
            //Console.WriteLine(cr);
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
        }
    }
}