string[] arr = { "hello", "2", "world", ":-)" };
string[] newArr = new string[arr.Length];
int i = 0;
int number = 3;

foreach (string str in arr)
{
    if (str.Length <= number)
    {
        newArr[i] = str;
        i++;
    }
}

var str1 = string.Join(" " ,newArr);
System.Console.WriteLine("[ " + str1 + "]");
System.Console.WriteLine(newArr[1]);