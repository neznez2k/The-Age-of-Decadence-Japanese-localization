package MDNSkyEvents
{
	function onInitLocation()
	{
		setAchievement("ACH_SKY_CITY");
	}
	
	function onLoadLocation()
	{
		apmsPlayMusic(custom, 4, 1);
		
		blockTraveling(true);
	}
	
	function onGameplayStart()
	{
		if(aod.MDN_Sky_MagusTower_IntroDone == false)
		{
			sd(MDN_Sky_MagusTower_Intro);
			aod.MDN_Sky_MagusTower_IntroDone = true;
			aod.jnl_inferiae_end_01 = true;
			aod.mdn_Sky_MagusTower_tube = 1;
			aod.mdn_Sky_MagusTower_visited = 1;
		}
		
		
		//*************** Party Settings ****
		//***********************************
	}
	
	function onStartCombat()
	{
		apmsPlayMusic(custom, 4, 1);
	}
	
	function onEndCombat()
	{
		apmsPlayMusic(custom, 4, 1);
		
		if (isalive() == true)
		{
			
			// For Custom Death Screens
			
			deactivateDeathDesc();
		}
	}
	
	function onLeaveLocation()
	{
		globalOnLeaveLocation();
	}
	
	function VCO_MDN_MagusTower_tube()
	{
		if(VCO_Tube.isCursorTextDefault()) // cursorText $= "Examine the lamp".
		{
			narratePhrase("You remove the protective cover and discover a large, softly glowing tube. It looks similar to power tubes, but much bigger.");
			VCO_Tube.setCursor("StealCursor");
			VCO_Tube.setCursorText(3);
		}
		else if(VCO_Tube.getCursorTextID() == 3) // Remove the power tube.
		{
			narratePhrase("You remove the tube from its socket and the portal stops glowing.");
			dlgAddItem(1610, 1);
			OBJ_Portal.hideObjects();
			VCO_Tube.setCursor("StealCursor");
			VCO_Tube.setCursorText(4);
			VCO_Portal.setActive(0);
			aod.mdn_Sky_MagusTower_tube = 2;
		}
		else if(VCO_Tube.getCursorTextID() == 4 && dlgGetItemsCount(1610) >= 1) // Place a power tube.
		{
			narratePhrase("The portal powers up with a low, steady humming sound.<nlo>The inside of the frame starts glowing, the air flickers, and suddenly a blue light fills up the doorway, forming a glowing wall emitting a strange sound.");
			dlgRemoveItem(1610, 1);
			OBJ_Portal.showObjects();
			VCO_Tube.setCursor("StealCursor");
			VCO_Tube.setCursorText(3);
			VCO_Portal.setActive(1);
			aod.mdn_Sky_MagusTower_tube = 1;
		}
		else if(VCO_Tube.getCursorTextID() == 4 && dlgGetItemsCount(1610) < 1) // Place a power tube.
		{
			narratePhrase("You don't have anything to power it up with.");
		}
	}
	
	function VCO_MDN_MagusTower_message()
	{
		if(aod.lore >= 6)
		{
			narratePhrase("[success] The message is hastily written; many words are smudged or faded. The magus was dying from wounds sustained during the attack on his tower, so clarity wasn't at the top of his priorities.<nlo><nlo>\"Balzaar attacked ... has fallen. He's too powerful. I couldn't stop him. All my defenses ... He's coming for you ...<nlo>You must do it before it's too late. Don't hesitate for the price we have already paid is too great.<nlo>... wait any longer, there will be nothing left.\"");
			if(aod.mdn_magusTowerMessageSeen == false)
			{
				addLore(23);
				aod.mdn_magusTowerMessageSeen = true;
			}
		}
		else
			narratePhrase("[failure] As far as you can tell, the message says something about someone named Balzaar who's grown too powerful and resentful<nlo>and is urging the unknown recipient to take action before it's too late.");
	}

	function VCO_MDN_MagusTower_glove()
	{
		if(aod.artefact_metalglove_identified)
		{
			narratePhrase("It's an artefact called the Ghost Hand. It was said that some machines could never function in this world for they required different laws of physics. Thus, the Magi had built them in realms that exist elsewhere.<nlo>They called them the Ghost Worlds and used devices such as this one to bridge the gap between these worlds and ours.");
			dlgAddItem(2191, 1);
			VCO_Glove.setActive(false);
			OBJ_Glove.hideObjects();
		}
		else
		{
			narratePhrase("It's a strange, metal glove of unknown purpose. It takes three 'tubes' to power it up, so whatever the glove does requires a lot of magical energy.");
			dlgAddItem(2190, 1);
			VCO_Glove.setActive(false);
			OBJ_Glove.hideObjects();
		}
	}

	function VCO_MDN_MagusTower_Portal()
	{
		aod.inf_fromPortal = true;
		BlackOut.command = "switchMission(\"Inferiae Tower.mis\");";
		startBlackOut();
	}
};

useEventPackage(MDNSkyEvents);