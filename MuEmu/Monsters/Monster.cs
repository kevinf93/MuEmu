﻿using MuEmu.Resources;
using MuEmu.Resources.Map;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MuEmu.Monsters
{
    public class Monster
    {
        public ushort Index { get; set; }

        public ObjectType Type { get; set; }
        public MonsterBase Info { get; }
        public float Life { get; set; }
        public float Mana { get; set; }

        public Maps MapID { get; set; }
        public MapInfo Map { get; }
        public Point Position { get; set; }
        public byte Direction { get; set; }
        public List<Item> ItemBag { get; set; }

        public int Attack => Info.Attack + (new Random().Next(Info.DmgMin,Info.DmgMax));
        public int Defense => Info.Defense;

        public Monster(ushort Monster, ObjectType type, Maps mapID, Point position, byte direction)
        {
            Type = type;
            MapID = mapID;
            Position = position;
            Direction = direction;
            Info = MonstersMng.Instance.MonsterInfo[Monster];
            Life = Info.HP;
            Mana = Info.MP;
            Map = ResourceCache.Instance.GetMaps()[MapID];
            Map.Monsters.Add(this);
        }
    }
}