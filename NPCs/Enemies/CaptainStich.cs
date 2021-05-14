using BasicTestingAAMod.NPCs.Enemies;
using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BasicTestingAAMod.NPCs.Enemies
{
    [AutoloadBossHead]
    public class CaptainStich : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Captain Stich");
        }
        public override void SetDefaults()
        {
            npc.scale = 1.0f;
            npc.aiStyle = 0;
            npc.lifeMax = 35000;
            npc.damage = 5;
            npc.defense = 10;
            npc.knockBackResist = 0f;
            npc.width = 32;
            npc.height = 32;
            animationType = NPCID.RainbowSlime;
            Main.npcFrameCount[npc.type] = 4;
            npc.npcSlots = 1f;
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noGravity = false;
            npc.noTileCollide = false;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.buffImmune[24] = true;
            npc.netAlways = true;
            music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/MidBoss");
        }
    }
}