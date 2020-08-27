package AemolasVillageEvents
{
	function onInitLocation()
	{
		addJournalLocation(Village);
	}
	
	function onLoadLocation()
	{
		setCombatAllowed(false);
	}
	
	function onGameplayStart()
	{
		if(aod.Aemolas_introDone == false)
		{
			aod.Aemolas_introDone = true;
			rwd_location(Aemolas);
		}
		
		if(aod.quest_aemolas_raidersGone == 1)
		{
			dlgDeleteCharacter(3010);
			dlgDeleteCharacter(3011);
			dlgDeleteCharacter(3012);
			dlgDeleteCharacter(3013);
			dlgDeleteCharacter(3014);
			dlgDeleteCharacter(3015);
			dlgDeleteCharacter(3016);
			dlgDeleteCharacter(3017);
			dlgDeleteCharacter(3018);
			dlgDeleteCharacter(3019);
			dlgDeleteCharacter(3020);
			dlgDeleteCharacter(3021);
			aod.quest_aemolas_raidersGone = 2;
		}
		
		//*************** Party Settings ****
		//***********************************
		
		if (aod.quest_aemolas_raidersGone == 0)
		{
			addParty(VillageRaiders, 0);
			addCharToParty(3010, "VillageRaiders", "fighter");
			addCharToParty(3011, "VillageRaiders", "fighter");
			addCharToParty(3012, "VillageRaiders", "fighter");
			addCharToParty(3013, "VillageRaiders", "fighter");
			addCharToParty(3014, "VillageRaiders", "fighter");
			addCharToParty(3015, "VillageRaiders", "fighter");
			addCharToParty(3016, "VillageRaiders", "fighter");
			addCharToParty(3017, "VillageRaiders", "fighter");
			addCharToParty(3018, "VillageRaiders", "fighter");
			addCharToParty(3019, "VillageRaiders", "fighter");
			addCharToParty(3020, "VillageRaiders", "fighter");
			addCharToParty(3021, "VillageRaiders", "fighter");
		}
	}
	
	function onEndCombat()
	{
		
		if (isalive() == true)
		{
			if (aod.quest_aemolas_getGold == false && aod.quest_aemolas_gotmoney == false)
			{
				VCO_theWell_01.setActive(true);
				aod.quest_aemolas_getGold = true;
				narratePhrase("Aemolas mentioned the gold was near the well.");
			}
			
			// For Custom Death Screens
			
			deactivateDeathDesc();
		}
	}
	
	function TRG_StartQuest()
	{
		if(aod.quest_aemolas_raidersGone == false && aod.quest_aemolas_raidersDead == false && isInCombat() == false)
		{
			BlackSplash.command = "";
			BlackOut.command = "sd(Quest_AemolasVillage_01); dlgTeleportToMarker(TM_Start); startBlackSplash();";
			startBlackOut();
		}
	}
	
	function onLeaveLocation()
	{
		globalOnLeaveLocation();
	}
};

useEventPackage(AemolasVillageEvents);