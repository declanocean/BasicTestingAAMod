public void AI() {
	npc.ai[0]++;
	Player P = Main.player[npc.target];
	for (int i = 0; i < npc.buffType.Length; i++)
	{
		if(npc.buffType[i] == Config.buffID["Freeze"])
		{
			npc.DelBuff(i);
			i=0;
		}
	}
	if (npc.target < 0 || npc.target == 255 || Main.player[npc.target].dead || !Main.player[npc.target].active)
	{
		npc.TargetClosest(true);
	}
	npc.netUpdate = true;
	if (npc.ai[0] < 500)
	{
		if (P.position.X < npc.position.X)
		{
			if (npc.velocity.X > -8) npc.velocity.X -= 0.22f;
		}

		if (P.position.X > npc.position.X)
		{
			if (npc.velocity.X < 8) npc.velocity.X += 0.22f;
		}

		if (P.position.Y < npc.position.Y+250)
		{
			if (npc.velocity.Y < 0)
			{
				if (npc.velocity.Y > -4) npc.velocity.Y -= 0.7f;
			}
			else npc.velocity.Y -= 0.6f;
		}

		if (P.position.Y > npc.position.Y+250)
		{
			if (npc.velocity.Y > 0)
			{
				if (npc.velocity.Y < 4) npc.velocity.Y += 0.8f;
			}
			else npc.velocity.Y += 0.6f;
		}
		npc.ai[1]++;
		if (npc.ai[1] >= 90)
		{
			float Speed = 8f;
			Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
			int damage = 40;
			int type = Config.projDefs.byName["Halo"].type;
			Main.PlaySound(2, (int) npc.position.X, (int) npc.position.Y, 17);
			float rotation = (float) Math.Atan2(vector8.Y-(P.position.Y+(P.height * 0.5f)), vector8.X-(P.position.X+(P.width * 0.5f)));
			int num54 = Projectile.NewProjectile(vector8.X, vector8.Y,(float)((Math.Cos(rotation) * Speed)*-1),(float)((Math.Sin(rotation) * Speed)*-1), type, damage, 0f, 0);
			if (Main.netMode == 2)
			{
				NetMessage.SendData(27, -1, -1, "", num54, 0f, 0f, 0f, 0);
			}
			npc.ai[1] = 0;
		}
		if (Main.player[npc.target].position.Y + 75 < npc.position.Y)
		{
			npc.ai[2]++;
			if (npc.ai[2] >= 30)
			{
				float Speed = 8f;
				Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
				int damage = 20;
				int type = Config.projDefs.byName["Halo"].type;
				Main.PlaySound(2, (int) npc.position.X, (int) npc.position.Y, 17);
				float rotation = (float) Math.Atan2(vector8.Y-(P.position.Y+(P.height * 0.5f)), vector8.X-(P.position.X+(P.width * 0.5f)));
				int num54 = Projectile.NewProjectile(vector8.X, vector8.Y,(float)((Math.Cos(rotation) * Speed)*-1),(float)((Math.Sin(rotation) * Speed)*-1), type, damage, 0f, 0);
				if (Main.netMode == 2)
				{
					NetMessage.SendData(27, -1, -1, "", num54, 0f, 0f, 0f, 0);
				}
				npc.ai[2] = 0;
			}
		}
	}
	else if (npc.ai[0] >= 500 && npc.ai[0] < 600)
	{
		npc.velocity.X *= 0.98f;
		npc.velocity.Y *= 0.98f;
		Vector2 vector8 = new Vector2(npc.position.X + (npc.width * 0.5f), npc.position.Y + (npc.height / 2));
		if ((npc.velocity.X < 1.5f) && (npc.velocity.X > -1.5f) && (npc.velocity.Y < 1.5f) && (npc.velocity.Y > -1.5f))
		{
			float rotation = (float) Math.Atan2((vector8.Y)-(Main.player[npc.target].position.Y+(Main.player[npc.target].height * 0.5f)), (vector8.X)-(Main.player[npc.target].position.X+(Main.player[npc.target].width * 0.5f)));
			npc.velocity.X = (float) (Math.Cos(rotation) * 15)*-1;
			npc.velocity.Y = (float) (Math.Sin(rotation) * 15)*-1;
		}
	}
	else if (npc.ai[0] >= 600 && npc.ai[0] < 850)
	{
		if (Main.player[npc.target].position.X < npc.position.X)
		{
			if (npc.velocity.X > -8) npc.velocity.X -= 0.22f;
		}

		if (Main.player[npc.target].position.X > npc.position.X)
		{
			if (npc.velocity.X < 8) npc.velocity.X += 0.22f;
		}

		if (Main.player[npc.target].position.Y < npc.position.Y+250)
		{
			if (npc.velocity.Y < 0)
			{
				if (npc.velocity.Y > -4) npc.velocity.Y -= 0.7f;
			}
			else npc.velocity.Y -= 0.6f;
		}

		if (Main.player[npc.target].position.Y > npc.position.Y+250)
		{
			if (npc.velocity.Y > 0)
			{
				if (npc.velocity.Y < 4) npc.velocity.Y += 0.8f;
			}
			else npc.velocity.Y += 0.6f;
		}
		npc.ai[3]++;
		if (npc.ai[3] >= 50)
		{
			float Speed = 8f;
			Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
			int damage = 45;
			int type = 100;
			Main.PlaySound(2, (int) npc.position.X, (int) npc.position.Y, 33);
			float rotation = (float) Math.Atan2(vector8.Y-(Main.player[npc.target].position.Y+(Main.player[npc.target].height * 0.5f)), vector8.X-(Main.player[npc.target].position.X+(Main.player[npc.target].width * 0.5f)));
			int num54 = Projectile.NewProjectile(vector8.X, vector8.Y,(float)((Math.Cos(rotation) * Speed)*-1),(float)((Math.Sin(rotation) * Speed)*-1), type, damage, 0f, 0);
			if (Main.netMode == 2)
			{
				NetMessage.SendData(27, -1, -1, "", num54, 0f, 0f, 0f, 0);
			}
			//npc.ai[3] = 0;
		}
		if (npc.ai[3] >= 251f)
		{
			float Speed = 8f;
			Vector2 npcPosRef = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
			Main.PlaySound(2, (int)npc.position.X, (int)npc.position.Y, 33);
			float rot = (float) Math.Atan2(npcPosRef.Y-(P.position.Y+(P.height * 0.5f)), npcPosRef.X-(P.position.X+(P.width * 0.5f)));
			for (float f = 0f; f < MathHelper.TwoPi; f += 0.35f)
			{
				Projectile.NewProjectile(npcPosRef.X, npcPosRef.Y, (float)Math.Cos(rot + f) * -Speed, (float)Math.Sin(rot + f) * -Speed, 100, 50, 2.3f, 0);
			}
			npc.ai[3] = 0f;
		}
	}
	else npc.ai[0] = 0;
	if (Main.player[npc.target].dead) npc.TargetClosest(true);
	if (Main.player[npc.target].dead || npc.target == 255 || !Main.player[npc.target].active)
	{
		if (npc.timeLeft > 10) npc.timeLeft = 10;
	}
}
public void NPCLoot()
{
	Gore.NewGore(npc.position,npc.velocity,"Cataryst Head",1.1f,-1);
	Gore.NewGore(npc.position,npc.velocity,"Cataryst Wing 1",1.1f,-1);
	Gore.NewGore(npc.position,npc.velocity,"Cataryst Wing 2",1.1f,-1);
	Gore.NewGore(npc.position,npc.velocity,"Cataryst Halo",1.1f,-1);
	Gore.NewGore(npc.position,npc.velocity,"Cataryst Arm",1.1f,-1);
	Gore.NewGore(npc.position,npc.velocity,"Cataryst Staff",1.1f,-1);
	Gore.NewGore(npc.position,npc.velocity,"Cataryst Boot",1.1f,-1);
	Gore.NewGore(npc.position,npc.velocity,"Cataryst Boot",1.1f,-1);
	ModWorld.Bless();
}