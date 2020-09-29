function mdn_startDlg()
{
	if(aod.mdn_thief_start)
	{
		sd(MDN_arrivalTG);
		createByCharMarker("CM_Aziz_Teron");
		createByCharMarker("CM_Bassar_TG");
		dlgTeleportToMarker(TM_arrivalTG_01);
		if(aod.npc_lucius_dead == false) createByCharMarker("CM_Lucius_Teron");
		TG_Cart.isRenderEnabled = true;
		aod.mdn_thief_start = false;
	}
	
	if(aod.mdn_tookDocuments_start)
	{
		sd(MDN_tookDocuments_01);
		aod.mdn_tookDocuments_start = false;
	}
	
	if(aod.mdn_guard_start)
	{
		sd(Quest_IGTrial_01);
		aod.mdn_guard_start = false;
		aod.npc_pavola_askForEquipment = true;
	}
	
	if(aod.mdn_spyAG_start)
	{
		sd(NPC_Gaelius_01);
		aod.mdn_spyAG_start = false;
	}
	
	if(aod.mdn_mine_start)
	{
		sd(NPC_Gaelius_01);
		aod.mdn_mine_start = false;
	}
}

function guardcheckpoint01()
{
	if(isInDialogue() == false && IsInCombat() == false && theLevelInfo.levelname $= "Teron")
	{
		if(dlgIsNude() || aod.global_teron_killedKeyCharacter || (aod.global_teron_killedCivilianCharacter == 1 && aod.global_teron_warnedAboutKilling == false) || aod.global_teron_killedCivilianCharacter > 1 || aod.tsq_shanty_killedGuard)
		{
			BlackSplash.command = "$RTSCamera.lookAtChar(2150);";
			BlackOut.command = "dlgTeleportTo(174, 65, 0, N); dlgTeleportTo(174, 67, 0, S, 2150); dlgTeleportTo(173, 68, 0, S, 2151); dlgTeleportTo(175, 68, 0, S, 2152); dlgTeleportTo(176, 66, 0, W, 2153); dlgTeleportTo(176, 63, 0, NW, 2154); dlgTeleportTo(172, 64, 0, NE, 2155); apmsstartdialogue(Teron_Guards_01); startBlackSplash();";
			startBlackOut();
		}
	}
}

function guardcheckpoint02()
{
	if(isInDialogue() == false && IsInCombat() == false && theLevelInfo.levelname $= "Teron")
	{
		if(dlgIsNude() || aod.global_teron_killedKeyCharacter || (aod.global_teron_killedCivilianCharacter == 1 && aod.global_teron_warnedAboutKilling == false) || aod.global_teron_killedCivilianCharacter > 1 || aod.tsq_shanty_killedGuard)
		{
			BlackSplash.command = "$RTSCamera.lookAtChar(2150);";
			BlackOut.command = "dlgTeleportTo(199, 55, 0, W); dlgTeleportTo(197, 55, 0, E, 2150); dlgTeleportTo(196, 54, 0, E, 2151); dlgTeleportTo(196, 56, 0, E, 2152); dlgTeleportTo(197, 57, 0, SE, 2153); dlgTeleportTo(199, 58, 0, S, 2154); dlgTeleportTo(199, 52, 0, N, 2155); apmsstartdialogue(Teron_Guards_01); startBlackSplash();";
			startBlackOut();
		}
	}
}

function guardcheckpoint03()
{
	if(isInDialogue() == false && IsInCombat() == false && theLevelInfo.levelname $= "Teron")
	{
		if(dlgIsNude() || aod.global_teron_killedKeyCharacter || (aod.global_teron_killedCivilianCharacter == 1 && aod.global_teron_warnedAboutKilling == false) || aod.global_teron_killedCivilianCharacter > 1 || aod.tsq_shanty_killedGuard)
		{
			BlackSplash.command = "$RTSCamera.lookAtChar(2150);";
			BlackOut.command = "dlgTeleportTo(137, 72, 0, N); dlgTeleportTo(137, 73, 0, S, 2150); dlgTeleportTo(136, 74, 0, S, 2151); dlgTeleportTo(138, 74, 0, S, 2152); dlgTeleportTo(136, 70, 0, NE, 2153); dlgTeleportTo(138, 70, 0, NW, 2154); dlgTeleportTo(137, 69, 0, N, 2155); apmsstartdialogue(Teron_Guards_01); startBlackSplash();";
			startBlackOut();
		}
	}
}

function guardcheckpoint04()
{
	if(isInDialogue() == false && IsInCombat() == false && theLevelInfo.levelname $= "Teron")
	{
		if(dlgIsNude() || aod.global_teron_killedKeyCharacter || (aod.global_teron_killedCivilianCharacter == 1 && aod.global_teron_warnedAboutKilling == false) || aod.global_teron_killedCivilianCharacter > 1 || aod.tsq_shanty_killedGuard)
		{
			BlackSplash.command = "$RTSCamera.lookAtChar(2150);";
			BlackOut.command = "dlgTeleportTo(172, 124, 0, N); dlgTeleportTo(172, 125, 0, S, 2150); dlgTeleportTo(171, 126, 0, S, 2151); dlgTeleportTo(173, 126, 0, S, 2152); dlgTeleportTo(171, 122, 0, NE, 2153); dlgTeleportTo(173, 122, 0, NW, 2154); dlgTeleportTo(172, 121, 0, N, 2155); apmsstartdialogue(Teron_Guards_01); startBlackSplash();";
			startBlackOut();
		}
	}
}

function guardcheckpoint05()
{
	if(isInDialogue() == false && IsInCombat() == false && theLevelInfo.levelname $= "Teron")
	{
		if(dlgIsNude() || aod.global_teron_killedKeyCharacter || (aod.global_teron_killedCivilianCharacter == 1 && aod.global_teron_warnedAboutKilling == false) || aod.global_teron_killedCivilianCharacter > 1 || aod.tsq_shanty_killedGuard)
		{
			BlackSplash.command = "$RTSCamera.lookAtChar(2150);";
			BlackOut.command = "dlgTeleportTo(197, 85, 0, W); dlgTeleportTo(196, 85, 0, E, 2150); dlgTeleportTo(195, 84, 0, E, 2151); dlgTeleportTo(195, 86, 0, E, 2152); dlgTeleportTo(199, 84, 0, W, 2153); dlgTeleportTo(200, 86, 0, W, 2154); dlgTeleportTo(201, 85, 0, W, 2155); apmsstartdialogue(Teron_Guards_01); startBlackSplash();";
			startBlackOut();
		}
	}
}

function guardcheckpoint06()
{
	if(isInDialogue() == false && IsInCombat() == false && theLevelInfo.levelname $= "Teron")
	{
		if(dlgIsNude() || aod.global_teron_killedKeyCharacter || (aod.global_teron_killedCivilianCharacter == 1 && aod.global_teron_warnedAboutKilling == false) || aod.global_teron_killedCivilianCharacter > 1 || aod.tsq_shanty_killedGuard)
		{
			BlackSplash.command = "$RTSCamera.lookAtChar(2150);";
			BlackOut.command = "dlgTeleportTo(131, 141, 0, N); dlgTeleportTo(131, 142, 0, S, 2150); dlgTeleportTo(130, 143, 0, S, 2151); dlgTeleportTo(132, 143, 0, S, 2152); dlgTeleportTo(130, 140, 0, N, 2153); dlgTeleportTo(132, 140, 0, N, 2154); dlgTeleportTo(131, 139, 0, N, 2155); apmsstartdialogue(Teron_Guards_01); startBlackSplash();";
			startBlackOut();
		}
	}
}

function guardcheckpoint07()
{
	if(isInDialogue() == false && IsInCombat() == false && theLevelInfo.levelname $= "Teron")
	{
		if(dlgIsNude() || aod.global_teron_killedKeyCharacter || (aod.global_teron_killedCivilianCharacter == 1 && aod.global_teron_warnedAboutKilling == false) || aod.global_teron_killedCivilianCharacter > 1 || aod.tsq_shanty_killedGuard)
		{
			BlackSplash.command = "$RTSCamera.lookAtChar(2150);";
			BlackOut.command = "dlgTeleportTo(219, 148, 0, W); dlgTeleportTo(218, 148, 0, E, 2150); dlgTeleportTo(217, 147, 0, E, 2151); dlgTeleportTo(217, 149, 0, E, 2152); dlgTeleportTo(221, 147, 0, W, 2153); dlgTeleportTo(221, 149, 0, W, 2154); dlgTeleportTo(222, 148, 0, W, 2155); apmsstartdialogue(Teron_Guards_01); startBlackSplash();";
			startBlackOut();
		}
	}
}

