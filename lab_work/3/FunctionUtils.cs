using System.Collections.Generic;
using ZedGraph;

public static class FunctionUtils
{
    public static void CalculatePoints(PointPairList functionPoints, PointPairList derivativePoints, float xStart, float xEnd, float step)
    {
        // Логика для вычисления значений функции и производной
        for (float x = xStart; x <= xEnd; x += step)
        {
            float y = Function(x);
            float dy = DerivativeFunction(x);
            functionPoints.Add(x, y);
            derivativePoints.Add(x, dy);
        }
    }

    public static float Function(float x)
    {
        if (Math.Abs(x) >= 1)
            return 0; // Предотвращаем деление на ноль

        return x / ((1 + x) * (1 - x) * (1 - x));
    }

    public static float DerivativeFunction(float x)
    {
        // Реализация расчета производной функции
        float numerator = (1 - x) * (1 + x) * (1 + x) - x * (2 * (1 + x) * (1 - x));
        float denominator = (1 + x) * (1 - x) * (1 - x) * (1 - x);
        return numerator / (denominator * denominator);
    }

    public static List<float> FindZeros(float xStart, float xEnd, float step)
    {
        List<float> zeros = new List<float>();

        for (float x = xStart; x <= xEnd; x += step)
        {
            if (Math.Abs(Function(x)) < 0.001)
            {
                zeros.Add(x);
            }
        }

        return zeros;
    }


    public static List<float> FindCriticalPoints(float xStart, float xEnd, float step)
    {
        List<float> criticalPoints = new List<float>();

        for (float x = xStart; x <= xEnd; x += step)
        {
            if (Math.Abs(DerivativeFunction(x)) < 0.001)
            {
                criticalPoints.Add(x);
            }
        }

        return criticalPoints;
    }




}
