;string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);

string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";
string quantity = "";
string output = "";

// Your work here
int startPosition = input.IndexOf("<div>");
output = input.Remove(startPosition, 5);

int endPosition = output.IndexOf("</div>");
output = output.Remove(endPosition, 6);

output = output.Replace("&trade", "&reg");

int openingPosition = input.IndexOf("<span>");
int closingPosition = input.IndexOf("</span>");

openingPosition += 6;
int length = closingPosition - openingPosition;

quantity = input.Substring(openingPosition, length);



Console.WriteLine("Quantity: {0}", quantity);
Console.WriteLine(output);