function guardcheckpoint08()
{
	if(isInDialogue() == false && IsInCombat() == false && theLevelInfo.levelname $= "Teron")
	{
		if(dlgIsNude() || aod.global_teron_killedKeyCharacter || (aod.global_teron_killedCivilianCharacter == 1 && aod.global_teron_warnedAboutKilling == false) || aod.global_teron_killedCivilianCharacter > 1 || aod.tsq_shanty_killedGuard)
		{
			BlackSplash.command = "$RTSCamera.lookAtChar(2150);";
			BlackOut.command = "dlgTeleportTo(173, 160, 0, N); dlgTeleportTo(173, 161, 0, S, 2150); dlgTeleportTo(172, 162, 0, S, 2151); dlgTeleportTo(174, 162, 0, S, 2152); dlgTeleportTo(172, 158, 0, N, 2153); dlgTeleportTo(174, 158, 0, N, 2154); dlgTeleportTo(173, 157, 0, N, 2155); apmsstartdialogue(Teron_Guards_01); startBlackSplash();";
			startBlackOut();
		}
	}
}

function guardcheckpoint09()
{
	if(isInDialogue() == false && IsInCombat() == false && theLevelInfo.levelname $= "Teron")
	{
		if(dlgIsNude() || aod.global_teron_killedKeyCharacter || (aod.global_teron_killedCivilianCharacter == 1 && aod.global_teron_warnedAboutKilling == false) || aod.global_teron_killedCivilianCharacter > 1 || aod.tsq_shanty_killedGuard)
		{
			BlackSplash.command = "$RTSCamera.lookAtChar(2150);";
			BlackOut.command = "dlgTeleportTo(173, 16, 0, N); dlgTeleportTo(173, 17, 0, S, 2150); dlgTeleportTo(172, 18, 0, S, 2151); dlgTeleportTo(174, 18, 0, S, 2152); dlgTeleportTo(172, 14, 0, N, 2153); dlgTeleportTo(174, 14, 0, N, 2154); dlgTeleportTo(173, 13, 0, N, 2155); apmsstartdialogue(Teron_Guards_01); startBlackSplash();";
			startBlackOut();
		}
	}
}

function guardcheckpoint10()
{
	if(isInDialogue() == false && IsInCombat() == false && theLevelInfo.levelname $= "Teron")
	{
		if(dlgIsNude() || aod.global_teron_killedKeyCharacter || (aod.global_teron_killedCivilianCharacter == 1 && aod.global_teron_warnedAboutKilling == false) || aod.global_teron_killedCivilianCharacter > 1 || aod.tsq_shanty_killedGuard)
		{
			BlackSplash.command = "$RTSCamera.lookAtChar(2150);";
			BlackOut.command = "dlgTeleportTo(167, 106, 0, W); dlgTeleportTo(166, 106, 0, E, 2150); dlgTeleportTo(165, 107, 0, E, 2151); dlgTeleportTo(165, 105, 0, E, 2152); dlgTeleportTo(169, 105, 0, W, 2153); dlgTeleportTo(169, 107, 0, W, 2154); dlgTeleportTo(170, 106, 0, W, 2155); apmsstartdialogue(Teron_Guards_01); startBlackSplash();";
			startBlackOut();
		}
	}
}

function ownsSmallDagger()
{
	if(dlgOwnsItem(100) || dlgOwnsItem(101) || dlgOwnsItem(102) || dlgOwnsItem(105))
		return true;
	
	return false;
}

function dlgHasShieldEquipped()
{
	if(dlgIsEquippedItem(1700) || dlgIsEquippedItem(1701) || dlgIsEquippedItem(1702) || dlgIsEquippedItem(1703) || dlgIsEquippedItem(1710) || dlgIsEquippedItem(1711) || dlgIsEquippedItem(1712) || dlgIsEquippedItem(1713) || dlgIsEquippedItem(1750) || dlgIsEquippedItem(1751) || dlgIsEquippedItem(2505))
		return true;
	
	return false;
}

function dlgOwnsXbow()
{
	if(dlgOwnsItem(160) || dlgOwnsItem(161) || dlgOwnsItem(162) || dlgOwnsItem(163) || dlgOwnsItem(164) || dlgOwnsItem(165) || dlgOwnsItem(166) || dlgOwnsItem(167))
		return true;
	
	return false;
}

function dlgOwnsBow()
{
	if(dlgOwnsItem(150) || dlgOwnsItem(151) || dlgOwnsItem(152) || dlgOwnsItem(153) || dlgOwnsItem(154) || dlgOwnsItem(155))
		return true;
	
	return false;
}

function dlgOwnsThrowing()
{
	if(dlgOwnsItem(170) || dlgOwnsItem(171) || dlgOwnsItem(172) || dlgOwnsItem(173) || dlgOwnsItem(174) || dlgOwnsItem(179))
		return true;
	
	return false;
}

function dlgOwnsMissile(%Missiles)
{
	if(dlgGetItemsCount(300) >= %Missiles || dlgGetItemsCount(301) >= %Missiles || dlgGetItemsCount(302) >= %Missiles)
		return true;
	
	return false;
}

function dlgUnequipHands(%charID)
{
	if(%charID == 0)
		%charID = 1;
	
	if(dlgIsEquippedItem(2505) == false)
		dlgUnequipSlot(6, %charID);
	
	dlgUnequipSlot(7, %charID);
	dlgUnequipSlot(8, %charID);
	dlgUnequipSlot(9, %charID);
}

function dlgUnequipEverything(%charID)
{
	if(%charID == 0)
		%charID = 1;
	
	dlgUnequipSlot(0, %charID);
	
	if(dlgIsEquippedItem(2510) == false && dlgIsEquippedItem(2511) == false && dlgIsEquippedItem(2512) == false && dlgIsEquippedItem(2513) == false)
		dlgUnequipSlot(1, %charID);
	
	dlgUnequipSlot(2, %charID);
	dlgUnequipSlot(3, %charID);
	dlgUnequipSlot(4, %charID);
	dlgUnequipSlot(5, %charID);
	
	if(dlgIsEquippedItem(2505) == false)
		dlgUnequipSlot(6, %charID);
	
	dlgUnequipSlot(7, %charID);
	dlgUnequipSlot(8, %charID);
	dlgUnequipSlot(9, %charID);
}

function dlgUnequipArmor(%charID)
{
	if(%charID == 0)
		%charID = 1;
	
	if(dlgIsEquippedItem(2510) == false && dlgIsEquippedItem(2511) == false && dlgIsEquippedItem(2512) == false && dlgIsEquippedItem(2513) == false)
		dlgUnequipSlot(1, %charID);
	
	dlgUnequipSlot(2, %charID);
	dlgUnequipSlot(3, %charID);	
}

function dlgCarryBox(%charID)
{
	if(%charID == 0)
		%charID = 1;
	
	dlgUnequipHands(%charID);
	(sc @ %charID).setMeshHidden(i_box, false);
	dlgSetAnimation(anim_walk_box, getrandom(), %charID);
}

function dlgCarryChest(%charID)
{
	if(%charID == 0)
		%charID = 1;
	
	dlgUnequipHands(%charID);
	(sc @ %charID).setMeshHidden(i_chest, false);
	dlgSetAnimation(anim_walk_box, getrandom(), %charID);
}

function dlgSetAmphoraAnimationStart(%charID)
{
	if(%charID == 0)
		%charID = 1;
	
	dlgUnequipHands(%charID);
	(sc @ %charID).setMeshHidden(i_amphora, false);
	dlgSetAnimation(anim_walk_amphora, getrandom(), %charID);
}

function dlgSetAmphoraAnimationEnd(%charID)
{
	if(%charID == 0)
		%charID = 1;
	
	(sc @ %charID).setMeshHidden(i_amphora, true);
	dlgSetAmbientAnimation(%charID);
}

function dlgSetReadScrollAnimationStart(%charID)
{
	if(%charID == 0)
		%charID = 1;
	
	dlgUnequipHands(%charID);
	(sc @ %charID).setMeshHidden(i_scroll, false);
	dlgSetAnimation(anim_use_scroll, 0.5, %charID);
}

function dlgSetReadScrollAnimationEnd(%charID)
{
	if(%charID == 0)
		%charID = 1;
	
	(sc @ %charID).setMeshHidden(i_scroll, true);
	dlgSetAmbientAnimation(%charID);
}

function changeHP(%HP)
{
	if((dlgGetCharacterHP() + %HP) < 1) 
		dlgSetCharacterHP(1);
	else
		dlgChangeCharacterHP(%HP);
}

function PC_Traitor()
{
	aod.pc_traitor = (aod.pc_traitor + 1);
	
	if(aod.pc_traitor >= 2)
		setAchievement("ACH_TRAITOR");
}

function PC_trained()
{
	aod.pc_trained = (aod.pc_trained + 1);
	
	if(aod.pc_trained >= 5)
		setAchievement("ACH_TRAINED");
}

//********************* PC Member ***//
//***********************************//

