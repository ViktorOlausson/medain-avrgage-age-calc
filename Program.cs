namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // sparar aktuellt år till ny variable c_year
            int c_year = DateTime.Now.Year;

            //tomma listor för män och kvinnor
            int[] man_list = {};
            int[] kvinna_list = {};


            // Funktion som räknar ut medelåldern från en lista med åldrar

            static double calc_mean_age(int[] arr)
            {
                if(arr.Length == 0)
                {
                    return 0;
                }
                else
                {
                    int sumAges = arr.Sum();
                    double meanAge = (double)sumAges / arr.Length;
                    return meanAge;
                }
            }

            

            
            //funktion som räknar ut median åldern fler en lista

            static double calc_median_age(int[] arr)
            {
                if (arr.Length == 0)
                {
                    return 0;
                }
                else
                {
                    Array.Sort(arr);
                    int middle = arr.Length / 2;
                    double medianAge;

                    if (arr.Length % 2 == 0)
                    {
                        medianAge = (arr[middle - 1] + arr[middle]) / 2;
                    }
                    else
                    {
                        medianAge = arr[middle];
                    }

                    return medianAge;
                }
            }


            //loop för intpur från användare från terminalen

            while (true)
            {
                Console.WriteLine("Skriv in fördlseår med fyra siffror, eller q för att avsluta: ");
                string string_birth_year = Console.ReadLine();

                if (string_birth_year.ToLower = "q");
                   
            } 



            //Loopar som skriver ut medelåldern men endast om det finns någon data





            
        }
    }
}