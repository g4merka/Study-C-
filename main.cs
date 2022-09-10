using System;

class Program {
  public static void Main (string[] args) {
      Console.Write("Введите своё имя: "); //предложение ввода имени
      string? name = Console.ReadLine(); //знак "?" указывает, что переменная может также хранить значение null
      Console.WriteLine($"Привет {name}"); //вывод имени в консоль
      
  }
}