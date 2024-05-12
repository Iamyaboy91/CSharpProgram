/*
TryParse() の使用
TryParse() メソッドでは、いくつかの処理が同時に行われます。

指定された数値データ型に文字列を解析することが試行されます。
成功した場合は、変換された値を out パラメーターに格納してください。これについては、次のセクションで説明します。
これにより、アクションが成功したか、失敗したかを示す bool 値が返されます。
*/

string name = "Bob";
Console.WriteLine(int.TryParse(name, out int n));
/*変換が失敗したため、ブール値が返される*/
Console.WriteLine("");

string value = "102";
int result = 0;
if(int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}else
{
    Console.WriteLine("Unable to report the measurement.");
}
Console.WriteLine($"Measurement (w/ offset): {50 + result}");
Console.ReadLine();