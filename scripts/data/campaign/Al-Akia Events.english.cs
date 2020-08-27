package AlAkiaEvents
{
	function onInitLocation()
	{
		//revealMapLocation("Al-Akia");	Check for location name.
		setAchievement("ACH_ALK");
		addJournalLocation(ALK);
	}
	
	function onLoadLocation()
	{
		apmsPlayMusic(custom, 11, 1); // Desert Places
	}
	
	function onGameplayStart()
	{
		setTravelingAllowed(true);
		setCombatAllowed(false);
		aod.alk_visited = 1;
		
		if(aod.ALK_introDone == false)
		{
			aod.ALK_introDone = true;
			rwd_location(alAkia);
			aod.alk_visited = 1;
		}
		
		if(aod.alk_HD1 == 1) // For when you come with House Daratan to blow it.
		{
			ALK_removeCrassus();
			ALK_removeLoremasters();
			sd(ALK_HD_01);
			ALK_createCrassus();
			ALK_createDaratan();
			ALK_addCrassusPartyHD();
			ALK_addDaratanParty();
			addCharToParty(1, ALK_Daratan, fighter);
			aod.alk_HD1 = 2;
			aod.alk_HD2 = 5;
		}
		else if(aod.alk_hd2 == 1 || aod.quest_GNZ_MS_status == 3) // No siege in Ganezzar, you are part of the expedition
		{
			ALK_createCrassus();
			ALK_addCrassusParty();
			ALK_createLoremasters();
			dlgTeleportToMarker(TM_PC_MGStart);
			if(aod.alk_HD2 == 1) aod.alk_HD2 = 2;
			if(aod.quest_GNZ_MS_status == 3) {aod.alk_MS = 1; aod.jnl_MS_AlAkia = 1; aod.quest_GNZ_MS_status = 4;} // Mind Shield Path
			if(aod.quest_GnzHD2_status == 2) aod.quest_GnzHD2_status = 3;
			if(aod.jnl_AlAkia_HD == 1) aod.jnl_AlAkia_HD = 2;
			ss_start(alk_intro, "alk_startDlg();");
		}
		else if(aod.alk_meruExpedition_intro && aod.alk_HD2 == 0) // MG/IG Expedition
		{
			ss_start(alk_intro, "alk_startDlg();");
			ALK_createIG();
			ALK_createLoremasters();
			ALK_addIGParty();
			dlgTeleportToMarker(TM_PC_MGStart);
		}
		
		if(aod.loc_ALK_fromInterior)
		{
			dlgTeleportToMarker(TM_Start_FromComplex);
			aod.loc_ALK_fromInterior = 0;
			dlgCam(225, 45, 10);
		}
		
		if(aod.alk_IG7_insideComplex)
		{
			ALK_setNight();
			sd(ALK_Complex_Exit_IG);
			
			if(aod.alk_IG7_createAurelian == false)
			{
				ALK_KillIG();
				ALK_killLoremasters();
				// Remove armors and reduce HP
				dlgUnequipSlot(1, 6201);
				dlgUnequipSlot(2, 6201);
				dlgUnequipSlot(3, 6201);
				dlgUnequipHands(6201);
				dlgUnequipSlot(1, 6203);
				dlgUnequipSlot(3, 6203);
				dlgUnequipHands(6203);
				dlgUnequipSlot(1, 6204);
				dlgUnequipSlot(3, 6204);
				dlgUnequipHands(6204);
				dlgChangeCharacterHP(-10, 6200);
				dlgChangeCharacterHP(-15, 6201);
				dlgChangeCharacterHP(-15, 6203);
				dlgChangeCharacterHP(-15, 6204);
				dlgChangeCharacterHP(-20, 6205);
				dlgEquipItem(500, 0, 6201);
				dlgEquipItem(500, 0, 6203);
				dlgEquipItem(500, 0, 6204);
				aod.alk_IG7_createAurelian = true;
			}
			
			ALK_addAurelianParty();
			ALK_teleportAurelianIG();
			aod.alk_IG7_insideComplex = 0;
			killRandomDeathPosition(6202);
		}
		
		if(aod.alk_HC1 == 1)
		{
			if(aod.alk_aurelianGone || aod.gnz_underSiege == 0)
				sd(ALK_HC_00);
			else
			{
				createByCharMarker("CM_Faelan");
				ALK_createSoldiers();
				sd(ALK_HC_01);
				ALK_addAurelianParty();
				ALK_teleportAurelianHC();
				addParty(ALK_Faelan, 0);
				addCharToParty(1, ALK_Faelan, fighter);
				addCharToParty(8001, ALK_Faelan, master);
			}
			
			if(aod.jnl_HD_AlAkiaFate == 6)
				aod.jnl_HD_AlAkiaFate = 7;
			
			if(aod.quest_GnzHD1_status == 2)
				aod.quest_GnzHD1_status = 3;
			
			if(isQuestAdded(HD_GNZ_Siege))
				remQuest(HD_GNZ_Siege);
		}
		
		if(aod.global_ganezzar_completed)
		{
			dlgdeletedeadCharacters();
			ALK_removeIG();
			ALK_removeCrassus();
			ALK_removeAurelian();
		}
		
		if(aod.alk_nightTime)
			ALK_setNight();
		else
			ALK_setDay();
		
		//dlgKillCharacter(6200);	dlgKillCharacter(6201); dlgKillCharacter(6202);	dlgKillCharacter(6203); dlgKillCharacter(6204);	dlgKillCharacter(6205);
		
		//*************** Party Settings ****
		//***********************************
	}
	
	function onStartCombat()
	{
		VCO_Entrance.setActive(0);
		setCharacterInvincible(6240, 1);
		setCharacterInvincible(6241, 1);
		setCharacterInvincible(6242, 1);
		setCharacterInvincible(6243, 1);
	}
	
	function onEndCombat()
	{
		apmsPlayMusic(custom, 11, 1); // Desert Places
		VCO_Entrance.setActive(1);
		
		if(isalive())
		{
			if(aod.fight_ALK_MG8) // Expedition as MG
			{
				rwd_fight(ALK_01);
				BlackSplash.command = "";
				BlackOut.command = "sd(ALK_ExpeditionAttack); startBlackSplash();";
				startBlackOut();
				aod.ALK_ReturnGanezzar = true;
				ALK_loremastersCombatEnd();
				assignDialogue("", 6242);
			}
			
			if(aod.alk_ms) // Expedition as Mind Shield
			{
				rwd_fight(ALK_01);
				BlackSplash.command = "";
				BlackOut.command = "sd(ALK_ExpeditionAttack); startBlackSplash();";
				startBlackOut();
				aod.ALK_ReturnGanezzar = true;
				ALK_loremastersCombatEnd();
				assignDialogue("", 6242);
			}
			
			if(aod.fight_ALK_ExpeditionHD) // Expedition as HD
			{
				rwd_fight(ALK_02);
				BlackSplash.command = "";
				BlackOut.command = "sd(ALK_ExpeditionAttack); startBlackSplash();";
				startBlackOut();
				ALK_loremastersCombatEnd();
				assignDialogue("", 6242);
			}
			
			if(aod.fight_ALK_IG7) // Alone as IG
			{
				rwd_fight(ALK_03);
				aod.fight_ALK_IG7 = false;
				EXIT_ReturnGanezzar.isRenderEnabled = true; 
				aod.ALK_ReturnGanezzar = true;
				rwd_reputation(IG7_01);
			}
			
			if(aod.fight_alk_HC) // With Faelan
			{
				rwd_fight(ALK_04);
				aod.fight_alk_HC = false;
				aod.alk_HC1 = 2;
				BlackSplash.command = "";
				BlackOut.command = "ALK_FaelanKillSurvivors(); sd(ALK_HC_01); startBlackSplash();";
				startBlackOut();
			}
			
			if(aod.fight_alk_HD) // Fight the Crassus Party as HD
			{
				rwd_fight(ALK_05);
				rwd_reputation(HD5_03);
				aod.fight_alk_HD = false;
				BlackSplash.command = "";
				BlackOut.command = "sd(ALK_HD_01); startBlackSplash();";
				startBlackOut();
			}
			
			// For Custom Death Screens
			
			deactivateDeathDesc();
		}
	}
	
	function onEndTurn(%turnNumber)
	{
		if(aod.fight_alk_HC)
		{
			
		}
	}
	
	function ALK_createIG()
	{
		if(aod.pc_member_guards == 0)
			createByCharMarker("CM_AlAkia_IG_Legatus");
		
		createByCharMarker("CM_AlAkia_IG_Soldier_01");
		createByCharMarker("CM_AlAkia_IG_Soldier_02");
		createByCharMarker("CM_AlAkia_IG_Soldier_03");
		createByCharMarker("CM_AlAkia_IG_Soldier_04");
		createByCharMarker("CM_AlAkia_IG_Soldier_05");
	}
	
	function ALK_createLoremasters()
	{
		createByCharMarker("CM_Loremaster_01");
		createByCharMarker("CM_Loremaster_02");
		createByCharMarker("CM_Loremaster_03");
		createByCharMarker("CM_Loremaster_04");
	}
	
	function ALK_killLoremasters()
	{
		killRandomDeathPosition(6240);
		killRandomDeathPosition(6241);
		killRandomDeathPosition(6242);
		killRandomDeathPosition(6243);
	}
	
	function ALK_removeLoremasters()
	{
		dlgDeleteCharacter(6240);
		dlgDeleteCharacter(6241);
		dlgDeleteCharacter(6242);
		dlgDeleteCharacter(6243);
	}
	
	function ALK_createSoldiers()
	{
		createByCharMarker("CM_Aurelian_01");
		createByCharMarker("CM_Aurelian_02");
		createByCharMarker("CM_Aurelian_03");
		createByCharMarker("CM_Aurelian_04");
		createByCharMarker("CM_Aurelian_05");
		createByCharMarker("CM_Aurelian_06");
	}
	
	function ALK_createCrassus()
	{
		createByCharMarker("CM_AlAkia_Crassus_Legionary_01");
		createByCharMarker("CM_AlAkia_Crassus_Legionary_02");
		createByCharMarker("CM_AlAkia_Crassus_Legionary_03");
		createByCharMarker("CM_AlAkia_Crassus_Legionary_04");
		createByCharMarker("CM_AlAkia_Crassus_Legionary_05");
		createByCharMarker("CM_AlAkia_Crassus_Legionary_06");
	}
	
	function ALK_createDaratan()
	{
		createByCharMarker("CM_AlAkia_Daratan_Legionary_01");
		createByCharMarker("CM_AlAkia_Daratan_Legionary_02");
		createByCharMarker("CM_AlAkia_Daratan_Legionary_03");
		createByCharMarker("CM_AlAkia_Daratan_Legionary_04");
		createByCharMarker("CM_AlAkia_Daratan_Legionary_05");
		createByCharMarker("CM_AlAkia_Daratan_Legionary_06");
	}
	
	function ALK_addAurelianParty()
	{
		addParty(ALK_Aurelian, 0);
		addCharToParty(6200, ALK_Aurelian, fighter);
		addCharToParty(6201, ALK_Aurelian, fighter);
		addCharToParty(6202, ALK_Aurelian, fighter);
		addCharToParty(6203, ALK_Aurelian, fighter);
		addCharToParty(6204, ALK_Aurelian, fighter);
		addCharToParty(6205, ALK_Aurelian, fighter);
	}
	
	function ALK_addCrassusParty()
	{
		addParty(ALK_Crassus, 0);
		addCharToParty(6220, ALK_Crassus, fighter);
		addCharToParty(6221, ALK_Crassus, fighter);
		addCharToParty(6222, ALK_Crassus, fighter);
		addCharToParty(6223, ALK_Crassus, fighter);
		addCharToParty(6224, ALK_Crassus, fighter);
		addCharToParty(6225, ALK_Crassus, fighter);
	}
	
	function ALK_addCrassusPartyHD()
	{
		addParty(ALK_CrassusHD, 0);
		addCharToParty(6220, ALK_CrassusHD, fighter);
		addCharToParty(6221, ALK_CrassusHD, fighter);
		addCharToParty(6222, ALK_CrassusHD, fighter);
		addCharToParty(6223, ALK_CrassusHD, fighter);
		addCharToParty(6224, ALK_CrassusHD, fighter);
		addCharToParty(6225, ALK_CrassusHD, fighter);
	}
	
	function ALK_addDaratanParty()
	{
		addParty(ALK_Daratan, 0);
		addCharToParty(6230, ALK_Daratan, fighter);
		addCharToParty(6231, ALK_Daratan, fighter);
		addCharToParty(6232, ALK_Daratan, fighter);
		addCharToParty(6233, ALK_Daratan, fighter);
		addCharToParty(6234, ALK_Daratan, fighter);
		addCharToParty(6235, ALK_Daratan, fighter);
	}
	
	function ALK_addIGParty()
	{
		addParty(ALK_IG, 0);
		addCharToParty(6211, ALK_IG, fighter);
		addCharToParty(6212, ALK_IG, fighter);
		addCharToParty(6213, ALK_IG, fighter);
		addCharToParty(6214, ALK_IG, fighter);
		addCharToParty(6215, ALK_IG, fighter);
	}
	
	function ALK_startMSCombat()
	{
		ALK_addAurelianParty();
		ALK_addCrassusParty();
		addCharToParty(1, ALK_Crassus, fighter);
		addEnemyParty(ALK_Aurelian, ALK_Crassus);
		addEnemyParty(ALK_Crassus, ALK_Aurelian);
		ALK_loremastersCombat();
		dlgTeleportToMarker(TM_PC_Fight_01);
		aod.fight_ALK_MS = true;
		schedule(100, 0, dlgStartCombat);
	}
	
	function ALK_startIGCombat()
	{
		ALK_addAurelianParty();
		ALK_addIGParty();
		addCharToParty(1, ALK_IG, fighter);
		addEnemyParty(ALK_Aurelian, ALK_IG);
		addEnemyParty(ALK_IG, ALK_Aurelian);
		ALK_loremastersCombat();
		dlgTeleportToMarker(TM_PC_Fight_01);
		aod.fight_ALK_MG8 = true;
		schedule(100, 0, dlgStartCombat);
	}
	
	function ALK_removeIG()
	{
		if(isAlive(6210))
			dlgDeleteCharacter(6210);
		
		if(isAlive(6211))
			dlgDeleteCharacter(6211);
		
		if(isAlive(6212))
			dlgDeleteCharacter(6212);
		
		if(isAlive(6213))
			dlgDeleteCharacter(6213);
		
		if(isAlive(6214))
			dlgDeleteCharacter(6214);
		
		if(isAlive(6215))
			dlgDeleteCharacter(6215);
	}
	
	function ALK_removeCrassus()
	{
		if(isAlive(6220))
			dlgDeleteCharacter(6220, 1);
		
		if(isAlive(6221))
			dlgDeleteCharacter(6221, 1);
		
		if(isAlive(6222))
			dlgDeleteCharacter(6222, 1);
		
		if(isAlive(6223))
			dlgDeleteCharacter(6223, 1);
		
		if(isAlive(6224))
			dlgDeleteCharacter(6224, 1);
		
		if(isAlive(6225))
			dlgDeleteCharacter(6225, 1);
	}
	
	function ALK_removeAurelian()
	{
		dlgDeleteCharacter(6200);
		dlgDeleteCharacter(6201);
		dlgDeleteCharacter(6202);
		dlgDeleteCharacter(6203);
		dlgDeleteCharacter(6204);
		dlgDeleteCharacter(6205);
	}
	
	function ALK_KillIG()
	{
		if(isAlive(6210))
			killRandomDeathPosition(6210);
		
		if(isAlive(6211))
			killRandomDeathPosition(6211);
		
		if(isAlive(6212))
			killRandomDeathPosition(6212);
		
		if(isAlive(6213))
			killRandomDeathPosition(6213);
		
		if(isAlive(6214))
			killRandomDeathPosition(6214);
		
		if(isAlive(6215))
			killRandomDeathPosition(6215);
	}
	
	function ALK_teleportAurelianMG()
	{
		dlgTeleportToMarker(TM_Aurelian_01, 6200);
		dlgTeleportToMarker(TM_Aurelian_02, 6201);
		dlgTeleportToMarker(TM_Aurelian_03, 6202);
		dlgTeleportToMarker(TM_Aurelian_04, 6203);
		dlgTeleportToMarker(TM_Aurelian_05, 6204);
		dlgTeleportToMarker(TM_Aurelian_06, 6205);
	}
	
	function ALK_teleportAurelianHC()
	{
		dlgTeleportToMarker(TM_Aurelian_HC_01, 6200);
		dlgTeleportToMarker(TM_Aurelian_HC_02, 6201);
		dlgTeleportToMarker(TM_Aurelian_HC_03, 6202);
		dlgTeleportToMarker(TM_Aurelian_HC_04, 6203);
		dlgTeleportToMarker(TM_Aurelian_HC_05, 6204);
		dlgTeleportToMarker(TM_Aurelian_HC_06, 6205);
		dlgTeleportToMarker(TM_Aurelian_HC_07, 6206);
		dlgTeleportToMarker(TM_Aurelian_HC_08, 6207);
		dlgTeleportToMarker(TM_Aurelian_HC_09, 6208);
		dlgTeleportToMarker(TM_Aurelian_HC_10, 6209);
	}
	
	function ALK_teleportAurelianIG()
	{
		dlgTeleportToMarker(TM_Aurelian_IG_01, 6200);
		dlgTeleportToMarker(TM_Aurelian_IG_02, 6201);
		dlgTeleportToMarker(TM_Aurelian_IG_03, 6202);
		dlgTeleportToMarker(TM_Aurelian_IG_04, 6203);
		dlgTeleportToMarker(TM_Aurelian_IG_05, 6204);
		dlgTeleportToMarker(TM_Aurelian_IG_06, 6205);
	}
	
	function ALK_teleportHDvsHC()
	{
		dlgTeleportToMarker(TM_Aurelian_HC_01, 6220);
		dlgTeleportToMarker(TM_Aurelian_HC_02, 6221);
		dlgTeleportToMarker(TM_Aurelian_HC_03, 6222);
		dlgTeleportToMarker(TM_Aurelian_HC_04, 6223);
		dlgTeleportToMarker(TM_Aurelian_HC_05, 6224);
		dlgTeleportToMarker(TM_Aurelian_HC_06, 6225);
		dlgTeleportToMarker(TM_Aurelian_01, 1);
		dlgTeleportToMarker(TM_Aurelian_02, 6230);
		dlgTeleportToMarker(TM_Aurelian_03, 6231);
		dlgTeleportToMarker(TM_Aurelian_04, 6232);
		dlgTeleportToMarker(TM_Aurelian_05, 6233);
		dlgTeleportToMarker(TM_Aurelian_06, 6234);
		dlgTeleportToMarker(TM_Aurelian_07, 6235);
	}
	
	function ALK_loremastersCombat()
	{
		setCharacterInvincible(6240, 1);
		setCharacterInvincible(6241, 1);
		setCharacterInvincible(6242, 1);
		setCharacterInvincible(6243, 1);
		dlgSetAnimation(anim_stealth_00, 0.5, 6240);
		dlgSetAnimation(anim_stealth_00, 0.5, 6241);
		dlgSetAnimation(anim_stealth_00, 0.5, 6242);
		dlgSetAnimation(anim_stealth_00, 0.5, 6243);
	}
	
	function ALK_loremastersCombatEnd()
	{
		dlgSetAmbientAnimation(6240);
		dlgSetAmbientAnimation(6241);
		dlgSetAmbientAnimation(6242);
		dlgSetAmbientAnimation(6243);
	}
	
	function ALK_FaelanControl()
	{
		if(isAlive(6205) && aod.ALK_FaelanControl_6205 == 0)
		{
			removeCharFromParty(6205);
			addCharToParty(6205, ALK_Faelan, fighter);
			sayPhrase(6205, "For the glory of House Crassus!");
			sayPhrase(8001, "Got you another one.");
			aod.ALK_FaelanControl_6205 = 1;
			dlgChangeTraining(block, -50, 6205);
			removeEnemyFromParty(6205, ALK_Faelan);
		}
		else if(isAlive(6202) && aod.ALK_FaelanControl_6202 == 0)
		{
			removeCharFromParty(6202);
			addCharToParty(6202, ALK_Faelan, fighter);
			sayPhrase(6202, "For the glory of House Crassus!");
			sayPhrase(8001, "Got you another one.");
			aod.ALK_FaelanControl_6202 = 1;
			dlgChangeTraining(block, -50, 6202);
			removeEnemyFromParty(6202, ALK_Faelan);
		}
		else if(isAlive(6201) && aod.ALK_FaelanControl_6201 == 0)
		{
			removeCharFromParty(6201);
			addCharToParty(6201, ALK_Faelan, fighter);
			sayPhrase(6201, "For the glory of House Crassus!");
			sayPhrase(8001, "Got you another one.");
			aod.ALK_FaelanControl_6201 = 1;
			dlgChangeTraining(block, -50, 6201);
			removeEnemyFromParty(6201, ALK_Faelan);
		}
		else if(isAlive(6200) && aod.ALK_FaelanControl_6200 == 0)
		{
			removeCharFromParty(6200);
			addCharToParty(6200, ALK_Faelan, fighter);
			sayPhrase(6200, "For the glory of House Crassus!");
			sayPhrase(8001, "Got you another one.");
			aod.ALK_FaelanControl_6200 = 1;
			dlgChangeTraining(block, -50, 6200);
			removeEnemyFromParty(6200, ALK_Faelan);
		}
	}
	
	function ALK_checkEnemiesAlive()
	{
		if(isAlive(6205) && aod.ALK_FaelanControl_6205 == 0)
			aod.noEnemies = 0;
		else
			aod.noEnemies = 1;
		
		if(isAlive(6204) && aod.ALK_FaelanControl_6204 == 0)
			aod.noEnemies = 0;
		else
			aod.noEnemies = 1;
		
		if(isAlive(6203) && aod.ALK_FaelanControl_6203 == 0)
			aod.noEnemies = 0;
		else
			aod.noEnemies = 1;
		
		if(isAlive(6202) && aod.ALK_FaelanControl_6202 == 0)
			aod.noEnemies = 0;
		else
			aod.noEnemies = 1;
		
		if(isAlive(6201) && aod.ALK_FaelanControl_6201 == 0)
			aod.noEnemies = 0;
		else
			aod.noEnemies = 1;
		
		if(isAlive(6200) && aod.ALK_FaelanControl_6200 == 0)
			aod.noEnemies = 0;
		else
			aod.noEnemies = 1;
	}
	
	function ALK_FaelanKillSurvivors()
	{
		if(isAlive(6205))
			killRandomDeathPosition(6205);
		
		if(isAlive(6204))
			killRandomDeathPosition(6204);
		
		if(isAlive(6203))
			killRandomDeathPosition(6203);
		
		if(isAlive(6202))
			killRandomDeathPosition(6202);
		
		if(isAlive(6201))
			killRandomDeathPosition(6201);
		
		if(isAlive(6200))
			killRandomDeathPosition(6200);
	}

	function char6205::onDeath()
	{
		if(aod.fight_alk_HC && aod.ALK_FaelanControl_6205)
			ALK_FaelanControl();
	}

	function char6204::onDeath()
	{
		if(aod.fight_alk_HC && aod.ALK_FaelanControl_6204)
			ALK_FaelanControl();
	}

	function char6203::onDeath()
	{
		if(aod.fight_alk_HC && aod.ALK_FaelanControl_6203)
			ALK_FaelanControl();
	}

	function char6202::onDeath()
	{
		if(aod.fight_alk_HC && aod.ALK_FaelanControl_6202)
			ALK_FaelanControl();
	}

	function char6201::onDeath()
	{
		if(aod.fight_alk_HC && aod.ALK_FaelanControl_6201)
			ALK_FaelanControl();
	}
	
	function ALK_ExitGanezzar()
	{
		if(aod.quest_ig8_introGanezzar)
		{
			BlackOut.command = "switchMission(\"Quest_IG8_01.mis\");";
			startBlackOut();
		}
		else
		{
			BlackOut.command = "switchMission(\"Ganezzar.mis\");";
			startBlackOut();
		}
	}
	
	function alk_startDlg()
	{
		if(aod.alk_meruExpedition_intro)
		{
			sd(ALK_Intro_01);
			aod.alk_meruExpedition_intro = false;
			aod.alk_meruExpedition_arrived = true;
		}
	}
	
	function VCO_ALK_TowerEntrance()
	{
		if(aod.alk_HD2 == 3 || aod.alk_HD2 == 4 || aod.alk_MS == 1 || aod.alk_MG8 == 1 || aod.alk_MG8 == 2)
			sayPhrase(6241, "You are not allowed to go down there.");
		else
		{
			BlackSplash.command = "";
			BlackOut.command = "sd(ALK_Complex_Intro_01); startBlackSplash();";
			startBlackOut();
		}
	}
	
	function onLeaveLocation()
	{
		globalOnLeaveLocation();
		
		if(aod.alk_IG7_insideComplex == 0)
			aod.alk_nightTime = 0;
	}
	
	function mapScreenButtonScripts()
	{
		if(aod.gnz_finished)
			apmsStartMapScreen();
		else if(aod.alk_HC1 == 2)
			MessageBoxOk("Al-Akia Ruins", "Meru is waiting inside.", "", "");
		else if(aod.alk_HD1 == 2)
			MessageBoxOk("Al-Akia Ruins", "You have to blow up the complex before leaving.", "", "");
		else if(aod.alk_HD2 == 3 || aod.alk_MG8 == 1 || aod.alk_MS == 1)
			MessageBoxOk("Al-Akia Ruins", "Wait for the legatus to return. Talk to one of the loremasters in the meantime.", "", "");
		else if(aod.alk_HD2 == 4)
			apmsStartMapScreen();
		else
			MessageBoxYesNo("Al-Akia Ruins", "Return to Ganezzar?", "ALK_ExitGanezzar();", ""); // Should check for variable
	}
	
	function ALK_setDay()
	{
		theSun.color = "0.937255 0.768628 0.415686 1";
		theSun.ambient = "0.996078 0.917647 0.768628 1";
		theSun.brightness = 1.35;
		theSun.castShadows = "1";
		theSun.shadowSoftness = 0.5;
		theSun.apply();
		thelevelinfo.fogColor = "0.57 0.46 0.31 1";
		thelevelinfo.fogDensity = "0.0015";
		thelevelinfo.fogDensityOffset = "8";
		thelevelinfo.apply();
		aod.alk_nightTime = 0;
	}
	
	function ALK_setNight()
	{
		theSun.color = "0.35 0.40 0.57 1";
		theSun.ambient = "0.3 0.3 0.35 1";
		theSun.brightness = 0.25;
		theSun.castShadows = "1";
		theSun.shadowSoftness = 5;
		theSun.apply();
		thelevelinfo.fogColor = "0.32 0.32 0.37 1";
		thelevelinfo.fogDensity = "0.005";
		thelevelinfo.fogDensityOffset = "2";
		thelevelinfo.apply();
		aod.alk_nightTime = 1;
	}
};

useEventPackage(AlAkiaEvents);