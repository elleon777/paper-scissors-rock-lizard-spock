enum PSRLS
{

  Камень = 1,
  Ножницы,
  Бумага,
  Ящерица,
  Спок,
}

class Program
{
  public static void Main(string[] args)
  {
    Console.WriteLine("Камень-Ножницы-Бумага");
    while (true)
    {
      Console.WriteLine("1: Камень");
      Console.WriteLine("2: Ножницы");
      Console.WriteLine("3: Бумага");
      Console.WriteLine("4: Ящерица");
      Console.WriteLine("5: Спок");
      Console.WriteLine("0: Выход из игры");

      PSRLS userChoice = GetUserChoice();

      if (userChoice == 0)
      {
        Console.WriteLine("Пока");
        break;
      }
      PSRLS computerChoice = GetComputerChoice();

      Console.WriteLine();
      Console.WriteLine($"Ваш выбор: {GetChoiceName(userChoice)}");
      Console.WriteLine($"Выбор компьютера: {GetChoiceName(computerChoice)}");
      Console.WriteLine();

      DetermineWinner(userChoice, computerChoice);
    }

    static PSRLS GetUserChoice()
    {
      PSRLS choice;
      while (true)
      {
        if (Enum.TryParse(Console.ReadLine(), out choice))
        {
          return choice;
        }
        else
        {
          Console.WriteLine("Введите корректное число");
        };
      }
    }

    static PSRLS GetComputerChoice()
    {
      Random random = new Random();
      int randomNumber = random.Next(1, 6);
      PSRLS computerChoice = (PSRLS)randomNumber;
      return computerChoice;
    }

    static string GetChoiceName(PSRLS choice)
    {
      switch (choice)
      {
        case PSRLS.Камень:
          return "Камень";
        case PSRLS.Ножницы:
          return "Ножницы";
        case PSRLS.Бумага:
          return "Бумага";
        case PSRLS.Ящерица:
          return "Ящерица";
        case PSRLS.Спок:
          return "Спок";
        default:
          return "Неизвестное число";
      }
    }

    static void DetermineWinner(PSRLS userChoice, PSRLS computerChoice)
    {
      if (userChoice == computerChoice)
      {
        Console.WriteLine("Ничья");
      }
      else if ((userChoice == PSRLS.Камень && computerChoice == PSRLS.Ножницы) ||
              (userChoice == PSRLS.Камень && computerChoice == PSRLS.Ящерица) ||
              (userChoice == PSRLS.Ножницы && computerChoice == PSRLS.Бумага) ||
              (userChoice == PSRLS.Ножницы && computerChoice == PSRLS.Бумага) ||
              (userChoice == PSRLS.Бумага && computerChoice == PSRLS.Камень) ||
              (userChoice == PSRLS.Бумага && computerChoice == PSRLS.Камень) ||
              (userChoice == PSRLS.Ящерица && computerChoice == PSRLS.Спок) ||
              (userChoice == PSRLS.Ящерица && computerChoice == PSRLS.Бумага) ||
              (userChoice == PSRLS.Спок && computerChoice == PSRLS.Камень) ||
              (userChoice == PSRLS.Спок && computerChoice == PSRLS.Ножницы))
      {
        Console.WriteLine("Вы победили!");
      }
      else
      {
        Console.WriteLine("Вы проиграли :(");
      }
    }

  }
}

