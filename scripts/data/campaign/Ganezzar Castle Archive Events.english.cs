package levelEvents
{
	function onInitLocation()
	{
		
	}
	
	function onLoadLocation()
	{
		
	}
	
	function onGameplayStart()
	{
		setTravelingAllowed(false);
		setCombatAllowed(false);
		
		//*************** Party Settings ****
		//***********************************
	}
	
	function onEndCombat()
	{
		
		
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
	
	function VCO_Scrolls()
	{
		sdFade(GNZ_Archive_Scrolls_01);
	}
	
	function VCO_Console()
	{
		narratePhrase("It doesn't seem to be working.");
	}
	
	function VCO_Ganezzar()
	{
		aod.gnz_startPosition_castleExterior = 1;
		BlackOut.command = "switchMission(\"Ganezzar.mis\");";
		startBlackOut();
	}
};

useEventPackage(levelEvents);