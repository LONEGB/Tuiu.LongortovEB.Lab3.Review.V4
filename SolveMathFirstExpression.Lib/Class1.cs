namespace SolveMathFirstExpression.Lib;

public class MathFirstExpression
{
    public double CalculateFirstExpression(double x, double y)
    {
        double z = 0;

        // Вычисляем промежуточные значения
        double sqrt_abs_x = Math.Sqrt(Math.Abs(x)); // корень из модуля |x|
        double term1 = y - sqrt_abs_x; // (y - sqrt(|x|))

        double denominator = x + (x * x / 4); // (x + x^2/4)
        double fraction = y / denominator; // y / (x + x^2/4)
        double term2 = x - fraction; // (x - y / (x + x^2/4))

        double result = term1 * term2; // (y - sqrt(|x|)) * (x - y / (x + x^2/4))
        double ln_arg = Math.Abs(result); // модуль результата для логарифма

        // Проверяем, чтобы аргумент логарифма был больше 0
        if (ln_arg > 0)
        {
            z = Math.Log(ln_arg); // натуральный логарифм ln(|...|)
        }
        else
        {
            throw new ArgumentException("Аргумент логарифма должен быть больше 0.");
        }

        // Округляем результат до 3 знаков после запятой
        double z_round = Math.Round(z, 3);
        return z_round;
    }
}
