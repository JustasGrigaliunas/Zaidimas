using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Zaidimas.Template;

namespace Zaidimas.Iterator
{
    public class KnifeIterator : IEnumerator<Knife>
    {

        public List<Knife> kn = new List<Knife>();
        int position = -1;
        private object _current;
        private Knife _current1;

        public KnifeIterator(List<Knife> kn)
        {
            this.kn = kn;
        }

        public bool MoveNext()
        {
            position++;
            
            return (position < kn.Count);
        }

        public void Reset()
        {
            position = -1;
        }

        //Knife IEnumerator<Knife>.Current => _current1;

        //object IEnumerator.Current => _current;

        //public Knife Current()
        //{
        //    return kn[position];
        //}


        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Knife Current
        {
            get
            {
                try
                {
                    return kn[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
  


        

}