function removePcMember()
{
	if(aod.pc_member_guards)
	{
		aod.pc_member_guards = false;
		dlgDelRank(37);
		dlgDelRank(50);
		dlgDelRank(56);
		aod.pc_exMember_guards = true;
	}
	
	if(aod.pc_member_assassins)
	{
		aod.pc_member_assassins = false;
		dlgDelRank(38);
		dlgDelRank(39);
		aod.pc_exMember_assassins = true;
	}
	
	if(aod.pc_member_thieves)
	{
		aod.pc_member_thieves = false;
		dlgDelRank(40);
		aod.pc_exMember_thieves = true;
	}
	
	if(aod.pc_member_commercium)
	{
		aod.pc_member_commercium = false;
		dlgDelRank(41);
		aod.pc_exMember_commercium = true;
	}
	
	if(aod.pc_member_daratan)
	{
		aod.pc_member_daratan = false;
		dlgDelRank(42);
		dlgDelRank(53);
		aod.pc_exMember_daratan = true;
	}
	
	if(aod.pc_liegemanAurelian)
	{
		aod.pc_liegemanAurelian = false;
		dlgDelRank(47);
	}
	
	if(aod.pc_member_aurelian)
	{
		aod.pc_member_aurelian = false;
		dlgDelRank(48);
		dlgDelRank(59);
		aod.pc_exMember_aurelian = true;
	}
	
	if(aod.pc_member_crassus)
	{
		aod.pc_member_crassus = false;
		dlgDelRank(57);
	}
	
	if(aod.pc_member_templars)
	{
		aod.pc_member_templars = false;
		dlgDelRank(58);
	}
	
	if(aod.pc_member_none)
		aod.pc_member_none = false; // This is only for starter characters
}

// Add: aod.pc_member_trnAG, etc.
// Add: aod.pc_member_mdnAG, etc.
// Add: aod.pc_exMember_asssassins, etc.

function PCmemberIG()
{
	removePcMember();
	aod.pc_member_guards = true;
	dlgAddRank(37);
	
	if(isQuestAdded(Guildless))
		remQuest(Guildless);
}

function PCmemberMG()
{
	removePcMember();
	aod.pc_member_commercium = true;
	dlgAddRank(41);
	
	if(isQuestAdded(Guildless))
		remQuest(Guildless);
}

function PCmemberAssassins()
{
	removePcMember();
	aod.pc_member_assassins = true;
	
	if(aod.gender == 1)
		dlgAddRank(38);
	
	if(aod.gender == 0)
		dlgAddRank(39);
	
	if(isQuestAdded(Guildless))
		remQuest(Guildless);
}

function PCmemberThieves()
{
	removePcMember();
	aod.pc_member_thieves = true;
	dlgAddRank(40);
	
	if(isQuestAdded(Guildless))
		remQuest(Guildless);
}

function PCmemberAurelian()
{
	removePcMember();
	aod.pc_member_aurelian = true;
	aod.pc_liegemanAurelian = true;

	if(aod.pc_liegemanDaratan)
	{
		aod.pc_liegemanDaratan = false;
		dlgDelRank(36);
		rwd_reputation(HA_from_HD);
	}
	
	if(aod.pc_exMember_daratan)
		rwd_reputation(HA_from_HD);
	
	if(isQuestAdded(Guildless))
		remQuest(Guildless);
	
	dlgAddRank(48);
	dlgDelRank(47);
        rwd_reputation(HA_Praetor);
	dlgAddItemlist(Aurelian_Cape);
}

function PCAurelianLiegeman()
{
	removePcMember();
	aod.pc_liegemanAurelian = true;

	if(aod.pc_liegemanDaratan)
	{
		aod.pc_liegemanDaratan = false;
		dlgDelRank(36);
		rwd_reputation(HA_from_HD);
	}
	
	if(aod.pc_exMember_daratan)
		rwd_reputation(HA_from_HD);
	
	if(aod.pc_exMember_commercium)
	{
		if(isQuestAdded(MG_ArriveMDN))
			remQuest(MG_ArriveMDN);
		
		if(isQuestAdded(MG4))
			remQuest(MG4);
		
		if(isQuestAdded(MG5))
			remQuest(MG5);
		
		if(isQuestAdded(MG5a))
			remQuest(MG5a);
		
		if(isQuestAdded(MG6))
			remQuest(MG6);
	}
	
	if(aod.pc_exMember_assassins)
	{
		DOOR_AG_01.close();
		DOOR_AG_01.lock();

		if(isQuestAdded(AG_ArriveMDN))
			remQuest(AG_ArriveMDN);
		
		if(isQuestAdded(AG4))
			remQuest(AG4);
	}

	if(isQuestAdded(Guildless))
		remQuest(Guildless);
	
	dlgAddRank(47);
	setAchievement("ACH_LIEGEMAN_HA");
}

function PCmemberBalzaar()
{
	removePcMember();
	aod.pc_member_crassus = 1;
	
	if(aod.pc_liegemanDaratan)
	{
		aod.pc_liegemanDaratan = false;
		dlgDelRank(36);
	}
	
	if(isQuestAdded(HA_GNZ))
		remQuest(HA_GNZ);
	
	if(isQuestAdded(Guildless))
		remQuest(Guildless);
	
	rwd_reputation(HC_Acolyte);
	dlgAddRank(57);

	if(pcHasFaction())
		PC_Traitor();
}

function PCmemberCarrinasTemplar()
{
	removePcMember();
	aod.pc_member_templars = 1;
	
	if(aod.pc_liegemanDaratan)
	{
		aod.pc_liegemanDaratan = false;
		dlgDelRank(36);
	}
	
	if(isQuestAdded(Guildless))
		remQuest(Guildless);
	
	rwd_reputation(IG9_04);
	dlgAddRank(58);
	PC_Traitor();
}

function pcHasFaction()
{
	if(aod.pc_member_assassins || aod.pc_member_commercium || aod.pc_member_thieves || aod.pc_member_daratan || aod.pc_member_guards || aod.pc_member_aurelian || aod.pc_member_crassus || aod.pc_member_templars || aod.pc_liegemanAurelian)
		return true;
	else
		return false;
}

function warnGaeliusMG()
{
	aod.maadoran_notAllowedStrabos = true;
	aod.mdn_fort_blocked = true;
	aod.mdn_lorenza_blocked = true;
	aod.pc_member_mdnMG = 0;
	PCmemberAurelian();
	remQuest(MG5); 
	aod.quest_MG5_active = false;
	remQuest(MG5a);
	
	if(aod.quest_MG4_SennaSupport)
		aod.npc_senna_dead = true;
	
	if(aod.quest_MG4_lorenzaSupport)
		aod.npc_lorenza_dead = true;
	
	aod.ending_mdn_character_betrayedGuildForGaelius = true;
	rwd_reputation(Gaelius_Betray_MG);
}

function warnGaeliusTG()
{
	PCmemberAurelian();
	remQuest(TG6); 
	aod.quest_TG6_active = false;
	aod.ending_mdn_character_betrayedGuildForGaelius = true;
	dlgDeleteCharacter(4620);
	rwd_reputation(Gaelius_Betray_TG);
	dlgTeleportToMarker(TM_TG_GuardOutside, 4030);
}

function warnGaeliusIG()
{
	PCmemberAurelian();
	aod.mdn_fort_blocked = true;
	aod.npc_pavola_reportStrabos = false;
	aod.ending_mdn_character_betrayedGuildForGaelius = true;
	rwd_reputation(Gaelius_Betray_IG);
	remQuest(IG4);
	rwd_quest(IG4_02);
}

//************** Weather Commands ***//
//***********************************//

function TeronNightTime()
{
  theSun.color = "0.35 0.40 0.57 1";
  theSun.ambient = "0.30 0.30 0.35 1";
  theSun.brightness = 0.65;
  theSun.castShadows = "1";
  theSun.shadowSoftness = 5;
  theSun.apply();
  thelevelinfo.fogColor = "0.32 0.32 0.37 1";
  thelevelinfo.fogDensity = "0.005";
  thelevelinfo.fogDensityOffset = "2";
  thelevelinfo.apply();
  aod.weather_teron_dayTime = false;
  aod.weather_teron_nightTime = true;
  aod.weather_teron_exterior = true;
  aod.weather_teron_interior = false;
}

function TeronDayTime()
{
  theSun.color = "0.86 0.71 0.45 1";
  theSun.ambient = "0.52 0.51 0.49 1";
  theSun.brightness = 1.6;
  theSun.castShadows = "1";
  theSun.shadowSoftness = 0.5;
  theSun.apply();
  thelevelinfo.fogColor = "0.57 0.46 0.31 1";
  thelevelinfo.fogDensity = "0.0015";
  thelevelinfo.fogDensityOffset = "8";
  thelevelinfo.apply();
  aod.weather_teron_dayTime = true;
  aod.weather_teron_nightTime = false;
  aod.weather_teron_exterior = true;
  aod.weather_teron_interior = false;
}

function TeronPropInteriorNight()
{
  theSun.color = "0.35 0.40 0.57 1";
  theSun.ambient = "0.30 0.30 0.35 1";
  theSun.brightness = 0;
  theSun.castShadows = "0";
  theSun.apply();
  thelevelinfo.fogColor = "0.32 0.32 0.37 1";
  thelevelinfo.fogDensity = "0";
  thelevelinfo.fogDensityOffset = "2";
  thelevelinfo.apply();
  aod.weather_teron_dayTime = false;
  aod.weather_teron_nightTime = true;
  aod.weather_teron_exterior = false;
  aod.weather_teron_interior = true;
}

