package hangarInteriorEvents
{
	function onInitLocation()
	{
		
	}
	
	function onLoadLocation()
	{
		apmsPlayMusic(custom, 4, 1);
		blockTraveling(true);
		
		if(aod.HGR_doorOpen)
			HGR_openDoor();
		else if(aod.HGR_doorCollapsed)
			HGR_collapse();
		else
			HGR_closeDoor();
	}
	
	function onGameplayStart()
	{
		//*************** Party Settings ****
		//***********************************
		
		if(aod.hgr_engineer_status == 3)
		{
			addParty(HGR_Engineers, 0);
			addCharToParty(6303, "HGR_Engineers", "fighter");
			addCharToParty(6304, "HGR_Engineers", "fighter");
			addCharToParty(6305, "HGR_Engineers", "fighter");
		}
	}
	
	function onLeaveLocation()
	{
		globalOnLeaveLocation();
	}
	
	function HGR_openDoor()
	{
		door_closed.isRenderEnabled = 0;
		door_open.isRenderEnabled = 1;
		VCO_Door.setActive(0);
		aod.HGR_doorOpen = true;
		setGroupPassability(124, 122, 130, 122, 0, 1);
		airship.isRenderEnabled = 1;
		HangarHide.isRenderEnabled = 0;
		VCO_HatchConsole.setActive(1);
		setAchievement("ACH_HANGAR");
	}
	
	function HGR_closeDoor()
	{
		door_closed.isRenderEnabled = 1;
		door_open.isRenderEnabled = 0;
		VCO_Door.setActive(1);
		aod.HGR_doorOpen = false;
		setGroupPassability(124, 122, 130, 122, 0, 0);
		airship.isRenderEnabled = 0;
		HangarHide.isRenderEnabled = 1;
		VCO_HatchConsole.setActive(0);
	}
	
	function HGR_collapse()
	{
		collapse.isRenderEnabled = 1;
		VCO_Door.setActive(0);
		aod.HGR_doorOpen = false;
		aod.HGR_doorCollapsed = true;
		setGroupPassability(124, 117, 130, 117, 0, 0);
		airship.isRenderEnabled = 0;
		HangarHide.isRenderEnabled = 1;
		VCO_HatchConsole.setActive(0);
	}
	
	function HGR_onFloor2()
	{
		floor2.isRenderEnabled = 1;
	}
	
	function HGR_onFloor1()
	{
		floor2.isRenderEnabled = 0;
		
		if(aod.HGR_doorOpen)
			HGR_openDoor();
		else if(aod.HGR_doorCollapsed)
			HGR_collapse();
		else
			HGR_closeDoor();
	}
	
	function VCO_climbOutside()
	{
		aod.hgr_fromInside = 1;
		BlackOut.command = "switchMission(\"Hangar Exterior.mis\");";
		startBlackOut();
	}
	
	function VCO_Elevator_Top()
	{
		BlackSplash.command = "";
		BlackOut.command = "dlgTeleportToMarker(TM_Elevator_Bottom); startBlackSplash();";
		startBlackOut();
	}
	
	function VCO_Elevator_Bottom()
	{
		if(aod.hgr_engineer_status == 1 && aod.hgr_soldiers_status < 2)
		{
			aod.hgr_engineer_status = 2;
			BlackSplash.command = "";
			BlackOut.command = "dlgTeleportToMarker(TM_Elevator_Top); hgr_createEngineers(); sd(HGR_Engineers_01); startBlackSplash();";
			startBlackOut();
		}
		else
		{
			BlackSplash.command = "";
			BlackOut.command = "dlgTeleportToMarker(TM_Elevator_Top); startBlackSplash();";
			startBlackOut();
		}
	}
	
	function hgr_deleteEngineers()
	{
		dlgDeleteCharacter(6303);
		dlgDeleteCharacter(6304);
		dlgDeleteCharacter(6305);
	}
	
	function hgr_createEngineers()
	{
		createByCharMarker("CM_Hangar_Aurelian_Engineer_01");
		createByCharMarker("CM_Hangar_Aurelian_Engineer_02");
		createByCharMarker("CM_Hangar_Aurelian_Engineer_03");
		addParty(HGR_Engineers, 0);
		addCharToParty(6303, "HGR_Engineers", "fighter");
		addCharToParty(6304, "HGR_Engineers", "fighter");
		addCharToParty(6305, "HGR_Engineers", "fighter");
	}
	
	function hgr_teleportEngineers()
	{
		dlgTeleportToMarker(TM_EngineerWait_04);
		dlgTeleportToMarker(TM_EngineerWait_03, 6303);
		dlgTeleportToMarker(TM_EngineerWait_02, 6304);
		dlgTeleportToMarker(TM_EngineerWait_01, 6305);
	}
	
	function hgr_dlg_engineerWait()
	{
		if(aod.hgr_engineer_status == 3)
		{
			BlackSplash.command = "";
			BlackOut.command = "sd(HGR_Engineers_01); startBlackSplash();";
			startBlackOut();
		}
	}
	
	function hgr_dlg_engineerNear()
	{
		if(aod.hgr_engineer_status == 3)
			aod.hgr_nearEngineer = true;
	}
	
	/*
	
	Engineer status:
	
	1 = They should appear when you go back to the top chamber.
	2 = They have appeared on the top chamber.
	3 = They were told to wait outside the door.
	4 = They were killed.
	5 = They left peacefully.
	
	*/
	
	function onStartCombat()
	{
		if(aod.hgr_engineer_status == 3 && aod.hgr_nearEngineer)
		{
			VCO_Elevator_Bottom.setActive(0);
			sayPhrase(6305, "Defend yourselves!");
			addEnemyToParty(1, HGR_Engineers);
			aod.hgr_engineer_status = 4;
		}
		
		VCO_Elevator_Top.setActive(0);
		VCO_Exit.setActive(0);
	}
	
	function onEndCombat()
	{
		apmsPlayMusic(custom, 4, 1);
		VCO_Elevator_Bottom.setActive(1);
		VCO_Elevator_Top.setActive(1);
		VCO_Exit.setActive(1);
		
		if(isalive())
		{
			// For Custom Death Screens
			
			deactivateDeathDesc();
		}
	}
	
	function descriptionsVCO(%desc)
	{
		switch(%desc)
		{
			case 1: narratePhrase("A strange machine sitting in the middle of a half-empty chamber.<nlo>It's been stripped of everything valuable and left to rust - a symbol of age long gone and the one that followed.");
			case 2: narratePhrase("Old supplies, long past their expiration date.");
			case 3: narratePhrase("Nothing but junk. Looks like anything of value has been taken a long time ago.");
			case 4: narratePhrase("Old pipes that haven't seen any action in centuries. They are covered with rust and black residue."); 
			case 5: narratePhrase("Strange tools, broken gauges, discarded parts, and one petrified scorpion."); 
			case 6: narratePhrase("Two barrels containing foul-smelling, dark, viscous liquid."); 
			case 7: narratePhrase("It looks like a ballista armed with a bronze bolt as thick as your arm.<nlo>The bolt is perfectly machined, as smooth as the surface of still water,<nlo>except for a single row of magical characters engraved along the length of the shaft."); 
			case 8: narratePhrase("A crystal semi-sphere, carved from a single crystal and polished to perfection."); 
			case 9: if((aod.crafting >= 5 || aod.str >= 8) && aod.hangar_tube1 == false)
				{
					narratePhrase("Something about this valve catches your eye.<nlo>Removing the valve cap, you find a secret stash, containing several power tubes.<nlo>Unfortunately, only one tube has any charge left.");
					dlgAddItem(1600, 1);
					aod.hangar_tube1 = true;
				}
				else if(aod.hangar_tube1)
					narratePhrase("You check the stash again to make sure you didn't miss anything.");
				else
					narratePhrase("Something about this valve catches your eye. Unfortunately, the valve cap seems to be stuck.");
			case 10: narratePhrase("The inner workings of the ship: strange machines and pipes running under wooden walkways.<nlo>Everything laid bare to provide fast and easy access to repair damage and replace parts.");
			case 11: narratePhrase("A strange control system, damaged beyond recovery.");
			default: narratePhrase("You see nothing of interest.");
		}
	}
};

useEventPackage(hangarInteriorEvents);