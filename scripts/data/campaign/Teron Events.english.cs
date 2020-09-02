package TeronEvents
{
	function onInitLocation()
	{
		aod.global_teron_ag_burned = false;
		aod.global_teron_fort_IG = true;
		aod.pc_traitor = 0;
		aod.pc_trained = 0;
		aod.global_trn_crisisActive = 1;
		
		revealMapLocation("Teron");
		revealMapLocation("TeronPalace");
		revealMapLocation("TeronDoctor");
		revealMapLocation("TeronFeng");
		revealMapLocation("TeronTavern");
		revealMapLocation("TeronGate");
		revealMapLocation("TeronMerchants");
		revealMapLocation("TeronInn");
		revealMapLocation("TeronBarracks");
		revealMapLocation("TeronAssassins");
		revealMapLocation("TeronShanty");
		revealMapLocation("TeronBlacksmith");
		addJournalLocation(Teron);
	}
	
	function onLoadLocation()
	{
		apmsPlayMusic(custom, 13, 1);
		
		if(aod.trn_mapMarkers == 0)
		{
			revealMapLocation("TeronBlacksmith");
			aod.trn_mapMarkers = 1;
		}
		
		if(aod.weather_teron_dayTime && aod.weather_teron_exterior)
			TeronDayTime();
		
		if(aod.weather_teron_dayTime && aod.weather_teron_interior)
			TeronPropInteriorDay();
		
		if(aod.weather_teron_nightTime && aod.weather_teron_exterior)
			TeronNightTime();
		
		if(aod.weather_teron_nightTime && aod.weather_teron_interior)
			TeronPropInteriorNight();
		
		if(aod.global_teron_fort_IG)
		{
			FortBanners_IG.showObjects();
			VCO_misc_01.setActive(1);
			FortBanners_Daratan.hideObjects();
		}
		
		if(aod.global_teron_fort_daratan)
		{
			FortBanners_IG.hideObjects();
			VCO_misc_01.setActive(0);
			FortBanners_Daratan.showObjects();
		}
		
		if(aod.global_teron_ag_burned == false)
			tbd_ag_burned.IsRenderEnabled = false;
		
		if(aod.global_teron_ag_burned)
		{
			tbd_ag_normal.IsRenderEnabled = false;
			tbd_ag_burned.IsRenderEnabled = true;
			setPassability(207, 104, 0, 0);
			tbd_door_assassin_01.setAllMeshesHidden(true);
		}
		
		/*if(aod.quest_kill_cassius_dead)
			dlgDeleteCharacter(1010);*/
		
		if(aod.npc_zenon_dead)
			dlgDeleteCharacter(1090);
		
		if(aod.quest_kill_cassius_alive)
		{
			dlgDeleteCharacter(1000);
			dlgDeleteCharacter(1330);
		}
		
		if(aod.tsq_preacher_finished)
			PreacherNPCs.hideobjects();
	}
	
	function onGameplayStart()
	{		
		if(aod.start_vignette)
		{
			SS_start("vignettes", "vignetteText();");
			setCombatAllowed(false);
			aod.global_teron_vignette = true;
			aod.global_trnVignette_active = true;
			
			switch(aod.professionID)
			{
				case 0: dlgChangeMoney(75); vignette_assassin_start(); addQuest(VignetteAssassin);
				case 1: dlgChangeMoney(150); vignette_thief_start(); addQuest(VignetteThief);
				case 2: dlgChangeMoney(125); vignette_praetor_start(); addQuest(VignettePraetor);
				case 3: dlgChangeMoney(70); vignette_loremaster_start(); addQuest(VignetteLoremaster);
				case 4: dlgChangeMoney(100); vignette_grifter_start(); addQuest(VignetteGrifter);
				case 5: dlgChangeMoney(350); vignette_drifter_start(); addQuest(VignetteDrifter);
				case 6: dlgChangeMoney(100); vignette_mercenary_start(); addQuest(VignetteMercenary);
				case 7: dlgChangeMoney(150); vignette_merchant_start(); addQuest(VignetteMerchant);
				case 8: dlgChangeMoney(500); vignette_veteran_start();
			}
			
			if(aod.block >= aod.dodge)
			{
				if(aod.professionID != 2 && aod.professionID != 7)
					dlgAddItem(1700);
			}
			else if(aod.professionID == 2 || aod.professionID == 7)
				dlgRemoveItem(1700, 1);
			
			aod.start_vignette = false;
		}
		
		if(aod.global_teron_thieves_destroyed)
		{
			tgd_tg_door6.close();
			tgd_tg_door6.lock();
			dlgDeleteCharacter(1105);
			dlgDeleteCharacter(1140);
		}
		
		setCombatAllowed(false);
		
		//*************** Party Settings ****
		//***********************************
		
		if(aod.gameplay_questAG3_fight == 0 && aod.quest_hd2_carrinasFailure == 0 && aod.quest_ag2_final_fight == 0 && aod.quest_ag2_betrayal_combat == 0)
		{
			addParty(TeronAssassins, 0);
			addCharToParty(1030, "TeronAssassins", "fighter");
			addCharToParty(1040, "TeronAssassins", "fighter");
			addCharToParty(1050, "TeronAssassins", "fighter");
			addCharToParty(1020, "TeronAssassins", "fighter");
			addCharToParty(1210, "TeronAssassins", "fighter");
			
			addParty(IgGuards, 0);
			addCharToParty(1120, "IgGuards", "fighter");
			addCharToParty(1130, "IgGuards", "fighter");
			addCharToParty(1150, "IgGuards", "fighter");
			addCharToParty(1610, "IgGuards", "fighter");
			addCharToParty(1340, "IgGuards", "fighter");
			addCharToParty(1341, "IgGuards", "fighter");
			addCharToParty(1342, "IgGuards", "fighter");
			addCharToParty(1813, "IgGuards", "fighter");
			addCharToParty(7000, "IgGuards", "fighter");
			addCharToParty(7001, "IgGuards", "fighter");
			addCharToParty(7010, "IgGuards", "fighter");
			addCharToParty(7011, "IgGuards", "fighter");
		}
		
		addParty(TeronGang01, 0);
		addCharToParty(3001, "TeronGang01", "fighter");
		addCharToParty(3002, "TeronGang01", "fighter");
		addCharToParty(3003, "TeronGang01", "fighter");
		addCharToParty(3004, "TeronGang01", "fighter");
		
		addParty(MgGuards, 0);
		addCharToParty(1570, "MgGuards", "fighter");
		addCharToParty(1571, "MgGuards", "fighter");
		
		addParty(TowerGuards, 0);
		addCharToParty(1530, "TowerGuards", "fighter");
		addCharToParty(1531, "TowerGuards", "fighter");
		addCharToParty(1533, "TowerGuards", "fighter");
		addCharToParty(1534, "TowerGuards", "fighter");
		addCharToParty(1535, "TowerGuards", "fighter");
		addCharToParty(1536, "TowerGuards", "fighter");
		
		addParty(TSQCellarSquatters, 0);
		addCharToParty(2080, TSQCellarSquatters, fighter);
		addCharToParty(2081, TSQCellarSquatters, fighter);
		addCharToParty(2082, TSQCellarSquatters, fighter);
		addCharToParty(2083, TSQCellarSquatters, fighter);
		
		addParty(TeronInnMerchant, 0);
		addCharToParty(7505, TeronInnMerchant, fighter);
		addCharToParty(7510, TeronInnMerchant, fighter);
		
		dlgSetAnimation(anim_sit_chair_00_00, 0, 2110);
		
		if(aod.gameplay_aemolasShop && aod.npc_aemolas_dead == false)
		{
			AemolasShop.showObjects();
			setGroupPassability(120, 88, 124, 88, 0, 0);
			setPassability(118, 88, 0, 0);
		}
		
		if(aod.npc_aemolas_dead)
		{
			AemolasShop.hideObjects();
			setGroupPassability(120, 88, 124, 88, 0, 1);
			setPassability(118, 88, 0, 1);
			
			if(isAlive(2070))
				dlgDeleteCharacter(2070);
		}
		
		if(aod.quest_mg3_tavern)
		{
			addParty(MerchantGuardsTavern, 0);
			addCharToParty(1570, "MerchantGuardsTavern", "fighter");
			addCharToParty(1571, "MerchantGuardsTavern", "fighter");
			apmsStartDialogue(quest_mg3_03); 
		}
		
		if(aod.global_teron_thieves_left == false)
		{
			addParty(Teron_Thieves, 0);
			addCharToParty(1100, "Teron_Thieves", "fighter");
			addCharToParty(1105, "Teron_Thieves", "fighter");
			addCharToParty(1110, "Teron_Thieves", "fighter");
			addCharToParty(1300, "Teron_Thieves", "fighter");
			addCharToParty(1290, "Teron_Thieves", "fighter");
		}
		
		if(aod.quest_teronRaider_reportToDellar)
		{
			apmsStartDialogue(TBC_DellarReport);
			aod.quest_teronRaider_reportToDellar = false;
		}
		
		if(aod.quest_teronMine_reportToDellar)
		{
			apmsStartDialogue(Teron_Mine_Ending);
			aod.quest_teronMine_reportToDellar = false;
		}
		
		if(aod.TRN_fromTowerCellar)
		{
			aod.TRN_fromTowerCellar = 0;
			dlgTeleportToMarker(TM_TowerCellarExit);
			
			if(aod.tsq_cellar_status == 2)
				sd(TSQ_Cellar_Bums);
		}
	}
	
	function onStartCombat()
	{
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
		dlgSetAnimation(anim_sit_chair_00_00, 0, 2110);
		
		apmsPlayMusic(custom, 13, 1);
		
		if(isalive())
		{
			if(PG_HelpText_02.isvisible())
				PG_HelpText_02.setVisible(false);
			
			if(aod.achievements_inFirstFight)
				aod.achievements_inFirstFight = false;
			
			if(aod.quest_ag1_combat_01)
			{
				aod.quest_ag1_killed_one_spy = true;
				rwd_fight(AG1_01);
				BlackSplash.command = "";
				BlackOut.command = "apmsStartDialogue(quest_AG1); startBlackSplash();";
				startBlackOut();
			}
			
			if(aod.quest_ag1_combat_02)
			{
				aod.quest_ag1_combat_02 = false;
				rwd_fight(AG1_02);
				aod.quest_ag1_search_report = true;
				VCO_AG1_01.setActive(1);
				VCO_AG1_02.setActive(1);
				VCO_AG1_03.setActive(1);
				VCO_AG1_04.setActive(1);
				VCO_AG1_05.setActive(1);
				BlackSplash.command = "";
				BlackOut.command = "apmsStartDialogue(quest_AG1); startBlackSplash();";
				startBlackOut();
			}
			
			if(aod.TPTA_slaveFight)
			{
				BlackOut.command = "apmsStartDialogue(teron_palace_TA);";
				startBlackOut();
			}
			
			if(aod.TPTA_barrackFight)
			{
				BlackOut.command = "apmsStartDialogue(teron_palace_TA);";
				startBlackOut();
			}
			
			if(aod.TPTA_flaviusFight)
			{
				rwd_fight(TRN_TPTA_04);
				BlackOut.command = "apmsStartDialogue(teron_palace_TA);";
				startBlackOut();
			}
			
			if(aod.TPTA_towerFight)
			{
				BlackOut.command = "apmsStartDialogue(teron_palace_TA);";
				startBlackOut();
			}
			
			if(aod.TPTA_guardFight)
			{
				rwd_fight(TRN_TPTA_05);
				BlackOut.command = "apmsStartDialogue(teron_palace_TA);";
				startBlackOut();
			}
			
			/*if(aod.quest_ig3_killed_antidas && aod.quest_ig3_aureliansFight == 0)
			{
				BlackOut.command = "apmsStartDialogue(Quest_IG3);";
				startBlackOut();
			}*/
			
			if(aod.fight_ig3_palace)
			{
				aod.fight_ig3_palace = 0;
				BlackSplash.command = "";
				BlackOut.command = "apmsStartDialogue(Quest_IG3); startBlackSplash();";
				startBlackOut();
			}
			
			if(aod.quest_ig2_back)
			{
				BlackOut.command = "apmsStartDialogue(Quest_IG2);";
				startBlackOut();
			}
			
			if(aod.quest_goblet_fight)
			{
				BlackOut.command = "apmsLootItemlist(goblet_fight);";
				startBlackOut();
			}
			
			if(aod.quest_banditCamp_fightEsbenus)
			{
				BlackOut.command = "apmsLootItemlist(EsbenusMine);";
				startBlackOut();
			}
			
			if(aod.quest_mg2_carrinas_fight)
			{
				BlackSplash.command = "";
				BlackOut.command = "apmsStartDialogue(quest_MG2_02); startBlackSplash();";
				startBlackOut();
			}
			
			if(aod.quest_mg3_inAmbush)
			{
				BlackSplash.command = "";
				BlackOut.command = "apmsStartDialogue(quest_MG3_04); startBlackSplash();";
				startBlackOut();
			}
			
			if(aod.quest_tg2_fightStarted)
			{
				aod.quest_tg2_fightStarted = false;
				aod.quest_tg2_foughtMercs = true;
				BlackSplash.command = "";
				BlackOut.command = "apmsStartDialogue(quest_TG2_02); startBlackSplash();";
				startBlackOut();
			}
			
			if(aod.quest_ag2_final_fight)
			{
				BlackSplash.command = "";
				BlackOut.command = "apmsStartDialogue(Quest_AG2); useCameraBookmark(quest_ag2_10); if(isalive(1050)) { dlgTeleportTo(75, 144, 0, E, 1050); } if(isalive(1210)) { dlgTeleportTo(75, 147, 0, E, 1210); } dlgTeleportTo(77, 146, 0, S, 1020); dlgTeleportTo(77, 144, 0, N, 1030); dlgTeleportTo(75, 145, 0, E, 1040); dlgTeleportTo(75, 146, 0, E); startBlackSplash();";
				startBlackOut();
			}
			
			if(aod.quest_ag2_betrayal_combat)
			{
				BlackSplash.command = "";
				BlackOut.command = "apmsStartDialogue(Quest_AG2); startBlackSplash();";
				startBlackOut();
			}
			
			if(aod.quest_mg3_fightMG)
			{
				guardcheckpoint03();
				rwd_fight(MG3_02);
				aod.quest_mg3_fightMG = 0;
			}
			
			if(aod.quest_ag3_final_fight)
			{
				BlackOut.command = "apmsStartDialogue(quest_AG3);";
				startBlackOut();
			}
			
			if(aod.quest_hd2_GangCombat)
			{
				if(isAlive(1940))
					sayPhrase(1940, "Your work here is done, <charname>. Go see Cado.");
				else if(isAlive(1941))
					sayPhrase(1941, "Your work here is done, <charname>. Go see Cado.");
				else
					narratephrase("Your work here is done. You should go see Cado.");
				
				aod.quest_hd2_GangCombat = false;
				aod.quest_hd2a_phase3 = true;
			}
			
			if(aod.quest_hd2_carrinasFailure == 1)
			{
				BlackSplash.command = "";
				BlackOut.command = "apmsStartDialogue(Quest_HD2_02); startBlackSplash();";
				startBlackOut();
			}
			
			if(aod.fight_hd2_decius)
			{
				aod.fight_hd2_decius = false;
				rwd_fight(HD2_02);
			}
			
			if(aod.global_teron_foughtCheckpointGuards)
			{
				BlackSplash.command = "";
				BlackOut.command = "apmsStartDialogue(Teron_Guards_01); startBlackSplash();";
				startBlackOut();
			}
			
			if(aod.fight_vignette_assassin)
			{
				rwd_fight(Vignette_Assassin); // Fight SP
				aod.fight_vignette_assassin = false;
				VCO_vignette_01.setActive(1);
				VCO_vignette_02.setActive(1);
			}
			
			if(aod.fight_vignette_mercenary)
			{
				rwd_fight(Vignette_Mercenary); // Fight SP
				aod.fight_vignette_mercenary = false;
				VCO_vignette_01.setActive(1);
				VCO_vignette_02.setActive(1);
			}
			
			if(aod.fight_vignette_thief)
			{
				rwd_fight(Vignette_Thief); // Fight SP
				aod.fight_vignette_thief = false;
				VCO_vignette_01.setActive(1);
				VCO_vignette_02.setActive(1);
			}
			
			if(aod.fight_livia_house)
			{
				aod.fight_livia_house = 0;
				rwd_fight(Teron_Livia);
				rwd_quest(TRN_Pickpocket_01);
				tgd_h3_door1.unlock();
			}
			
			if(aod.gameplay_vardanis_fight == 1)
			{
				aod.gameplay_vardanis_fight = 0;
				
				if(isAlive(1185))
				{
					assignDialogue(vardanis_01, 1185);
					sayPhrase(1185, "生き延びたな！");
					rwd_fight(Vignette_Vardanis); // Fight SP
				}
				
				if(isAlive(1185) == 0)
				{
					narratePhrase("ヴァルダニスはあの金を持っているはずだ。彼が行く先では必要ないだろう。");
					setObjectRenderState(EXIT_VardanisFight, 1);
					rwd_fight(Vignette_Vardanis); // Fight SP
				}
			}
			
			if(aod.gameplay_vardanis_fight == 2)
			{
				aod.gameplay_vardanis_fight = 0;
				rwd_fight(Vignette_Vardanis); // Fight SP
				narratePhrase("ヴァルダニスはあの金を持っているはずだ。彼が行く先では必要ないだろう。");
				setObjectRenderState(EXIT_VardanisFight, 1);
			}
			
			if(aod.fight_cassius_01)
			{
				aod.fight_cassius_01 = false;
				rwd_fight(Cassius_01);
				rwd_reputation(Cassius_05);
				VCO_CassiusExit.setActive(1);
			}
			
			if(aod.fight_rhaskos_01)
			{
				aod.fight_rhaskos_01 = false;
				rwd_fight(Rhaskos_01);
				VCO_RhaskosStash_01.setActive(true);
				VCO_RhaskosStash_02.setActive(true);
			}
			
			if(aod.quest_ig1_fight)
			{
				rwd_fight(IG1_01); // Fight SP
				
				if(isAlive(1514) || isAlive(1515))
				{
					BlackSplash.command = "";
					BlackOut.command = "apmsStartDialogue(Quest_IG1); startBlackSplash();";
					startBlackOut();
				}
				
				if(isDead(1514) && isDead(1515))
				{
					aod.quest_ig1_loot = true;
					aod.quest_ig1_fight = false;
				}
				
			}
			
			if(aod.quest_ig1_recruits)
			{
				rwd_fight(IG1_02); // Fight SP
				BlackSplash.command = "";
				BlackOut.command = "apmsStartDialogue(quest_IG1); startBlackSplash();";
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
	
	function onLootScreenClose()
	{
		if(aod.quest_goblet_fight)
			apmsStartDialogue(quest_teron_goblet);
		
		if(aod.quest_ag2_room)
			apmsStartDialogue(Quest_AG2);
	}
	
	function TRN_daratanFort()
	{
		aod.global_teron_fort_daratan = 1;
		FortBanners_IG.hideObjects();
		VCO_misc_01.setActive(0);
		FortBanners_Daratan.showObjects();
		aod.trn_fort_closed = 1;
		tbd_door_barracks_01.lock();
		dlgCreateCharacter("ダラタンの衛兵", 1830, 1830, 217, 57, 0, W);
		dlgCreateCharacter("ダラタンの衛兵", 1830, 1831, 217, 54, 0, W);
		dlgCreateCharacter("ダラタンの衛兵", 1845, 1845, 215, 61, 1, W);
		dlgCreateCharacter("ダラタンの衛兵", 1845, 1846, 215, 50, 1, W);
		dlgCreateCharacter("ダラタンの衛兵", 1840, 1840, 201, 63, 1, SW);
		dlgCreateCharacter("ダラタンの衛兵", 1840, 1841, 202, 47, 1, NW);
		/*dlgDeleteCharacter(1020);
		dlgDeleteCharacter(1030);
		dlgDeleteCharacter(1040);
		dlgDeleteCharacter(1050); // AG Characters
		dlgDeleteCharacter(1210);*/
		dlgDeleteCharacter(1340);
		dlgDeleteCharacter(1341);
		dlgDeleteCharacter(7011);
		dlgDeleteCharacter(7010);	
		dlgDeleteCharacter(7001);
		dlgDeleteCharacter(7000);
		dlgDeleteCharacter(1800);
		dlgDeleteCharacter(1801);
		dlgDeleteCharacter(1802);
		dlgDeleteCharacter(1803);
		dlgDeleteCharacter(1804);
		dlgDeleteCharacter(1805);
		dlgDeleteCharacter(1806);
		dlgDeleteCharacter(1807);
		dlgDeleteCharacter(1808);
		dlgDeleteCharacter(1809);
		dlgDeleteCharacter(1810);
		dlgDeleteCharacter(1811);
		dlgDeleteCharacter(1812);
		dlgDeleteCharacter(1610);
		dlgDeleteCharacter(1611);
		dlgDeleteCharacter(1120);
		dlgDeleteCharacter(1130);
		dlgDeleteCharacter(1342);
		dlgDeleteCharacter(1813);
	}
	
	function TRN_daratanFort_IGwiped()
	{
		aod.global_teron_fort_daratan = 1;
		FortBanners_IG.hideObjects();
		VCO_misc_01.setActive(0);
		FortBanners_Daratan.showObjects();
		aod.trn_fort_closed = 1;
		tbd_door_barracks_01.lock();
		dlgCreateCharacter("ダラタンの衛兵", 1835, 1835, 217, 57, 0, W);
		dlgDeleteCharacter(1340);
		dlgDeleteCharacter(1341);
		dlgDeleteCharacter(7011);
		dlgDeleteCharacter(7010);
		dlgDeleteCharacter(7001);
		dlgDeleteCharacter(7000);
		dlgDeleteCharacter(1800);
		dlgDeleteCharacter(1801);
		dlgDeleteCharacter(1802);
		dlgDeleteCharacter(1803);
		dlgDeleteCharacter(1804);
		dlgDeleteCharacter(1805);
		dlgDeleteCharacter(1806);
		dlgDeleteCharacter(1807);
		dlgDeleteCharacter(1808);
		dlgDeleteCharacter(1809);
		dlgDeleteCharacter(1810);
		dlgDeleteCharacter(1811);
		dlgDeleteCharacter(1812);
		dlgDeleteCharacter(1610);
		dlgDeleteCharacter(1611);
		dlgDeleteCharacter(1120);
		dlgDeleteCharacter(1130);
		dlgDeleteCharacter(1342);
		dlgDeleteCharacter(1813);
	}
	
	function TRN_IG3_Door()
	{
		BlackSplash.command = "";
		BlackOut.command = "apmsStartDialogue(Quest_IG3_PostPalace); startBlackSplash();";
		startBlackOut();
	}
	
	function VCO_FengHatch()
	{
		if(VCO_FengHatch.getCursorTextID() == 5)
		{
			BlackSplash.command = "";
			BlackOut.command = "dlgTeleportToMarker(TM_FengStair_02); narratePhrase(\"You enter Feng's house.\"); startBlackSplash();";
			startBlackOut();
		}
		else if(aod.lockpick >= 3)
		{
			BlackSplash.command = "";
			BlackOut.command = "dlgTeleportToMarker(TM_FengStair_01); narratePhrase(\"[lockpick - success] You succesfully unlock the hatch.\"); rwd_civil(lockpick); VCO_FengHatch.setCursor(\"StealCursor\"); VCO_FengHatch.setCursorText(5); startBlackSplash();";
			startBlackOut();
		}
		else if(aod.lockpick < 3)
		{
			BlackSplash.command = "";
			BlackOut.command = "dlgTeleportToMarker(TM_FengStair_01); narratePhrase(\"[lockpick - failure] You failed to unlock the hatch.\"); startBlackSplash();";
			startBlackOut();
		}
	}
	
	function VCO_FengBoxes()
	{
		if(aod.per < 8)
			narratePhrase("Feng's personal archive - boxes with scrolls.<nlo>There doesn't appear to be any filing system,<nlo>so Feng is probably the only one who can find anything in there.<nlo>You browse through the scrolls but find nothing of interest.");
		else if(aod.exploration_fengBoxes)
			narratePhrase("Feng's personal archive - boxes with scrolls.<nlo>There doesn't appear to be any filing system,<nlo>so Feng is probably the only one who can find anything in there.<nlo>You browse through the scrolls but find nothing of interest.");
		else if(aod.per >= 8)
		{
			narratePhrase("Feng's personal archive - boxes with scrolls.<nlo>There doesn't appear to be any filing system,<nlo>so Feng is probably the only one who can find anything in there.<nlo>You browse through the scrolls and manage to spot a very informative and illustrated treatise on locks.<nlo>Pictures are definitely worth a thousand words.");
			aod.exploration_fengBoxes = true;
			increaseSkillsLockpick(10);
		}
	}
	
	function VCO_vignetteChest()
	{
		if(isInCombat() == false)
		{
			if(aod.vignette_chestLooted)
				narratePhrase("君は既にチェストの中にあった貴重品を全て持っている…。");
			else if(aod.vignette_mercenary_chestEmpty)
				narratePhrase("あの盗賊はチェストの中の貴重品を全て持ち去った…。");
			else if(aod.vignette_drifter_chestEmpty)
				narratePhrase("誰かがチェストの中の貴重品を全て持ち去った…。");
			else
			{
				narratePhrase("君はチェストの中の貴重品を全て持って行った。");
				dlgAddItemlist(vignette_chest_complete);
				aod.vignette_chestLooted = true;
			}
		}
	}
	
	function VCO_ThesalosInfiltration()
	{
		if(aod.sneak >= 4)
			startFadeTeleport(TM_SneakThesalos_1);
		else
			TRG_sneakFailure(9, 4);
	}
};

useEventPackage(TeronEvents);