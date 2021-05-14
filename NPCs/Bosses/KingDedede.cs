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
    public class KingDedede : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("King Dedede");
        }
        public override void SetDefaults()
        {
            npc.scale = 1.0f;
            npc.aiStyle = 1;
            npc.lifeMax = 70000;
            npc.damage = 50;
            npc.defense = 100;
            npc.knockBackResist = 0f;
            npc.width = 48;
            npc.height = 56;
            animationType = NPCID.RainbowSlime;
            Main.npcFrameCount[npc.type] = 4;
            npc.npcSlots = 1f;
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noGravity = false;
            npc.noTileCollide = false;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath10;
            npc.buffImmune[24] = true;
            npc.netAlways = true;
            music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/Dedede");
        }
    }
}