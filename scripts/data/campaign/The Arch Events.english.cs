package theArchEvents
{
	function onInitLocation()
	{
		setAchievement("ACH_ARCH");
		addJournalLocation(Arch);
	}
	
	function onLoadLocation()
	{
		apmsPlayMusic(custom, 11, 1); // Desert Places
	}
	
	function onGameplayStart()
	{
		//blockTraveling(true);
		
		if(aod.PRT_introDone == false)
		{
			sd(PRT_Intro);
			aod.PRT_introDone = true;
			setCombatAllowed(false);
			rwd_location(theArch);
			dlgTeleportToMarker(TM_Intro_PC_00);
			dlgcam(125, 40, 15);
		}
		
		if(aod.quest_teronRaider_metLeader && aod.npc_esbenus_dead == false)
		{
			createByCharMarker("CM_Esbenus_Portal");
			createByCharMarker("CM_Portal_Slaver_01");
			createByCharMarker("CM_Portal_Slaver_02");
			createByCharMarker("CM_Portal_Slaver_03");
			createByCharMarker("CM_Portal_Slaver_04");
			createByCharMarker("CM_Portal_Slaver_05");
			createByCharMarker("CM_Portal_Slaver_06");
			dlgTeleportToMarker(TM_Oracle_NPC_02, 5830);
			aod.jnl_arch_phase2 = true;
			aod.npc_esbenus_portal = 1;
		}
		
		else setCombatAllowed(false);
		
		//BlackSplash.command = "";
		//BlackOut.command = "apmsStartDialogue(Quest_Zamedi_02); startBlackSplash();";
		//startBlackOut();
		
		
		//*************** Party Settings ****
		//***********************************
		
		if(aod.quest_teronRaider_metLeader && aod.npc_esbenus_dead == false)
		{
			addParty(EsbenusSlavers, 0);
			addCharToParty(1558, "EsbenusSlavers", "fighter");
			addCharToParty(5840, "EsbenusSlavers", "fighter");
			addCharToParty(5841, "EsbenusSlavers", "fighter");
			addCharToParty(5842, "EsbenusSlavers", "fighter");
			addCharToParty(5843, "EsbenusSlavers", "fighter");
			addCharToParty(5844, "EsbenusSlavers", "fighter");
			addCharToParty(5845, "EsbenusSlavers", "fighter");
		}
		
		addParty(PortalDwellers, 0);
		addCharToParty(5830, "PortalDwellers", "fighter");
		addCharToParty(5831, "PortalDwellers", "fighter");
		addCharToParty(5832, "PortalDwellers", "fighter");
		addCharToParty(5833, "PortalDwellers", "fighter");
		addCharToParty(5834, "PortalDwellers", "fighter");
		addCharToParty(5835, "PortalDwellers", "fighter");
		addCharToParty(5836, "PortalDwellers", "fighter");
		addCharToParty(5837, "PortalDwellers", "fighter");
		addCharToParty(5838, "PortalDwellers", "fighter");
	}
	
	function onEndCombat()
	{
		apmsPlayMusic(custom, 11, 1); // Desert Places
		
		if(isalive())
		{
			if(isDead(1558) && isAlive(5830) && aod.prt_oracle_talkedFreedom == false)
			{
				aod.prt_oracle_talkAboutFreedom = true;
				aod.jnl_arch_phase3 = true;
				rwd_fight(Portal_01);
				BlackSplash.command = "";
				BlackOut.command = "sd(PRT_Oracle); startBlackSplash();";
				startBlackOut();
			}
			
			// For Custom Death Screens
			
			deactivateDeathDesc();
		}
	}
	
	function onLeaveLocation()
	{
		globalOnLeaveLocation();
	}
	
	function TRG_EsbenusPortal()
	{
		if(isInCombat() == false && aod.npc_esbenus_dead == false && aod.npc_esbenus_archPaid == false)
		{
			BlackSplash.command = "";
			BlackOut.command = "sd(PRT_Intro); startBlackSplash();";
			startBlackOut();
		}
	}

	function TRG_PortalApproach()
	{
		if(aod.npc_esbenus_enemy && aod.prt_approached == false)
		{
			aod.prt_approached = true;
			addEnemyToParty(1, EsbenusSlavers);
			schedule(100, 0, dlgStartCombat);
			sayPhrase(1558, "Should have killed you back in Teron.");
		}
		
		else if(isInCombat() == false && aod.prt_approached == false)
		{
			aod.prt_approached = true;
			
			if(aod.npc_oracle_met == false)
			{
				BlackSplash.command = "";
				BlackOut.command = "sd(PRT_Intro); startBlackSplash();";
				startBlackOut();
			}
		}
	}

	function VCO_PRT_Portal()
	{
		BlackSplash.command = "";
		BlackOut.command = "sd(PRT_Portal); startBlackSplash();";
		startBlackOut();
	}
};

useEventPackage(theArchEvents);