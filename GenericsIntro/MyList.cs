using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //T - type
    {
        T[] items;
        //constructor - bir dizinin new lendiği zaman çalışdığı bloğa denir
        public MyList()
        {
            items = new T[0];
        }

        
        public void Add(T item)
        {
            T[] tempArray = items;//tempArray - gecicidizi yani
            //new lendiği zaman elemamanlar kaybolmasın diye tempArray e aktarıyoruz
            items = new T[items.Length+1];//dizinin eleman sayısını bir arttırır

            /*items = tempArray;  items[tempArray.Length + 1] = item;*/ //kendim yazdım 
           
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }

        public int Length
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }
    }
}
