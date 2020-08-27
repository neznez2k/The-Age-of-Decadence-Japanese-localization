function harvestAlchemy(%amount, %ingredient, %number)
{
	switch$(%ingredient)
	{
		case "cassava": 		%requirement = 2; %itemID = 1800; %name = "cassava roots";
		case "goldenberry": 	%requirement = 3; %itemID = 1801; %name = "golden berries";
		case "amaranthus": 		%requirement = 8; %itemID = 1802; %name = "amaranthus extract";
		case "bloodMushroom": 	%requirement = 2; %itemID = 1803; %name = "blood mushrooms";
		case "emoryl": 			%requirement = 3; %itemID = 1804; %name = "emoryl roots";
		case "fennah": 			%requirement = 3; %itemID = 1805; %name = "fennah berries";
		case "quicksilver": 	%requirement = 3; %itemID = 1806; %name = "quicksilver roots";
		case "dragonBlood": 	%requirement = 7; %itemID = 1807; %name = "dragon blood";
		case "kadura": 			%requirement = 2; %itemID = 1808; %name = "kadura leaves";
		case "avatera": 		%requirement = 3; %itemID = 1809; %name = "avatera sprouts";
		case "sulfur": 			%requirement = 1; %itemID = 1810; %name = "sulfur";
		case "saltPetrae": 		%requirement = 1; %itemID = 1811; %name = "salt petrae";
		case "foolsGold": 		%requirement = 1; %itemID = 1812; %name = "fools gold";
		case "rockOil": 		%requirement = 1; %itemID = 1813; %name = "rock oil";
		case "quicklime": 		%requirement = 1; %itemID = 1814; %name = "quicklime";
		case "blackPowder": 	%requirement = 1; %itemID = 1815; %name = "black powder";
		default:
			warn("harvestAlchemy - unknown ingredient " @ %ingredient @ "!"); narratePhrase("If you are reading this, there's a bug here!"); %failed = true;
	}
	
	if(%failed == false)
	{
		if(aod.alchemy < %requirement)
		{
			narratePhrase($alchemyHarvesting_failure);
		}
		
		else
		{
			narratePhrase($alchemyHarvesting_success @ " " @ %name @ " (" @ %amount @ ")");
			dlgAddItem(%itemID, %amount);
			(VCO_AlchemyHarvest_ @ %number).setActive(false);
			%alchemy_model = "MODEL_AlchemyHarvest_" @ %number;
			%alchemy_model.startFade(1000, 0, 1);
			schedule(1000, 0, hideAlchemyObject, %alchemy_model);
        }
    }
}

function hideAlchemyObject(%objectName)
{
    setObjectRenderState(%objectName, 0);
}

function trapDamage(%TrapLevel)
{
	switch(%TrapLevel)
	{
		case 3: %HP = 25;
		case 4: %HP = 30;
		case 5: %HP = 35;
		case 6: %HP = 40;
		case 7: %HP = 45;
		case 8: %HP = 50;
		case 9: %HP = 55;
		case 10: %HP = 60;
	}
	
	if(dlgGetCharacterHP() > %HP)
	{
		narratePhrase("\c4[traps failure]\c1 You trigger a trap and take a bolt to the gut.");			
		dlgAddTextBoxMessage("You lose " @ %HP @ " hit points!");
		dlgAddTextBoxMessage("Constitution is reduced by 1.");
		dlgAddStatPenalty("con", 1);
		sfxPlayOnce(trapBolt01);
		trapOnHit(%HP);
		//dlgChangeCharacterHP(-%HP);
		//dlgSetAnimation(anim_washit_back, 0, 1);
		//schedule(200, 0, dlgSetAmbientAnimation);
	}
	
	else
	{
		narratePhrase("\c4[traps failure]\c1 You trigger a trap and take a bolt to the gut.");
		aod.death_traps_01 = true;
		sfxPlayOnce(trapBolt01);
		trapDeath();
		/*dlgUnequipHands(1);
		dlgSetAnimation(anim_death_aimed_torso, 0, 1);
		dlgKillCharacter(1);
		schedule(2000, 0, schedulePCDeath, 1);*/
	}
}

