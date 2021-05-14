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
    public class IZ : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Infinity Zero, Mechanical Malice");
        }
        public override void SetDefaults()
        {
            npc.scale = 1.0f;
            npc.aiStyle = 439;
            npc.lifeMax = 2000000;
            npc.damage = 150;
            npc.defense = 150;
            npc.knockBackResist = 0f;
            npc.width = 48;
            npc.height = 56;
            Main.npcFrameCount[npc.type] = 1;
            npc.npcSlots = 1f;
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = false;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath10;
            npc.buffImmune[24] = true;
            npc.netAlways = true;
            music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/IZ");
        }
    }
}