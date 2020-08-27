package QuestWellChamberEvents
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
		
		if(aod.mdn_theWell_insideChamber == false)
			sd(MDN_theWell_02);
		
		if(aod.mty_fromWellChamber)
		{
			aod.mty_fromWellChamber = 0;
			dlgTeleportToMarker(TM_Chamber_03);
			dlgCam(190, 45, 10);
			VCO_Tube.setCursor("StealCursor");
			VCO_Tube.setCursorText(3);
		}
	}
	
	function onEndCombat()
	{
		apmsPlayMusic(custom, 4, 1);
		
		if(isalive())
		{
			// For Custom Death Screens
			
			deactivateDeathDesc();
		}
	}
	
	function onLeaveLocation()
	{
		globalOnLeaveLocation();
	}
	
	function VCO_MDN_WellChamberStrongbox()
	{
		if(aod.lockpick >= 4)
		{
			if(aod.lore >= 5)
			{
				dlgAddItem(904, 1);
				narratePhrase("[success] [lore success] The lock protests and resists your every move, but you both know that it's all for show.<nlo>It throws in the towel in less than two minutes, revealing a treasure trove of relics:<nlo>two power tubes, a respirator, and a dozen of blue steel ingots.");
			}
			else if(aod.artefact_respirator1_identified)
			{
				dlgAddItem(904, 1);
				narratePhrase("[success] The lock protests and resists your every move, but you both know that it's all for show.<nlo>It throws in the towel in less than two minutes, revealing a treasure trove of relics:<nlo>two power tubes, a respirator, and a dozen of blue steel ingots.");
			}
			else
			{
				dlgAddItem(903, 1);
				narratePhrase("[success] The lock protests and resists your every move, but you both know that it's all for show.<nlo>It throws in the towel in less than two minutes, revealing a treasure trove of relics:<nlo>two power tubes, a strange mask, and a dozen of blue steel ingots.");
			}
			
			dlgAddItemList(MDN_WellChamber_Strongbox);
			rwd_civil(Lockpick);
			VCO_Strongbox_02.setActive(0);
		}
		else
			narratePhrase("[failure] You try to pick the lock but fail miserably.");
	}
	
	function getMenesBag()
	{
		dlgAddItemlist(MDN_WellChamber_Bag);
		aod.mdn_theWell_gotBag = false; 
		narratePhrase("You examine the content of Menes' bag, helping yourself to some gold coins and a dozen of blue steel ingots.");
	}
	
	function VCO_MDN_wellChamberDebris_02()
	{
		if(aod.mdn_wellChamber_debris_02_explored == false)
		{
			aod.mdn_wellChamber_debris_02_explored = true;
			
			if(aod.per >= 9)
			{
				narratePhrase("You look around for something valuable, leaving no stone unturned.<nlo>Your dedication is rewarded with a few iron balls, some alchemical compounds, and a small dusty bottle with a dark red liquid.");
				dlgAddItem(1807, 1);
				dlgAddItem(1810, 3);
				dlgAddItem(1812, 2);
				dlgAddItem(1816, 3);
			}
			else if(aod.per >= 7)
			{
				narratePhrase("You look around for something valuable, leaving no stone unturned.<nlo>Your dedication is rewarded with a few iron balls and some alchemical compounds.");
				dlgAddItem(1810, 3);
				dlgAddItem(1812, 2);
				dlgAddItem(1816, 3);
			}
			else
			{
				narratePhrase("You look around for something valuable, but find only a few iron balls, their purpose unknown.");
				dlgAddItem(1816, 2);
			}
		}
		else
			narratePhrase("There's nothing else here.");
	}
	
	function VCO_Well_Lamp()
	{
		if(VCO_Tube.isCursorTextDefault()) // cursorText $= "Strange Device"
		{
			if(aod.lore >= 4)
			{
				VCO_Tube.setCursorText(8);
				
				if(dlgOwnsItem(1610))
					narratePhrase("It looks like a large glass lamp: a glass tube - or what's left of it - enclosed in a rusty metal cage designed to protect the glass from damage.<nlo>Unfortunately, the device wasn't designed to withstand a cave-in and the glass is cracked and broken in places. It's still glowing though.<nl><nl>It's similar to the one you have. The stories mentioned that the ancients knew how to capture and store the power of the sun.<nlo>The drawings that illustrated such tales pictured small suns, shining brightly in magical cages held by wise and noble Magi.<nlo>The reality has proven to be far less glamorous - some broken glass in a rusted, bent cage.");
				else
					narratePhrase("It looks like a large glass lamp: a glass tube - or what's left of it - enclosed in a rusty metal cage designed to protect the glass from damage.<nlo>Unfortunately, the device wasn't designed to withstand a cave-in and the glass is cracked and broken in places. It's still glowing though.<nl><nl>You've heard of such devices before, but never seen one up until now. The stories mentioned that the ancients knew how to capture and store the power of the sun.<nlo>The drawings that illustrated such tales pictured small suns, shining brightly in magical cages held by wise and noble Magi.<nlo>The reality has proven to be far less glamorous - some broken glass in a rusted, bent cage.");
			}
			else if(dlgOwnsItem(1610))
			{
				VCO_Tube.setCursorText(8);
				narratePhrase("It looks like a large glass lamp: a glass tube - or what's left of it - enclosed in a rusty metal cage designed to protect the glass from damage.<nlo>Unfortunately, the device wasn't designed to withstand a cave-in and the glass is cracked and broken in places. It's still glowing though.<nl><nl>It's similar to the one you have.");
			}
			else
				narratePhrase("It looks like a large glass lamp: a glass tube - or what's left of it - enclosed in a rusty metal cage designed to protect the glass from damage.<nlo>Unfortunately, the device wasn't designed to withstand a cave-in and the glass is cracked and broken in places.<nlo>It's still glowing though, so it must have been a really good lamp.");
		}
		else if(VCO_Tube.getCursorTextID() == 8) // Remove the cover.
		{
			narratePhrase("You remove the protective cover.");
			VCO_Tube.setCursor("StealCursor");
			VCO_Tube.setCursorText(4);
		}
		else if(VCO_Tube.getCursorTextID() == 3) // Remove the power tube.
		{
			narratePhrase("You remove the tube from its socket and the portal stops glowing.");
			dlgAddItem(1610, 1);
			OBJ_Portal.hideObjects();
			VCO_Tube.setCursor("StealCursor");
			VCO_Tube.setCursorText(4);
			VCO_Portal.setActive(0);
			VCO_Doorway.setActive(1);
			aod.mdn_theWell_portalActive = 0;
		}
		else if(VCO_Tube.getCursorTextID() == 4 && dlgOwnsItem(1610)) // Place a power tube.
		{
			narratePhrase("The portal powers up with a low, steady humming sound. The inside of the frame starts glowing, the air flickers,<nlo>and suddenly a blue light fills up the doorway, forming a glowing wall emitting a strange sound.");
			dlgRemoveItem(1610, 1);
			OBJ_Portal.showObjects();
			VCO_Tube.setCursor("StealCursor");
			VCO_Tube.setCursorText(3);
			VCO_Portal.setActive(1);
			VCO_Doorway.setActive(0);
			aod.mdn_theWell_portalActive = 1;
		}
		else if(VCO_Tube.getCursorTextID() == 4 && dlgOwnsItem(1610) == false) // Try to place a power tube.
			narratePhrase("You don't have anything to power it up with.");
	}
	
	function VCO_Well_Portal()
	{
		aod.mty_fromWellChamber = 1;
		BlackOut.command = "switchMission(\"Monastery Interior Chamber.mis\");";
		startBlackOut();
	}
};

useEventPackage(QuestWellChamberEvents);