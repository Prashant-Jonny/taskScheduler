namespace taskScheduler
{
    public class Process
    {
        public static int createdProcesses { get; set; }



        public Process(int deliveryTick)
        {
            Id = createdProcesses;
            createdProcesses++;
        }
        public int Id { get; private set; }
        public int TimeToSolve { get; set; }            //time it takes to complete task
        public int Progress { get; set; }             //progress on completion of task
        public int DeliveryTick { get; private set; } //tick on which task was delivered
        public bool WasUpdated { get; set; }

        public int SolvedTime() => TimeToSolve + DeliveryTick + WaitTime;

        //counter of how many ticks process has been awaiting since its arrival
        public int WaitTime { get; set; }
    }
}
