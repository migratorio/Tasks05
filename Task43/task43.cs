/*Программа вычисляет точку пересечения двух прямых, заданных уравнениями
 y = k1 * x + b1, y = k2 * x + b2. 
 Значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Clear();

double b1 = EnterElementOfEquation("Введите значение b1: ");
double k1 = EnterElementOfEquation("Введите значение коэффициента k1: ");
double b2 = EnterElementOfEquation("Введите значение b2: ");
double k2 = EnterElementOfEquation("Введите значение коэффициента k2: ");

double[] YX = GetPointOfIntersectionOfLines(b1, k1, b2, k2);

PrdoubleResult(b1, k1, b2, k2, YX);

//----------------------------FUNCTIONS---------------------------------
static double EnterElementOfEquation(string message)
{

    while (true)
    {
        Console.Write(message);
        bool isCorrect = double.TryParse(Console.ReadLine() ?? "", out double userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine("Ошибка ввода!");
    }
}
//----------------------------------------------------------------------
static double[] GetPointOfIntersectionOfLines(double b1, double k1, double b2, double k2)
{
    double[] outYX = new double[2];

    outYX[0] = (b2 - b1) / (k1 - k2);
    outYX[1] = k2 * outYX[0] + b2;

    return outYX;
}
//----------------------------------------------------------------------
static void PrdoubleResult(double b1, double k1, double b2, double k2, double[] YX)
{
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({YX[0]}, {YX[1]})");
}   