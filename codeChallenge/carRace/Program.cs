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
        Console.WriteLine("you reached 500m.");
    }
    else if (distance >= 500 && speed > 10)
    {
        speed -= 10;
        Console.WriteLine("slowing down");
    }
    distance += speed;
    Console.WriteLine($"Distance: {distance}, Speed: {speed}");
}
Console.WriteLine("car has reached 1000m and is parked.");