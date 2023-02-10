Console.Clear();
Console.WriteLine("Введите число A");
int a= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B");
int b= Convert.ToInt32(Console.ReadLine());

int result=a;
for(int i=0; i<b-1; i++){
    result=result*a;
}
Console.WriteLine(result);