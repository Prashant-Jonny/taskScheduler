using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace taskScheduler
{
    public class ProcessUpdateInfo : EventArgs
    {
        public IList<Process> AllTasks { get; set; } 
        public Process NewTask { get; set; }

    }
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


        public delegate void UpdateProcesses(object sender, ProcessUpdateInfo args);

        public event UpdateProcesses UpdateStatus;

        public void RunTick()
        {
            Thread.Sleep(TickDuration);
            CurrentTick++;
            var newTask = TryAddTask();
            if (newTask != null)
            {
                //AllTasks.Add(newTask);
                WaitLine.Add(newTask);
            }
            if (!WaitLine.Any())
            {
                Standby++;
                return;
            }
            RefreshCurrentTask();
            UpdateTasksInQueue();

            if (UpdateStatus != null)
            {
                var i = new ProcessUpdateInfo
                {
                    AllTasks = AllTasks,
                    NewTask = newTask,
                };
                UpdateStatus(this, i);
            }
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

            CurProcess.ProgressInt++;
            if (CurProcess.ProgressInt >= CurProcess.TimeToSolve)
            {
                WaitLine.Remove(CurProcess);
                CurProcess = null;
            }
            else
            {
                CurProcess.WaitTime--;
            }
        }

        private Process TryAddTask()
        {
            if (//allTasks.Count < 24 &&
                WaitLine.Count < MaxTasks && R.NextDouble() < TaskAdditionProbability)
            {
                var task = new Process(CurrentTick)
                {
                    TimeToSolve = R.Next(3, 10),
                };
                return task;
                //AllTasks.Add(task);
            }
            return null;
        }
    }
}
