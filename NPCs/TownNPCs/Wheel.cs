using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Events;

namespace BasicTestingAAMod.NPCs.TownNPCs
{
	[AutoloadHead]
	public class Wheel : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wheel");
		}
		public override bool Autoload(ref string name)
		{
			name = "Wheel";
			return mod.Properties.Autoload;
		}
		public override void SetDefaults()
		{
			npc.townNPC = true;
			npc.friendly = true;
			npc.width = 18;
			npc.height = 40;
			npc.aiStyle = 7;
			npc.damage = 30;
			npc.defense = 50;
			npc.lifeMax = 500;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.knockBackResist = 0.5f;
			Main.npcFrameCount[npc.type] = 4;
			//NPCID.Sets.ExtraFramesCount[npc.type] = 1;
			NPCID.Sets.AttackFrameCount[npc.type] = 1;
			NPCID.Sets.DangerDetectRange[npc.type] = 700;
			NPCID.Sets.AttackType[npc.type] = 0;
			NPCID.Sets.AttackTime[npc.type] = 90;
			NPCID.Sets.AttackAverageChance[npc.type] = 30;
			//NPCID.Sets.HatOffsetY[npc.type] = 4;
			//NPCID.Sets.ExtraTextureCount[npc.type] = 1;
			animationType = NPCID.RainbowSlime;
		}
		public override bool CanTownNPCSpawn(int numTownNPCs, int money)
		{
			if (NPC.downedBoss1)
			{
				return true;
			}

			return false;// this make that he will spawn when a house is available
		}



		public override string TownNPCName()
		{                                       //NPC names
			switch (WorldGen.genRand.Next(1))
			{
				default:
					return "Wheelie";
			}
		}




		public override string GetChat()
		{                                           //npc chat
			if (BirthdayParty.PartyIsUp == true && Main.rand.Next(5) == 0)
			{
				return "MMMMMM... ";
			}
			switch (Main.rand.Next(11))
			{
				case 0:
					return "MMMMMM MMMM";
				case 1:
					return "M M M M M M MM! M MM...";
				case 2:
					return "M MM M M MM M M?";
				case 3:
					return "M M M M M MMM?";
				case 4:
					return "M MM MM?";
				case 5:
					return "MM M M M M M M?";
				case 6:
					return "M M MMMM M, M M M MM M M";
				case 7:
					return "M M M M M M...";
				case 8:
					return "M MM M MM... MM M M MM M...";
				case 9:
					return "M M M M M MMM MM M?";
				case 10:
					return "*Cough* M M M M M MM?";
				default:
					return "MMM M M, MM M MMM";
			}
		}

		public override void SetChatButtons(ref string button, ref string button2)
		{
			button = Lang.inter[28].Value;
		}

		public override void OnChatButtonClicked(bool firstButton, ref bool shop)
		{
			if (firstButton)
			{
				shop = true;
			}
		}

		public override void SetupShop(Chest shop, ref int nextSlot)
		{
			shop.item[nextSlot].SetDefaults(mod.ItemType("BasicTestSword"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("WheelieKid"));
			nextSlot++;
			//shop.item[nextSlot].SetDefaults(mod.ItemType("MabiGlasses"));
			//nextSlot++;
			if (NPC.downedBoss3)
			{
				shop.item[nextSlot].SetDefaults(mod.ItemType("Shredder"));
				nextSlot++;
			}
			if (NPC.downedPlantBoss)
			{
				shop.item[nextSlot].SetDefaults(mod.ItemType("Decoration_Bulb"));
				nextSlot++;
			}
			if (NPC.downedAncientCultist)
			{
				shop.item[nextSlot].SetDefaults(mod.ItemType("LunaticCultistPainting"));
				nextSlot++;
			}
			if (NPC.downedMoonlord)
			{
				shop.item[nextSlot].SetDefaults(mod.ItemType("GodOfTerraria"));
				nextSlot++;
			}
		}
		public override void TownNPCAttackStrength(ref int damage, ref float knockback)
		{
			if (!Main.hardMode)
			{
				damage = 20;
				knockback = 4f;
			}
			else if (Main.hardMode)
			{
				if (!NPC.downedAncientCultist)
				{
					damage = 60;
					knockback = 8f;
				}
				else if (NPC.downedAncientCultist)
				{
					damage = 110;
					knockback = 12f;
				}
			}
		}

		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
		{
			cooldown = 30;
			randExtraCooldown = 30;
		}

		public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
		{
			if (!Main.hardMode)
			{
				projType = 698;
				attackDelay = 1;
			}
			else if (Main.hardMode)
			{
				if (!NPC.downedAncientCultist)
				{
					projType = mod.ProjectileType("DeathProj");
					attackDelay = 1;
				}
				else if (NPC.downedAncientCultist)
				{
					projType = 636;
					attackDelay = 1;
				}
			}
		}

		public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
		{
			multiplier = 12f;
			randomOffset = 2f;
		}
		/*
		public override void ModifyBuffTip(int type, ref string tip, ref int rare)
		{
			tip = "oooo look a PONY";
		}
		*/
	}
}