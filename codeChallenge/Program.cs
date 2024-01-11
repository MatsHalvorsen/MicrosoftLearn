int speed = 10;
int distance = 0;

while (distance < 1000)
    {
        if (distance < 500)
        {
            speed += 10;
        }
        else if (distance == 500)
        {
            Console.WriteLine("car has driven 500m");
        }
        else if (distance >= 500 && speed > 10)
        {
            speed -= 10;
            Console.WriteLine("Slowing down");
        }
        distance += speed;
        Console.WriteLine($"Distance: {distance}m, Speed: {speed}s/m");
    }
    Console.WriteLine("car har reached the destination and parked");