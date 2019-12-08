using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Zaidimas.Iterator;
using Zaidimas.Template;

namespace Zaidimas
{
    public class KnifeList : IEnumerable
    {
        private List<Knife> knifes = new List<Knife>();


        public void AddKnife(int level, int damage, string name)
        {
            var tempKnife = new Knife(level, damage, name);
            knifes.Add(tempKnife);
        }

        public void AddKnife(Knife k)
        {
            knifes.Add(k);
        }

        public void RemoveKnife(Knife knife)
        {
            knifes.Remove(knife);
        }

        public List<Knife> getKnifes()
        {
            return knifes;

        }

        //public KnifeList GetEnumertorKnifes()
        //{
        //    yield return this;
        //}

        //public IEnumerator GetEnumerator()
        //{
        //    foreach (Knife knife in knifes)
        //    {
        //        yield return knife;
        //    }
        //}

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) GetEnumerator();
        }

        public KnifeIterator GetEnumerator()
        {
            return new KnifeIterator(knifes);
        }
    }

}
