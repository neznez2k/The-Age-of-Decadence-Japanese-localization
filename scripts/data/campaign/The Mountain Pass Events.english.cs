package ThePassEvents
{
	function onInitLocation()
	{
		setAchievement("ACH_PASS");
		addJournalLocation(Pass);
	}
	
	function onLoadLocation()
	{
		apmsPlayMusic(custom, 33, 1); // IG Light
	}
	
	function onGameplayStart()
	{
		setCombatAllowed(false);
		
		if(aod.pass_introDone == 0)
		{
			aod.pass_introDone = 1;
			ss_start(start_pass, "pass_startDlg();");
			rwd_location(thePass);
		}
		
		if (isAlive(4430))
			dlgSetAnimation(anim_sit_chair_00_00, 0, 4430);
		
		//*************** Party Settings ****
		//***********************************
		
		addParty(PassGuards, 0);
		addCharToParty(4410, "PassGuards", "fighter");
		addCharToParty(4430, "PassGuards", "fighter");
		addCharToParty(5500, "PassGuards", "fighter");
		addCharToParty(5505, "PassGuards", "fighter");
		addCharToParty(5510, "PassGuards", "fighter");
		addCharToParty(5511, "PassGuards", "fighter");
		addCharToParty(5512, "PassGuards", "fighter");
		addCharToParty(5515, "PassGuards", "fighter");
		addCharToParty(5516, "PassGuards", "fighter");
		addCharToParty(5517, "PassGuards", "fighter");
		addCharToParty(5518, "PassGuards", "fighter");
		addCharToParty(5520, "PassGuards", "fighter");
		addCharToParty(5521, "PassGuards", "fighter");
		addCharToParty(5530, "PassGuards", "fighter");
		addCharToParty(5540, "PassGuards", "fighter");
		addCharToParty(5550, "PassGuards", "fighter");
		addCharToParty(5551, "PassGuards", "fighter");
		addCharToParty(5555, "PassGuards", "fighter");
		addCharToParty(5556, "PassGuards", "fighter");
		addCharToParty(5560, "PassGuards", "fighter");
	}
	
	function onEndCombat()
	{
		apmsPlayMusic(custom, 33, 1); // IG Light
		
		if (isalive() == true)
		{
			if(aod.fight_haPass_intro)
			{
				BlackSplash.command = "";
				BlackOut.command = "sd(Quest_HA_Pass_01); startBlackSplash();";
				startBlackOut();
			}
			
			// For Custom Death Screens
			
			deactivateDeathDesc();
		}
	}
	
	function quest_ha_startNight()
	{
		BlackSplash.command = "";
		BlackOut.command = "sd(Quest_HA_Pass_01); startBlackSplash();";
		startBlackOut();
	}
	
	function onLeaveLocation()
	{
		globalOnLeaveLocation();
	}
	
	function pass_startDlg()
	{
		if(aod.quest_IG5_getPassIntro)
		{
			aod.quest_IG5_getPassIntro = false;
			aod.npc_bass_met = 1;
			sd(NPC_Bass_01); 
		}
		
		else if(aod.quest_HA2_goToPass)
		{
			aod.quest_HA2_goToPass = false;
			aod.jnl_HA2_phase2 = true;
			sd(Quest_HA_Pass_01);
		}
		
		else
			aod.pas_open = 1;
	}
	
	function setNight()
	{
		theSun.color = "0.28 0.35 0.63 1";
		theSun.ambient = "0.16 0.18 0.26 1";
		theSun.brightness = 0.5;
		theSun.castShadows = "1";
		theSun.shadowSoftness = 5;
		theSun.apply();
	}
	
	function setDay()
	{
		theSun.color = "0.86 0.71 0.45 1";
		theSun.ambient = "0.45 0.39 0.31 1";
		theSun.brightness = 1.4;
		theSun.castShadows = "1";
		theSun.shadowSoftness = 0.5;
		theSun.apply();
	}
	
	function mapScreenButtonScripts()
	{
		if(aod.quest_HA_pass == 2)
			MessageBoxYesNo("Harran's Pass", "Wait till dark?", "quest_ha_startNight();", "");
		else if(aod.pas_open == 0)
		{
			MessageBoxYesNo("Harran's Pass", "Go to the ordu camp?", "switchMission(\"Barbarian Camp.mis\");", "");
		}
		else
			apmsStartMapScreen();
	}
};

useEventPackage(ThePassEvents);