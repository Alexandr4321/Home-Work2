//1
/*
void Stepen(int numA , int numB)
{
    int sum=numA;
    for (int i = 2; i <= numB; i++)
    {
        sum *= numA;
    }
    Console.WriteLine($"ответ: {sum}");
}
Console.Write("число: ");
int user_numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("степень: ");
int user_numberB = Convert.ToInt32(Console.ReadLine());

if(user_numberA<0 && user_numberB<0)
{
    Console.Write("Error");
}
else Stepen(user_numberA, user_numberB);
*/



//2
/*
void SummNumber(int numberA)
{
    int i=1;
    int sum=0;
    while(numberA>=i)
    {
        sum+=(numberA/i)%10;
        i=i*10;
    }
    Console.WriteLine(sum);
}
Console.Write("число: ");
int user_numberA = Convert.ToInt32(Console.ReadLine());
if(user_numberA>0)
SummNumber(user_numberA);
else Console.WriteLine("Error");
*/


//3
int [] NewArray (int size_array , int numberA , int numberB)
{
    int [] randomArray= new int[size_array];
    for (int i = 0; i < size_array; i++)
    {
        randomArray [i] = new Random().Next (numberA, numberB+1);
    }
    return randomArray;
}

void ShowCreatedArray (int [] array01)
{
    for (int i = 0; i < array01.Length; i++)
    Console.Write (array01[i] + " ");
}
Console.Write("длина: ");
int user_numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("от: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("до: ");
int numB = Convert.ToInt32(Console.ReadLine());

if(user_numberA>0)
{
    NewArray (user_numberA, numA, numB);
    ShowCreatedArray(NewArray(user_numberA, numA, numB));
}
else Console.WriteLine("Error");
