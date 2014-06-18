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
        public async Task<int> followers()
        {
            try
            {
                var github = new GitHubClient(new ProductHeaderValue("MyAmazingApp"));
                var user = await github.User.Get("half-ogre");
                Console.WriteLine(user.Followers + " folks love the half ogre!");
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
            }
            return 1;
        }

        static void Main(string[] args)
        {
            libgit.BasicCommands bc = new libgit.BasicCommands();
            var t = bc.followers("half-ogre");
            t.Wait();
            Console.WriteLine("followers : " + t.Result);
        }
    }
}
