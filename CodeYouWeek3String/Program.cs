System.String[] myString;
myString = new System.String[5];

myString[0] = "Hello";
myString[1] = "How";
myString[2] = "Are";
myString[3] = "You";
myString[4] = "Doing?";

foreach (string words in myString)
{
    System.Console.WriteLine(words);
}
