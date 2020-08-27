package GanezzarCastleBasementTunnelsEvents
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
		setCombatAllowed(false);
		
		//*************** Party Settings ****
		//***********************************
		
		addParty(GNZ_CastleTunnels_Guards, 0);
		addCharToParty(6265, "GNZ_CastleTunnels_Guards", "fighter");
		addCharToParty(6266, "GNZ_CastleTunnels_Guards", "fighter");
		
		if(aod.gnz_tunnels_leakFixed)
			VCO_LeakControl.setActive(0);
	}
	
	function onEndCombat()
	{
		apmsPlayMusic(custom, 4, 1);
		
		if(isalive())
		{
			rwd_fight(TG7_02);
			
			if(aod.quest_TG7_status == 5)
				VCO_Door_6.setActive(1);
			
			// For Custom Death Screens
			
			deactivateDeathDesc();
		}
	}
	
	function onLeaveLocation()
	{
		globalOnLeaveLocation();
	}
	
	function gnz_tunnelTrapSpot(%ValueTraps, %ValuePer, %Trap)
	{
		if(aod.traps >= %ValueTraps || aod.per >= %ValuePer)
		{
			if(aod.traps >= %ValueTraps)
				narratePhrase("[traps success] You spot a trap!");
			else if(aod.per >= %ValuePer)
				narratePhrase("[perception success] You spot a trap!");
			
			eval("VCO_Trap_" @ %Trap @ "_Trigger.setActive(1);");
			eval("setObjectRenderState(OBJ_Trap_" @ %Trap @ "_Trigger, 1);"); 
			eval("aod.gnzTunnels_Trap_" @ %Trap @ "_spotted = true;");
		}
	}
	
	function gnz_tunnelTrapDisarm(%Value, %HP, %MaxHP, %Trap)
	{
		if(aod.traps >= %Value)
		{
			narratePhrase("[traps success] You manage to disarm the trap.");
			eval("VCO_Trap_" @ %Trap @ "_Trigger.setActive(0);");
			eval("setObjectRenderState(OBJ_Trap_" @ %Trap @ "_Trigger, 0);"); 
			eval("aod.gnzTunnels_Trap_" @ %Trap @ "_disarmed = true;");
		}
		else if(%Value - aod.traps == 1)
			narratePhrase("[traps failure] You fail to disarm the trap.");
		else
		{
			narratePhrase("[traps critical failure] You trigger the trap!");
			gnz_tunnelTrapTrigger(%HP, %MaxHP, %Trap);
		}
	}
	
	function gnz_tunnelTrapTrigger(%HP, %MaxHP, %Trap)
	{
		if(dlgGetCharacterHP() > %HP)
		{
			narratePhrase("[traps failure] You trigger a trap and take a bolt to the gut.");
			eval("VCO_Trap_" @ %Trap @ "_Trigger.setActive(0);");
			eval("setObjectRenderState(OBJ_Trap_" @ %Trap @ "_Trigger, 0);"); 
			eval("aod.gnzTunnels_Trap_" @ %Trap @ "_disarmed = true;");
			dlgAddTextBoxMessage("You lose " @ %HP @ " hit points!");
			dlgAddTextBoxMessage("Constitution is reduced by 1.");
			dlgAddStatPenalty("con", 1);
			trapOnHit(%HP);
			//dlgSetAnimation(anim_washit_back, 0, 1);
			//schedule(200, 0, dlgSetAmbientAnimation);
			eval("aod.gnzTunnels_Trap_" @ %Trap @ "_triggered = true;");
		}
		else
		{
			aod.death_traps_01 = true;
			trapDeath();
		}
	}
	
	function gnz_tunnelsLeakControl()
	{
		if(aod.gnz_tunnels_leakFixed == 0 && aod.lore >= 8)
		{
			narratePhrase("[success] You manage to fix the leak.");
			aod.gnz_tunnels_leakFixed = 1;
			VCO_LeakControl.setActive(0);
			rwd_civil(GNZ_Castle_Basement_Tunnels_01);
		}
		else
			narratePhrase("[failure] You have no idea how to fix the leak.");
	}
	
	function gnz_tunnelsRadiation(%Value, %Type)
	{
		if(aod.gnz_tunnels_leakFixed == 0)
			aod.gnz_tunnels_radiation = aod.gnz_tunnels_radiation + %Value;

		if(aod.gnz_tunnels_radiation >= 6 && dlgGetCharacterHP() > 1)
		{
			dlgChangeCharacterHP(-1);
			narratePhrase("You are feeling weaker.");
			aod.gnz_tunnels_radiation = aod.gnz_tunnels_radiation - 6;
			
			if(%Type == 1)
			{
				dlgChangeMaxHp(-1);
				dlgAddTextBoxMessage("You lose one maximum hit point!");
			}
		}
		else if(aod.gnz_tunnels_radiation >= 6 && dlgGetCharacterHP() == 1)
		{
			dlgChangeMaxHp(-1);
			narratePhrase("You are feeling extremely weak.");
			dlgAddTextBoxMessage("You lose one maximum hit point!");
			aod.gnz_tunnels_radiation = 0;
		}
	}
	
	function gnz_CastleTunnels_goToCityTunnels()
	{
		aod.gnz_tunnels_fromCastle = true;
		BlackOut.command = "switchMission(\"Ganezzar Tunnels.mis\");";
		startBlackOut();
	}
	
	function gnz_tunnels_goToTG()
	{
		BlackOut.command = "switchMission(\"Ganezzar TG.mis\");";
		startBlackOut();
	}
};

useEventPackage(GanezzarCastleBasementTunnelsEvents);