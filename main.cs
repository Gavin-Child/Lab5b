using System;

class MainClass {
  public static void Main (string[] args) {
    int counter = 0;
    double average = 0;

    Console.WriteLine("How many cars are in the race?");
    int cars = Convert.ToInt32(Console.ReadLine());

    while(counter < cars)
    {
      counter ++;
      Console.WriteLine("Enter distance covered by Car " + counter);
      double dist = Convert.ToDouble(Console.ReadLine());

     // Console.WriteLine(dist);

      Console.WriteLine("Enter time taken by Car " + counter);

      double time = Convert.ToDouble(Console.ReadLine());
      double speed = dist/time;

      Console.WriteLine("The speed of this car is " + speed + " miles per hour");

      average = average + speed;
      
    }

    Console.WriteLine ("The average speed of the cars is " + (average / counter) + " miles per hour");

  }
}