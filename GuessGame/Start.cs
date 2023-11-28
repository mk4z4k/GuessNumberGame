namespace GuessGame;

public class Start
{

    private int _number;
    public void Run()
    {
        while (true)
        {
            Console.WriteLine("Играем? Y/N");
            var yn = Console.ReadLine();
            if (yn.ToLower() != "y")
                break;
            StartGame();
        }
    }

    private void StartGame()
    {
        SetValue();
        int entered = 0;
        int attemptCnt = 0;
        while (entered != _number)
        {
            Console.WriteLine("Введите число: ");
            try
            {
                entered = Int32.Parse(Console.ReadLine());
                attemptCnt++;
                if (entered > _number)
                    Console.WriteLine("Меньше!");
                else if (entered < _number)
                    Console.WriteLine("Больше!");
                else
                {
                    Console.WriteLine($"Отгадано за {attemptCnt} попыток! Спасибо за игру!");
                    return;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Пожалуйста, введите число!");
            }
            
        }
        
    }
    private void SetValue()
    {
        Random rnd = new Random();
        _number = rnd.Next(1, 100);
    }
}