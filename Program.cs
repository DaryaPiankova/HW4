Console.Clear();
Console.WriteLine("Введите число A");
int a= Convert.ToInt32(Console.ReadLine());
int sum=0;
for(;a!=0;a=a/10){
sum=sum+a%10;
}
Console.WriteLine(sum);