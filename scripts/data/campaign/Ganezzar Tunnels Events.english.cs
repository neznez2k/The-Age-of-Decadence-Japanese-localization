package GanezzarTunnelsEvents
{
	function onInitLocation()
	{

	}
	
	function onLoadLocation()
	{
		//apmsPlayMusic(custom, 5, 1);
	}
	
	function onGameplayStart()
	{
		if(aod.gnz_tunnels_intro == 0)
		{
			dlgSetAnimation(anim_death_back00, 0.95, 6267);
			dlgKillCharacter(6267);
			sd(Quest_TG7_01);
			aod.gnz_tunnels_intro = 1;
		}
		
		if(aod.gnz_tunnels_fromCastle)
			aod.gnz_tunnels_fromCastle = 0;
		
		setTravelingAllowed(false);
		setCombatAllowed(false);
		
		//*************** Party Settings ****
		//***********************************
	}
	
	function onStartCombat()
	{
		//apmsStopMusic(); apmsPlayMusic(custom, 2, 1);
		
		aod.fight_scolopendra = 1;
	}
	
	function onEndCombat()
	{
		//apmsPlayMusic(custom, 5, 1);
		
		if(isalive())
		{
			aod.fight_scolopendra = 0;
			
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
	
	function gnz_tunnelsDebris(%Dex, %Side, %Debris)
	{
		if(aod.dex >= %Dex)
		{
			narratePhrase("[success] You manage to squeeze through the opening.");
			eval("dlgTeleportToMarker(TM_Debris_" @ %Debris @ "_" @ %Side @ ");");
		}
		else
			narratePhrase("[failure] You aren't agile enough to squeeze through the opening.");
	}
	
	function gnz_tunnels_goToCastle()
	{
		BlackOut.command = "switchMission(\"Ganezzar Castle Basement Tunnels.mis\");";
		startBlackOut();
	}
	
	function gnz_tunnels_goToTG()
	{
		aod.gnz_TG_fromTunnels = 1;
		BlackOut.command = "switchMission(\"Ganezzar TG.mis\");";
		startBlackOut();
	}
	
	function scolopendraIntro()
	{
		if(aod.gnz_tunnels_metScolopendra_01 == false)
		{
			aod.gnz_tunnels_metScolopendra_01 = true;
			BlackSplash.command = "";
			BlackOut.command = "createByCharMarker(\"CM_Scolopendra\"); sd(Quest_TG7_Scolopendra); startBlackSplash();";
			startBlackOut();
		}
	}
	
	function scolopendraIntroClimb()
	{
		if(aod.gnz_tunnels_metScolopendra_01 == false)
		{
			aod.gnz_tunnels_metScolopendra_01 = true;
			createByCharMarker("CM_Scolopendra"); 
			sd(Quest_TG7_Scolopendra);
		}
	}
};

useEventPackage(GanezzarTunnelsEvents);