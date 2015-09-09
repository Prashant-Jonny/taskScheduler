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
        public Process curProcess;
        public IList<Process> waitLine;
        public IList<Process> allTasks = new List<Process>();
        public static Random r = new Random();
        //public Dictionary<int,IList<Process>> plannedTasksAdditions

        public int CurrentTick { get; private set; }

        public const double TaskAdditionProbability = 0.1;
        public const int TickDuration = 500;
        public const int MaxTasks = 30;

        public Dispatcher()
        {
            waitLine = new List<Process>();
            for (int i = 0; i < MaxTasks / 2; i++)
            {
                var task = new Process(CurrentTick)
                {
                    TimeToSolve = r.Next(1, 5),
                };
                waitLine.Add(task);
                allTasks.Add(task);
            }
        }

        public void RunTick()
        {
            CurrentTick++;
            tryAddTask();
            if (curProcess == null)
            {
                curProcess = waitLine.First();
            }
            if (waitLine.Any())
            {
                Thread.Sleep(TickDuration);
                curProcess.Progress++;
                curProcess.WasUpdated = true;
                if (curProcess.Progress >= curProcess.TimeToSolve)
                {
                    waitLine.Remove(curProcess);
                    curProcess = null;
                }
                else
                {
                    curProcess.WaitTime--;
                }
                foreach(var p in waitLine)
                {
                    p.WaitTime++;
                    p.WasUpdated = true;
                }
            }
        }



        private void tryAddTask()
        {
            if (waitLine.Count < MaxTasks && r.NextDouble() < TaskAdditionProbability)
            {
                var task = new Process(CurrentTick)
                {
                    TimeToSolve = r.Next(1, 5),
                    WasUpdated = true
                };
                waitLine.Add(task);
                allTasks.Add(task);
            }
        }
    }
}
