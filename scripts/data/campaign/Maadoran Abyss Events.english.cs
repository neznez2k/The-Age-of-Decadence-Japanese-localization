package MaadoranAbyssEvents
{
	function onInitLocation()
	{
		addJournalLocation(Abyss);
	}
	
	function onLoadLocation()
	{
		if(aod.quest_abyss_fogLifted == false) 
		{
			apmsPlayMusic(custom, 4, 1);
			abyssThunder.play();
		}
		else 
		{
			abyssThunder.stop();
			apmsPlayMusic(custom, 5, 1);
		}
	}
	
	function onGameplayStart()
	{
		setTravelingAllowed(false);
		setCombatAllowed(false);
		dlgCam(180, 40, 15);
		
		if(aod.mdn_visitedAbyss == false)
		{
			sd(MDN_GateAbyss_03);
			aod.mdn_visitedAbyss = true;
		}
		
		if(aod.quest_abyss_fogLifted) 
			fogLifted();
		
		if(aod.quest_abyss_godShow)
			showGodTent();
		
		//*************** Party Settings ****
		//***********************************
	}
	
	function onEndCombat()
	{
		
		if (isalive() == true)
		{
			
			if(aod.quest_abyss_fogLifted == false) 
			{
				apmsPlayMusic(custom, 4, 1);
				abyssThunder.play();
			}
			else 
			{
				abyssThunder.stop();
				apmsPlayMusic(custom, 5, 1);
			}
			
			// For Custom Death Screens
			
			deactivateDeathDesc();
		}
	}
	
	function onLeaveLocation()
	{
		globalOnLeaveLocation();
		if(aod.quest_abyss_fogLifted)
			aod.quest_abyss_godShow = 1;
	}
	
	function abyssInterior()
	{
		thelevelinfo.fogdensity = "0.00025";
		thelevelinfo.apply();
		CraterInteriorStuff.hideObjects();
	}
	
	function fogLifted()
	{
		thelevelinfo.fogdensity = "0.00025";
		thelevelinfo.apply();
		CraterInteriorStuff.hideObjects();
	}
	
	function showGodTent()
	{
		setObjectRenderState(GodTent, 1);
		setObjectRenderState(GodCrowd_1, 1);
		setObjectRenderState(GodCrowd_2, 1);
		setObjectRenderState(GodCrowd_3, 1);
		dlgTeleportToMarker(TM_OldManGod, 4910);
		assignDialogue(NPC_AbyssOldMan_02, 4910);
		setPassability(224, 231, 4, 0);
		setPassability(223, 232, 4, 0);
		setPassability(223, 234, 4, 0);
	}
	
	function OldManGodPhrase()
	{
		if(aod.quest_abyss_godShow)
			sayPhrase(4910, "Come one, come all!");
	}
	
	function AbyssChargeRespirator()
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

useEventPackage(MaadoranAbyssEvents);