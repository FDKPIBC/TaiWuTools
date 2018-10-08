using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TaiWuSaveEdit.Core
{
    public class SaveFile
    {
        [JsonProperty("_year")]
        public int Year { get; set; }

        [JsonProperty("_samsara")]
        public int Samsara { get; set; }

        [JsonProperty("_mianActorId")]
        public int MianActorId { get; set; }

        [JsonProperty("_mainActorName")]
        public string MainActorName { get; set; }

        [JsonProperty("_playTime")]
        public string PlayTime { get; set; }

        [JsonProperty("_playerSeatName")]
        public string PlayerSeatName { get; set; }

        [JsonProperty("_gameLine")]
        public int GameLine { get; set; }

        [JsonProperty("_randSeedValue")]
        public int RandSeedValue { get; set; }

        [JsonProperty("_taiWuShop")]
        public int TaiWuShop { get; set; }

        [JsonProperty("_worldXXLevel")]
        public int WorldXXLevel { get; set; }

        [JsonProperty("_homeFavorAdd")]
        public int HomeFavorAdd { get; set; }

        [JsonProperty("_foodUPList")]
        public Dictionary<int, Dictionary<int, int[]>> FoodUPList { get; set; }

        [JsonProperty("_woodUPList")]
        public Dictionary<int, Dictionary<int, int[]>> WoodUPList { get; set; }

        [JsonProperty("_stoneUPList")]
        public Dictionary<int, Dictionary<int, int[]>> StoneUPList { get; set; }

        [JsonProperty("_silkUPList")]
        public Dictionary<int, Dictionary<int, int[]>> SilkUPList { get; set; }

        [JsonProperty("_herbalUPList")]
        public Dictionary<int, Dictionary<int, int[]>> HerbalUPList { get; set; }

        [JsonProperty("_moneyUPList")]
        public Dictionary<int, Dictionary<int, int[]>> MoneyUPList { get; set; }

        [JsonProperty("_manpowerUseList")]
        public Dictionary<int, Dictionary<int, int[]>> ManpowerUseList { get; set; }

        [JsonProperty("_manpowerHomeUseList")]
        public Dictionary<int, Dictionary<int, Dictionary<int, int>>> ManpowerHomeUseList { get; set; }

        [JsonProperty("_manpowerHomeUpList")]
        public Dictionary<int, Dictionary<int, Dictionary<int, int>>> ManpowerHomeUpList { get; set; }

        [JsonProperty("_manpowerHomeRemoveList")]
        public Dictionary<int, Dictionary<int, Dictionary<int, int>>> ManpowerHomeRemoveList { get; set; }

        [JsonProperty("_backManpowerList")]
        public Dictionary<int, Dictionary<int, int[]>> BackManpowerList { get; set; }

        [JsonProperty("_baseWorldDate")]
        public Dictionary<int, Dictionary<int, int[]>> BaseWorldDate { get; set; }

        [JsonProperty("_gangDate")]
        public Dictionary<int, Dictionary<int, string>> GangDate { get; set; }

        [JsonProperty("_gangGroupDate")]
        public Dictionary<int, Dictionary<int, Dictionary<int, List<int>>>> GangGroupDate { get; set; }

        [JsonProperty("_baseHomeDate")]
        public Dictionary<int, Dictionary<int, int>> BaseHomeDate { get; set; }

        [JsonProperty("_homeShopBootysDate")]
        public Dictionary<int, Dictionary<int, Dictionary<int, List<int[]>>>> HomeShopBootysDate { get; set; }

        [JsonProperty("_homeShopSaveMassagesDate")]
        public Dictionary<int, Dictionary<int, Dictionary<int, List<string[]>>>> HomeShopSaveMassagesDate { get; set; }

        [JsonProperty("_itemsDate")]
        public Dictionary<int, Dictionary<int, string>> ItemsDate { get; set; }

        [JsonProperty("_actorItemsDate")]
        public Dictionary<int, Dictionary<int, int>> ActorItemsDate { get; set; }

        [JsonProperty("_actorBookDate")]
        public Dictionary<int, List<int>> ActorBookDate { get; set; }

        [JsonProperty("_actorShopDate")]
        public Dictionary<int, Dictionary<int, int>> ActorShopDate { get; set; }

        [JsonProperty("_itemsChangeDate")]
        public Dictionary<int, Dictionary<int, int>> ItemsChangeDate { get; set; }

        [JsonProperty("_lateDeleteItems")]
        public List<int> LateDeleteItems { get; set; }

        [JsonProperty("_actorShopDate")]
        public Dictionary<int, Dictionary<int, string>> ActorsDate { get; set; }

        [JsonProperty("_actorSocialDate")]
        public SortedDictionary<int, List<int>> ActorSocialDate { get; set; }

        [JsonProperty("_deadActors")]
        public List<int> DeadActors { get; set; }

        [JsonProperty("_acotrTeamDate")]
        public List<int> AcotrTeamDate { get; set; }

        [JsonProperty("_actorFamilyDate")]
        public List<int> ActorFamilyDate { get; set; }

        [JsonProperty("_actorsWorkingDate")]
        public Dictionary<int, Dictionary<int, Dictionary<int, int>>> ActorsWorkingDate { get; set; }

        [JsonProperty("_actorStudyDate")]
        public Dictionary<int, List<int[]>> ActorStudyDate { get; set; }

        [JsonProperty("_actorSkills")]
        public SortedDictionary<int, int[]> ActorSkills { get; set; }

        [JsonProperty("_actorGongFas")]
        public Dictionary<int, SortedDictionary<int, int[]>> ActorGongFas { get; set; }

        [JsonProperty("_actorEquipGongFas")]
        public Dictionary<int, Dictionary<int, int[]>> ActorEquipGongFas { get; set; }

        [JsonProperty("_mianActorEquipGongFas")]
        public Dictionary<int, Dictionary<int, int[]>> MianActorEquipGongFas { get; set; }

        [JsonProperty("_actorInjuryDate")]
        public Dictionary<int, Dictionary<int, int>> ActorInjuryDate { get; set; }

        [JsonProperty("_actorTalkFavor")]
        public Dictionary<int, List<int>> ActorTalkFavor { get; set; }

        [JsonProperty("_gongFaBookPages")]
        public Dictionary<int, int[]> GongFaBookPages { get; set; }

        [JsonProperty("_skillBookPages")]
        public Dictionary<int, int[]> SkillBookPages { get; set; }

        [JsonProperty("_cricketBoxDate")]
        public Dictionary<int, int[]> CricketBoxDate { get; set; }

        [JsonProperty("_eventId")]
        public List<int[]> EventId { get; set; }

        [JsonProperty("_storyShopLevel")]
        public int[] StoryShopLevel { get; set; }

        [JsonProperty("_storyShopMoney")]
        public int[] StoryShopMoney { get; set; }

        [JsonProperty("_xxPartIds")]
        public List<int> XxPartIds { get; set; }

        [JsonProperty("_xxEnemyAtPlace")]
        public List<int> XxEnemyAtPlace { get; set; }

        [JsonProperty("_missionDate")]
        public SortedDictionary<int, int[]> MissionDate { get; set; }

        [JsonProperty("_xxPointValue")]
        public Dictionary<int, int[]> XxPointValue { get; set; }

        [JsonProperty("_xxList")]
        public List<int> XxList { get; set; }

        [JsonProperty("_runEnemys")]
        public List<int> RunEnemys { get; set; }

        [JsonProperty("_actorGetScore")]
        public Dictionary<int, Dictionary<int, List<int[]>>> ActorGetScore { get; set; }

        [JsonProperty("_mianActorEquipGongFaIndex")]
        public int MianActorEquipGongFaIndex { get; set; }

        [JsonProperty("_addSkillStudyValue")]
        public int AddSkillStudyValue { get; set; }

        [JsonProperty("_addGongFaStudyValue")]
        public int AddGongFaStudyValue { get; set; }

        [JsonProperty("_dayTime")]
        public int DayTime { get; set; }

        [JsonProperty("_dayTrun")]
        public int DayTrun { get; set; }

        [JsonProperty("_gongFaExperienceP")]
        public int GongFaExperienceP { get; set; }

        [JsonProperty("_newItemId")]
        public int NewItemId { get; set; }

        [JsonProperty("_newActorId")]
        public int NewActorId { get; set; }

        [JsonProperty("_worldId")]
        public int WorldId { get; set; }

        [JsonProperty("_partId")]
        public int PartId { get; set; }

        [JsonProperty("_placeId")]
        public int PlaceId { get; set; }

        [JsonProperty("_buyStudyValue")]
        public int BuyStudyValue { get; set; }

        [JsonProperty("_getQuquTrun")]
        public int GetQuquTrun { get; set; }

        [JsonProperty("_killActorName")]
        public string KillActorName { get; set; }

        [JsonProperty("_xxComeTyp")]
        public int XxComeTyp { get; set; }

        [JsonProperty("_makePower")]
        public bool MakePower { get; set; }

        [JsonProperty("_readPower")]
        public bool ReadPower { get; set; }

        [JsonProperty("_mapHealing1")]
        public bool MapHealing1 { get; set; }

        [JsonProperty("_mapHealing2")]
        public bool MapHealing2 { get; set; }

        [JsonProperty("_nameIndex")]
        public int[] NameIndex { get; set; }

        [JsonProperty("_endNameIndex")]
        public Dictionary<int, List<int>> EndNameIndex { get; set; }

        [JsonProperty("_badPlaceIds")]
        public Dictionary<int, List<int>> BadPlaceIds { get; set; }
    }
}
