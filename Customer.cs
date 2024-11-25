using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_13
{
    public class Customer
    {
        public void OnItemChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                foreach (Shop.Item newItem in e.NewItems)
                {
                    Console.WriteLine($"Добавлен товар: {newItem.Name}, ID: {newItem.Id}");
                }
            }
            else if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                foreach (Shop.Item oldItem in e.OldItems)
                {
                    Console.WriteLine($"Удален товар: {oldItem.Name}, ID: {oldItem.Id}");
                }
            }
        }
    }

}
