using System;
using System.Diagnostics;
using System.Numerics;

namespace PowerLogic
{
    public static class Calculator
    {
        // Структура для хранения результата и статистики
        public struct CalculationResult
        {
            public BigInteger Value; // Используем BigInteger, так как 100^30 — это 61 знак
            public int Ops;
            public long Ticks;
        }

        /// <summary>
        /// Наивное возведение в степень (O(n))
        /// </summary>
        public static CalculationResult Naive(int baseNum, int exponent)
        {
            Validate(baseNum, exponent);

            Stopwatch sw = Stopwatch.StartNew();
            BigInteger result = 1;
            int ops = 0;

            for (int i = 0; i < exponent; i++)
            {
                result *= baseNum;
                ops++;
            }

            sw.Stop();
            return new CalculationResult { Value = result, Ops = ops, Ticks = sw.ElapsedTicks };
        }

        /// <summary>
        /// Быстрое возведение в степень (O(log n))
        /// </summary>
        public static CalculationResult Fast(int baseNum, int exponent)
        {
            Validate(baseNum, exponent);

            Stopwatch sw = Stopwatch.StartNew();
            int ops = 0;
            BigInteger result = 1;
            BigInteger b = baseNum;
            int e = exponent;

            while (e > 0)
            {
                if (e % 2 == 1)
                {
                    result *= b;
                    ops++;
                }
                b *= b;
                ops++;
                e /= 2;
            }

            sw.Stop();
            return new CalculationResult { Value = result, Ops = ops, Ticks = sw.ElapsedTicks };
        }

        private static void Validate(int baseNum, int exponent)
        {
            if (baseNum < -100 || baseNum > 100)
                throw new ArgumentOutOfRangeException("Основание должно быть от -100 до 100");
            if (exponent < 0 || exponent > 30)
                throw new ArgumentOutOfRangeException("Показатель должен быть от 0 до 30");
        }
    }
}