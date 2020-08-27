package QuestAemolasHouseEvents
{
	function onInitLocation()
	{
		
	}
	
	function onLoadLocation()
	{
		aod.jnl_mg5_phase1a = true;
	}
	
	function onGameplayStart()
	{
		setCombatAllowed(false);
		
		//*************** Party Settings ****
		//***********************************
		
		if(aod.quest_aemolas_tearfulReunion)
		{
			createByCharMarker("CM_Raider_Village_Leader");
			createByCharMarker("CM_Raider_Village_01");
			createByCharMarker("CM_Raider_Village_02");
			addParty(AemolasSide, 0);
			addCharToParty(2070, AemolasSide, fighter);
			addParty(MykkoAemolas, 0);
			addCharToParty(3010, MykkoAemolas, fighter);
			addCharToParty(3011, MykkoAemolas, fighter);
			addCharToParty(3013, MykkoAemolas, fighter);
			dlgTeleportToMarker(TM_PC_01);
		}
		
		if(aod.quest_aemolas_houseNoIntro == false)
		{
			aod.quest_aemolas_houseNoIntro = true;
			sd(Quest_AemolasVillage_02);
		}
	}
	
	function onEndCombat()
	{
		
		if(isalive())
		{
			if(aod.fight_AemolasMykko)
			{
				if(aod.npc_aemolas_dead == false)
				{
					BlackSplash.command = "";
					BlackOut.command = "sd(Quest_AemolasVillage_02); startBlackSplash();";
					startBlackOut();
				}
				else
				{
					aod.jnl_AemolasGold = 4;
				}
			}
			
			// For Custom Death Screens
			
			deactivateDeathDesc();
		}
	}
	
	function VCO_AemolasHouseAfterGold()
	{
		if(isInCombat() == false)
		{
			MessageBoxYesNo("Aemolas' House", "Leave the house?", "leaveHouse();", "");
		}
		else
			narratePhrase("You can't leave right now.");
	}
	
	function leaveHouse()
	{
		BlackOut.command = "switchMission(\"RDM_ForestRoad_01.mis\");";
		startBlackOut();
	}
	
	function onLeaveLocation()
	{
		globalOnLeaveLocation();
	}
	
	function mapScreenButtonScripts()
	{
		MessageBoxYesNo("Aemolas' House", "Leave the house?", "leaveHouse();", "");
	}
};

useEventPackage(QuestAemolasHouseEvents);