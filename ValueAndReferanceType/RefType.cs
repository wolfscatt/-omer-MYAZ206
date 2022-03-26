namespace ValueAndReferanceType
{
    public class RefType
    {
        public int X { get; set; }
        public int Y { get; set; }
        public void Swap(ref int X, ref int Y)
        {
            var temp = X;
            X = Y;
            Y = temp;
        }
        public void CheckOut(out int x)
        {
            x = 53;
            return;
        }


    }
   
}