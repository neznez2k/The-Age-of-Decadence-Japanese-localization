package TempleChamberEvents
{
	function onInitLocation()
	{
		setgrouppassability(38, 26, 40, 26, 0, 0);
		setgrouppassability(45, 31, 45, 33, 0, 0);
		setgrouppassability(33, 31, 33, 33, 0, 0);
		setgrouppassability(38, 38, 40, 38, 0, 0);
		VCO_Tomb.setActive(0);
		setObjectRenderState(Tomb_Down, 1);
		setObjectRenderState(Tomb_Up, 0);
	}
	
	function onLoadLocation()
	{
		apmsPlayMusic(custom, 20, 1);
	}
	
	function onGameplayStart()
	{
		blockTraveling(1);
		setCombatAllowed(0);
		
		if(aod.ZIG_fromInterior)
		{
			dlgTeleportToMarker(TM_TowerExt_02);
			aod.ZIG_fromInterior = 0;
		}
		
		//*************** Party Settings ****
		//***********************************
		
	}
	
	function onStartCombat()
	{
		apmsPlayMusic(custom, 8, 1);
		VCO_ReactorConsole.setActive(0);
		VCO_Console.setActive(0);
		VCO_Exit.setActive(0);
	}
	
	function onEndTurn(%turnNumber)
	{
		switch(%turnNumber)
		{
			case 4: if(aod.temple_used_canister) {dlgChangeStat(str, 5, 290); dlgChangeStat(dex, 5, 290); dlgChangeStat(per, 5, 290); narratePhrase("Agathoth is growing stronger. Kill him before it's too late!");} dlgAddTextBoxMessage("Agathoth concentrates on his wounds for a moment and they begin to close right before your eyes.");
			default: if(isAlive(290)) {dlgChangeCharacterHP(5, 290); dlgAddTextBoxMessage("Agathoth concentrates on his wounds for a moment and they begin to close right before your eyes.");}
		}
	}
	
	function readTablet(%tablet)
	{
		switch(%tablet)
		{
			case 1: dlgTeleportToMarker(TM_Tablet_1); dlgCam(225, 45, 10, 1);
			case 2: dlgTeleportToMarker(TM_Tablet_2); dlgCam(315, 45, 10, 1);
			case 3: dlgTeleportToMarker(TM_Tablet_3); dlgCam(45, 45, 10, 1);
			case 4: dlgTeleportToMarker(TM_Tablet_4); dlgCam(135, 45, 10, 1);
		}
		
		sd(ZGT_tablets_01);
	}
	
	function onEndCombat()
	{
		apmsPlayMusic(custom, 20, 1);
		
		VCO_Exit.setActive(1);
		
		if(isalive())
		{
			if(isDead(290))
			{
				rwd_fight(Agathoth);
				aod.npc_agathoth_dead = 1;
				if(aod.alk_ritual_performed)
					aod.zgt_startEnding = 2;
				else
				{
					aod.zgt_startEnding = 3;
					aod.ending_men = 1;
				}
				
			}
			// For Custom Death Screens
			deactivateDeathDesc();
		}
	}
	
	function Chamber_Exit(%exit)
	{
		if(aod.zgt_startEnding == 1)
		{
			BlackSplash.command = "";
			BlackOut.command = "sd(ZGT_End_Lords); startBlackSplash();";
			startBlackOut();
		}
		
		else if(aod.zgt_startEnding == 2)
		{
			BlackOut.command = "switchMission(\"END_Balzaar.mis\");";
			startBlackOut();
		}
		
		else if(aod.zgt_startEnding == 3)
		{
			BlackSplash.command = "";
			BlackOut.command = "SS_start(\"temple_ending\", \"disconnect();\"); startBlackSplash();";
			startBlackOut();
		}
		
		else
		{
			aod.zgt_interior_spawn = 3;
			if(%exit == 1)
			{
				BlackOut.command = "switchMission(\"The Temple Interior.mis\");";
				startBlackOut();
			}
		}
	}
	
	function tomb_up()
	{
		setObjectRenderState(Tomb_Down, 0);
		setObjectRenderState(Tomb_Up, 1);
		setgrouppassability(38, 26, 40, 26, 0, 1);
		setgrouppassability(45, 31, 45, 33, 0, 1);
		setgrouppassability(33, 31, 33, 33, 0, 1);
		setgrouppassability(38, 38, 40, 38, 0, 1);
		VCO_Tomb.setActive(1);
	}
	
	function Chamber_Console()
	{
		BlackSplash.command = "";
		BlackOut.command = "sd(ZGT_TombConsole); dlgTeleportToMarker(TM_Console_Tomb); startBlackSplash();";
		startBlackOut();
	}
	
	function Chamber_ReactorConsole()
	{
		BlackSplash.command = "";
		BlackOut.command = "sd(ZGT_Reactor); dlgTeleportToMarker(TM_Console_Reactor); startBlackSplash();";
		startBlackOut();
	}
	
	function Chamber_Tomb()
	{
		BlackSplash.command = "";
		BlackOut.command = "sd(ZGT_NPC_Agathoth_01); startBlackSplash();";
		startBlackOut();
	}
	
	function onLeaveLocation()
	{
		globalOnLeaveLocation();
	}
};

useEventPackage(TempleChamberEvents);