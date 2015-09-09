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
        public int SolveTime { get; set; }
        public int Progress { get; set; }
        public int DeliveryTick { get; private set; }

        //counter of how many ticks process has been awaiting since its arrival
        public int WaitTime { get; set; }
    }
}