function TeronPropInteriorDay()
{
  theSun.color = "0.86 0.71 0.45 1";
  theSun.ambient = "0.52 0.51 0.49 1";
  theSun.brightness = 0;
  theSun.castShadows = "0";
  theSun.apply();
  thelevelinfo.fogColor = "0.57 0.46 0.31 1";
  thelevelinfo.fogDensity = "0";
  thelevelinfo.fogDensityOffset = "8";
  thelevelinfo.apply();
  aod.weather_teron_dayTime = true;
  aod.weather_teron_nightTime = false;
  aod.weather_teron_exterior = false;
  aod.weather_teron_interior = true;
}

function interiorAmbient()
{
  theSun.castShadows = "0";
  theSun.brightness = 0;
  theSun.apply();
}

function exteriorTeron()
{
  theSun.castShadows = "1";
  theSun.ambient = "0.52 0.51 0.49 1";
  theSun.brightness = 1.6;
  theSun.apply();
}

//****************** Dev Commands ***//
//***********************************//


//********** RTS Camera Functions ***//
//***********************************//



//****************** Quest Events ***//
//***********************************//

function mty_rightThing()
{
	if(aod.mty_everyoneDead == 0 && aod.jnl_elixir == 6)
		setAchievement("ACH_RIGHT_THING");
}

function abyss_backToTop()
{
	dlgTeleportToMarker(TM_Crater_Top);
	setRtsCam();
	thelevelinfo.fogdensity = "0.0025";
	thelevelinfo.apply();
	theSun.brightness = 1.6;
	theSun.apply();
}

function abyss_enterChamber()
{
	thesun.ambient = "0.05 0.05 0.05 1";
	theSun.apply();
	abyssThunder.stop();
	thelevelinfo.fogdensity = "0";
	thelevelinfo.apply();
}

function Aemolas_SnipeStageOne()
{
	if(isAlive(3010)) {dlgTeleportToMarker(TM_Snipe_StageOne_NPC_05, 3010);}
	if(isAlive(3011)) {dlgTeleportToMarker(TM_Snipe_StageOne_NPC_04, 3011);}
	if(isAlive(3012)) {dlgTeleportToMarker(TM_Snipe_StageOne_NPC_02, 3012);}
	if(isAlive(3013)) {dlgTeleportToMarker(TM_Snipe_StageOne_NPC_01, 3013);}
	if(isAlive(3014)) {dlgTeleportToMarker(TM_Snipe_StageOne_NPC_07, 3014);}
	if(isAlive(3016)) {dlgTeleportToMarker(TM_Snipe_StageOne_NPC_03, 3016);}
	if(isAlive(3018)) {dlgTeleportToMarker(TM_Snipe_StageOne_NPC_06, 3018);}
}

function Aemolas_SnipeStageTwo()
{
	if(isAlive(3010)) {dlgTeleportToMarker(TM_Snipe_StageTwo_NPC_05, 3010);}
	if(isAlive(3011)) {dlgTeleportToMarker(TM_Snipe_StageTwo_NPC_04, 3011);}
	if(isAlive(3012)) {dlgTeleportToMarker(TM_Snipe_StageTwo_NPC_02, 3012);}
	if(isAlive(3013)) {dlgTeleportToMarker(TM_Snipe_StageTwo_NPC_01, 3013);}
	if(isAlive(3014)) {dlgTeleportToMarker(TM_Snipe_StageTwo_NPC_07, 3014);}
	if(isAlive(3016)) {dlgTeleportToMarker(TM_Snipe_StageTwo_NPC_03, 3016);}
	if(isAlive(3018)) {dlgTeleportToMarker(TM_Snipe_StageTwo_NPC_06, 3018);}
	if(isAlive(3020)) {dlgTeleportToMarker(TM_Snipe_StageTwo_NPC_08, 3020);}
}

function Aemolas_SnipeStageThree()
{
	if(isAlive(3010)) {dlgTeleportToMarker(TM_Snipe_StageThree_NPC_05, 3010);}
	if(isAlive(3011)) {dlgTeleportToMarker(TM_Snipe_StageThree_NPC_06, 3011);}
	if(isAlive(3012)) {dlgTeleportToMarker(TM_Snipe_StageThree_NPC_03, 3012);}
	if(isAlive(3013)) {dlgTeleportToMarker(TM_Snipe_StageThree_NPC_02, 3013);}
	if(isAlive(3014)) {dlgTeleportToMarker(TM_Snipe_StageThree_NPC_01, 3014);}
	if(isAlive(3016)) {dlgTeleportToMarker(TM_Snipe_StageThree_NPC_04, 3016);}
	if(isAlive(3018)) {dlgTeleportToMarker(TM_Snipe_StageThree_NPC_07, 3018);}
	if(isAlive(3020)) {dlgTeleportToMarker(TM_Snipe_StageThree_NPC_11, 3020);}
	if(isAlive(3015)) {dlgTeleportToMarker(TM_Snipe_StageThree_NPC_10, 3015);}
	if(isAlive(3017)) {dlgTeleportToMarker(TM_Snipe_StageThree_NPC_09, 3017);}
	if(isAlive(3021)) {dlgTeleportToMarker(TM_Snipe_StageThree_NPC_08, 3021);}
}

function PRT_GhostMachine()
{
	GhostMachine.showObjects();
}

function PRT_PortalActive()
{
	GhostMachine.showObjects();
	PortalLight.showObjects();
	theSun.brightness = 0;
	theSun.apply();
	portalFace.isRenderEnabled = true;
}

function PRT_realWorld()
{
	GhostMachine.hideObjects();
	PortalLight.hideObjects();
	theSun.brightness = 1.6;
	theSun.apply();
	portalFace.isRenderEnabled = false;
}

function PRT_everyoneLeaves()
{
	if(aod.npc_esbenus_dead == false)
	{
		dlgDeleteCharacter(1558);
		dlgDeleteCharacter(5840);
		dlgDeleteCharacter(5841);
		dlgDeleteCharacter(5842);
		dlgDeleteCharacter(5843);
		dlgDeleteCharacter(5844);
		dlgDeleteCharacter(5845);
	}
	
	dlgDeleteCharacter(5830);
	dlgDeleteCharacter(5831);
	dlgDeleteCharacter(5832);
	dlgDeleteCharacter(5833);
	dlgDeleteCharacter(5834);
	dlgDeleteCharacter(5835);
	dlgDeleteCharacter(5836);
	dlgDeleteCharacter(5837);
	dlgDeleteCharacter(5838);
	
	aod.prt_everyoneGone = true;
}

function TG4_FindJar()
{
	narratePhrase($phrase_TG4_FindJar);
	aod.quest_TG4_gotJar = true;
	aod.jnl_tg4_phase3 = true;
	dlgAddItem(2165, 1);
	dlgTeleportToMarker(TM_JarChest);
}

function fightMehrabHermonEnd()
{
	if(isAlive(5274))
	{
		dlgTeleportToMarker(TM_Hermon_02, 5274);
		addCharToParty(5274, HermonGang, fighter);
	}

	if(isAlive(5275))
	{
		dlgTeleportToMarker(TM_Hermon_02, 5275);
		addCharToParty(5275, HermonGang, fighter);
	}
	
	aod.fight_mehrabWithMen = false;
}

function enableArenaExit()
{
	VCO_ArenaExit_01.setActive(true);
	VCO_ArenaExit_02.setActive(true);
	EXIT_ArenaExit_01.isRenderEnabled = true;
	EXIT_ArenaExit_02.isRenderEnabled = true;
}

function disableArenaExit()
{
	VCO_ArenaExit_01.setActive(false);
	VCO_ArenaExit_02.setActive(false);
	EXIT_ArenaExit_01.isRenderEnabled = false;
	EXIT_ArenaExit_02.isRenderEnabled = false;
}

function MG5_moveGuards()
{
	if(isAlive(5112)) dlgTeleportToMarker(TM_Guard_01, 5112);
	if(isAlive(5113)) dlgTeleportToMarker(TM_Guard_02, 5113);
	if(isAlive(5114)) dlgTeleportToMarker(TM_Guard_03, 5114);
	if(isAlive(5115)) dlgTeleportToMarker(TM_Guard_04, 5115);
	if(isAlive(5116)) dlgTeleportToMarker(TM_Guard_05, 5116);
}

function HD3_EscapeSennasVilla()
{
	VCO_EnterSenna.setActive(false);
	dlgDeleteDeadCharacters();
	Exit_SennaFight_01.IsRenderEnabled = false;
	Exit_SennaFight_02.IsRenderEnabled = false;
	VCO_EscapeSenna_01.setActive(false);
	VCO_EscapeSenna_02.setActive(false);
	dlgTeleportToMarker(TM_Gate_PD);
}

function dariusTomb_raiders_door()
{
	dlgTeleportToMarker(TM_NPC_Door_01, 5045);
	dlgTeleportToMarker(TM_NPC_Door_02, 5046);
	dlgTeleportToMarker(TM_NPC_Door_03, 5047);
	dlgTeleportToMarker(TM_NPC_Door_04, 5048);
	dlgTeleportToMarker(TM_NPC_Door_05, 5049);
	dlgTeleportToMarker(TM_NPC_Door_06, 5050);
}

