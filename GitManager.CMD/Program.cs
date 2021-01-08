using System;
using LibGit2Sharp;
using LibGit2Sharp.Handlers;

namespace GitManager.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入要查找的路径：");
            var path = Console.ReadLine();

            var repoPath = Repository.Discover(path);
            var repo = new Repository(repoPath);
            
            
            Console.WriteLine(repo.Info.Message);
            Console.ReadKey();
        }
    }
}
