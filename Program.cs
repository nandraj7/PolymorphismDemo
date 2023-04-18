

using PolymorphismDemo;
using System.Security.Claims;


 public class Parent
{
    public int Id { get; set; }
    public  string Name { get; set; }


    //Default/Paremeterless Constructor
    public Parent()
    {
        this.Id = 1;
        this.Name = "Amit";
        Console.WriteLine("Default Constructor Called");
    }


    //Paremeterized Constructor
    public Parent(int id, string name)
    {
        Id = id;
        Name = name;
        Console.WriteLine("Parameterized Constructor Called");
    }

    public Parent(string name, int id)
    {
        this.Id = id;
        this.Name = name;
        Console.WriteLine("Parameterized Constructor Called");
    }

    public void Show()
    {

    }

    public void Show(int a,int b)
    {

    }

}



public class Program
{
    public static void Main()
    {
        Parent p = new Parent();
        p.Show();
        p.Show(10, 20);

        Parent p2 = new Parent(2, "Vihay");

        Parent p3 = new Parent("Kiran", 3);

      
    }
}








#region
//public class Parent
//{
//    public void Show() 
//    {
//        Console.WriteLine("Parent Class Show Method");    
//    }
//    public void Show(int a, int b)
//    {
//        Console.WriteLine("Parent Class Show Method");
//    }
//    public virtual void Display() 
//    {
//        Console.WriteLine("Parent Class Display Method");
//    }
//    public void Putdata() 
//    {
//        Console.WriteLine("Parent Class Putdata Method");
//    }
//}


//public class Child : Parent
//{
//    public void Show(int a)     //Method OverLoading
//    {
//        Console.WriteLine("Child Class Show Method");
//    }
//    public override void Display()     //Method Overriding
//    {
//        Console.WriteLine("Child Class Display Method");

//        Parent p = new Parent();
//        p.Display();    //Calling To Parent Class Methods
//        p.Putdata();    //Calling To Parent Class Methods

//    }

//     public new void Putdata()    //Method Hiding
//    {
//        Console.WriteLine("Child Class Putdata Method");

//        base.Display();     //Calling To Parent Class Method
//        base.Putdata();     //Calling To Parent Class Method
//    }
//}

//public class Program
//{

//    public static void Main()
//    {
//        Child c = new Child(); 
//        c.Show();       //Parent Class Show Method
//        c.Show(10);     //Child Class Show Method
//        c.Display();    //Child Class Display Method
//        c.Putdata();    //Child Class Putdata Method


//        Parent p = new Parent();
//        p.Show();       //Parent Class Show Method 
//        p.Show(10, 20);
//        p.Display();    //Parent Class Display Methods
//        p.Putdata();    //Parent Class Putdata Methods

//        //p.Show(10);   //Invalid
//        Parent parent;
//        Child child;

//        parent = c;
//        //child = p;      //Invalid

//        parent.Display();   //Child Class Method
//        parent.Putdata();   //Child Class Method 

//    }
//}

#endregion










#region
//public class Program
//{
//public static void Main()
//{
//Doctor doctor = new Doctor();
//doctor.Operations("Heart Surgery");


//Arithmatic arithmatic = new Arithmatic();
//arithmatic.Add();
//arithmatic.Add(10);
//arithmatic.Add(10, 20);
//arithmatic.Add(10.5F, 20.5F);
//arithmatic.Add(10.5F, 20);
//arithmatic.Add(10, 20.5F);


//Parent parent = new Parent();

//Child child = new Child();

//Parent P;
//Child C;

//P = parent;
//C = child;

//P = child;





//child.Show();       //Parent Class Show Method 
//child.Show(10);     //Child Class Show Method

//child.Display();        //Parent Class Display Method


//parent.Show();       //Parent Class Show Method 
//parent.Display();    //Parent Class Show Method 

//parent.PutData();       // Parent Class PutData Method

//child.PutData();        // Child Class PutData Method

//}
//}
#endregion