package GanezzarEvents
{
	function onInitLocation()
	{
		revealMapLocation("Ganezzar");
		setAchievement("ACH_GNZ");
		addJournalLocation(GNZ);
		
		aod.global_gnz_crisisActive = true;
		setgrouppassability(148, 144, 150, 147, 0, 0);
	}
	
	function onLoadLocation()
	{
		if(aod.npc_hector_dead)
			dlgDeleteCharacter(9010);
		
		if(aod.npc_darganus_dead)
			dlgDeleteCharacter(9014);
		
		aod.map_inGanezzar = 1;
		apmsPlayMusic(custom, 32, 1);
		
		if(isAlive(8000) == 0)
			aod.npc_meru_dead = 1;
		
		if(isAlive(8000) || aod.gnz_newLeader $= Fabianus)
		{
			CrassusBanners.showObjects();
			HACity.hideObjects();
			IGCity.hideObjects();
		}
		else if(aod.gnz_newLeader $= Maseus || aod.gnz_newLeader $= Hagnon)
		{
			CrassusBanners.hideObjects();
			HACity.showObjects();
			IGCity.hideObjects();
		}
		else if(aod.gnz_newLeader $= Centurion)
		{
			CrassusBanners.hideObjects();
			HACity.hideObjects();
			IGCity.showObjects();
		}
	}
	
	function onGameplayStart()
	{
		setTravelingAllowed(true);
		setCombatAllowed(false);
		
		if(aod.global_beenToGanezzar == false)
		{	
			aod.gnz_cityGate_zealots = 1;
			
			if(aod.mdn_destroyed)
			{
				addQuest(MDN_HA_Destroyed_GNZ);
				
				if(aod.gnz_merchant_start)
					aod.gnz_merchant_start = 0;
				
				if(aod.gnz_thief_start)
					aod.gnz_thief_start = 0;
				
				if(aod.gnz_assassin_start)
					aod.gnz_assassin_start = 0;
				
				if(aod.gnz_HA_start)
					aod.gnz_HA_start = 0;
				
				if(aod.gnz_HD_start)
					aod.gnz_HD_start = 0;
			}
			
			if(aod.pc_member_daratan && aod.gnz_underSiege)
				aod.gnz_HD_start = 1;
			
			if(aod.gnz_merchant_start)
				aod.gnz_underSiege = 0;
			
			if(aod.gnz_thief_start)
				aod.gnz_underSiege = 1;
			
			if(aod.gnz_assassin_start)
				aod.gnz_underSiege = 1;
			
			if(aod.gnz_HA_start)
				aod.gnz_underSiege = 1;
			
			if(aod.gnz_HD_start && aod.quest_GnzHD2_status == 0)
				aod.gnz_underSiege = 1;
			
			ss_start(gnz_intro, "gnz_startDlg();");
			rwd_location(Ganezzar);
			aod.global_beenToGanezzar = true;
			cheatHP();
		}
		
		if(aod.gnz_allowedIntoCastle == false)
			CloseCastleGate();
		else
			OpenCastleGate();
		
		if(aod.mdn_destroyed)
			aod.gnz_underSiege = 0;
		
		if(aod.gnz_siegeComing && aod.mdn_destroyed == false && aod.mdn_slumsAttacked == false)
		{
			ss_start(gnz_intro, "gnz_startDlg();");
			aod.gnz_underSiege = 1;
			dlgTeleportToMarker(TM_CastleGate_01);
			
			if(aod.alk_mg8 == 2)
				aod.quest_mg_killFaelan = 1;
		}
		
		if(aod.airship_ganezzar == 1)
		{
			if(isAlive(8000))
				dlgTeleportToMarker(TM_Start_Airship_Meru, 8000);
			else
				dlgTeleportToMarker(TM_Start_Airship_Meru, 9021);
			
			dlgTeleportTo(164, 125, 0, E, 81101);
			dlgTeleportTo(164, 127, 0, E, 81102);
			dlgTeleportToMarker(TM_Start_Airship);
			aod.airship_ganezzar = 2;
			aod.gnz_hasAirship = 1;
			setTravelingAllowed(false);
		}
		
		if(aod.npc_darganus_cross)
		{
			DarganusCross.showObjects();
			setpassability(70,150,0,0);
			setpassability(71,150,0,0);
			setpassability(71,151,0,0);
			aod.npc_darganus_dead = 1;
		}
		
		if(aod.npc_darganus_cross == 0 || aod.gnz_finished)
		{
			DarganusCross.hideObjects();
			setpassability(70,150,0,1);
			setpassability(71,150,0,1);
			setpassability(71,151,0,1);
		}
		
		if(aod.npc_faelan_dead == 1)
		{
			aod.npc_faelan_dead = 2;
			dlgDeleteCharacter(8001); // Remove Faelan
			
			if(isAlive(8000))
			{
				dlgTeleportToMarker(TM_Meru_SideNPC_01, 8040);
				GNZ_createThroneGuards();
			}
		}
		
		if(aod.quest_ig8_introGanezzar)
			ss_start(gnz_intro, "gnz_startDlg();");
		
		if(aod.gnz_startSiegeEnd)
		{
			aod.gnz_startSiegeEnd = false;
			aod.gnz_underSiege = false;
			sd(GNZ_Siege_01);
		}
		
		if(aod.gnz_hasAirship)
			airship.isRenderEnabled = 1;
		
		if(aod.gnz_underSiege)
			gnz_siegeToggle(1);
		
		if(aod.gnz_underSiege == false)
			gnz_siegeToggle(0);
		
		if(aod.gnz_startPosition_castleExterior)
		{
			dlgTeleportToMarker(TM_Start_PalaceExterior);
			aod.gnz_startPosition_castleExterior = false;
			
			if(aod.gnz_map_top == false)
			{
				revealMapLocation("GanezzarTop");
				aod.gnz_map_top = true;
			}
		}
		
		if(aod.gnz_startPosition_topDistrict)
		{
			dlgTeleportToMarker(TM_Map_Castle);
			aod.gnz_startPosition_topDistrict = 0;
			
			if(aod.gnz_map_top == false)
			{
				revealMapLocation("GanezzarTop");
				aod.gnz_map_top = true;
			}
		}
		
		if(aod.gnz_startPosition_TG)
		{
			dlgTeleportToMarker(TM_Start_TG);
			aod.gnz_startPosition_TG = 0;
			dlgCam(135, 45, 10, 1);
			
			if(aod.gnz_map_lowtown == 0)
			{
				revealMapLocation("GanezzarGate");
				revealMapLocation("GanezzarAG");
				revealMapLocation("GanezzarTG");
				aod.gnz_map_lowtown = 1;
			}
		}
		
		if(aod.gnz_startPosition_Gates)
		{
			dlgTeleportToMarker(TM_Map_Gate);
			aod.gnz_startPosition_Gates = 0;
		}
		
		if(aod.gnz_startPosition_Temple)
		{
			dlgTeleportToMarker(TM_Map_MG);
			aod.gnz_startPosition_Temple = 0;
		}
		
		if(aod.gnz_startPosition_Darganus) // After the events in his house.
		{
			dlgTeleportToMarker(TM_Darganus_Outside);
			dlgDeleteCharacter(9014);
			dlgDeleteCharacter(9015);
			dlgDeleteCharacter(9016);
			aod.gnz_startPosition_Darganus = 0;
		}
		
		if(aod.gnz_thievesGuildDiscovered)
			VCO_EnterThievesGuild.setActive(1);
		
		if(aod.gnz_siegeBroken == 1)
			GNZ_Post_SiegeBroken();
		
		if(aod.gnz_cityTaken == 1)
			GNZ_Post_CityTaken();
		
		if(aod.gnz_balzaar == 1)
			GNZ_Post_Balzaar();
		
		if(aod.gnz_meruDies == 1)
			GNZ_Post_MeruDies();
		
		if(aod.global_ganezzar_completed && aod.quest_gnz_miltiades == 0 && aod.npc_miltiades_lord)
		{
			aod.quest_gnz_miltiades = 1;
			
			if(aod.npc_darganus_miltiades == 1)
			{
				dlgAddTextBoxMessage("Visit lord Darganus, see if he has any work for you.");
				aod.quest_gnz_milt_01 = 1;
				addQuest(GNZ_Darganus_03);
			}
			
			if(aod.npc_hector_miltiades == 1)
			{
				dlgAddTextBoxMessage("Visit Hector, see if he has any work for you.");
				addQuest(GNZ_Hector_03);
			}
		}
		
		if(aod.quest_gnz_milt_01 == 5)
		{
			dlgTeleportToMarker(TM_Miltiades_Darganus_04, 9044);
			assignDialogue(GNZ_NPC_Miltiades_02, 9044);
			DOOR_Darganus.unlock();
		}
		
		if(aod.quest_gnz_milt_01 == 6 || aod.quest_gnz_milt_02 == 6)
		{
			dlgTeleportToMarker(TM_Miltiades_Lowtown_01, 9044);
			assignDialogue(GNZ_NPC_Miltiades_02, 9044);
		}
		
		if(aod.quest_gnz_milt_01 == 7)
			dlgDeleteCharacter(9044);
		
		if(aod.global_ganezzar_completed)
		{
			if(VCO_AG9_Guild.Active == 1)
				VCO_AG9_Guild.setActive(0);
			
			if(VCO_EnterThievesGuild.Active == 1)
				VCO_EnterThievesGuild.setActive(0);
			
			dlgDeleteCharacter(8260);
			dlgDeleteCharacter(8261);
			dlgDeleteCharacter(8262);
		}
		
		// TEMP for savegame compatability
		
		if(isAlive(8040) && isAlive(8001))
			dlgTeleportToMarker(TM_Talk_Varro_NPC, 8040);
		
		if(aod.gnz_siegeBroken == 2)
		{
			assignDialogue(END_NPC_Athanasius, 8050); // New dialogue for Athan
			assignDialogue(END_NPC_Varro, 8040); // New dialogue for Varro
		}

	
		// Note: We should make an "AI" that keeps the character sitting, and during a combat that doesn't involve them they shouldn't change their animation.
		
		if(isAlive(9020))
			dlgSetAnimation(anim_sit_chair_00_00, 0, 9020);
		
		if(isAlive(601))
			dlgSetAnimation(anim_sit_ground_00_00, 0, 601);
		
		if(isAlive(9021) && aod.gnz_newLeader $= Fabianus && aod.airship_ganezzar != 2)
			dlgSetAnimation(anim_sit_chair_00_00, 0, 9021);
		
		if(isAlive(8000) && aod.airship_ganezzar != 2)
			dlgSetAnimation(anim_sit_chair_00_00, 0, 8000);
		
		if(isAlive(8031))
			dlgSetAnimation(anim_sit_chair_00_00, 0, 8031);
		
		if(isAlive(8200))
			dlgSetAnimation(anim_sit_chair_00_00, 0, 8200);
		
		if(isAlive(8210))
			dlgSetAnimation(anim_sit_chair_00_00, 0, 8210);
		
		if(isAlive(8050))
			dlgSetAnimation(anim_sit_chair_00_00, 0, 8050);
		
		if(isAlive(8090))
			dlgSetAnimation(anim_sit_chair_00_00, 0, 8090);
		
		if(isAlive(4305))
			dlgSetAnimation(anim_sit_chair_00_00, 0, 4305);
		
		
		//*************** Party Settings ****
		//***********************************
	}
	
	function onEndCombat()
	{
		apmsPlayMusic(custom, 32, 1);
		
		if(isalive())
		{
			if(aod.fight_GNZ_gateZealots == 1)
			{
				rwd_fight(Zealots_01);
				BlackSplash.command = "";
				BlackOut.command = "sd(GNZ_cityGate_zealots); startBlackSplash();";
				startBlackOut();
			}
			
			if(aod.fight_gnz_elias == 1)
			{
				aod.fight_gnz_elias = 0;
				rwd_fight(Elias_01);
				rwd_reputation(GNZ_Elias_02);
				BlackSplash.command = "";
				BlackOut.command = "sd(GSQ_Elias); startBlackSplash();";
				startBlackOut();
			}
			
			if(aod.fight_pancratius == 1)
			{
				rwd_fight(Pancratius_01);
				aod.fight_pancratius = 0;
				DOOR_Pancratius.unlock();
				aod.quest_darganus_02 = 2;
			}
			
			if(aod.fight_gnz_arena >= 1)
			{
				switch(aod.fight_gnz_arena)
				{
					case 1 : rwd_arena(gnz_arena_01);
					case 2 : rwd_arena(gnz_arena_02);
					case 3 : rwd_arena(gnz_arena_03);
					case 4 : rwd_arena(gnz_arena_04);
				}
				
				aod.fight_gnz_arena = 0;
				VCO_ExitArena.setActive(1);
				setObjectRenderState(OBJ_ExitArena, 1);
			}
			
			if(aod.fight_bernieGuards == 1)
			{
				rwd_fight(Bernie_01);
				aod.fight_bernieGuards = 0;
			}
			
			if(aod.fight_gnz_miltiades == 1)
			{
				rwd_fight(GNZ_Miltiades_01);
				aod.fight_gnz_miltiades = 0;
			}
			
			// Return Neutral NPC Animation
			
			if(isAlive(9020))
				dlgSetAnimation(anim_sit_chair_00_00, 0, 9020);
			
			if(isAlive(601))
				dlgSetAnimation(anim_sit_ground_00_00, 0, 601);
			
			if(isAlive(9021) && aod.gnz_newLeader $= Fabianus)
				dlgSetAnimation(anim_sit_chair_00_00, 0, 9021);
			
			if(isAlive(8000))
				dlgSetAnimation(anim_sit_chair_00_00, 0, 8000);
			
			if(isAlive(8031))
				dlgSetAnimation(anim_sit_chair_00_00, 0, 8031);
			
			if(isAlive(8200))
				dlgSetAnimation(anim_sit_chair_00_00, 0, 8200);
			
			if(isAlive(8210))
				dlgSetAnimation(anim_sit_chair_00_00, 0, 8210);
			
			if(isAlive(8050))
				dlgSetAnimation(anim_sit_chair_00_00, 0, 8050);
			
			if(isAlive(8090))
				dlgSetAnimation(anim_sit_chair_00_00, 0, 8090);
			
			if(isAlive(4305))
				dlgSetAnimation(anim_sit_chair_00_00, 0, 4305);
			
			// For Custom Death Screens
			
			deactivateDeathDesc();
		}
	}
	
	function onLootScreenClose()
	{
		
	}
	
	function TRG_GNZ_CastleGate()
	{
		if(aod.gnz_map_castle == false)
		{
			revealMapLocation("GanezzarCastle");
			aod.gnz_map_castle = true;
		}
		
		if(aod.gnz_blockMeru == 1)
			sayPhrase(81102, "You are not welcome here.");
		else if(aod.gnz_allowedIntoCastle == false)
		{
			BlackSplash.command = "";
			BlackOut.command = "sd(GNZ_castleGate_01); dlgTeleportToMarker(TM_CastleGate_01); startBlackSplash();";
			startBlackOut();
		}
	}
	
	function OpenCastleGate()
	{
		CastleGateOBJ.hideObjects();
		setgrouppassability(148, 144, 150, 147, 0, 1);
	}
	
	function CloseCastleGate()
	{
		CastleGateOBJ.showObjects();
		setgrouppassability(148, 144, 150, 147, 0, 0);
	}
	
	function TRG_GNZ_MiddleGate()
	{
		if(aod.gnz_map_middle == false)
		{
			revealMapLocation("GanezzarFort");
			revealMapLocation("GanezzarMG");
			revealMapLocation("GanezzarHealer");
			revealMapLocation("GanezzarBlacksmith");
			revealMapLocation("GanezzarInn");
			aod.gnz_map_middle = true;
		}
	}
	
	function TRG_GNZ_TopGate()
	{
		if(aod.gnz_map_top == false)
		{
			revealMapLocation("GanezzarTop");
			aod.gnz_map_top = true;
		}
		
		TRG_GNZ_MiddleGate();
	}
	
	function TRG_GNZ_CityGate()
	{
		if(aod.gnz_map_lowtown == false)
		{
			revealMapLocation("GanezzarGate");
			revealMapLocation("GanezzarAG");
			revealMapLocation("GanezzarTG");
			aod.gnz_map_lowtown = true;
		}
		
		if(aod.gnz_cityGate_siege == 1)
		{
			BlackSplash.command = "";
			BlackOut.command = "sd(GNZ_cityGate_siege); aod.gnz_cityGate_siege = 2; startBlackSplash();";
			startBlackOut();
		}
		
		if(aod.gnz_cityGate_zealots == 1)
		{
			BlackSplash.command = "";
			BlackOut.command = "sd(GNZ_cityGate_zealots); GNZ_createGateZealots(); dlgTeleportToMarker(TM_cityGate_Zealots); aod.gnz_cityGate_zealots = 2; startBlackSplash();";
			startBlackOut();
		}
	}
	
	function GNZ_createGateZealots()
	{
		createByCharMarker("CM_Gate_Zealot_01");
		createByCharMarker("CM_Gate_Zealot_02");
		createByCharMarker("CM_Gate_Zealot_03");
		createByCharMarker("CM_Gate_Zealot_04");
		createByCharMarker("CM_Gate_Zealot_05");
		addParty(GNZ_gateZealots, 0);
		addCharToParty(8130, GNZ_gateZealots, fighter);
		addCharToParty(8131, GNZ_gateZealots, fighter);
		addCharToParty(8132, GNZ_gateZealots, fighter);
		addCharToParty(8133, GNZ_gateZealots, fighter);
		addCharToParty(8134, GNZ_gateZealots, fighter);
	}
	
	function gnz_deleteGateZealots()
	{
		dlgDeleteCharacter(8130);
		dlgDeleteCharacter(8131);
		dlgDeleteCharacter(8132);
		dlgDeleteCharacter(8133);
		dlgDeleteCharacter(8134);
	}
	
	function gnz_traderCampToggle(%toggle)
	{
		if(%toggle == 1)
		{
			setGroupPassability(144, 40, 142, 47, 0, 0);
			setGroupPassability(138, 41, 140, 42, 0, 0);
			setGroupPassability(138, 44, 140, 44, 0, 0);
			setGroupPassability(144, 38, 144, 39, 0, 0);
			setGroupPassability(145, 46, 145, 47, 0, 0);
			setPassability(141, 45, 0, 0);
			setPassability(146, 40, 0, 0);
			TraderCamp.showObjects();
		}
		else
		{
			setGroupPassability(144, 40, 142, 47, 0, 1);
			setGroupPassability(138, 41, 140, 42, 0, 1);
			setGroupPassability(138, 44, 140, 44, 0, 1);
			setGroupPassability(144, 38, 144, 39, 0, 1);
			setGroupPassability(145, 46, 145, 47, 0, 1);
			setPassability(141, 45, 0, 1);
			setPassability(146, 40, 0, 1);
			TraderCamp.hideObjects();
			dlgDeleteCharacter(8120);
		}
	}
	
	function gnz_siegeCampToggle(%toggle)
	{
		if(%toggle == 1)
		{
			SiegeCamp.showObjects();
			setGroupPassability(113, 55, 116, 52, 0, 0);
			setGroupPassability(133, 49, 134, 52, 0, 0);
			setGroupPassability(133, 55, 134, 58, 0, 0);
			setGroupPassability(137, 56, 136, 52, 0, 0);
			setGroupPassability(148, 49, 151, 50, 0, 0);
			setGroupPassability(149, 35, 152, 36, 0, 0);
			setGroupPassability(156, 35, 159, 36, 0, 0);
			setGroupPassability(152, 33, 156, 32, 0, 0);
		}
		else
		{
			SiegeCamp.hideObjects();
			setGroupPassability(113, 55, 116, 52, 0, 1);
			setGroupPassability(133, 49, 134, 52, 0, 1);
			setGroupPassability(133, 55, 134, 58, 0, 1);
			setGroupPassability(137, 56, 136, 52, 0, 1);
			setGroupPassability(148, 49, 151, 50, 0, 1);
			setGroupPassability(149, 35, 152, 36, 0, 1);
			setGroupPassability(156, 35, 159, 36, 0, 1);
			setGroupPassability(152, 33, 156, 32, 0, 1);
		}
	}
	
	function gnz_siegeToggle(%toggle)
	{
		if(%toggle == 1)
		{
			gnz_traderCampToggle(0);
			gnz_siegeCampToggle(1);
			aod.gnz_underSiege = 1;
			
			if(isAlive(9001) == false)
				createByCharMarker("CM_Woman_Old_Man");
			
			if(isAlive(9002) == false)
				createByCharMarker("CM_Old_Man");
		}
		else
		{
			gnz_traderCampToggle(1);
			gnz_siegeCampToggle(0);
			aod.gnz_underSiege = 0;
			
			if(isAlive(9001))
				dlgDeleteCharacter(9001);
			
			if(isAlive(9002))
				dlgDeleteCharacter(9002);
		}
	}
	
	function VCO_CityGate()
	{
		BlackSplash.command = "";
		BlackOut.command = "sd(GNZ_CityGate_Exit); startBlackSplash();";
		startBlackOut();
	}
	
	function gnz_startDlg()
	{
		if(aod.quest_ig8_introGanezzar)
		{
			sd(Quest_IG8_01);
			aod.quest_ig8_introGanezzar = false;
		}
		
		if(aod.gnz_merchant_start == 1)
		{
			aod.gnz_underSiege = 0;
			aod.gnz_cityGate_zealots = 1;
			aod.jnl_MG_ArriveGNZ = 3;
			aod.gnz_merchant_start = 2;
		}
		
		if(aod.gnz_thief_start)
		{
			sd(GNZ_ArrivalTG);
			aod.gnz_cityGate_zealots = 0;
			aod.gnz_underSiege = 1;
		}
		
		if(aod.gnz_assassin_start)
		{
			sd(GNZ_ArrivalAG);
			aod.gnz_cityGate_zealots = 0;
			aod.gnz_cityGate_siege = 1;
			aod.gnz_cityGate_AG = 1;
			aod.gnz_assassin_findAG = 1;
			aod.gnz_underSiege = 1;
		}
		
		if(aod.gnz_HA_start)
		{
			sd(GNZ_ArrivalHA);
			aod.gnz_cityGate_zealots = 0;
			aod.gnz_cityGate_siege = 1;
			aod.gnz_cityGate_HA = 1;
			aod.quest_GnzHA1_status = 1;
			aod.gnz_underSiege = 1;
		}
		
		if(aod.gnz_HD_start)
		{
			if(aod.quest_GnzHD2_status == 1) 	// No siege, House Aurelian gone.
			{
				aod.gnz_cityGate_zealots = 1;
				aod.gnz_cityGate_siege = 0;
				aod.gnz_cityGate_HD = 0;
				aod.gnz_underSiege = 0;
			}
			else					// Siege is on.
			{
				sd(GNZ_ArrivalHD);
				aod.gnz_cityGate_zealots = 0;
				aod.gnz_cityGate_siege = 1;
				aod.gnz_cityGate_HD = 1;
				aod.quest_GnzHD1_status = 1;
				aod.gnz_underSiege = 1;
			}
		}
	}
	
	function onLeaveLocation()
	{
		globalOnLeaveLocation();
		aod.map_inGanezzar = 0;
		
		if(aod.quest_mg_killFaelan == 4)
			aod.quest_mg_killFaelan = 6;
		
		if(aod.quest_darganus_02 == 7 && aod.gnz_pancratiusRise == 0)
			aod.gnz_pancratiusRise = 1;
	}

	function descriptionsVCO(%desc)
	{
		switch(%desc)
		{
			case 1: narratePhrase("The dirty floor is crowded with straw mattresses,<nlo>children sleeping alongside drunken men and whores.");
			case 2: narratePhrase("The dirtiest brothel you've ever seen. It's a fairly busy place<nlo>that proves once and for all that beggars can't be choosers. ");
			case 3: narratePhrase("The door is barred from the inside. You hear the sounds of<nlo>praying and chanting, interrupted by sobbing and pleading. ");
			case 4: narratePhrase("A maze of tiny 'rooms', separated from each other by makeshift walls.<nlo>Each room is its own world with its own smell: spices to cover the taste of meat going bad,<nlo>incense to cover the smell of unwashed bodies, fried fish from the river,<nlo>bitter herbs boiling in a pot. "); 
			case 5: narratePhrase("A smoke-filled hashish house for those who can afford more than a filthy straw mattress.<nlo>Men with empty eyes look through you before returning to their pipes."); 
			case 6: narratePhrase("\"No room!\" yells a man, throwing a bottle in your direction when you open the door."); 
			case 7: narratePhrase("A sobbing man with bulging, bloodshot eyes. Every now and then he gathers<nlo>enough strength and starts shouting - recanting his words and pleading for mercy.<nlo>The onlookers laugh and encourage him to shout louder."); 
			case 8: narratePhrase("A dangerous heretic once threatening communal order. Not so dangerous now, is he?"); 
			case 9: narratePhrase("Men and women are lying on the floor or sitting against the walls.<nlo>Some are moaning in their sleep, others are praying, probably for a quick death.");
		}
	}
	
	function TRG_AirshipIntro()
	{
		if(aod.airship_ganezzar == 2)
		{
			BlackSplash.command = "";
			BlackOut.command = "apmsStartDialogue(GNZ_Airship); startBlackSplash();";
			startBlackOut();
		}
	}
	
	function TRG_TemplePreacher()
	{
		if(aod.gnz_templePreacher == 0 && aod.global_ganezzar_completed == 0)
		{
			aod.gnz_templePreacher = 1;
			BlackSplash.command = "";
			BlackOut.command = "apmsStartDialogue(GNZ_NPC_preacher_01); startBlackSplash();";
			startBlackOut();
		}
	}
	
	function TRG_GSQ_Elias()
	{
		if(aod.gsq_elias == 0 && aod.global_ganezzar_completed == 0)
		{
			aod.gsq_elias = 1;
			BlackSplash.command = "";
			BlackOut.command = "sd(GSQ_Elias); GNZ_Create_Elias(); dlgTeleportToMarker(TM_GSQ_Elias_01); startBlackSplash();";
			startBlackOut();
		}
	}

	function GNZ_Create_Elias()
	{
		createByCharMarker("CM_Elias"); 
		dlgTeleportToMarker(TM_GSQ_Elias_Zealot_1, 8260);
		dlgTeleportToMarker(TM_GSQ_Elias_Zealot_2, 8261);
		dlgTeleportToMarker(TM_GSQ_Elias_Zealot_3, 8262);
		addParty(GNZ_Elias, 0);
		addCharToParty(8260, GNZ_Elias, fighter);
		addCharToParty(8261, GNZ_Elias, fighter);
		addCharToParty(8262, GNZ_Elias, fighter);
		remQuest(GNZ_Elias);
		aod.gnz_elias = 1;
	}
	
	function GNZ_Exit_Arena()
	{
		if(aod.gnz_arena_fight == 4)
		{
			BlackSplash.command = "";
			BlackOut.command = "dlgDeleteDeadCharacters(); aod.gnz_arena_fight = 5; dlgTeleportToMarker(TM_Arena_Exit_PC); startBlackSplash();";
			startBlackOut();
		}
		else
		{
			BlackSplash.command = "";
			BlackOut.command = "apmsStartDialogue(GNZ_Arena_01); startBlackSplash();";
			startBlackOut();
		}	
	}
	
	function TRG_createBernie()
	{
		if(aod.gnz_bernieCreated == 0)
		{
			aod.gnz_bernieCreated = 1;
			createByCharMarker("CM_Berengarius"); 
			createByCharMarker("CM_Berengarius_Guard_Spear"); 
			createByCharMarker("CM_Berengarius_Guard_Xbow"); 
			addParty(GNZ_Bernie, 0);
			addCharToParty(9018, GNZ_Bernie, fighter);
			addCharToParty(9019, GNZ_Bernie, fighter);
		}
	}
	
	function TRG_MiltiadesInn()
	{
		if(aod.quest_gnz_milt_02 == 1)
		{
			BlackSplash.command = "";
			BlackOut.command = "apmsStartDialogue(GNZ_Quest_Milt_02); dlgTeleportToMarker(TM_Inn_Miltiades); startBlackSplash();";
			startBlackOut();
			createByCharMarker("CM_Miltiades_GNZ");
			createByCharMarker("CM_Miltiades_Merc_01");
			createByCharMarker("CM_Miltiades_Merc_02");
			createByCharMarker("CM_Miltiades_Merc_03");
			createByCharMarker("CM_Miltiades_Merc_04");
			aod.quest_gnz_milt_02 = 2;
			addParty(MiltiadesParty, 0);
			addCharToParty(9040, MiltiadesParty, fighter);
			addCharToParty(9041, MiltiadesParty, fighter);
			addCharToParty(9042, MiltiadesParty, fighter);
			addCharToParty(9043, MiltiadesParty, fighter);
			addCharToParty(9044, MiltiadesParty, fighter);
		}
	}
	
	function bark_gateMerc()
	{
		if(aod.npc_gnz_merc01_met == 0 && isInCombat() == false)
			sayPhrase(9003, "What're you looking at?");
	}
	
	function GNZ_Hide_ArenaExit()
	{
		VCO_ExitArena.setActive(0);
		OBJ_ExitArena.isRenderEnabled = 0;
	}
	
	function GNZ_createPancratius()
	{
		if(aod.gnz_pancratiusCreated == 0)
		{
			aod.gnz_pancratiusCreated = 1;
			createByCharMarker("CM_Pancratius");
			createByCharMarker("CM_Pancratius_Zealot_01");
			createByCharMarker("CM_Pancratius_Zealot_02");
			createByCharMarker("CM_Pancratius_Zealot_03");
			createByCharMarker("CM_Pancratius_Zealot_04");
			addParty(GNZ_Pancratius, 0);
			addCharToParty(9023, GNZ_Pancratius, fighter);
			addCharToParty(9024, GNZ_Pancratius, fighter);
			addCharToParty(9025, GNZ_Pancratius, fighter);
			addCharToParty(9026, GNZ_Pancratius, fighter);
			addCharToParty(9027, GNZ_Pancratius, fighter);
		}
		else if(aod.gnz_pancratiusCreated == 1 && aod.gnz_pancratiusRise)
		{
			aod.gnz_pancratiusCreated = 2;
			removeCharFromParty(9024);
			removeCharFromParty(9025);
			removeCharFromParty(9026);
			removeCharFromParty(9027);
			dlgDeleteCharacter(9024); // Remove old zealots
			dlgDeleteCharacter(9025);
			dlgDeleteCharacter(9026);
			dlgDeleteCharacter(9027);
			createByCharMarker("CM_New_Pancratius_Zealot_01"); // Create new zealots
			createByCharMarker("CM_New_Pancratius_Zealot_02");
			createByCharMarker("CM_New_Pancratius_Zealot_03");
			createByCharMarker("CM_New_Pancratius_Zealot_04");
			addCharToParty(9028, GNZ_Pancratius, fighter); // Add them to party GNZ_Pancratius
			addCharToParty(9029, GNZ_Pancratius, fighter);
			addCharToParty(9030, GNZ_Pancratius, fighter);
			addCharToParty(9031, GNZ_Pancratius, fighter);
		}

		if(aod.gnz_pancratiusRise)
			GNZ_armZealots();
	}
	
	function GNZ_Post_SiegeBroken()
	{
		aod.gnz_siegeBroken = 2;
		// Meru – lord
		// Varro - inquisitor
		// Athanasius – overseeing the temple
		// Paullus – back at Caer-Tor
		
		if(aod.ending_gnz_Carrinas_joins_HC)
			createByCharMarker("CM_Carrinas_First_Sword"); // Carrinas – First Sword
		
		assignDialogue(END_NPC_Meru, 8000);
		gnz_siegeToggle(0);
		assignDialogue(END_NPC_Athanasius, 8050); // New dialogue for Athan
		assignDialogue(END_NPC_Varro, 8040); // New dialogue for Varro
		
		if(aod.quest_mg_killFaelan == 6)
		{
			dlgDeleteCharacter(8001); // Remove Faelan
			aod.npc_faelan_dead = 1;
			GNZ_createThroneGuards();
		}
	}
	
	function GNZ_Post_CityTaken()
	{
		aod.gnz_cityTaken = 2;
		CrassusBanners.hideObjects();
		gnz_siegeToggle(0);
		dlgDeleteCharacter(8040); // Remove Varro
		dlgDeleteCharacter(8000); // Remove Meru
		aod.npc_meru_dead = 1;
		dlgDeleteCharacter(8001); // Remove Faelan
		aod.npc_faelan_dead = 1;
		
		if(isAlive(1000))
			dlgDeleteCharacter(1000); // Remove Feng
		
		assignDialogue(END_NPC_Athanasius, 8050); // New dialogue for Athan
		OpenCastleGate();
		aod.gnz_allowedIntoCastle = true;
		
		if(aod.gnz_newLeader $= Maseus)
		{
			dlgDeleteCharacter(81101); // Remove HC Castle, Fort, Plague guards
			dlgDeleteCharacter(81102);
			dlgDeleteCharacter(9501);
			dlgDeleteCharacter(9012);
			GNZ_deleteThroneGuards();
			createByCharMarker("CM_Maseus"); // Add Maseus
			createByCharMarker("CM_HA_Guard_Plague");
			HACity.showObjects();
		}
		
		if(aod.gnz_newLeader $= Hagnon && aod.npc_hagnon_dead == 0)
		{
			dlgDeleteCharacter(81101); // Remove HC Castle, Fort, Plague guards
			dlgDeleteCharacter(81102);
			dlgDeleteCharacter(9501);
			dlgDeleteCharacter(9012);
			GNZ_deleteThroneGuards();
			createByCharMarker("CM_Hagnon"); // Add HA Legatus Hagnon
			dlgUnequipHands(8200);
			createByCharMarker("CM_HA_Guard_Plague");
			HACity.showObjects();
		}
		
		if(aod.gnz_newLeader $= Hagnon && aod.npc_hagnon_dead)
		{
			dlgDeleteCharacter(81101); // Remove HC Castle, Fort, Plague guards
			dlgDeleteCharacter(81102);
			dlgDeleteCharacter(9501);
			dlgDeleteCharacter(9012);
			GNZ_deleteThroneGuards();
			createByCharMarker("CM_Legatus_HA"); // Add HA Legatus - Hagnon replacement
			dlgUnequipHands(8210);
			createByCharMarker("CM_HA_Guard_Plague");
			HACity.showObjects();
		}
		
		if(aod.gnz_newLeader $= Centurion)
		{
			dlgDeleteCharacter(81101); // Remove HC Castle, Fort, Plague guards
			dlgDeleteCharacter(81102);
			dlgDeleteCharacter(9501);
			dlgDeleteCharacter(9012);
			GNZ_deleteThroneGuards();
			createByCharMarker("CM_IG_Centurion"); // Add IG Centurion that governs in your place
			createByCharMarker("CM_IG_Guard_Plague");
			IGCity.showObjects();
		}
		
		if(aod.gnz_newLeader $= Fabianus)
		{
			dlgTeleportToMarker(TM_Meru_Throne, 9021); // Places Fabianus on the Throne
			assignDialogue(GNZ_NPC_Fabianus_02, 9021);
			GNZ_createThroneGuards();
			CrassusBanners.showObjects();
		}
		
		if(aod.gnz_thievesGuildDiscovered) // Block Access to Thieves
		{
			VCO_EnterThievesGuild.setActive(0);
			aod.gnz_thievesGuildDiscovered = 0;
		}
	}
	
	function GNZ_Post_MeruDies()
	{
		aod.gnz_meruDies = 2;
		gnz_siegeToggle(0);
		dlgDeleteCharacter(8040); // Remove Varro
		dlgDeleteCharacter(8000); // Remove Meru
		aod.npc_meru_dead = 1;
		dlgDeleteCharacter(8001); // Remove Faelan
		assignDialogue(END_NPC_Athanasius, 8050); // New dialogue for Athan
		dlgTeleportToMarker(TM_Meru_Throne, 9021); // Places Fabianus on the Throne
		assignDialogue(GNZ_NPC_Fabianus_02, 9021);
		GNZ_createThroneGuards();
		
		if(aod.gnz_thievesGuildDiscovered) // Block Access to Thieves
		{
			VCO_EnterThievesGuild.setActive(0);
			aod.gnz_thievesGuildDiscovered = 0;
		}
	}
	
	function GNZ_Post_Balzaar()
	{
		aod.gnz_balzaar = 2;
		gnz_siegeToggle(0);
		dlgDeleteCharacter(8000); // Remove Meru
		dlgDeleteCharacter(8001); // Remove Faelan
		createByCharMarker("CM_Balzaar_2");
		GNZ_createThroneGuards();
		dlgSetAnimation(anim_sit_chair_00_00, 0, 8031);
		assignDialogue(END_NPC_Athanasius, 8050); // New dialogue for Athan
		assignDialogue(END_NPC_Varro, 8040); // New dialogue for Varro
		BalzaarPraying.showObjects();
		setgrouppassability(147, 176, 148, 173, 0, 0);
		setgrouppassability(148, 171, 148, 172, 0, 0);
		setgrouppassability(146, 177, 146, 175, 0, 0);
		setgrouppassability(150, 171, 150, 172, 0, 0);
		setgrouppassability(150, 173, 151, 176, 0, 0);
		setgrouppassability(152, 175, 152, 177, 0, 0);
	}
	
	function GNZ_armZealots()
	{
		dlgSetCombatAnimation(9028);
		dlgSetCombatAnimation(9029);
		dlgSetCombatAnimation(9030);
		dlgSetCombatAnimation(9031);
	}
	
	function GNZ_disarmZealots()
	{
		if(aod.gnz_pancratiusRise)
		{
			dlgSetAmbientAnimation(9028);
			dlgSetAmbientAnimation(9029);
			dlgSetAmbientAnimation(9030);
			dlgSetAmbientAnimation(9031);
		}
	}
	
	function GNZ_createThroneGuards()
	{
		dlgCreateCharacter("衛兵", 8253, 82531, 152, 181, 0, S);
		dlgCreateCharacter("衛兵", 8253, 82532, 146, 181, 0, S);
		dlgCreateCharacter("衛兵", 8253, 82533, 153, 170, 0, W);
		dlgCreateCharacter("衛兵", 8253, 82534, 145, 170, 0, E);
	}
	
	function GNZ_deleteThroneGuards()
	{
		dlgDeleteCharacter(82531);
		dlgDeleteCharacter(82532);
		dlgDeleteCharacter(82533);
		dlgDeleteCharacter(82534);
	}
	
	function mapScreenWorldButtonScripts()
	{
		if(aod.quest_MG9_status == 1 && aod.quest_mg9_legatusStop == 0)
			sdFade(Quest_MG9_01);
		else if(aod.gnz_underSiege && aod.airship_ganezzar == 4)
			sdFade(GNZ_CityGate_Exit);
		else
			apmsMapWorld();
	}
};

useEventPackage(GanezzarEvents);