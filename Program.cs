void clear(){
    Console.Clear();
}

int Prompt(string message){
    Console.WriteLine(message);
    int a=Convert.ToInt32(Console.ReadLine());
    return a;
}

int sumDigit(int number){
    int sum=0;
    for(;number!=0;number=number/10){
        sum=sum+number%10;
    }
    return sum;
}

clear();
int number= Prompt("Введите число");
Console.WriteLine($"Сумма цифр в числе {number} равна {sumDigit(number)}");
