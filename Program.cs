using ДЗ_13;

class Program
{
    static void Main(string[] args)
    {
        Shop shop = new Shop();
        Customer customer = new Customer();
                
        shop.Items.CollectionChanged += customer.OnItemChanged;

        int idCounter = 1;
        while (true)
        {
            Console.WriteLine("Нажмите 'A' для добавления товара, 'D' для удаления товара, 'X' для выхода.");
            var key = Console.ReadKey(intercept: true).Key;

            if (key == ConsoleKey.A)
            {
                string itemName = $"Товар от {DateTime.Now}";
                shop.Add(new Shop.Item(idCounter++, itemName));
            }
            else if (key == ConsoleKey.D)
            {
                Console.Write("Введите ID товара для удаления: ");
                if (int.TryParse(Console.ReadLine(), out int itemId))
                {
                    shop.Remove(itemId);
                }
                else
                {
                    Console.WriteLine("Некорректный ввод ID.");
                }
            }
            else if (key == ConsoleKey.X)
            {
                Console.WriteLine("Выход из программы.");
                break;
            }
        }
    }
}

