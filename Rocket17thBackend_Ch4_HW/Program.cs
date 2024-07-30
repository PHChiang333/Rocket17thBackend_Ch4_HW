using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket17thBackend_Ch4_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //例題5.1 - 利用一維陣列求10個數字的計算平均值。

            //Console.WriteLine("例題5.1 - 利用一維陣列求10個數字的計算平均值。");

            //double[] nums = new double[10];
            //double sum=0;
            //double ave= 0;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine($"請輸入第{i+1}個數字=");
            //    nums[i] = Convert.ToDouble(Console.ReadLine());
            //    sum += nums[i];
            //}

            //ave = sum / nums.Length;

            //Console.WriteLine($"輸入的數字平均數為{ave}");

            //Console.ReadKey();


            //----------------------------------------------


            //例題5.2 - 利用一維陣列求10個數字的最大值。

            //Console.WriteLine("例題5.2 - 利用一維陣列求10個數字的最大值。");


            //double[] nums = new double[10];
            //double max = double.MinValue;


            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine($"請輸入第{i + 1}個數字=");
            //    nums[i] = Convert.ToDouble(Console.ReadLine());
            //    if (nums[i] > max)
            //    {
            //        max = nums[i];
            //    }
            //}

            //Console.WriteLine($"輸入的數字中最大值為{max}");

            //Console.ReadKey();

            //----------------------------------------------


            //例題5.3 - 搜尋問題：輸入10個數字至A[]，再輸入x，判斷x是否存在於A陣列中，如果存在，輸出所在的註標(索引)值，若不存在，則告知不存在。

            //Console.WriteLine("例題5.3 - 搜尋問題：輸入10個數字至A[]，再輸入x，判斷x是否存在於A陣列中，如果存在，輸出所在的註標(索引)值，若不存在，則告知不存在。");

            //int[] A = new int[10];
            //int x;
            //bool isCorrect = false;


            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.Write($"請輸入第{i + 1}個數字=");
            //    A[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.Write($"請輸入要搜尋的數字x=");
            //x = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < A.Length; i++)
            //{
            //    if (x == A[i])
            //    {
            //        isCorrect = true;
            //        break;
            //    }
            //}

            //if (isCorrect == true)
            //{
            //    Console.WriteLine($"{x}在數列中");
            //}
            //else
            //{
            //    Console.WriteLine($"{x}不在數列中");
            //}

            //Console.ReadKey();

            //----------------------------------------------


            //例題5.4 - 求兩個2乘3的二維矩陣相加之結果，第一個及第二個矩陣分別以A及B表示，相加之結果存入C矩陣，最後將C矩陣內容顯示出來。

            //Console.WriteLine("例題5.4 - 求兩個2乘3的二維矩陣相加之結果，第一個及第二個矩陣分別以A及B表示，相加之結果存入C矩陣，最後將C矩陣內容顯示出來。");

            //int[,] A = new int[2, 3] ;
            //int[,] B = new int[2, 3];
            //int[,] C = new int[2, 3] { { 0, 0, 0 }, { 0, 0, 0 } };

            //Console.WriteLine("矩陣A=");

            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"A[{i},{j}]=");
            //        A[i, j ] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("\n");
            //Console.WriteLine("矩陣B=");

            //for (int i = 0; i < B.GetLength(0); i++)
            //{
            //    for (int j = 0; j < B.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"B[{i},{j}]=");
            //        B[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("\n");
            //Console.WriteLine("矩陣C=矩陣A+矩陣B");


            //for (int i = 0; i < C.GetLength(0); i++) { 
            //    for (int j = 0;j < C.GetLength(1); j++)
            //    {
            //        C[i,j] += A[i,j]+B[i,j];
            //    }
            //}

            //Console.Write($"矩陣C=");
            //foreach (int c in C)
            //{
            //    Console.Write($"{c}\t");
            //}

            //Console.ReadKey();

            //----------------------------------------------


            //例題5.5 - 求2乘3的A矩陣乘以3乘1的B矩陣，結果存入2乘1的C矩陣，最後將C矩陣的內容顯示出來。

            //Console.WriteLine("例題5.5 - 求2乘3的A矩陣乘以3乘1的B矩陣，結果存入2乘1的C矩陣，最後將C矩陣的內容顯示出來。");

            //int[,] A = new int[2, 3];
            //int[,] B = new int[3, 1];
            //int[,] C = new int[2, 1];

            //Console.WriteLine("矩陣A=");

            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    for (int k = 0; k < A.GetLength(1); k++)
            //    {
            //        Console.WriteLine($"A[{i},{k}]=");
            //        A[i, k] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("\n");
            //Console.WriteLine("矩陣B=");

            //for (int k = 0; k < B.GetLength(0); k++)
            //{
            //    for (int j = 0; j < B.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"B[{k},{j}]=");
            //        B[k, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("\n");
            //Console.WriteLine("矩陣C = 矩陣A x 矩陣B");


            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    for (int j = 0; j < B.GetLength(1); j++)
            //    {
            //        for (int k = 0; k < A.GetLength(1); k++)
            //        {
            //            C[i, j] += A[i, k] * B[k, j];
            //        }
            //    }
            //}


            //Console.Write($"矩陣C=");
            //foreach (int c in C)
            //{
            //    Console.Write($"{c}\t");
            //}

            //Console.ReadKey();

            //----------------------------------------------


            //5-1.寫一程式，將10個數字讀入A陣列，然後逐一檢查此陣列，如A[i] > 5，則令A[i] = A[i] - 5，否則A[i] = A[i] + 5。

            //Console.WriteLine("5-1.寫一程式，將10個數字讀入A陣列，然後逐一檢查此陣列，如A[i] > 5，則令A[i] = A[i] - 5，否則A[i] = A[i] + 5。 ");

            //int[] A = new int[10];

            //Console.WriteLine("將10個數字依序輸入A陣列");

            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.Write($"請輸入第{i + 1}個數字=");
            //    A[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine("原先輸入的A為以下數字");

            //foreach (int a in A) 
            //{
            //    Console.Write($"{a}\t");
            //}

            //Console.WriteLine("\n");
            //Console.WriteLine("如A[i] > 5，則令A[i] = A[i] - 5，否則A[i] = A[i] + 5");
            //Console.WriteLine("經過處理後為");

            //for (int i = 0; i < A.Length; i++)
            //{
            //    if (A[i] >5)
            //    {
            //        A[i] = A[i] - 5;
            //    }
            //    else
            //    {
            //        A[i] = A[i] + 5;
            //    }
            //}

            //foreach (int a in A)
            //{
            //    Console.Write($"{a}\t");
            //}


            //Console.ReadKey();

            //----------------------------------------------

            //5-2.寫一程式，將10個數字讀入A陣列，對每一個數字，令A[i] = A[i] + i。

            //Console.WriteLine("5-2.寫一程式，將10個數字讀入A陣列，對每一個數字，令A[i] = A[i] + i。 ");

            //int[] A = new int[10];

            //Console.WriteLine("將10個數字依序輸入A陣列");

            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.Write($"請輸入第{i + 1}個數字=");
            //    A[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine("原先輸入的A為以下數字");

            //foreach (int a in A)
            //{
            //    Console.Write($"{a}\t");
            //}

            //Console.WriteLine("\n");
            //Console.WriteLine("對每一個數字，令A[i] = A[i] + i。 (i=0開始, i++)");
            //Console.WriteLine("經過處理後為");

            //for (int i = 0; i < A.Length; i++)
            //{
            //    A[i] = A[i] + i;
            //}

            //foreach (int a in A)
            //{
            //    Console.Write($"{a}\t");
            //}


            //Console.ReadKey();

            //----------------------------------------------

            //5-3.寫一程式，將10個數字讀入A陣列，並建立一個B陣列，如A[i]≥0，令B[i] = 1，否則令B[i] = 0。

            //Console.WriteLine("5-3.寫一程式，將10個數字讀入A陣列，並建立一個B陣列，如A[i]>=0，令B[i] = 1，否則令B[i] = 0。 ");

            //int[] A = new int[10];
            //int[] B = new int[10];

            //Console.WriteLine("將10個數字依序輸入A陣列");

            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.Write($"請輸入第{i + 1}個數字=");
            //    A[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine("輸入的A為以下數字");

            //foreach (int a in A)
            //{
            //    Console.Write($"{a}\t");
            //}

            //Console.WriteLine("\n");
            //Console.WriteLine("將10個數字讀入A陣列，並建立一個B陣列，如A[i]≥0，令B[i] = 1，否則令B[i] = 0");

            //for (int i = 0; i < A.Length; i++)
            //{
            //    if (A[i] >= 0) {
            //        B[i] = 1;
            //    }
            //    else
            //    {
            //        B[i] = 0; 
            //    }
            //}

            //Console.WriteLine("經過處理後的B為以下數字");

            //foreach (int b in B)
            //{
            //    Console.Write($"{b}\t");
            //}


            //Console.ReadKey();

            //----------------------------------------------

            //5-4.寫一程式，將15數字存入3×5的二維陣列A中，求每一行及每一列數字的和。

            //Console.WriteLine("5-4.寫一程式，將15數字存入3×5的二維陣列A中，求每一行及每一列數字的和。 ");

            //int[,] A = new int[3, 5];

            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {
            //        Console.Write($"A[{i},{j}]=");
            //        A[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //// sun of row

            //Console.WriteLine("每個row的總和分別為");

            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    int sumRow = 0;
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {
            //        sumRow += A[i, j];
            //    }
            //    Console.WriteLine($"第 {i + 1} 行數字的和 = {sumRow}");
            //}

            ////sum of column 

            //Console.WriteLine("每個column的總和分別為");

            //for (int j = 0; j < A.GetLength(1); j++)
            //{
            //    int sumCol = 0;
            //    for (int i = 0; i < A.GetLength(0); i++)
            //    {
            //        sumCol += A[i, j];
            //    }
            //    Console.WriteLine($"第 {j + 1} 列的和：{sumCol}");
            //}


            //Console.ReadKey();

            //----------------------------------------------

            //5-5.寫一程式，將15數字存入3×5的二維陣列A中，求每一行及每一列數字的最小值。

            //Console.WriteLine("5-5.寫一程式，將15數字存入3×5的二維陣列A中，求每一行及每一列數字的最小值。 ");

            //int[,] A = new int[3, 5];

            //Console.WriteLine("請輸入3x5 陣列數字");

            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {
            //        Console.Write($"A[{i},{j}]=");
            //        A[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //    Console.WriteLine("\n");
            //}

            //// sun of row

            //Console.WriteLine("每個row的最小值分別為");

            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    int minRow = int.MaxValue;
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {
            //        if (A[i, j] < minRow)
            //        {

            //            minRow = A[i, j];
            //        }

            //    }
            //    Console.WriteLine($"第 {i + 1} 行數字的和 = {minRow}");
            //}

            ////sum of column 

            //Console.WriteLine("每個column的最小值分別為");

            //for (int j = 0; j < A.GetLength(1); j++)
            //{
            //    int minCol = int.MaxValue;
            //    for (int i = 0; i < A.GetLength(0); i++)
            //    {
            //        if (A[i, j] < minCol)
            //        {

            //            minCol = A[i, j];
            //        }
            //    }
            //    Console.WriteLine($"第 {j + 1} 列的和：{minCol}");
            //}


            //Console.ReadKey();


            //----------------------------------------------

            //5-6.寫一程式，輸入兩組數字：a1,a2,…,a5和b1,b2,…,b5。求ai + bi，i = 1到i = 5。

            //Console.WriteLine("5-6.寫一程式，輸入兩組數字：a1,a2,…,a5和b1,b2,…,b5。求ai + bi，i = 1到i = 5。 ");

            //int[] A = new int[5];
            //int[] B = new int[5];
            //int[] sumAB = new int[5];

            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.Write($"請輸入a{i+1}=");
            //    A[i] = Convert.ToInt32(Console.ReadLine());

            //}

            //Console.WriteLine("\n");

            //for (int i = 0; i < B.Length; i++)
            //{
            //    Console.Write($"請輸入b{i + 1}=");
            //    B[i] = Convert.ToInt32(Console.ReadLine());

            //}

            //for(int i = 0;i < sumAB.Length; i++)
            //{
            //    sumAB[i]= A[i] + B[i];
            //    Console.Write($"a{i+1}+b{i + 1}={A[i]}+{B[i]}={sumAB[i]}\n");
            //}

            //Console.ReadKey();


            //----------------------------------------------

            //5-7.寫一程式，輸入兩組數字： a1,a2,…,a5和b1,b2,…,b5。令x為a中的最大值，令y為b中的最大值，求x與y中較小者。

            //Console.WriteLine("5-7.寫一程式，輸入兩組數字： a1,a2,…,a5和b1,b2,…,b5。令x為a中的最大值，令y為b中的最大值，求x與y中較小者。 ");

            //int[] A = new int[5];
            //int[] B = new int[5];

            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.Write($"請輸入a{i + 1}=");
            //    A[i] = Convert.ToInt32(Console.ReadLine());

            //}

            //Console.WriteLine("\n");

            //for (int i = 0; i < B.Length; i++)
            //{
            //    Console.Write($"請輸入b{i + 1}=");
            //    B[i] = Convert.ToInt32(Console.ReadLine());

            //}

            //Console.WriteLine("令x為a中的最大值");

            //int x = int.MinValue;

            //for (int i = 0; i < A.Length; i++) {

            //    if (A[i] > x) { 
            //        x= A[i];
            //    }
            //}

            //Console.Write($"x為a中的最大值={x}");

            //Console.WriteLine("\n");

            //Console.WriteLine("令y為b中的最大值");

            //int y = int.MinValue;

            //for (int i = 0; i < B.Length; i++)
            //{

            //    if (A[i] > y)
            //    {
            //        y = B[i];
            //    }
            //}

            //Console.Write($"y為b中的最大值={y}");



            //Console.WriteLine("\n");

            //Console.WriteLine("求x與y中較小者");

            //if (x > y)
            //{
            //    Console.WriteLine($"x={x} > y={y}, y={y}較小");
            //}
            //else if (x == y)
            //{
            //    Console.WriteLine($"x={x} = y={y}, 兩者相等");

            //}
            //else
            //{
            //    Console.WriteLine($"x={x} < y={y}, x={x}較小");
            //}

            //Console.ReadKey();





        }
    }
}
