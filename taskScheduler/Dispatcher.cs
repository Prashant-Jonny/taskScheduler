using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace taskScheduler
{
    public class Dispatcher
    {
        public IList<Process> waitLine;
        public IList<Process> allTasks;
        public static Random r = new Random();
        //public Dictionary<int,IList<Process>> plannedTasksAdditions

        public int CurrentTick { get; private set; }

        public const double TaskAdditionProbability = 0.01;
        public const int TickDuration = 500;
        public const int MaxTasks = 30;

        public void RunTick()
        {
            tryAddTask();
            if (waitLine.Any())
            {
                var task = waitLine.First();
                Thread.Sleep(TickDuration);
                task.Progress++;
                if (task.Progress == task.SolveTime)
                {
                    waitLine.RemoveAt(0);
                }
                foreach(var p in waitLine)
                {
                    p.SolveTime++;
                }
            }
        }



        private void tryAddTask()
        {
            if (waitLine.Count < MaxTasks && r.NextDouble() < TaskAdditionProbability)
            {
                var task = new Process(CurrentTick)
                {
                    SolveTime = r.Next(1, 5),
                };
                waitLine.Add(task);
                allTasks.Add(task);
            }
        }
    }
}