function stealFailure(%TM, %Type)
{
	switch(%Type)
	{
		case 1: $Phrase_StealFailure = "\c4[steal failure]\c1 Your clumsy attempt wakes up the guest, forcing you to retreat. ";
		case 2: $Phrase_StealFailure = "\c4[steal failure]\c1 The merchant gets suspicious and keeps his eyes on you, making it impossible to steal anything.";
	}
	
	if(%TM == 0)
	{
		narratePhrase($Phrase_StealFailure);
	}
	else
	{
		BlackSplash.command = "";
		BlackOut.command = "dlgTeleportToMarker(TM_ThiefFail_" @ %TM @ "); narratePhrase($Phrase_StealFailure); startBlackSplash();";
		startBlackOut();
	}
}

function stealSuccess(%Type)
{
	switch(%Type)
	{
		case 1: narratePhrase("\c6[steal success]\c1 You go through the sleeping guest's belongings without disturbing his rest."); // For Inns, stealing from sleeping patrons
		case 2: narratePhrase("\c6[steal success]\c1 The merchant is too distracted to pay any attention to what you're doing."); // For market stalls
	}
}

function TRG_sneakFailure(%TM, %Type)
{
	switch(%Type)
	{
		case 1: $Phrase_SneakFailure = "\c4[sneak failure]\c1 The sleeping guest wakes up when you enter the room, forcing you to retreat.";
		case 2: $Phrase_SneakFailure = "\c4[sneak failure]\c1 The sleeping guest wakes up when you come closer, forcing you to retreat.";
		case 3: $Phrase_SneakFailure = "\c4[sneak failure]\c1 The guard hears something and goes to investigate, forcing you to retreat. ";
		case 4: $Phrase_SneakFailure = "\c4[sneak failure]\c1 You draw too much attention and retreat before it becomes a problem.";
		case 5: $Phrase_SneakFailure = "\c4[sneak failure]\c1 The innkeeper stops you before you get close enough to his chest.";
	}
	
	BlackSplash.command = "";
	BlackOut.command = "dlgTeleportToMarker(TM_ThiefFail_" @ %TM @ "); narratePhrase($Phrase_SneakFailure); startBlackSplash();";
	startBlackOut();
}

function TRG_sneakSuccess(%Type)
{
	switch(%Type)
	{
		case 1: narratePhrase("\c6[sneak success]\c1 You enter the room without waking up the sleeping guest."); // For Inns, entering the room
		case 2: narratePhrase("\c6[sneak success]\c1 The sleeping guest remains blissfully unaware of your presence."); // For Inns, approaching the beds
		case 3: narratePhrase("\c6[sneak success]\c1 The guard remains unaware of your presence."); // For Houses with guards, like Thesalos, when you move around.
		case 4: narratePhrase("\c6[sneak success]\c1 You slip inside the room without raising any suspicions."); // For empty rooms.
		case 5: narratePhrase("\c6[sneak success]\c1 Distracted, the innkeeper doesn't notice you skulking behind him."); // For Ganezzar Inn.
	}
}

function playerStash()
{
	if(aod.stashtutorial == 0)
	{
		MessageBoxOk("Stash", "This is a magic chest. It will follow you from one inn to the next and keep your items safe while you're adventuring.", "openGlobalStash();", ""); 
		aod.stashtutorial = 1;
	}
	
	else
		openGlobalStash();
}

function VCO_TRN_FengScroll()
{
	if(aod.exploration_fengLore == false)
	{
		aod.exploration_fengLore = true;
		if(aod.lore <= 3)
		{
			narratePhrase("It's a large, carefully restored document tracing the history of House Daratan throughout the centuries.<nlo>Turns out the House owes its name to the battle of Dar Attan<nlo>where a certain Legatus managed to defeat an army of 20,000 men with less than a full legion.<nlo><nlo>*Your Lore skill is increased by 1*");
			increaseSkillsLore(10);
		}
		
		else
		{
			narratePhrase("It's a large, carefully restored document tracing the history of House Daratan throughout the centuries.<nlo>Turns out the House owes its name to the battle of Dar Attan<nlo>where a certain Legatus managed to defeat an army of 20,000 men with less than a full legion.<nlo><nlo>The scroll doesn't contain anything you don't already know, but you manage to gain a few bits and pieces of knowledge.");
			increaseSkillsLore(10);
		}
		
	}
	
	else
		narratePhrase("It's a large, carefully restored document tracing the history of House Daratan throughout the centuries.<nlo>Turns out the House owes its name to the battle of Dar Attan<nlo>where a certain Legatus managed to defeat an army of 20,000 men with less than a full legion.");
}