function vignette_mg_open()
{
	setPassability(132, 105, 0, 1);
	setPassability(134, 105, 0, 1);
	setPassability(136, 105, 0, 1);
	setPassability(137, 105, 0, 1);
	setPassability(139, 105, 0, 1);
	setPassability(141, 105, 0, 1);
	setPassability(144, 110, 0, 1);
	setPassability(146, 110, 0, 1);
	setPassability(148, 110, 0, 1);
	setPassability(149, 110, 0, 1);
	setPassability(151, 110, 0, 1);
	setPassability(153, 110, 0, 1);
	setPassability(120, 110, 0, 1);
	setPassability(122, 110, 0, 1);
	setPassability(124, 110, 0, 1);
	setPassability(125, 110, 0, 1);
	setPassability(127, 110, 0, 1);
	setPassability(129, 110, 0, 1);
}

function vignette_mg_close()
{
	setPassability(132, 105, 0, 0);
	setPassability(134, 105, 0, 0);
	setPassability(136, 105, 0, 0);
	setPassability(137, 105, 0, 0);
	setPassability(139, 105, 0, 0);
	setPassability(141, 105, 0, 0);
	setPassability(144, 110, 0, 0);
	setPassability(146, 110, 0, 0);
	setPassability(148, 110, 0, 0);
	setPassability(149, 110, 0, 0);
	setPassability(151, 110, 0, 0);
	setPassability(153, 110, 0, 0);
	setPassability(120, 110, 0, 0);
	setPassability(122, 110, 0, 0);
	setPassability(124, 110, 0, 0);
	setPassability(125, 110, 0, 0);
	setPassability(127, 110, 0, 0);
	setPassability(129, 110, 0, 0);
}

function vignette_praetor_start()
{
	dlgTeleportToMarker(TM_Vignette_PraetorStart);
	setPassability(155, 218, 0, 0);
	setPassability(155, 219, 0, 0);
	setPassability(155, 222, 0, 0);
	setPassability(155, 223, 0, 0);
	assignDialogue(vignette_knight, 1060);
	aod.pc_member_daratan = true;
	aod.pc_background_praetor = true;
	aod.npc_dellar_met = true;
	aod.npc_antidas_allowedToSeeHim = true;
	aod.npc_antidas_met = true;
	aod.npc_antidas_talkedAboutMap = true;
	aod.exploration_locationSign_Palace = true;
	aod.exploration_location_TeronMG = true;
	dlgcamPC(25,40,20);
	dlgAddRank(42);
	dlgDelRank(36);
	setTravelingAllowed(false);
	rwd_reputation(HD_Praetor);
	
	if(aod.skills[$ccs_best_skill] > 1)
		switch($ccs_best_skill)
		{
			case 0: dlgRemoveItem(110, 1); dlgRemoveItem(120, 1); dlgRemoveItem(130, 1); dlgRemoveItem(140, 1); dlgRemoveItem(150, 1); dlgRemoveItem(161, 1); dlgRemoveItem(300, 25); dlgRemoveItem(170, 25);	//dagger
			case 1: dlgRemoveItem(120, 1); dlgRemoveItem(130, 1); dlgRemoveItem(140, 1); dlgRemoveItem(150, 1); dlgRemoveItem(161, 1); dlgRemoveItem(300, 25); dlgRemoveItem(170, 25);							//sword
			case 2: dlgRemoveItem(110, 1); dlgRemoveItem(130, 1); dlgRemoveItem(140, 1); dlgRemoveItem(150, 1); dlgRemoveItem(161, 1); dlgRemoveItem(300, 25); dlgRemoveItem(170, 25);							//axe
			case 3: dlgRemoveItem(110, 1); dlgRemoveItem(120, 1); dlgRemoveItem(140, 1); dlgRemoveItem(150, 1); dlgRemoveItem(161, 1); dlgRemoveItem(300, 25); dlgRemoveItem(170, 25);							//hammer
			case 4: dlgRemoveItem(110, 1); dlgRemoveItem(120, 1); dlgRemoveItem(130, 1); dlgRemoveItem(150, 1); dlgRemoveItem(161, 1); dlgRemoveItem(300, 25); dlgRemoveItem(170, 25);							//spear
			case 5: dlgRemoveItem(110, 1); dlgRemoveItem(120, 1); dlgRemoveItem(130, 1); dlgRemoveItem(140, 1); dlgRemoveItem(161, 1); dlgRemoveItem(170, 25);													//bow
			case 6: dlgRemoveItem(110, 1); dlgRemoveItem(120, 1); dlgRemoveItem(130, 1); dlgRemoveItem(140, 1); dlgRemoveItem(150, 1); dlgRemoveItem(170, 25);													//crossbow
			case 7: dlgRemoveItem(110, 1); dlgRemoveItem(120, 1); dlgRemoveItem(130, 1); dlgRemoveItem(140, 1); dlgRemoveItem(150, 1); dlgRemoveItem(161, 1); dlgRemoveItem(300, 25);							//throwing
			default:
				warn("CcsGiveWeaponBySkill - unknown primary weapon skill ID.");
		}
	else
	{
		dlgRemoveItem(110, 1);
		dlgRemoveItem(120, 1);
		dlgRemoveItem(130, 1);
		dlgRemoveItem(140, 1);
		dlgRemoveItem(150, 1);
		dlgRemoveItem(161, 1);
		dlgRemoveItem(300, 25);
		dlgRemoveItem(170, 25);
	}
}

function vignette_assassin_start()
{
	aod.exploration_location_TeronAG = true; 
	tbd_door_assassin_01.lock(); 
	dlgTeleportToMarker(TM_Vignette_AssassinStart);
	aod.pc_member_assassins = true; 
	aod.pc_background_assassin = true; 
	assignDialogue(vignette_assassin, 1020);
	
	if(aod.gender == 1)
		dlgAddRank(38);
	
	if(aod.gender == 0)
		dlgAddRank(39);
	
	dlgcamPC(345,45,15);
}

function vignette_loremaster_start()
{
	aod.exploration_location_TeronFeng = true;
	dlgTeleportToMarker(TM_Vignette_LoremasterStart);
	assignDialogue(vignette_loremaster, 1000);
	tbd_loremaster_door_02.unlock();
	tbd_loremaster_door_01.lock();
	dlgcamPC(315,40,20);
	aod.pc_background_loremaster = 1;
}

function vignette_merchant_start()
{
	aod.exploration_location_TeronMG = true;
	dlgTeleportToMarker(TM_Vignette_MerchantStart);
	vignette_mg_close();
	assignDialogue(vignette_merchant, 1080);
	aod.pc_member_commercium = true;
	aod.pc_background_merchant = true;
	tbd_mg_door_04.unlock();
	tbd_mg_door_01.unlock();
	dlgcamPC(315,45,20);
	dlgAddRank(41);
}

function vignette_thief_start()
{
	aod.exploration_location_TeronTG = true;
	dlgTeleportToMarker(TM_Vignette_ThiefStart);
	assignDialogue(vignette_thief, 1100);
	aod.pc_member_thieves = true;
	aod.pc_background_thief = true;
	aod.exploration_locationSign_Tavern = true;
	tgd_tg_door6.lock();
	dlgAddRank(40);
	dlgcamPC(135,45,15);
}

function vignette_mercenary_start()
{
	aod.exploration_location_TeronInn = true;
	dlgTeleportToMarker(TM_Vignette_MercenaryStart);
	assignDialogue(vignette_mercenary, 1180);
	aod.pc_background_mercenary = true;
	aod.pc_member_none = true;
	tbd_inn_door_01.lock();
	tbd_inn_door_02.lock();
	dlgcamPC(325,40,15);
}

function vignette_grifter_start()
{
	aod.exploration_location_TeronInn = true;
	dlgTeleportToMarker(TM_Vignette_GrifterStart);
	dlgCreateCharacter("ペトラス", 1160, 1160, 183, 97, 0, E);
	assignDialogue(vignette_grifter, 1160);
	aod.pc_background_grifter = true;
	aod.pc_member_none = true;
	tbd_inn_door_01.lock();
	tbd_inn_door_02.lock();
	dlgcamPC(135,40,15);
}

function vignette_drifter_start()
{
	TeronPropInteriorNight();
	aod.exploration_location_TeronInn = true;
	dlgTeleportTo(29, 223, 0, S);
	dlgCreateCharacter("グラキウス", 1170, 1170, 6, 247, 0, S);
	dlgCreateCharacter("護衛", 1190, 1190, 5, 248, 0, SE);
	dlgCreateCharacter("暗殺者", 1200, 1200, 5, 245, 0, N);
	aod.pc_background_drifter = true;
	aod.pc_member_none = true;
	dlgRotateToChar(1200, 1170);
	VCO_vignette_drifter_01.setActive(true);
	dlgcamPC(225,45,15);
}

