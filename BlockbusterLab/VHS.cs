using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class VHS : MovieAbstract
    {
        public int CurrentTime { get; set; } = 0;

        public VHS(string title, enum genre, int runtime, List<string> scenes, int currentTime) : base(title, genre, runtime, scenes)
        {
            CurrentTime = currentTime;
        }



    public override void Play()
        {
            string scene = Scenes[CurrentTime];
            Console.WriteLine(scene);
            CurrentTime++;

        }

        public void Rewind()
        {
            CurrentTime = 0;
        }

        //
        //public int CurrentTime { get; set; }

        //public VHS(string Title, string Category, int RunTime, List<string> Scenes)
        //    : base(Title, Category, RunTime, Scenes)
        //{

        //}


        //public override void Play()
        //{
        //    if (CurrentTime == Scenes.Count)
        //    {
        //        Rewind();
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine($"Now playing scene {CurrentTime + 1} - Scenes[CurrentTime]");
        //    CurrentTime++;
        //}

        //public void Rewind()
        //{
        //    CurrentTime = 0;
        //}

    }
}