function VCO_TRN_FengVine01()
{
	if(aod.dex >= 8)
	{
		BlackSplash.command = "";
		BlackOut.command = "dlgTeleportToMarker(TM_FengVine_01); narratePhrase(\"[dexterity - success] You managed to climb the vine.\"); startBlackSplash();";
		startBlackOut();
	}

	if(aod.dex < 8)
	{
		BlackSplash.command = "";
		BlackOut.command = "dlgTeleportToMarker(TM_FengVine_03); narratePhrase(\"[dexterity - failure] You failed to climb the vine.\"); startBlackSplash();";
		startBlackOut();
	}
}

function VCO_TRN_FengVine02()
{
	if(aod.dex >= 8)
	{
		BlackSplash.command = "";
		BlackOut.command = "dlgTeleportToMarker(TM_FengVine_02); narratePhrase(\"[dexterity - success] You managed to climb the vine.\"); startBlackSplash();";
		startBlackOut();
	}

	if(aod.dex < 8)
	{
		BlackSplash.command = "";
		BlackOut.command = "dlgTeleportToMarker(TM_FengVine_04); narratePhrase(\"[dexterity - failure] You failed to climb the vine.\"); startBlackSplash();";
		startBlackOut();
	}
}

function VCO_TRN_FengVine03()
{
	BlackSplash.command = "";
	BlackOut.command = "dlgTeleportToMarker(TM_FengVine_03); startBlackSplash();";
	startBlackOut();
}

function VCO_TRN_FengVine04()
{
	BlackSplash.command = "";
	BlackOut.command = "dlgTeleportToMarker(TM_FengVine_04); startBlackSplash();";
	startBlackOut();
}

function VCO_TRN_FengHatch()
{
	if(aod.lockpick >= 3 && aod.exploration_fengHatchOpen == false)
	{
		BlackSplash.command = "";
		BlackOut.command = "dlgTeleportToMarker(TM_FengStair_01); narratePhrase(\"[lockpick - success] You succesfully unlock the hatch.\"); rwd_civil(Lockpick); aod.exploration_fengHatchOpen = true; startBlackSplash();";
		startBlackOut();
	}

	if(aod.lockpick < 3 && aod.exploration_fengHatchOpen == false)
	{
		BlackSplash.command = "";
		BlackOut.command = "dlgTeleportToMarker(TM_FengStair_01); narratePhrase(\"[lockpick - failure] You failed to unlock the hatch.\"); startBlackSplash();";
		startBlackOut();
	}

	if(aod.exploration_fengHatchOpen)
	{
		BlackSplash.command = "";
		BlackOut.command = "dlgTeleportToMarker(TM_FengStair_02); narratePhrase(\"You enter Feng's house.\"); startBlackSplash();";
		startBlackOut();
	}
}

function VCO_TRN_FengStair()
{
	BlackSplash.command = "";
	BlackOut.command = "dlgTeleportToMarker(TM_FengStair_03); aod.exploration_fengHatchOpen = true; startBlackSplash();";
	startBlackOut();
}

function VCO_TRN_blacksmithWindowOutside()
{
	if(aod.exploration_blacksmithFinished == false)
	{
		BlackSplash.command = "";
		BlackOut.command = "apmsStartDialogue(Exploration_Blacksmith); startBlackSplash();";
		startBlackOut();
	}

	else
	{
		narratePhrase("The window is locked.");
	}
}

function VCO_TRN_BlacksmithTechnique()
{
	if(aod.exploration_blacksmithTechnique == false)
	{
		aod.exploration_blacksmithTechnique = true;
		if(aod.crafting < 3)
		{
			narratePhrase("A workbench cluttered with tools.<nlo>The wall above is filled with charts, notes, and blade patterns.<nlo>One of the notes contains detailed instructions on edge quenching and tempering.<nlo>You quickly copy them to your journal.<nlo><nlo>*Your Crafting skill is increased by 1*");
			increaseSkillsCrafting(10);
		}
		else
		{
			narratePhrase("A workbench cluttered with tools.<nlo>The wall above is filled with charts, notes, and blade patterns.<nlo>The notes don't contain anything you don't already know, but you manage to gain a few bits and pieces of useful knowledge.");
			increaseSkillsCrafting(10);
		}
	}
	
	else
		narratePhrase("A workbench cluttered with tools.<nlo>The wall above is filled with charts, notes, and blade patterns.");
}

