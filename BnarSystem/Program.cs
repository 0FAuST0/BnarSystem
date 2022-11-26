// See https://aka.ms/new-console-template for more information
int startNumber = Convert.ToInt32(Console.ReadLine());
int processNumber = 0;
int processNumberInt = 0;
string numberIs2 = "";
for (; startNumber > 0;)
{

    processNumberInt = startNumber / 2;
    processNumber = startNumber % 2;
    string bufer = processNumber.ToString();
    numberIs2 += bufe;
    startNumber = processNumberInt;

}
char[] chars = numberIs2.ToCharArray();
int i = numberIs2.Length-1;
foreach (char coll in numberIs2)
{
    chars[i] = coll;
     i--;   
}

Console.WriteLine(numberIs2);
Console.WriteLine(chars);
Console.Write(chars);

