using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class DVD : MovieAbstract
    {
        public DVD(string Title, string Category, int RunTime, List<string> Scenes)
            : base(Title, Category, RunTime, Scenes)
        {

        }

        public override void Play()
        {
            Console.Write("What scene would you like to watch? ");

            int index = 0;
            bool run = true;
            while (run)
            {
                string input = Console.ReadLine();

             
            }



            Console.WriteLine(Scenes[index - 1]);
        }
    }
}
