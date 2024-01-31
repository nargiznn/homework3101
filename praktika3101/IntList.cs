using System;
namespace praktika3101
{
	public class IntList
	{
		public IntList(int size=0)
		{
			_values = new int[size];
		}
		int[] _values;
        public int Length => _values.Length;
        public int this[int index]
		{
			get => _values[index];
			set => _values[index] = value;
		}
		public void Add(int value)
		{
			Array.Resize(ref _values, _values.Length + 1);
			_values[_values.Length - 1] = value;
		}

	}
}

