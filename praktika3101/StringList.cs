using System;
namespace praktika3101
{
	public class StringList
	{

		
		public StringList(int size=0)
		{
			_values = new string[size];
		}

        public int Length => _values.Length;

        public string this [int index]
		{
			get => _values[index];
			set => _values[index] = value;
		}
		public void Add(string value)
		{
			Array.Resize(ref _values, _values.Length + 1);
			_values[_values.Length - 1] = value;
		}


		string[] _values;
		
	}
}

