Console.Write("Стоимость покупки: ");
double cost = double.Parse (Console.ReadLine());
double discount = 0;

if (cost > 1000 && cost < 2000) discount = 0.05;
else if (cost > 2000 && cost < 5000) discount = 0.10;

Console.WriteLine ($"Скидка: {discount * 100}%");
Console.WriteLine($"Итог: {cost - cost * discount}");