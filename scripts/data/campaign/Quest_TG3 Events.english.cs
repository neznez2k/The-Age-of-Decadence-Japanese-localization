package TG3Events
{
	function onInitLocation()
	{

	}
	
	function onLoadLocation()
	{
		if(aod.quest_tg3_walkway == 0)
			setgrouppassability(79, 58, 79, 57, 0, 0);
		else
			setgrouppassability(79, 58, 79, 57, 0, 1);
	}
	
	function onGameplayStart()
	{
		setTravelingAllowed(false);
		setCombatAllowed(false);
		
		if(aod.quest_tg3_foughtMercs == 1 || aod.fight_tg3_ambush == 2 || aod.fight_tg3_leaderAmbush == 2)
		{	
			setTravelingAllowed(1);
		}
		
		if(aod.ending_npc_livia_01)
			createByCharMarker("CM_Livia");
		
		//*************** Party Settings ****
		//***********************************
		
		addParty(TG3_Thieves, 0);
		addCharToParty(1, "TG3_Thieves", "fighter");
		addCharToParty(1961, "TG3_Thieves", "fighter");
		addCharToParty(1962, "TG3_Thieves", "fighter");
		addCharToParty(1963, "TG3_Thieves", "fighter");
		
		addParty(TG3_Mob, 0);
		addCharToParty(1955, "TG3_Mob", "fighter");
		addCharToParty(1956, "TG3_Mob", "fighter");
		addCharToParty(1957, "TG3_Mob", "fighter");
		addCharToParty(1958, "TG3_Mob", "fighter");
		addCharToParty(1959, "TG3_Mob", "fighter");
		addCharToParty(1960, "TG3_Mob", "fighter");
		
		addParty(TG3_Guard, 0);
		addCharToParty(1969, "TG3_Guard", "fighter");
		addCharToParty(1970, "TG3_Guard", "fighter");
		addCharToParty(1971, "TG3_Guard", "fighter");
		
		addParty(TG3_Mercs, 0);
		addCharToParty(1972, "TG3_Mercs", "fighter");
		addCharToParty(1973, "TG3_Mercs", "fighter");
		addCharToParty(1974, "TG3_Mercs", "fighter");
		addCharToParty(1975, "TG3_Mercs", "fighter");
		addCharToParty(1976, "TG3_Mercs", "fighter");
		addCharToParty(1977, "TG3_Mercs", "fighter");
	}
	
	function onEndCombat()
	{
		
		
		if(isalive())
		{
			if(aod.fight_tg3_Iolus)
			{
				aod.fight_tg3_Iolus = false;
				rwd_fight(TG3_02);
				VCO_Wall.setActive(1);
				setObjectRenderState(EXIT_Wall_Passage, 1);
			}
			
			if(aod.fight_tg3_Bracchus)
			{
				aod.fight_tg3_Bracchus = false;
				rwd_fight(TG3_03);
				VCO_Wall.setActive(1);
				VCO_Wall.setCursorText(11);
				setObjectRenderState(EXIT_Wall_Passage, 1);
			}
			
			if(aod.quest_tg3_fightMob)
			{
				aod.quest_tg3_fightMob = false;
				aod.quest_tg3_foughtMob = true;
				VCO_MobToGate.setActive(1);
				setObjectRenderState(EXIT_MobToGate, 1);
			}
			
			if(aod.fight_tg3_ambush == 1 || aod.fight_tg3_leaderAmbush == 1)
			{
				if(aod.fight_tg3_ambush == 1)
					aod.fight_tg3_ambush = 2;
				if(aod.fight_tg3_leaderAmbush == 1)
					rwd_reputation(TG3_06);
					aod.fight_tg3_leaderAmbush = 2;
				
				VCO_CartAmbush.setActive(1);
				setObjectRenderState(EXIT_CartAmbush, 1);
			}
			
			if(aod.quest_tg3_fightGuards)
			{
				aod.quest_tg3_fightGuards = false;
				aod.quest_tg3_foughtGuards = true;
				VCO_GateToMerc.setActive(1);
				setObjectRenderState(EXIT_GateToMerc, 1);
			}
			
			if(aod.quest_tg3_foughtMercs == 1)
			{	
				if(getObjectRenderState(OBJ_Cart_Merc_Gate) == 1)
				{
					VCO_Cart_Merc_Gate.setActive(1);
					setObjectRenderState(EXIT_Cart_Merc_Gate, 1);
				}
				else if(getObjectRenderState(OBJ_Cart_Merc_Forest) == 1)
				{
					VCO_Cart_Merc_Forest.setActive(1);
					setObjectRenderState(EXIT_Cart_Merc_Forest, 1);
				}
				else if(getObjectRenderState(OBJ_Cart_Merc_Camp) == 1)
				{
					VCO_Cart_Merc_Camp.setActive(1);
					setObjectRenderState(EXIT_Cart_Merc_Camp, 1);
				}
			}
			
			//BlackSplash.command = "";
			//BlackOut.command = "SS_start(\"gnz_ending\", \"disconnect();\"); startBlackSplash();";
			//startBlackOut();
			
			// For Custom Death Screens
			
			deactivateDeathDesc();
		}
	}
	
	function onLeaveLocation()
	{
		globalOnLeaveLocation();
	}
	
	function TRG_StartMob()
	{
		if(aod.quest_tg3_status == 2)
		{
			BlackSplash.command = "";
			BlackOut.command = "sd(Quest_TG3_Mob); startBlackSplash();";
			startBlackOut();
		}
	}
	
	function TRG_StartGate()
	{
		if(aod.quest_tg3_status == 3)
		{
			aod.quest_tg3_status = 4;
			
			if(aod.quest_tg1_guardsBribed)
				startFadeDlg(quest_tg3_04);
			else
				startFadeDlg(quest_tg3_05);
		}
	}
	
	function VCO_LeaveMob()
	{
		MessageBoxYesNo("Escape the town!", "You cut a path through the mob, leaving a trail of corpses behind you. The way to the gate is clear. Continue?", "startFadeScript(Move_Mob_Gate); VCO_MobToGate.setActive(0); setObjectRenderState(EXIT_MobToGate, 0);", "");
	}
	
	function VCO_LeaveGate()
	{
		startFadeDlg(Quest_TG3_05);
	}
	
	function VCO_WallPassage()
	{
		if(aod.quest_tg3_foughtBracchus)
		{
			StartFadeDlg(quest_tg3_04);
		}
		
		else if(aod.per >= 7)
		{
			aod.quest_tg3_foundPassage = 1;
			StartFadeDlg(quest_tg3_04);
		}

		else
		{
			narratePhrase("[failure] You can't find the passage. You should take the cart and go through the gate.");
			VCO_CartWall.setActive(1);
		}
	}
	
	function tg3_deleteMob()
	{
		/*if(aod.quest_tg3_mobLeaderParty == false)
		{
			dlgDeleteCharacter(1955);
		}
		
		dlgDeleteCharacter(1956);
		dlgDeleteCharacter(1957);
		dlgDeleteCharacter(1958);
		dlgDeleteCharacter(1959);
		dlgDeleteCharacter(1960);
		dlgDeleteDeadCharacters();*/
	}
	
	function tg3_deleteRobbers()
	{
		dlgDeleteCharacter(1978);
		dlgDeleteCharacter(1979);
		dlgDeleteCharacter(1980);
		dlgDeleteCharacter(1981);
		dlgDeleteCharacter(1982);
	}
	
	function tg3_createAmbush()
	{
		createByCharMarker("CM_Ambush_Guy_01");
		createByCharMarker("CM_Ambush_Guy_02");
		createByCharMarker("CM_Ambush_Guy_03");
		createByCharMarker("CM_Ambush_Guy_04");
		createByCharMarker("CM_Ambush_Guy_05");
		addParty(tg3_ambush, 0);
		addCharToParty(1978, tg3_ambush, fighter);
		addCharToParty(1979, tg3_ambush, fighter);
		addCharToParty(1980, tg3_ambush, fighter);
		addCharToParty(1981, tg3_ambush, fighter);
		addCharToParty(1982, tg3_ambush, fighter);
	}
	
	function StartMob()
	{
		dlgTeleportToMarker(TM_Start_Mob_PC);
		setObjectRenderState(OBJ_CartMob_1, 1);
		setPassability(73, 102, 0, 0);
		dlgTeleportToMarker(TM_Start_Mob_Thief_01, 1961);
		dlgTeleportToMarker(TM_Start_Mob_Thief_02, 1962);
		dlgTeleportToMarker(TM_Start_Mob_Thief_03, 1963);
	}
	
	function Fail_Mob_Cheat()
	{
		dlgTeleportToMarker(TM_Fail_Mob_01, 1960);
		dlgTeleportToMarker(TM_Fail_Mob_02, 1959);
		dlgTeleportToMarker(TM_Fail_Mob_03, 1956);
		dlgTeleportToMarker(TM_Fail_Mob_04, 1957);
		dlgTeleportToMarker(TM_Fail_Mob_05, 1958);
		dlgSetCombatAnimation(1955);
		dlgSetCombatAnimation(1956);
		dlgSetCombatAnimation(1957);
		dlgSetCombatAnimation(1958);
		dlgSetCombatAnimation(1959);
		dlgSetCombatAnimation(1960);
	}
	
	function Move_Mob_Talk()
	{
		setpassability(82, 100, 0, 0);
		setpassability(73, 102, 0, 1);
		setObjectRenderState(OBJ_CartMob_1, 0);
		setObjectRenderState(OBJ_CartMob_2, 1);
		dlgTeleportToMarker(TM_Talk_Mob_PC);
		dlgTeleportToMarker(TM_Talk_Mob_Thief_01, 1961);
		dlgTeleportToMarker(TM_Talk_Mob_Thief_02, 1962);
		dlgTeleportToMarker(TM_Talk_Mob_Thief_03, 1963);
	}
	
	function Move_Mob_Gate()
	{
		setpassability(82, 100, 0, 1);
		setpassability(82, 78, 0, 0);
		setObjectRenderState(OBJ_CartMob_1, 0);
		setObjectRenderState(OBJ_CartMob_2, 0);
		setObjectRenderState(OBJ_Cart_Gate_1, 1);
		dlgTeleportToMarker(TM_Start_Gate_PC);
		if(isAlive(1961)) {dlgTeleportToMarker(TM_Start_Gate_Thief_01, 1961); dlgSetAmbientAnimation(1961);}
		if(isAlive(1962)) {dlgTeleportToMarker(TM_Start_Gate_Thief_02, 1962); dlgSetAmbientAnimation(1962);}
		if(isAlive(1963)) {dlgTeleportToMarker(TM_Start_Gate_Thief_03, 1963); dlgSetAmbientAnimation(1963);}
		if(aod.quest_tg3_mobLeaderParty && isAlive(1955)) dlgTeleportToMarker(TM_Start_Gate_MobLeader, 1955);
	}
	
	function Move_Gate_Wall()
	{
		setpassability(82, 100, 0, 1);
		setpassability(82, 78, 0, 0);
		setObjectRenderState(OBJ_Cart_Gate_1, 0);
		setObjectRenderState(OBJ_Cart_Wall_1, 1);
		dlgTeleportToMarker(TM_Start_Wall_PC);
		if(isAlive(1961)) {dlgTeleportToMarker(TM_Start_Wall_Thief_01, 1961); dlgSetAmbientAnimation(1961);}
		if(isAlive(1962)) {dlgTeleportToMarker(TM_Start_Wall_Thief_02, 1962); dlgSetAmbientAnimation(1962);}
		if(isAlive(1963)) {dlgTeleportToMarker(TM_Start_Wall_Thief_03, 1963); dlgSetAmbientAnimation(1963);}
		if(aod.quest_tg3_mobLeaderParty && isAlive(1955)) dlgTeleportToMarker(TM_Start_Wall_MobLeader, 1955);
	}
	
	function Move_Fight_Wall()
	{
		dlgTeleportToMarker(TM_Fight_Wall_PC);
		if(isAlive(1961)) {dlgTeleportToMarker(TM_Fight_Wall_Thief_01, 1961); dlgSetAmbientAnimation(1961);}
		if(isAlive(1962)) {dlgTeleportToMarker(TM_Fight_Wall_Thief_02, 1962); dlgSetAmbientAnimation(1962);}
		if(isAlive(1963)) {dlgTeleportToMarker(TM_Fight_Wall_Thief_03, 1963); dlgSetAmbientAnimation(1963);}
		if(aod.quest_tg3_mobLeaderParty && isAlive(1955)) dlgTeleportToMarker(TM_Fight_Wall_MobLeader, 1955);
	}
	
	function Move_Gate_Fight()
	{
		if(isAlive(1961) && aod.quest_tg3_thiefAtGate == 0) dlgTeleportToMarker(TM_Fight_Gate_Thief_01, 1961);
		if(isAlive(1962)) dlgTeleportToMarker(TM_Fight_Gate_Thief_02, 1962);
		if(isAlive(1963)) dlgTeleportToMarker(TM_Fight_Gate_Thief_03, 1963);
		if(aod.quest_tg3_mobLeaderParty && isAlive(1955)) dlgTeleportToMarker(TM_Fight_Gate_MobLeader, 1955);
	}
	
	function Move_Gate_Merc()
	{
		setgrouppassability(82, 54, 82, 52, 0, 0);
		setObjectRenderState(OBJ_Cart_Gate_1, 0);
		setObjectRenderState(OBJ_Cart_Merc_Gate, 1);
		dlgTeleportToMarker(TM_Start_Merc_PC);
		if(isAlive(1961)) dlgTeleportToMarker(TM_Start_Merc_Thief_01, 1961);
		if(isAlive(1962)) dlgTeleportToMarker(TM_Start_Merc_Thief_02, 1962);
		if(isAlive(1963)) dlgTeleportToMarker(TM_Start_Merc_Thief_03, 1963);
		dlgTeleportToMarker(TM_Start_Merc_Thief_04, 1983);
		dlgTeleportToMarker(TM_Start_Merc_Lucius, 1110);
		if(aod.quest_tg3_mobLeaderParty && isAlive(1955)) dlgTeleportToMarker(TM_Start_Merc_MobLeader, 1955);
	}
	
	function Move_Merc_Sneak()
	{
		setpassability(73, 26, 0, 0);
		setObjectRenderState(OBJ_Cart_Merc_Forest, 1);
		setObjectRenderState(OBJ_Cart_Merc_Gate, 0);
		dlgTeleportToMarker(TM_Sneak_Merc_PC);
		if(isAlive(1961)) dlgTeleportToMarker(TM_Sneak_Merc_Thief_01, 1961);
		if(isAlive(1962)) dlgTeleportToMarker(TM_Sneak_Merc_Thief_02, 1962);
		if(isAlive(1963)) dlgTeleportToMarker(TM_Sneak_Merc_Thief_03, 1963);
		dlgTeleportToMarker(TM_Sneak_Merc_Thief_04, 1983);
		dlgTeleportToMarker(TM_Sneak_Merc_Lucius, 1110);
	}
	
	function Move_Merc_Camp()
	{
		setgrouppassability(82, 54, 82, 52, 0, 1);
		setObjectRenderState(OBJ_Cart_Merc_Camp, 1);
		setObjectRenderState(OBJ_Cart_Merc_Gate, 0);
		dlgTeleportToMarker(TM_Camp_Merc_PC);
		if(isAlive(1961)) dlgTeleportToMarker(TM_Camp_Merc_Thief_01, 1961);
		if(isAlive(1962)) dlgTeleportToMarker(TM_Camp_Merc_Thief_02, 1962);
		if(isAlive(1963)) dlgTeleportToMarker(TM_Camp_Merc_Thief_03, 1963);
		dlgTeleportToMarker(TM_Camp_Merc_Thief_04, 1983);
		dlgTeleportToMarker(TM_Camp_Merc_Lucius, 1110);
		if(aod.quest_tg3_mobLeaderParty && isAlive(1955)) dlgTeleportToMarker(TM_Camp_Merc_MobLeader, 1955);
		dlgTeleportToMarker(TM_Merc_Camp_01, 1975);
		dlgTeleportToMarker(TM_Merc_Camp_02, 1976);
		dlgTeleportToMarker(TM_Merc_Camp_03, 1973);
	}
	
	function Move_Merc_Fight_Gate()
	{
		dlgTeleportToMarker(TM_Merc_Gate_Fight_01, 1972);
		dlgTeleportToMarker(TM_Merc_Gate_Fight_02, 1977);
		dlgTeleportToMarker(TM_Merc_Gate_Fight_03, 1974);
		
		if(aod.quest_tg2_foughtMercs == 0)
		{
			dlgTeleportToMarker(TM_Merc_Gate_Fight_04, 1975);
			dlgTeleportToMarker(TM_Merc_Gate_Fight_05, 1976);
		}
	}
	
	function Move_Merc_Fight_Sneak()
	{
		dlgTeleportToMarker(TM_Merc_Sneak_Fight_01, 1972);
		dlgTeleportToMarker(TM_Merc_Sneak_Fight_02, 1977);
		dlgTeleportToMarker(TM_Merc_Sneak_Fight_03, 1974);
		dlgTeleportToMarker(TM_Merc_Sneak_Fight_04, 1975);
		dlgTeleportToMarker(TM_Merc_Sneak_Fight_05, 1976);
	}
	
	function Aziz_End()
	{
		TeronDayTime();
		setObjectRenderState(OBJ_Cart_Aziz, 1);
		dlgTeleportToMarker(TM_End_PC);
		dlgTeleportToMarker(TM_End_Aziz, 1300);
		if(isAlive(1961)) {dlgTeleportToMarker(TM_End_Thief_01, 1961); dlgSetAmbientAnimation(1961);}
		if(isAlive(1962)) {dlgTeleportToMarker(TM_End_Thief_02, 1962); dlgSetAmbientAnimation(1962);}
		if(isAlive(1963)) {dlgTeleportToMarker(TM_End_Thief_03, 1963); dlgSetAmbientAnimation(1963);}
		if(isAlive(1983)) {dlgTeleportToMarker(TM_End_Thief_04, 1983); dlgSetAmbientAnimation(1983);}
		if(isAlive(1110)) {dlgTeleportToMarker(TM_End_Lucius, 1110); dlgSetAmbientAnimation(1110);}
		dlgDeleteDeadCharacters();
		dlgCam(225, 40, 8, 1);
	}
	
	function getnumberdead()
	{
		if(isDead(1961))
			%dead += 1;
		if(isDead(1962))
			%dead += 1;
		if(isDead(1963))
			%dead += 1;
		
		return %dead;
	}
	
	function dealXbowGate()
	{
		if(isAlive(1961))
		{
			dlgTeleportToMarker(TM_Sneak_Xbow_01, 1961);
			dlgAddItem(301, 15, 1961);
		}
		else if(isAlive(1962))
		{
			dlgTeleportToMarker(TM_Sneak_Xbow_01, 1962);
			dlgAddItem(301, 15, 1962);
		}
		else if(isAlive(1963))
		{
			dlgTeleportToMarker(TM_Sneak_Xbow_01, 1963);
			dlgAddItem(301, 15, 1963);
		}
	}
	
	function mapScreenButtonScripts()
	{
		if(aod.fight_tg3_ambush == 2 || aod.fight_tg3_leaderAmbush == 2)
			sdFade(quest_tg3_04);
		else
			sdFade(quest_tg3_03);
	}
	
	// aod.quest_tg3_status == 1 - Started the quest.
	// aod.quest_tg3_status == 2 - Approach Mob.
	// aod.quest_tg3_status == 3 - Solved Mob, approach gate (both yourself or Flavius) 
	// aod.quest_tg3_status == 4 - Solved gate, approach mercs
	// aod.quest_tg3_status == 5 - Solved mercs, leave
	// aod.quest_tg3_status == 6 - Solved Bracchus/guard, approach ambush
	// aod.quest_tg3_status == 7 - Solved ambush
};

useEventPackage(TG3Events);