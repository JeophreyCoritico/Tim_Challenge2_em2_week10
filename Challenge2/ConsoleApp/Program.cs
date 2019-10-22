using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;

namespace ConsoleApp1
{
    class Program
    {
        static void space()
        {
            Console.WriteLine("");
        }

        static void WL(string text)
        {
            Console.WriteLine(text);
        }

        static void Main(string[] args)
        {
            WL("1 - Quadrilateral");
            WL("2 - Triangle");
            WL("3 - Circle");
            space();

            ConsoleKeyInfo Menu1;
            Menu1 = Console.ReadKey();
            ////////////////// Quadrilateral //////////////////
            if (Menu1.Key == ConsoleKey.D1)
            {
                space();
                WL("Input Color");
                space();
                string UColor = Console.ReadLine();
                space();
                WL("1 - Square");
                WL("2 - Rectangle");
                space();
                ConsoleKeyInfo Menu2;
                Menu2 = Console.ReadKey();
                ////////////////// Square //////////////////
                if (Menu2.Key == ConsoleKey.D1)
                {
                    try
                    {
                        space();
                        WL("Input side length 1");
                        double Uside1 = double.Parse(Console.ReadLine());
                        string Uside1Str = Uside1.ToString();
                        space();
                        int d;
                        if (Uside1 < 1)
                        {
                            throw (new InvalidIntException(""));
                        }
                        if (!int.TryParse(Uside1Str, out d))
                        {
                            throw (new InvalidDecException(""));
                        }
                        Square newSq = new Square(UColor, Uside1);
                        space();
                        WL("Color: " + UColor);
                        WL("Area: " + newSq.GetArea(Uside1));
                        WL("Perimeter: " + newSq.GetPerimeter(Uside1));
                    }
                    catch (InvalidIntException e)
                    {
                        space();
                        WL(e.Message);
                    }
                    catch (InvalidDecException e)
                    {
                        space();
                        WL(e.Message);
                    }
                    finally
                    {
                        WL("Thanks for using the app!");
                    }
                }
                ////////////////// Rectangle //////////////////
                if (Menu2.Key == ConsoleKey.D2)
                {
                    try
                    {
                        space();
                        WL("Input side length 1");
                        double Uside1 = double.Parse(Console.ReadLine());
                        string Uside1Str = Uside1.ToString();
                        space();
                        int d;
                        if (Uside1 < 1)
                        {
                            throw (new InvalidIntException(""));
                        }
                        if (!int.TryParse(Uside1Str, out d))
                        {
                            throw (new InvalidDecException(""));
                        }
                        WL("Input side length 2");
                        double Uside2 = double.Parse(Console.ReadLine());
                        string Uside2Str = Uside2.ToString();
                        space();
                        if (Uside2 < 1)
                        {
                            throw (new InvalidIntException(""));
                        }
                        if (!int.TryParse(Uside2Str, out d))
                        {
                            throw (new InvalidDecException(""));
                        }
                        Rectangle newRec = new Rectangle(UColor, Uside1, Uside2);
                        space();
                        WL("Color: " + UColor);
                        WL("Area: " + newRec.GetArea(Uside1));
                        WL("Perimeter: " + newRec.GetPerimeter(Uside1));
                    }
                    catch (InvalidIntException e)
                    {
                        space();
                        WL(e.Message);
                    }
                    catch (InvalidDecException e)
                    {
                        space();
                        WL(e.Message);
                    }
                    finally
                    {
                        WL("Thanks for using the app!");
                    }
                }
                Console.ReadKey();
            }
            ////////////////// Triangle //////////////////
            if (Menu1.Key == ConsoleKey.D2)
            {
                space();
                WL("Input Color");
                space();
                string UColor = Console.ReadLine();
                space();
                WL("1 - Equilateral");
                WL("2 - Right-Angled");
                space();
                ConsoleKeyInfo Menu2;
                Menu2 = Console.ReadKey();
                //////////////////  Equilateral //////////////////
                if (Menu2.Key == ConsoleKey.D1)
                {
                    try
                    {
                        space();
                        WL("Input side length 1");
                        double Uside1 = double.Parse(Console.ReadLine());
                        string Uside1Str = Uside1.ToString();
                        space();
                        int d;
                        if (Uside1 < 1)
                        {
                            throw (new InvalidIntException(""));
                        }
                        if (!int.TryParse(Uside1Str, out d))
                        {
                            throw (new InvalidDecException(""));
                        }
                        Equilateral newEq = new Equilateral(UColor, Uside1);
                        space();
                        WL("Color: " + UColor);
                        WL("Area: " + newEq.GetArea(Uside1));
                        WL("Perimeter: " + newEq.GetPerimeter(Uside1));
                    }
                    catch (InvalidIntException e)
                    {
                        space();
                        WL(e.Message);
                    }
                    catch (InvalidDecException e)
                    {
                        space();
                        WL(e.Message);
                    }
                    finally
                    {
                        WL("Thanks for using the app!");
                    }
                }
                ////////////////// Right-Angled //////////////////
                if (Menu2.Key == ConsoleKey.D2)
                {
                    try
                    {
                        space();
                        WL("Input side length 1");
                        double Uside1 = double.Parse(Console.ReadLine());
                        string Uside1Str = Uside1.ToString();
                        space();
                        int d;
                        if (Uside1 < 1)
                        {
                            throw (new InvalidIntException(""));
                        }
                        if (!int.TryParse(Uside1Str, out d))
                        {
                            throw (new InvalidDecException(""));
                        }
                        WL("Input side length 2");
                        double Uside2 = double.Parse(Console.ReadLine());
                        string Uside2Str = Uside2.ToString();
                        space();
                        if (Uside2 < 1)
                        {
                            throw (new InvalidIntException(""));
                        }
                        if (!int.TryParse(Uside2Str, out d))
                        {
                            throw (new InvalidDecException(""));
                        }
                        RightAngled newRA = new RightAngled(UColor, Uside1, Uside2);
                        newRA.SetHypotenuse(Uside1, Uside2);
                        space();
                        WL("Color: " + UColor);
                        WL("Area: " + newRA.GetArea(Uside1));
                        WL("Perimeter: " + newRA.GetPerimeter(Uside1));
                    }
                    catch (InvalidIntException e)
                    {
                        space();
                        WL(e.Message);
                    }
                    catch (InvalidDecException e)
                    {
                        space();
                        WL(e.Message);
                    }
                    finally
                    {
                        WL("Thanks for using the app!");
                    }
                }
                Console.ReadKey();
            }
            ////////////////// Circle //////////////////
            if (Menu1.Key == ConsoleKey.D3)
            {
                try
                {
                    space();
                    WL("Input Color");
                    space();
                    string UColor = Console.ReadLine();
                    space();
                    WL("Input radius");
                    double URad = double.Parse(Console.ReadLine());
                    string URadStr = URad.ToString();
                    int d;
                    if (URad < 1)
                    {
                        throw (new InvalidIntException(""));
                    }
                    if (!int.TryParse(URadStr, out d))
                    {
                        throw (new InvalidDecException(""));
                    }
                    space();
                    Circle newCirc = new Circle(UColor, URad);
                    space();
                    WL("Color: " + UColor);
                    WL("Area: " + newCirc.GetArea(URad));
                    WL("Circumference: " + newCirc.GetPerimeter(URad));
                }
                catch (InvalidIntException e)
                {
                    space();
                    WL(e.Message);
                }
                catch (InvalidDecException e)
                {
                    space();
                    WL(e.Message);
                }
                finally
                {
                    WL("Thanks for using the app!");
                }
            }
            Console.ReadKey();
        }
    }
}
