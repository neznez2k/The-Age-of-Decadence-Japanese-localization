package QuestTG4Events
{
	function onInitLocation()
	{

	}
	
	function onLoadLocation()
	{
		
	}
	
	function onGameplayStart()
	{
		setTravelingAllowed(0);
		setCombatAllowed(0);
		
		if(aod.quest_tg4_reachedBasement == false) apmsStartDialogue(quest_TG4_01);
		
		//*************** Party Settings ****
		//***********************************
		
		addParty(Quest_TG4_Guards, 0);
		addCharToParty(5020, "Quest_TG4_Guards", "fighter");
		addCharToParty(5021, "Quest_TG4_Guards", "fighter");
		addCharToParty(5022, "Quest_TG4_Guards", "fighter");
	}
	
	function onEndCombat()
	{
		
		
		if (isalive() == true)
		{
			
			if (aod.fight_TG4_outside == true)
			{
				VCO_EnterGuild.setActive(true);
				Exit_EnterGuild.isRenderEnabled = true;
				BlackSplash.command = "";
				BlackOut.command = "narratePhrase(\"You take the key from the guard's body.\"); startBlackSplash();";
				startBlackOut();
				aod.fight_TG4_outside = false;
				rwd_fight(TG4_01);
			}
			
			if (aod.fight_TG4_inside == true)
			{
				VCO_Pavillion.setActive(true);
				Exit_Pavillion.isRenderEnabled = true;
				aod.fight_TG4_inside = false;
				rwd_fight(TG4_01);
			}
			
			if (aod.fight_TG4_poison == true)
			{
				VCO_EnterGuild.setActive(true);
				Exit_EnterGuild.isRenderEnabled = true;
				aod.fight_TG4_poison = false;
				rwd_fight(TG4_01);
			}
			
			// For Custom Death Screens
			
			deactivateDeathDesc();
		}
	}
	
	function onLeaveLocation()
	{
		globalOnLeaveLocation();
	}
};

useEventPackage(QuestTG4Events);