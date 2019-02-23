using System;
// using System.Boolean;

public class SparklingWater {
    public static void Main () {
        // 1 - berry, 2 - citrus, 3 - regular, 4 - coconut
        int[] sodaCans = new int[13] { 1, 1, 1, 1, 2, 4, 2, 2, 3, 3, 3, 3, 9 };
        // int[] distributedCans = new int[13];
        bool iGotCoconut = false;

        System.Console.WriteLine ("sodaCans initial " + sodaCans[0] + sodaCans[1] + sodaCans[2] + sodaCans[3] + sodaCans[4] + sodaCans[5] + sodaCans[6] + sodaCans[7] + sodaCans[8] + sodaCans[9] + sodaCans[10] + sodaCans[11] + sodaCans[12]);
        while(sodaCans[12] != 4)
            for (int i = 0; i < 12; i++) {
                // if (sodaCans[12] == 4) {
                //     System.Console.WriteLine ("I get the coconut one!");
                //     iGotCoconut = True; 
                // } 
                // else {
                    // for(int j=0; j<sodaCans.Length; j++)
                    // {
                    int temp = sodaCans[i];
                    sodaCans[i] = sodaCans[i + 1];
                    sodaCans[i + 1] = temp;
                // }

                System.Console.WriteLine ("sodaCans AFTER-- " + sodaCans[0] + sodaCans[1] + sodaCans[2] + sodaCans[3] + sodaCans[4] + sodaCans[5] + sodaCans[6] + sodaCans[7] + sodaCans[8] + sodaCans[9] + sodaCans[10] + sodaCans[11] + sodaCans[12]);

            }
        //         System.Console.WriteLine("FIRST: " + sodaCans[0]);
        //    System.Console.WriteLine(sodaCans[1]);
        //         System.Console.WriteLine(sodaCans[2]);
        //         System.Console.WriteLine(sodaCans[3]);
        //         System.Console.WriteLine(sodaCans[4]);
        //         System.Console.WriteLine(sodaCans[5]);
        //         System.Console.WriteLine(sodaCans[6]);
        //         System.Console.WriteLine(sodaCans[7]);
        //         System.Console.WriteLine(sodaCans[8]);
        //         System.Console.WriteLine(sodaCans[9]);
        //         System.Console.WriteLine(sodaCans[10]);
        //         System.Console.WriteLine(sodaCans[11]);
        //         System.Console.WriteLine("LAST: " + sodaCans[12]);

    }
}