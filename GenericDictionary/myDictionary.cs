using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDictionary
{
    class myDictionary<T, U>
    {
        T[] _key;
        T[] _tempKey;
        U[] _value;
        U[] _tempValue;

        public myDictionary()
        {
            _key = new T[0];
            _value = new U[0];
        }

        public void Add(T key, U value)
        {
            _tempKey = _key;
            _tempValue = _value;
            _key = new T[_key.Length + 1];
            for (int i = 0; i < _tempKey.Length; i++)
            {
                _key[i] = _tempKey[i];
            }
            _value = new U[_value.Length + 1];
            for (int i = 0; i < _tempValue.Length; i++)
            {
                _value[i] = _tempValue[i];
            }
            _key[_key.Length - 1] = key;
            _value[_value.Length - 1] = value;
        }
        public int Length
        {
            get
            {
                return _key.Length;
            }
        }
        public T[] Keys
        {
            get
            {
                return _key;
            }
        }
        public U[] Values
        {
            get
            {
                return _value;
            }
        }
    }
}
