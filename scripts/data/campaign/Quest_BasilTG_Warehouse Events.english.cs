package QuestBasilTGWarehouseEvents
{
	function onInitLocation()
	{

	}
	
	function onLoadLocation()
	{
		//apmsPlayMusic(custom, 1, 1);
	}
	
	function onGameplayStart()
	{
		setCombatAllowed(0);
		
		if(aod.quest_BasilTG_WarehouseIntroDone == 0)
		{
			aod.quest_BasilTG_WarehouseIntroDone = 1;
			sd(MDN_Quest_BasilTG_Warehouse);
		}
		
		//*************** Party Settings ****
		//***********************************
		
		addParty(BasilTGBoss, 0);
		addCharToParty(5155, BasilTGBoss, fighter);
		addCharToParty(5156, BasilTGBoss, fighter);
		addCharToParty(5157, BasilTGBoss, fighter);
	}
	
	function onStartCombat()
	{
		//apmsStopMusic(); apmsPlayMusic(custom, 2, 1);
		VCO_Exit.setActive(0);
	}
	
	function onEndCombat()
	{
		//apmsPlayMusic(custom, 1, 1);
		
		if(isalive())
		{
			VCO_Exit.setActive(1);
			rwd_reputation(BasilTG_03);
			if(aod.fight_basilTG_boss)
			{
				rwd_fight(BasilTG_03);
				aod.fight_basilTG_boss = 0;
			}
			
			// For Custom Death Screens
			
			deactivateDeathDesc();
		}
	}
	
	function onLeaveLocation()
	{
		globalOnLeaveLocation();
	}
	
	function VCO_LeaveWarehouse()
	{
		BlackOut.command = "switchMission(\"Maadoran.mis\");";
		startBlackOut();
	}
	
	function mapScreenButtonScripts()
	{
		MessageBoxYesNo("Warehouse", "Leave the warehouse?", "VCO_LeaveWarehouse();", "");
	}
};

useEventPackage(QuestBasilTGWarehouseEvents);