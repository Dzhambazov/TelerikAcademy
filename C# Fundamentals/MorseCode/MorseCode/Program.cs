using System;
namespace MorseCodeConverter
{
    class MorseCodee
    {
        private Char[] Letters = new Char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g',
          'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u',
          'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8',
          '9', ' '};
        private String[] MorseCode = new String[] {".-", "-...", "-.-.",
          "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", 
          "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", 
          "...-", ".--", "-..-", "-.--", "--..", "-----", ".----", "..---", 
          "...--", "....-", ".....", "-....", "--...", "---..", "----.", " "};

        public String ConvertTextToMorse(String text)
        {
            text = text.ToLower();
            String result = "";
            int index = -1;
            for (int i = 0; i <= text.Length - 1; i++)
            {
                index = Array.IndexOf(Letters, text[i]);
                if (index != -1)
                    result += MorseCode[index] + " ";
            }

            return result;
        }
   
        public String ConvertMorseToText(String text)
        {
            text = "@" + text.Replace(" ", "@@") + "@";
            int index = -1;
            foreach (Char c in Letters)
            {
                index = Array.IndexOf(Letters, c);
                text = text.Replace("@" + MorseCode[index] + "@", "@" + c.ToString() + "@");
            }

            return text.Replace("@@@@", " ").Replace("@", "");
        }
    }
    //от морсов към латиница  единичен интервал за разделение между  отделните символи,  и двоен интервал за разделение на думи
    class Program
    {
        static void Main(string[] args)
        {
            MorseCodee Morse = new MorseCodee();
            Console.WriteLine("Make your choise:");
            Console.WriteLine("1 - from text to morse");
            Console.WriteLine("2 - from morse to text");
            char choise = '0';
            do
            {
                Console.Write("Your choise: ");
                choise = char.Parse(Console.ReadLine());
                Console.Write("Enter your word in the choosen language: ");
                string input = Console.ReadLine();
                if (choise == '1')
                {
                    Console.WriteLine( Morse.ConvertTextToMorse(input));
                }

                if (choise == '2')
                {
                    Console.WriteLine(Morse.ConvertMorseToText(input));
                }
            }
            while(choise == '1' || choise == '2');
        }
    }
}