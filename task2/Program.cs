
var per1=new Account(1,300);
var per2=new Account(2,600);
per1.TransferTo(100,per2);
System.Console.WriteLine(per1.ToString());
per2.TransferTo(100,per1);
System.Console.WriteLine(per2.ToString());







//------------------------------------//
public class Account{
    int number;
    decimal balance;
     public Account(int num)
    {
     number=num ;  
    }
    public Account(int num ,decimal balanc)
    {
       number=num;
       balance=balanc; 
    }
    public int GetNumber { get{return number;} }
    public decimal GetBalance { get{return balance;} }
    public string ToString(){
          return $"Account [number = {number}, balance = {balance}]";
    }
       public void Credit(decimal amount)
    {
        balance += amount;
    }
     public void Debit(decimal amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
        }else
        {
            System.Console.WriteLine("Amount exceeded");
        }
    }
     public void TransferTo(decimal amount, Account another)
    {
        if ( balance >= amount )
        {
            balance -= amount;
            another.Credit(amount);
        }
        else
        {
            System.Console.WriteLine("Amount exceeded");
        }
    }
}