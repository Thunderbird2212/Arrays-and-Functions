// ВозврвщаемыйТипДанных ИмяМетода([ТипДанных1 ИмяАргумента1,...])
//{
//    Тело Метода
//    return ЗначениеСоответствующееВозвращаемомуТипуДанных
//}
// 1-й Метод Ничего не принимает и ничего не возвращает.
void Method1()
{
    Console.WriteLine("Author Kirill Romanov");
}
//Вызов Метода
//Method1();

// 2-й Метод Принимает аргументы но ничего не возвращает.
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Message Text");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("Message Text", 4); неименованные аргументы
//Method21(count: 4, msg: "New Message"); //именованные аргументы

// 3-й Метод Ничего не принимает но что-то возвращает.
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);

//4-й Метод что-то принимает и что-то возвращает.
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(12, "Bullshit");
Console.WriteLine(res);