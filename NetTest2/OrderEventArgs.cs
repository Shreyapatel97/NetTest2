namespace NetTest2
{
    public class OrderEventArgs : EventArgs
    {


        public string PrdName { get; set; }

        public OrderEventArgs(string prodName)
        {
            PrdName = prodName;
        }
    }
}