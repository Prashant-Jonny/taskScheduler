namespace taskScheduler
{
    public class Process
    {
        public static int CreatedProcesses { get; set; }
        public Process(int deliveryTick)
        {
            Id = CreatedProcesses;
            DeliveryTick = deliveryTick;
            CreatedProcesses++;
        }
        public int Id { get; private set; }
        public int TimeToSolve { get; set; }   //time it takes to complete task
        public int Progress { get; set; }      //progress on completion of task
        public int DeliveryTick { get; }       //tick on which task was delivered

        public int SolvedTime() => TimeToSolve + DeliveryTick + WaitTime; //counter of how many ticks process has been awaiting since its arrival
        public int WaitTime { get; set; }
        public string ProcessStatus() => $"{(double)Progress / TimeToSolve * 100:0.00}%";
    }
}
