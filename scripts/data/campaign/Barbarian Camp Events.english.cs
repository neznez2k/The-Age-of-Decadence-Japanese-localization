package OrduCampEvents
{
	function onInitLocation()
	{
		setAchievement("ACH_ORDU");
		addJournalLocation(Ordu);
	}
	
	function onLoadLocation()
	{
		apmsPlayMusic(custom, 11, 1); // Desert Places
	}
	
	function onGameplayStart()
	{
		dlgSetAmbientAnimation();
		
		setCombatAllowed(false);
		
		if(aod.loc_ordu_started == false)
		{
			ss_start(start_ord);
			rwd_location(Ordu);
			aod.loc_ordu_started = true;
			//apmsStartDialogue(NPC_Thorgul_01);
			addParty(orduCamp_bondsmen, 0);
			addCharToParty(4800, "orduCamp_bondsmen", "fighter");
			addCharToParty(4810, "orduCamp_bondsmen", "fighter");
			addCharToParty(4811, "orduCamp_bondsmen", "fighter");
			addCharToParty(4812, "orduCamp_bondsmen", "fighter");
			addCharToParty(4813, "orduCamp_bondsmen", "fighter");
			dlgSetAnimation(anim_sit_chair_00_00, 0, 4800);
			dlgSetAnimation(anim_sit_ground_00_00, 0, 4811);
			dlgSetAnimation(anim_sit_ground_02_00, 0, 4812);
			aod.quest_ordu_attackStrength = 3;
		}
		
		//*************** Party Settings ****
		//***********************************
		
		dlgSetAnimation(anim_sit_ground_00_00, 0, 4815);
	}
	
	function onStartCombat()
	{
		if(aod.quest_ordu_betrayBelgutai)
		{
			dlgSetAttitude(4805, 1, -10);
		}
	}
	
	function onEndCombat()
	{
		apmsPlayMusic(custom, 11, 1); // Desert Places
		
		if(isalive())
		{
			
			if(aod.fight_ordu_prison)
			{
				rwd_fight(OrduCamp_02);
				aod.fight_ordu_prison = false;
				VCO_PrisonExit.setActive(true);
				EXIT_PrisonExit.isRenderEnabled = true;
			}
			
			if(aod.fight_belgutaiChallenge)
			{
				aod.fight_belgutaiChallenge = false;
				rwd_fight(OrduCamp_03);
			}
			
			if(aod.fight_belgutaiBetrayal)
			{
				rwd_fight(OrduCamp_01);
				aod.fight_belgutaiBetrayal = false;
				if(isDead(4805))
				{
					VCO_KhanTent.setActive(true);
					EXIT_KhanTent.isRenderEnabled = true;
					aod.quest_ordu_attackStrength = 1; //No Attack
				}
				else
				{
					removeCharFromParty(4805);
					aod.quest_ordu_betrayBelgutai = true;
				}
			}
			
			dlgSetAnimation(anim_sit_ground_00_00, 0, 4815);
			
			// For Custom Death Screens
			
			deactivateDeathDesc();
		}
	}
	
	function onLeaveLocation()
	{
		globalOnLeaveLocation();
	}
	
	function VCO_ORD_well()
	{
		BlackSplash.command = "";
		BlackOut.command = "sd(ORD_Well); startBlackSplash();";
		startBlackOut();
	}
	
	function DOOR_Thorgul_Open()
	{
		if(aod.npc_thorgul_met == 0)
		{
			BlackSplash.command = "";
			BlackOut.command = "sd(NPC_Thorgul_01); startBlackSplash();";
			startBlackOut();
		}
	}
	
	function TGR_KhanTent()
	{
		if(aod.ordu_KhanTent == 0)
			narratePhrase("The khan's tent is easy to find - it's the only tent with two guards posted outside.<nlo>They scoff at you, but step aside, pointing at the entrance.");
		aod.ordu_KhanTent = 1;
	}
	
	function mapScreenButtonScripts()
	{
		MessageBoxYesNo("Ordu Camp", "Return to the mountain pass?", "switchMission(\"Quest_IG6.mis\");", "");
		
		//else
		//	apmsStartMapScreen();
	}
};

useEventPackage(OrduCampEvents);