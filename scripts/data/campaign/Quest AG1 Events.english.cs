package QuestAG4Events
{
	function onInitLocation()
	{

	}
	
	function onLoadLocation()
	{

	}
	
	function onGameplayStart()
	{
		if(aod.quest_AG1_metDias == false)
		{
			apmsStartDialogue(quest_AG1_02);
			aod.quest_AG1_metDias = true;
		}
		
		
		//*************** Party Settings ****
		//***********************************
	}
	
	function onEndCombat()
	{
		
		if (isalive() == true)
		{
			
			if (aod.fight_AG1_dias)
			{
				VCO_goMdn.setActive(1);
				setObjectRenderState(EXIT_goMdn, 1); 
				aod.fight_AG1_dias = false;
				aod.mdn_spyAG_start = true;
				rwd_fight(AG1_03);
				
				if (isalive(1316))
				{
					sayPhrase(1316, "Let's head to Maadoran.");
					aod.npc_gaelius_talkSpyAG = true;
				}
				else
				{
					narratePhrase("Looks like Yazad didn't make it. Oh well... You take the documents from his dead body.");
					aod.npc_gaelius_talkDocumentsAG = true;
					dlgAddItem(2135, 1);
				}
			}
			
			// For Custom Death Screens
			
			deactivateDeathDesc();
		}
	}
	
	function onLeaveLocation()
	{
		globalOnLeaveLocation();
	}
	
	function mapScreenButtonScripts()
	{
		MessageBoxYesNo("The road to Maadoran", "Travel to Maadoran?", "startFadeScript(StartTeronEnding);", "");
	}
};

useEventPackage(QuestAG4Events);