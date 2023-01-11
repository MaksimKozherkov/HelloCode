//Вид 1
void Method1()//Метод который ни чего не возвращает и ни чего не принимает
{
    Console.WriteLine("Автор ФИО");
}
//Method1();//Так вызываются данные методы











//Вид 2
void Method2(string msg)//Метод который ни чего не возвращает,но может принимать какие то аргументы
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Текст", count: 4);
//Method21(count: 4, msg: "новый текст");







//Вид 3

int Method3()//Метод который что то возвращает но ничего не принимает
{
    return DateTime.Now.Year;//обязательно используем return
}

int year = Method3();
//Console.WriteLine(year);










//Вид 4
// string Method4(int count, string text)//Метод который что то принимает и что то возвращает
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

string Method4(int count, string text)//Метод который что то принимает и что то возвращает
{ 
    string result = String.Empty;
    for(int i = 0; i < count; i++)//for вместо while, for компанует все условия цикла
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "asdf");
//Console.WriteLine(res);

//Вид 4 Цикл в цикле(таблица умножения)
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
//}


//Работа с текстом
//Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

// Ясна ли задача?

string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винцегероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";


//string s = "qwerty"
//            012
// s[3] // r

string Replace(string text, char oldValue, char newValue)//Replace это то как мы назвали метод
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);