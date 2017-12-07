using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking;

namespace Person
{
    public class Client
    {

        public string Name { get; set; }
        public string lname { get; set; }
        public string email; 
        private string phoneNumber;
        public int pinCode;

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = Console.ReadLine();
                string[] mails = new string[] { "@mail.ru", "@list.ru", "bk.ru", "@gmail.com" }; 
                for(int i=0; i< mails.Length; i++)
                {
                    if(mails[i].Contains(email) == true)
                    {
                        Console.WriteLine("Майл введен корректно");
                    }
                    else
                    {
                        Console.WriteLine("Не правильный формат майла!");
                    }
                    
                }

                email = value;
            }
        }


        
    }
}
