using System;

    class FruitPriceList
    {
        private string[] _names;
        private int[] _prices;
        private int _count;

        public FruitPriceList(int capacity)
        {
            _names = new string[capacity];
            _prices = new int[capacity];
            _count = 0;
        }

        public int Count => _count;

        public void Add(string name, int price)
        {
            if (_count < _names.Length)
            {
                _names[_count] = name;
                _prices[_count] = price;
                _count++;
            }
            else
            {
                Console.WriteLine("가격표가 가득 찼습니다.");
            }
        }
        public int this[string name]
        {
            get
            {
                for (int i = 0; i < _count; i++)
                {
                    if (_names[i] == name) return _prices[i];
                }
                return -1;
            }
        }

        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= _count) return "";
                return _names[index];
            }
        }
    }
