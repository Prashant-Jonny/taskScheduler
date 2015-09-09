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
        public IList<Process> waitLine = new List<Process>();
        public IList<Process> allTasks = new List<Process>();
        public static Random r = new Random();

        public int CurrentTick { get; private set; }
        public int Standby { get; private set; }

        public const double TaskAdditionProbability = 0.25;
        public const int TickDuration = 500;
        public const int MaxTasks = 30;

        public void RunTick()
        {
            CurrentTick++;
            tryAddTask();
            Thread.Sleep(TickDuration);

            if (!waitLine.Any())
            {
                Standby++;
                return;
            }
            RefreshCurrentTask();
            UpdateTasksInQueue();
        }

        private void UpdateTasksInQueue()
        {
            foreach (var p in waitLine)
            {
                p.WaitTime++;
                p.WasUpdated = true;
            }
        }

        private void RefreshCurrentTask()
        {
            if (curProcess == null)
            {
                curProcess = waitLine.First();
            }

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
        }

        private void tryAddTask()
        {
            if (//allTasks.Count < 24 &&
                waitLine.Count < MaxTasks && r.NextDouble() < TaskAdditionProbability)
            {
                var task = new Process(CurrentTick)
                {
                    TimeToSolve = r.Next(3, 10),
                    WasUpdated = true
                };
                waitLine.Add(task);
                allTasks.Add(task);
            }
        }
    }
}
