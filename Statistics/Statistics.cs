using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        public class Stats
        {
            public float average { get; set; }
            public float max { get; set; }
            public float min { get; set; }
        }

        public Stats CalculateStatistics(List<float> numbers)
        {
            Stats stats = new Stats();

            if (numbers.Count == 0)
            {
                stats.average = float.NaN;
                stats.max = float.NaN;
                stats.min = float.NaN;
            }
            else
            {
                float sum = 0;
                float min = numbers[0];
                float max = numbers[0];

                for (int i = 0; i < numbers.Count; i++)
                {
                    sum += numbers[i];
                    if (numbers[i] > max)
                    {
                        max = numbers[i];
                    }
                    else if (numbers[i] < min)
                    {
                        min = numbers[i];
                    }
                }

                stats.average = sum / numbers.Count;
                stats.max = max;
                stats.min = min;
            }

            return stats;
        }
    }
}