function VCO_TRN_BlacksmithStorage()
{
	if(aod.exploration_blacksmithStorage == false)
	{
		aod.exploration_blacksmithStorage = true;
		if(aod.per >= 8)
		{
			narratePhrase("[perception success] A storage area filled with chests and barrels. You've heard stories about magical weapons and riches found in barrels,<nlo>but these ones contain nothing save for some salted pork, cabbage heads, and charcoal. The chests contain mundane supplies and leftovers.<nlo>You manage to spot several iron and steel ingots there and carefully place them in your backpack.");
			dlgAddItemlist(TSQ_Blacksmith_IronIngot);
			dlgAddItemlist(TSQ_Blacksmith_SteelIngot);
		}
		else
		{
			narratePhrase("A storage area filled with chests and barrels. You've heard stories about magical weapons and riches found in barrels,<nlo>but these ones contain nothing save for some salted pork, cabbage heads, and charcoal. The chests contain mundane supplies and leftovers.<nlo>You manage to spot a few iron ingots there and carefully place them in your backpack.");
			dlgAddItemlist(TSQ_Blacksmith_IronIngot);
		}
	}
	
	else
		narratePhrase("A storage area filled with chests and barrels.");
}

function VCO_ZMD_StairsToTop()
{
	if(aod.loc_zamedi_visitedTop == false)
	{
		BlackSplash.command = "";
		BlackOut.command = "sd(Quest_Zamedi_02); dlgTeleportToMarker(TM_TowerTop_03); theSun.logWeight = 0.9; theSun.apply(); BlackSky.IsRenderEnabled = false; startBlackSplash();";
		startBlackOut();
	}
	
	else if(aod.zmd_portalActive)
	{
		BlackSplash.command = "";
		BlackOut.command = "ZamediPortal.showObjects(); dlgTeleportToMarker(TM_TowerTop_03); theSun.logWeight = 0.9; theSun.apply(); BlackSky.IsRenderEnabled = false; startBlackSplash();";
		startBlackOut();
	}
	
	else
	{
		BlackSplash.command = "";
		BlackOut.command = "dlgTeleportToMarker(TM_TowerTop_03); theSun.logWeight = 0.9; theSun.apply(); BlackSky.IsRenderEnabled = false; startBlackSplash();";
		startBlackOut();
	}	
}

function VCO_ZMD_StairsFromTop()
{
	BlackSplash.command = "";
	BlackOut.command = "ZamediPortal.hideObjects(); dlgTeleportToMarker(TM_TowerTop_04); theSun.logWeight = 0.16; theSun.apply(); BlackSky.IsRenderEnabled = true; startBlackSplash();";
	startBlackOut();
}

function VCO_ZMD_Elevator1F()
{
	if(isInCombat() == false)
	{
		aod.quest_zamedi_usedElevator = true;
		switchMission("The Tower.mis");
	}
}

function TRG_SRS_ChamberSearch()
{
	if(aod.SRS_exploredLibrary && aod.SRS_chamberLocation == false)
	{
		if(aod.SRS_foundGrate && aod.int >= 6)
		{
			narratePhrase("[intelligence success] The air vent you saw earlier indicates that there should be another chamber here.");
			aod.SRS_chamberLocation = true;
			VCO_ChamberDoor.setActive(true);
		}
		
		else if(aod.per >= 6 && aod.srs_chamberMentioned)
		{
			narratePhrase("[perception success] Keeping in mind what the prospector told you about the secret chamber, you look around until you settle on the northern wall. If the secret chamber exists, it has to be behind that wall.");
			aod.SRS_chamberLocation = true;
			VCO_ChamberDoor.setActive(true);
		}
		
		else if(aod.per >= 7)
		{
			narratePhrase("[perception success] You notice the telltale signs of a fake wall behind the elevator. A hidden chamber?");
			aod.SRS_chamberLocation = true;
			VCO_ChamberDoor.setActive(true);
		}
	}
}

