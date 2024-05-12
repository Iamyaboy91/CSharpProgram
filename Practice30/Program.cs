string pangram = "The quick brown fox jumps over the lazy dog";
// step 1
string[] message = pangram.Split(' ');
// step 2
string[] newMessage = new string[message.Length];

// step 3
for (int i = 0; i <message.Length; i++)
{
char[] letters = message[i].ToCharArray();
Array.Reverse(letters);
newMessage[i] = new string(letters);
}

// step 4
string result = String.Join(" ", newMessage);
Console.WriteLine(result);