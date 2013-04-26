using System;
    class CompanyInformation
    {
        static void Main()
        {
            Console.WriteLine("======== Company Information =========");
            Console.Write("Name: ");
            string CompanyName = Console.ReadLine();
            Console.Write("Address: ");
            string CompanyAddress = Console.ReadLine();
            Console.Write("Phone: ");
            string CompanyPhone = Console.ReadLine();
            Console.Write("Fax: ");
            string CompanyFax = Console.ReadLine();
            Console.WriteLine("======== Manager Information =========");
            Console.Write("First Name: ");
            string FirstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string LastName = Console.ReadLine();
            Console.Write("Age: ");
            string Age = Console.ReadLine();
            Console.Write("Manager Phone: ");
            string ManagerPhone = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Company Name: {0}",CompanyName);
            Console.WriteLine("Company Address: {0}",CompanyAddress);
            Console.WriteLine("Company Phone: {0}",CompanyPhone);
            Console.WriteLine("Company Fax: {0}",CompanyFax);
            Console.WriteLine("Manager Name: {0} {1}",FirstName,LastName);
            Console.WriteLine("Manager age: {0}",Age);
            Console.WriteLine("Manager phone: ",ManagerPhone);
        }
    }