function VCO_SRS_Grate()
{
	if(aod.SRS_foundGrate == false && aod.SRS_movedGrateStone)
	{
		narratePhrase("It's a small air vent indicating the presence of a chamber below.");
		aod.SRS_foundGrate = true;
	}
	
	else if(aod.str >= 7 && aod.SRS_movedGrateStone == false)
	{
		narratePhrase("[success] You manage to move the stones, revealing a small grating.");
		aod.SRS_movedGrateStone = true;
		OBJ_GrateStone.hideObjects();
		VCO_Grate.setCursor("EyeCursor");
		VCO_Grate.setCursorText(12);
	}
	
	else if(aod.SRS_movedGrateStone == false)
		narratePhrase("[failure] The stones are too heavy.");
	
	else if(aod.SRS_foundGrate)
		narratePhrase("There's nothing else here.");
}

function VCO_SRS_ChamberDoor()
{
	if(aod.SRS_foundDoor == false)
	{
		narratePhrase("Knowing that there is another chamber behind the wall, it doesn't take you long to find a hidden switch.");
		aod.SRS_foundDoor = true;
		VCO_ChamberDoor.setCursor("GearCursor");
		VCO_ChamberDoor.setCursorText(13);
	}
	
	else if(aod.SRS_generatorFixed == false)
	{
		narratePhrase("You press the switch but nothing happens. Probably needs power.");
	}
	
	else if(aod.SRS_generatorFixed)
	{
		BlackSplash.command = "";
		BlackOut.command = "BasementVault.showObjects(true); SecretDoor01.hideObjects(); SecretDoor02.showObjects(); VCO_ChamberDoor.setActive(false); narratePhrase(\"You press the switch and a section of the wall sinks into the floor, revealing a hidden chamber.\"); startBlackSplash();";
		startBlackOut();
		//narratePhrase("You press the switch and a section of the wall sinks into the floor, revealing a hidden chamber.");
		//BasementVault.showObjects(true);
		//SecretDoor01.hideObjects();
		//SecretDoor02.showObjects();
		aod.SRS_foundChamber = true;
		//VCO_ChamberDoor.setActive(false);
		setPassability(63, 66, 0, 1);
	}
}

function VCO_AemolasGold()
{
	/*BlackSplash.command = "";
	BlackOut.command = "narratePhrase(\"You don't have to dig long. Buried two feet below the surface, you find a heavy leather bag.<nlo>Judging by the weight, there are at least a thousand imperials inside.\"); startBlackSplash();";
	startBlackOut();
	rwd_quest(AemolasVillage_01);
	aod.quest_aemolas_gotmoney = true;
	VCO_theWell_01.setActive(false);*/
	
	aod.quest_aemolas_gotMoneyVCO = true;
	
	BlackSplash.command = "";
	BlackOut.command = "sd(Quest_AemolasVillage_01); startBlackSplash();";
	startBlackOut();
}

function VCO_SRS_shelfLocations()
{
	if(aod.srs_foundLocationsMention == false)
	{
		aod.srs_foundLocationsMention = true;
		narratePhrase("You find an old map, but it falls apart in your hands the moment you touch it.<nlo>The fragments depict a strange arch in the middle of nowhere and a stylized tower surrounded by small dwellings.<nlo>You add both locations to your map.");
		revealMapLocation("Arch");
		dlgAddTextBoxMessage("The Arch added to the map");
		addQuest("theArch");
		if(aod.srs_foundZamediMention == false)
		{
			revealMapLocation("Zamedi");
			dlgAddTextBoxMessage("Zamedi added to the map");
			addQuest("Zamedi");
			aod.srs_foundZamediMention = true;
		}
	}
	
	else
		narratePhrase("There's nothing else here.");
}

