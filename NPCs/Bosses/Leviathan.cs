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
    public class Leviathan : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Leviathan");
        }
        public override void SetDefaults()
        {
            npc.scale = 1.0f;
            npc.aiStyle = 222;
            npc.lifeMax = 350000;
            npc.damage = 50;
            npc.defense = 150;
            npc.knockBackResist = 0f;
            npc.width = 214;
            npc.height = 146;
            animationType = NPCID.DukeFishron;
            Main.npcFrameCount[npc.type] = 8;
            npc.npcSlots = 1f;
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath10;
            npc.buffImmune[24] = true;
            npc.netAlways = true;
            music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/LeviathanAndSiren");
        }
    }
}