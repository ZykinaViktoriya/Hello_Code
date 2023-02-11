//Вид 1: Ничего не принимают,ничего не возвращают

void Method1()
{
    System.Console.WriteLine("Автор - Зыкина Виктория");
}
//Method1();



//Вид 2: Что-то принимают, ничего не возвращают

// void Method2(string msg);
// {
//     System.Console.WriteLine(msg);
// }
// Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}   
Method21(msg: "Текст", count: 4);



//Вид 3: Ничего не принимают, что то возвращают

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
System.Console.WriteLine(year);



// Вид 4: Что то принимают, что то возвращают

string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;

    while(i<count)
    {
        result = result + c;
        i++;
    }
    return result;
}
string res = Method4(10, "asdf");
System.Console.WriteLine(res);