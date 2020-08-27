package MonasteryEvents
{
	function onInitLocation()
	{
		setAchievement("ACH_MONASTERY");
		addJournalLocation(MTY);
	}
	
	function onLoadLocation()
	{
		apmsPlayMusic(custom, 11, 1); // Desert Places
	}
	
	function onGameplayStart()
	{
		//Update compatability
		if(isAlive(5864))
			assignDialogue(MTY_NPC_Guard_01, 9044);
		if(isAlive(5864))
			assignDialogue(MTY_NPC_Youth_01, 5864);
		
		if(isAlive(5860) && dlgOwnsItem(2405, 5860) == 0)
			dlgAddItem(2405, 1, 5860);
		
		if(aod.mty_introDone == false)
		{
			aod.mty_introDone = true;
			ss_start(monastery_intro);
			aod.mty_meetingRaiders = true;
			aod.mty_started = true;
			aod.jnl_elixir = 1;
			dlgTeleportToMarker(TM_PC_Start);
			rwd_location(Monastery);
		}
		
		if(dlgGetItemsCount(1802) >= 1 && aod.jnl_elixir < 7)
		{
			aod.jnl_elixir = 5;
		}
		
		if(aod.mty_leftEarly)
		{
			if(isAlive(5850)) dlgDeleteCharacter(5850);
			if(isAlive(5851)) dlgDeleteCharacter(5851);
			if(isAlive(5852)) dlgDeleteCharacter(5852);
			if(isAlive(5853)) dlgDeleteCharacter(5853);
			if(isAlive(5854)) dlgDeleteCharacter(5854);
			if(isAlive(5855)) dlgDeleteCharacter(5855);
			if(isAlive(5856)) dlgDeleteCharacter(5856);
			if(isAlive(5857)) dlgDeleteCharacter(5857);
			if(isAlive(5860)) {chooseRandomDeathPosition(5860); dlgKillCharacter(5860);}
			if(isAlive(5861)) {chooseRandomDeathPosition(5861); dlgKillCharacter(5861);}
			if(isAlive(5862)) {chooseRandomDeathPosition(5862); dlgKillCharacter(5862);}
			if(isAlive(5863)) {chooseRandomDeathPosition(5863); dlgKillCharacter(5863);}
			if(isAlive(5864)) {chooseRandomDeathPosition(5864); dlgKillCharacter(5864);}
			if(isAlive(5865)) {chooseRandomDeathPosition(5865); dlgKillCharacter(5865);}
			if(isAlive(5866)) {chooseRandomDeathPosition(5866); dlgKillCharacter(5866);}
			if(isAlive(5867)) {chooseRandomDeathPosition(5867); dlgKillCharacter(5867);}
			if(isAlive(5868)) {chooseRandomDeathPosition(5868); dlgKillCharacter(5868);}
			if(isAlive(5870)) {chooseRandomDeathPosition(5870); dlgKillCharacter(5870);}
			if(isAlive(5871)) {chooseRandomDeathPosition(5871); dlgKillCharacter(5871);}
			if(isAlive(5872)) {chooseRandomDeathPosition(5872); dlgKillCharacter(5872);}
			StormStairsOrig.hideObjects();
			if(aod.mty_leftEarlyIntroDone == false)
			{
				ss_start(monastery_intro);
				aod.mty_leftEarlyIntroDone = true;
			}
		}
		
		if(aod.mty_fromInterior)
		{
			aod.mty_fromInterior = false;
			dlgTeleportToMarker(TM_FromInterior);
			dlgCam(135, 45, 20, 1);
		}
		
		if(aod.mty_metDaneusInside && aod.mty_removeRaiders == false)
		{
			if(isAlive(5850)) dlgDeleteCharacter(5850);
			if(isAlive(5851)) dlgDeleteCharacter(5851);
			if(isAlive(5852)) dlgDeleteCharacter(5852);
			if(isAlive(5853)) dlgDeleteCharacter(5853);
			if(isAlive(5854)) dlgDeleteCharacter(5854);
			if(isAlive(5855)) dlgDeleteCharacter(5855);
			if(isAlive(5856)) dlgDeleteCharacter(5856);
			if(isAlive(5857)) dlgDeleteCharacter(5857);
			aod.mty_raidersLeft = true;
		}
		
		if(aod.mty_brokeInside && aod.mty_caughtStealing == false)
		{
			aod.mty_caughtStealing = true;
			apmsStartDialogue(MTY_Villagers_01);
		}
		
		if(aod.mty_bridgePlank)
		{
			setGroupPassability(83, 89, 83, 82, 0, 1);
			OBJ_BridgePlank.showObjects();
		}
		else 
		{
			setGroupPassability(84, 89, 82, 82, 0, 0);
			OBJ_BridgePlank.hideObjects();
		}
		
		if((aod.mty_VillagersWon && aod.mty_exiled == false) || aod.mty_metDaneusInside)
		{
			MTY_activateElevator();
		}
		
		if(aod.mty_exiled)
		{
			MTY_deActivateElevator();
		}
		
		//*************** Party Settings ****
		//***********************************
		
		if(aod.mty_raidersDead == false && aod.fight_mty_storm == 0)
		{
			addParty(MonasteryRaiders, 0);
			addCharToParty(5850, "MonasteryRaiders", "fighter");
			addCharToParty(5851, "MonasteryRaiders", "fighter");
			addCharToParty(5852, "MonasteryRaiders", "fighter");
			addCharToParty(5853, "MonasteryRaiders", "fighter");
			addCharToParty(5854, "MonasteryRaiders", "fighter");
			addCharToParty(5855, "MonasteryRaiders", "fighter");
			addCharToParty(5856, "MonasteryRaiders", "fighter");
			addCharToParty(5857, "MonasteryRaiders", "fighter");
		}
	}
	
	function onLeaveLocation()
	{
		globalOnLeaveLocation();
		if(aod.mty_meetingRaiders)
		{
			aod.mty_leftEarly = true;
			aod.mty_meetingRaiders = false;
			aod.mty_RaidersWon = true;
			aod.jnl_elixir = 4;
		}
	}
	
	function onStartCombat()
	{
		if(aod.mty_meetingRaiders)
		{
			addEnemyToParty(1, MonasteryRaiders);
			sayPhrase(5856, "Kill <him/her>!");
			aod.mty_meetingRaiders = false;
			aod.fight_mtyRaidersOutside = true;
		}
		
		if(aod.mty_VillagersWon && aod.mty_exiled == false && aod.mty_attackedVillagers == false)
		{
			MTY_AttackVillagers();
		}
		
		//Deactivate Elevator VCO
		
		MTY_deActivateElevator();
	}
	
	function onEndCombat()
	{
		apmsPlayMusic(custom, 11, 1); // Desert Places
		
		if(isalive())
		{
			if(aod.fight_mtyUpperWalls)
			{
				BlackSplash.command = "";
				BlackOut.command = "dlgDeleteCharacter(5851); dlgDeleteCharacter(5854);	dlgDeleteCharacter(5856); startBlackSplash();";
				startBlackOut();
				aod.fight_mtyUpperWalls = false;
				aod.mty_RaidersWon = true;
				aod.jnl_elixir = 3;
				aod.fight_mty_storm = 0;
				rwd_fight(Monastery_02);
				dlgRemoveItem(2405, 1, 0, 5860);
			}
			
			if(aod.fight_mtyRaidersOutside)
			{
				aod.fight_mtyRaidersOutside = false;
				rwd_fight(Monastery_01);
				aod.jnl_elixir = 2;
				BlackSplash.command = "";
				BlackOut.command = "sd(MTY_Villagers_01); startBlackSplash();";
				startBlackOut();
			}
			
			if(aod.fight_mtyAgainstVillagers)
			{
				rwd_fight(Monastery_03);
				rwd_reputation(MTY_02);
				aod.fight_mtyAgainstVillagers = false;
			}
			
			if(aod.mty_VillagersWon && aod.mty_exiled == false)
			{
				MTY_activateElevator();
			}
			
			// For Custom Death Screens
			
			deactivateDeathDesc();
		}
	}
	
	function MTY_AttackVillagers()
	{
		addParty(MonasteryDefenders, 0);
		addCharToParty(5870, "MonasteryDefenders", "fighter");
		addCharToParty(5871, "MonasteryDefenders", "fighter");
		addCharToParty(5872, "MonasteryDefenders", "fighter");
		addCharToParty(5860, "MonasteryDefenders", "fighter");
		addCharToParty(5861, "MonasteryDefenders", "fighter");
		addCharToParty(5862, "MonasteryDefenders", "fighter");
		addCharToParty(5863, "MonasteryDefenders", "fighter");
		addCharToParty(5864, "MonasteryDefenders", "fighter");
		addCharToParty(5865, "MonasteryDefenders", "fighter");
		addCharToParty(5866, "MonasteryDefenders", "fighter");
		addCharToParty(5867, "MonasteryDefenders", "fighter");
		addCharToParty(5868, "MonasteryDefenders", "fighter");
		addEnemyToParty(1, MonasteryDefenders);
		aod.mty_attackedVillagers = true;
		aod.fight_mtyAgainstVillagers = true;
	}
	
	function mty_slides()
	{
		if(aod.mty_leftEarly)
		{
			$SS_text = 2;
			$SS_image = "Monastery_intro_02.png";
		}
		else
		{
			$SS_text = 1;
			$SS_image = "Monastery_intro_01.png";
		}
	}
	
	function MTY_StormWalls()
	{
		removeCharFromParty(5850);
		removeCharFromParty(5852);
		removeCharFromParty(5853);
		removeCharFromParty(5855);
		removeCharFromParty(5857);
		aod.mty_meetingRaiders = false;
		createByCharMarker(CM_Monastery_Defender_01);
		createByCharMarker(CM_Monastery_Defender_02);
		createByCharMarker(CM_Monastery_Defender_03);
		addParty(MonasteryDefenders, 0);
		addCharToParty(5870, "MonasteryDefenders", "fighter");
		addCharToParty(5871, "MonasteryDefenders", "fighter");
		addCharToParty(5872, "MonasteryDefenders", "fighter");
		addCharToParty(5863, "MonasteryDefenders", "fighter");
		addCharToParty(5864, "MonasteryDefenders", "fighter");
		addCharToParty(5865, "MonasteryDefenders", "fighter");
		addCharToParty(5866, "MonasteryDefenders", "fighter");
		addCharToParty(5868, "MonasteryDefenders", "fighter");
		addParty(MonasteryStorm, 0);
		addCharToParty(1, "MonasteryStorm", "fighter");
		addCharToParty(5850, "MonasteryStorm", "fighter");
		addCharToParty(5852, "MonasteryStorm", "fighter");
		addCharToParty(5853, "MonasteryStorm", "fighter");
		addCharToParty(5855, "MonasteryStorm", "fighter");
		addCharToParty(5857, "MonasteryStorm", "fighter");
		dlgTeleportToMarker(TM_Storm_Attackers_02);
		dlgTeleportToMarker(TM_Storm_Attackers_01, 5850);
		dlgTeleportToMarker(TM_Storm_Attackers_03, 5852);
		dlgTeleportToMarker(TM_Storm_Attackers_04, 5853);
		dlgTeleportToMarker(TM_Storm_Attackers_05, 5855);
		dlgTeleportToMarker(TM_Storm_Attackers_06, 5857);
		dlgTeleportToMarker(TM_Storm_Leader_02, 5851);
		dlgTeleportToMarker(TM_Storm_Leader_01, 5854);
		dlgTeleportToMarker(TM_Storm_Leader_03, 5856);
		aod.mty_defenderDeathCount = 0;
		StormStairsBack.showObjects();
		StormStairsOrig.hideObjects();
		aod.mty_bridgePlank = true;
		setGroupPassability(83, 89, 83, 82, 0, 1);
		OBJ_BridgePlank.showObjects();
		addEnemyParty(MonasteryDefenders, MonasteryStorm);
		addEnemyParty(MonasteryStorm, MonasteryDefenders);
	}

	function MTY_SecondPhase()
	{
		addCharToParty(5860, "MonasteryDefenders", "fighter");
		addCharToParty(5861, "MonasteryDefenders", "fighter");
		addCharToParty(5862, "MonasteryDefenders", "fighter");
		addCharToParty(5867, "MonasteryDefenders", "fighter");
		dlgTeleportToMarker(TM_Storm_Walls_01);
		if(isAlive(5850)) dlgTeleportToMarker(TM_Storm_Walls_02, 5850);
		if(isAlive(5852)) dlgTeleportToMarker(TM_Storm_Walls_03, 5852);
		if(isAlive(5853)) dlgTeleportToMarker(TM_Storm_Walls_04, 5853);
		if(isAlive(5855)) dlgTeleportToMarker(TM_Storm_Walls_05, 5855);
		if(isAlive(5857)) dlgTeleportToMarker(TM_Storm_Walls_06, 5857);
		dlgTeleportToMarker(TM_Storm_Leader_02, 5851);
		dlgTeleportToMarker(TM_Storm_Leader_01, 5854);
		dlgTeleportToMarker(TM_Storm_Leader_03, 5856);
		if(isAlive(5865)) dlgTeleportToMarker(TM_Storm_Defenders_01, 5865);
		if(isAlive(5866)) dlgTeleportToMarker(TM_Storm_Defenders_05, 5866);
		if(isAlive(5863)) dlgTeleportToMarker(TM_Storm_Defenders_06, 5863);
		if(isAlive(5864)) dlgTeleportToMarker(TM_Storm_Defenders_02, 5864);
		if(isAlive(5868)) dlgTeleportToMarker(TM_Storm_Defenders_08, 5868);
		if(isAlive(5867)) dlgTeleportToMarker(TM_Storm_Defenders_07, 5867);
		if(isAlive(5860)) dlgTeleportToMarker(TM_Storm_Defenders_09, 5860);
		if(isAlive(5861)) dlgTeleportToMarker(TM_Storm_Defenders_03, 5861);
		if(isAlive(5862)) dlgTeleportToMarker(TM_Storm_Defenders_04, 5862);
		StormStairsWalls.showObjects();
		StormStairsBack.hideObjects();
		dlgTeleportToMarker(TM_Storm_Leader_05, 5851);
		dlgTeleportToMarker(TM_Storm_Leader_04, 5856);
		dlgTeleportToMarker(TM_Storm_Leader_06, 5854);
		aod.fight_mtyUpperWalls = true;
		if(isAlive(5870)) killRandomDeathPosition(5870);
		if(isAlive(5871)) killRandomDeathPosition(5871);
		if(isAlive(5872)) killRandomDeathPosition(5872);
	}

	function MTY_Delegation()
	{
		createByCharMarker(CM_Monastery_Defender_01);
		createByCharMarker(CM_Monastery_Defender_02);
		createByCharMarker(CM_Monastery_Defender_03);
		dlgTeleportToMarker(TM_Delegation_PC);
		dlgTeleportToMarker(TM_Delegation_01, 5860);
		dlgTeleportToMarker(TM_Delegation_02, 5863);
		dlgTeleportToMarker(TM_Delegation_03, 5864);
		dlgTeleportToMarker(TM_Villager_01, 5861);
		dlgTeleportToMarker(TM_Villager_02, 5862);
		dlgTeleportToMarker(TM_Villager_05, 5865);
		dlgTeleportToMarker(TM_Villager_06, 5866);
		dlgTeleportToMarker(TM_Villager_07, 5867);
		dlgTeleportToMarker(TM_Villager_08, 5868);
		dlgTeleportToMarker(TM_Guard_01, 5870);
		dlgTeleportToMarker(TM_Guard_02, 5871);
		dlgTeleportToMarker(TM_Guard_03, 5872);
		aod.mty_bridgePlank = true;
		setGroupPassability(83, 89, 83, 82, 0, 1);
		OBJ_BridgePlank.showObjects();
		aod.mty_VillagersWon = true;
		aod.jnl_elixir_phase3 = true;
		addParty(MonasteryDefenders, 0);
		addCharToParty(5870, "MonasteryDefenders", "fighter");
		addCharToParty(5871, "MonasteryDefenders", "fighter");
		addCharToParty(5872, "MonasteryDefenders", "fighter");
		addCharToParty(5860, "MonasteryDefenders", "fighter");
		addCharToParty(5861, "MonasteryDefenders", "fighter");
		addCharToParty(5862, "MonasteryDefenders", "fighter");
		addCharToParty(5863, "MonasteryDefenders", "fighter");
		addCharToParty(5864, "MonasteryDefenders", "fighter");
		addCharToParty(5865, "MonasteryDefenders", "fighter");
		addCharToParty(5866, "MonasteryDefenders", "fighter");
		addCharToParty(5867, "MonasteryDefenders", "fighter");
		addCharToParty(5868, "MonasteryDefenders", "fighter");
		MTY_activateElevator();
		if(aod.mty_raidersLeft)
		{
			dlgDeleteCharacter(5850);
			dlgDeleteCharacter(5851);
			dlgDeleteCharacter(5852);
			dlgDeleteCharacter(5853);
			dlgDeleteCharacter(5854);
			dlgDeleteCharacter(5855);
			dlgDeleteCharacter(5856);
			dlgDeleteCharacter(5857);
		}
	}

	function MTY_activateElevator()
	{
		VCO_ElevatorTop.setActive(1);
		VCO_ElevatorBottom.setActive(1);
		OBJ_ElevatorBottom.showObjects();
		OBJ_ElevatorTop.showObjects();
	}

	function MTY_deActivateElevator()
	{
		VCO_ElevatorTop.setActive(0);
		VCO_ElevatorBottom.setActive(0);
		OBJ_ElevatorBottom.hideObjects();
		OBJ_ElevatorTop.hideObjects();
	}
	
	function MTY_Theft()
	{
		dlgTeleportToMarker(TM_Theft_PC);
		dlgTeleportToMarker(TM_Theft_Elder, 5860);
		dlgTeleportToMarker(TM_Theft_01, 5861);
		dlgTeleportToMarker(TM_Theft_02, 5862);
		dlgTeleportToMarker(TM_Theft_03, 5863);
		dlgTeleportToMarker(TM_Theft_04, 5864);
		dlgTeleportToMarker(TM_Theft_05, 5865);
		dlgTeleportToMarker(TM_Theft_06, 5866);
		dlgTeleportToMarker(TM_Theft_07, 5867);
		dlgTeleportToMarker(TM_Theft_08, 5868);
		dlgTeleportToMarker(TM_Theft_09, 5872);
	}
	
	function MTY_After()
	{
		dlgTeleportToMarker(TM_Elder_01, 5860);
		dlgTeleportToMarker(TM_Villager_01, 5861);
		dlgTeleportToMarker(TM_Villager_02, 5862);
		dlgTeleportToMarker(TM_Villager_03, 5863);
		dlgTeleportToMarker(TM_Villager_04, 5864);
		dlgTeleportToMarker(TM_Villager_05, 5865);
		dlgTeleportToMarker(TM_Villager_06, 5866);
		dlgTeleportToMarker(TM_Villager_07, 5867);
		dlgTeleportToMarker(TM_Villager_08, 5868);
		dlgTeleportToMarker(TM_Guard_01, 5870);
		dlgTeleportToMarker(TM_Guard_02, 5871);
		dlgTeleportToMarker(TM_Guard_03, 5872);
	}
	
	function onLootScreenClose()
	{
		
	}
};

useEventPackage(MonasteryEvents);