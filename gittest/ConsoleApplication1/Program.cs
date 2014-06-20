using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octokit;


namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            libgit.BasicCommands bc = new libgit.BasicCommands();
            var t = bc.followers("half-ogre");
            t.Wait();
            Console.WriteLine("followers : " + t.Result);
        }
    }
}
