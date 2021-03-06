using System;

namespace Hopsital
{
    class Program
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int patients;
            int treatPats = 0;
            int untreatPats = 0;

            int doctors = 7;

            for (int i = 1; i <= days; i++)
            {
                patients = int.Parse(Console.ReadLine());

                if (i % 3 == 0)
                {
                    if (treatPats < untreatPats)
                    {
                        doctors++;
                    }

                    if (patients >= doctors)
                    {
                        treatPats = treatPats + doctors;
                        untreatPats = untreatPats + (patients - doctors);
                    }
                    else
                    {
                        treatPats = treatPats + patients;
                    }

                }
                else
                {
                    if (patients >= doctors)
                    {
                        treatPats = treatPats + doctors;
                        untreatPats = untreatPats + (patients - doctors);
                    }
                    else
                    {
                        treatPats = treatPats + patients;
                    }

                }
            }
            Console.WriteLine("Treated patients: {0}.", treatPats);
            Console.WriteLine("Untreated patients: {0}.", untreatPats);
        }
    }
}