package BanditCampEvents
{
	function onInitLocation()
	{
		addJournalLocation(RaidersCamp);
	}
	
	function onLoadLocation()
	{
		
	}
	
	function onGameplayStart()
	{
		if(aod.global_Teron_IGTookOver || aod.global_Teron_Alliance || aod.global_Teron_DaratanWon)
		{
			finishedTeronBandits();
			aod.quest_teronRaider_finished = true;
			aod.tbc_introDone = true;
			aod.tbc_banditsDead = true;
			
			if(aod.quest_teronRaider_complete == false)
			{
				narratePhrase("The camp is deserted, an empty cage slowly swinging in the wind.<nlo>The raiders are long gone. The hostage is probably dead. Oh well...");
				aod.quest_teronRaider_complete = true;
			}
		}
		
		if(aod.tbc_introDone == false)
		{
			aod.tbc_introDone = true;
			aod.tbc_meetingBandits = true;
			rwd_location(BanditCamp);
			dlgChangeCharacterHP(-25, 1551);
			dlgChangeCharacterHP(-25, 1554);
			teron_banditCamp_prisionerCage.isRenderEnabled = true;
			teron_banditCamp_emptyCage.isRenderEnabled = false;
		}
		
		if(aod.quest_teronRaider_finished)
		{
			teron_banditCamp_prisionerCage.isRenderEnabled = false;
			teron_banditCamp_emptyCage.isRenderEnabled = true;
			VCO_tiberius_cage.setactive(false);
			finishedTeronBandits();
		}
		
		if(aod.quest_teronRaider_aziz)
		{
			sd(TBC_AzizAmbush);
			aod.quest_teronRaider_aziz = false;
		}
		
		
		//*************** Party Settings ****
		//***********************************
		
		if(aod.tbc_banditsDead == false)
		{
			addParty(TeronBandits, 0);
			addCharToParty(1550, "TeronBandits", "fighter");
			addCharToParty(1551, "TeronBandits", "fighter");
			addCharToParty(1553, "TeronBandits", "fighter");
			addCharToParty(1554, "TeronBandits", "fighter");
			addCharToParty(1555, "TeronBandits", "fighter");
			addCharToParty(1556, "TeronBandits", "fighter");
		}
	}
	
	function onLeaveLocation()
	{
		globalOnLeaveLocation();
	}
	
	function onStartCombat()
	{
		if(aod.tbc_campArea && aod.tbc_banditsDead == false)
		{
			aod.gameplay_questRaiders_fight = true;
			addEnemyToParty(1, TeronBandits);
			sayPhrase(1555, "Kill <him/her>!");
			aod.fight_tbcBandits = true;
		}
		
		if(aod.gameplay_combatHelpShown == false)
		{
			PG_HelpText_02.setVisible(true);
			aod.gameplay_combatHelpShown = true;
			aod.achievements_inFirstFight = true;
			TM_ShowTutorial(combat);
		}
	}
	
	function onEndCombat()
	{
		if(isalive())
		{
			if(aod.quest_teronRaider_fightStarted)
				aod.quest_teronRaider_fightStarted = false;
			
			if(aod.achievements_inFirstFight)
				aod.achievements_inFirstFight = false;
			
			// For Custom Death Screens
			
			deactivateDeathDesc();
		}
	}
	
	function onLootScreenClose()
	{
		
	}
};

useEventPackage(BanditCampEvents);