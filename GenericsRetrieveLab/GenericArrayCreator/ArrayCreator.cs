namespace GenericArrayCreator
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ArrayCreator
    {

        public static T[] Create<T>(int lenght, T item)
        {
            var data = new T[lenght];

            for (int i = 0; i < data.Length - 1; i++)
            {
                data[i] = item;
            }

            return data;
        }
    }
}
