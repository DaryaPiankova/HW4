Console.Clear();
Console.WriteLine("Введите количество учеников");
int number= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите рост учеников ");
int [] arr=new int[number];
for(int i=0; i<number; i++){
    arr[i]=Convert.ToInt32(Console.ReadLine());
}

string s1 = string.Join(", ", arr);
Console.WriteLine("Массив из роста учеников: " + s1);
Console.WriteLine("Введите рост Пети ");
int Petya= Convert.ToInt32(Console.ReadLine());

for(int j=0; j<arr.Length; j++){
    if(Petya>arr[j]){
        Console.WriteLine(j+1);
        j=arr.Length-1;
    }
}
