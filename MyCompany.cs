using System;

class MyCompany
{
    static void Main(string[] args)
    {
        Console.Write("What is you company name?  ");
        string companyName = Console.ReadLine();

        Console.Write("What is the adress of your company?  ");
        string companyAdress = Console.ReadLine();

        Console.Write("What is you company phone number?  ");
        string companyPhone = Console.ReadLine();

        Console.Write("What is your company fax number?  ");
        string companyFax = Console.ReadLine();

        Console.Write("What is yor company web page?  ");
        string companyWebPage = Console.ReadLine();

        Console.Write("What is yor company manager's first name?  ");
        string managerFirstName = Console.ReadLine();

        Console.Write("What is yor company manager's last name?  ");
        string managerLastName = Console.ReadLine();

        Console.Write("How old is your company manager? ");
        string managerAge = Console.ReadLine();

        Console.Write("What is your company manager's phone number? ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("\tYour company's name is {0}. The adress of the company is {1}, with phone number {2}." +
                          "The fax number of your company is {3}, and the web page is {4}. The manager's name is {5} {6}," +
                          "and he is using phone number {7}. The manager is {8} years old.", companyName, companyAdress, companyPhone,
                            companyFax, companyWebPage, managerFirstName, managerLastName, managerPhone, managerAge);

    }
}

