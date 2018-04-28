using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotifyAPI.Web; //Base Namespace
using SpotifyAPI.Web.Auth; //All Authentication-related classes
using SpotifyAPI.Web.Enums; //Enums
using SpotifyAPI.Web.Models; //Models for the JSON-responses

namespace AlarmClock
{
    class Program
    {
        static void Main(string[] args)
        {
            SpotifyWebAPI _spotify = new SpotifyWebAPI()
            {
                UseAuth = false,
            };

            FullTrack track = _spotify.GetTrack("3Hvu1pq89D4R0lyPBoujSv");

            Console.WriteLine(track.Name);
        }
    }
}
