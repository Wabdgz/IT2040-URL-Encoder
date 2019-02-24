using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLEncoder
{
    class Program
    {
        static string urlFormatString = "https://companyserver.com/content/{0}/files/{1}/{1}Report.pdf";

        static bool Valid(string input)
        {
            foreach (char character in input.ToCharArray())
            {
                if (character == 0x1F)
                {
                    return (true);
                }
                else return (false);
            }   
        }
        static void GetInput(string input)
        {
            
            do
            {
                input = Console.ReadLine();
                if (Valid(input)== true)
                Console.Write("The input contains invalid characters. Enter again:");
            } while (Valid(input)== true);
        }
        static string CreateURL(string projname, string actname)
        {
          string url =  String.Format(urlFormatString(projname, actname));
            return url;
        }

     
        static void Main(string[] args)
        {
             Console.WriteLine("URL Encoder");

            do
            {
                Console.Write("\nProject name: ");
                string projectname = Console.ReadLine();
                    GetInput(projectname);
                Console.Write("Activity name: ");
                string activityname = Console.ReadLine();
                    GetInput(activityname);

                Console.WriteLine(CreateURL(projectname, activityname));

                Console.WriteLine("Would you like to do another? (y/n): ");
            } while (Console.ReadLine().ToLower().Equals("y"));

        }
        
    }