function VCO_SRS_shelfLocationInferiae()
{
	if(aod.srs_foundInferiaeMention == false)
	{
		if(aod.lore >= 3)
		{
			aod.srs_foundInferiaeMention = true;
			narratePhrase("[lore success] You find a crumbling scroll depicting a strange diagram and some comments written in a language you recognize.<nlo>It seems that the scroll shows some kind of network connecting different places, although the purpose of such a network is unclear.<nlo>You're able to copy two locations to your map before the scroll falls apart in your hands.");
			revealMapLocation("Inferiae");
			dlgAddTextBoxMessage("Inferiae added to the map");
			addQuest("Inferiae");
			if(aod.srs_foundZamediMention == false)
			{
				revealMapLocation("Zamedi");
				dlgAddTextBoxMessage("Zamedi added to the map");
				addQuest("Zamedi");
				aod.srs_foundZamediMention = true;
			}
		}
		
		else
		{
			narratePhrase("[lore failure] You find a crumbling scroll depicting a strange diagram and some comments written in a language you don't understand.");
		}
	}
	
	else
		narratePhrase("There's nothing else here.");
}

function VCO_INF_DeadGuardBody()
{
	dlgAddItemlist(Loot_InferiaeDemon);
	dlgAddItem(2185, 1);
	narratePhrase("You take the stone guards' swords and the glowing core.");
	VCO_DeadGuardBody.setActive(0);
}

function VCO_SRS_warStory(%storyPiece)
{
	switch(%storyPiece)
	{
		case 0: %text = "There came a great disturbance in the town of Lakia by the Nazvian Sea, with confusion and flight.<nlo>[...] And all the people fled from the ships of the kingdom of Qantaar, which had crossed the sea, inflicting every kind of punishment upon the people of Lakia.<nlo>[...] The Imperial army, being blessed and varying in design, fell upon the enemy. Slain were the men, their ships set aflame, the women taken into bondage.";
		case 1: %text = "A single year did come to pass, and again a great number of Qantari ships crossed the sea.<nlo>The ships carried an army larger than had ever been witnessed, and never had the Words of Power afforded such benefit to a coming invasion.";
		case 2: %text = "War did come, and like the army who brought it, the magnitude humbled all that came before. Men and towns burned alike and even the seas stirred with the fury of war.<nlo>The sun became as night, and the moon ceased to shine. The war continued with the passing of many years and although countless thousands had died,<nlo>[...] The Qantari Servants of Power called upon the Gods of Chaos, who came forth like an eruption consuming the armies and fleets of men[...]";
		case 3: %text = "Then the High Magi summoned [...] beings, which have no king and deign superiority to all that came before them.<nlo>Moreover, immortality deifies them within the mortal domain, exalting them far beyond kings and champions.<nlo>They did then condemn the Gods of Chaos and their forces, casting them into the abyss, and breaking their malefic hold upon the land.";
		case 4: %text = "The cities did lay in ruin, the rivers did no longer flow, the mountains had tumbled, and the dead did strew the whole land.<nlo>The Wrath of Power brought down both the wicked kingdom of Qantaar and the glorious [...] Empire.<nlo>The Gods returned to their kingless realm, for everyone must go to the place from which he comes.";
		case 5: %text = "Something about the First of the Magi: he who built his ascent up to the sky, he who founded his vaulted dome above Maadoran, he who raised the mighty pillars...";
	}
	
	narratePhrase(%text);
}

function VCO_SRS_Shelves()
{
	%RDM = getRandom(0, 3);
	switch(%RDM)
	{
		case 0: %text = "You find nothing of interest.";
		case 1: %text = "Nothing but rat droppings.";
		case 2: %text = "The scrolls fall apart when you touch them.";
		case 3: %text = "The ink faded and disappeared a long time go.";
	}
	
	narratePhrase(%text);
}

function TRG_SRS_ApproachProspector()
{
	if(isInCombat() == false && aod.srs_prospectorThreat && isAlive(5800))
	{
		dlgSetAttitude(5800, 1, -10);
		sayPhrase(5800, "That's as far as you go!");
		dlgStartCombat();
		aod.srs_foughtProspector = true;
	}
	
	else if(isInCombat() && isAlive(5800) && aod.srs_foughtProspector == false)
	{
		dlgSetAttitude(5800, 1, -10);
		sayPhrase(5800, "That's as far as you go!");
		aod.srs_foughtProspector = true;
		aod.SRS_prospectorSeen = true;
	}
	
	else if(aod.SRS_prospectorSeen == false)
	{
		narratePhrase("By the looks of it, the ruins have been picked clean over the centuries and anything worth a few coppers has been stripped away or dug out a long time ago.<nlo><nlo>Yet as you get closer, you see a prospector sitting in front of a campfire.");
		sayPhrase(5800, "Come here!");
		aod.SRS_prospectorSeen = true;
	}
}

