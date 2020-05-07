using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    abstract class MovieAbstract
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; }

        public Movie(string Title, string Category, int RunTime, List<string> Scenes)
        {
            Title = Title;
            Category = Category;
            RunTime = RunTime;
            Scenes = Scenes;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Movie:    {Title}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Runtime:  {RunTime}");
            Console.WriteLine();
            PrintScenes();
        }

        public void PrintScenes()
        {
            int sceneIndex = 0;
            foreach (string scene in Scenes)
            {
                sceneIndex++;
                Console.WriteLine(scene);
                Console.WriteLine(sceneIndex);
            }

        }

        public virtual void Play()
        {
           

           
        }



    }
}
