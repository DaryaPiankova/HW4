void clear(){
    Console.Clear();    
}


int [] setArr(){
    
    Console.WriteLine("Введите количество учеников");
int number= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите рост учеников ");
int [] arr=new int[number];
for(int i=0; i<number; i++){
    arr[i]=Convert.ToInt32(Console.ReadLine());
    }
string s1 = string.Join(", ", arr);
Console.WriteLine("Массив из роста учеников: " + s1);
return arr;

}

int count(int [] arr){
    Console.WriteLine("Введите рост Пети ");
int Petya= Convert.ToInt32(Console.ReadLine());

for(int j=0; j<arr.Length; j++){
        if(Petya>arr[j]){
            return j+1;
        }
    }
    return 0;
}


clear();
int[] arr;
arr=setArr();
Console.WriteLine(count(arr));