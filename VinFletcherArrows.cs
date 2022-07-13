using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SimulaSoup
{
    public class VinFletcherArrows
    {
        class Arrow
        {
            
            public enum ArrowHead
            {
                Steel,
                Wood,
                Obsidian,
                Null
            }

            public enum FletchingType
            {
               
                GooseFeathered,
                TurkeyFeathered,
                Plastic,
                Null
            }

            public  ArrowHead arrowheadChoice;
            public  FletchingType fletchingChoice; 
            public  int length = 0;
            

            public Arrow(ArrowHead arrowheadChoice,FletchingType fletchingChoice, int length)
            {
                
                this.arrowheadChoice = arrowheadChoice;
                this.fletchingChoice = fletchingChoice;
                this.length = length;
            }

            static ArrowHead GetArrowHead ()
            {
                int arrowheadChoice = Convert.ToInt32(Console.ReadLine()); 
                float arrowHeadCost = 0;
                switch (arrowheadChoice)
                {
                    case (int)ArrowHead.Wood:
                        Console.WriteLine($"Your arrows will have a {ArrowHead.Wood} arrowhead");
                        arrowHeadCost = 3;
                        return ArrowHead.Wood;
                        //break;
                    case (int)ArrowHead.Obsidian:
                        Console.WriteLine($"Your arrows will have an {ArrowHead.Obsidian} arrowhead");
                        arrowHeadCost = 5;
                        return ArrowHead.Obsidian;
                        //break;
                    case (int)ArrowHead.Steel:
                        Console.WriteLine($"Your arrows will have an {ArrowHead.Steel}");
                        arrowHeadCost = 10;
                        return ArrowHead.Steel;
                        //break;
                    default:
                        Console.WriteLine($"Your arrow have {ArrowHead.Null} arrowhead. You hadn't choose anything from Wood/Obsidian/Steel choice");
                        arrowHeadCost = 0;
                        return ArrowHead.Null;
                        //break;
                }

            }

             static FletchingType GetFletchingType()
            {
                int fletchingChoice = Convert.ToInt32(Console.ReadLine()); ;
                float fletchingCost = 0;
                switch (fletchingChoice)
                {
                    case (int)FletchingType.GooseFeathered:
                        Console.WriteLine($"Your fletching type is {FletchingType.GooseFeathered}");
                        fletchingCost = 3;
                        return FletchingType.GooseFeathered;
                        //break;
                    case (int)FletchingType.TurkeyFeathered:
                        Console.WriteLine($"Your fletching type is {FletchingType.TurkeyFeathered}");
                        fletchingCost = 5;
                        return FletchingType.TurkeyFeathered;
                        //break;
                    case (int)FletchingType.Plastic:
                        Console.WriteLine($"Your fletching type is {FletchingType.Plastic}");
                        fletchingCost = 10;
                        return FletchingType.Plastic;
                        //break;
                    default:
                        Console.WriteLine($"Your fletching type is {FletchingType.Null}. Choose between Goose/Turkey/Plastic feathers.");
                        fletchingCost = 0;
                        return FletchingType.Null;
                        //break;
                }
            }

            public static int GetLength()
            {
                int length = Convert.ToInt32(Console.ReadLine());
                if(length >= 60 && length <= 100){
                    Console.WriteLine($"Your arrow have length:{length}");
                }
                return length;

            }

            public float GetCost()
            {
                float totalCost;

                float arrowHeadCost = this.arrowheadChoice switch
                {
                    ArrowHead.Wood => 3f,
                    ArrowHead.Obsidian => 5f,
                    ArrowHead.Steel => 10f,
                    ArrowHead.Null => 0f
                };

                float fletchingCost = this.fletchingChoice switch
                {
                    FletchingType.GooseFeathered => 3f,
                    FletchingType.TurkeyFeathered => 5f,
                    FletchingType.Plastic => 10f,
                    FletchingType.Null => 0f
                };

                float lengthCost = this.length * 0.05f;

                totalCost = fletchingCost + arrowHeadCost + lengthCost;
                Console.WriteLine("The total cost would be:" + totalCost);
                return totalCost;
            }

            public static void Main(String[] args)
            {
                Arrow firstArrow = new(GetArrowHead(), GetFletchingType(), GetLength());
                firstArrow.GetCost();
            }
        }
       

    }
}
