while (true)
{
    Console.Clear();
    int[,] myArray_1 = new int[5, 5];
    int[,] myArray_2 = new int[5, 5];
    int[,] draft_1 = new int[5, 5];
    int[,] draft_2 = new int[5, 5];
    string player_1, player_2;
    uint ship_1 = 3, ship_2 = 3;

    Console.WriteLine("Игра марской бой без визуала так что\n0=пустая ячейка\n1=корабль\n2=промах\n3=подбитый корабль");
    Console.Write("Игрок номер 1 введите свое имя:\t");
    player_1 = Console.ReadLine();
    Console.Write("Теперь игрок номер 2 введите свое имя:\t");
    player_2 = Console.ReadLine();
    Console.WriteLine("Поле игры 4Х4");
    Console.Clear();
    Console.WriteLine($"{player_1} назначьте три коробля по двум координатам");
    for (int i = 1; i <= 3; i++)
    {
        Console.Write($"Введите первую координату коробля номер {i}:\t");
        int y;
        if (int.TryParse(Console.ReadLine(), out y))
        {
            if (y > 0 && y <= 4)
            {
                Console.Write($"Теперь введите вторую координату коробля номер {i}:\t");
                int x;
                if (int.TryParse(Console.ReadLine(), out x))
                {
                    if (x > 0 && x <= 4)
                    {
                        if (myArray_1[y, x] == 1)
                        {
                            Console.WriteLine("Тут уже есть корабль");
                            i--;
                        }
                        else
                        {
                            myArray_1[y, x] = 1;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Предел карты 4Х4");
                        i--;
                    }
                }
                else
                {
                    Console.WriteLine("Это не число");
                    i--;
                }
            }
            else
            {
                Console.WriteLine("Предел карты 4Х4");
                i--;
            }
        }
        else
        {
            Console.WriteLine("Это не число");
            i--;
        }
        Console.WriteLine();
    }
    for (int i = 1; i <= 4; i++)
    {
        for (int d = 1; d <= 4; d++)
        {
            Console.Write(myArray_1[i, d] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    Console.ReadLine();
    Console.Clear();
    //aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaЭТАП2aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
    Console.WriteLine($"{player_2} назначьте три коробля по двум координатам");
    for (int i = 1; i <= 3; i++)
    {
        Console.Write($"Введите первую координату коробля номер {i}:\t");
        int y;
        if (int.TryParse(Console.ReadLine(), out y))
        {
            if (y > 0 && y <= 4)
            {
                Console.Write($"Теперь введите вторую координату коробля номер {i}:\t");
                int x;
                if (int.TryParse(Console.ReadLine(), out x))
                {
                    if (x > 0 && x <= 4)
                    {
                        if (myArray_2[y, x] == 1)
                        {
                            Console.WriteLine("Тут уже есть корабль");
                            i--;
                        }
                        else
                        {
                            myArray_2[y, x] = 1;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Предел карты 4Х4");
                        i--;
                    }
                }
                else
                {
                    Console.WriteLine("Это не число");
                    i--;
                }
            }
            else
            {
                Console.WriteLine("Предел карты 4Х4");
                i--;
            }
        }
        else
        {
            Console.WriteLine("Это не число");
            i--;
        }
        Console.WriteLine();
    }
    for (int i = 1; i <= 4; i++)
    {
        for (int d = 1; d <= 4; d++)
        {
            Console.Write(myArray_2[i, d] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    Console.ReadLine();
    Console.Clear();
    //aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaGAMEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
    Console.WriteLine("Что ж теперь время битвы");
    for (int i = 1; i <= 16; i++)
    {
        Console.WriteLine($"{player_1} ваш выстрел ");
        for (int q = 1; q <= 4; q++)
        {
            for (int s = 1; s <= 4; s++)
            {
                Console.Write(draft_1[q, s] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        Console.Write($"Введите первую координату выстрела:\t");
        int y;
        if (int.TryParse(Console.ReadLine(), out y))
        {
            if (y > 0 && y <= 4)
            {
                Console.Write($"Введите вторую координату выстрела:\t");
                int x;
                if (int.TryParse(Console.ReadLine(), out x))
                {
                    if (x > 0 && x <= 4)
                    {
                        if (myArray_2[y, x] == 0)
                        {
                            Console.WriteLine("Тут нет корабля");
                            myArray_2[y, x] = 2;
                            draft_1[y, x] = 2;
                        }
                        else if (myArray_2[y, x] == 1)
                        {
                            Console.WriteLine($"{player_1} попал у {player_2} осталось {--ship_2} коробля");
                            myArray_2[y, x] = 3;
                            draft_1[y, x] = 3;
                            if (ship_2 == 0)
                                break;
                        }
                        else
                            Console.WriteLine("Сюда уже проводился выстрел");
                    }
                    else
                    {
                        Console.WriteLine("Предел карты 4Х4");
                        i--;
                    }
                }
                else
                {
                    Console.WriteLine("Это не число");
                    i--;
                }
            }
            else
            {
                Console.WriteLine("Предел карты 4Х4");
                i--;
            }
        }
        else
        {
            Console.WriteLine("Это не число");
            i--;
        }
        Console.WriteLine();
        for (int q = 1; q <= 4; q++)
        {
            for (int s = 1; s <= 4; s++)
            {
                Console.Write(draft_1[q, s] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        Console.ReadLine();
        //aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaplayer_2aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
        Console.WriteLine($"{player_2} ваш выстрел ");
        for (int q = 1; q <= 4; q++)
        {
            for (int s = 1; s <= 4; s++)
            {
                Console.Write(draft_2[q, s] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        Console.Write($"Введите первую координату выстрела:\t");
        if (int.TryParse(Console.ReadLine(), out y))
        {
            if (y > 0 && y <= 4)
            {
                Console.Write($"Введите вторую координату выстрела:\t");
                int x;
                if (int.TryParse(Console.ReadLine(), out x))
                {
                    if (x > 0 && x <= 4)
                    {
                        if (myArray_1[y, x] == 0)
                        {
                            Console.WriteLine("Тут нет корабля");
                            myArray_1[y, x] = 2;
                            draft_2[y, x] = 2;
                        }
                        else if (myArray_1[y, x] == 1)
                        {
                            Console.WriteLine($"{player_2} попал у {player_1} осталось {--ship_1} коробля");
                            myArray_1[y, x] = 3;
                            draft_2[y, x] = 3;
                            if (ship_1 == 0)
                                break;
                        }
                        else
                            Console.WriteLine("Сюда уже проводился выстрел");
                    }
                    else
                    {
                        Console.WriteLine("Предел карты 4Х4");
                        i--;
                    }
                }
                else
                {
                    Console.WriteLine("Это не число");
                    i--;
                }
            }
            else
            {
                Console.WriteLine("Предел карты 4Х4");
                i--;
            }
        }
        else
        {
            Console.WriteLine("Это не число");
            i--;
        }
        Console.WriteLine();
        for (int q = 1; q <= 4; q++)
        {
            for (int s = 1; s <= 4; s++)
            {
                Console.Write(draft_2[q, s] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        Console.ReadLine();
        Console.Clear();
    }
    if (ship_1 == 0)
        Console.WriteLine($"Победил {player_1}");
    else
        Console.WriteLine($"Победил {player_2}");
    Console.ReadLine();
}