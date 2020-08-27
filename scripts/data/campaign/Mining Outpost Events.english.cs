package MiningOutpostEvents
{
	function onInitLocation()
	{
		addJournalLocation(Mine);
	}
	
	function onLoadLocation()
	{
		if(aod.global_teron_completed || aod.weather_teron_dayTime && aod.weather_teron_exterior)
		{
			TeronDayTime();
		}
		
		if(aod.weather_teron_nightTime && aod.weather_teron_exterior)
		{
			TeronNightTime();
		}
	}
	
	function onGameplayStart()
	{
		//blockTraveling(true);
		setCombatAllowed(false);
		
		if(aod.tmo_introDone == false)
		{
			aod.tmo_introDone = true;
			//dlgTeleportToMarker(TM_PC_Start);
			rwd_location(MineOutpost);
		}
		
		if(aod.quest_teronMine_finished && aod.quest_teronMine_complete == false) // This is only for when you didn't complete the quest. It's completed when reporting to Dellar (Teron_Mine_Ending dialogue).
		{
			quest_outpost_deleteNPC();
			aod.quest_teronMine_complete = true;
			aod.tmo_setConsequences = 1;
			
			if(aod.global_Teron_IGTookOver && aod.quest_teronMine_blownUp == false)
			{
				quest_outpost_IG();
				VCO_chest_01.setActive(0);
				if(aod.tmo_introDoneIG == false)
				{
					aod.tmo_introDoneIG = true;
					narratePhrase("The Aurelian troops seem to be gone. Judging by the banners, the mine is under control of the Imperial Guards.<nlo><nlo>There is nothing for you to do here anymore.");
				}
			}
			
			else if(aod.global_Teron_Alliance || aod.global_Teron_DaratanWon && aod.quest_teronMine_blownUp == false)
			{
				quest_outpost_Daratan();
				VCO_chest_01.setActive(0);
				if(aod.tmo_introDoneDaratan == false)
				{
					aod.tmo_introDoneDaratan = true;
					narratePhrase("The Aurelian troops seem to be gone. Judging by the banners, the mine is under control of House Daratan. Looks like they managed without you after all.<nlo><nlo>There is nothing for you to do here anymore.");
				}
			}
		}
		
		if(aod.global_teron_completed && aod.tmo_setState < 2) //Checks this once ending slides have played out.
		{
			quest_outpost_deleteNPC();
			aod.tmo_setState = 2;
			
			if(aod.global_Teron_IGTookOver && aod.quest_teronMine_blownUp == false)
			{
				deleteDaratanFaction();
				quest_outpost_IG();
				VCO_chest_01.setActive(0);
				aod.global_teron_mineActive = true;
				MineInteriorDark.hideObjects();
				MineInteriorActive.showObjects();
				if(aod.tmo_autoSolveIntro == false && aod.quest_teronMine_complete == 0)
				{
					aod.tmo_autoSolveIntro = true;
					aod.quest_teronMine_complete = true;
					narratePhrase("The Aurelian troops seem to be gone. Judging by the banners, the mine is under control of the Imperial Guards.<nlo><nlo>There is nothing for you to do here anymore.");
				}
			}
			
			else if(aod.global_Teron_Alliance || aod.global_Teron_DaratanWon && aod.quest_teronMine_blownUp == false)
			{
				quest_outpost_Daratan();
				VCO_chest_01.setActive(0);
				aod.global_teron_mineActive = true;
				MineInteriorDark.hideObjects();
				MineInteriorActive.showObjects();
				if(aod.tmo_autoSolveIntro == false && aod.quest_teronMine_complete == 0)
				{
					aod.tmo_autoSolveIntro = true;
					aod.quest_teronMine_complete = true;
					narratePhrase("The Aurelian troops seem to be gone. Judging by the banners, the mine is under control of House Daratan. Looks like they managed without you after all.<nlo><nlo>There is nothing for you to do here anymore.");
				}
			}
		}
		
		if(aod.quest_teronMine_complete && aod.tmo_setState == 0) // This is for when you completed the quest (reported to Dellar) and return to the location. No ending slides played yet. aod.quest_TeronMine_Complete is set on Teron_Mine_Ending.
		{
			aod.tmo_setState = 1;
			quest_outpost_deleteNPC();
			VCO_chest_01.setActive(0);
			if(aod.quest_teronMine_blownUp == false)
			{
				quest_outpost_Daratan();
			}
		}
		
		if(aod.quest_teronMine_poisoned && aod.mto_appliedPoison == false)
		{
			aod.mto_appliedPoison = true;
			if(aod.quest_teronMine_lowPoison)
				quest_outpost_poisonLow();
			else if(aod.quest_teronMine_mediumPoison)
				quest_outpost_poisonMedium();
			else if(aod.quest_teronMine_highPoison)
				quest_outpost_poisonHigh();
		}
		
		if(aod.teron_outpostDestroyed)
			quest_outpost_destroyMine();
		
		if(aod.teron_outpostAurelian)
			outpost_aurelian.showobjects();
		
		if(aod.teron_outpostDaratan)
			outpost_daratan.showobjects();
		
		if(aod.quest_teronRaider_convincedAttack && aod.tmo_placedEsbenusDellar == false)
		{
			quest_outpost_addNPC();
			createByCharMarker("CM_Bandit_Leader_Mine");
			createByCharMarker("CM_Dellar_Base");
			dlgSetAnimation(anim_beg00_ambient_01, 0.99, 1557);
			dlgChangeCharacterHP(-15, 1557);
			aod.quest_teronRaider_finished = true;
			aod.ending_banditOupost = true;
			aod.ending_outpost_attacked = true;
			aod.quest_teronMine_afterBandits = true;
			aod.tmo_banditsAttacked = 1;
			aod.tmo_placedEsbenusDellar = true;
			dlgTeleportToMarker(TM_Start_PC_01);
			aod.tmo_noTravel = true;
			setTravelingAllowed(0);
			ExitTiles.hideobjects();
			VCO_chest_01.setActive(0);
		}
		
		if(aod.tmo_noTravel)
			ExitTiles.hideobjects();
		
		if(aod.tmo_noTravel == false)
			ExitTiles.showobjects();
		
		if(aod.teron_outpostBarricaded)
		{
			quest_outpost_setBarricade();
			MineBarricadeNormal.hideobjects();
		}
		
		if(aod.teron_outpostBarricaded == false)
		{
			quest_outpost_removeBarricade();
			MineBarricadeNormal.showobjects();
		}
		
		if(aod.gameplay_noTravel == false)
		{
			if(aod.quest_teronMine_isDaratan == false && aod.quest_teronMine_fightOutside == false && aod.quest_teronMine_complete == false)
			{
				//BlackSplash.command = "";
				//BlackOut.command = "apmsstartdialogue(teron_mine_01); startBlackSplash();";
				//startBlackOut();
				/*setPassability(27, 146, 0, 0);
				setPassability(28, 146, 0, 0);
				setPassability(29, 146, 0, 0);
				setPassability(30, 146, 0, 0);
				setPassability(15, 146, 0, 0);
				setPassability(16, 146, 0, 0);
				setPassability(17, 146, 0, 0);
				setPassability(18, 146, 0, 0);*/
			}
			
			if(aod.quest_teronMine_leftBeforeInterior && aod.teron_outpostBarricaded == false)
			{
				dlgTeleportToMarker(TM_Barricade_NPC_01, 1994);
				dlgTeleportToMarker(TM_Barricade_NPC_02, 1996);
				dlgTeleportToMarker(TM_Barricade_NPC_03, 1997);
				if(isAlive(1998)) dlgTeleportToMarker(TM_Barricade_NPC_04, 1998);
				dlgTeleportToMarker(TM_Barricade_NPC_05, 1999);
				if(isAlive(2000)) dlgTeleportToMarker(TM_Barricade_NPC_06, 2000);
				if(isAlive(1998)) cheatHP(1998);
				if(isAlive(2000)) cheatHP(2000);
				cheatHP(1997);
				cheatHP(1999);
				cheatHP(1994);
				cheatHP(1996);
				quest_outpost_setBarricade();
				//dlgdeletedeadcharacters();
				aod.teron_outpostBarricaded = true;
				narratePhrase("The entrance to the camp is barricaded.");
				aod.tmo_trapSet = true;
			}
		}
		
		else
		{
			apmsCloseMapScreen();
			sayPhrase(1, "I can't leave right now.");
		}
		
		//*************** Party Settings ****
		//***********************************
		
		if(aod.tmo_AurelianMineOutsideDead == false)
		{
			addParty(AurelianMineOutside, 0);
			addCharToParty(1990, AurelianMineOutside, fighter);
			addCharToParty(1991, AurelianMineOutside, fighter);
			addCharToParty(1992, AurelianMineOutside, fighter);
			addCharToParty(1993, AurelianMineOutside, fighter);
		}
		
		if(aod.tmo_AurelianMineInsideDead == false)
		{
			addParty(AurelianMineInside, 0);
			addCharToParty(1994, AurelianMineInside, fighter);
			addCharToParty(1996, AurelianMineInside, fighter);
			addCharToParty(1997, AurelianMineInside, fighter);
			addCharToParty(1998, AurelianMineInside, fighter);
			addCharToParty(1999, AurelianMineInside, fighter);
			addCharToParty(2000, AurelianMineInside, fighter);
		}
	}
	
	function onLeaveLocation()
	{
		globalOnLeaveLocation();
		
		if(aod.quest_teronMine_fightOutside && aod.quest_teronMine_fightInside == false && aod.quest_teronMine_leftBeforeInterior == false)
		{
			aod.quest_teronMine_leftBeforeInterior = true;
		}
		
		if(aod.weather_teron_nightTime)
		{
			aod.weather_teron_nightTime = false;
			aod.weather_teron_dayTime = true;
		}
		
		aod.mapScreenDisabled = 0;
	}
	
	function onStartCombat()
	{
		if(aod.tmo_hostile == false)
		{
			aod.tmo_hostile = true;
			aod.gameplay_questMine_fight = true;
		}
		
		if(aod.gameplay_combatHelpShown == false)
		{
			PG_HelpText_02.setVisible(true);
			aod.gameplay_combatHelpShown = true;
			aod.achievements_inFirstFight = true;
			TM_ShowTutorial(combat);
		}
	}
	
	function onEndCombat()
	{
		if(isalive())
		{
			if(aod.fight_TMO_Barricade)
			{
				VCO_RemoveBarricade_01.setActive(1);
				VCO_RemoveBarricade_02.setActive(1);
				VCO_RemoveBarricade_03.setActive(1);
				aod.fight_TMO_Barricade = false;
				aod.quest_teronMine_leftBeforeInterior = false;
				aod.quest_teronMine_fightInside = true;
			}
			
			if(aod.quest_banditCamp_fightEsbenus)
			{
				rwd_fight(TMO_Mine_03);
				BlackOut.command = "apmsLootItemlist(EsbenusMine);";
				startBlackOut();
			}
			
			if(aod.achievements_inFirstFight)
			{
				aod.achievements_inFirstFight = false;
			}
			
			if(aod.quest_banditCamp_fightEsbenus)
			{
				quest_outpost_showNPC();
			}
			
			// For Custom Death Screens
			
			deactivateDeathDesc();
		}
	}
	
	function onLootScreenClose()
	{
		if(aod.quest_banditCamp_fightEsbenus)
		{
			BlackSplash.command = "";
			BlackOut.command = "apmsStartDialogue(TMO_afterBandits_01); dlgAddItem(1600, 1); startBlackSplash();";
			startBlackOut();
		}
	}
	
	function TRG_TMO_StartQuest()
	{
		if(aod.tmo_hostile == false && aod.quest_teronMine_reportToDellar == false && aod.quest_teronRaider_convincedAttack == false && aod.quest_teronMine_complete == false)
		{
			BlackSplash.command = "";
			BlackOut.command = "dlgTeleportToMarker(TM_Start_PC_01); sd(Teron_Mine_01); startBlackSplash();";
			startBlackOut();
		}
	}

	function TRG_TMO_Trap()
	{
		if(aod.tmo_trapSet)
		{
			BlackSplash.command = "";
			BlackOut.command = "aod.tmo_trapSet = false; dlgTeleportToMarker(TM_Trap_PC_01); sd(TMO_Traps_01); startBlackSplash();";
			startBlackOut();
		}
	}

	function VCO_RemoveBarricade()
	{
		BlackSplash.command = "";
		BlackOut.command = "VCO_RemoveBarricade_01.setActive(0); VCO_RemoveBarricade_02.setActive(0); VCO_RemoveBarricade_03.setActive(0); quest_outpost_removeBarricade(); MineBarricadeNormal.showobjects(); startBlackSplash();";
		startBlackOut();
		aod.teron_outpostBarricaded = false;
	}

	function VCO_TMO_MineChest()
	{
		if(VCO_chest_01.cursor $= Eye)
		{
			narratePhrase("It's an old, but sturdy chest with a new lock.");
			VCO_chest_01.setCursor("LockpickCursor");
			VCO_chest_01.setCursorText(6);
		}
		
		else if(VCO_chest_01.cursor $= Lockpick)
		{
			if(dlgOwnsItem(2410))
			{
				VCO_Chest_01.setActive(0);
				VCO_chest_01.setCursor("DefaultCursor");
				dlgAddItem(1600, 1);
				aod.quest_teronMine_tubeStolen = true;
				aod.quest_teronMine_reportToDellar = true;
				narratePhrase("You use the key to open the chest.<nlo><nlo>Inside it you find nothing but a small glass tube encased in elaborate metal framework and wrapped in rags.<nlo>The tube is warm to the touch and contains what appears to be constantly shifting liquid fire, glowing brightly in the poorly lit chamber.");
			}
			else if(aod.lockpick >= 4)
			{
				VCO_Chest_01.setActive(0);
				VCO_chest_01.setCursor("DefaultCursor");
				dlgAddItem(1600, 1);
				aod.quest_teronMine_tubeStolen = true;
				aod.quest_teronMine_reportToDellar = true;
				narratePhrase("[success] The lock is cheap and doesn't put up much of a fight.<nlo>It might have kept the content safe from the slaves working here, but not from someone with your skillset.<nlo><nlo>Inside the chest you find nothing but a small glass tube encased in elaborate metal framework and wrapped in rags.<nlo>The tube is warm to the touch and contains what appears to be constantly shifting liquid fire, glowing brightly in the poorly lit chamber.");
				rwd_civil(Lockpick);
			}
			else
				narratePhrase("[failure] You fail to pick the lock.");
		}
	}

	function VCO_TMO_ControlPanel()
	{
		if(VCO_Panel_01.cursor $= Eye)
		{
			if(aod.lore >= 2)
			{
				VCO_Panel_01.setCursor("GearCursor");
				VCO_Panel_01.setCursorText(7);
				narratePhrase("[lore success] You recognize some machines from drawings in old manuscripts.<nlo>It looks like an ore melting facility, but judging by House Aurelian's interest, it could be more than that.");
			}
			else if(aod.quest_hd1_Smelter)
			{
				VCO_Panel_01.setCursor("GearCursor");
				VCO_Panel_01.setCursorText(7);
				narratePhrase("This must be the ore smelting facility Sohrab told you about.");
			}
			else
				narratePhrase("[lore failure] You have no idea what these machines are.");
		}
		else
		{
			BlackSplash.command = "";
			BlackOut.command = "sd(TMO_ControlPanel_01); startBlackSplash();";
			startBlackOut();
		}
	}

	function TRG_TMO_SneakingExit()
	{
		if(aod.quest_teronMine_sneakExplore && aod.quest_teronMine_killedEveryone == false)
		{
			BlackSplash.command = "";
			BlackOut.command = "dlgTeleportToMarker(TM_SneakExit_PC_01); sd(TMO_SneakingExit_01); startBlackSplash();";
			startBlackOut();
		}
	}

	function TRG_TMO_MineEntranceOutside()
	{
		if(aod.tmo_AurelianMineOutsideDead && aod.tmo_AurelianMineInsideDead == false && aod.tmo_narration_moreInside == false)
		{
			narratePhrase("The men guarding the entrance to the mine are dead, but it's likely that there are more men inside.");
			aod.tmo_narration_moreInside = true;
		}
		
		if(isAlive(2990) && aod.tmo_allowedIntoMine == 0)
		{
			BlackSplash.command = "";
			BlackOut.command = "dlgTeleportToMarker(TM_MineDoorOutside_PC_04); sd(TMO_Decanus_HD); startBlackSplash();";
			startBlackOut();
		}
		
		if(isAlive(2890) && aod.tmo_allowedIntoMine == 0)
		{
			BlackSplash.command = "";
			BlackOut.command = "dlgTeleportToMarker(TM_MineDoorOutside_PC_04); sd(TMO_Decanus_IG); startBlackSplash();";
			startBlackOut();
		}
	}

	function TRG_TMO_travelEnter()
	{
		if(aod.quest_teronMine_reportToDellar)
		{
			BlackSplash.command = "";
			BlackOut.command = "dlgTeleportToMarker(TM_Exit_PC_01); sd(TMO_exitDialogue_01); startBlackSplash();";
			startBlackOut();
		}
		else
			blockTraveling(0);
	}

	function TRG_TMO_travelLeave()
	{
		if(aod.quest_teronMine_reportToDellar == false)
			blockTraveling(1);
	}

	function TRG_TMO_ActivateInteriorFight()
	{
		if(aod.quest_teronMine_fightOutside && aod.quest_teronMine_fightInside == false)
		{
			addEnemyToParty(1, AurelianMineInside);
			aod.quest_teronMine_fightInside = true;
			schedule(250, 0, dlgStartCombat);
			aod.gameplay_questMine_fight = true;
		}
	}
	
	function quest_outpost_destroyMine()
	{
		setgrouppassability(30, 65, 28, 64, 0, 0);
		setgrouppassability(36, 64, 38, 64, 0, 0);
		outpost_destroyed.showobjects();
		OutpostCampFire.hideObjects();
	}

	function quest_outpost_setBarricade()
	{
		mineBarricade01.isRenderEnabled = false;
		mineBarricade01.setCollisionType("None");
		mineBarricade02.isRenderEnabled = false;
		mineBarricade02.setCollisionType("None");
		mineBarricade03.isRenderEnabled = true;
		mineBarricade03.setCollisionType("collision mesh");
		mineBarricade04.isRenderEnabled = true;
		mineBarricade04.setCollisionType("collision mesh");
		setgrouppassability(32, 49, 40, 49, 0, 0);
		setgrouppassability(30, 45, 30, 48, 0, 1);
		setgrouppassability(42, 45, 42, 48, 0, 1);
	}

	function quest_outpost_removeBarricade()
	{
		mineBarricade01.isRenderEnabled = true;
		mineBarricade01.setCollisionType("collision mesh");
		mineBarricade02.isRenderEnabled = true;
		mineBarricade02.setCollisionType("collision mesh");
		mineBarricade03.isRenderEnabled = false;
		mineBarricade03.setCollisionType("None");
		mineBarricade04.isRenderEnabled = false;
		mineBarricade04.setCollisionType("None");
		setgrouppassability(32, 49, 40, 49, 0, 1);
		setgrouppassability(30, 45, 30, 48, 0, 0);
		setgrouppassability(42, 45, 42, 48, 0, 0);
	}

	function quest_outpost_Daratan()
	{
		outpost_daratan.showobjects();
		outpost_aurelian.hideobjects();
		createByCharMarker("CM_Daratan_Captain");
		createByCharMarker("CM_Daratan_Guard_01");
		createByCharMarker("CM_Daratan_Guard_02");
		createByCharMarker("CM_Daratan_Guard_03");
		createByCharMarker("CM_Daratan_Guard_04");
		createByCharMarker("CM_Daratan_Guard_05");
		createByCharMarker("CM_Daratan_Guard_06");
		createByCharMarker("CM_Daratan_Guard_07");
		createByCharMarker("CM_Daratan_Worker_01");
		createByCharMarker("CM_Daratan_Worker_02");
		createByCharMarker("CM_Daratan_Worker_03");
		createByCharMarker("CM_Daratan_Worker_04");
		addParty(DaratanMine, 0);
		addCharToParty(2990, DaratanMine, fighter);
		addCharToParty(2991, DaratanMine, fighter);
		addCharToParty(2992, DaratanMine, fighter);
		addCharToParty(2993, DaratanMine, fighter);
		addCharToParty(29931, DaratanMine, fighter);
		addCharToParty(2995, DaratanMine, fighter);
		addCharToParty(2994, DaratanMine, fighter);
		addCharToParty(2996, DaratanMine, fighter);
		addCharToParty(2997, DaratanMine, fighter);
		addCharToParty(2998, DaratanMine, fighter);
		addCharToParty(2999, DaratanMine, fighter);
		addCharToParty(3000, DaratanMine, fighter);
		aod.teron_outpostDaratan = true;
		aod.teron_outpostAurelian = false;
		dlgSetCharacterTags(TeronCivilianNPC, 2990);
		dlgSetCharacterTags(TeronCivilianNPC, 2991);
		dlgSetCharacterTags(TeronCivilianNPC, 2992);
		dlgSetCharacterTags(TeronCivilianNPC, 2993);
		dlgSetCharacterTags(TeronCivilianNPC, 2994);
		dlgSetCharacterTags(TeronCivilianNPC, 2995);
		dlgSetCharacterTags(TeronCivilianNPC, 2996);
		dlgSetCharacterTags(TeronCivilianNPC, 2997);
		dlgSetCharacterTags(TeronCivilianNPC, 2998);
		dlgSetCharacterTags(TeronCivilianNPC, 2999);
		dlgSetCharacterTags(TeronCivilianNPC, 3000);
		if(aod.quest_teronMine_leftBeforeInterior)
		{
			quest_outpost_removeBarricade();
			aod.teron_outpostBarricaded = false;
		}
	}

	function quest_outpost_IG()
	{
		outpost_guards.showobjects();
		outpost_aurelian.hideobjects();
		outpost_daratan.hideobjects();
		createByCharMarker("CM_IG_Captain");
		createByCharMarker("CM_IG_Guard_01");
		createByCharMarker("CM_IG_Guard_02");
		createByCharMarker("CM_IG_Guard_03");
		createByCharMarker("CM_IG_Guard_04");
		createByCharMarker("CM_IG_Guard_05");
		createByCharMarker("CM_IG_Guard_06");
		createByCharMarker("CM_IG_Guard_07");
		createByCharMarker("CM_IG_Worker_01");
		createByCharMarker("CM_IG_Worker_02");
		createByCharMarker("CM_IG_Worker_03");
		createByCharMarker("CM_IG_Worker_04");
		addParty(IGMine, 0);
		addCharToParty(2890, IGMine, fighter);
		addCharToParty(2891, IGMine, fighter);
		addCharToParty(2892, IGMine, fighter);
		addCharToParty(2893, IGMine, fighter);
		addCharToParty(28931, IGMine, fighter);
		addCharToParty(2895, IGMine, fighter);
		addCharToParty(2894, IGMine, fighter);
		addCharToParty(2896, IGMine, fighter);
		addCharToParty(2897, IGMine, fighter);
		addCharToParty(2898, IGMine, fighter);
		addCharToParty(2899, IGMine, fighter);
		addCharToParty(2900, IGMine, fighter);
		aod.teron_outpostIG = true;
		aod.teron_outpostAurelian = false;
		aod.teron_outpostDaratan = false;
		if(aod.quest_teronMine_leftBeforeInterior)
		{
			quest_outpost_removeBarricade();
			aod.teron_outpostBarricaded = false;
		}
	}

	function quest_outpost_createNPC()
	{
		dlgCreateCharacter("Aurelian Captain", 1990, 1990, 22, 154, 0, S);
		dlgCreateCharacter("Aurelian Soldier", 1991, 1991, 26, 149, 0, SE);
		dlgCreateCharacter("Aurelian Soldier", 1992, 1992, 27, 156, 0, SW);
		dlgCreateCharacter("Aurelian Soldier", 1993, 1993, 23, 144, 1, S);
		dlgCreateCharacter("Aurelian Soldier", 1994, 1994, 68, 206, 0, S);
		dlgCreateCharacter("Aurelian Soldier", 1996, 1996, 75, 219, 0, E);
		dlgCreateCharacter("Aurelian Worker", 1997, 1997, 24, 169, 0, E);
		dlgCreateCharacter("Aurelian Worker", 1998, 1998, 30, 166, 0, N);
		dlgCreateCharacter("Aurelian Worker", 1999, 1999, 73, 242, 0, N);
		dlgCreateCharacter("Aurelian Worker", 2000, 2000, 85, 221, 0, W);
		addParty(AurelianMineOutside, 0);
		addCharToParty(1990, AurelianMineOutside, fighter);
		addCharToParty(1991, AurelianMineOutside, fighter);
		addCharToParty(1992, AurelianMineOutside, fighter);
		addCharToParty(1993, AurelianMineOutside, fighter);
		addParty(AurelianMineInside, 0);
		addCharToParty(1994, AurelianMineInside, fighter);
		addCharToParty(1996, AurelianMineInside, fighter);
		addCharToParty(1997, AurelianMineInside, fighter);
		addCharToParty(1998, AurelianMineInside, fighter);
		addCharToParty(1999, AurelianMineInside, fighter);
		addCharToParty(2000, AurelianMineInside, fighter);
		assignCombatScheme(hightrained, 1990);
		assignCombatScheme(trained, 1991);
		assignCombatScheme(trained, 1992);
		assignCombatScheme(trained, 1993);
		assignCombatScheme(trained, 1994);
		assignCombatScheme(trained, 1996);
	}

	function quest_outpost_poisonLow()
	{
		dlgChangeCharacterHP(-20, 1990);
		dlgChangeCharacterHP(-20, 1991);
		dlgChangeCharacterHP(-25, 1992);
		dlgChangeCharacterHP(-20, 1993);
		dlgChangeCharacterHP(-20, 1994);
		dlgChangeCharacterHP(-20, 1996);
		dlgChangeCharacterHP(-20, 1997);
		dlgChangeCharacterHP(-25, 1998);
		dlgChangeCharacterHP(-20, 1999);
		dlgChangeCharacterHP(-25, 1999);
		aod.quest_mineWine_poisonedLow = true;
	}

	function quest_outpost_poisonMedium()
	{
		dlgChangeCharacterHP(-25, 1990);
		dlgChangeCharacterHP(-25, 1991);
		dlgChangeCharacterHP(-30, 1992);
		dlgChangeCharacterHP(-25, 1993);
		dlgChangeCharacterHP(-25, 1994);
		dlgChangeCharacterHP(-25, 1996);
		dlgChangeCharacterHP(-25, 1997);
		dlgChangeCharacterHP(-30, 1998);
		dlgChangeCharacterHP(-25, 1999);
		dlgTeleportTo(50, 60, 0, E, 2000);
		dlgSetAnimation(anim_death_back04, 0.95, 2000);
		dlgKillCharacter(2000);
		aod.quest_mineWine_poisonedMedium = true;
	}

	function quest_outpost_poisonHigh()
	{
		dlgChangeCharacterHP(-25, 1990);
		dlgChangeCharacterHP(-30, 1991);
		dlgTeleportTo(50, 60, 0, E, 1992);
		dlgSetAnimation(anim_death_back04, 0.95, 1992);
		dlgKillCharacter(1992);
		dlgChangeCharacterHP(-25, 1993);
		dlgChangeCharacterHP(-25, 1994);
		dlgChangeCharacterHP(-25, 1996);
		dlgChangeCharacterHP(-25, 1997);
		dlgTeleportTo(50, 59, 0, E, 1998);
		dlgSetAnimation(anim_death_back04, 0.95, 1998);
		dlgKillCharacter(1998);
		dlgChangeCharacterHP(-25, 1999);
		dlgTeleportTo(50, 58, 0, E, 2000);
		dlgSetAnimation(anim_death_back04, 0.95, 2000);
		dlgKillCharacter(2000);
		aod.quest_mineWine_poisonedHigh = true;
	}

	function quest_outpost_deleteNPC()
	{
		dlgDeleteCharacter(1551);
		dlgDeleteCharacter(1553);
		dlgDeleteCharacter(1554);
		dlgDeleteCharacter(1555);
		dlgDeleteCharacter(1556);
		dlgDeleteCharacter(1990);
		dlgDeleteCharacter(1991);
		dlgDeleteCharacter(1992);
		dlgDeleteCharacter(1993);
		dlgDeleteCharacter(1994);
		dlgDeleteCharacter(1996);
		dlgDeleteCharacter(1997);
		dlgDeleteCharacter(1998);
		dlgDeleteCharacter(1999);
		dlgDeleteCharacter(2000);
	}

	function quest_outpost_addNPC()
	{
		dlgCreateCharacter("賊", 1551, 1551, 31, 44, 0, N);
		dlgCreateCharacter("賊", 1555, 1553, 38, 48, 0, E);
		dlgCreateCharacter("賊", 1556, 1554, 35, 43, 0, W);
		dlgCreateCharacter("賊", 1553, 1555, 41, 42, 0, NW);
		dlgCreateCharacter("賊", 1554, 1556, 42, 44, 0, SE);
		dlgUnequipHands(1551);
		dlgUnequipHands(1553);
		dlgUnequipHands(1554);
		dlgUnequipHands(1555);
		dlgUnequipHands(1556);
		dlgUnequipHands(1990);
		dlgUnequipHands(1991);
		dlgUnequipHands(1992);
		dlgUnequipHands(1993);
		dlgSetAnimation(anim_death_forward00, 0.95, 1551);
		dlgSetAnimation(anim_death_back00, 0.95, 1553);
		dlgSetAnimation(anim_death_forward01, 0.95, 1554);
		dlgSetAnimation(anim_death_forward02, 0.95, 1555);
		dlgSetAnimation(anim_death_back02, 0.95, 1556);
		dlgSetAnimation(anim_death_forward03, 0.95, 1990);
		dlgSetAnimation(anim_death_back03, 0.95, 1991);
		dlgSetAnimation(anim_death_back04, 0.95, 1992);
		dlgSetAnimation(anim_death_forward00, 0.95, 1993);
		setCharacterInvincible(1551, 1);
		setCharacterInvincible(1553, 1);
		setCharacterInvincible(1554, 1);
		setCharacterInvincible(1555, 1);
		setCharacterInvincible(1556, 1);
		setCharacterInvincible(1990, 1);
		setCharacterInvincible(1991, 1);
		setCharacterInvincible(1992, 1);
		setCharacterInvincible(1993, 1);
		dlgDeleteCharacter(1994);
		dlgDeleteCharacter(1996);
		dlgDeleteCharacter(1997);
		dlgDeleteCharacter(1998);
		dlgDeleteCharacter(1999);
		dlgDeleteCharacter(2000);
	}
	
	function quest_outpost_hideNPC()
	{
		setCharacterRendered(1551, 0);
		setCharacterRendered(1553, 0);
		setCharacterRendered(1554, 0);
		setCharacterRendered(1555, 0);
		setCharacterRendered(1556, 0);
		setCharacterRendered(1990, 0);
		setCharacterRendered(1991, 0);
		setCharacterRendered(1992, 0);
		setCharacterRendered(1993, 0);
	}
	
	function quest_outpost_showNPC()
	{
		setCharacterRendered(1551, 1);
		setCharacterRendered(1553, 1);
		setCharacterRendered(1554, 1);
		setCharacterRendered(1555, 1);
		setCharacterRendered(1556, 1);
		setCharacterRendered(1990, 1);
		setCharacterRendered(1991, 1);
		setCharacterRendered(1992, 1);
		setCharacterRendered(1993, 1);
		dlgSetAnimation(anim_death_forward00, 0.95, 1551);
		dlgSetAnimation(anim_death_back00, 0.95, 1553);
		dlgSetAnimation(anim_death_forward01, 0.95, 1554);
		dlgSetAnimation(anim_death_forward02, 0.95, 1555);
		dlgSetAnimation(anim_death_back02, 0.95, 1556);
		dlgSetAnimation(anim_death_forward03, 0.95, 1990);
		dlgSetAnimation(anim_death_back03, 0.95, 1991);
		dlgSetAnimation(anim_death_back04, 0.95, 1992);
		dlgSetAnimation(anim_death_forward00, 0.95, 1993);
	}
	
	function deleteDaratanFaction()
	{
		dlgDeleteCharacter(2990);
		dlgDeleteCharacter(2991);
		dlgDeleteCharacter(2992);
		dlgDeleteCharacter(2993);
		dlgDeleteCharacter(29931);
		dlgDeleteCharacter(2994);
		dlgDeleteCharacter(2995);
		dlgDeleteCharacter(2996);
		dlgDeleteCharacter(2997);
		dlgDeleteCharacter(2998);
		dlgDeleteCharacter(2999);
		dlgDeleteCharacter(3000);
	}
	
	function mapScreenButtonScripts()
	{
		if(aod.quest_teronMine_reportToDellar)
		{
			MessageBoxYesNo("Mining Outpost", "Return to Teron and report to Dellar?", "aod.mapScreenDisabled = 0; TMO_Report();", "");
		}
		else
			apmsStartMapScreen();
	}
	
	function TMO_Report()
	{
		if(aod.teron_outpostBarricaded)
		{
			VCO_RemoveBarricade_01.setActive(0); 
			VCO_RemoveBarricade_02.setActive(0); 
			VCO_RemoveBarricade_03.setActive(0); 
			aod.teron_outpostBarricaded = false;
			aod.tmo_trapSet = false;
		}
		
		BlackOut.command = "switchMission(\"Teron.mis\");";
		startBlackOut();
	}
	
	//Cheats
	
	function winFightMineOutside()
	{
		dlgKillCharacter(1990);
		dlgKillCharacter(1991);
		dlgKillCharacter(1992);
		dlgKillCharacter(1993);
	}

	function winFightMineInside()
	{
		dlgKillCharacter(1994);
		dlgKillCharacter(1996);
		dlgKillCharacter(1997);
		dlgKillCharacter(1998);
		dlgKillCharacter(1999);
		dlgKillCharacter(2000);
	}
	
	function moveNPCoutside()
	{
		dlgTeleportToMarker(TM_Night_NPC_01, 1994);
		dlgTeleportToMarker(TM_Night_NPC_02, 1996);
		dlgTeleportToMarker(TM_Night_NPC_03, 1997);
		dlgTeleportToMarker(TM_Night_NPC_04, 1998);
		dlgTeleportToMarker(TM_Night_NPC_05, 1999);
		dlgTeleportToMarker(TM_Night_NPC_06, 2000);
		dlgUnequipHands(1994);
		dlgUnequipHands(1996);
		dlgSetAnimation(anim_sit_ground_00_00, 0, 1994);
		dlgSetAnimation(anim_sit_ground_02_00, 0, 1996);
		dlgSetAnimation(anim_sit_ground_01_00, 0, 1997);
		dlgSetAnimation(anim_beg00_ambient_01, 0, 1998);
		dlgSetAnimation(anim_sit_ground_00_02, 0, 1999);
		dlgSetAnimation(anim_sit_ground_00_00, 0, 2000);
	}
	
	function moveNPCinside()
	{
		dlgEquipItem(122, 0, 1994);
		dlgEquipItem(1700, 0, 1994);
		dlgEquipItem(140, 0, 1996);
		dlgEquipItem(1702, 0, 1996);
		dlgSetAmbientAnimation(1994);
		dlgSetAmbientAnimation(1996);
		dlgSetAmbientAnimation(1997);
		dlgSetAmbientAnimation(1998);
		dlgSetAmbientAnimation(1999);
		dlgSetAmbientAnimation(2000);
		dlgTeleportToMarker(TM_Inside_NPC_01, 1994);
		dlgTeleportToMarker(TM_Inside_NPC_02, 1996);
		dlgTeleportToMarker(TM_Inside_NPC_03, 1997);
		dlgTeleportToMarker(TM_Inside_NPC_04, 1998);
		dlgTeleportToMarker(TM_Inside_NPC_05, 1999);
		dlgTeleportToMarker(TM_Inside_NPC_06, 2000);
	}
};

useEventPackage(MiningOutpostEvents);