using ListOfMovies.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfMovies.DAL
{
    public static class DataGeneric<T>
    {
        public static T[] arrObj;

        public static T[] CreateArr(int size)
        {
            arrObj = new T[size];
            return arrObj;
        }
    }

}
