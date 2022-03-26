using System.Collections;

namespace DataStructures.Array
{
    public class Array : ICloneable , IEnumerable
    {
        protected Object[] InnerArray { get; set; }
        public int Lenght => InnerArray.Length;

        public Array(int defaultSize=16)
        {
            InnerArray = new Object[defaultSize];  // Fixed size - Diziler sabit boyutludur.
        }

        public Array(params Object[] sourceArray) : this(sourceArray.Length)
        {
            //System Array üzerinden Copy metodu ile de yapılabilir

            System.Array.Copy(sourceArray,InnerArray,sourceArray.Length);

            /*
            for (int i = 0; i < sourceArray.Length; i++)
            {
                InnerArray[i] = sourceArray[i];
            }
            */
        }
        public void SetValue( int index, Object value)
        {
            if (!(index >= 0 && index < InnerArray.Length))
                throw new ArgumentOutOfRangeException();

            if (value == null)
                throw new ArgumentNullException();

            InnerArray[index] = value;
        }
        public Object GetValue(int index)
        {
            if (!(index>=0 && index <InnerArray.Length))           
                throw new ArgumentOutOfRangeException();
            
            return InnerArray[index];
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public IEnumerator GetEnumerator()
        {
            //return InnerArray.GetEnumerator();
            return new CustomArrayEnumerator(InnerArray);
        }
       

        public int IndexOf(Object value)
        {
            for (int i = 0; i < InnerArray.Length; i++)
            {
                if (GetValue(i).Equals(value))
                    return i;
            }
            return -1;  // O(n) lik bir maliyet vardır
        }
    }
}