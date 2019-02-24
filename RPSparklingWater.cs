using System;
namespace RPSparklingWater {
    public class SparklingWater {
        public static void Main (int[] sodaCans[13]) {
            // 1 - berry, 2 - citrus, 3 - regular, 4 - coconut
            //int[] sodaCans = new int[13] { 1, 1, 1, 1, 2, 2, 4, 2, 3, 3, 3, 3, 3 };
            //int[] sodaCans = new int[13] { 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4 };
            // int[] sodaCans = new int[13];

            System.Console.WriteLine ("Initial Cans: " + sodaCans[0] + sodaCans[1] + sodaCans[2] + sodaCans[3] + sodaCans[4] + sodaCans[5] + sodaCans[6] + sodaCans[7] + sodaCans[8] + sodaCans[9] + sodaCans[10] + sodaCans[11] + sodaCans[12]);
        
            if (sodaCans[12] == 4) {
                System.Console.WriteLine ("I get the coconut one!");
                return True;
            } 
        
            while(sodaCans[12] != 4)
                for (int i = 0; i < 12; i++) {
                    int temp = sodaCans[i];
                    sodaCans[i] = sodaCans[i + 1];
                    sodaCans[i + 1] = temp;
                    System.Console.WriteLine ("Cans AFTER---- " + sodaCans[0] + sodaCans[1] + sodaCans[2] + sodaCans[3] + sodaCans[4] + sodaCans[5] + sodaCans[6] + sodaCans[7] + sodaCans[8] + sodaCans[9] + sodaCans[10] + sodaCans[11] + sodaCans[12]);
                }
                System.Console.WriteLine("I will get coconut 100% if the first can to be given away is " + sodaCans[0]);
        }
    }
}
