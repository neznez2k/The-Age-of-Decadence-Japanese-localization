package TrainingYardEvents
{
	//Executed when visiting location for a first time.
	//After level objects are created.
	//Before characters are created.
	//Before spawnable client objects are created (units, camera)
	//Before player gains control.
	function onInitLocation()
	{
	
	}

	//Executed each time location is loaded.
	//After level objects are created.
	//After characters are created.
	//Before spawnable client objects are created (units, camera)
	//Before player gains control.
	function onLoadLocation()
	{
		apmsPlayMusic(custom, 1, 1);
	}
	
	//Executed each time location is loaded.
	//After level objects are created.
	//After characters are created.
	//After spawnable client objects are created (units, camera)
	//After player gains control.
	function onGameplayStart()
	{	
		setTravelingAllowed(false);
		setCombatAllowed(false);
		journal_button.setActive(0);
		
		if(aod.training_started == false)
		{
			sd(NPC_Tutorial);
			aod.training_started = true;
			dlgcam(25,40,8,300);
			PG_HelpText_01.setVisible(true);
			dlgaddskillpoints(80, 1);
		}
	}
	
	//Executed each time the combat is started.
	//After peace-time commands are deleted, first combat turn started, music changed, interface updated
	function onStartCombat()
	{
		aod.death_training = true;
		
		if (aod.gameplay_combatHelpShown == false)
		{
			PG_HelpText_02.setVisible(true);
			aod.gameplay_combatHelpShown = true;
			aod.achievements_inFirstFight = true;
			TM_ShowTutorial(training6);
			//MessageBoxOk("Welcome to your first fight!", " Read the help on the top left corner for hints on combat, or press F1 for more info. The most important thing to master are the special attacks, right click on your weapon to access them, and hover over them to get information on what they do.", "");
		}
	}
	
	//Executed each time the combat is ended.
	//After combat commands are deleted, combat turn ended, music changed, interface updated
	function onEndCombat()
	{
		if (isalive() == true)
		{
			PG_HelpText_02.setVisible(false);
			
			if (aod.training_combat == 0)
			{
				MessageBoxOk("You won!", "It was not that hard, wasn't it? Leave the arena by clicking on the gate, spend your SP and get on to the next fight!", "");
				aod.training_combat = 1 ;
			}
			
			if(aod.fight_training_01 == 1)
			{
				addCombatSP(10);
				aod.fight_training_01 = 2;
			}
			
			if(aod.fight_training_02 == 1)
			{
				addCombatSP(15);
				aod.fight_training_02 = 2;
			}
			
			if (aod.training_foughtFight03)
			{
				MessageBoxOk("Great Success!", "Your training is now complete, which gives you basic understanding of the combat system. We strongly recommend to play a combat specialist first to learn the system better before attempting to play a fighter/talker or other hybrid characters. Make sure your character has good physical attributes and well developed combat skills. Critical Strike, Crafting, and Alchemy can make quite a difference and increase your life expectancy. Fighter with some Crafting skills is a simple yet very reliable build. Experiment and find a build that works for you.", "StartNewGame();");
			}
			
			apmsPlayMusic(custom, 1, 1);
			
			// For Custom Death Screens
			
			deactivateDeathDesc();
		}
	}
	
	function onLeaveLocation()
	{
		globalOnLeaveLocation();
	}
	
	function startTutorial_01()
	{
		MessageBoxOk("Welcome to the training area!", "Read the help on the top left corner for camera controls. Press C to go to the character screen and distribute SP on your combat skills. Focus on a single offensive and defensive skills. Get some equipment from the chest, save your game and click on the gate to start. Press F1 for more info.", "");
	}
	
	function VCO_Gate()
	{
		if(aod.dagger == 1 && aod.sword == 1 && aod.axe == 1 && aod.hammer == 1 && aod.spear == 1 && aod.bow == 1 && aod.crossbow == 1 && aod.throwing == 1 && aod.training_msg_noSkill == 0)
		{
			aod.training_msg_noSkill = 1;
			MessageBoxOk("Low combat skills!", "You haven't increased a weapon skill. Put some skill points into a weapon skill of your choice and click on the gate again. For now, focus on a single weapon and a single defensive skill (Dodge or Block).", "apmsToggleCharScreen();");
		}
		
		else if(isInCombat() == false) 
		{
			BlackSplash.command = "";
			BlackOut.command = "vco_trainingYard(); startBlackSplash();";
			startBlackOut();
		}

		else
			narratePhrase("Finish the fight first, coward!");
	}
	
	function startTutorial(%Number)
	{
		switch(%Number)
		{
			case 1: if(aod.training_tutorial == 0){TM_ShowTutorial(training1); aod.training_tutorial = 1;}
			case 2: if(aod.training_tutorial == 1){TM_ShowTutorial(training2); aod.training_tutorial = 2;}
			case 3: if(aod.training_tutorial == 2){TM_ShowTutorial(training3); aod.training_tutorial = 3;}
			case 4: if(aod.training_tutorial == 3){TM_ShowTutorial(training4); aod.training_tutorial = 4;}
			case 5: if(aod.training_tutorial == 4){TM_ShowTutorial(training5); aod.training_tutorial = 5;}
		}
	}
	
	function vco_trainingYard()
	{
		if (aod.training_insideRing)
		{
			dlgTeleportToMarker(TM_OutsideRing);
			cheatHP();
			dlgCureStat(all);
			dlgDeleteDeadCharacters();
			if(aod.training_saveMessage == 0)
			{
				MessageBoxOk("","You've been healed.\nRemember to save, you are going to die soon.\nF5 for quicksave - F9 for quickload\nPress ESC to go to the main menu and select Save/Load.","");
				aod.training_saveMessage = 1;
			}
		}
		
		else
		{
			if (aod.training_foughtFight01 == false)
			{
				aod.training_foughtFight01 = true;
				createByCharMarker("CM_Train_Enemy_01");
				dlgSetAttitude(305, 1, -10);
				schedule(100, 0, dlgStartCombat);
				dlgTeleportToMarker(TM_InsideRing);
				PG_HelpText_01.setVisible(false);
				PG_HelpText_02.setVisible(true);
				aod.fight_training_01 = 1;
			}
			
			else if (aod.training_foughtFight02 == false)
			{
				aod.training_foughtFight02 = true;
				createByCharMarker("CM_Train_Enemy_02");
				createByCharMarker("CM_Train_Enemy_03");
				addParty(training_fight02, 0);
				addCharToParty(306, "training_fight02", "fighter");
				addCharToParty(307, "training_fight02", "fighter");
				addEnemyToParty(1, training_fight02);
				schedule(100, 0, dlgStartCombat);
				dlgTeleportToMarker(TM_InsideRing);
				aod.fight_training_02 = 1;
			}
			
			else if (aod.training_foughtFight03 == false)
			{
				aod.training_foughtFight03 = true;
				createByCharMarker("CM_Train_Enemy_04");
				createByCharMarker("CM_Train_Enemy_05");
				addParty(training_fight03, 0);
				addCharToParty(308, "training_fight03", "fighter");
				addCharToParty(309, "training_fight03", "fighter");
				addEnemyToParty(1, training_fight03);
				schedule(100, 0, dlgStartCombat);
				dlgTeleportToMarker(TM_InsideRing);
			}
			
			else
				MessageBoxOk("Great Success!", "Your training is complete.", "");
		}
	}	
};

useEventPackage(TrainingYardEvents);