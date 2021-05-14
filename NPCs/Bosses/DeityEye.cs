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
    public class DeityEye : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fence Eye");
        }
        public override void SetDefaults()
        {
            npc.scale = 1.0f;
            npc.aiStyle = 4;
            npc.lifeMax = 350000;
            npc.damage = 50;
            npc.defense = 150;
            npc.knockBackResist = 0f;
            npc.width = 58;
            npc.height = 108;
            animationType = NPCID.EyeofCthulhu;
            Main.npcFrameCount[npc.type] = 6;
            npc.npcSlots = 1f;
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
            npc.HitSound = SoundID.NPCHit4;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.buffImmune[24] = true;
            npc.netAlways = true;
            music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/ItSeesEverything");
        }
    }
}