function vignette_veteran_start()
{
	dlgTeleportTo(160, 70, 0, N);
	aod.pc_background_veteran = true;
	aod.pc_member_none = true;
	$RTSCamera.setYZAngle(50);
	$RTSCamera.setXYAngle(225);
	$RTSCamera.lookAtPC(false);
	dlgSetZoom(12);
	dlgChangeRep(bodycount, 3);
	addQuest(Map);
	aod.quest_map_phase1 = true;
	addQuest(Job);
	aod.quest_job_phase1 = true;
}

function vignetteText()
{
	PG_HelpText_01.setVisible(true);
	TM_ShowTutorial(movement);
	switch(aod.professionID)
	{
		case 0: narratePhrase($phrase_vignettes_prof0); 
		case 1: narratePhrase($phrase_vignettes_prof1);
		case 2: narratePhrase($phrase_vignettes_prof2);
		case 3: sayPhrase(1000, $phrase_vignettes_prof3);
		case 4: narratePhrase($phrase_vignettes_prof4);
		case 5: narratePhrase($phrase_vignettes_prof5);
		case 6: narratePhrase($phrase_vignettes_prof6);
		case 7: narratePhrase($phrase_vignettes_prof7);
	}
}

function endVignette()
{
	aod.global_trnVignette_active = false;
	setCombatAllowed(true);
}

function TSQGangNorth()
{
	dlgTeleportTo(116, 52, 0, N, 3001);
	dlgTeleportTo(114, 54, 0, NE, 3002);
	dlgTeleportTo(117, 51, 0, N, 3003);
	dlgTeleportTo(115, 51, 0, N, 3004);
	useCameraBookmark(TSQ_Gang_cam_02);
}

function TSQGangSouth()
{
	dlgTeleportTo(117, 51, 0, S, 3001);
	dlgTeleportTo(114, 49, 0, SE, 3002);
	dlgTeleportTo(116, 52, 0, S, 3003);
	dlgTeleportTo(118, 52, 0, S, 3004);
	useCameraBookmark(TSQ_Gang_cam_03);	
}

function TSQGangOrigin()
{
	dlgTeleportTo(111, 51, 0, E, 3001);
	dlgTeleportTo(112, 53, 0, S, 3002);
	dlgTeleportTo(110, 53, 0, SE, 3003);
	dlgTeleportTo(113, 49, 0, N, 3004);
}

function TSQ_CreateRefugees()
{
	dlgCreateCharacter("Aemolas", 2070, 2070, 171, 23, 0, N);
	dlgCreateCharacter("難民", 2071, 2071, 172, 21, 0, N);
	dlgCreateCharacter("難民", 2072, 2072, 173, 20, 0, N);
	dlgCreateCharacter("難民", 2073, 2073, 172, 19, 0, N);
	dlgCreateCharacter("難民", 2074, 2074, 170, 20, 0, N);
}

function quest_ig3_antidasDeathReaction()
{
	dlgChangeTraining(dodge, -10, 1070);
	dlgChangeTraining(block, -10, 1390);
	dlgChangeTraining(block, -10, 1391);
	dlgChangeTraining(block, -10, 1400);
	dlgChangeTraining(block, -10, 1401);
	dlgChangeTraining(block, -10, 1880);
	dlgChangeTraining(dodge, -10, 1881);
	dlgChangeTraining(dodge, -10, 1882);
	
	dlgChangeTraining(sword, -10, 1070);
	dlgChangeTraining(sword, -10, 1390);
	dlgChangeTraining(sword, -10, 1391);
	dlgChangeTraining(sword, -10, 1400);
	dlgChangeTraining(sword, -10, 1401);
	dlgChangeTraining(sword, -10, 1880);
	dlgChangeTraining(spear, -10, 1881);
	dlgChangeTraining(spear, -10, 1882);
	
	if(isAlive(1070)) {schedule(500, 0, sayPhrase, 1070, $phrase_IG3_antidas_dead); aod.npc_antidas_deadCry = true;}
	if(isAlive(1390) && aod.npc_antidas_deadCry == false) {schedule(500, 0, sayPhrase, 1390, $phrase_IG3_antidas_dead);}
	if(isAlive(1391) && aod.npc_antidas_deadCry == false) {schedule(500, 0, sayPhrase, 1391, $phrase_IG3_antidas_dead);}
	if(isAlive(1400) && aod.npc_antidas_deadCry == false) {schedule(500, 0, sayPhrase, 1400, $phrase_IG3_antidas_dead);}
	if(isAlive(1401) && aod.npc_antidas_deadCry == false) {schedule(500, 0, sayPhrase, 1401, $phrase_IG3_antidas_dead);}
	if(isAlive(1880) && aod.npc_antidas_deadCry == false) {schedule(500, 0, sayPhrase, 1880, $phrase_IG3_antidas_dead);}
	if(isAlive(1881) && aod.npc_antidas_deadCry == false) {schedule(500, 0, sayPhrase, 1881, $phrase_IG3_antidas_dead);}
	if(isAlive(1882) && aod.npc_antidas_deadCry == false) {schedule(500, 0, sayPhrase, 1882, $phrase_IG3_antidas_dead);}
}

function quest_ig3_normal_soldiers()
{
	dlgCreateCharacter("帝国衛兵", 1860, 1860, 171, 224, 0, N);
	dlgCreateCharacter("帝国衛兵", 1861, 1861, 171, 226, 0, N);
	dlgCreateCharacter("帝国衛兵", 1863, 1863, 171, 225, 0, N);
	dlgCreateCharacter("帝国衛兵", 1862, 1862, 169, 225, 0, N);
	dlgCreateCharacter("帝国衛兵", 1864, 1864, 169, 224, 0, N);
	dlgCreateCharacter("帝国衛兵", 1865, 1865, 169, 226, 0, N);
	addParty(IG3Soldiers, 0);
	addCharToParty(1860, IG3Soldiers, fighter);
	addCharToParty(1861, IG3Soldiers, fighter);
	addCharToParty(1862, IG3Soldiers, fighter);
	addCharToParty(1863, IG3Soldiers, fighter);
	addCharToParty(1864, IG3Soldiers, fighter);
	addCharToParty(1865, IG3Soldiers, fighter);
	addCharToParty(1, IG3Soldiers, fighter);
}

function deleteIg3NormalSoldiers()
{
	dlgDeleteCharacter(1860);
	dlgDeleteCharacter(1861);
	dlgDeleteCharacter(1862);
	dlgDeleteCharacter(1863);
	dlgDeleteCharacter(1864);
	dlgDeleteCharacter(1865);
}

function quest_ig3_elite_soldiers()
{
	dlgCreateCharacter("Imperial Guard Elite", 1870, 1870, 169, 226, 0, N);
	dlgCreateCharacter("Imperial Guard Elite", 1871, 1871, 171, 226, 0, N);
	dlgCreateCharacter("Imperial Guard Elite", 1872, 1872, 171, 225, 0, N);
	dlgCreateCharacter("Imperial Guard Elite", 1873, 1873, 169, 225, 0, N);
	dlgCreateCharacter("Imperial Guard Elite", 1874, 1874, 169, 224, 0, N);
	dlgCreateCharacter("Imperial Guard Elite", 1875, 1875, 171, 224, 0, N);
	addParty(IG3Soldiers, 0);
	addCharToParty(1870, IG3Soldiers, fighter);
	addCharToParty(1871, IG3Soldiers, fighter);
	addCharToParty(1872, IG3Soldiers, fighter);
	addCharToParty(1873, IG3Soldiers, fighter);
	addCharToParty(1874, IG3Soldiers, fighter);
	addCharToParty(1875, IG3Soldiers, fighter);
	addCharToParty(1, IG3Soldiers, fighter);
}

function deleteIg3EliteSoldiers()
{
	dlgDeleteCharacter(1870);
	dlgDeleteCharacter(1871);
	dlgDeleteCharacter(1872);
	dlgDeleteCharacter(1873);
	dlgDeleteCharacter(1874);
	dlgDeleteCharacter(1875);
}

function quest_mg3_createAmbush()
{
	dlgCreateCharacter("賊", 1820, 1820, 31, 68, 0, E);
	dlgCreateCharacter("賊", 1821, 1821, 33, 66, 0, N);
	addParty(MG3BanditsAmbush, 0);
	addCharToParty(1820, "MG3BanditsAmbush", "fighter");
	addCharToParty(1821, "MG3BanditsAmbush", "fighter");
}

function quest_ig1_createRingBlock()
{
	setPassability(220, 50, 0, 0);
	setPassability(221, 50, 0, 0);
	setPassability(222, 50, 0, 0);
	setPassability(223, 50, 0, 0);
	setPassability(224, 50, 0, 0);
	setPassability(225, 50, 0, 0);
	setPassability(219, 54, 0, 0);
	setPassability(220, 54, 0, 0);
	setPassability(221, 55, 0, 0);
	setPassability(222, 55, 0, 0);
	setPassability(223, 55, 0, 0);
	setPassability(224, 54, 0, 0);
	setPassability(225, 54, 0, 0);
}

