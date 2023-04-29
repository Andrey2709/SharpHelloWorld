// See https://aka.ms/new-console-template for more information




// Задача 2
using System;

int a1 = 5, b1 = 7; 
int a2 = 2, b2 = 10; 
int a3 = -9, b3 = -3; 
int max;

int Max (int x, int y){
    if (x>y){
        max = x;
    }else {
        max = y;
    }
    return max;
}

Console.WriteLine(Max(a1,b1));
Console.WriteLine(Max(a2,b2));
Console.WriteLine(Max(a3,b3));


//Задача 4

int e1 = 2, q1 = 3, f1 =7; 
int e2 = 44, q2 = 5, f2 =78; 
int e3 = 22, q3 = 3, f3 =9; 

int Max4 (int x, int y,int z){
    if (x>y&&x>z){
        max = x;
    }else if(y>x&&y>z){
        max = y;
    }else{
        max = z;
    
    } 
    return max;
}

Console.WriteLine(Max4(e1,q1,f1));
Console.WriteLine(Max4(e2 , q2 , f2 ));
Console.WriteLine(Max4(e3, q3, f3));


//Задача 6

int c =4,v=-3,n=7;

Boolean A(int x){

if((x%2)>1){
   return false; 
}

return true;
}

Console.WriteLine(A(c));
Console.WriteLine(A(v));
Console.WriteLine(A(n));


//Задача 8
int o  =5,m=8;

 static void B(int x){

int max = x;
    for(int i = 1;i<=max;i++){
        if((i%2)==0){
            Console.Write(i+" ");
        }
    }
    Console.WriteLine(" ");


}

B(o);
B(m);
