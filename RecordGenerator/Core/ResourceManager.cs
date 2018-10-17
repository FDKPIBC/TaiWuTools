using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordGenerator.Core
{
    public class ResourceManager
    {
        public Dictionary<int, Dictionary<int,string>> MessageData { get; set; }

        public Dictionary<int, Dictionary<int, int>> ActorItemsDate { get; set; }

        public Dictionary<int, Dictionary<int, string>> PresetGangGroupDate { get; set; }

        public Dictionary<int, int[]> CricketBoxDate { get; set; }

        public Dictionary<int, List<int>> EndNameIndex { get; set; }

        public int[] NameIndex { get; set; }

        public ResourceManager()
        {
            MessageData = new Dictionary<int, Dictionary<int, string>>();
            ActorItemsDate = new Dictionary<int, Dictionary<int, int>>();
            CricketBoxDate = new Dictionary<int, int[]>();
            NameIndex = new int[] { };
        }
    }
}
