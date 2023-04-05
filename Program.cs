
using PolymorphismDemo;

public class Program
{
    public static void Main()
    {
        Doctor doctor = new Doctor();
        doctor.Operations("Heart Surgery");


        Arithmatic arithmatic = new Arithmatic();
        arithmatic.Add();
        arithmatic.Add(10);
        arithmatic.Add(10, 20);
        arithmatic.Add(10.5F, 20.5F);
        arithmatic.Add(10.5F, 20);
        arithmatic.Add(10, 20.5F);



        Child child = new Child();
        child.Show();
        child.Show(10);

        Parent parent = new Parent();
        parent.Show();
    }
}