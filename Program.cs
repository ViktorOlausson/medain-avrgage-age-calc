namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // sparar aktuellt år till ny variable c_year
            int c_year = DateTime.Now.Year;

            //tomma listor för män och kvinnor
            int[] man_list = { };
            int[] kvinna_list = { };


            // Funktion som räknar ut medelåldern från en lista med åldrar

            static double calc_mean_age(int[] arr)
            {
                if (arr.Length == 0)
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
            {//TODO: göra try catch
                Console.WriteLine("Skriv in fördlseår med fyra siffror, eller q för att avsluta: ");
                //funkar så länge man inte anger något konstigt
                string str_birth_year_input = Console.ReadLine();
                


                if (str_birth_year_input.ToLower() == "q")
                {
                    break;
                }

                int birth_year = int.Parse(str_birth_year_input);//FIXME: Kastar error om input inte är int eller q

                /*try
                {
                    int result = int.Parse(input);
                    // input is a valid integer, and the parsed value is in 'result'
                }
                catch (FormatException)
                {
                    // input is not a valid integer
                }*/


                if (birth_year >= c_year)
                {
                    Console.WriteLine($"Felaktig inmatning, ange ett år som är mindre än nu varande år: {c_year}");
                    continue;
                }else if(birth_year <= c_year - 130)
                {
                    Console.WriteLine("Felaktig inmatning, åldern måste vara mindre än 130");
                    continue;
                }

            }

            //Loopar som skriver ut medelåldern men endast om det finns någon data



        }
    }
}