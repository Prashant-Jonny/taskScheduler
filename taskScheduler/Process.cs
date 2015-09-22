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
        public int ProgressInt;      //progress on completion of task
        public int DeliveryTick { get; }       //tick on which task was delivered
        public string Progress => $"{(double)ProgressInt / TimeToSolve * 100:0.00}%";
        public string SolvedTime => (ProgressInt >= TimeToSolve) ? (TimeToSolve + DeliveryTick + WaitTime).ToString() : "-";

        //counter of how many ticks process has been awaiting since its arrival
        public int WaitTime { get; set; }
    }
}