function quest_ig1_deleteRingBlock()
{
	setPassability(220, 50, 0, 1);
	setPassability(221, 50, 0, 1);
	setPassability(222, 50, 0, 1);
	setPassability(223, 50, 0, 1);
	setPassability(224, 50, 0, 1);
	setPassability(225, 50, 0, 1);
	setPassability(219, 54, 0, 1);
	setPassability(220, 54, 0, 1);
	setPassability(221, 55, 0, 1);
	setPassability(222, 55, 0, 1);
	setPassability(223, 55, 0, 1);
	setPassability(224, 54, 0, 1);
	setPassability(225, 54, 0, 1);
}

function quest_ig2_createBattleground()
{
	setPassability(112, 151, 0, 0);
	setPassability(120, 151, 0, 0);
	setPassability(129, 150, 0, 0);
	setPassability(130, 150, 0, 0);
	setPassability(133, 150, 0, 0);
	setPassability(134, 150, 0, 0);
	setPassability(136, 132, 0, 0);
	setPassability(136, 133, 0, 0);
	setPassability(137, 137, 0, 0);
	setPassability(138, 137, 0, 0);
	setPassability(139, 137, 0, 0);
	setPassability(114, 132, 0, 0);
	setPassability(119, 132, 0, 0);
	setPassability(120, 132, 0, 0);
	setPassability(140, 150, 0, 0);
	setPassability(140, 149, 0, 0);
	setPassability(140, 147, 0, 0);
	setPassability(140, 146, 0, 0);
}

function quest_ig2_deleteBattleground()
{
	setPassability(112, 151, 0, 1);
	setPassability(120, 151, 0, 1);
	setPassability(129, 150, 0, 1);
	setPassability(130, 150, 0, 1);
	setPassability(133, 150, 0, 1);
	setPassability(134, 150, 0, 1);
	setPassability(136, 132, 0, 1);
	setPassability(136, 133, 0, 1);
	setPassability(137, 137, 0, 1);
	setPassability(138, 137, 0, 1);
	setPassability(139, 137, 0, 1);
	setPassability(114, 132, 0, 1);
	setPassability(119, 132, 0, 1);
	setPassability(120, 132, 0, 1);
	setPassability(140, 150, 0, 1);
	setPassability(140, 149, 0, 1);
	setPassability(140, 147, 0, 1);
	setPassability(140, 146, 0, 1);
}

function quest_hd2_AntidasGuard()
{
	dlgTeleportTo(169, 230, 0, SE, 1070);
	dlgTeleportTo(167, 227, 0, E, 1400);
	dlgTeleportTo(173, 227, 0, W, 1401);
	dlgTeleportTo(167, 223, 0, NE, 1390);
	dlgTeleportTo(173, 223, 0, NW, 1391);
	dlgCreateCharacter("Daratan Captain", 1880, 1880, 171, 230, 0, S);
	dlgCreateCharacter("Daratan Spearman", 1881, 1881, 168, 228, 0, SE);
	dlgCreateCharacter("Daratan Spearman", 1882, 1882, 172, 228, 0, SW);
	addParty(hd2Daratan, 0);
	addCharToParty(1060, hd2Daratan, fighter);
	addCharToParty(1070, hd2Daratan, fighter);
	addCharToParty(1880, hd2Daratan, fighter);
	addCharToParty(1400, hd2Daratan, fighter);
	addCharToParty(1401, hd2Daratan, fighter);
	addCharToParty(1390, hd2Daratan, fighter);
	addCharToParty(1391, hd2Daratan, fighter);
	addCharToParty(1881, hd2Daratan, fighter);
	addCharToParty(1882, hd2Daratan, fighter);
}

function quest_hd2_IGSoldiers()
{
	dlgTeleportTo(170, 227, 0, N, 1130);
	dlgCreateCharacter("Imperial Guard Elite", 1870, 1870, 169, 226, 0, N);
	dlgCreateCharacter("Imperial Guard Elite", 1871, 1871, 171, 226, 0, N);
	dlgCreateCharacter("Imperial Guard Elite", 1872, 1872, 171, 225, 0, N);
	dlgCreateCharacter("Imperial Guard Elite", 1873, 1873, 169, 225, 0, N);
	dlgCreateCharacter("Imperial Guard Elite", 1874, 1874, 169, 224, 0, N);
	dlgCreateCharacter("Imperial Guard Elite", 1875, 1875, 171, 224, 0, N);
	addParty(hd2Soldiers, 0);
	addCharToParty(1130, hd2Soldiers, fighter);
	addCharToParty(1870, hd2Soldiers, fighter);
	addCharToParty(1871, hd2Soldiers, fighter);
	addCharToParty(1872, hd2Soldiers, fighter);
	addCharToParty(1873, hd2Soldiers, fighter);
	addCharToParty(1874, hd2Soldiers, fighter);
	addCharToParty(1875, hd2Soldiers, fighter);
}

function tsq_pickpocket_create()
{
	dlgTeleportTo(130, 47, 0, SE);
	dlgCreateCharacter("Livia", 2065, 2065, 129, 47, 0, E);
	dlgCreateCharacter("傭兵", 2066, 2066, 131, 46, 0, NW);
	dlgCreateCharacter("Ordu", 2067, 2067, 136, 31, 0, N);
	addParty(tsqpickpocketparty, 0);
	addCharToParty(2065, tsqpickpocketparty, fighter);
	addCharToParty(2066, tsqpickpocketparty, fighter);
	addCharToParty(2067, tsqpickpocketparty, fighter);
}


function tg2_createGoldAmbush()
{
	TG2_Ambush_Level.showObjects();
	dlgCreateCharacter("傭兵", 1945, 1945, 69, 109, 0, E);
	dlgCreateCharacter("傭兵", 1946, 1946, 70, 113, 0, E);
	dlgCreateCharacter("傭兵", 1947, 1947, 67, 109, 0, E);
	dlgCreateCharacter("傭兵", 1948, 1948, 68, 113, 0, E);
	dlgCreateCharacter("傭兵", 1949, 1949, 66, 109, 0, E);
	dlgCreateCharacter("傭兵", 1950, 1950, 65, 113, 0, E);
	dlgCreateCharacter("商人", 1951, 1951, 69, 111, 0, E);
	dlgCreateCharacter("奴隷", 1952, 1952, 68, 110, 0, E);
	dlgCreateCharacter("奴隷", 1953, 1953, 67, 112, 0, E);
	addParty(tg2_mercenaries, 0);
	addCharToParty(1945, tg2_mercenaries, fighter);
	addCharToParty(1946, tg2_mercenaries, fighter);
	addCharToParty(1947, tg2_mercenaries, fighter);
	addCharToParty(1948, tg2_mercenaries, fighter);
	addCharToParty(1949, tg2_mercenaries, fighter);
	addCharToParty(1950, tg2_mercenaries, fighter);
	dlgCreateCharacter("盗賊", 1940, 1940, 74, 107, 0, NW);
	dlgCreateCharacter("盗賊", 1941, 1941, 76, 108, 0, W);
	dlgCreateCharacter("盗賊", 1942, 1942, 72, 116, 0, SW);
	dlgCreateCharacter("盗賊", 1943, 1943, 73, 116, 0, SW);
	addParty(tg2_thieves, 0);
	addCharToParty(1, tg2_thieves, fighter);
	addCharToParty(1940, tg2_thieves, fighter);
	addCharToParty(1941, tg2_thieves, fighter);
	addCharToParty(1942, tg2_thieves, fighter);
	addCharToParty(1943, tg2_thieves, fighter);
	dlgStealthPose(1940);
	dlgStealthPose(1941);
	dlgStealthPose(1942);
	dlgStealthPose(1943);
}

function tg2_createGoldAmbushFake()
{
	TG2_Ambush_Level.showObjects();
	dlgCreateCharacter("商人", 1951, 1951, 69, 111, 0, E);
	dlgCreateCharacter("奴隷", 1952, 1952, 68, 110, 0, E);
	dlgCreateCharacter("奴隷", 1953, 1953, 67, 112, 0, E);
	dlgCreateCharacter("盗賊", 1940, 1940, 74, 107, 0, NW);
	dlgCreateCharacter("盗賊", 1941, 1941, 76, 108, 0, W);
	dlgCreateCharacter("盗賊", 1942, 1942, 72, 116, 0, SW);
	dlgCreateCharacter("盗賊", 1943, 1943, 73, 116, 0, SW);
	dlgStealthPose(1940);
	dlgStealthPose(1941);
	dlgStealthPose(1942);
	dlgStealthPose(1943);
}

function tg2_finishQuest()
{
	TG2_Ambush_Level.hideObjects();
	dlgDeleteCharacter(1940);
	dlgDeleteCharacter(1941);
	dlgDeleteCharacter(1942);
	dlgDeleteCharacter(1943);
	dlgDeleteCharacter(1945);
	dlgDeleteCharacter(1946);
	dlgDeleteCharacter(1947);
	dlgDeleteCharacter(1948);
	dlgDeleteCharacter(1949);
	dlgDeleteCharacter(1950);
	dlgDeleteCharacter(1951);
	dlgDeleteCharacter(1952);
	dlgDeleteCharacter(1953);
}

