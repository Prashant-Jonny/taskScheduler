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
        public Dispatcher()
        {
            for (int i = 0; i < WaitLine.Length; i++)
            {
                WaitLine[i] = new List<Process>();
                AllTasksGrouped[i] = new List<Process>();
            }
        }
        public bool GenerateTasks { get; set; } = true;
        public Process CurProcess;
        public IList<Process> AllTasks = new BindingList<Process>();
        public IList<Process>[] AllTasksGrouped = new IList<Process>[MaxPriority]; 
        public static Random R = new Random();

        public IList<Process>[] WaitLine = new IList<Process>[MaxPriority]; 

        public int CurrentTick { get; private set; }
        public int Standby { get; private set; }

        public double TaskAdditionProbability { get; set; } = 0.9;
        public const int MaxPriority = 32;

        public delegate void UpdateProcesses(object sender, ProcessUpdateInfo args);

        public event UpdateProcesses UpdateStatus;

        public void RunTick()
        {
            if (!GenerateTasks && !WaitLine.Any(x => x.Any())) return;
            //Thread.Sleep(TickDuration);
            CurrentTick++;
            var newTask = TryAddTask();
            if (newTask != null)
            {
                WaitLine[newTask.Priority].Add(newTask);
                AllTasks.Add(newTask);
                AllTasksGrouped[newTask.Priority].Add(newTask);
            }
            if (!WaitLine.Any(x => x.Any()))
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
            foreach (var plist in WaitLine)
            {
                foreach (var p in plist)
                {
                    p.WaitTime++;
                }
            }
        }

        private void RefreshCurrentTask()
        {
            if (CurProcess == null)
            {
                CurProcess = WaitLine.First(x => x.Any()).First();
                foreach (var i in WaitLine)
                {
                    if (i.Any())
                    {
                        CurProcess = i.First();
                        break;
                    }
                }
            }

            CurProcess.ProgressInt++;
            if (CurProcess.ProgressInt >= CurProcess.TimeToSolve)
            {
                WaitLine[CurProcess.Priority].Remove(CurProcess);
                CurProcess = null;
            }
            else
            {
                CurProcess.WaitTime--;
            }
        }

        public int MinComplexity { get; set; } = 3;
        public int MaxComplexity { get; set; } = 10;
        private Process TryAddTask()
        {
            if (GenerateTasks && R.NextDouble() < TaskAdditionProbability)
            {
                var task = new Process(CurrentTick)
                {
                    Priority = R.Next(MaxPriority),
                    TimeToSolve = R.Next(MinComplexity, MaxComplexity),
                };
                return task;
            }
            return null;
        }
    }
}
