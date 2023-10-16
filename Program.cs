//38.1
//int summa = 0;
//while (true)
//{
//    Console.WriteLine("Введите очередное число последовательности a=");
//    int z = int.Parse(Console.ReadLine());
//    if (z >= 0)
//        summa += z;
//    Console.WriteLine("Продолжить ввод? Y/N");
//    if (Console.ReadLine() == "N")
//        break;
//}
//Console.WriteLine($"Сумма чисел summa= {summa}");
//38.6
//Console.WriteLine("Введите значение больше 0");
//int summa = int.Parse(Console.ReadLine());
//while (true)
//{
//    Console.WriteLine("Введите очередное число последовательности a=");
//    int x = int.Parse(Console.ReadLine());
//    if (x >= 0)
//        summa *= x;
//    Console.WriteLine("Продолжить ввод? Y/N");
//    if (Console.ReadLine() == "N")
//        break;
//}
//Console.WriteLine($"Произведение чисел summa= {summa}");
//38.9
//double summa = 0;
//while (true)
//{
//    Console.WriteLine("Введите очередное число последовательности a=");
//    double c = int.Parse(Console.ReadLine());
//    if (c >= 0)
//        summa += Math.Pow(c, 2);
//    Console.WriteLine("Продолжить ввод? Y/N");
//    if (Console.ReadLine() == "N")
//        break;
//}
//Console.WriteLine($"Сумма квадратов последовательности равна = {summa}");
//41.1
//int u;
//int y;
//int x = 0;
//int uu;
//int sum;
//Console.WriteLine("Введите натуральное число n");
//u = Convert.ToInt32(Console.ReadLine());
//uu = u;
//while (u != 0)
//   {
//   if (u / 10 == 0)
//        x = u;
//        u /= 10;
//   }
//y = uu % 10;
//sum = x + y;
//Console.WriteLine($"сумма первого и последнего числа равны = {sum}");
//33.3
//Console.Write(" Введите количество множителей n=");
//int r = int.Parse(Console.ReadLine());
//double P = 1;
//for (int s = 1; s <= r; s++)
//{
//    double e = (s * 2.0) / (2.0 * s + 1.0);
//    P *= e;
//}
//Console.WriteLine($" P={P}");
//36.1.б
//Console.WriteLine("Введите значение eps=");
//double eps = double.Parse(Console.ReadLine());
//double summa = 0;
//int d = 1;
//double a;
//do
//{
//    a = 1.0 / (Math.Pow(2.0, d)) + 1.0 / (Math.Pow(3.0, d));
//    summa += a;
//    d++;
//}
//while (Math.Abs(a) >= eps);
//Console.WriteLine($"Сумма последовательности summa={summa}");




