using System;

public class SparklingWater
{
    public static void Main()
    {
        // 1 - berry, 2 - citrus, 3 - regular, 4 - coconut
        int[] sodaCans = new int[13]{1,1,1,1,2,2,2,2,3,3,3,3,4};
        int[] distributedCans = new int[13];

        System.Console.WriteLine("sodaCans initial" + sodaCans[0] + sodaCans[1] + sodaCans[2] + sodaCans[3] + sodaCans[4] + sodaCans[5] + sodaCans[6] + sodaCans[7] + sodaCans[8] + sodaCans[9] + sodaCans[10] + sodaCans[11] + sodaCans[12]);
 
        // for(int i=0; i<sodaCans.Length; i++)
        // {
            if(sodaCans[12] == 4)
            {
                System.Console.WriteLine("I get the coconut one!");
            }
            else
            {
                System.Console.WriteLine("You don't get the coconut!");
            }
        // }


    }
}