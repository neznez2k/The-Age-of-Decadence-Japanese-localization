package DeadRiverEvents
{
	function onInitLocation()
	{
		setAchievement("ACH_DEAD_RIVER");
		addJournalLocation(River);
	}
	
	function onLoadLocation()
	{
		apmsPlayMusic(custom, 11, 1);
	}
	
	function onGameplayStart()
	{
		if(aod.RVR_introDone == false)
		{
			aod.RVR_introDone = true;
			rwd_location(DeadRiver);
		}
		
		if(aod.RVR_fromUnderground)
		{
			dlgTeleportToMarker(TM_Underground);
			aod.RVR_fromUnderground = false;
		}
		
		if(aod.RVR_ropeRiver == 1)
		{
			dock_rope.isRenderEnabled = 1;
			VCO_ropeRiverDown.setactive(1);
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
		aod.fight_scorpion = 1;
	}
	
	function onEndCombat()
	{
		apmsPlayMusic(custom, 11, 1);
		
		if(aod.RVR_insideFog)
		{
			aod.FogDamage_Combat = 0;
			fogDamage();
		}
		
		if(isalive())
		{
			aod.fight_scorpion = 0;
			
			// For Custom Death Screens
			
			deactivateDeathDesc();
		}
	}
	
	function onLootScreenClose()
	{
		
	}
	
	function RVR_dowstairs()
	{
		BlackOut.command = "switchMission(\"Dead River Underground.mis\");";
		startBlackOut();
	}
	
	function RVR_ropeRiverUp()
	{
		if(aod.RVR_ropeRiver == 0)
		{
			if(dlgownsitem(2120))
			{
				BlackSplash.command = "";
				BlackOut.command = "RVR_addRope(); dlgRemoveItem(2120, 1); startBlackSplash();";
				startBlackOut();
				
			}
			else if(dlgownsitem(2125))
			{
				BlackSplash.command = "";
				BlackOut.command = "RVR_addRope(); dlgRemoveItem(2125, 1); startBlackSplash();";
				startBlackOut();
			}
			else
				narratephrase("You need a rope to climb down.");
		}
		else
		{
			BlackSplash.command = "";
			BlackOut.command = "dlgTeleportToMarker(TM_RiverDown); startBlackSplash();";
			startBlackOut();
		}
	}
	
	function RVR_ropeRiverDown()
	{
		BlackSplash.command = "";
		BlackOut.command = "dlgTeleportToMarker(TM_RiverUp); startBlackSplash();";
		startBlackOut();
	}
	
	function RVR_jumpTube(%Number)
	{
		if(%Number == 01)
		{
			BlackSplash.command = "";
			BlackOut.command = "dlgTeleportToMarker(TM_JumpTubes_02); startBlackSplash();";
			startBlackOut();
		}
		else if(%Number == 02)
		{
			BlackSplash.command = "";
			BlackOut.command = "dlgTeleportToMarker(TM_JumpTubes_01); startBlackSplash();";
			startBlackOut();
		}
	}
	
	function RVR_EndLake(%Action)
	{
		if(%Action == 01)
		{
			BlackSplash.command = "";
			BlackOut.command = "dlgTeleportToMarker(TM_EnterLake); startBlackSplash();";
			startBlackOut();
		}
		else if(%Action == 02)
		{
			BlackSplash.command = "";
			BlackOut.command = "dlgTeleportToMarker(TM_LeaveLake); startBlackSplash();";
			startBlackOut();
		}
	}
	
	function RVR_addRope()
	{
		VCO_ropeRiverUp.setCursor("ClimbCursor");
		VCO_ropeRiverUp.setCursorText(9);
	
		aod.RVR_ropeRiver = 1;
		VCO_ropeRiverDown.setactive(1);
		dock_rope.isRenderEnabled = 1;
	}
	
	function RVR_introDialogue()
	{
		if(aod.RVR_introDialogueDone == 0)
		{
			aod.RVR_introDialogueDone = 1;
			BlackSplash.command = "";
			BlackOut.command = "sd(RVR_Intro_01); dlgTeleportToMarker(TM_Intro); dlgTeleportToMarker(TM_Intro_NPC, 8505); startBlackSplash();";
			startBlackOut();
		}
	}
	
	function RVR_templeExit()
	{
		if(aod.gnz_finished == false)
		{
			MessageBoxYesNo($phrase_map_leave_ganezzar_01, $phrase_map_leave_ganezzar_02, "leaveGanezzar();", "");
		}
		else
		{
			BlackOut.command = "switchMission(\"The Temple.mis\");";
			startBlackOut();
		}
	}
	
	function RVR_enterFog()
	{
		aod.RVR_insideFog = 1;
		
		if(aod.RVR_enterFog == 0)
		{
			sdFade(RVR_Fog_01);
		}
	}
	
	function RVR_exitFog()
	{
		aod.RVR_insideFog = 0;
		
		if(aod.RVR_enterFog == 0)
		{
			sdFade(RVR_Fog_01);
		}
	}
	
	function onEndTurn(%turnNumber)
	{
		if(aod.RVR_insideFog)
		{
			switch(%turnNumber)
			{
			case 1: 
			case 2: fogDamage();
			case 3: aod.FogDamage_Combat = 0;
			case 4: 
			case 5: 
			case 6: fogDamage();
			case 7: aod.FogDamage_Combat = 0;
			case 8: 
			case 9: 
			case 10: fogDamage();
			case 11: aod.FogDamage_Combat = 0;
			default: fogDamage();
			}
		}
	}
	
	function fogDamage()
	{
		if(aod.FogDamage_Combat == 0)
		{
			if(dlggetCharacterHP(1) >= 5)
				if(dlgOwnsItem(909))
					dlgchangeCharacterHP(-1, 1);
				else
					dlgchangeCharacterHP(-2, 1);
			%phrase = getRandom(1, 4);
			switch(%phrase)
			{
				case 1: sayPhrase(1, "ugh!");
				case 2: sayPhrase(1, "cough, cough!");
				case 3: sayPhrase(1, "uff!");
				case 4: sayPhrase(1, "<cough>");
				default: sayPhrase(1, "<cough>");
			}
			
			aod.FogDamage_Combat = 1;
		}
	}
	
	function fogDamageTrigger()
	{
		if(isInCombat() == false)
		{
			aod.RVR_poisonCount += 1;
			if(aod.RVR_poisonCount > 120)
			{
				if(dlggetCharacterHP(1) >= 5)
					if(dlgOwnsItem(909))
						dlgchangeCharacterHP(-1, 1);
					else
						dlgchangeCharacterHP(-2, 1);
				%phrase = getRandom(1, 4);
				switch(%phrase)
				{
					case 1: sayPhrase(1, "ugh!");
					case 2: sayPhrase(1, "cough, cough!");
					case 3: sayPhrase(1, "uff!");
					case 4: sayPhrase(1, "<cough>");
					default: sayPhrase(1, "<cough>");
				}
				
				aod.RVR_poisonCount = 0;
			}
		}
	}
	
	function RVRChargeRespirator()
	{
		dlgAddItem(909, 1);
		dlgRemoveItem(1600, 1);
		
		if(dlgOwnsItem(904))
		{
			dlgRemoveItem(904, 1);
		}
		else if(dlgOwnsItem(902))
		{
			dlgRemoveItem(902, 1);
			dlgAddItem(2002, 2);
			dlgAddItem(2003, 4);
			dlgAddItem(2004, 4);
		}
	}
};

useEventPackage(DeadRiverEvents);