package CaerTorEvents
{
	function onInitLocation()
	{
		revealMapLocation("CaerTor");
		addJournalLocation(CT);
		if(aod.caerTor_IG_beforeGanezzar)
			aod.pas_open = 1;
	}
	
	function onLoadLocation()
	{
		if((aod.global_maadoran_completed && aod.ending_mdn_town_ordu && aod.npc_gaelius_dead == 0) || (aod.global_ganezzar_completed && aod.ending_gnz_IG_joins_HC))
		{
			dlgCreateCharacter("Pavola", 4400, 4400, 68, 67, 0, E);
			assignDialogue(NPC_Pavola_02, 4400);
		}

		apmsPlayMusic(custom, 33, 1);
	}
	
	function onGameplayStart()
	{
		//useCameraBookmark(Quest_AG4_Cam_01);
		//dlgsetzoom(30);
		
		dlgSetAmbientAnimation();
		
		if(aod.caerTor_IG_beforeGanezzar)
			setTravelingAllowed(false);
		
		if(aod.quest_MG9_status == 1)
		{
			assignDialogue(Quest_MG9_03, 8005);
			setTravelingAllowed(1);
			
			if(aod.CTR_introDone == false)
			{
				aod.CTR_introDone = true;
				rwd_location(CaerTor);
			}
		}
		
		if(aod.quest_IG9_status == 2 || aod.quest_IG9_status == 4)
		{
			assignDialogue(Quest_IG9_01, 8005);
			setTravelingAllowed(1);
			
			if(aod.CTR_introDone == false)
			{
				aod.CTR_introDone = true;
				rwd_location(CaerTor);
			}
		}
		
		if(aod.quest_GnzHA1_status >= 3)
		{
			assignDialogue(NPC_Paullus_02, 8005);
			setTravelingAllowed(1);
			
			if(aod.CTR_introDone == false)
			{
				aod.CTR_introDone = true;
				rwd_location(CaerTor);
			}
		}
		
		if(aod.global_ganezzar_completed)
		{
			if(aod.ending_gnz_IG_joins_HA)
			{
				dlgdeletecharacter(8005);
				dlgTeleportToMarker(TM_DLG_Paullus_NPC, 8011);
				assignDialogue(END_NPC_Carbo, 8011);
			}
			else
			{
				assignDialogue(END_NPC_Paullus, 8005);
				setTravelingAllowed(1);
			
				if(aod.CTR_introDone == false)
				{
					aod.CTR_introDone = true;
					rwd_location(CaerTor);
				}
			}
		}
		
		setCombatAllowed(false);
		
		
		//*************** Party Settings ****
		//***********************************
		
		if(aod.CTR_introDone == false)
		{
			sd(NPC_Paullus_01);
			aod.CTR_introDone = true;
			rwd_location(CaerTor);
		}
		
		if(isAlive(8005))
			dlgSetAnimation(anim_sit_chair_00_00, 0, 8005);
		
		if(aod.ending_gnz_IG_joins_HA)
			dlgSetAnimation(anim_sit_chair_00_00, 0, 8011);
	}
	
	function onStartCombat()
	{
		
	}
	
	function onEndCombat()
	{
		apmsPlayMusic(custom, 33, 1);
		
		if(isalive())
		{
			if(aod.fight_BarnusTest)
			{
				aod.fight_BarnusTest = false;
				BlackSplash.command = "";
				BlackOut.command = "sd(NPC_Barnus_01); rwd_fight(BarnusTest); dlgDeleteDeadCharacters(); startBlackSplash();";
				startBlackOut();
			}
			
			// For Custom Death Screens
			
			deactivateDeathDesc();
		}
	}
	
	function CT_BarnusTest()
	{
		aod.fight_BarnusTest = true;
		createByCharMarker(CM_Barnus_Barbarian_01);
		createByCharMarker(CM_Barnus_Barbarian_02);
		createByCharMarker(CM_Barnus_Barbarian_03);
		createByCharMarker(CM_Barnus_Barbarian_04);
		addParty(BarnusBarbarians, 0);
		addCharToParty(8014, "BarnusBarbarians", "fighter");
		addCharToParty(8015, "BarnusBarbarians", "fighter");
		addCharToParty(8016, "BarnusBarbarians", "fighter");
		addCharToParty(8017, "BarnusBarbarians", "fighter");
		dlgTeleportToMarker(TM_BarnusFight_01);
		addEnemyToParty(1, BarnusBarbarians);
		schedule(100, 0, dlgStartCombat);
	}
	
	function onLeaveLocation()
	{
		globalOnLeaveLocation();
	}
};

useEventPackage(CaerTorEvents);