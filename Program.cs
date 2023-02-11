void clear()
{
    Console.Clear();
}

int inputA(){
Console.WriteLine("Введите число A");
int a= Convert.ToInt32(Console.ReadLine());
return a;
}
int inputB(){
Console.WriteLine("Введите число B");
int b= Convert.ToInt32(Console.ReadLine());
return b;
}
void res(int a,int b){
int result=a;
for(int i=0; i<b-1; i++){
        result=result*a;
    }
Console.WriteLine(result);
}

bool check(int b){
    if(b<0){
        Console.WriteLine("Степень не может быть отриц.");
        return false;
    }
    return true;
    
}

clear();
int a=inputA();
int b=inputB();
if(check(b)){
res(a,b);
}

