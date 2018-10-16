using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GongFaEditor.Utils
{
    public class GongFa
    {
        /// <summary>
        /// 元数据
        /// </summary>
        public Dictionary<int, string> Original { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        [GongFa(Index = -1,Description ="Id",Editable =false)]
        public int GongFaId { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [GongFa(Index = 0, Description = "名称")]
        public string Name { get; set; }

        /// <summary>
        /// 品级1
        /// </summary>
        [GongFa(Index = 2, Description = "品级1")]
        public int Level1 { get; set; }

        /// <summary>
        /// 品级2
        /// </summary>
        [GongFa(Index = 5, Description = "品级2")]
        public int Level2 { get; set; }

        /// <summary>
        /// 类型1
        /// </summary>
        [GongFa(Index = 61, Description = "类型1")]
        public int GFType1 { get; set; }

        /// <summary>
        /// 类型2
        /// </summary>
        [GongFa(Index = 1, Description = "类型2")]
        public int GFType2 { get; set; }

        /// <summary>
        /// 属性
        /// </summary>
        [GongFa(Index = 62, Description = "属性")]
        public int GFProperty { get; set; }

        /// <summary>
        /// 造诣
        /// </summary>
        [GongFa(Index = 63, Description = "造诣")]
        public int Attainments { get; set; }

        /// <summary>
        /// 阅读难度
        /// </summary>
        [GongFa(Index = 64, Description = "阅读难度")]
        public decimal ReadLevel { get; set; }

        /// <summary>
        /// 修习历练
        /// </summary>
        [GongFa(Index = 66, Description = "修习历练")]
        public int PracticeExperience { get; set; }

        /// <summary>
        /// 突破历练
        /// </summary>
        [GongFa(Index = 73, Description = "突破历练")]
        public int SurmountExperience { get; set; }

        /// <summary>
        /// 说明
        /// </summary>
        [GongFa(Index = 99, Description = "说明")]
        public string Description { get; set; }

        /// <summary>
        /// 心法正练
        /// </summary>
        [GongFa(Index = 103, Description = "心法正练")]
        public int HeartPositiveExperience { get; set; }

        /// <summary>
        /// 心法反练
        /// </summary>
        [GongFa(Index = 104, Description = "心法反练")]
        public int HeartNegativeExperience { get; set; }
        
        /// <summary>
        /// 运功位置
        /// </summary>
        [GongFa(Index = 6, Description = "运功位置",Tips = "1摧破2轻灵3护体4奇窍")]
        public int OperatingPosition { get; set; }
        
        /// <summary>
        /// 运功占格
        /// </summary>
        [GongFa(Index = 7, Description = "运功占格")]
        public int Occupy { get; set; }

        /// <summary>
        /// 门派
        /// </summary>
        [GongFa(Index = 3, Description = "门派")]
        public int Sect { get; set; }

        /// <summary>
        /// 初始类型
        /// </summary>
        [GongFa(Index = 15, Description = "初始类型")]
        public int InitialType { get; set; }

        /// <summary>
        /// 不可为外人道
        /// </summary>
        [GongFa(Index = 16, Description = "不可为外人道",Tips ="1为可以,0为不可以")]
        public int Secret { get; set; }

        /// <summary>
        /// 金刚
        /// </summary>
        [GongFa(Index = 701, Description = "金刚")]
        public decimal KingKong { get; set; }

        /// <summary>
        /// 紫霞
        /// </summary>
        [GongFa(Index = 702, Description = "紫霞")]
        public decimal ZiXia { get; set; }

        /// <summary>
        /// 玄阴
        /// </summary>
        [GongFa(Index = 703, Description = "玄阴")]
        public decimal XuanYin { get; set; }

        /// <summary>
        /// 纯阳
        /// </summary>
        [GongFa(Index = 704, Description = "纯阳")]
        public decimal ChunYang { get; set; }

        /// <summary>
        /// 归元
        /// </summary>
        [GongFa(Index = 705, Description = "归元")]
        public decimal GuiYuan { get; set; }

        /// <summary>
        /// 使用需求
        /// </summary>
        [GongFa(Index = 710,Description = "使用需求", Tips = "内功|根骨|悟性|定力")]
        public string BasicProperty { get; set; }

        /// <summary>
        /// 功法发挥%
        /// </summary>
        [GongFa(Index = 711, Description = "功法发挥%",Tips = "*10+100")]
        public int ExertPercentage { get; set; }

        /// <summary>
        /// 催破
        /// </summary>
        [GongFa(Index = 921, Description = "催破")]
        public int Destroy { get; set; }

        /// <summary>
        /// 轻灵
        /// </summary>
        [GongFa(Index = 922, Description = "轻灵")]
        public int Brisk { get; set; }

        /// <summary>
        /// 护体
        /// </summary>
        [GongFa(Index = 923, Description = "护体")]
        public int BodyCare { get; set; }

        /// <summary>
        /// 奇窍
        /// </summary>
        [GongFa(Index = 924, Description = "奇窍")]
        public int QiQiao { get; set; }

        /// <summary>
        /// 气势消耗
        /// </summary>
        [GongFa(Index = 8, Description = "气势消耗",Tips = "气势消耗—提气% 架势%=总气势-提气 % ")]
        public int MomentumConsume { get; set; }

        /// <summary>
        /// 总气势
        /// </summary>
        [GongFa(Index = 9, Description = "总气势")]
        public int MomentumSum { get; set; }

        /// <summary>
        /// 攻击距离
        /// </summary>
        [GongFa(Index = 9, Description = "攻击距离", Tips ="/100")]
        public int AttackDistance { get; set; }

        /// <summary>
        /// 造诣要求
        /// </summary>
        [GongFa(Index = 10, Description = "造诣要求")]
        public int AttainmentRequire { get; set; }

        /// <summary>
        /// 招式消耗1
        /// </summary>
        [GongFa(Index = 11, Description = "招式消耗1")]
        public string GongFaConsumption1 { get; set; }

        /// <summary>
        /// 招式消耗2
        /// </summary>
        [GongFa(Index = 12, Description = "招式消耗2")]
        public string GongFaConsumption2 { get; set; }

        /// <summary>
        /// 招式消耗3
        /// </summary>
        [GongFa(Index = 13, Description = "招式消耗3")]
        public string GongFaConsumption3 { get; set; }

        /// <summary>
        /// 功法属性系数(力道)
        /// </summary>
        [GongFa(Index = 601, Description = "功法属性系数", Tips = "力道*90")]
        public decimal Strength { get; set; }

        /// <summary>
        /// 功法属性系数(精妙)
        /// </summary>
        [GongFa(Index = 602, Description = "功法属性系数", Tips = "精妙*90")]
        public decimal Extremely { get; set; }

        /// <summary>
        /// 功法属性系数(迅疾)
        /// </summary>
        [GongFa(Index = 603, Description = "功法属性系数", Tips = "迅疾*90")]
        public decimal Fast { get; set; }

        /// <summary>
        /// 力道格
        /// </summary>
        [GongFa(Index = 611, Description = "力道格", Tips = "/10")]
        public string StrengthGrid { get; set; }

        /// <summary>
        /// 精妙格
        /// </summary>
        [GongFa(Index = 612, Description = "精妙格", Tips = "/10")]
        public string ExtremelyGrid { get; set; }

        /// <summary>
        /// 迅疾格
        /// </summary>
        [GongFa(Index = 613, Description = "迅疾格", Tips = "/10")]
        public string FastGrid { get; set; }

        /// <summary>
        /// 穿透系数(破体)
        /// </summary>
        [GongFa(Index = 614, Description = "破体", Tips = "破体*90")]
        public decimal PoTi { get; set; }

        /// <summary>
        /// 穿透系数(破气)
        /// </summary>
        [GongFa(Index = 615, Description = "破气", Tips = "破气*90")]
        public decimal PoQi { get; set; }

        /// <summary>
        /// 内功
        /// </summary>
        [GongFa(Index = 604, Description = "内功")]
        public decimal InternalStrength { get; set; }

    }
}
