/*var list = new List<int>{1,3,4,8,4,7};
var sum=0;
foreach (var index in list)
{
    sum+=index;
}
System.Console.WriteLine(sum);
var list2=new List<string>{"Hello ","word"};
var sums="";
foreach (var it in list2)
{
    sums+=it;
}
System.Console.WriteLine(sums);
//=----------------------------------------------------//
var list3 =new List<DateTime>();
var tim1=new DateTime(2023,02,01);
var tim2=new DateTime(2023,12,03);
var tim3=new DateTime(2023,10,23);
list3.Add(tim1);
list3.Add(tim2);
list3.Add(tim3);
//---------------------------------------------------------------//

var list4 =new List<double>(){1.2,3.5,6.7,2.1,5.4};
var summ=0d;
foreach (var index in list4)
{
    summ+=index;
}
System.Console.WriteLine(summ);

var list5 = new List<int>{1,3,2,8,4,7};
var juft=0;
foreach (var item in list5)
{
   if (item%2==0) {
    System.Console.WriteLine(item);
   }
}

var list6=new List<bool>{true,false,true};
int s=0;
foreach (var ims in list6)
{
    if(ims==false){
        s++;
    }
}
if(s==0){
    System.Console.WriteLine("Are all the values in the list true?   allTrue");
}*/


var list7=new List<int>();
var ran=new Random();

for (int i = 0; i < 6; i++)
{
    list7.Add(ran.Next(20));
}
foreach (var itemm in list7)
{
   System.Console.WriteLine(itemm); 
}





    





