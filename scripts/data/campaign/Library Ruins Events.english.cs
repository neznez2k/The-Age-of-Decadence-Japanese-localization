package LibraryRuinsEvents
{
	function onInitLocation()
	{
		setAchievement("ACH_WISDOM");
		addJournalLocation(Library);
	}
	
	function onLoadLocation()
	{
		apmsPlayMusic(custom, 14, 1); // Old Imperial
		
		if(aod.SRS_fromBasement)
		{
			dlgTeleportToMarker(TM_FromBasement_01);
			aod.SRS_fromBasement = false;
		}
	}
	
	function onGameplayStart()
	{
		if(aod.SRS_noIntro == false)
		{
			apmsStartDialogue(Quest_Saross_01);
			dlgTeleportToMarker(TM_SarossIntro_01);
			aod.SRS_noIntro = true;
			rwd_location(Saross);
		}
		
		//*************** Party Settings ****
		//***********************************
	}
	
	function onStartCombat()
	{
		//apmsPlayMusic(custom, 4, 1);
		aod.fight_desolate = 1;
		
		if(aod.srs_foughtProspector == false && aod.SRS_prospectorInsideView)
		{
			aod.srs_foughtProspector = true;
			aod.fight_srs_prospector = true;
			
			if(aod.SRS_prospectorMet == false)
			{
				dlgSetAttitude(5800, 1, -10);
				sayPhrase(5800, "That's as far as you go!");
			}
		}
	}
	
	function onEndCombat()
	{
		apmsPlayMusic(custom, 14, 1); // Old Imperial
		
		if(isalive())
		{
			aod.fight_desolate = 0;
			
			if(aod.fight_srs_prospector)
			{
				aod.fight_srs_prospector = false;
				rwd_fight(SRS_Prospector_01);
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

useEventPackage(LibraryRuinsEvents);