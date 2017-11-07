using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
namespace GameScoreLibrary
{
    public class GameFactory
    {
        List<Game> gameList = new List<Game>();

        public string FilePath { get; set; }

        public void CreateGameList()
        {
            gameList.Add(new Game("Miami Heat", 85, "Boston Celtics", 76));
            gameList.Add(new Game("Utah Jazz", 35, "Detroit Pistons", 60));
            gameList.Add(new Game("Cleveland Cavaliers", 94, "Minnesota Timberwolves", 98));
            gameList.Add(new Game("New York Knicks", 104, "Denver Nuggets", 98));
            gameList.Add(new Game("Dallas Mavericks", 75, "Chicago Bulls", 34));
            gameList.Add(new Game("Memphis Grizzlies", 87, "Houston Rockets", 86));

        }

        public bool SerializeGameList()
        {
            StreamWriter sw = new StreamWriter("games.xml");
            XmlSerializer serial = new XmlSerializer(gameList.GetType());
            serial.Serialize(sw, gameList);
            sw.Close();
            return true;
        }

        public void DeserializeGameList()
        {

        }
    }
}
