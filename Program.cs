using System;

namespace SynystetNght
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p =new Program();
            Console.WriteLine("1 - Fibonnacci");
            Console.WriteLine("2 Binary Search");
            Console.WriteLine("3 Max number");
            Console.WriteLine("4 Bubble Sort");
            
            int[] vector = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,35 };
            int c = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case 1: p.fibo();
                    break;
                default: break;
                case 2: int x = Convert.ToInt32(Console.ReadLine());
                    if (x > vector[vector.Length - 1])
                        Console.WriteLine("Number Greater than upper limit");
                    else
                        Console.WriteLine(p.bin(vector, x, 0, vector.Length));
                    break;
                case 3:Console.WriteLine(p.max(vector)); 
                    break;
                case 4: p.bubble();
                    break;
                case 5: p.criba();
                    break;
                case 6: c = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(p.fibor(c));
                    break;
            }
        }

        public int max(int[] x) {
            int n = 0;

            for (int i = 0; i < x.Length; i++)
            {
                if (n < x[i]) n = x[i];
            }
            return n;
        }

        public void bubble(){
            int[] v = { 5,  6, 89, 8, 7, 10, 135, 468, 1};
            int n = v.Length;

            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n-1-i; j++)
                {
                    if (v[j] > v[j + 1])
                    {
                        int temp = v[j];
                        v[j] = v[j + 1];
                        v[j + 1] = temp;
                    }
                }
            }

            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(v[i]);
            }
        }

        public bool bin(int[] vector, int x, int li, int ls) {
            int mid = (li + ls)/2;

            if (x == vector[mid])
                return true;
            if (li == ls) return false;
            if (x > vector[mid])
                li = mid;
            else
                ls = mid;

            return bin(vector,x,li,ls);
        }
        public void fibo()
        {
            double li, ls, a;
            li = a = 0;
            ls = 1;
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                a = li + ls;
                li = ls;
                ls = a;
            }
            Console.WriteLine(ls);
        }

        public double fibor(int p)
        {
            if (p < 3) return 1;
            else {
                return (fibor(p - 2) + fibor(p - 1));
            }
            

        }

        public void criba()
        {
            int n = 1000;
            bool[] criba =new bool[n];
            
            
            for (int i = 2; i <= n; i++)
            {
                for (int j = i; j < n/i; j++)
                {
                    criba[i * j] = true;
                }

            }

            n= Convert.ToInt32(Console.ReadLine());
            if (criba[n] == false)
            {
                Console.WriteLine("ES Primo");
            }
            else Console.WriteLine("No es primo");
        }

    }
}
