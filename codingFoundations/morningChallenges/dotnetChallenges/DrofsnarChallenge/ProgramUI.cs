public class ProgramUI
{
    public void Run()
    {
        string sequenceString = File.ReadAllText("./DrofsnarChallenge/game-sequence.txt");
        string[] interactionsArray = sequenceString.Split(',');

        int drofsnarPts = 5000;
        int drofsnarLives = 3;
        int vulnerableHunterPtVal = 200;

        while (drofsnarLives > 0)
        {
            foreach (string interaction in interactionsArray)
            {
                switch (interaction)
                {
                    case "InvincibleBirdHunter":
                    // write "InvincibleBirdHunter has been detected! Life has been lost :("
                    // drofsnarLives = drofsnarLives - 1
                    // ---- OR ----
                    // drofsnarLives--
                    // "Total lives: {drofsnarLives}"
                        System.Console.WriteLine("Invincible Bird Hunter has been detected! Life has been lost :(");
                        
                        drofsnarLives--;
                        System.Console.WriteLine($"Total lives: {drofsnarLives}");
                        break;
                    case "VulnerableBirdHunter":
                    // write "VulnerableBirdHunter has been detected! {vulnerableHunterPtVal} points added!"
                    // drofsnarPts = drofsnarPts + vulnerableHunterPtVal
                    // drofsnarPts += vulnerableHunterPtVal;
                    // "Points: {drofsnarPts}"
                        System.Console.WriteLine($"Vulnerable Bird Hunter has been detected! {vulnerableHunterPtVal} points added!");

                        drofsnarPts += vulnerableHunterPtVal;
                        System.Console.WriteLine($"Points: {drofsnarPts}");
                    // * AFTER vulnerableHunterPtVal is added, need to multiply the previous val by 2 and 
                    // * reassign vulnerableHunterPtVal
                        vulnerableHunterPtVal = vulnerableHunterPtVal * 2;
                        break;
                    case "Bird":
                    // write "It's a Bird! 10 points added!"
                    // drofsnarPts += 10;
                    // "Points: {drofsnarPts}"
                        System.Console.WriteLine("It's a Bird! 10 points added!");

                        drofsnarPts += 10;
                        System.Console.WriteLine($"Points: {drofsnarPts}");
                        break;
                    case "EveningGrosbeak":
                    // write "It's a EveningGrosbeak! 1000 points added!"
                    // drofsnarPts += 1000;
                    // $"Points: {drofsnarPts}"
                        System.Console.WriteLine("It's an Evening Grosbeak! 1000 points added!");

                        drofsnarPts += 1000;
                        System.Console.WriteLine($"Points: {drofsnarPts}");
                        break;
                    case "GreaterPrairieChicken":
                    // write "It's a GreaterPrairieChicken! 2000 points added!"
                    // drofsnarPts += 2000;
                    // $"Points: {drofsnarPts}"
                        System.Console.WriteLine("It's a Greater Prairie Chicken! 2000 points added!");

                        drofsnarPts += 2000;
                        System.Console.WriteLine($"Points: {drofsnarPts}");
                        break;
                    case "IcelandGull":
                    // write "It's a IcelandGull! 3000 points added!"
                    // drofsnarPts += 3000;
                    // $"Points: {drofsnarPts}"
                        System.Console.WriteLine("It's a Iceland Gull! 3000 points added!");

                        drofsnarPts += 3000;
                        System.Console.WriteLine($"Points: {drofsnarPts}");
                        break;
                    case "CrestedIbis":
                    // write "It's a CrestedIbis! 100 points added!"
                    // drofsnarPts += 100;
                    // $"Points: {drofsnarPts}"
                        System.Console.WriteLine("It's a Crested Ibis! 100 points added!");

                        drofsnarPts += 100;
                        System.Console.WriteLine($"Points: {drofsnarPts}");
                        break;
                    case "GreatKiskudee":
                    // write "It's a GreatKiskudee! 300 points added!"
                    // drofsnarPts += 300;
                    // $"Points: {drofsnarPts}"
                        System.Console.WriteLine("It's a Great Kiskudee! 300 points added!");

                        drofsnarPts += 300;
                        System.Console.WriteLine($"Points: {drofsnarPts}");
                        break;
                    case "RedCrossbill":
                    // write "It's a RedCrossbill! 500 points added!"
                    // drofsnarPts += 500;
                    // $"Points: {drofsnarPts}"
                        System.Console.WriteLine("It's a Red Crossbill! 500 points added!");

                        drofsnarPts += 500;
                        System.Console.WriteLine($"Points: {drofsnarPts}");
                        break;
                    case "Red-neckedPhalarope":
                    // write "It's a Red-neckedPhalarope! 700 points added!"
                    // drofsnarPts += 700;
                    // $"Points: {drofsnarPts}"
                        System.Console.WriteLine("It's a Red-necked Phalarope! 700 points added!");

                        drofsnarPts += 700;
                        System.Console.WriteLine($"Points: {drofsnarPts}");
                        break;
                    case "Orange-belliedParrot":
                    // write "It's a Orange-belliedParrot! 5000 points added!"
                    // drofsnarPts += 5000;
                    // $"Points: {drofsnarPts}"
                        System.Console.WriteLine("It's an Orange-bellied Parrot! 5000 points added!");

                        drofsnarPts += 5000;
                        System.Console.WriteLine($"Points: {drofsnarPts}");
                        break;
                    default:
                        System.Console.WriteLine("Interaction was not recognized. No changes have been made.");
                        break;
                }
                
                if (drofsnarPts > 10000 && drofsnarPts < 11811)
                {
                    System.Console.WriteLine("~~~~ 10000 points! Life added ~~~~");
                    drofsnarLives++;
                }
            
            }

            System.Console.WriteLine($"Drofsnar has emerged victorious! With {drofsnarLives} lives to spare!");
            System.Console.WriteLine($"Final Points: {drofsnarPts}");
        }
    }
}
