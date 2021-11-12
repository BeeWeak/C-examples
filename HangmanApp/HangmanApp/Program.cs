using System;

namespace HangmanApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string Word = "hello";
            
            foreach(char c in Word)
            {

                Console.WriteLine("{0}", c);


            }
            string[] secretWord = { "w", "o", "r", "d", "s" };
            secretWord[0] = "*";
            secretWord[1] = "*";
            secretWord[2] = "*";
            secretWord[3] = "*";
            secretWord[4] = "*";
            string[] secretWord2 = { "w", "o", "r", "d", "s" };

            foreach (string c in secretWord)
            {
              
                Console.WriteLine(c);

            }
         
            //secretWord.Replace('e', '*');
            int counter = 6;
            bool correctguess;
            do
            {
                
                string guess;
                Console.WriteLine("Enter your guess");
                guess = Console.ReadLine();

                
                if (guess.Contains(secretWord2[0]) || (guess.Contains(secretWord2[1]) || (guess.Contains(secretWord2[2]) || (guess.Contains(secretWord2[3])) || (guess.Contains(secretWord2[4])))))
                {
                    correctguess = true;
                    if (guess.Contains(secretWord2[0])){
                        secretWord[0] = secretWord2[0];
                        correctguess = true;
                    }
                    else if ((guess.Contains(secretWord2[1])))
                    {
                        secretWord[1] = secretWord2[1];
                        correctguess = true;
                    }
                    else if ((guess.Contains(secretWord2[2])))
                    {
                        secretWord[2] = secretWord2[2];
                        correctguess = true;
                    }
                    else if ((guess.Contains(secretWord2[3])))
                    {
                        secretWord[3] = secretWord2[3];
                        correctguess = true;
                    }
                    else if ((guess.Contains(secretWord2[4])))
                    {
                        secretWord[4] = secretWord2[4];
                        correctguess = true;
                    }
                    


                    string result = string.Join(" ", secretWord);
                     Console.WriteLine(result);
                  
                }
                else
                {
                    counter--;
                    Console.WriteLine("you have " + counter + " turns left");
                }
                Console.WriteLine(counter);


            } while (counter != 0);
            
            Console.ReadLine();

            

            
        }
    }
}
