using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zaidimas.Template;

namespace Zaidimas.Iterator
{
    public class Swords : ICollection<Sword>
    {

        public int lenght = -1;
        Dictionary<int,Sword> swordDictionary = new Dictionary<int,Sword>();
        public IEnumerator<Sword> GetEnumerator()
        {
            return new SwordsIterator(swordDictionary);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(Sword item)
        {
            swordDictionary.Add(++lenght, item);
        }

        public void Clear()
        {
            for (int i = 0; i < lenght; i++)
            {
                swordDictionary.Remove(i);
            }
        }

        public bool Contains(Sword item)
        {
           return  swordDictionary.ContainsValue(item);
        }

        public void CopyTo(Sword[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Sword item)
        {

            foreach (var item1 in swordDictionary.Where(kvp => kvp.Value == item).ToList())
            {
               return swordDictionary.Remove(item1.Key);
            }

            return false;

        }

        public int Count { get; }
        public bool IsReadOnly { get; }
    }
}
