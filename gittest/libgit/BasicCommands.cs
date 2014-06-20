using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octokit;

namespace libgit
{
    public class BasicCommands
    {
        public async Task<int> followers(String name)
        {
            try
            {
                var github = new GitHubClient(new ProductHeaderValue("asuapp"));
                var user = await github.User.Get(name);
                
                return user.Followers;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
            }
            return -1;
        }

    }
}
