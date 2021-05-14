using BasicTestingAAMod.NPCs.Bosses;
using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BasicTestingAAMod.NPCs.Bosses
{
    [AutoloadBossHead]
    public class ArmageddonSlime : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Armageddon Slime");
        }
        public override void SetDefaults()
        {
            npc.scale = 1.0f;

            npc.aiStyle = 15;  //5 is the flying AI
            npc.lifeMax = 56250;   //boss life
            npc.damage = 250;  //boss damage
            npc.defense = 40;    //boss defense
            npc.knockBackResist = 0f;
            npc.width = 110;
            npc.height = 166;
            animationType = NPCID.KingSlime;   //this boss will behavior like the DemonEye
            Main.npcFrameCount[npc.type] = 5;    //boss frame/animation 
            npc.value = Item.buyPrice(0, 40, 75, 45);
            npc.npcSlots = 1f;
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
            music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/GelatineThrone");
        }
    }
}