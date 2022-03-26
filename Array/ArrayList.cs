using System.Collections;

namespace DataStructures.Array
{
    public class ArrayList : DataStructures.Array.Array, IEnumerable
    {
        private int position;
        public int Count => position;
        public ArrayList(int DefaultSize = 2) : base(DefaultSize)
        {
            position = 0;
        }

        public ArrayList(IEnumerable collection) :this()
        {
            foreach (var item in collection)
            {
                Add(item);
            }
        }

        public void Add(Object value)
        {
            if (position == Lenght)
            {
                DoubleArray();
            }
            if (position < Lenght)
            {
                //InnerArray[position]=value;
                SetValue(position, value);
                position++;
                return;
            }
            throw new Exception();
        }

        private void DoubleArray()
        {
            try
            {
                var temp = new Object[InnerArray.Length * 2];
                System.Array.Copy(InnerArray, temp, InnerArray.Length);
                InnerArray = temp;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Object Remove()
        {
            if (position >= 0)
            {
                var temp = InnerArray[position - 1];
                position--;

                if (position == InnerArray.Length / 4)
                    HalfArray();
                return temp;
            }
            throw new Exception();
        }

        private void HalfArray()
        {
            try
            {
                var temp = new Object[InnerArray.Length / 2];
                System.Array.Copy(InnerArray, temp, InnerArray.Length / 2);
                InnerArray = temp;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        new public IEnumerator GetEnumerator()
        {
            return InnerArray.Take(position).GetEnumerator();
        }
    }
}