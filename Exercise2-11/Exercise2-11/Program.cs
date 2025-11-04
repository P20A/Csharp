using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("d:");
            int d = Convert.ToInt32(Console.ReadLine());


            if (a > b)
            {
                if (a > c)
                {
                    if (a > d)
                    {
                        if (b > c)
                        {
                            if (b > d)
                            {
                                if (c > d)
                                {
                                    Console.WriteLine($"{a}>{b}>{c}>{d}");
                                }
                                else
                                {
                                    Console.WriteLine($"{a}>{b}>{d}>{c}");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"{a}>{d}>{b}>{c}");
                            }
                        }

                        else if (c > b)
                        {
                            if (c > d)
                            {
                                if (b > d)
                                {
                                    Console.WriteLine($"{a}>{c}>{b}>{d}");
                                }
                                else
                                {
                                    Console.WriteLine($"{a}>{c}>{d}>{b}");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"{a}>{d}>{c}>{b}");
                            }
                        }
                    }
                    else if (d > a)
                    {
                        if (b > c)
                        {
                            Console.WriteLine($"{d}>{a}>{b}>{c}");
                        }
                        else
                        {
                            Console.WriteLine($"{d}>{a}>{c}>{b}");
                        }

                    }
                }

                else if (c > a)
                {
                    if (d > a)
                    {
                        if (c > d)
                        {
                            Console.WriteLine($"{c}>{d}>{a}>{b}");
                        }
                        else
                        {
                            Console.WriteLine($"{d}>{c}>{a}>{b}");
                        }

                    }
                    else
                    {
                        if (b > d)
                        {
                            Console.WriteLine($"{c}>{a}>{b}>{d}");
                        }
                        else
                        {
                            Console.WriteLine($"{c}>{a}>{d}>{b}");
                        }
                    }

                }
            }
            else
            {
                if (a > d)
                {
                    if (a > c)
                    {
                        if (c > d)
                        {
                            Console.WriteLine($"{b}>{a}>{c}>{d}");
                        }
                        else
                        {
                            Console.WriteLine($"{b}>{a}>{d}>{c}");
                        }
                    }
                    else if (c > a)
                    {
                        if (c > b)
                        {
                            Console.WriteLine($"{c}>{b}>{a}>{d}");
                        }
                        else
                        {
                            if (a > d)
                            {
                                Console.WriteLine($"{b}>{c}>{a}>{d}");
                            }
                            else
                            {
                                Console.WriteLine($"{b}>{c}>{d}>{a}");
                            }
                        }
                    }
                    else
                    {
                        if (a > c)
                        {
                            Console.WriteLine($"{b}>{d}>{a}>{c}");
                        }
                        else
                        {
                            Console.WriteLine($"{b}>{d}>{c}>{a}");
                        }
                    }
                }
                else
                {
                    if (c > a)
                    {
                        if (d > a)
                        {
                            if (b > c)
                            {
                                if (d > b)
                                {
                                    Console.WriteLine($"{d}>{b}>{c}>{a}");
                                }
                                else
                                {
                                    if (c > d)
                                    {
                                        Console.WriteLine($"{b}>{c}>{d}>{a}");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{b}>{d}>{c}>{a}");
                                    }

                                }

                            }
                            else
                            {
                                if (c > d)
                                {
                                    if (d > b)
                                    {
                                        Console.WriteLine($"{c}>{d}>{b}>{a}");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{c}>{b}>{d}>{a}");
                                    }

                                }
                                else
                                {
                                    Console.WriteLine($"{d}>{c}>{b}>{a}");
                                }

                            }

                        }
                        else
                        {
                            Console.WriteLine($"{c}>{b}>{d}>{a}");
                        }

                    }
                    else
                    {
                        if (d > b)
                        {
                            Console.WriteLine($"{d}>{b}>{a}>{c}");
                        }
                        else
                        {
                            if (a > c)
                            {
                                Console.WriteLine($"{b}>{d}>{a}>{c}");
                            }
                            else
                            {
                                Console.WriteLine($"{b}>{d}>{c}>{a}");
                            }
                        }
                    }
                }
            }
        }
    }
}
