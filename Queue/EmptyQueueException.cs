namespace DataStructures.Queue
{
    public class EmptyQueueException : Exception
    {
        private string msg;
        public EmptyQueueException(string message = "Queue is Empty") :base(message)
        {

        }
    }
}