function TRG_SRS_TalkProspector()
{
	if(aod.srs_foughtProspector && isAlive(5800) && isInCombat() == false)
	{
		dlgStartCombat();
		sayPhrase(5800, "That's as far as you go!");
	}
	
	else if(isAlive(5800) && aod.srs_foughtProspector == false && aod.SRS_prospectorMet == false)
	{
		aod.SRS_prospectorMet = true;
		BlackSplash.command = "";
		BlackOut.command = "sd(Quest_Saross_01); startBlackSplash();";
		startBlackOut();
	}
}

function TRG_MTY_TalkToDaneus()
{
	if(aod.mty_TalkToDaneus == false && aod.mty_meetingRaiders)
	{
		sayPhrase(5854, "Talk to Daneus. He's back there.");
		aod.mty_TalkToDaneus = true;
	}
}

function TRG_MTY_SneakFront()
{
	if(aod.mty_sneakCaughtStarted == false && aod.mty_everyoneDead == false && isInCombat() == false)
	{
		BlackSplash.command = "";
		BlackOut.command = "dlgTeleportToMarker(TM_SneakCaught); sd(MTY_GuardSneak_01); startBlackSplash();";
		startBlackOut();
	}
}

function TRG_MTY_SneakBack_01()
{
	if(aod.mty_sneakCaughtStarted == false && aod.mty_everyoneDead == false && isInCombat() == false)
	{
		if(aod.sneak < 3)
		{
			aod.mty_sneakCaughtStarted = true;
			BlackSplash.command = "aod.mty_sneakCaughtStarted = false;";
			BlackOut.command = "dlgTeleportToMarker(TM_SneakCaught); sd(MTY_GuardSneak_01); startBlackSplash();";
			startBlackOut();
		}
		
		else if(aod.MTY_sneakReward1 == false)
		{
			narratePhrase("[sneak success] The guards are too distracted to see you sneaking into the building.");
			aod.MTY_sneakReward1 = true;
		}
	}
}

function TRG_MTY_SneakBack_02()
{
	if(aod.mty_sneakCaughtStarted == false && aod.mty_everyoneDead == false && isInCombat() == false)
	{
		if(aod.sneak < 4)
		{
			aod.mty_sneakCaughtStarted = true;
			BlackSplash.command = "aod.mty_sneakCaughtStarted = false;";
			BlackOut.command = "dlgTeleportToMarker(TM_SneakCaught); sd(MTY_GuardSneak_01); startBlackSplash();";
			startBlackOut();
		}
		
		else if(aod.MTY_sneakReward1 == false)
		{
			narratePhrase("[sneak success] The guards remain unaware of your presence.");
			aod.MTY_sneakReward1 = true;
		}
	}
}

function VCO_MTY_ElevatorTopOutside()
{
	BlackSplash.command = "";
	BlackOut.command = "dlgTeleportToMarker(TM_ElevatorBottom); startBlackSplash();";
	startBlackOut();
}

function VCO_MTY_ElevatorBottomOutside()
{
	BlackSplash.command = "";
	BlackOut.command = "dlgTeleportToMarker(TM_ElevatorTop); startBlackSplash();";
	startBlackOut();
}

function VCO_MTY_VaultEntrance()
{
	if(isInCombat() == false)
	{
		BlackOut.command = "switchMission(\"Monastery interior.mis\");";
		startBlackOut();
	}
	else
		narratePhrase("You can't leave right now.");
}

function VCO_MTY_VaultBigDoor()
{
	narratePhrase("You're standing in front of a huge round, rust-covered door.<nlo>It must weigh at least a thousand pounds and it can probably withstand anything you can throw at it.<nlo>You don't see anything that even remotely resembles a lock, so if you have to guess,<nlo>the door can only be opened from the other side.");
}

function VCO_MTY_VaultPlants01()
{
	narratePhrase("Cultivated plants.");
}

