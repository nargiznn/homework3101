﻿using System;
using System.Runtime;

namespace praktika3101
{
    internal class MyList<T> 
    {
        T[] _values;

        public MyList(int size = 0)
        {
            _values = new T[size];
        }

        public int Length => _values.Length;

        public T this[int index]
        {
            get => _values[index];
            set => _values[index] = value;
        }

        public void Add(T value)
        {
            Array.Resize(ref _values, _values.Length + 1);
            _values[_values.Length - 1] = value;
        }
    }
}

