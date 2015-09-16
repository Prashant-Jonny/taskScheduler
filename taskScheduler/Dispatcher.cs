using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace taskScheduler
{
    public class Dispatcher
    {
        public Process CurProcess;
        public IList<Process> WaitLine = new List<Process>();
        public IList<Process> AllTasks = new BindingList<Process>();
        public static Random R = new Random();

        public int CurrentTick { get; private set; }
        public int Standby { get; private set; }

        public const double TaskAdditionProbability = 0.5;
        public const int TickDuration = 500;
        public const int MaxTasks = 30;

        public void RunTick()
        {
            CurrentTick++;
            TryAddTask();
            Thread.Sleep(TickDuration);

            if (!WaitLine.Any())
            {
                Standby++;
                return;
            }
            RefreshCurrentTask();
            UpdateTasksInQueue();
        }

        private void UpdateTasksInQueue()
        {
            foreach (var p in WaitLine)
            {
                p.WaitTime++;
            }
        }

        private void RefreshCurrentTask()
        {
            if (CurProcess == null)
            {
                CurProcess = WaitLine.First();
            }

            CurProcess.Progress++;
            if (CurProcess.Progress >= CurProcess.TimeToSolve)
            {
                WaitLine.Remove(CurProcess);
                CurProcess = null;
            }
            else
            {
                CurProcess.WaitTime--;
            }
        }

        private void TryAddTask()
        {
            if (//allTasks.Count < 24 &&
                WaitLine.Count < MaxTasks && R.NextDouble() < TaskAdditionProbability)
            {
                var task = new Process(CurrentTick)
                {
                    TimeToSolve = R.Next(3, 10),
                };
                WaitLine.Add(task);
                AllTasks.Add(task);
            }
        }
    }
}
