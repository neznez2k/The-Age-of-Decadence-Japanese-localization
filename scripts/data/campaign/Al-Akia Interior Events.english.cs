package AlAkiaInteriorEvents
{
	function onInitLocation()
	{
		
	}
	
	function onLoadLocation()
	{
		apmsPlayMusic(custom, 4, 1);
	}
	
	function onGameplayStart()
	{
		setTravelingAllowed(false);
		setCombatAllowed(true);
		
		if(aod.alk_complex_intro == false)
		{
			aod.alk_complex_intro = true;
			dlgTeleportToMarker(TM_ALK_Start);
			
			if(aod.alk_HC1 == 2)
				sd(ALK_HC_04);
			else
				sd(ALK_Complex_Intro_02);
		}
		
		if(aod.ALK_imperialSide_Discovered)
			ALK_showImperialSide();
		
		if(aod.ALK_qantariSide_Discovered)
			ALK_showQantariSide();
		
		if(aod.alk_HC1 == 2)
		{
			aod.alk_HC1 = 3;
			createByCharMarker("CM_Meru");
			createByCharMarker("CM_Faelan");
			createByCharMarker("CM_Meru_Ritual_Loremaster");
			setCharacterInvincible(8000, 1);
			setCharacterInvincible(8001, 1);
			setCharacterInvincible(8033, 1);
		}
		
		//dlgKillCharacter(6200);	dlgKillCharacter(6201); dlgKillCharacter(6202);	dlgKillCharacter(6203); dlgKillCharacter(6204);	dlgKillCharacter(6205);
		
		//*************** Party Settings ****
		//***********************************
	}
	
	function onStartCombat()
	{
		if(aod.alk_nearMeru == 1)
			sayPhrase(8001, "You won't hit us, <charname>");
		
		if(aod.fight_alkBalzaar)
			apmsPlayMusic(custom, 7, 1);
	}
	
	function onEndCombat()
	{
		apmsPlayMusic(custom, 4, 1);
		
		if(isalive())
		{
			if(aod.fight_alkBalzaar)
			{
				aod.fight_alkBalzaar = 0;
				rwd_fight(Balzaar_01);
				aod.ending_gnz_MeruDiesAlAkia = 1;
				
				if(aod.jnl_HD_AlAkiaFate == 7) 
					aod.jnl_HD_AlAkiaFate = 9;
				
				BlackSplash.command = "";
				BlackOut.command = "sd(ALK_HC_03); dlgTeleportToMarker(TM_HC_DeadGod_Faelan, 8001); dlgTeleportToMarker(TM_HC_MeruGod, 8030); dlgTeleportToMarker(TM_HC_MeruGod_PC); dlgRotateToChar(8001, 1); dlgSetAmbientAnimation(8001); startBlackSplash();";
				startBlackOut();
			}

			if(aod.fight_scolopendra)
				aod.fight_scolopendra = 0;
			// For Custom Death Screens
			
			deactivateDeathDesc();
		}
	}
	
	function onLeaveLocation()
	{
		globalOnLeaveLocation();
	}
	
	function VCO_ALK_Exit()
	{
		if(aod.alk_HC1 == 3)
			sayPhrase(8000, "Find the sacred chamber, <charname>.");
		
		else if(aod.alk_HC1 == 4 && aod.gnz_finished == 0)
		{
			dlgDeleteCharacter(8000);
			dlgDeleteCharacter(8001);
			dlgDeleteCharacter(8033);
			
			if(aod.jnl_HC_AlAkia == 3 || aod.jnl_HC_AlAkia == 4)
				aod.jnl_HC_AlAkia = 5;
			
			if(aod.quest_GnzHA1_status >= 2)
			{
				aod.quest_GnzHA1_status = 5;
				aod.ending_GNZ_faction_HA = 3;
				BlackSplash.command = "";
				BlackOut.command = "SS_start(\"gnz_ending\", \"switchMaadoran();\"); startBlackSplash();";
				startBlackOut();
			}
			else if(aod.quest_GnzHD2_status >= 3 || aod.quest_GnzHD1_status == 3)
			{
				aod.quest_GnzHD2_status = 5;
				aod.ending_GNZ_faction_HD = 3;
				BlackSplash.command = "";
				BlackOut.command = "SS_start(\"gnz_ending\", \"switchTeron();\"); startBlackSplash();";
				startBlackOut();
			}
			else
			{
				aod.loc_ALK_fromInterior = true;
				BlackSplash.command = "";
				BlackOut.command = "SS_start(\"gnz_ending\", \"switchGanezzar();\"); startBlackSplash();";
				startBlackOut();
			}
		}
		
		else if(aod.quest_IG_GNZ1 == 2)
			narratePhrase("You still need to explore the lower chambers.");
		
		else
		{
			if(isInCombat())
				narratePhrase("You can't leave right now.");
			else
			{
				aod.loc_ALK_fromInterior = true;
				BlackOut.command = "switchMission(\"Al-Akia.mis\");";
				startBlackOut();
			}
		}
	}
	
	function switchAlAkia()
	{
		switchMission("Al-Akia.mis");
	}
	
	function switchMaadoran()
	{
		switchMission("Maadoran.mis");
	}
	
	function switchTeron()
	{
		switchMission("Teron_MG.mis");
	}
	
	function switchGanezzar()
	{
		switchMission("Ganezzar.mis");
	}
	
	function ALK_showImperialSide()
	{
		BLOCK_Imperial_1F_01.isRenderEnabled = 0;
		BLOCK_Imperial_1F_02.isRenderEnabled = 0;
		BLOCK_Imperial_2F.isRenderEnabled = 0;
		aod.ALK_imperialSide_Discovered = true;
	}
	
	function ALK_showQantariSide()
	{
		BLOCK_Qantari_1F_01.isRenderEnabled = 0;
		BLOCK_Qantari_1F_02.isRenderEnabled = 0;
		BLOCK_Qantari_2F.isRenderEnabled = 0;
		aod.ALK_qantariSide_Discovered = true;
	}
	
	function ALK_OpenQantariDoor()
	{
		DOOR_QantariEntrance_1F.open();
		VCO_QantariDoor.setActive(0);
		ALK_showQantariSide();
	}
	
	function ALK_OpenImperialDoor()
	{
		DOOR_ImperialEntrance_2F.open();
		VCO_ImperialDoor.setActive(0);
		VCO_ImperialDoor_1F.setActive(0);
		ALK_showImperialSide();
	}
	
	function TRG_ALK_1F()
	{
		if(aod.ALK_imperialSide_Discovered)
			ALK_showImperialSide();
		else
			BLOCK_Imperial_2F.isRenderEnabled = 0;
		
		if(aod.ALK_qantariSide_Discovered)
			ALK_showQantariSide();
		else
			BLOCK_Qantari_2F.isRenderEnabled = 0;
		
		VCO_tank_01.setActive(0);
		VCO_tank_02.setActive(0);
		VCO_tank_03.setActive(0);
		VCO_tank_04.setActive(0);
		VCO_device_01.setActive(0);
		VCO_SemiSphere_01.setActive(0);
		VCO_SemiSphere_02.setActive(0);
		VCO_Console_01.setActive(0);
		VCO_Console_02.setActive(0);
		VCO_vat_01.setActive(0);
		VCO_stairs_01.setActive(0);
		DOOR_Lab_Imperial1.isRenderEnabled = 0;
		DOOR_Lab_Imperial11.isRenderEnabled = 0;
		DOOR_Lab_Imperial111.isRenderEnabled = 0;
	}
	
	function TRG_ALK_2F()
	{
		if(aod.ALK_imperialSide_Discovered)
			ALK_showImperialSide();
		else
			BLOCK_Imperial_2F.isRenderEnabled = 1;
		
		if(aod.ALK_qantariSide_Discovered)
			ALK_showQantariSide();
		else
			BLOCK_Qantari_2F.isRenderEnabled = 1;
		
		VCO_tank_01.setActive(1);
		VCO_tank_02.setActive(1);
		VCO_tank_03.setActive(1);
		VCO_tank_04.setActive(1);
		VCO_device_01.setActive(1);
		VCO_SemiSphere_01.setActive(1);
		VCO_SemiSphere_02.setActive(1);
		VCO_Console_01.setActive(1);
		VCO_Console_02.setActive(1);
		VCO_vat_01.setActive(1);
		VCO_stairs_01.setActive(1);
		DOOR_Lab_Imperial1.isRenderEnabled = 1;
		DOOR_Lab_Imperial11.isRenderEnabled = 1;
		DOOR_Lab_Imperial111.isRenderEnabled = 1;
	}
	
	function TRG_ALK_Scolopendra_01()
	{
		if(aod.ALK_ScolopendraDead == false)
		{
			BlackSplash.command = "";
			BlackOut.command = "sd(ALK_Complex_Scolopendra_01); startBlackSplash();";
			startBlackOut();
		}
	}
	
	function TRG_ChamberVisit(%TM)
	{
		if(aod.alk_HC1 == 3)
		{
			BlackSplash.command = "";
			BlackOut.command = "aod.alk_HC1 = 4; sd(ALK_HC_02); dlgTeleportToMarker(TM_LabStair_01_1F); aod.ALK_foundChamber = true; startBlackSplash();";
			startBlackOut();
		}
		else if(aod.ALK_foundChamber == false)
		{
			BlackSplash.command = "";
			BlackOut.command = "sd(ALK_Chamber_Intro); dlgTeleportToMarker(TM_LabStair_First); aod.ALK_foundChamber = true; startBlackSplash();";
			startBlackOut();
		}
		else if(%TM == 1)
		{
			BlackSplash.command = "";
			BlackOut.command = "dlgTeleportToMarker(TM_LabStair_01_1F); startBlackSplash();";
			startBlackOut();
		}
		else if(%TM == 2)
		{
			BlackSplash.command = "";
			BlackOut.command = "dlgTeleportToMarker(TM_LabStair_02_1F); startBlackSplash();";
			startBlackOut();
		}
	}

	function descriptionsVCO(%desc)
	{
		switch(%desc)
		{
			case 1: if(aod.quest_abyss_enteredChamber)
					narratePhrase("It's a tank similar to the one you saw under the Abyss.<nlo>It's empty - the 'god' that once inhabited it is long gone.");
				else
					narratePhrase("It's a strange tank connected to several machines that appear to be long dead.<nlo>There is a console on one side and a small glass aperture on the top.<nlo>Cleaning away as much as you can of the grime, you take a look inside - nothing but some murky liquid.");
			case 2: narratePhrase("A strange device or a base to mount a far larger device that seems to be missing.");
			case 3: narratePhrase("A wondrous column made of thick green glass and filled with liquid. An aquarium to calm one's senses?");
			case 4: narratePhrase("A blocked stairway filled with sand and debris."); 
			case 5: narratePhrase("The passage beyond the door is filled with sand and debris."); 
			case 6: if(aod.quest_abyss_enteredChamber)
					narratePhrase("You've seen this chamber in one of the visions<nlo>you've experienced while exploring the Abyss. That's where the ritual took place.");
				else
					narratePhrase("It's the heart of the pyramid - seven sarcophagi arranged in a circle, each standing at an angle of about forty degrees.<nlo>Marble statues, kneeling to recieve divine blessing or reaching to the sky, strange machinery and pipes connecting the sarcophagi<nlo>and disappearing into the pit below create a very uneasy feeling.");
			case 7: narratePhrase("It's the most complex control system you've seen in your travels.<nlo>Judging by the low humming sound, it still has the power to change the world."); 
			case 8: narratePhrase("It seems that this part of the complex was vacated in a hurry.<nlo>Whatever happened, happened fast and without warning."); 
			case 9: BlackSplash.command = ""; BlackOut.command = "sd(ALK_Diary_02); startBlackSplash();"; startBlackOut();
			case 10: BlackSplash.command = ""; BlackOut.command = "sd(ALK_Diary_01); startBlackSplash();"; startBlackOut();
			case 11: narratePhrase("The semi-sphere is disabled.");
			case 12: narratePhrase("The control panel is inactive.");
		}
	}
};

useEventPackage(AlAkiaInteriorEvents);