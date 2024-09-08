using System;
using System.Collections.Generic;
using System.Text;

namespace AS_prog
{
    class Array_relay_team
    {
        public static void Run()
        {
            // Question 1
            // ============================================================
            int[,] TeamTime =
            {
                {54, 65, 58, 62 },
                {58, 61, 51, 57 },
                {53, 60, 59, 60 },
                {56, 65, 64, 67 },
                {57, 56, 53, 56 }
            };

            // Question 2
            // ============================================================
            for (int Row = 0; Row < TeamTime.GetLength(0); Row++)
            {
                int TotalTime = 0;
                for (int Col = 0; Col < TeamTime.GetLength(1); Col++)
                {
                    TotalTime = TotalTime + TeamTime[Row, Col];
                }
                Console.WriteLine($"Team {Row} had total time {TotalTime}");
            }

            // Question 3
            // initalise FastestTime as worst case time
            // as we are looking for fastest time
            // ============================================================
            int FastestTime = 120;
            int FastestRunner = 0;
            int FastestRunnersTeam = 0;

            for (int Row = 0; Row < TeamTime.GetLength(0); Row++)
            {
                for (int Col = 0; Col < TeamTime.GetLength(1); Col++)
                {
                   if (TeamTime[Row, Col] < FastestTime)
                    {
                        FastestTime = TeamTime[Row, Col];
                        FastestRunner = Col;
                        FastestRunnersTeam = Row;
                    }
                }
            }
            Console.WriteLine($"Fastest time {FastestTime}");
            Console.WriteLine($"Fastest runner {FastestRunner}");
            Console.WriteLine($"Fastest runner's team {FastestRunnersTeam}");
        }
    }
}

