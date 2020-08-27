package MonasteryInteriorEvents
{
	function onInitLocation()
	{
		
	}
	
	function onLoadLocation()
	{
		apmsPlayMusic(custom, 4, 1);
		blockTraveling(true);
	}
	
	function onGameplayStart()
	{
		if(aod.mty_introDone == false)
		{
			//aod.mty_introDone = true;
			//apmsStartDialogue(MTY_Intro_01); 
			//aod.mty_meetingRaiders = true;
		}
		
		//*************** Party Settings ****
		//***********************************
		
		if(aod.mty_RaidersWon && aod.mty_metDaneusInside == false)
		{
			dlgTeleportToMarker(TM_Start_Daneus);
			createByCharMarker(CM_Monastery_Invader_01);
			createByCharMarker(CM_Monastery_Invader_02);
			createByCharMarker(CM_Monastery_Invader_03);
			addParty(MonasteryRaidersInterior, 0);
			addCharToParty(5851, "MonasteryRaidersInterior", "fighter");
			addCharToParty(5854, "MonasteryRaidersInterior", "fighter");
			addCharToParty(5856, "MonasteryRaidersInterior", "fighter");
			aod.mty_metDaneusInside = true;
			dlgAddItem(1802, 1, 5856);
			apmsStartDialogue(MTY_Raiders_01); 
		}
		
		if(aod.mty_VillagersWon && aod.mty_everyoneDead == false && aod.mty_brokeInside == false)
		{
			aod.mty_brokeInside = true;
		}
	}
	
	function onStartCombat()
	{
		VCO_Elevator_1F.setActive(0);
		VCO_Elevator_2F.setActive(0);
	}
	
	function onEndCombat()
	{
		VCO_Elevator_1F.setActive(1);
		VCO_Elevator_2F.setActive(1);
		apmsPlayMusic(custom, 4, 1);
		
		if (isalive() == true)
		{
			if(aod.fight_mty_monasteryRaidersInterior)
			{
				aod.fight_mty_monasteryRaidersInterior = false;
				rwd_fight(Monastery_04);
			}
			
			// For Custom Death Screens
			
			deactivateDeathDesc();
		}
	}
	
	function onLootScreenClose()
	{
		if(dlgGetItemsCount(1802) >= 1 && aod.jnl_elixir < 7)
		{
			aod.jnl_elixir = 5;
		}
	}
	
	function VCO_MTY_ElixirStrongbox()
	{
		if(aod.mty_elixirStrongBoxExamined == false)
		{
			if(aod.mty_RaidersWon)
			{
				narratePhrase("The strongbox stands wide open, looted by the raiders.");
			}
			
			else
			{
				aod.mty_elixirStrongBoxExamined = true;
				narratePhrase("It lacks decorations of any kind and you don't see anything even remotely resembling a lid, but you see a keyhole, which tells you all you need to know about it.");
				VCO_ElixirStrongbox.setCursor("LockpickCursor");
				VCO_ElixirStrongbox.setCursorText(6);
			}
		}
		
		else if(dlgOwnsItem(2405))
		{
			VCO_ElixirStrongbox.setActive(0);
			narratePhrase("You use the key to open the strongbox. Inside you find several vials, including the elixir you came here for.");
			dlgAddItem(1802, 1);
			aod.mty_stoleElixir = true;
			aod.jnl_elixir = 5;
		}
		
		else if(aod.lockpick >= 6)
		{
			VCO_ElixirStrongbox.setActive(0);
			narratePhrase("[success] The lock protests and resists your every move, but you both know that it's all for show.<nlo>It throws in the towel in less than two minutes, opening the bowels of the strongbox to you. You see several vials, including the elixir you came here for.");
			rwd_civil(Lockpick);
			dlgAddItem(1802, 1);
			aod.mty_stoleElixir = true;
			aod.jnl_elixir = 5;
		}
		else
			narratePhrase("[failure] You try to pick the lock but fail miserably.");
	}
	
	function onLeaveLocation()
	{
		globalOnLeaveLocation();
	}
};

useEventPackage(MonasteryInteriorEvents);