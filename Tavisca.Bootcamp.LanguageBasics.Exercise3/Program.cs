using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public static class Program
        {

            static void Main(string[] args)
            {

                Test(

                    new[] { 3, 4 },

                    new[] { 2, 8 },

                    new[] { 5, 2 },

                    new[] { "P", "p", "C", "c", "F", "f", "T", "t" },

                    new[] { 1, 0, 1, 0, 0, 1, 1, 0 });

                Test(

                    new[] { 3, 4, 1, 5 },

                    new[] { 2, 8, 5, 1 },

                    new[] { 5, 2, 4, 4 },

                    new[] { "tFc", "tF", "Ftc" },

                    new[] { 3, 2, 0 });

                Test(

                    new[] { 18, 86, 76, 0, 34, 30, 95, 12, 21 },

                    new[] { 26, 56, 3, 45, 88, 0, 10, 27, 53 },

                    new[] { 93, 96, 13, 95, 98, 18, 59, 49, 86 },

                    new[] { "f", "Pt", "PT", "fT", "Cp", "C", "t", "", "cCp", "ttp", "PCFt", "P", "pCt", "cP", "Pc" },

                    new[] { 2, 6, 6, 2, 4, 4, 5, 0, 5, 5, 6, 6, 3, 5, 6 });

                Console.ReadKey(true);

            }



            private static void Test(int[] protein, int[] carbs, int[] fat, string[] dietPlans, int[] expected)
            {

                var result = SelectMeals(protein, carbs, fat, dietPlans).SequenceEqual(expected) ? "PASS" : "FAIL";

                Console.WriteLine("Proteins = " + string.Join(", ", protein));

                Console.WriteLine("Carbs =" + string.Join(", ", carbs));

                Console.WriteLine("Fats =" + string.Join(", ", fat));

                Console.WriteLine("Diet plan =" + string.Join(", ", dietPlans));

                Console.WriteLine(result);

            }
            public static List<int> retIndexPM(List<int> pp, char ch,List<int> pm)
            {
                List<int> ii = new List<int>();
                List<int> aa = new List<int>();
                for (int i = 0; i < pm.Count; i++)
                {
                    aa.Add(pp[pm[i]]);
                }
                int min = aa.Min(), max = aa.Max(),k=0;
                if (ch == 'p')
                {
                    for (int i = 0; i < pp.Count; i++)
                    {
                        if ((i<=pm.Max())&&(i == pm[k]))
                        {
                            if (pp[i] == min)
                                ii.Add(i);
                            k++;
                        }
                    }
                }
                else if (ch == 'P')
                {
                    for (int i = 0; i < pp.Count; i++)
                    {
                        if ((i<=pm.Max())&&(i == pm[k]))
                        {
                            if (pp[i] == max)
                                ii.Add(i);
                            k++;
                        }
                    }
                
                }
              
                return ii;
            }// returns the value of indexes accordingly for proteins
            public static List<int> retIndexFM(List<int> pp, char ch, List<int> pm)
            {
                List<int> ii = new List<int>();
                List<int> aa = new List<int>();
                for (int i = 0; i < pm.Count; i++)
                {
                    aa.Add(pp[pm[i]]);
                }
                int min = aa.Min(), max = aa.Max(),k=0;
                if (ch == 'f')
                {
                    for (int i = 0; i < pp.Count; i++)
                    {
                        if ((i<=pm.Max())&&(i == pm[k]))
                        {
                            if (pp[i] == min)
                                ii.Add(i);
                            k++;
                        }
                    }
                }
                else if (ch == 'F')
                {
                    for (int i = 0; i < pp.Count; i++)
                    {
                        if ((i<=pm.Max())&&(i == pm[k]))
                        {
                            if (pp[i] == max)
                                ii.Add(i);
                            k++;
                        }
                    }

                }
              
                return ii;
            }// returns the value of indexes accordingly for fats
            public static List<int> retIndexCM(List<int> pp, char ch, List<int> pm)
            {
                List<int> ii = new List<int>();
                List<int> aa = new List<int>();
                for (int i = 0; i < pm.Count; i++)
                {
                    aa.Add(pp[pm[i]]);
                }
                int min = aa.Min(), max = aa.Max(),k=0;
                if (ch == 'c')
                {
                    for (int i = 0; i < pp.Count; i++)
                    {
                        if ((i<=pm.Max())&&(i == pm[k]))
                        {
                            if (pp[i] == min)
                                ii.Add(i);
                            k++;
                        }
                    }
                }
                else if (ch == 'C')
                {
                    for (int i = 0; i < pp.Count; i++)
                    {
                        if ((i<=pm.Max())&&(i == pm[k]))
                        {
                            if (pp[i] == max)
                                ii.Add(i);
                            k++;
                        }
                    }
                }
              
                    return ii;
            }// returns the value of indexes accordingly for carbs
            public static List<int> retIndexTM(List<int> pp, char ch, List<int> pm)
            {
                List<int> ii = new List<int>();
                List<int> aa = new List<int>();
                for (int i = 0; i < pm.Count; i++)
                {
                    aa.Add(pp[pm[i]]);
                }
                int min = aa.Min(), max = aa.Max(),k=0;
                if (ch == 't')
                {
                    for (int i = 0; i < pp.Count; i++)
                    {
                        if ((i<=pm.Max())&&(i == pm[k]))
                        {
                            if (pp[i] == min)
                                ii.Add(i);
                            k++;
                        }
                    }
                }
                else if (ch == 'T')
                {
                    for (int i = 0; i < pp.Count; i++)
                    {
                        if ((i<=pm.Max())&&(i == pm[k]))
                        {
                            if (pp[i] == max)
                                ii.Add(i);
                            k++;
                        }
                    }

                }
              
                return ii;
            }// returns the value of indexes accordingly for total calories
           

            public static int[] SelectMeals(int[] protein, int[] carbs, int[] fat, string[] dietPlans)
            {
                int[] a=new int[dietPlans.Length];
                List<int> kk = new List<int>();
                List<int> ii = new List<int>();
                for (int i = 0; i < protein.Length; i++)
                {
                    kk.Add(i);
                }
                List<int> pp = new List<int>(protein);
                List<int> ff = new List<int>(fat);
                List<int> cc = new List<int>(carbs);
                List<int> tt = new List<int>();
                for (int i = 0; i < protein.Length; i++)
                {
                    tt.Add((pp[i] * 5 + cc[i] * 5 + ff[i] * 9));
                }
                for (int i = 0; i < dietPlans.Length; i++)
                {
                    ii = kk;
                    char[] ch = dietPlans[i].ToCharArray();
                    for (int j = 0; j < ch.Length; j++)
                    {
                        switch (ch[j])
                        {
                            case 'p': ii = retIndexPM(pp, 'p',ii);
                                break;
                            case 'P': ii = retIndexPM(pp, 'P',ii);
                                break;
                            case 'f': ii = retIndexFM(ff, 'f',ii);
                                break;
                            case 'F': ii = retIndexFM(ff, 'F',ii);
                                break;
                            case 'c': ii = retIndexCM(cc, 'c',ii);
                                break;
                            case 'C': ii = retIndexCM(cc, 'C',ii);
                                break;
                            case 't': ii = retIndexTM(tt, 't',ii);
                                break;
                            case 'T': ii = retIndexTM(tt, 'T',ii);
                                break;
                        }
                    }
                    a[i] = ii[0];
                }
                return a;



            }
        }
    }
