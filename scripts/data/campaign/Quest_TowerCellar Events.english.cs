package QuestTowerCellarEvents
{
	function onInitLocation()
	{

	}
	
	function onLoadLocation()
	{
		apmsPlayMusic(custom, 4, 1);
	}
	
	function onGameplayStart()
	{
		if(aod.TRN_TowerCellar_introDone == false)
		{
			aod.TRN_TowerCellar_introDone = true;
			dlgTeleportToMarker(TM_Start);
			sd(TSQ_Cellar_Interior);
		}
		
		//*************** Party Settings ****
		//***********************************
	}
	
	function onLeaveLocation()
	{
		globalOnLeaveLocation();
	}
	
	function onStartCombat()
	{

	}
	
	function onEndCombat()
	{
		apmsPlayMusic(custom, 4, 1);
		
		if (isalive() == true)
		{
			// For Custom Death Screens
			
			deactivateDeathDesc();
		}
	}
	
	function onLootScreenClose()
	{
		
	}
	
	function TRN_TowerCellar_Exit()
	{
		aod.TRN_fromTowerCellar = true;
		
		if(aod.global_Teron_IGTookOver == false && aod.global_Teron_Alliance == false && aod.global_Teron_DaratanWon == false)
		{
			BlackOut.command = "switchMission(\"Teron.mis\");";
			startBlackOut();
		}
		
		else if(aod.global_Teron_IGTookOver || aod.global_Teron_Alliance)
		{
			BlackOut.command = "switchMission(\"Teron_IG.mis\");";
			startBlackOut();
		}
		
		else if(aod.global_Teron_DaratanWon)
		{
			BlackOut.command = "switchMission(\"Teron_MG.mis\");";
			startBlackOut();
		}
	}
	
	function TRN_TowerCellar_Drain()
	{
		narratePhrase("You probe it with a femur bone, but fail to reach the bottom.");
	}
	
	function TRN_TowerCellar_Walls()
	{
		if(aod.per < 6)
			narratePhrase("[perception failure] You find nothing of interest.");
		else
		{
			BlackSplash.command = "";
			BlackOut.command = "sd(TSQ_Cellar_Wall); dlgTeleportToMarker(TM_WallPump); startBlackSplash();";
			startBlackOut();
		}
	}
	
	function TRN_TowerCellar_Pump()
	{
		if((aod.int < 7 && aod.crafting >= 5) || (aod.int >= 7 && aod.crafting >= 4) || (aod.int >= 9 && aod.crafting >= 3))
		{
			BlackSplash.command = "";
			BlackOut.command = "sd(TSQ_Cellar_Pump); dlgTeleportToMarker(TM_WallPump); startBlackSplash();";
			startBlackOut();
		}
		else
			narratePhrase("[failure] Unfortunately, if there was once some mechanism to activate the pump, you can't find it.<nlo>The device remains silent and inert despite your best efforts.");
	}
};

useEventPackage(QuestTowerCellarEvents);