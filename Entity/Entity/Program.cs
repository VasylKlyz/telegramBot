using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Users users = new Users())
            {
                Console.WriteLine(users.channelNames.First().ChannelName);
                foreach (var item in users.User)
                {
                    Console.WriteLine(item.FirstName);
                }
                Console.ReadLine();
            }
        }
    }
}
