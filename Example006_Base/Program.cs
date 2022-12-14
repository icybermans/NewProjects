int a = 5;
int b = 11;
int c = 5;
int d = 8;
int e = 3;

int max = a;
if(b > max)
{
    max = b;
}
else{
    if(c > max){
        max = c;
    }
    else{
        if(d > max){
            max = d;
        }
        else{
            if(e > max){
                max = e;
            }
        }
    }
}
Console.Write("Наибольшее число равно: " + max);