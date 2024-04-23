using System;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // 入力された文字列を1行読み込む
            var str = Console.ReadLine(); 

            // 入力された整数（int型）を読み込む
            var numInt;
              int.Parse(Console.ReadLine());

            // 入力された小数（float型）を読み込む
            var numFloat = float.Parse(Console.ReadLine());

            // 変数strを出力
            Console.WriteLine(str);

            // 変数numIntを出力
            Console.WriteLine(numInt);

            // 変数numFloatを出力
            Console.WriteLine(numFloat);
        }
    }
}