Console.Clear();

string[] str = {"hello","2","world",":-)"};
string[] result = ArrayCreate(str);
Console.Write($"{String.Join(" ",result)}");

string[] ArrayCreate(string[] stroka)
{
    int count = 0;
    int i = 0;
    int resultSize = 0;
    int len = 3;

    while (count < stroka.Length)
    {
        if (stroka[count].Length <= len)
        {
            resultSize++;
        }
        count++;
    }

    count = 0;
    string [] res = new string[resultSize];

    while (count < stroka.Length)
    {
        if (stroka[count].Length <= len)
        {
            res[i] = stroka[count];
            i++;
        }
        count++;
    }
    return res;
}
