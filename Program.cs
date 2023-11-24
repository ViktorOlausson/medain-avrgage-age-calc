namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // sparar aktuellt år till ny variable c_year
            int c_year = DateTime.Now.Year;

            //tomma listor för män och kvinnor

            //TOODOO?: gör om till classer??
            //int[] man_list = { };
            //int[] kvinna_list = { };

            List<int> man_list = new List<int>();
            List<int> kvinna_list = new List<int>();
            //DOING: Lista för alla, ska bli separata för kvinnor och män
            List<int> lista_alla = new List<int>();


            //Test listor
            List<double> testlista = new List<double>() {1,2,3,4,5, 6 };
            List<int> testlistTom = new List<int>();


            // Funktion som räknar ut medelåldern från en lista med åldrar

            static double calc_mean_age(List<int> list)
            {
                if (list.Count == 0)
                {
                    return 0;
                }
                else
                {
                    int sumAges = list.Sum();
                    double meanAge = (double)sumAges / list.Count;
                    return meanAge;
                }
            }



            //funktion som räknar ut median åldern fler en lista

            static double calc_median_age(List<double> list)
            {
                if (list.Count == 0)
                {
                    return 0;
                }
                else
                {
                    double[] listArr = list.ToArray();
                    Array.Sort(listArr);//TOODOO?: Göra en riktigt sorting function somär snabbare?
                    int middle = list.Count / 2;
                    double medianAge;

                    if (list.Count % 2 == 0)
                    {
                        medianAge = (list[middle - 1] + list[middle]) / 2;
                    }
                    else
                    {
                        medianAge = list[middle];
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

                int birth_year = int.Parse(str_birth_year_input);//FIXME: Kastar error om input inte är int eller q och om input är för stor

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

            Console.WriteLine(calc_median_age(testlista));
            

        }
    }
}