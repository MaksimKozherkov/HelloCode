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
string Method4(int count, string text)//Метод который что то принимает и что то возвращает
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

string res = Method4(10, "asdf");
//Console.WriteLine(res);