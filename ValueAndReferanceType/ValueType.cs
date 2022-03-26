namespace ValueAndReferanceType
{
    public struct ValueType
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Swap(int X,int Y)
        {
            var temp = X;
            X = Y;
            Y = temp;
        }

    }
   
}