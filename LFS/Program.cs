
bool isContinue = true;
string students = "";
do
{
    Console.WriteLine("Dersde olan telebenin adini giriniz");
    string fullName = Console.ReadLine();
    students=students+fullName+"\n";
    Console.WriteLine("Derse basqa telebe varmi? (h/y)");
    char result = char.Parse(Console.ReadLine());
    if (result == 'h' || result == 'H')
    {
        isContinue = true;
    }
    else {
        isContinue = false;
    }



} while (isContinue);
Console.WriteLine("Dersde olan telebler");
Console.WriteLine(students);
