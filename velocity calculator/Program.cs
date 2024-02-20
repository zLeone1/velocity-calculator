using velocity_calculator;

Console.WriteLine("Final Velocity Calculator");


Console.Write("Enter the initial velocity (m/s): ");
double initialVelocity = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the acceleration (m/s^2): ");
double acceleration = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the time (s): ");
double time = Convert.ToDouble(Console.ReadLine());

FinalVelocityCalculator calculator = new FinalVelocityCalculator(initialVelocity, acceleration, time);
double finalVelocity = calculator.CalculateFinalVelocity();

Console.WriteLine($"The final velocity is: {finalVelocity} m/s");

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();