function tg3_createMob()
{
	TG3_Mob_Level.showObjects();
	tg3_mob_prop_26.isrenderenabled = false;
	dlgCreateCharacter("Mob Leader", 1955, 1955, 82, 81, 0, N);
	dlgCreateCharacter("Mob Member", 1956, 1956, 83, 80, 0, N);
	dlgCreateCharacter("Mob Member", 1957, 1957, 80, 79, 0, N);
	dlgCreateCharacter("Mob Member", 1958, 1958, 78, 78, 0, N);
	dlgCreateCharacter("Mob Member", 1959, 1959, 81, 77, 0, N);
	dlgCreateCharacter("Mob Member", 1960, 1960, 84, 77, 0, N);
	addParty(tg3_mob, 0);
	addCharToParty(1955, tg3_mob, fighter);
	addCharToParty(1956, tg3_mob, fighter);
	addCharToParty(1957, tg3_mob, fighter);
	addCharToParty(1958, tg3_mob, fighter);
	addCharToParty(1959, tg3_mob, fighter);
	addCharToParty(1960, tg3_mob, fighter);
	dlgCreateCharacter("盗賊", 1961, 1961, 80, 93, 0, S);
	dlgCreateCharacter("盗賊", 1962, 1962, 82, 93, 0, S);
	dlgCreateCharacter("盗賊", 1963, 1963, 83, 92, 0, S);
	addParty(tg3_thieves, 0);
	addCharToParty(1, tg3_thieves, fighter);
	addCharToParty(1961, tg3_thieves, fighter);
	addCharToParty(1962, tg3_thieves, fighter);
	addCharToParty(1963, tg3_thieves, fighter);
}

function tg3_createGuards()
{
	TG3_Gate_Level.showObjects();
	dlgCreateCharacter("Gate Guard", 1969, 1969, 81, 58, 0, N);
	dlgCreateCharacter("Gate Guard", 1970, 1970, 77, 58, 0, N);
	dlgCreateCharacter("Gate Crossbowman", 1971, 1971, 76, 54, 1, N);
	addParty(tg3_guard, 0);
	addCharToParty(1969, tg3_guard, fighter);
	addCharToParty(1970, tg3_guard, fighter);
	addCharToParty(1971, tg3_guard, fighter);
}

function tg3_deleteGuards()
{
	dlgDeleteCharacter(1969);
	dlgDeleteCharacter(1970);
	dlgDeleteCharacter(1971);
	dlgDeleteDeadCharacters();
	TG3_Gate_Level.hideObjects();
}

function tg3_createMercs()
{
	TG3_Merc_Level.showObjects();
	tg3_merc_prop_09.isrenderenabled = false;
	tg3_merc_prop_10.isRenderEnabled = false;
	setPassability(55, 9, 0, 0);
	setPassability(56, 9, 0, 0);
	dlgCreateCharacter("Mercenaries Leader", 1972, 1972, 83, 19, 0, SW);
	dlgCreateCharacter("傭兵", 1973, 1973, 62, 10, 0, W);
	dlgCreateCharacter("傭兵", 1974, 1974, 84, 17, 0, W);
	dlgCreateCharacter("傭兵", 1977, 1977, 84, 16, 0, W);
	
	if(aod.quest_tg2_foughtMercs)
	{
		dlgCreateCharacter("傭兵", 1976, 1976, 63, 11, 0, W);
		dlgCreateCharacter("傭兵", 1975, 1975, 63, 9, 0, W);
	}
	
	else
	{
		dlgCreateCharacter("傭兵", 1976, 1976, 80, 20, 0, S);
		dlgCreateCharacter("傭兵", 1975, 1975, 81, 20, 0, S);	
	}
	
	addParty(tg3_mercs, 0);
	addCharToParty(1972, tg3_mercs, fighter);
	addCharToParty(1973, tg3_mercs, fighter);
	addCharToParty(1974, tg3_mercs, fighter);
	addCharToParty(1975, tg3_mercs, fighter);
	addCharToParty(1976, tg3_mercs, fighter);
	addCharToParty(1977, tg3_mercs, fighter);
}

function tg3_deleteMercs()
{
	dlgDeleteCharacter(1972);
	dlgDeleteCharacter(1973);
	dlgDeleteCharacter(1974);
	dlgDeleteCharacter(1975);
	dlgDeleteCharacter(1976);
	dlgDeleteCharacter(1977);
	dlgDeleteDeadCharacters();
	TG3_Merc_Level.hideObjects();
}

function tg3_deleteAmbush()
{
	dlgDeleteCharacter(1978);
	dlgDeleteCharacter(1979);
	dlgDeleteCharacter(1980);
	dlgDeleteCharacter(1981);
	dlgDeleteCharacter(1982);
	dlgDeleteDeadCharacters();
	TG3_Wall_Level.hideObjects();
}

function tg3_deleteRobbers()
{
	dlgDeleteCharacter(1978);
	dlgDeleteCharacter(1979);
	dlgDeleteCharacter(1980);
	dlgDeleteCharacter(1981);
	dlgDeleteCharacter(1982);
	dlgDeleteDeadCharacters();
}

function hd2_shantyTownGang()
{
	dlgTeleportTo(151, 13, 0, W, 1891);
	dlgCreateCharacter("Gang Member", 1978, 1978, 150, 13, 0, E);
	dlgCreateCharacter("Gang Member", 1979, 1979, 150, 12, 0, E);
	dlgCreateCharacter("Gang Member", 1980, 1980, 150, 14, 0, E);
	dlgCreateCharacter("Gang Member", 1981, 1981, 149, 11, 0, E);
	dlgCreateCharacter("Gang Member", 1982, 1982, 149, 15, 0, E);
	addParty(Hd2_Gang, 0);
	addCharToParty(1978, Hd2_Gang, fighter);
	addCharToParty(1979, Hd2_Gang, fighter);
	addCharToParty(1980, Hd2_Gang, fighter);
	addCharToParty(1981, Hd2_Gang, fighter);
	addCharToParty(1982, Hd2_Gang, fighter);
}

function tg3_deleteShantyTownGang()
{
	dlgDeleteCharacter(1978);
	dlgDeleteCharacter(1979);
	dlgDeleteCharacter(1980);
	dlgDeleteCharacter(1981);
	dlgDeleteCharacter(1982);
	dlgDeleteCharacter(1940); 
	dlgDeleteCharacter(1941);
	dlgDeleteDeadCharacters();
}

function ag2FireStart()
{
	AG2Fire.showObjects();
	ag2_ag_door_01.isRenderEnabled = false;
}

function CreateTeronBandits()
{
	dlgCreateCharacter("賊頭", 1550, 1550, 32, 101, 0, SW);
	dlgCreateCharacter("賊", 1551, 1551, 26, 100, 0, NE);
	dlgCreateCharacter("賊", 1553, 1553, 34, 100, 0, W);
	dlgCreateCharacter("賊", 1554, 1554, 28, 102, 0, SW);
	dlgCreateCharacter("賊", 1555, 1555, 20, 109, 0, NW);
	dlgCreateCharacter("賊", 1556, 1556, 26, 111, 0, NW);
}

function finishedTeronBandits()
{
	teron_banditCamp_prisionerCage.isRenderEnabled = false;
	teron_banditCamp_emptyCage.isRenderEnabled = true;
	VCO_tiberius_cage.setactive(false);
	dlgDeleteCharacter(1550);
	dlgDeleteCharacter(1551);
	dlgDeleteCharacter(1553);
	dlgDeleteCharacter(1554);
	dlgDeleteCharacter(1555);
	dlgDeleteCharacter(1556);
}

function emptyTgTavern()
{
	dlgDeleteCharacter(1100);
	dlgDeleteCharacter(1105);
	dlgDeleteCharacter(1110);
	dlgDeleteCharacter(1290);
	dlgDeleteCharacter(1300);
}

function finishedTG1Mandate()
{
	dlgTeleportTo(232, 67, 0, S, 1930);
	dlgTeleportTo(222, 46, 0, S, 1800);
	dlgTeleportTo(241, 54, 0, W, 1801);
	dlgTeleportTo(242, 44, 0, N, 1802);
	dlgTeleportTo(219, 46, 0, S, 1803);
	dlgTeleportTo(227, 49, 0, E, 1804);
	dlgTeleportTo(227, 57, 0, E, 1805);
	dlgTeleportTo(227, 60, 0, E, 1806);
	dlgTeleportTo(242, 48, 0, W, 1807);
	sc1802.setMeshHidden(i_box, true);
	sc1803.setMeshHidden(i_chest, true);
	sc1804.setMeshHidden(i_box, true);
	sc1806.setMeshHidden(i_box, true);
	dlgSetAmbientAnimation(1930);
	dlgSetAmbientAnimation(1800);
	dlgSetAmbientAnimation(1801);
	dlgSetAmbientAnimation(1802);
	dlgSetAmbientAnimation(1803);
	dlgSetAmbientAnimation(1804);
	dlgSetAmbientAnimation(1805);
	dlgSetAmbientAnimation(1806);
	dlgSetAmbientAnimation(1807);
}