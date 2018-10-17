using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordGenerator.Core
{
    public class NewGameSetting
    {
        public string NewActorSurname { get; set; }
        public string NewActorName { get; set; }
        public int NewActorGoodnessVaule { get; set; }
        public int NewActorClothesIndex { get; private set; }
        public int NewActorGender { get; set; }
        public int NewActorAge { get; set; }
        public int NewActorBodyTyp { get; set; }
        public int NewActorBirthday { get; set; }
        public int NewActorGenderChange { get; set; }
        public int[] NewActorFaceDate { get; set; }
        public int[] NewActorFaceColorDate { get; set; }
        public int NewActorBirthPlaceId { get; set; }
        public int NewActorHomeTypId { get; set; }
        public int NewActorAgeTime { get; set; }
        public int NewActorEnemyBorn { get; set; }
        public int NewActorEnemySize { get; set; }
        public int NewActorXXLevel { get; set; }
        public int NewActorRandomHeir { get; set; }
        public int NewActorWorldResource { get; set; }
        public bool NewActorHairColorLock { get; set; }
        public bool NewActorEyebrowsColorLock { get; private set; }
        public bool NewActorBeardColorLock { get; set; }

        public NewGameSetting()
        {
            this.NewActorSurname = "";
            this.NewActorName = "";
            this.NewActorGoodnessVaule = 500;
            this.NewActorClothesIndex = 0;
            this.NewActorGender =  new Random().Next(0, 2) + 1;
            this.NewActorAge = 20;
            this.NewActorBodyTyp = 0;
            this.NewActorBirthday = 22;
            this.NewActorGenderChange = 0;
            this.NewActorFaceDate = null;
            this.NewActorFaceColorDate = null;
            this.NewActorBirthPlaceId = 1;
            this.NewActorHomeTypId = 0;
            this.NewActorAgeTime = 1;
            this.NewActorEnemyBorn = 0;
            this.NewActorEnemySize = 1;
            this.NewActorXXLevel = 0;
            this.NewActorRandomHeir = 0;
            this.NewActorWorldResource = 0;
            this.NewActorHairColorLock = true;
            this.NewActorEyebrowsColorLock = true;
            this.NewActorBeardColorLock = true;
        }

    }
}
