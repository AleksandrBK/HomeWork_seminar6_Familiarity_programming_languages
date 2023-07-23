// Задача 43: Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] IntersectionPoint()
{

    Console.WriteLine("Первая прямая задана уравнением: y = k1 * x + b1");
    Console.Write("Введите значение переменной b1: ");
    double variableB1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите значение переменной k1: ");
    double variableК1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Вторая прямая задана уравнением: y = k2 * x + b2");
    Console.Write("Введите значение переменной b2: ");
    double variableB2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите значение переменной k2: ");
    double variableК2 = Convert.ToDouble(Console.ReadLine());

    if (variableB1 == variableB2 && variableК1 == variableК2)
    {
        Console.WriteLine("Прямые совпадают");
        return null; 
    }

    if (variableК1 == variableК2)
    {
        Console.WriteLine("Прямые параллельны и не имеют точки пересечения.");
        return null; 
    }

    double xPointIntersection = Math.Round((variableB2 - variableB1) / (variableК1 - variableК2), 2);
    double yPointIntersection = Math.Round((variableК1 * (variableB2 - variableB1) / (variableК1 - variableК2)) + variableB1, 2);

    return new double[] { xPointIntersection, yPointIntersection };
}

double[] intersectionPoint = IntersectionPoint();

Console.WriteLine($"Точка пересечения прямых: [ {intersectionPoint[0]}; {intersectionPoint[1]} ]");
