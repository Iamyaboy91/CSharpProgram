string value = "bad";
int result = 0;
if(int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement (w/ offset) : {result}");
}
else
{
    Console.WriteLine($"Unable to report the measurement.{value}");

}

if(result > 0)
Console.WriteLine($"Measurement (w/ offset): {50 + result}");