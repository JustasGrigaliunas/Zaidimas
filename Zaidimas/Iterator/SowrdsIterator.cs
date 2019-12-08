using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;using Zaidimas.Template;

namespace Zaidimas.Iterator
{
    public class SwordsIterator : IEnumerator<Sword>
    {
        public Dictionary<int,Sword> kn;
        int position = -1;

        public SwordsIterator(Dictionary< int, Sword> kn)
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



        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Sword Current
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
