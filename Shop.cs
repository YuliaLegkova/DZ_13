using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_13
{
    public class Shop
    {
        public class Item
        {
            public int Id 
            { 
                get; 
                set; 
            }
            public string Name 
            { 
                get;
                set; 
            }

            public Item(int id, string name)
            {
                Id = id;
                Name = name;
            }
        }
        public ObservableCollection<Item> Items { get; private set; }

        public Shop()
        {
            Items = new ObservableCollection<Item>();
        }

        public void Add(Item item)
        {
            Items.Add(item);
        }
        public void Remove(int itemId)
        {
            var item = Items.FirstOrDefault(i => i.Id == itemId);
            if (item != null)
            {
                Items.Remove(item);
            }
            else
            {
                Console.WriteLine($"Товар с Id {itemId} не найден.");
            }
        }
     }
}
