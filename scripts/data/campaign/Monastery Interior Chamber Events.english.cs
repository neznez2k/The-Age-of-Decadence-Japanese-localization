package MonasteryInteriorChamberEvents
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
		if(aod.mty_chamberintroDone == 0)
		{
			aod.mty_chamberintroDone = 1;
			apmsStartDialogue(MTY_Exploration_01); 
		}
		
		if(aod.MTY_medical_discovered == 0)
			aod.MTY_medical_discovered = 1;
		
		if(aod.god_ritual_ready == 1)
		{
			aod.god_ritual_ready = 2;
			createByCharMarker("CM_Bennie");
			dlgTeleportToMarker(TM_Bennie_PC);
			apmsStartDialogue(Quest_God_MTY);
		}
		
		if(aod.mty_fromHellgate)
		{
			aod.mty_fromZamedi = 0;
			aod.mty_fromWellChamber = 0;
		}
		else if(aod.mty_fromZamedi)
		{
			aod.mty_fromHellgate = 0;
			aod.mty_fromWellChamber = 0;
		}
		else if(aod.mty_fromWellChamber)
		{
			aod.mty_fromHellgate = 0;
			aod.mty_fromZamedi = 0;
		}
		
		//*************** Party Settings ****
		//***********************************
	}
	
	function onStartCombat()
	{
		
	}
	
	function onEndCombat()
	{
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
	
	function MTY_chamber_tank()
	{
		aod.MTY_chamber_exploration = 1;
		BlackSplash.command = "";
		BlackOut.command = "sd(MTY_Exploration_01); startBlackSplash();";
		startBlackOut();
	}
	
	function MTY_chamber_scrolls()
	{
		BlackSplash.command = "";
		BlackOut.command = "sd(MTY_MShelves_01); startBlackSplash();";
		startBlackOut();
	}
	
	function MTY_chamber_healingMachine()
	{
		BlackSplash.command = "";
		BlackOut.command = "sd(MTY_healingMachine_01); startBlackSplash();";
		startBlackOut();
	}
	
	function MTY_chamber_console()
	{
		BlackSplash.command = "";
		BlackOut.command = "sd(MTY_Console_01); startBlackSplash();";
		startBlackOut();
	}
	
	function VCO_Strongbox(%Value)
	{
		if(aod.lockpick >= %Value)
		{
			narratePhrase("[success] You succesfully pick the lock.");
			rwd_civil(Lockpick);
			VCO_Strongbox.setActive(0);
		}
		else
			narratePhrase("[fail] You failed picking the lock.");
	}
	
	function VCO_MTY_VaultBigDoorInside()
	{
		narratePhrase("You're standing in front of a huge, rust-covered door that's been welded shut from the inside.<nlo>It must weigh at least a thousand pounds and it can probably withstand anything you can throw at it.");
	}
	
	function MTY_chamberVats()
	{
		if(aod.MTY_canisterLearned == false || dlgOwnsItem(2250) || aod.MTY_canisterTaken)
			narratePhrase("The vats are filled with strange canisters, long past their expiration date.");
		else
		{
			narratePhrase("The vats are filled with strange canisters, long past their expiration date.<nlo>You grab a canister with the compound mentioned in the scrolls. Never know when it might come in handy.");
			dlgAddItem(2250, 1);
			aod.MTY_canisterTaken = 1;
		}
	}
	
	function MTY_chamberPortal()
	{
		if(aod.mty_fromHellgate)
		{
			BlackOut.command = "switchMission(\"Hellgate Underground.mis\");";
			startBlackOut();
		}
		else if(aod.mty_fromZamedi)
		{
			BlackOut.command = "switchMission(\"The Tower.mis\");";
			startBlackOut();
		}
		else if(aod.mty_fromWellChamber)
		{
			BlackOut.command = "switchMission(\"Quest_WellChamber.mis\");";
			startBlackOut();
		}
	}
};

useEventPackage(MonasteryInteriorChamberEvents);