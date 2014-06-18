using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octokit;

namespace PortableClassLibrary1
{
    public class libgit
    {
        async Task<int> followers()
        {
            try
            {
                var github = new GitHubClient(new ProductHeaderValue("MyAmazingApp"));
                var user = await github.User.Get("half-ogre");
                return user.Followers;
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
            }
            return 0;
        }
    }
}
