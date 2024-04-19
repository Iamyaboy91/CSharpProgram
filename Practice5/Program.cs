int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
foreach (int number in numbers)
{
    total += number;

    if (number == 42)
    {
       Console.WriteLine("Set contains 42");
    }

}
Console.WriteLine($"Total: {total}");
/* This is one possible solution from microsoft learn.
but my opinion is that this code is quite readable.

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;
    if (number == 42)
        found = true;
}

if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");
 */