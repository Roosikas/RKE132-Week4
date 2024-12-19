
Random rnd = new Random();
int cpuRandom;

bool loopActive = true;

while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    //Console.WriteLine($" cpu has generated {cpuRandom}.");
    Console.WriteLine("Make a quess. Enter a number1-3");
    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Congratulation, You won!");
        loopActive = false;
    }
    else
    {

        Console.WriteLine("Oops. Try agan!");

    }
}
Console.WriteLine("Have a nice day!");
