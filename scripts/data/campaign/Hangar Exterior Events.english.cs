package hangarExteriorEvents
{
	function onInitLocation()
	{
		addJournalLocation(Hangar);
	}
	
	function onLoadLocation()
	{
		apmsPlayMusic(custom, 14, 1); // Old Imperial
	}
	
	function onGameplayStart()
	{
		if(aod.HGR_IntroDone == false)
		{
			aod.HGR_IntroDone = true;
			rwd_location(Hangar);
		}
		
		if(aod.hgr_fromInside)
		{
			aod.hgr_fromInside = 0;
			dlgTeleportToMarker(TM_FromInside);
		}
		
		if(aod.hgr_engineer_status == 4 && aod.hgr_soldiers_status < 2)
		{
			BlackSplash.command = "";
			BlackOut.command = "sd(HGR_Soldiers_02); startBlackSplash();";
			startBlackOut();
		}
		
		if(aod.hgr_engineer_status == 5)
		{
			aod.hgr_soldiers_status = 3;
			dlgDeleteCharacter(6300);
			dlgDeleteCharacter(6301);
			dlgDeleteCharacter(6302);
		}
		
		//*************** Party Settings ****
		//***********************************
		
		if(aod.hgr_soldiers_status <= 1)
		{
			addParty(HGR_Soldiers, 0);
			addCharToParty(6300, "HGR_Soldiers", "fighter");
			addCharToParty(6301, "HGR_Soldiers", "fighter");
			addCharToParty(6302, "HGR_Soldiers", "fighter");
		}
	}
	
	function TRG_Soldier()
	{
		if(isInCombat() == false && aod.hgr_soldiers_status == 0)
		{
			BlackSplash.command = "";
			BlackOut.command = "sd(HGR_Soldiers_01); startBlackSplash();";
			startBlackOut();
		}
	}
	
	function onStartCombat()
	{
		VCO_Hole.setActive(0);
		if(aod.hgr_soldiers_status <= 1)
		{
			sayPhrase(6300, "Attack <him/her>!");
			addEnemyToParty(1, HGR_Soldiers);
			aod.hgr_soldiers_status = 2;
		}
	}
	
	function onEndCombat()
	{
		apmsPlayMusic(custom, 14, 1); // Old Imperial
		
		if(isalive())
		{
			VCO_Hole.setActive(1);
			
			
			
			// For Custom Death Screens
			
			deactivateDeathDesc();
		}
	}
	
	function onLeaveLocation()
	{
		globalOnLeaveLocation();
	}
	
	// aod.hgr_soldiers_status == 0 - No interaction or failed to convince to go down.
	// aod.hgr_soldiers_status == 1 - Convinced to go down.
	// aod.hgr_soldiers_status == 2 - Fought them.
	// aod.hgr_soldiers_status == 3 - They left.
};

useEventPackage(hangarExteriorEvents);