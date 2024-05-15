string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

openingPosition += 1;
// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);
int Length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, Length));

string message2 = "what is the value <span>between the tags</span>?";

int openingPosition2 = message2.IndexOf("<span>");
int closingPosition2 = message2.IndexOf("</span>");

openingPosition2 += 6;
int Length2 = closingPosition2 - openingPosition2;
Console.WriteLine(message2.Substring(openingPosition2, Length2));

string message3 = "what is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closingSpan = "</span>";

int openingPosition3 = message3.IndexOf(openSpan);
int closingPosition3 = message3.IndexOf(closingSpan);

openingPosition3 += openSpan.Length;
int length3 = closingPosition3 - openingPosition3;


Console.WriteLine(message3.Substring(openingPosition3, length3));