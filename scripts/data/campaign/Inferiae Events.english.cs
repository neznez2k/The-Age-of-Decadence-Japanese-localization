package InferiaeEvents
{
	function onInitLocation()
	{
		setAchievement("ACH_INFERIAE");
		addJournalLocation(INF);
	}
	
	function onLoadLocation()
	{
		apmsPlayMusic(custom, 11, 1); // Desert Places
	}
	
	function onGameplayStart()
	{
		if(aod.inf_insideAzra == 0)
			setCombatAllowed(0);
		
		if(aod.INF_villageIntroDone == 0)
		{
			ss_start(start_inf);
			aod.INF_villageIntroDone = 1;
			aod.jnl_inferiae_phase2 = 1;
			rwd_location(Inferiae);
		}
		
		if(aod.inf_destroyed == 1)
		{
			INF_burst_killEveryone();
		}
		
		if(aod.INF_escapeTowerStart == 1)
		{
			aod.INF_escapeTowerStart = 2;
			inf_setNight();
			sd(INF_EscapeTower);
		}
		
		if(aod.inf_fromTower)
		{
			aod.inf_fromTower = 0;
			dlgTeleportToMarker(TM_HoleEscape_PC_01);
		}
		
		if(aod.inf_nightTime)
			inf_setNight();
		else
			inf_setDay();
		
		//*************** Party Settings ****
		//***********************************
		
		if(aod.inf_destroyed == 0 && aod.fight_InfNightGuards == 0)
		{
			addParty(InferiaeVillagers, 0);
			addCharToParty(5805, "InferiaeVillagers", "fighter");
			addCharToParty(5810, "InferiaeVillagers", "fighter");
			addCharToParty(5811, "InferiaeVillagers", "fighter");
			addCharToParty(5812, "InferiaeVillagers", "fighter");
			addCharToParty(5813, "InferiaeVillagers", "fighter");
			addCharToParty(5814, "InferiaeVillagers", "fighter");
			addCharToParty(5815, "InferiaeVillagers", "fighter");
			addCharToParty(5816, "InferiaeVillagers", "fighter");
			addCharToParty(5817, "InferiaeVillagers", "fighter");
			addCharToParty(5818, "InferiaeVillagers", "fighter");
			addCharToParty(5819, "InferiaeVillagers", "fighter");
			addCharToParty(5820, "InferiaeVillagers", "fighter");
			addCharToParty(5821, "InferiaeVillagers", "fighter");
			addCharToParty(5822, "InferiaeVillagers", "fighter");
			addCharToParty(5823, "InferiaeVillagers", "fighter");
			addCharToParty(5824, "InferiaeVillagers", "fighter");
			addCharToParty(5825, "InferiaeVillagers", "fighter");
			addCharToParty(5826, "InferiaeVillagers", "fighter");
			addCharToParty(5827, "InferiaeVillagers", "fighter");
		}
	}
	
	function inf_setNight()
	{
		theSun.color = "0.28 0.35 0.63 1";
		theSun.ambient = "0.16 0.18 0.26 1";
		theSun.brightness = 0.5;
		theSun.castShadows = "1";
		theSun.shadowSoftness = 5;
		theSun.apply();
		aod.inf_nightTime = 1;
	}
	
	function inf_setDay()
	{
		theSun.color = "0.86 0.71 0.45 1";
		theSun.ambient = "0.45 0.39 0.31 1";
		theSun.brightness = 1.6;
		theSun.castShadows = "1";
		theSun.shadowSoftness = 0.5;
		theSun.apply();
		aod.inf_nightTime = 0;
	}
	
	function onLeaveLocation()
	{
		globalOnLeaveLocation();
		
		if(aod.inf_toTower == 0)
			aod.inf_nightTime = 0;
	}
	
	function onStartCombat()
	{
		VCO_AzraDoor.setActive(0);
		if(aod.inf_insideAzra)
		{
			addEnemyToParty(1, InferiaeVillagers);
			blockTraveling(0);
			aod.inf_insideAzra = 0;
		}
	}
	
	function onEndCombat()
	{
		apmsPlayMusic(custom, 11, 1);
		
		if(isalive())
		{
			if(aod.fight_InfNightGuards)
			{
				rwd_fight(Inferiae_02);
				BlackSplash.command = "";
				BlackOut.command = "sd(INF_EscapeTower); startBlackSplash();";
				startBlackOut();
			}
			
			setCombatAllowed(0);
			
			// For Custom Death Screens
			
			deactivateDeathDesc();
		}
	}
	
	function TRG_Start()
	{
		if(aod.inf_status == 0)
		{
			aod.inf_status = 1;
			BlackSplash.command = "";
			BlackOut.command = "sd(INF_NPC_Azra_01); startBlackSplash();";
			startBlackOut();
		}
		
		if(aod.inf_status == 4 && aod.inf_destroyed == 0)
		{
			aod.inf_status = 5;
			BlackSplash.command = "";
			BlackOut.command = "sd(INF_Return); VCO_AzraDoor.setActive(0); startBlackSplash();";
			startBlackOut();
		}
	}
	
	function INF_VCO_AzraDoor()
	{
		BlackSplash.command = "";
		BlackOut.command = "sd(INF_afterAzra); VCO_AzraDoor.setActive(0); startBlackSplash();";
		startBlackOut();
	}
	
	function InferiaeVillagers::onDestroyed()
	{
		if(aod.inf_destroyed == 0)
			rwd_fight(Inferiae_01);
		aod.inf_destroyed = 2;
		aod.inf_status = 3;
		VCO_AzraDoor.setActive(0);
	}
	
	function VCO_INF_eyeHole()
	{
		if(isInCombat() == false && aod.inf_destroyed)
		{
			BlackSplash.command = "";
			BlackOut.command = "sd(INF_EyeHole); startBlackSplash();";
			startBlackOut();
		}
		else if(isInCombat())
			narratePhrase("You can't leave right now.");
		else
			narratePhrase("The guard stops you.");
	}
	
	function INF_moveMobSpot()
	{
		dlgTeleportToMarker(TM_VillagerMobSpot_01, 5816);
		dlgTeleportToMarker(TM_VillagerMobSpot_02, 5817);
		dlgTeleportToMarker(TM_VillagerMobSpot_03, 5818);
		dlgTeleportToMarker(TM_VillagerMobSpot_04, 5819);
		dlgTeleportToMarker(TM_VillagerMobSpot_05, 5820);
		dlgTeleportToMarker(TM_VillagerMobSpot_06, 5821);
		dlgTeleportToMarker(TM_VillagerMobSpot_07, 5822);
		dlgTeleportToMarker(TM_VillagerMobSpot_08, 5823);
		dlgTeleportToMarker(TM_VillagerMobSpot_09, 5824);
		dlgTeleportToMarker(TM_VillagerMobSpot_10, 5825);
		dlgTeleportToMarker(TM_VillagerMobSpot_11, 5826);
		dlgTeleportToMarker(TM_VillagerMobSpot_12, 5827);
		dlgTeleportToMarker(TM_GuardMobSpot_01, 5812);
		dlgTeleportToMarker(TM_GuardMobSpot_02, 5815);
		dlgTeleportToMarker(TM_GuardMobSpot_03, 5813);
		dlgTeleportToMarker(TM_GuardMobSpot_04, 5814);
	}
	
	function INF_moveOriginalSpot()
	{
		dlgTeleportToMarker(TM_HoleGuardian_01, 5812);
		dlgTeleportToMarker(TM_HoleGuardian_02, 5815);
		dlgTeleportToMarker(TM_HoleGuardian_03, 5813);
		dlgTeleportToMarker(TM_HoleGuardian_04, 5814);
		dlgTeleportToMarker(TM_VillagerSpot_01, 5816);
		dlgTeleportToMarker(TM_VillagerSpot_02, 5817);
		dlgTeleportToMarker(TM_VillagerSpot_03, 5818);
		dlgTeleportToMarker(TM_VillagerSpot_04, 5819);
		dlgTeleportToMarker(TM_VillagerSpot_05, 5820);
		dlgTeleportToMarker(TM_VillagerSpot_06, 5821);
		dlgTeleportToMarker(TM_VillagerSpot_07, 5822);
		dlgTeleportToMarker(TM_VillagerSpot_08, 5823);
		dlgTeleportToMarker(TM_VillagerSpot_09, 5824);
		dlgTeleportToMarker(TM_VillagerSpot_10, 5825);
		dlgTeleportToMarker(TM_VillagerSpot_11, 5826);
		dlgTeleportToMarker(TM_VillagerSpot_12, 5827);
	}
	
	function INF_moveTowerSpot()
	{
		dlgTeleportToMarker(TM_VillagerTowerSpot_01, 5816);
		dlgTeleportToMarker(TM_VillagerTowerSpot_02, 5817);
		dlgTeleportToMarker(TM_VillagerTowerSpot_03, 5818);
		dlgTeleportToMarker(TM_VillagerTowerSpot_04, 5819);
		dlgTeleportToMarker(TM_VillagerTowerSpot_05, 5820);
		dlgTeleportToMarker(TM_VillagerTowerSpot_06, 5821);
		dlgTeleportToMarker(TM_VillagerTowerSpot_07, 5822);
		dlgTeleportToMarker(TM_VillagerTowerSpot_08, 5823);
		dlgTeleportToMarker(TM_VillagerTowerSpot_09, 5824);
		dlgTeleportToMarker(TM_VillagerTowerSpot_10, 5825);
		dlgTeleportToMarker(TM_VillagerTowerSpot_11, 5826);
		dlgTeleportToMarker(TM_VillagerTowerSpot_12, 5827);
		dlgTeleportToMarker(TM_GuardTowerSpot_01, 5810);
		dlgTeleportToMarker(TM_GuardTowerSpot_02, 5811);
		dlgTeleportToMarker(TM_AzraTowerSpot_01, 5805);
	}
	
	function INF_burst_killEveryone()
	{
		dlgTeleportToMarker(TM_Escape_NPC_Patrol_01, 5813);
		dlgTeleportToMarker(TM_Escape_NPC_Patrol_02, 5814);
		dlgTeleportToMarker(TM_VillagerSpot_01, 5816);
		dlgTeleportToMarker(TM_VillagerSpot_02, 5817);
		dlgTeleportToMarker(TM_VillagerSpot_03, 5818);
		dlgTeleportToMarker(TM_VillagerSpot_04, 5819);
		dlgTeleportToMarker(TM_VillagerSpot_05, 5820);
		dlgTeleportToMarker(TM_VillagerSpot_06, 5821);
		dlgTeleportToMarker(TM_VillagerSpot_07, 5822);
		dlgTeleportToMarker(TM_VillagerSpot_08, 5823);
		dlgTeleportToMarker(TM_VillagerSpot_09, 5824);
		dlgTeleportToMarker(TM_VillagerSpot_10, 5825);
		dlgTeleportToMarker(TM_VillagerSpot_11, 5826);
		dlgTeleportToMarker(TM_VillagerSpot_12, 5827);
		dlgTeleportToMarker(TM_GuardMobSpot_01, 5812);
		dlgTeleportToMarker(TM_GuardMobSpot_02, 5815);
		chooseRandomDeathPosition(5805);
		chooseRandomDeathPosition(5810);
		chooseRandomDeathPosition(5811);
		chooseRandomDeathPosition(5812);
		chooseRandomDeathPosition(5813);
		chooseRandomDeathPosition(5814);
		chooseRandomDeathPosition(5815);
		chooseRandomDeathPosition(5816);
		chooseRandomDeathPosition(5817);
		chooseRandomDeathPosition(5818);
		chooseRandomDeathPosition(5819);
		chooseRandomDeathPosition(5820);
		chooseRandomDeathPosition(5821);
		chooseRandomDeathPosition(5822);
		chooseRandomDeathPosition(5823);
		chooseRandomDeathPosition(5824);
		chooseRandomDeathPosition(5825);
		chooseRandomDeathPosition(5826);
		chooseRandomDeathPosition(5827);
		dlgKillCharacter(5805);
		dlgKillCharacter(5810);
		dlgKillCharacter(5811);
		dlgKillCharacter(5812);
		dlgKillCharacter(5813);
		dlgKillCharacter(5814);
		dlgKillCharacter(5815);
		dlgKillCharacter(5816);
		dlgKillCharacter(5817);
		dlgKillCharacter(5818);
		dlgKillCharacter(5819);
		dlgKillCharacter(5820);
		dlgKillCharacter(5821);
		dlgKillCharacter(5822);
		dlgKillCharacter(5823);
		dlgKillCharacter(5824);
		dlgKillCharacter(5825);
		dlgKillCharacter(5826);
		dlgKillCharacter(5827);
		aod.inf_destroyed = 2;
		aod.inf_status = 3;
		Cows.hideObjects();
		VCO_AzraDoor.setActive(0);
	}
};

useEventPackage(InferiaeEvents);