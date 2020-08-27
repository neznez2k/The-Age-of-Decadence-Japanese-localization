package QuestTG6Events
{
	function onInitLocation()
	{

	}
	
	function onLoadLocation()
	{
		apmsPlayMusic(custom, 5, 1);
	}
	
	function onGameplayStart()
	{
		setTravelingAllowed(0);
		setCombatAllowed(0);
		
		if(aod.quest_tg6_atFloor3)
		{
			FLOOR3_01.isRenderEnabled = true;
			FLOOR3_02.isRenderEnabled = true;
		}
		else if(aod.quest_tg6_startedMission == false)
		{
			apmsStartDialogue(quest_TG6_02);
			aod.quest_tg6_startedMission = true;
		}
		
		//*************** Party Settings ****
		//***********************************
		
		addParty(Quest_TG6_Guards, 0);
		addCharToParty(5080, "Quest_TG6_Guards", "fighter");
		addCharToParty(5081, "Quest_TG6_Guards", "fighter");
		addCharToParty(5082, "Quest_TG6_Guards", "fighter");
		
		addParty(Quest_TG6_Thieves, 0);
		addCharToParty(1, "Quest_TG6_Thieves", "fighter");
		addCharToParty(4620, "Quest_TG6_Thieves", "fighter");
	}
	
	//dlgKillCharacter(5080); dlgKillCharacter(5081); dlgKillCharacter(5082);
	
	function onEndCombat()
	{
		apmsPlayMusic(custom, 5, 1);
		if(isalive())
		{
			
			if(aod.fight_TG6_alley)
			{
				if(isDead(4620))
				{
					VCO_endQuest.setActive(true);
					EXIT_endQuest.isRenderEnabled = true;
					narratePhrase("You should go back to Levir. With Cyrus dead there's nothing you can do.");
					aod.npc_levir_failedTG6 = true;
					aod.jnl_tg6_phase4a = true;
				}
				aod.fight_TG6_alley = false;
			}
			
			// For Custom Death Screens
			
			deactivateDeathDesc();
		}
	}
	
	function EquipGuardDisguise()
	{
		dlgUnequipEverything();
		dlgEquipItem(1114);
		dlgEquipItem(1000);
		dlgEquipItem(413);
	}
	
	function onLeaveLocation()
	{
		globalOnLeaveLocation();
	}
	
	function removeUnusedDisguise()
	{
		if(dlgIsEquippedItem(505) == 0) dlgRemoveItem(505, 1);
		if(dlgIsEquippedItem(506) == 0) dlgRemoveItem(506, 1);
	}
};

useEventPackage(QuestTG6Events);