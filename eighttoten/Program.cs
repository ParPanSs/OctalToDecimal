using eighttoten;

Console.WriteLine("Lenght of array: ");
int lenght = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[lenght];
int sum = 0;

Translator translator = new Translator(numbers, sum);

translator.AddNumbers(numbers);

Console.WriteLine($"\nNumber in 10-system: {translator.Summator(numbers, sum)}");
