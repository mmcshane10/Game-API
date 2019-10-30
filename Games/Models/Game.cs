using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Games.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Publisher { get; set; }
        public int MaxPlayers { get; set; }
        public int MinPlayers { get; set; }
        public int MinAge { get; set; }
        public int AvgPlayTime { get; set; }

        public static List<Game> GetGames()
        {
          
            var apiCallTask = ApiHelper.ApiCall();
            var result = apiCallTask.Result;
            
            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<Game> gameList = JsonConvert.DeserializeObject< List<Game>>(result);
            // List<Game> gameList = new List<Game>();
            // foreach (JObject Jgame in jsonResponse)
            // {
            //     Game game = JsonConvert.DeserializeObject<Game>(Jgame.ToString());
            //     gameList.Add(game);
            // } 
            return gameList;
        }
    }
}