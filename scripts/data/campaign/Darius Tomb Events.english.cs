package DariusTombEvents
{
	function onInitLocation()
	{
		addJournalLocation(Tomb);
	}
	
	function onLoadLocation()
	{
		apmsPlayMusic(custom, 11, 1); // Desert Places
		
		if(aod.quest_dariusTomb_tombOpen)
		{
			setPassability(42, 108, 0, 1);
			RealTomb.showObjects();
			Tomb_Interior_03.IsRenderEnabled = false;
			TombChamberObj_01.setActive(true);
			TombChamberObj_02.setActive(true);
			TombChamberObj_03.setActive(true);
			TombDoor_01.setActive(false);
		}
		else
			setPassability(42, 108, 0, 0);
		
		if(aod.quest_dariusTomb_gaeliusMen && aod.quest_dariusTomb_tombOpen == false)
		{
			createByCharMarker("CM_Tomb_Gaelius_Man_01");
			createByCharMarker("CM_Tomb_Gaelius_Man_02");
			createByCharMarker("CM_Tomb_Gaelius_Man_03");
			createByCharMarker("CM_Tomb_Gaelius_Man_04");
		}
		
		aod.global_atTeron = false; //TEMP, should be removed when the outpost and the bandit camp become their own locations.
	}
	
	function onGameplayStart()
	{
		if(aod.quest_dariusTomb_firstVisit == false)
		{
			addParty(DariusTomb_Raiders, 0);
			addCharToParty(5045, "DariusTomb_Raiders", "fighter");
			addCharToParty(5046, "DariusTomb_Raiders", "fighter");
			addCharToParty(5047, "DariusTomb_Raiders", "fighter");
			addCharToParty(5048, "DariusTomb_Raiders", "fighter");
			addCharToParty(5049, "DariusTomb_Raiders", "fighter");
			addCharToParty(5050, "DariusTomb_Raiders", "fighter");
			aod.quest_dariusTomb_firstVisit = true;
			rwd_location(DariusTomb);
			apmsStartDialogue(Quest_DariusTomb_01);
		}
		
		if(aod.quest_dariusTomb_gaeliusMen && aod.quest_dariusTomb_tombOpen == false)
		{
			dlgTeleportToMarker(TM_NPC_Door_01, 5051);
			dlgTeleportToMarker(TM_NPC_Door_02, 5052);
			dlgTeleportToMarker(TM_NPC_Door_05, 5053);
			dlgTeleportToMarker(TM_NPC_Door_06, 5054);
			apmsStartDialogue(Quest_DariusTomb_02);
		}
		
		//*************** Party Settings ****
		//***********************************
	}
	
	function onStartCombat()
	{
		if(aod.quest_dariusTomb_tombOpen)
		{
			TombChamberObj_01.setActive(0);
			TombChamberObj_02.setActive(0);
			TombChamberObj_03.setActive(0);
		}
	}
	
	function onEndCombat()
	{
		apmsPlayMusic(custom, 11, 1); // Desert Places
		
		if (isalive() == true)
		{
			
			if(aod.quest_dariusTomb_tombOpen)
			{
				TombChamberObj_01.setActive(1);
				TombChamberObj_02.setActive(1);
				TombChamberObj_03.setActive(1);
			}
			
			// For Custom Death Screens
			
			deactivateDeathDesc();
		}
	}
	
	function onLeaveLocation()
	{
		globalOnLeaveLocation();
	}
	
	function VCO_SecretDoor()
	{
		BlackSplash.command = "";
		BlackOut.command = "sd(quest_dariusTomb_02); startBlackSplash();";
		startBlackOut();
	}
	
	function TRG_tomb_01()
	{
		if(aod.DRS_tombDescription == 0)
		{
			narratePhrase("The chamber is lit by a strange blue light, emanating from glowing semi-spheres mounted on the walls.<nlo>Even though this tomb is crude and was built long after the Empire fell,<nlo>it's clear that the post-war era had seen an abundance of arcane artefacts.");
			aod.DRS_tombDescription = 1;
		}
	}
	
	function TRG_tomb_02()
	{
		if(aod.DRS_tombDescription == 1)
		{
			narratePhrase("You see two strange devices near the opposite walls of the chamber.<nlo>They look like heavy chests, but it doesn't seem like they were designed to ever be opened.<nlo>There are some figurines at the top, but their purpose is unclear.<nlo>Maybe they were brought here for safekeeping.");
			aod.DRS_tombDescription = 2;
		}
	}
	
	function TRG_IntCheck()
	{
		if(isInCombat() == false)
		{
			if(aod.DRS_hallwayDescription == 3 && aod.quest_dariusTomb_foundDoor == 0 && aod.per >= 6 && aod.int >= 8)
			{
				aod.quest_dariusTomb_foundDoor = true;
				aod.quest_dariusTomb_int = true;
				BlackSplash.command = "";
				BlackOut.command = "sd(quest_dariusTomb_02); startBlackSplash();";
				startBlackOut();
			}
		}
	}
	
	function TRG_PerCheck()
	{
		if(isInCombat() == false)
		{
			if(aod.DRS_hallwayDescription == 3 && aod.quest_dariusTomb_foundDoor == 0 && aod.per >= 8)
			{
				aod.quest_dariusTomb_foundDoor = true;
				aod.quest_dariusTomb_per = true;
				BlackSplash.command = "";
				BlackOut.command = "sd(quest_dariusTomb_02); startBlackSplash();";
				startBlackOut();
			}
		}
	}
	
	function TRG_Hallway_01()
	{
		if(aod.DRS_hallwayDescription == 0)
		{
			narratePhrase("You're standing in a small chamber.<nlo>It's hard to tell what role it played in the past, but in this more enlightened and practical age, it's mostly a sleeping hall doubling up as storage.<nlo>Two crude half walls split the chamber in half, creating a narrow and easily defended entrance point.");
			aod.DRS_hallwayDescription = 1;
		}
	}
	
	function TRG_Hallway_02()
	{
		if(aod.DRS_hallwayDescription == 1)
		{
			narratePhrase("The corridor branches off here, but it's clear that the branch caved in a long time ago.<nlo>If that's where Darius is buried, he's out of reach now.");
			aod.DRS_hallwayDescription = 2;
		}
	}
	
	function TRG_Hallway_03()
	{
		if(aod.DRS_hallwayDescription == 2)
		{
			narratePhrase("This was a burial chamber once, but as Gaelius noted, resting in peace has become something of a luxury these days.<nlo>The occupant of the heavy sarcophagus was thrown out a long time ago, to spend the rest of his afterlife under the scorching sun.<nlo>Now the sarcophagus is home to the raiders' most prized possessions.<nlo>The rest is kept in boxes, barrels, and chests filling up the room.");
			aod.DRS_hallwayDescription = 3;
		}
	}
};

useEventPackage(DariusTombEvents);