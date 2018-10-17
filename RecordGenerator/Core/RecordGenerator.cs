using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordGenerator.Core
{
    public class RecordGenerator
    {
        public ResourceManager ResourceManager;

        private int newActorId;
        private int samsara;
        private int newItemId;
        private List<int> acotrTeamDate;
        private int mianActorId;
        private string playerSeatName;
        private int getQuquTrun;

        private List<int> xxList = new List<int>();

        public RecordGenerator()
        {
            ResourceManager = new ResourceManager();
            newActorId = 10000;
            samsara = 1;
            newItemId = 1000000;
            acotrTeamDate = new List<int>(new int[]{ -1, -1, -1, -1, -1 });
            mianActorId = 0;
            playerSeatName = ResourceManager.MessageData[1][1];
            getQuquTrun = 100;
            for (int i = 0; i < 15; i++)
            {
                int key = i;
                int[] array = new int[3];
                array[0] = -97;
                array[1] = -96;
                ResourceManager.CricketBoxDate.Add(key, array);
            }
            for (int j = 0; j < 4; j++)
            {
                ResourceManager.NameIndex[j] = new Random().Next(0, ResourceManager.MessageData[9002][j].Split(new char[]
                {
                '|'
                }).Length);
                List<int> list = new List<int>();
                int num = ResourceManager.MessageData[9003][j / 2].Split(new char[]
                {
                '|'
                }).Length;
                for (int k = 0; k < num; k++)
                {
                    list.Add(k);
                }
                ResourceManager.EndNameIndex.Add(j, list);
            }
            ResourceManager.ActorItemsDate.Add(-999, new Dictionary<int, int>());
        }

        public void Init()
        {   
            xxList = new List<int>();
        }
    }
}
