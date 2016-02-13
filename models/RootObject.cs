using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models
{
    public class Scanentity
    {
        public int x { get; set; }
        public int y { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string species { get; set; }
    }

    public class Attack
    {
        public string type { get; set; }
        public List<int> damage { get; set; }
    }

    public class Scanthing
    {
        public string name { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int tohit { get; set; }
        public int todam { get; set; }
        public int ac { get; set; }
        public Attack attack { get; set; }
        public string subtype { get; set; }
        public object description { get; set; }
        public int amount { get; set; }
        public int dp { get; set; }
        public int value { get; set; }
        public long createdAt { get; set; }
        public object modifiedAt { get; set; }
        public object createdBy { get; set; }
        public string id { get; set; }
        public string type { get; set; }
    }

    public class Atk
    {
        public string type { get; set; }
        public List<int> damage { get; set; }
    }

    public class ScanArea
    {
        public string x { get; set; }
        public string y { get; set; }
        public string tiletype { get; set; }
    }

    public class Payload
    {
        public string name { get; set; }
        public string species { get; set; }
        public int gameRef { get; set; }
        public string levelRef { get; set; }
        public string levelType { get; set; }
        public string playerRef { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int light { get; set; }
        public List<List<ScanArea>> scanarea { get; set; }
        public List<Scanentity> scanentities { get; set; }
        public List<Scanthing> scanthings { get; set; }
        public List<string> inventory { get; set; }
        public string info { get; set; }
        public string gamelevel { get; set; }
        public int level { get; set; }
        public int exp { get; set; }
        public int ac { get; set; }
        public int hp { get; set; }
        public int maxhp { get; set; }
        public Atk atk { get; set; }
        public object resist { get; set; }
        public object special { get; set; }
        public int value { get; set; }
        public long createdAt { get; set; }
        public object modifiedAt { get; set; }
        public string createdBy { get; set; }
        public string id { get; set; }
        public string type { get; set; }
    }

    public class RootObject
    {
        public string status { get; set; }
        public string info { get; set; }
        public Payload payload { get; set; }
    }
}
