using CodeWarConsoleApp._6kyu;

public class Program
{
    public static void Main()
    {

        Replace_With_Alphabet_Position.AlphabetPosition("The sunset sets at twelve o' clock.");
        //Replace_With_Alphabet_Position.AlphabetPosition("The narwhal bacons at midnight.");
        //Replace_With_Alphabet_Position.AlphabetPosition("sagkakyxmhlepb");

        Replace_With_Alphabet_Position.AlphabetPositionVersion2("The sunset sets at twelve o' clock.");

        Console.WriteLine(MorseCodeDecoder.Decode(".... . -.--   .--- ..- -.. ."));


        Console.WriteLine("Unique In Order",Unique_In_Order.UniqueInOrderYield("AAAABBBCCDAnullABBB"));



        int[] smth = { 206847684, 1056521, 7, 17, 1901, 21104421, 7, 1, 35521, 1, 7781 };
        Find_The_Parity_Outlier.Find(smth);



    }

}