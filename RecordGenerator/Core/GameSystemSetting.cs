using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordGenerator.Core
{
    public class GameSystemSetting
    {
        public float BGMVolume { get; set; }
        public float SEVolume { get; set; }
        public bool BGMOff { get; set; }
        public bool SEOff { get; set; }
        public bool ShowDamage { get; set; }
        public bool ShowTaiwuName { get; set; }
        public List<int> itemSortLists { get; set; }
        public bool FullScreen { get; set; }
        public int ScreenWidth { get; set; }
        public int Screenheight { get; set; }
        public int TeachingId { get; set; }
        public bool TeachingOff { get; set; }
    }
}
