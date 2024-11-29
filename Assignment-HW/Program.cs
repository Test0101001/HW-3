using System.Collections;

class Student
{
    public string Id { get; set; }
    public string Name { get; set; }
    public double Mark { get; set; }

    public Student(string id, string name, double mark)
    {
        Id = id;
        Name = name;
        Mark = mark;
    }
}

class UserAccount
{
    public string Email { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }

    public UserAccount(string email, string username, string password)
    {
        Email = email;
        Username = username;
        Password = password;
    }

    public UserAccount(UserAccount account)
    {
        Email = account.Email;
        Username = account.Username;
        Password = account.Password;
    }
}

class Pograme
{
    static void Main(string[] args)
    {
        // Q1-HW

        //List<Student> students = new List<Student>();
        //int numberOfStudents;
        //Console.WriteLine("Enter the number of students :");
        //numberOfStudents = int.Parse(Console.ReadLine());
        //for (int i = 0; i < numberOfStudents; i++) 
        //{
        //    Console.WriteLine("Enter Details for student {0}",i+1);
        //    Console.Write("ID: ");
        //    string id = Console.ReadLine();
        //    Console.Write("Name: ");
        //    string name = Console.ReadLine();
        //    Console.Write("Mark: ");
        //    double mark = double.Parse(Console.ReadLine());
        //    students.Add(new Student(id, name, mark));
        //}

        //Console.WriteLine("Students who passed");
        //foreach (Student student in students)
        //{
        //    if(student.Mark >= 50)
        //        Console.WriteLine(student.Name);
        //}


        // Q2-HW

            //ArrayList accounts = new ArrayList();

            //accounts.Add(new UserAccount("user1@example.com", "user1", "password1"));
            //accounts.Add(new UserAccount("user2@example.com", "user2", "password2"));

            //Console.WriteLine("Enter username:");
            //string inputUsername = Console.ReadLine();
            //Console.WriteLine("Enter password:");
            //string inputPassword = Console.ReadLine();

            //bool validCredentials = false;

            //foreach (UserAccount account in accounts)
            //{
            //    if (account.Username == inputUsername && account.Password == inputPassword)
            //    {
            //        validCredentials = true;
            //        Console.WriteLine("Correct credentials!");
            //        break;
            //    }
            //}

            //if (!validCredentials)
            //{
            //    Console.WriteLine("Invalid credentials!");
            //}


        }
    }