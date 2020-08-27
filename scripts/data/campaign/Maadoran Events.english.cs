package MaadoranEvents
{
	function onInitLocation()
	{
		revealMapLocation("Maadoran");
		revealMapLocation("MaadoranGate");
		revealMapLocation("MaadoranArena");
		revealMapLocation("MaadoranFort");
		
		addJournalLocation(MDN);
		addQuest("Arena");
		setAchievement("ACH_MAADORAN");
		aod.global_mdn_crisisActive = 1;
	}
	
	function onLoadLocation()
	{
		if(aod.npc_kemnebi_dead)
			dlgDeleteCharacter(4750);
		
		if(aod.npc_cyrus_deleteHim)
		{
			dlgDeleteCharacter(4620);
			aod.npc_cyrus_deleteHim = false;
		}
		
		if((isAlive(4600) && aod.npc_darista_dead) || aod.npc_gaelius_dead)
		{
			dlgDeleteCharacter(4600);
			dlgDeleteCharacter(4615);
			DOOR_AG_01.close();
			DOOR_AG_01.lock();
		}
		
		if(aod.npc_gaelius_dead)
		{
			if(isAlive(4100))
				dlgDeleteCharacter(4100);
			
			if(isAlive(4150) == 0)
				createByCharMarker("CM_Serenas");
			
			dlgTeleportToMarker(TM_AurelianThrone, 4150);
			dlgSetAnimation(anim_sit_chair_00_00, 0, 4150);
		}
		
		if(aod.npc_livia_maadoran == 1)
		{
			createByCharMarker("CM_Livia");
			aod.npc_livia_maadoran = 2;
		}
		
		if(aod.npc_lucius_dead)
			dlgDeleteCharacter(1110);
		
		if(aod.npc_aziz_dead)
			dlgDeleteCharacter(1300);
		
		if(aod.npc_levir_dead == 1)
		{
			dlgDeleteCharacter(4000);
			aod.npc_levir_dead = 2;
		}
		
		// Maadoran Ending Effects
		
		if(aod.global_maadoran_completed)
		{
			if(aod.ending_mdn_town_ordu && aod.npc_gaelius_dead == 0) // Gaelius brought the Ordu
			{
				IGFort.hideObjects();
				VCO_EnterFort.setActive(false);
				VCO_ExitFort.setActive(false);
				dlgDeleteCharacter(4400); // Remove Pavola
				dlgDeleteCharacter(4415); // Remove Vitus
				dlgDeleteCharacter(4450); // Remove IG_Maadoran_Legionary_01_10258
				dlgDeleteCharacter(4451); // Remove IG_Maadoran_Legionary_01_102581
				HAFort.showObjects();
				createByCharMarker("CM_HA_Fort_Guard_01");
				createByCharMarker("CM_HA_Fort_Guard_02");
			}
		}
		
		// Ganezzar Ending Effects
		
		if(aod.global_ganezzar_completed)
		{
			if(aod.ending_gnz_IG_joins_HC)
			{
				IGFort.hideObjects();
				VCO_EnterFort.setActive(false);
				VCO_ExitFort.setActive(false);
				dlgDeleteCharacter(4400); // Remove Pavola
				dlgDeleteCharacter(4415); // Remove Vitus
				dlgDeleteCharacter(4450); // Remove IG_Maadoran_Legionary_01_10258
				dlgDeleteCharacter(4451); // Remove IG_Maadoran_Legionary_01_102581
				HAFort.showObjects();
				createByCharMarker("CM_HA_Fort_Guard_01");
				createByCharMarker("CM_HA_Fort_Guard_02");
			}
			
			if(aod.ending_gnz_IG_joins_HA && aod.npc_paullus_mdn == 0 && aod.npc_paullus_dead == 0)
			{
				createByCharMarker("CM_Paullus");
				aod.npc_paullus_mdn = 1;
			}
			
			if(aod.ending_GNZ_faction_TG == 2)
			{
				assignDialogue(END_NPC_Levir, 4000);
				assignDialogue(END_NPC_Senna, 4210);
			}
			
			if(aod.ending_GNZ_faction_TG == 2)
				assignDialogue(END_NPC_Levir, 4000);
			
			if(aod.gnz_newLeader $= Maseus && aod.npc_maseus_gone == 0)
			{
				dlgDeleteCharacter(4305);
				aod.npc_maseus_gone = 1;
			}
			
			if(aod.ending_GNZ_faction_MG == 1)
			{
				assignDialogue(END_NPC_Strabos, 4300);
				aod.maadoran_notAllowedStrabos = 0;
				aod.maadoran_allowedSeeStrabos = 1;
			}
			
			if(aod.ending_GNZ_faction_MG == 2)
			{
				VCO_EnterPalace.setActive(0);
				setObjectRenderState(Exit_EnterPalace, 0);
				aod.mdn_allowed_palace = 0;
				aod.maadoran_notAllowedStrabos = 1;
			}
			
			//AG Questline
			if(aod.ending_GNZ_faction_AG == 1) // Killed Hamza
			{
				dlgDeleteCharacter(4600);
				dlgDeleteCharacter(4615);
				DOOR_AG_01.close();
				DOOR_AG_01.lock();
			}
			
			if(aod.ending_GNZ_faction_AG == 2) // Killed Meru
				assignDialogue(END_NPC_Darista, 4600);
		}
		
		if(isQuestComplete(TG5) && isAlive(5055))
			dlgDeleteCharacter(5055);
		
		if(aod.mdn_allowed_palace == false)
		{
			VCO_EnterPalace.setActive(0);
			setObjectRenderState(Exit_EnterPalace, 0);
		}
		
		if(aod.mdn_allowed_palace)
		{
			VCO_EnterPalace.setActive(1);
			setObjectRenderState(Exit_EnterPalace, 1);
		}
		
		if(dlgGetRep(thieves) < -20)
		{
			VCO_Gate_SlumsToTemple.setActive(1);
			setObjectRenderState(EXIT_GateSlumsToTemple, 1);
			revealMapLocation("MaadoranTG", 0);
		}
		
		apmsPlayMusic(custom, 5, 1);
	}
	
	function onGameplayStart()
	{
		setTravelingAllowed(true);
		setCombatAllowed(false);
		
		// For patch
		if(aod.mdn_traderGeneral_TM == 0)
		{
			dlgTeleportToMarker(TM_NPC_TraderGeneral, 6103);
			aod.mdn_traderGeneral_TM = 1;
		}
		
		if(isAlive(4210) && aod.npc_senna_created == 0)
			aod.npc_senna_created = 1;
		
		// End Patch
		
		if(aod.global_beenToMaadoran == false)
		{
			if(aod.pc_member_commercium)
				addQuest("MG_ArriveMDN");
			
			if(aod.pc_member_assassins)
				addQuest("AG_ArriveMDN");
			
			if(aod.pc_member_guards)
				addQuest("IG_ArriveMDN");
			
			if(aod.pc_member_daratan)
				aod.mdn_hd_status = 1;
			
			ss_start(mdn_intro, "mdn_startDlg();");
			rwd_location(Maadoran);
			aod.global_beenToMaadoran = true;
			cheatHP();
		}
		
		if(aod.quest_MDN_gateTrader_status == 5) // Create Merc
		{
			aod.quest_MDN_gateTrader_status = 6;
			dlgTeleportToMarker(TM_MainGateMerchant_02, 5236);
			dlgTeleportToMarker(TM_MainGateTrader_11, 5237);
			dlgTeleportToMarker(TM_MainGateTrader_10, 5238);
			createByCharMarker("CM_Trader_Thug_Merc");
			addParty(GateMerchantThugs, 0);
			addCharToParty(5236, GateMerchantThugs, fighter);
			addCharToParty(5237, GateMerchantThugs, fighter);
			addCharToParty(5238, GateMerchantThugs, fighter);
			addCharToParty(5239, GateMerchantThugs, fighter);
		}
		
		if(aod.airship_maadoran == 1)
		{
			dlgTeleportToMarker(TM_Palace_Exterior);
			sd(MDN_Airship_01);
			aod.airship_maadoran = 2;
			aod.mdn_hasAirship = 1;
			setObjectRenderState(OBJ_Airship, 1);
		}
		
		if(aod.quest_tg6_startTemple == 1)
		{
			dlgTeleportToMarker(TM_StartTemple);
			sayPhrase(4000, "Come here, <charname>. I need to talk to you.");
			aod.quest_tg6_startTemple = 2;
			assignDialogue(Quest_TG6_05, 4000);
		}
		
		if(aod.quest_GnzHA1_status == 5) //Meru died in the chamber, report to Gaelius
		{
			dlgTeleportToMarker(TM_DLG_Gaelius_01);
			sd(Quest_HA_MeruDies);
		}
		
		if(aod.quest_AG5_restLorenza)
		{
			dlgTeleportToMarker(TM_Lorenza_TalkPC_01);
			aod.maadoran_allowedIntoLorenza = true;
			aod.npc_lorenza_met = true;
			sd(quest_AG5_03);
		}
		
		if(aod.mdn_theWell_fromInside)
		{
			dlgTeleportToMarker(TM_WellGuy_02);
			aod.mdn_theWell_fromInside = false;
			
			if(aod.npc_wellguy_chamber && aod.mdn_theWell_cut)
				sd(NPC_MDN_WellGuy_01);
		}
		
		if(aod.quest_tg4_backToLevir)
		{
			aod.quest_tg4_backToLevir = false;
			dlgTeleportToMarker(TM_Map_TG);
		}
		
		if(aod.mdn_fromAbyss)
		{
			aod.mdn_fromAbyss = false;
			dlgTeleportToMarker(TM_fromAbyss);
			schedule(100, 0, centerCamera, 180, 40, 20);
		}
		
		if(aod.mdn_fromSkyTower)
		{
			dlgTeleportToMarker(TM_Sky_Tower);
			aod.mdn_fromSkyTower = 0;
			dlgCam(115, 45, 20);
		}
		
		if(aod.mdn_startTM_Scolopendra == 1)
		{
			aod.mdn_startTM_Scolopendra = 0;
			dlgTeleportToMarker(TM_ScolopendraHouse_02);
			dlgcam(315, 45, 10);
		}
		
		if(aod.mdn_fromAG4)
		{
			dlgTeleportToMarker(TM_Map_AG);
			aod.mdn_fromAG4 = false;
		}
		
		if(aod.mdn_fromIG4)
		{
			if(aod.quest_ig4_betrayedIG)
				dlgTeleportToMarker(TM_Map_Palace);
			else
				dlgTeleportToMarker(TM_Map_Fort);
			
			aod.mdn_fromIG4 = false;
		}
		
		if(aod.mdn_fromMG5)
		{
			sd(NPC_Strabos_01);
			aod.mdn_fromMG5 = false;
		}
		
		if(aod.npc_gaelius_fromMG5 == 1)
			sd(NPC_Gaelius_01);
		
		if(aod.npc_darista_reportSerenas)
			sd(NPC_Darista_01);
		
		if(aod.quest_HA_pass_fromPass)
		{
			sd(Quest_HA_Pass_03);
			aod.quest_HA_pass_fromPass = false;
			dlgTeleportToMarker(TM_DLG_Gaelius_01);
		}
		
		if(aod.npc_iola_inn == 1)
		{
			aod.npc_iola_inn = 2;
			createByCharMarker("CM_Iola");
		}
		
		if(aod.global_beenToGanezzar && aod.mdn_abyssClosed == 0)
		{
			aod.mdn_abyssClosed = 1;
			AbyssBarricade.showObjects();
			setObjectRenderState(EXIT_Abyss, 0);
			VCO_Gate_Abyss.setActive(0);
			createByCharMarker("CM_AbyssGuard");
			setgrouppassability(25, 0, 21, 2, 0, 0);
			
			if(aod.npc_mehrab_paid == 0 && aod.npc_mehrab_fight == 0)
			{
				dlgDeleteCharacter(5260);
				dlgDeleteCharacter(5261);
				dlgDeleteCharacter(5262);
				dlgDeleteCharacter(5263);
				dlgDeleteCharacter(5264);
				aod.npc_mehrab_paid = 1; // Improve the variables, just check status >= 1. 1 could be paid, 2 fought.
			}
		}
		
		if(aod.quest_gnz_miltiades >= 1)
		{
			DOOR_Miltiades_01.close();
			DOOR_Miltiades_01.lock();
			dlgDeleteCharacter(2090);
		}
		
		if(aod.quest_BasilTG_status == 5)
			narratePhrase("It's time to check on your good friend Basil.");
		
		//*************** Party Settings ****
		//***********************************
		
		addParty(MehrabBlades, 0);
		addCharToParty(5260, MehrabBlades, fighter);
		addCharToParty(5261, MehrabBlades, fighter);
		addCharToParty(5262, MehrabBlades, fighter);
		addCharToParty(5263, MehrabBlades, fighter);
		addCharToParty(5264, MehrabBlades, fighter);
		
		addParty(HermonGang, 0);
		addCharToParty(5270, HermonGang, fighter);
		addCharToParty(5271, HermonGang, fighter);
		addCharToParty(5272, HermonGang, fighter);
		addCharToParty(5273, HermonGang, fighter);
		
		if(aod.fight_mehrabWithMen == false)
		{
			addCharToParty(5274, HermonGang, fighter);
			addCharToParty(5275, HermonGang, fighter);
		}
	}
	
	function onEndCombat()
	{
		apmsPlayMusic(custom, 5, 1);
		
		if(isalive())
		{
			if(aod.fight_arena)
			{
				enableArenaExit();
				SFX_arenaCrowdCheer_05.play();
				aod.fight_arena = false;
			}
			
			if(aod.fight_kadmos)
			{
				enableArenaExit();
				SFX_arenaCrowdCheer_05.play();
				rwd_fight(Kadmos);
			}
			
			if(aod.npc_miltiades_maadoranNobleFight)
			{
				rwd_fight(MDN_Miltiades_02);
				BlackSplash.command = "";
				BlackOut.command = "apmsStartDialogue(NPC_Miltiades_02); startBlackSplash();";
				startBlackOut();
			}
			
			if(aod.fight_sennaHD3)
			{
				VCO_EscapeSenna_01.setActive(true);
				VCO_EscapeSenna_02.setActive(true);
				CNT_SennaLockbox.setActive(true);
				CNT_SennaTable.setActive(true);
				VCO_SennaChest.setActive(true);
				VCO_EnterSenna.setActive(true);
				Exit_SennaFight_01.IsRenderEnabled = true;
				Exit_SennaFight_02.IsRenderEnabled = true;
				aod.fight_sennaHD3 = false;
				rwd_fight(HD3_02);
			}
			
			if(aod.fight_silvanusHouse)
			{
				VCO_SilvanusVilla_02.setActive(true);
				EXIT_SilvanusVilla_01.IsRenderEnabled = true;
				aod.fight_silvanusHouse = false;
				rwd_fight(MDN_SilvanusHouse);
				rwd_reputation(MDN_theGem_03);
				narratePhrase("You take a key from Silvanus' body.");
				aod.quest_MDN_TheGem_gotKey = true;
			}
			
			if(aod.fight_mdnGateMain_01)
			{
				aod.fight_mdnGateMain_01 = false;
				rwd_fight(MDN_GateMain_01);
				
				if(isAlive(5235))
				{
					BlackSplash.command = "";
					BlackOut.command = "apmsStartDialogue(MDN_GateMain_01); startBlackSplash();";
					startBlackOut();
				}
			}
			
			if(aod.fight_mdnGateMain_02 == 1)
			{
				aod.fight_mdnGateMain_02 = 2;
				rwd_fight(MDN_GateMain_01);
			}
			
			if(aod.fight_ameriusHome_01)
			{
				aod.fight_ameriusHome_01 = false;
				Door_AmeriusHouse.unlock();
			}
			
			if(aod.fight_mdnPreacher_01)
			{
				aod.fight_mdnPreacher_01 = false;
				createByCharMarker("CM_MDN_Preacher_01");
				createByCharMarker("CM_MDN_Preacher_Man_01");
				createByCharMarker("CM_MDN_Preacher_Man_02");
				rwd_fight(MDN_Preacher_01);
				BlackSplash.command = "";
				BlackOut.command = "apmsStartDialogue(MDN_Preacher_01); startBlackSplash();";
				startBlackOut();
			}
			
			if(aod.fight_calvusHome_01)
			{
				aod.fight_calvusHome_01 = false;
				rwd_fight(Calvus_01);
				BlackSplash.command = "";
				BlackOut.command = "apmsStartDialogue(NPC_Calvus_01); startBlackSplash();";
				startBlackOut();
			}
			
			if(aod.fight_slumsAmbush01)
			{
				aod.fight_slumsAmbush01 = false;
				rwd_fight(MDN_Slums_Ambush_01);
			}
			
			if(aod.fight_nerosGuards)
			{
				aod.fight_nerosGuards = false;
				rwd_fight(NerosGuards_01);
			}
			
			if(aod.fight_nerosGuardsManners)
			{
				aod.fight_nerosGuardsManners = false;
				rwd_fight(NerosGuards_02);
			}
			
			if(aod.fight_slumsLeon)
			{
				aod.fight_slumsLeon = false;
				rwd_fight(MDN_Slums_LeonAmbush_01);
			}
			
			if(aod.fight_basilThughs)
			{
				aod.fight_basilThughs = false;
				rwd_fight(BasilThugs_01);
				BlackSplash.command = "";
				BlackOut.command = "sd(NPC_Basil_01); startBlackSplash();";
				startBlackOut();
			}
			
			if(aod.fight_quintusThughs)
			{
				aod.fight_quintusThughs = false;
				rwd_fight(QuintusThugs_01);
				DOOR_Quintus_01.unlock();
				BlackSplash.command = "";
				BlackOut.command = "sd(NPC_Quintus_01); startBlackSplash();";
				startBlackOut();
			}
			
			if(aod.fight_mehrabWithMen)
			{	
				rwd_reputation(MehrabBlades_01);
				BlackSplash.command = "";
				BlackOut.command = "fightMehrabHermonEnd(); startBlackSplash();";
				startBlackOut();
			}
			
			if(aod.fight_IGTrialByCombat)
			{
				aod.fight_IGTrialByCombat = false;
				BlackSplash.command = "";
				BlackOut.command = "apmsStartDialogue(Quest_IGTrial_01); startBlackSplash();";
				startBlackOut();
			}
			
			if(aod.fight_DomHAGuards || aod.fight_hd3_trial)
			{
				BlackSplash.command = "";
				BlackOut.command = "SS_start(\"epicDeath\", \"disconnect();\"); startBlackSplash();";
				startBlackOut();
			}
			
			if(aod.fight_hd3Assassins)
			{
				aod.fight_hd3Assassins = false;
				rwd_fight(HD3_01);
				BlackSplash.command = "";
				BlackOut.command = "sd(Quest_HD3_01); startBlackSplash();";
				startBlackOut();
			}
			
			if(aod.fight_basilTG_tavern)
			{
				rwd_fight(BasilTG_01);
				rwd_reputation(BasilTG_01);
				sdFade(MDN_Quest_BasilTG_Tavern);
			}
			
			if(aod.fight_basilTG_quintus)
			{
				rwd_fight(BasilTG_02);
				rwd_reputation(BasilTG_02);
				sdFade(MDN_Quest_BasilTG_Quintus);
			}
			
			// Return Neutral NPC Animation
			
			if(isAlive(4100))
				dlgSetAnimation(anim_sit_chair_00_00, 0, 4100);
			
			if(isAlive(4150))
				dlgSetAnimation(anim_sit_chair_00_00, 0, 4150);
			
			// For Custom Death Screens
			
			deactivateDeathDesc();
		}
	}
	
	function onLootScreenClose()
	{
		
	}
	
	function VCO_TG_Entrance()
	{
		if(aod.quest_tg6_startTemple == 2)
			narratePhrase("Talk to Levir before you leave.");
		else if(aod.npc_levir_dead || aod.ending_GNZ_faction_TG == 1)
		{
			BlackSplash.command = "";
			BlackOut.command = "sd(MDN_TGTempleGuard_01); dlgTeleportToMarker(TM_TG_Entrance_KICKED); startBlackSplash();";
			startBlackOut();
		}
		else if(aod.pc_member_thieves)
		{
			if(aod.TG_Entrance == 1)
			{
				BlackSplash.command = "";
				BlackOut.command = "dlgTeleportToMarker(TM_TG_Entrance_IN); sfxPlayOnce(AudioButtonStoneClick); startBlackSplash();";
				startBlackOut();
			}
			else if(aod.TG_Entrance == 2)
			{
				BlackSplash.command = "";
				BlackOut.command = "dlgTeleportToMarker(TM_TG_Entrance_OUT); sfxPlayOnce(AudioButtonStoneClick); startBlackSplash();";
				startBlackOut();
			}
		}
		else
		{
			BlackSplash.command = "";
			BlackOut.command = "sd(MDN_TGTempleGuard_01); dlgTeleportToMarker(TM_TG_Entrance_KICKED); startBlackSplash();";
			startBlackOut();
		}
	}
	
	function TRG_MDN_Palace_Throne()
	{
		if(isAlive(4100))
		{
			if(aod.global_ganezzar_completed)
			{
				BlackSplash.command = "";
				BlackOut.command = "sd(END_NPC_Gaelius); dlgTeleportToMarker(TM_DLG_Gaelius_01); startBlackSplash();";
				startBlackOut();
			}
			else if(aod.quest_GnzHA1_status == 2)
			{
				BlackSplash.command = "";
				BlackOut.command = "sd(NPC_Gaelius_02); dlgTeleportToMarker(TM_DLG_Gaelius_01); startBlackSplash();";
				startBlackOut();
			}
			else
			{
				BlackSplash.command = "";
				BlackOut.command = "sd(NPC_Gaelius_01); startBlackSplash();";
				startBlackOut();
			}
		}
		else if(isAlive(4150))
		{
			if(aod.global_ganezzar_completed)
			{
				BlackSplash.command = "";
				BlackOut.command = "sd(END_NPC_Serenas); dlgTeleportToMarker(TM_DLG_Gaelius_01); startBlackSplash();";
				startBlackOut();
			}
			else
			{
				BlackSplash.command = "";
				BlackOut.command = "sd(NPC_Serenas_01); startBlackSplash();";
				startBlackOut();
			}
		}
	}
	
	function VCO_MG_elevator()
	{
		if(aod.maadoran_notAllowedStrabos)
			sayphrase(6000, "Master Strabos does not want to see you anymore.");
		else if(aod.maadoran_allowedSeeStrabos)
		{
			dlgSetAnimation(anim_sit_chair_00_00, 0, 4300);
			BlackSplash.command = "";
			BlackOut.command = "dlgTeleportToMarker(TM_MG_2F); dlgSetZoom(10); startBlackSplash();";
			startBlackOut();
		}
		else if(aod.quest_mg3_sentToStrabos && aod.pc_member_commercium)
		{
			sayphrase(1, "I'm <charname> from Teron.");
			sayphrase(6000, "Alright, go up. Strabos is expecting you.");
			aod.maadoran_allowedSeeStrabos = true;
			aod.quest_mg3_sentToStrabos = false;
		}
		else if(aod.npc_strabos_hiredByMaseus)
		{
			sayphrase(1, "I'm <charname>, Maseus just hired me.");
			sayphrase(6000, "Alright, go up. Strabos is expecting you.");
			aod.maadoran_allowedSeeStrabos = true;
		}
		else if(aod.quest_IG4_goSeeStrabos)
		{
			BlackSplash.command = "";
			BlackOut.command = "sd(quest_ig4_01); startBlackSplash();";
			startBlackOut();
		}
		else if(aod.quest_hd3_talkToStrabos)
		{
			sayphrase(1, "I'm House Daratan's Praetor.");
			sayphrase(6000, "Alright, go up.");
			aod.maadoran_allowedSeeStrabos = true;
		}
		else
			sayphrase(6000, "You are not allowed to go there.");
	}
	
	function TRG_maseusIntro()
	{
		if(aod.npc_maseus_intro == false)
		{
			aod.npc_maseus_intro = true;
			
			if(aod.quest_mg3_sentToStrabos && aod.pc_member_commercium) 
				sayPhrase(4305, "<charname>, right? Strabos is expecting you upstairs.");
			else
				sayPhrase(4305, "Do you need anything?");
		}
	}
	
	function TRG_MainGateEvent_ThugsPlaza()
	{
		if(aod.quest_MDN_gateTrader_status == 2 || aod.quest_MDN_gateTrader_status == 6) // Ignored or didn't follow || Merc is present
		{
			BlackSplash.command = "";
			BlackOut.command = "sd(MDN_GateMain_01); startBlackSplash();";
			startBlackOut();
		}
	}
	
	function TRG_SennasVilla()
	{
		if(aod.npc_senna_created == 0)
		{
			createByCharMarker("CM_Senna");
			createByCharMarker("CM_Senna_Guard_02");
			aod.npc_senna_created = 1;
			
			if(aod.ending_GNZ_faction_TG == 2)
				assignDialogue(END_NPC_Senna, 4210);
		}
	}
	
	function VCO_SennasDoor()
	{
		if(aod.pc_rep_killedSenna)
			narratephrase("Going through the front door is not a good idea.");
		else if(aod.npc_senna_dead)
			sayphrase(4215, "We are mourning the death of our Lord, please leave.");
		else if(aod.npc_senna_atThePalace)
			sayphrase(4215, "Our Lord has moved to the palace.");
		else if(aod.mdn_lordsBlocked)
			sayphrase(4215, "Lord Senna can't see you now, come back later.");
		else if(isQuestAdded(TG_Senna_Temple))
		{
			BlackSplash.command = "";
			BlackOut.command = "dlgTeleportToMarker(TM_Senna_Inside); dlgSetZoom(10); startBlackSplash();";
			startBlackOut();
		}
		else if(aod.maadoran_allowedIntoSenna && aod.quest_hd3_talkToSenna == false)
		{
			BlackSplash.command = "";
			BlackOut.command = "dlgTeleportToMarker(TM_Senna_Inside); dlgSetZoom(10); startBlackSplash();";
			startBlackOut();
		}
		else if(aod.maadoran_allowedIntoSenna && aod.quest_hd3_talkToSenna)
		{
			BlackSplash.command = "";
			BlackOut.command = "dlgTeleportToMarker(TM_SennaGuard_Inside, 4215); dlgTeleportToMarker(TM_Senna_Inside); dlgSetZoom(10); startBlackSplash();";
			startBlackOut();
		}
		else if(aod.quest_HA2_Senna == 1 && aod.maadoran_allowedIntoSenna == false)
		{
			sayphrase(1, "Lord Senna called for me.");
			sayphrase(4215, "Alright, go inside.");
			createByCharMarker("CM_Senna");
			createByCharMarker("CM_Senna_Guard_02");
			aod.maadoran_allowedIntoSenna = true;
			aod.npc_senna_created = 1;
		}
		else if(aod.quest_mg4_active && aod.quest_mg4_talkToSenna && aod.maadoran_allowedIntoSenna == false)
		{
			sayphrase(1, "I'm here on behalf of Master Strabos.");
			sayphrase(4215, "Alright, go inside.");
			createByCharMarker("CM_Senna");
			createByCharMarker("CM_Senna_Guard_02");
			aod.maadoran_allowedIntoSenna = true;
			aod.npc_senna_created = 1;
		}
		else if(aod.quest_hd3_talkToSenna && aod.maadoran_allowedIntoSenna == false)
		{
			sayphrase(1, "I'm House Daratan's Praetor.");
			sayphrase(4215, "Alright, go inside.");
			createByCharMarker("CM_Senna");
			createByCharMarker("CM_Senna_Guard_02");
			createByCharMarker("CM_Senna_Guard_03");
			aod.maadoran_allowedIntoSenna = true;
			aod.npc_senna_created = 1;
		}
		else
			sayphrase(4215, "You have nothing to do here. Move along.");
	}
	
	function LeftIG4()
	{
		aod.quest_IG4_goSeeStrabos = 0;
		remQuest(IG4);
		removePCmember();
		MessageBoxOk("Strabos", "Strabos was left unprotected and killed. You're expelled from the Imperial Guards.", "apmsStartMapScreen(); apmsMapWorld();");
	}
	
	function onLeaveLocation()
	{
		globalOnLeaveLocation();
		
		if(aod.quest_MDN_gateTrader_status == 4) // Thugs Left
			aod.quest_MDN_gateTrader_status = 5; // They bring the merc
		
		if(aod.quest_BasilTG_status == 4) // Killed the TG
			aod.quest_BasilTG_status = 5; // Start Scolopendra
	}
	
	function MDN_ExitGate()
	{
		if(isFunction("mapScreenWorldButtonScripts"))
			mapScreenWorldButtonScripts();
		else
		{
			BlackSplash.command = "";
			BlackOut.command = "apmsStartMapScreen(); apmsMapWorld(); startBlackSplash();";
			startBlackOut();
		}
	}
	
	function TRG_BasilTavern()
	{
		if(aod.charCreation_Basil == false)
		{
			createByCharMarker("CM_Basil");
			aod.charCreation_Basil = true;
		}
		
		if(aod.quest_BasilTG_status == 1)
		{
			aod.quest_BasilTG_status = 2;
			sdFade(MDN_Quest_BasilTG_Tavern);
			createByCharMarker("CM_Basil_TG_Leader");
			createByCharMarker("CM_Basil_TG_Bodyguard_01");
			createByCharMarker("CM_Basil_TG_Bodyguard_02");
			addParty(BasilTG, 0);
			addCharToParty(5150, BasilTG, fighter);
			addCharToParty(5151, BasilTG, fighter);
			addCharToParty(5152, BasilTG, fighter);
		}
		
		if(aod.quest_BasilTG_status == 8)
		{
			sdFade(NPC_Basil_01);
			createByCharMarker("CM_Basil_TG_Leader2");
		}
		
		if(aod.quest_BasilTG_status == 9 || aod.quest_BasilTG_status == 10)
			sdFade(NPC_Basil_01);
	}
	
	function TRG_QuintusWhorehouse()
	{
		if(aod.charCreation_Quintus == false)
		{
			createByCharMarker("CM_Quintus");
			aod.charCreation_Quintus = true;
		}
		
		if(aod.npc_quintus_firstProtection)
		{
			BlackSplash.command = "";
			BlackOut.command = "sd(NPC_Quintus_01); startBlackSplash();";
			startBlackOut();
		}
		
		if(aod.quest_BasilTG_status == 2)
		{
			dlgDeleteDeadCharacters();
			aod.quest_BasilTG_status = 3;
			sdFade(MDN_Quest_BasilTG_Quintus);
			createByCharMarker("CM_Quintus_TG_Thug_01");
			createByCharMarker("CM_Quintus_TG_Thug_02");
			addParty(QuintusTG, 0);
			addCharToParty(5153, QuintusTG, fighter);
			addCharToParty(5154, QuintusTG, fighter);
		}
	}
	
	function map_addTradeDistrictMarkers()
	{
		revealMapLocation("MaadoranMG");
		revealMapLocation("MaadoranAG");
		revealMapLocation("MaadoranBlacksmith");
		revealMapLocation("MaadoranHealer");
		revealMapLocation("MaadoranAbukar");
	}
	
	function map_addPalaceDistrictMarkers()
	{
		revealMapLocation("MaadoranNobles");
		revealMapLocation("MaadoranPalace");
	}
	
	function TRG_district_slums()
	{
		if(aod.rdm_thiefAmbush_mdn != 2)
		{
			if(aod.rdm_thiefAmbush_mdn == 1 || dlgGetRep(thieves) < -20)
			{
				aod.rdm_thiefAmbush_mdn = 2;
				switchMission("RDM_TG_Ambush_MDN.mis");
			}
		}
	}
	
	function TRG_district_trade()
	{
		if(aod.ambush_ag_mdn != 2)
		{
			if(aod.mdn_finished && (dlgGetRep(assassins) < -20 || aod.ambush_ag_mdn == 1))
			{
				aod.ambush_ag_mdn = 2;
				switchMission("RDM_AG_Ambush_MDN.mis");
			}
		}
	}
	
	function TRG_HermonGang()
	{
		if(isInCombat() == false)
		{
			if(dlgGetRep(thieves) < -20 && isAlive(5270))
			{
				addEnemyToParty(1, HermonGang);
				aod.npc_hermon_fight = 1;
			}
			else if(aod.npc_hermon_allowed == 0 && aod.npc_hermon_fight == 0 && aod.npc_hermon_met == 0)
			{
				BlackSplash.command = "";
				BlackOut.command = "sd(NPC_Hermon_01); startBlackSplash();";
				startBlackOut();
			}
		}
	}
	
	function VCO_MDN_SlumsGate()
	{
		if(dlgGetRep(thieves) < -20)
			MessageBoxOk("Forty Thieves Low Reputation", "You're heading for the Forty Thieves' homebase. You'll be hacked to pieces the moment someone spots you.", "");
		else if(aod.mdn_slumsTempleVisited == false)
		{
			createByCharMarker("CM_TG_OutsideGuard_01");
			createByCharMarker("CM_TG_OutsideGuard_02");
			aod.mdn_slumsTempleVisited = true;
			revealMapLocation("MaadoranTG");
			BlackSplash.command = "";
			BlackOut.command = "dlgTeleportToMarker(TM_Gate_SD_to_Temple); schedule(50, 0, centerCamera, 225, 40, 20); sd(NPC_Clemens_01); startBlackSplash();";
			startBlackOut();
		}
		else
		{
			BlackSplash.command = "";
			BlackOut.command = "dlgTeleportToMarker(TM_Gate_SD_to_Temple); schedule(50, 0, centerCamera, 225, 40, 20); startBlackSplash();";
			startBlackOut();
		}
	}
	
	function VCO_ArenaExit()
	{
		if(aod.fight_kadmos)
		{
			BlackSplash.command = "";
			BlackOut.command = "dlgTeleportToMarker(TM_Map_Arena); disableArenaExit(); dlgDeleteDeadCharacters(); dlgCam(45, 45, 10); startBlackSplash();";
			startBlackOut();
			aod.fight_kadmos = 0;
		}
		else
		{
			BlackSplash.command = "";
			BlackOut.command = "sd(Quest_Arena_01); startBlackSplash();";
			startBlackOut();
		}
	}
	
	function mapScreenWorldButtonScripts()
	{
		if(aod.mdn_hd_status == 1)
		{
			MessageBoxOk("Domitius", "You should find Domitius Ulpius before leaving Maadoran.", "");
			aod.worldmapScreenDisabled = 1;
		}
		else if(isQuestAdded(IG4) && isQuestComplete(IG4) == 0 && aod.npc_pavola_reportStrabos == 0)
			MessageBoxYesNo("Strabos", "If you leave the city, Strabos will die tonight. Leave anyway?", "LeftIG4();", "");
		else if((aod.quest_mg6_strabosMagistratus || aod.quest_mg6_sennaShared || aod.quest_mg6_lorenzaShared || aod.quest_MG6_sennaFailure || aod.quest_MG6_serenasFailure || aod.quest_MG6_lorenzaFailure) && aod.quest_mg6_strabosMap == 0 && aod.global_mdn_crisisActive)
		{
			aod.quest_mg6_strabosMap = 1;
			BlackSplash.command = "";
			BlackOut.command = "sd(NPC_Strabos_01); startBlackSplash();";
			startBlackOut();
		}
		else
		{
			apmsStartMapScreen();
			apmsMapWorld();
		}
	}
};

useEventPackage(MaadoranEvents);