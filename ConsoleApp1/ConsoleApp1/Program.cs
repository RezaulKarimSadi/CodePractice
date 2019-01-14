using System;

public struct book
{
    public int id;
    public string bookName;
    public string author;

    public void getValues(int i,string b,string a)
    {
        id = i;
        bookName = b;
        author = a;

    }

    public void display()
    {
        Console.WriteLine("book id {0} is : ",id);
        Console.WriteLine("bookname is {0} : ",bookName);
        Console.WriteLine("author is {0} : ",author);
    }
};




namespace ConsoleApp1
{



    class Test
    {
        private int id;
        private int age;
        private string name;

        public void make(int i, int a, string n)
        {
            id = i;
            age = a;
            name = n;
        }
        public int getAge()
        {
            return age;
        }

    }










    class Program
    {
        static void Main(string[] args)
        {

            book b = new book();

            Test t = new Test();

            t.make(1, 23, "sadi");
            Console.WriteLine(t.getAge());

            b.getValues(1, "python 3", "michael john");
            b.display();
            Console.ReadKey();
        }
    }
}
