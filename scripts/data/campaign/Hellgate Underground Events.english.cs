package HellgateUndergroundEvents
{
	function onInitLocation()
	{
		setAchievement("ACH_HELLGATE");
		setObjectRenderState(laser_1, 1);
		setObjectRenderState(laser_2, 1);
		setObjectRenderState(laser_3, 1);
		setObjectRenderState(laser_4, 1);
		setObjectRenderState(laser_5, 1);
		setObjectRenderState(laser_6, 1);
	}
	
	function onLoadLocation()
	{
		apmsPlayMusic(custom, 4, 1);
		blockTraveling(0);
		
		if(aod.hgt_block_01)
			LevelBlock_01.setCollisionType(None);
		
		if(aod.hgt_block_02)
			LevelBlock_02.setCollisionType(None);
		
		if(aod.hgt_zealot_status == 2)
		{
			aod.hgt_zealot_status = 3;
			createByCharMarker("CM_Mercenary_Hellgate");
			setCharacterInvincible(9101, 1);
			dlgTeleportToMarker(TM_FirstSpecter);
		}
	}
	
	function onGameplayStart()
	{		
		if(aod.HGT_fromUnderground)
		{
			dlgTeleportToMarker(TM_Underground);
			aod.HGT_fromUnderground = false;
		}
		
		if(aod.mty_fromHellgate == 1)
		{
			aod.mty_fromHellgate = 0;
			dlgTeleportToMarker(TM_PortalStart);
			dlgCam(270, 45, 10);
		}
		
		if(isAlive(27011))
			dlgTeleportToMarker(TM_Specter_27011, 27011);
		
		if(isAlive(27012))
			dlgTeleportToMarker(TM_Specter_27012, 27012);
		
		//*************** Party Settings ****
		//***********************************
		
	}
	
	function onLeaveLocation()
	{
		if(aod.npc_bennie_deal && aod.HGT_spear_found && aod.npc_bennie_spear == false && aod.HGT_spear_kept == false)
		{
			aod.HGT_spear_kept = true;
			dlgAddTextBoxMessage("You decided to ignore your promise to Bennie and keep the \'spear\' for yourself.");
			rwd_reputation(HGT_02);
		}
		
		globalOnLeaveLocation();
	}
	
	function onStartCombat()
	{
		aod.fight_specter = 1;
	}
	
	function onEndCombat()
	{
		apmsPlayMusic(custom, 4, 1);
		
		if(isalive())
		{
			aod.fight_specter = 0;
			
			if(aod.fight_hgt_firstSpecter)
			{
				aod.fight_hgt_firstSpecter = 0;
				BlackSplash.command = "";
				BlackOut.command = "sd(HGT_NPC_Bennie_01); startBlackSplash();";
				startBlackOut();
			}
			// For Custom Death Screens
			
			deactivateDeathDesc();
		}
	}
	
	function onLootScreenClose()
	{
		
	}
	
	function HGT_Interior()
	{
		aod.HGT_entranceFromUnderground = true;
		BlackOut.command = "switchMission(\"Hellgate Interior.mis\");";
		startBlackOut();
	}
	
	function HGT_TempleExit()
	{
		if(aod.gnz_finished == false)
			MessageBoxYesNo($phrase_map_leave_ganezzar_01, $phrase_map_leave_ganezzar_02, "leaveGanezzar();", "");
		else
		{
			BlackOut.command = "switchMission(\"The Temple.mis\");";
			startBlackOut();
		}
	}
	
	function HGT_FirstSpecter()
	{
		if(aod.HGT_firstSpecterFinished == 0)
		{
			BlackSplash.command = "";
			BlackOut.command = "sd(HGT_Specter_01); dlgTeleportToMarker(TM_FirstSpecter); startBlackSplash();";
			startBlackOut();
		}
	}
	
	function HGT_Console()
	{
		BlackSplash.command = "";
		BlackOut.command = "sd(HGT_Console_01); dlgTeleportToMarker(TM_Console); startBlackSplash();";
		startBlackOut();
	}
	
	function HGT_SpearChest()
	{
		if(aod.hgt_spear_found == 0)
		{
			BlackSplash.command = "";
			BlackOut.command = "sd(HGT_Spear_01); dlgTeleportToMarker(TM_SpearChest); startBlackSplash();";
			startBlackOut();
		}
		else
			narratePhrase("The chest is empty.");
	}
	
	function HGT_grenade()
	{
		BlackSplash.command = "";
		BlackOut.command = "sd(HGT_grenade_01); VCO_Grenade.setActive(0); startBlackSplash();";
		startBlackOut();
	}
	
	function HGT_LaserDamage(%Laser)
	{
		eval("%LaserIsActive = getObjectRenderState(laser_" @ %Laser @ ");");
		
		if(%LaserIsActive)
		{
			if(dlgGetCharacterHP(1) <= 10)
				aod.fight_desolate = 1;
			
			dlgAddStatPenalty("con", 1);
			dlgChangeCharacterHP(-10);
			narratePhrase("The magical rays burn you for 10 points of damage, reducing your Constitution by 1.");
		}
	}
	
	function HGT_LaserGenerator(%Lasers)
	{
		if(aod.lore + aod.crafting >= 14)
		{
			switch(%Lasers)
			{
				case 1: setObjectRenderState(laser_1, 0); setObjectRenderState(laser_2, 0); setObjectRenderState(laser_5, 0); setObjectRenderState(lasergenerator_01, 0); setObjectRenderState(lasergenerator_01_off, 1); VCO_LaserGenerator_1.setActive(0);
				case 2: setObjectRenderState(laser_3, 0); setObjectRenderState(laser_4, 0); setObjectRenderState(laser_6, 0); setObjectRenderState(lasergenerator_02, 0); setObjectRenderState(lasergenerator_02_off, 1); VCO_LaserGenerator_2.setActive(0);
			}
			
			narratePhrase("\c6[success]\c1 You disabled the generators.");
			rwd_civil(HGT_Generator);
		}
		else
			narratePhrase("[failure] You don't know how to disable them.");
	}
	
	function HGT_SpecterHostile(%Specter)
	{
		if(dlgownsitem(907) == 0 && aod.HGT_specters_deactivated == 0)
		{
			switch(%Specter)
			{
				case 1: if(isAlive(27011) || isAlive(27012)) {dlgSetAttitude(27011, 1, -10); dlgSetAttitude(27012, 1, -10); schedule(100, 0, dlgStartCombat); sayPhrase(27011, "Intruder detected."); sayPhrase(27012, "Eliminate at once.");}
				case 2: if(isAlive(27013)) {dlgSetAttitude(27013, 1, -10);}
				case 3: if(isAlive(27014)) {dlgSetAttitude(27014, 1, -10); schedule(100, 0, dlgStartCombat); sayPhrase(27014, "Intruder detected.");}
				case 4: if(isAlive(27015)) {dlgSetAttitude(27015, 1, -10); schedule(100, 0, dlgStartCombat); sayPhrase(27015, "Intruder detected.");}
				case 5: if(isAlive(27016) || isAlive(27017) || isAlive(27018)) {dlgSetAttitude(27016, 1, -10); dlgSetAttitude(27017, 1, -10); dlgSetAttitude(27018, 1, -10); schedule(100, 0, dlgStartCombat); sayPhrase(27016, "Intruder detected."); sayPhrase(27017, "Eliminate at once.");}
			}
		}
	}
	
	function VCO_Hellgate_Portal()
	{
		aod.mty_fromHellgate = 1;
		BlackOut.command = "switchMission(\"Monastery Interior Chamber.mis\");";
		startBlackOut();
	}
};

useEventPackage(HellgateUndergroundEvents);