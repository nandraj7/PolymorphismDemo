
using PolymorphismDemo;
using System.Security.Claims;

public class Program
{
    public static void Main()
    {
        //Doctor doctor = new Doctor();
        //doctor.Operations("Heart Surgery");


        //Arithmatic arithmatic = new Arithmatic();
        //arithmatic.Add();
        //arithmatic.Add(10);
        //arithmatic.Add(10, 20);
        //arithmatic.Add(10.5F, 20.5F);
        //arithmatic.Add(10.5F, 20);
        //arithmatic.Add(10, 20.5F);


        Parent parent = new Parent();

        Child child = new Child();

        Parent P;
        Child C;

        P = parent;
        C = child;

        P = child;












        child.Show();       //Parent Class Show Method 
        child.Show(10);     //Child Class Show Method

        child.Display();        //Parent Class Display Method

       
        parent.Show();       //Parent Class Show Method 
        parent.Display();    //Parent Class Show Method 

        parent.PutData();       // Parent Class PutData Method

        child.PutData();        // Child Class PutData Method

    }
}