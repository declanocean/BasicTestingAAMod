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
    public class Shen : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shen Doragon; Discordian Doomsayer");
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
            animationType = NPCID.GolemHead;
            Main.npcFrameCount[npc.type] = 2;
            npc.npcSlots = 1f;
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = false;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.buffImmune[24] = true;
            npc.netAlways = true;
            music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/Shen");
            public override bool Wings();
            npc.(ModNPC)this).get_mod().GetTexture("NPCs/Bosses/ShenWings");
        }
    }
}