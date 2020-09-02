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
				MessageBoxOk("勝利！", "それほど難しくはなかっただろう？\n門をクリックしてアリーナを出て、\nSPを消費して次の戦いに臨もう！", "");
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
				MessageBoxOk("大成功！", "訓練はこれで完了し、君は基本的な戦闘システムを理解できたことだろう。このゲームのシステムを学ぶために、まずは戦闘の専門家でプレイすることを強くお勧めする。その後、戦士/話し手や他のハイブリッドキャラを試すといい。君のキャラクターが優れた身体能力を持ち、よく練られた戦闘スキルであることを確認しよう。クリティカルストライクやクラフト、そして錬金術はかなりの効果をもたらし、君の寿命を延ばしてくれることだろう。クラフトスキルを持つ戦士はシンプルだが非常に信頼性の高いビルドだ。試行錯誤して、自分にあったビルドを見つけよう。", "StartNewGame();");
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
		MessageBoxOk("トレーニングエリアへようこそ！", "カメラ操作は左上のヘルプを見てください。Cボタンを押してキャラクター画面に移動し、SPを戦闘スキルに配分します。攻撃・防御共に一つのスキルに絞ってください。チェストから装備品を入手し、ゲームをセーブしたら門をクリックして始めます。F1を押すと詳細が表示されます。", "");
	}
	
	function VCO_Gate()
	{
		if(aod.dagger == 1 && aod.sword == 1 && aod.axe == 1 && aod.hammer == 1 && aod.spear == 1 && aod.bow == 1 && aod.crossbow == 1 && aod.throwing == 1 && aod.training_msg_noSkill == 0)
		{
			aod.training_msg_noSkill = 1;
			MessageBoxOk("戦闘スキルが低い！", "武器スキルを上げていない。好きな武器スキルにポイントを振ったら、もう一度門をクリックしよう。差しあたり、武器スキル1つと防御スキル（回避かブロック）1つに集中させよう。", "apmsToggleCharScreen();");
		}
		
		else if(isInCombat() == false) 
		{
			BlackSplash.command = "";
			BlackOut.command = "vco_trainingYard(); startBlackSplash();";
			startBlackOut();
		}

		else
			narratePhrase("この戦闘を終わらせてからだ、臆病者！");
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
				MessageBoxOk("","君は回復した。\nセーブを忘れるな。すぐに死ぬんだ。\nF5でクイックセーブ-F9でクイックロード\nESCでメインメニューに移動し、Save/Loadを選択する。","");
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
				MessageBoxOk("大成功！", "君の訓練は完了した。", "");
		}
	}	
};

useEventPackage(TrainingYardEvents);