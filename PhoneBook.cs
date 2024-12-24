using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_2
{
    internal struct PhoneBook
    {
        string[] names;
        long[] numbers;
        int size;
        public int Size
        {
            get
            {
                return size;
            }
        }
        public PhoneBook(int _size)
        {
            this.size = _size;
            names = new string[size];
            numbers = new long[size];
        }
        public void AddPerson(int position, string name, long number)
        {
            if (this.names is not null && this.numbers is not null)
            {
                if (position >= 0 && position < size)
                {
                    this.names[position] = name;
                    this.numbers[position] = number;
                }
            }
        }
        public long GetNumber(string _name)
        {
            if (names is not null && numbers is not null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == _name)
                        return numbers[i];
                }
            }
            return -1;
        }
        public void SetNumber(string _name, long _number)
        {
            if (numbers != null && names != null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == _name)
                        numbers[i] = _number;
                }
            }
        }
        public long this[string _name]
        {
            get
            {
                if (names is not null && numbers is not null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i] == _name)
                            return numbers[i];
                    }
                }
                return -1;
            }
            set
            {
                if (names != null && numbers != null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i] == _name)
                            numbers[i]= value;
                    }
                }
            }
        }
    }
}
