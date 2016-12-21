using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GSSimu4oac2
{
    class Data
    {
        //装备名 评分 颜色 图片
        public static string[,] items_body = new string[,]{
        {"","100",}
        };

        public static string[,] items_neck = new string[,]{
        {""},
        {""}
        };

        public static string[,] items_ring = new string[,]{
        {""},
        {""}
        };


        public static string[][] items_weapon = new string[][]{
        new string[]{"无装备","0","黑色",""},
        new string[]{"45级绿色-邪秘","459","绿色",""},
        new string[]{"45级蓝色-卓越神秘","513","蓝色",""},
        new string[]{"14级紫色-传奇","113","紫色",""},
        new string[]{"24级紫色-传奇狂兽","246","紫色",""},
        new string[]{"34级紫色-传奇恶魔","428","紫色",""},
        new string[]{"44级紫色-传奇狂乱","661","紫色",""},
        new string[]{"45级紫色-传奇神秘","713","紫色",""},
        new string[]{"传奇冬怒","713","橙色",""},
        new string[]{"启示1","727","橙色",""},
        new string[]{"启示2","741","橙色",""},
        new string[]{"启示3","755","橙色",""},
        new string[]{"启示4","770","橙色",""},
        new string[]{"启示5","784","橙色",""},
        new string[]{"传奇启示","799","橙色",""},
        new string[]{"诸神1","799","橙色",""},
        new string[]{"诸神2","813","橙色",""},
        new string[]{"诸神3","828","橙色",""},
        new string[]{"诸神4","858","橙色",""},
        new string[]{"诸神5","874","橙色",""},
        new string[]{"猎人尖刺","889","橙色",""},
        new string[]{"荒漠1","905","橙色",""},
        new string[]{"荒漠2","920","橙色",""},
        new string[]{"荒漠3","936","橙色",""},
        new string[]{"荒漠4","952","橙色",""},
        new string[]{"荒漠5","968","橙色",""},
        new string[]{"永恒蔑视","984","橙色",""},
        new string[]{"遗忘者1","1017","橙色",""},
        new string[]{"遗忘者2","1034","橙色",""},
        new string[]{"遗忘者3","1051","橙色",""},
        new string[]{"遗忘者4","1067","橙色",""},
        new string[]{"遗忘者5","1085","橙色",""},
        new string[]{"艾特拉之蔑视","1102","橙色",""}
        };



        public static string[][] dungeon = new string[][]{
            new string[]{"被遗忘的矿场","220","4600"},
            new string[]{"土灵神庙","1400","5600"},
            new string[]{"伊米尔圣谷","2560","5900"},
            new string[]{"腐蚀之地","4050","6100"},
            new string[]{"幻术师舞台","6300","6500"},
            new string[]{"灰石堡垒之战","6500","6800"},
            new string[]{"灰石堡垒之战：救赎","6500","6900"},
            new string[]{"流沙秘境","7100","7800"},
            new string[]{"返回流沙秘境","7300","8000"},
            new string[]{"巫王之墓","4400","9700"},
            new string[]{"琥珀社高塔","N/A","N/A"},

        };
    }
}
