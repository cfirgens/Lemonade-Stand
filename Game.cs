using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Game
    {
        public void RunGame()
        {
            GameHeader();
            Player player = new Player();
            GameInstructions();


            // O in solid - open to playing more days based on what the number of days playing is.
            int daysToPlay;
            daysToPlay = 0 ;
            int daysPlaying;
            daysPlaying = 7;

            while (i < daysPlaying)
            {
                Day day = new Day(player);
                daysToPlay++;
            }


        }


        public void GameInstructions()
        {
            Console.WriteLine("Do you know how to play? Yes or no");
            string displayInstructions;
            displayInstructions = Console.ReadLine();
            try
            {
                if (displayInstructions == "no" || displayInstructions == "n")
                {
                    Console.WriteLine("Operate your lemonade stand through various weather, change your prices to make more money and stock up on supplies before you run out." +
                        " Winning the game is not the goal. Instead the goal is to make as much money as possible during your 7 days open. \nThere are a variety ways to do this but paying attention" +
                        "to the weather, and ensuring your price is right is key. \nAt the end of each day, your ice will melt and your sugar and/or lemons may go bad after a day or two. \nIf you run out of supplies," +
                        "your store will close for the day and customers won't be able to buy any product from you. Good luck!");
                    Console.ReadLine();
                }

            }
            catch
            {
                Console.WriteLine("Please enter a valid response");
                GameInstructions();
            }
        }


        public void GameHeader()
        {
            Console.Title = "Lemonade Stand";
            string title = @"
 _        _______  _______  _______  _        _______  ______   _______ 
( \      (  ____ \(       )(  ___  )( (    /|(  ___  )(  __  \ (  ____ \
| (      | (    \/| () () || (   ) ||  \  ( || (   ) || (  \  )| (    \/
| |      | (__    | || || || |   | ||   \ | || (___) || |   ) || (__    
| |      |  __)   | |(_)| || |   | || (\ \) ||  ___  || |   | ||  __)   
| |      | (      | |   | || |   | || | \   || (   ) || |   ) || (      
| (____/\| (____/\| )   ( || (___) || )  \  || )   ( || (__/  )| (____/\
(_______/(_______/|/     \|(_______)|/    )_)|/     \|(______/ (_______/
                                                                        
 _______ _________ _______  _        ______  
(  ____ \\__   __/(  ___  )( (    /|(  __  \ 
| (    \/   ) (   | (   ) ||  \  ( || (  \  )
| (_____    | |   | (___) ||   \ | || |   ) |
(_____  )   | |   |  ___  || (\ \) || |   | |
      ) |   | |   | (   ) || | \   || |   ) |
/\____) |   | |   | )   ( || )  \  || (__/  )
\_______)   )_(   |/     \||/    )_)(______/ 
                                             ";
            Console.WriteLine(title);

            Console.ReadLine();

        }

    }
}
