using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOtusDictionary
{
    public class OtusDictionary
    {
        private Item[] _items;
        public string this[int i] => _items[i].Value;
        public OtusDictionary()
        {
            _items = new Item[32];
        }

        public void Add(int key, string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(value);
            }
            var item = new Item(key, value);
            var index = Math.Abs(key % _items.Length);
            if (_items[index].Value == null)
            {
                _items[index] = item;
            }
            else
            {
                if (_items[index].Key == key)
                {
                    throw new ArithmeticException("Одинаковые ключи");
                }
                var newItems = new Item[_items.Length * 2];
                foreach (var pairItem in _items)
                {
                    if (pairItem.Key == null) continue;
                    var newIndex = Math.Abs(pairItem.Key % newItems.Length);
                    newItems[newIndex] = pairItem;
                }
                _items = newItems;
                Add(key, value);
            }

        }

        public string? Get(int key)
        {
            try
            {
                foreach (var item in _items)
                {
                    if (item.Key == key)
                    {
                        return item.Value;
                    }
                }
                throw new Exception("Такого ключа нет в коллекции");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }

    public struct Item
    {
        public readonly int Key;
        public readonly string Value;

        public Item(int key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}
