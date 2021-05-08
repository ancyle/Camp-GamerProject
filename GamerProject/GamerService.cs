using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GamerProject
{
    public class GamerService : IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Gamer \"{0}\" Joined Us.", gamer.FirstName);
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer \"{0}\" Updated his/her Details.", gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer \"{0}\" Deleted from System.", gamer.FirstName);
        }
        public bool Validate(Gamer gamer)
        {
            Regex reg = new Regex("^[0-9]");
            if (gamer.TcNo.Length == 11 && reg.IsMatch(gamer.TcNo))
            {
                DateTime date;
                if(DateTime.TryParse(gamer.DateBirth.ToString(), out date))
                {
                    if (!string.IsNullOrEmpty(gamer.FirstName) && !string.IsNullOrEmpty(gamer.LastName))
                    {
                        Console.WriteLine("Gamer validation success.");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Gamer validation failed. Check your <FirstName-LastName>");
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("Gamer validation failed. Check your <BirthDate>");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Gamer validation failed. Check your <TC>");
                return false;
            }
        }
    }
}
