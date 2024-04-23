string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}
for (int j = 0; j < 10; j++)
{
    Console.WriteLine(j);
    if (j == 6)
    break;
}
