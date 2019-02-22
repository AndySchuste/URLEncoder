using System;

namespace URLEncoder
{
    class Program
    {
        static bool flag = false;
        static void Main(string[] args)
        {
            do
            {
                string project_name = "";
                string activity_name = "";

                try
                {
                    Console.WriteLine("Enter the Project name");
                    project_name = Console.ReadLine();

                    Console.WriteLine("Enter the Activity name");
                    activity_name = Console.ReadLine();

                    Console.WriteLine("Here is your URL:");
                    string url = "https://companyserver.com/content/" + project_name + "/files/" + activity_name + "/" + activity_name + "Report.pdf";
                    Console.WriteLine("\n");
                    Console.WriteLine(url);

                }
                catch
                {
                    Console.WriteLine("PLease enter vaild details");
                }
                Console.WriteLine("\n");
                Console.WriteLine("Do you want another URL say y/n");
                char res = Convert.ToChar(Console.ReadLine());
                if (res == 'y')
                {
                    flag = true;
                }
            } while (flag == true);
        }
    }
}
