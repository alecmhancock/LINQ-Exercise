using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LINQ
{
    public class Program
    {
        //Create a list of video game names...
        //Order the list of games by length of the game name.
        //Use the lambda expression in this exercise as well.
        //Use Method Syntax for this exercise
        static void Main(string[] args)
        {
            
            List<string> videogames = new List<string>();

            videogames.Add("Halo");
            videogames.Add("Portal");
            videogames.Add("Warcraft");
            videogames.Add("Civilization");
            videogames.Add("skate.");

            var answer = videogames.Where(item => item.Length > 0).OrderBy(item => item).ToList();
            for (int i = 0; i < answer.Count; i++)
            {
                Console.WriteLine(answer[i]);
            }

        }
    }
}