function VCO_MTY_VaultPlants02()
{
	narratePhrase("Mushrooms and fungi.");
}

function VCO_MTY_VaultVats()
{
	narratePhrase("Large vats filled with strange, strong-smelling, bubbling liquid.");
}

function VCO_MTY_VaultJars()
{
	narratePhrase("Shelves filled with rows of crude jars and bottles.<nlo>They are unmarked, so you assume that the villagers can tell them apart by smell or viscosity.");
}

function VCO_MTY_VaultMetalBarrels()
{
	narratePhrase("Old metal barrels filled with mysterious liquid.");
}

function VCO_MTY_VaultMetalTanks()
{
	narratePhrase("Strange metal tanks of unknown purpose.");
}

function VCO_MTY_VaultLabEquipment()
{
	narratePhrase("Various alchemical equipment; the crude glasswork suggests that these are replicas of the older sets.");
}

function VCO_MTY_VaultLabShelves()
{
	narratePhrase("The shelves contain nothing but work notes: daily production, usage, and storage.");
}

function VCO_MTY_VaultLibraryShelves_01()
{
	narratePhrase("Notes on hydro- and geoponics ... formulas for mineral solutions ... lists of reservoirs with growing solutions...");
}

function VCO_MTY_VaultLibraryShelves_02()
{
	narratePhrase("Water recycling and enrichment ... yield by year ... continuous-flow solutions ... aeration...");
}

function VCO_MTY_VaultLibraryShelves_03()
{
	narratePhrase("Mineral oil ... density gradient ... artificial photosynthesis ... catalytic water splitting...");
}
 
function VCO_ABY_DarkMachine()
{
	narratePhrase("The machine is dark and silent, but shows no sign of damage.");
}

function VCO_ABY_TankGlass()
{
	narratePhrase("The creature is still there, its eyes remain vacant.");
}

function VCO_ABY_PerceptionSearch()
{
	if(aod.per < 8 && aod.quest_abyss_foundText == false)
	{
		narratePhrase("[failure] You find nothing of interest.");
	}
	
	else if(aod.lore < 6 && aod.quest_abyss_foundText)
	{
		narratePhrase("[failure] The language is unknown to you.");
	}
	
	else
	{
		BlackSplash.command = "";
		BlackOut.command = "sd(Quest_Abyss_04_Perception); startBlackSplash();";
		startBlackOut();
	}
}

function VCO_CTR_leaveFort()
{
	BlackSplash.command = "";
	BlackOut.command = "disconnect(); startBlackSplash();";
	startBlackOut();
}

function TRG_TBC_TalkToEsbenus()
{
	if(aod.tbc_TalkToEsbenus == false && aod.tbc_meetingBandits && aod.quest_teronRaider_finished == false)
	{
		sayPhrase(1555, "Talk to Esbenus. He's back there.");
		aod.tbc_TalkToEsbenus = true;
	}
}

function TRG_TBC_SeeCamp()
{
	if(aod.quest_teronRaider_FirstSight == false) 
	{
		aod.quest_teronRaider_FirstSight = true;
		if(aod.quest_teronRaider_finished == false)
			narratePhrase("You enter a small camp in a forest clearing.<nlo>Rough boards nailed to the nearby trees form a crude perimeter fence.<nlo>Inside the fence there are several patched up tents, a campfire, and a metal cage hanging from a makeshift gallows.<nlo>The cage is occupied by a roughed up man in a dirty tunic.");
		
		else
			narratePhrase("This camp has been abandoned a long time ago.");
	}
}

function numberToWritten(%number)
{
	switch(%number)
	{
		case 0: return $textbox_writtenNumber0;
		case 1: return $textbox_writtenNumber1;
		case 2: return $textbox_writtenNumber2;
		case 3: return $textbox_writtenNumber3;
		case 4: return $textbox_writtenNumber4;
		case 5: return $textbox_writtenNumber5;
		case 6: return $textbox_writtenNumber6;
		case 7: return $textbox_writtenNumber7;
		case 8: return $textbox_writtenNumber8;
		case 9: return $textbox_writtenNumber9;
		case 10: return $textbox_writtenNumber10;
		default:
			warn("numberToWritten - number out of range: " @ %number @ "!");
	}
}