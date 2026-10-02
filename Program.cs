// for (инициализация; условие; шиг){ тело цикла}

// int totalExercises = 1;
// for (int number = 8; number >= totalExercises; number--)
// {
//     Console.WriteLine($"Упражнение {number}");
// }
// Console.WriteLine("Дз сделано");

// for (int room = 5; room <= 50; room += 5)
// {
//     Console.WriteLine($"Кабинет {room}");
// }

// int totalWeeks = 3;

// for (int week = 1; week <= totalWeeks; week++)
// {
//     for (int day = 1; day <= 5; day++)
//     {
//         Console.WriteLine($"Неделя {week}, день {day}");
//     }
//     Console.WriteLine("^_^");
// }
// int countTicket = 0;
// for (int ticket = 4; ticket <= 30; ticket++)
// {
//     if (ticket == 4 || ticket == 12 || ticket == 19)
//     {
//         countTicket++;
//         continue;
//     }

//     Console.WriteLine($"Первый доступ. билет: {ticket}, skip tickets: {countTicket}");
//     break;
// }

// for (; ; )
// {
//     Console.Write("Введите код группы (для выхода - <Exit>): ");
//     string groupCode = Console.ReadLine();

//     if (groupCode == "Exit")
//     {
//         break;
//     }

//     Console.WriteLine($"Записан код группы: {groupCode}");
// }
// Console.WriteLine("Работа с журналом завершена");

// B

// for (int num1 = 1; num1 <= 9; num1++)
// {
//     for (int num2 = 1; num2 <= 9; num2++)
//     {
//         Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
//     }
//     Console.WriteLine();
// }

// G

// for (int number = 1; number <= 50; number++)
// {
//     if (number % 3 == 0)
//     {
//         continue;
//     }
//     if (number%7 == 0)
//     {
//         break;
//     }
//     Console.WriteLine(number);
// }

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// Variant 1
// Console.Write("Введите число до которого будет выполняться цикл: ");
// int numtotal = int.Parse(Console.ReadLine());
// for (int num = 1; num <= numtotal; num++)
// {
//     if (num%3 == 0)
//     {
//         Console.WriteLine(num);
//     }
// }

// Variant 7

// for (int a = 1; a <= 5; a++)
// {
//     for (int b = 1; b <= 5; b++)
//     {
//         Console.WriteLine($"{a} + {b} = {a + b}");
//     }
//     Console.WriteLine();
// }

//Dop. variant

// Console.Write("Введите вол-во недель тренировок: ");
// int weekWorks = int.Parse(Console.ReadLine());
// bool enough = false;
// int count = 0;
// for (int i = 1; i <= weekWorks; i++)
// {
//     for (int j = 1; j <= 7; j++)
//     {
//         if (j == 7) continue; count++;

//         if (count == 20)
//         {
//             enough = true;
//             Console.WriteLine($"You stop work in weeks {i} and days {j}");
//             break;
//         }
//     }
//     if (enough)
//     {
//         break;
//     }
// }
