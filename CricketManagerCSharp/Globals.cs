using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CricketManagerCSharp
{
    public class Globals
    {
        public static string[] engFNames = {"Andy", "Andrew", "Alan", "Alex", "Alexander", "Bill", "Ben", "Barry", "Brendan", "Brandon", "Chris", "Clive", "Colin", "Craig", "Charles", "Charlie", "Dave", "David", "Darren", "Eric", "Ethan", "Ed", "Edward", "Frank", "Fred", "Freddie", "Graham", "George", "Gary", "Gareth", "Harry", "Isaac", "James", "Joseph", "Joe", "John", "Johnny", "Jeff", "Keith", "Ken", "Louis", "Lewis", "Luke", "Mark", "Matt", "Mike", "Matthew", "Mitchell", "Neville", "Norman", "Oscar", "Phil", "Pete", "Peter", "Patrick", "Ronnie", "Richard", "Rory", "Sam", "Steve", "Stuart", "Trevor", "Tim", "Tom", "Victor", "Vinny", "Will", "William", "Xavier"};
        public static string[] engSNames = {"Andrews", "Abraham", "Addis", "Austin", "Bright", "Brown", "Beckham", "Banks", "Billings", "Bradburn", "Bailey", "Bradley", "Butlin", "Butler", "Curran", "Cummins", "Clarkson", "Caddick", "Conway", "Cockerell", "Cohen", "Cope", "Corbin", "Corbett", "Darwood", "Davidson", "Davenport", "Derbyshire", "Donahoe", "Eden", "Eastman", "Eccles", "English", "Erwin", "Franks", "Farmer", "Fairweather", "Foakes", "Ferrel", "Fielding", "Fleming", "Flack", "Foot", "Galbraith", "Gilchrist", "Goodson", "Gough", "Graham", "Gray", "Grimmet", "Giles", "Halliday", "Holmes", "Holt", "Hackett", "Hammond", "Handscomb", "Hazlewood", "Hine", "Ives", "Ivings", "Jacks", "Johnson", "Joiner", "Kemp", "Kipling", "Lane", "Lawrence", "Lee", "Mackley", "Mack", "Mitchell", "Maddy", "Marsden", "Nixon", "O'Donnell", "Osborne", "Obama", "packman", "Paxman", "Paris", "Phillips", "Pittman", "Pollard", "Ratcliffe", "Ravens", "Stevens", "Stewart", "Scott", "Harrison", "Grischeff", "Vale", "Whitehouse", "Thomas", "Williams"};
        public static string[] rightHandBowlStyles = {"RSeam", "RSeam", "RSeam", "RSeam", "RSeam", "RSeam", "RSeam", "OS", "OS", "LS"};
        public static string[] leftHandBowlStyles = {"LSeam", "LSeam", "LSeam", "LSeam", "LSeam", "LSeam", "LSeam", "SLA", "SLA", "SLW"};
        public static string[] roles = {"batter", "batter", "batter", "batter", "batter", "batter", "batter", "allrounder", "allrounder", "allrounder", "keeper", "bowler", "bowler", "bowler", "bowler", "bowler"};
        public static int bowlStyleToInt(string style)
        {
            ArrayList bowlstyles = new ArrayList();
            return bowlstyles.LastIndexOf(style);
        }
        public static double NextGaussian(Random rnd, double mean, double stdDev)
        {
            double u1 = 1.0 - rnd.NextDouble(); // uniform(0,1] random doubles
            double u2 = 1.0 - rnd.NextDouble();
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2); // random normal(0,1)
            return mean + stdDev * randStdNormal; // random normal(mean,stdDev^2)
        }
    }
}
