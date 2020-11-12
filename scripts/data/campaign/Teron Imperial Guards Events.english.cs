package TeronIGEvents
{
	function onInitLocation()
	{
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
	}
	
	function onLoadLocation()
	{
		apmsPlayMusic(custom, 33, 1); // IG Light
		
		if(aod.npc_feng_fledTeron == false && aod.npc_antidas_dead == 0)
			createByCharMarker("CM_Feng");
		
		if(aod.trn_inn_roomRented == 1)
			VCO_InnDoor.setActive(0);
		
		if(aod.global_Teron_IGTookOver && aod.npc_cassius_daratan)
		{
			FengSign.isRenderEnabled = 0;
			CassiusSign.isRenderEnabled = 1;
			dlgCreateCharacter("カッシウス", 1010, 1010, 70, 94, 0, E);
			assignDialogue(Cassius_02, 1010);
		}
	}
	
	function onGameplayStart()
	{		
		if(aod.tig_introDone == false)
		{
			aod.tig_introDone = true;
			ss_start(tig_intro, "tig_startDlg();");
			
			if(aod.global_Teron_Alliance)
			{
				createByCharMarker("CM_Dellar");
				createByCharMarker("CM_Antidas");
			}
			
			if(aod.global_Teron_IGTookOver)
			{
				createByCharMarker("CM_Centurion");
				dlgTeleportToMarker(TM_Throne_NPC_01, 1120);
			}
		}
		
		if(aod.ending_gnz_Carrinas_joins_HC && isAlive(1120))
			dlgDeleteCharacter(1120);
		
		setCombatAllowed(false);
		
		//*************** Party Settings ****
		//***********************************
		
		addParty(MgGuards, 0);
		addCharToParty(1570, "MgGuards", "fighter");
		addCharToParty(1571, "MgGuards", "fighter");
		
		dlgSetAnimation(anim_sit_chair_00_00, 0, 2110);
		dlgSetAnimation(anim_sit_chair_00_00, 0, 7280);
		
		if(aod.gameplay_aemolasShop && aod.npc_aemolas_dead == false)
		{
			AemolasShop.showObjects();
			setGroupPassability(33, 105, 37, 105, 0, 0);
			setGroupPassability(36, 104, 37, 104, 0, 0);
			setPassability(31, 105, 0, 0);
			if(isAlive(2070) == false)
				createByCharMarker("CM_Aemolas");
		}
		
		if(aod.npc_aemolas_dead)
		{
			AemolasShop.hideObjects();
			setGroupPassability(33, 105, 37, 105, 0, 1);
			setGroupPassability(36, 104, 37, 104, 0, 1);
			setPassability(31, 105, 0, 1);
			
			if(isAlive(2070))
				dlgDeleteCharacter(2070);
		}
		
		if(aod.TRN_fromTowerCellar)
		{
			aod.TRN_fromTowerCellar = 0;
			dlgTeleportToMarker(TM_TowerCellarExit);
		}
	}
	
	function onStartCombat()
	{
		if(aod.gameplay_combatHelpShown == false)
		{
			PG_HelpText_02.setVisible(true);
			aod.gameplay_combatHelpShown = true;
			aod.achievements_inFirstFight = true;
		}
	}
	
	function onEndCombat()
	{
		dlgSetAnimation(anim_sit_chair_00_00, 0, 2110);
		dlgSetAnimation(anim_sit_chair_00_00, 0, 7280);
		
		apmsPlayMusic(custom, 33, 1); // IG Light
		
		if(isalive())
		{
			if(PG_HelpText_02.isvisible())
				PG_HelpText_02.setVisible(false);
			
			if(aod.achievements_inFirstFight)
				aod.achievements_inFirstFight = false;
			
			// For Custom Death Screens
			
			deactivateDeathDesc();
		}
	}
	
	function onLeaveLocation()
	{
		globalOnLeaveLocation();
	}
	
	function tig_startDlg()
	{
		
	}
};

useEventPackage(TeronIGEvents);