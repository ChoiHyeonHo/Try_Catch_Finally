using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0924
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BBB();
                AAA();
                string eee = Console.ReadLine();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private static void BBB()
        {
            AAA();
        }

        static void AAA()
        {
            //try
            //{
                int[] arr = new int[5] { 1, 2, 0, 4, 5 };
                Console.WriteLine("몇번째 배열의 값으로 계산할까요?");
                int idx = int.Parse(Console.ReadLine());

                if (idx < 0 || idx > 4)
                {
                    throw new ApplicationException("0~4의 수를 입력하세요");
                }

                int p = arr[idx];
                int k = 10 / p;
                Console.WriteLine(k);
            //}

            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("0으로 나눌 수 없습니다.");
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("0~4 범위 안의 수를 입력하세요.");
            //}
            //catch (Exception err) //보험. 작은 범위의 catch문부터 위로 둔다. 위의 두개는 순서 상관 없음.
            //{
            //    throw err;
            //}
        }
    }
}
