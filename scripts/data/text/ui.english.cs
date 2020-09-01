//Main Menu
$quit_confirm_caption = "確認";
$quit_confirm_message = "本当に終了しますか？";

//Loading Screen
$loading_objects = "LOADING OBJECTS";

//Play GUI
$cursor_string[0] = "AP";
$cursor_string[1] = "IA";
$cursor_string[2] = "AoO";
loadStringCollection("Cursor Strings", "cursor_string");

// Cursor hint
$cursor_hint[0] = "HP";
$cursor_hint[1] = "THC";
$cursor_hint[2] = "CS";
$cursor_hint[3] = "ADC";
loadStringCollection("Cursor Hints", "cursor_hint");

$main_panel[0] = "HP";
$main_panel[1] = "AP";
loadStringCollection("Main Panel", "main_panel");

$door_normal = "扉";
$door_locked_key = "Unlock the door";
$door_locked_lockpick = "[lockpick] Pick the door";
$door_locked_none = "この扉は鍵がかかっている";
$door_locked_barred = "The door is barred";
$door_locked_key_needed = "You need a key to open it.";
$container_locked_key = "Unlock the container";
$container_locked_lockpick = "[lockpick] Pick the container";
$container_locked_none = "The container is locked";
$trap_disarm = "[traps] Disarm the trap";

$usage_string_reload = "リロード（R)";
$usage_string_drink = "DRINK";

$usage_string_pa_apis = "APIS";
$usage_string_pa_horus = "HORUS";
$usage_string_pa_anubis = "ANUBIS";
$usage_string_pa_ra = "RA";

$ammo_desc[0] = "Regular";
$ammo_desc[1] = "Barbed";
$ammo_desc[2] = "Piercing";
loadStringCollection("Ammo Desc", "ammo_desc");
$ammo_desc_short[0] = "REG";
$ammo_desc_short[1] = "BARB";
$ammo_desc_short[2] = "PRC";
loadStringCollection("Ammo Desc Short", "ammo_desc_short");
$ammo_none = "弾がない";
$ammo_poisoned = "POISONED";
$ammo_sharpened = "SHARPENED";

$attack_string[0] = "素早い攻撃";
$attack_string[1] = "通常攻撃";
$attack_string[2] = "強攻撃";
$attack_string[3] = "投擲";
$attack_string[4] = "狙う：頭";
$attack_string[5] = "動脈裂断";
$attack_string[6] = "狙う：胴体";
$attack_string[7] = "狙う：脚";
$attack_string[8] = "狙う：腕";
$attack_string[9] = "狙う：脚";
$attack_string[10] = "狙う：腕";
$attack_string[11] = "スウィング";
$attack_string[12] = "CLEAVE";
$attack_string[13] = "DOUBLE TAP";
$attack_string[14] = "疾風突き";
$attack_string[15] = "IMPALE";
$attack_string[16] = "旋風斬";
$attack_string[17] = "マルチショット";
$attack_string[18] = "バースト";
$attack_string[19] = "エンタングル";
$attack_string[20] = "投擲　酸";
$attack_string[21] = "THROW: LEGS";
$attack_string[22] = "THROW: HEAD";
$attack_string[23] = "フェイント";
$attack_string[24] = "シールドバッシュ";
$attack_string[25] = "フラスコ投げ";
$attack_string[26] = "爆弾投げ";
$attack_string[27] = "旋風斬";
$attack_string[28] = "QUICK JAB";
$attack_string[29] = "SNIPE";
$attack_string[30] = "THROW OPPONENT";
$attack_string[31] = "SLASH";
$attack_string[32] = "強攻撃";
$attack_string[33] = "DOUBLE STRIKE";
$attack_string[34] = "SCORPION CLAW REGULAR";
$attack_string[35] = "SCORPION TAIL";
$attack_string[36] = "強攻撃";
$attack_string[37] = "TRIPLE STRIKE";
$attack_string[38] = "PUSH";
$attack_string[39] = "ELDER GOD HAND ATTACK";
$attack_string[40] = "ELDER TENTACLE ATTACK";
$attack_string[41] = "ELDER MIND ATTACK REGULAR";
$attack_string[42] = "ELDER MIND ATTACK SHIELDED";
$attack_string[43] = "THROW ACID";
$attack_string[44] = "ノックダウン";
$attack_string[45] = "ノックダウン";
$attack_string[46] = "SCOLOPENDRA";
$attack_string[47] = "旋風斬";
$attack_string[48] = "旋風斬";
loadStringCollection("Usage Mode Strings", "attack_string");

$playgui_item_tooltip_format =   "<font:Kinto Sans Bold:25>" @
                                 "<spush><color:FFFFFF>効果<spop><br>" @ 
                                 "<font:Kinto Sans:25><spush><color:AB9661><effect><spop><br>" @
                                 "<font:Kinto Sans Bold:25><spush><color:FFFFFF>クリティカル効果<spop><br>" @
                                 "<font:Kinto Sans:25><spush><color:AB9661><critical_effect><spop><br>";
//Fast
$attack_tooltip_effect[0] = " - 低ダメージ<br> - 命中率　＋15% <br> - クリティカル率  - 15% <br> - アーマーダメージ率　 - 15%";
$attack_tooltip_critical_effect[0] = " - 装甲貫通 <br> - クリティカルダメージ";
//Regular
$attack_tooltip_effect[1] = " - 通常ダメージ";
$attack_tooltip_critical_effect[1] = " - 装甲貫通 <br> - クリティカルダメージ";
//Power
$attack_tooltip_effect[2] = " - 高ダメージ <br> - 命中率　 - 15% <br> - クリティカル率 　＋15% <br> - アーマーダメージ率　＋15%";
$attack_tooltip_critical_effect[2] = " - 装甲貫通 <br> - クリティカルダメージ";
//Throw
$attack_tooltip_effect[3] = " - 高ダメージ <br> - 命中率　-10% <br> - クリティカル率 　+10% <br> - アーマーダメージ率　+15% <br>- Passive chance +5%";
$attack_tooltip_critical_effect[3] = " - クリティカルダメージ";
//Aimed: Head
$attack_tooltip_effect[4] = " - 高ダメージ <br> - 命中率　  - 25%<br> - クリティカル率 　 - 15%<br>- Penalty to Attack (THC)<br>- Amount: 5% + (Weapon AP-3) x2% for 3 turns";
$attack_tooltip_critical_effect[4] = "- Knockdown 2 turns, thrown 1 tile<br>- Reduces Perception by 1 <br>- Minimal Damage 1 point<br> - クリティカルダメージ<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>Critical Chance Formula<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>(CS - VsCS) + (STR-7) x10";
//Arterial Strike
$attack_tooltip_effect[5] = " - 高ダメージ <br> - 命中率　 -25% <br> - アーマーダメージ率　-25%<br> - クリティカル率 　-25%";
$attack_tooltip_critical_effect[5] = " - 装甲貫通 <br> - クリティカルダメージ <br>- Bleeding: 4 damage for 3 turns<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>Critical Chance Formula<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>(CS - VsCS) + (PER-7) x10";
//Aimed: Torso
$attack_tooltip_effect[6] = "- Normal Damage <br> - 命中率　 -10% <br> - 装甲貫通 by 30%";
$attack_tooltip_critical_effect[6] = " - 装甲貫通 by 70% <br>- Reduces armor DR by 2 <br> - クリティカルダメージ <br>- Reduces Constitution by 1<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>Critical Chance Formula<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>(CS - VsCS) + (PER-7) x10";
//Aimed: Legs
$attack_tooltip_effect[7] = "- Low Damage <br> - 命中率　 -10% <br> - アーマーダメージ率　-50% <br>- Penalty to Dodge<br>- Amount: 5% + (Weapon AP-3) x5% for 3 turns";
$attack_tooltip_critical_effect[7] = "- Double Penalty to Dodge<br>- Reduces Dexterity by 1<br>- Cripple 2 turns (doubles movement cost)<br>- Minimal Damage 1 point<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>Critical Chance Formula<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>(CS - VsCS) + (STR-7) x10";
//Aimed: Arms
$attack_tooltip_effect[8] = "- Low Damage <br> - 命中率　 -10% <br> - アーマーダメージ率　-50% <br>- Penalty to Attack (THC)<br>- Amount: 5% + (Weapon AP-3) x5% for 3 turns";
$attack_tooltip_critical_effect[8] = "- Double Penalty to Attack (THC)<br>- Reduces Strength by 1<br>- Disarm (weapon removed from hand slot)<br>- Minimal Damage 1 point<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>Critical Chance Formula<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>(CS - VsCS) + (STR-7) x10";
//Aimed: Legs - Ranged
$attack_tooltip_effect[9] = "- Low Damage <br> - 命中率　 -10% <br> - アーマーダメージ率　-50% <br>- Penalty to Dodge<br>- Amount: 5% + (Weapon AP-3) x5% for 3 turns";
$attack_tooltip_critical_effect[9] = "- Double Penalty to Dodge<br>- Reduces Dexterity by 1<br>- Cripple 2 turns (doubles movement cost)<br>- Minimal Damage 1 point<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>Critical Chance Formula<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>(CS - VsCS) + (PER-7) x10";
//Aimed: Arms - Ranged
$attack_tooltip_effect[10] = "- Low Damage <br> - 命中率　 -10% <br> - アーマーダメージ率　-50% <br>- Penalty to Attack (THC)<br>- Amount: 5% + (Weapon AP-3) x5% for 3 turns";
$attack_tooltip_critical_effect[10] = "- Double Penalty to Attack (THC)<br>- Reduces Strength by 1<br>- Disarm (weapon removed from hand slot)<br>- Minimal Damage 1 point<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>Critical Chance Formula<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>(CS - VsCS) + (PER-7) x10";
//Swing
$attack_tooltip_effect[11] = "- Normal Damage <br> - 命中率　 -10%<br> - アーマーダメージ率　-10%<br>- Covers the three tiles in front of the character";
$attack_tooltip_critical_effect[11] = " - クリティカルダメージ <br>- Knockdown 1 turn, thrown 2 tiles<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>Critical Chance Formula<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>(CS - VsCS) + (STR-7) x10";
//Cleave
$attack_tooltip_effect[12] = " - 高ダメージ <br> - 命中率　 -20% <br> - クリティカル率 　+35% <br> - アーマーダメージ率　+25%";
$attack_tooltip_critical_effect[12] = " - 装甲貫通 <br> - クリティカルダメージ<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>Critical Chance Formula<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>(CS - VsCS) + (STR-7) x10";
//Double Tap
$attack_tooltip_effect[13] = "- Two Attacks <br>- Low Damage minus 2 points (all attacks)<br> - 命中率　 +15% <br> - クリティカル率 　-15%<br> - アーマーダメージ率　-15%";
$attack_tooltip_critical_effect[13] = " - 装甲貫通 <br> - クリティカルダメージ";
//Flurry
$attack_tooltip_effect[14] = "- Three Attacks <br>- Low Damage minus 1 point (all attacks)<br> - 命中率　 +15% <br> - クリティカル率 　-15%<br> - アーマーダメージ率　-25%";
$attack_tooltip_critical_effect[14] = " - 装甲貫通 <br> - クリティカルダメージ";
//Impale
$attack_tooltip_effect[15] = " - 高ダメージ <br> - 命中率　 -10%";
$attack_tooltip_critical_effect[15] = " - 装甲貫通 <br> - クリティカルダメージ <br>- Impales Opponent for 2 turns <br>- Damages Constitution for 1 point<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>Critical Chance Formula<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>(CS - VsCS) + (STR-7) x10";
//Whirlwind
$attack_tooltip_effect[16] = "- Low Damage <br> - 命中率　 -20%<br> - アーマーダメージ率　-20%<br> - クリティカル率 　-20%<br>- Can hit every opponent on 8 squares surrounding your character";
$attack_tooltip_critical_effect[16] = " - クリティカルダメージ <br>- Knockdown 1 turn, thrown 1 tile<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>Critical Chance Formula<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>(CS - VsCS) + (STR-7) x10";
//Multishot
$attack_tooltip_effect[17] = "- Low Damage <br> - 命中率　 +10% <br>- Fires 3 arrows in a arc";
$attack_tooltip_critical_effect[17] = " - クリティカルダメージ";
//Burst
$attack_tooltip_effect[18] = "- Normal Damage <br> - 命中率　 +10% <br>- Fires 5 bolts in a row";
$attack_tooltip_critical_effect[18] = " - クリティカルダメージ";
//Entangle
$attack_tooltip_effect[19] = "- No Damage <br>- Lowers opponent's THC and Dodge Defense by 20 points for 1 turn<br>- Loses 6 AP for the next turn";
$attack_tooltip_critical_effect[19] = "- Lowers opponent's THC and Dodge Defense by 20 points for 2 turns <br>- Loses 6 AP for the next turn<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>Critical Chance Formula<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>(Throwing - (Victim DEX-7)) x10";
//Throw Acid
$attack_tooltip_effect[20] = "- Damages opponent's armor";
$attack_tooltip_critical_effect[20] = "- None";
//Throw Bolas: Legs
$attack_tooltip_effect[21] = "- No Damage <br>- Immobilizes opponent for 1 turn<br>- Loses 6 AP for the next turn<br>- Penalty to Dodge Defense 100% for 1 turn";
$attack_tooltip_critical_effect[21] = "- Immobilizes opponent for 2 turns<br>- Loses 6 AP for the next turn<br>- Penalty to Dodge Defense 100% for 2 turns<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>Critical Chance Formula<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>(Throwing - (Victim DEX-7)) x10";
//Throw Bolas: Head
$attack_tooltip_effect[22] = "- No Damage <br>- Chokes opponent for 1 turn<br>- Loses 8 AP for the next turn<br>- Penalty to Block and Dodge Defense 100% for 2 turns";
$attack_tooltip_critical_effect[22] = "- Chokes opponent for 2 turns<br>- Loses 8 AP for the next turn<br>- Penalty to Block and Dodge Defense 100% for 3 turns<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>Critical Chance Formula<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>(Throwing - (Victim DEX-7)) x10";
//Feint
$attack_tooltip_effect[23] = "- No Damage <br>- Switch places with the opponent<br> - アーマーダメージ率　-100%<br>- Attack chance is Dodge x10";
$attack_tooltip_critical_effect[23] = "- Switch places with the opponent, knockdown<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>Critical Chance Formula<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>((STR-7) - (Victim CON-7)) x5";
//Shield Bash
$attack_tooltip_effect[24] = "- No Damage <br>- Pushes opponent away one tile";
$attack_tooltip_critical_effect[24] = "- Knockdown 1 turn, thrown 1 tile<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>Critical Chance Formula<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>((STR-7) - (Victim CON-7)) x5";
//Throw Liquid Fire
$attack_tooltip_effect[25] = "- Damages opponent with fire, ignores DR<br>- Set tiles on fire<br>- Cross shaped area of attack";
$attack_tooltip_critical_effect[25] = "- None";
//Throw Bomb
$attack_tooltip_effect[26] = "- Damages opponent with blast";
$attack_tooltip_critical_effect[26] = "- Knockdown 1 turn, thrown 2-3 tiles<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>Critical Chance Formula<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>- Base: 25 + Center of Explosion Bonus - (Victim CON-6) x25<br>- Center of explosion adds 50% to CS chance. Distance from center of explosion lowers this value.";
//Whirlwind - Blades
$attack_tooltip_effect[27] = "- Low Damage <br> - 命中率　 -15%<br> - アーマーダメージ率　-25%<br> - クリティカル率 　-25%<br>- Can hit every opponent on 8 squares surrounding your character";
$attack_tooltip_critical_effect[27] = " - クリティカルダメージ <br><font:Kinto Sans Bold:25><spush><color:FFFFFF>Critical Chance Formula<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>(CS - VsCS) + (PER-7) x10";
//Quick Jab
$attack_tooltip_effect[28] = "- Low Damage, 25%<br> - 命中率　 +15%<br> - アーマーダメージ率　-50%";
$attack_tooltip_critical_effect[28] = "Not Used";
//Snipe
$attack_tooltip_effect[29] = " - 高ダメージ <br> - 命中率　 -10%<br> - クリティカル率 　+50% <br>- THC increases the farther the opponent is";
$attack_tooltip_critical_effect[29] = " - 装甲貫通 <br> - クリティカルダメージ";
//Feint - Throw Opponent
//$attack_tooltip_effect[30] = "- No Damage <br>- Switch places with the opponent, knockdown<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>Critical Chance Formula<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>(CS - VsCS) + ((Weapon AP-3) x2 + (STR-6) - (Victim CON-6)) x5";
//$attack_tooltip_critical_effect[30] = "- None";
//Stone Guardian - Slash
$attack_tooltip_effect[31] = "- Normal Damage";
$attack_tooltip_critical_effect[31] = " - 装甲貫通 <br> - クリティカルダメージ<br>- Knockdown 1 turn, thrown 1 tile";
//Stone Guardian - Power
$attack_tooltip_effect[32] = " - 高ダメージ <br> - 命中率　 -15% <br> - クリティカル率 　+15% <br> - アーマーダメージ率　+15%";
$attack_tooltip_critical_effect[32] = " - 装甲貫通 <br> - クリティカルダメージ<br>- Reduces armor DR by 2";
//Stone Guardian - Double Strike
$attack_tooltip_effect[33] = "- Two Attacks <br>- Low Damage minus 2 points (all attacks)<br> - 命中率　 +15% <br> - クリティカル率 　-15%<br> - アーマーダメージ率　-15%";
$attack_tooltip_critical_effect[33] = " - 装甲貫通 <br> - クリティカルダメージ";
//Construct - Leg Attack
$attack_tooltip_effect[36] = " - 高ダメージ <br> - 命中率　 -15% <br> - クリティカル率 　+15% <br> - アーマーダメージ率　+15%";
$attack_tooltip_critical_effect[36] = " - 装甲貫通 <br> - クリティカルダメージ<br>- Reduces armor DR by 2";
//Construct - Triple Strike
$attack_tooltip_effect[37] = "- Three Attacks <br>- Low Damage <br> - 命中率　 +15% <br> - クリティカル率 　-15%<br> - アーマーダメージ率　-15%";
$attack_tooltip_critical_effect[37] = " - 装甲貫通 <br> - クリティカルダメージ";
//Push
$attack_tooltip_effect[38] = "- No Damage <br>- Pushes opponent away one tile<br>- Attack chance is Strength x10";
$attack_tooltip_critical_effect[38] = "- None";
//Throw Acid - Splash
$attack_tooltip_effect[43] = "- Damages opponent's armor<br>- Cross shaped area of attack";
$attack_tooltip_critical_effect[43] = "- None";
//Hammer Knockdown
$attack_tooltip_effect[44] = "- Low Damage <br>- Knockdown 1 turn, thrown 1 tile <br> - 命中率　 -10%";
$attack_tooltip_critical_effect[44] = "- Knockdown 2 turns, thrown 1 tile <br><font:Kinto Sans Bold:25><spush><color:FFFFFF>Critical Chance Formula<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>(CS - VsCS) + (STR-7) x10";
//Strong Hammer Knockdown
$attack_tooltip_effect[45] = "- Low Damage <br>- Knockdown 1 turn, thrown 1 tile <br> - 命中率　 -10% <br> - クリティカル率 　+25%";
$attack_tooltip_critical_effect[45] = "- Knockdown 2 turns, thrown 1 tile <br><font:Kinto Sans Bold:25><spush><color:FFFFFF>Critical Chance Formula<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>(CS - VsCS) + (STR-7) x10";
//Whirlwind - 1H
$attack_tooltip_effect[47] = "- Low Damage <br> - 命中率　 -20%<br> - アーマーダメージ率　-20%<br> - クリティカル率 　-20%<br>- Can hit every opponent on 4 squares surrounding your character";
$attack_tooltip_critical_effect[47] = " - クリティカルダメージ <br>- Knockdown 1 turn, thrown 1 tile<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>Critical Chance Formula<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>(CS - VsCS) + (STR-7) x10";
//Whirlwind - Blades 1H
$attack_tooltip_effect[48] = "- Low Damage <br> - 命中率　 -15%<br> - アーマーダメージ率　-25%<br> - クリティカル率 　-25%<br>- Can hit every opponent on 4 squares surrounding your character";
$attack_tooltip_critical_effect[48] = " - クリティカルダメージ <br><font:Kinto Sans Bold:25><spush><color:FFFFFF>Critical Chance Formula<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>(CS - VsCS) + (PER-7) x10";

$combatHint_conditionalMod_header = "<b>Conditional Modifiers</b>";

$combatHint_skill = "Base Skill Value";
$combatHint_stat = "Stat modifier";
$combatHint_weapTraining = "Training";
$combatHint_weapSynergy = "Synergy";
$combatHint_perceptionEffect = "Perception";
$combatHint_weapThcMod = "Weapon Mod";
$combatHint_thcPenalty = "Injury";
$combatHint_shieldThcPenalty = "Shield";
$combatHint_helmetThcPenalty = "Helmet";
$combatHint_neurostimBonus = "Neurostim";
$combatHint_berserkPenalty = "Berserk";
$combatHint_netted = "Netted";
$combatHint_armorPenalty = "Armor penalty";
$combatHint_defPenalty = "Defence penalty";
$combatHint_mobilityBonus = "Mobility Bonus";
$combatHint_weapVsBlock = "Vs Block";
$combatHint_vsRanged = "Vs Ranged";
$combatHint_con = "CON bonus";

// THC Hint
$combatHint_baseThc = "Base";
$combatHint_pureAtt = "Attack";
$combatHint_pureDef = "Defense";
$combatHint_rangePenalty = "Range penalty";
$combatHint_attackThcMod = "Attack THC Modifier";
$combatHint_facingBonus = "Facing bonus";
$combatHint_isKnockedDown = "Knockdown";
$combatHint_netted = "Netted";
$combatHint_dexBonus = "Dexterity Bonus";
$combatHint_skillBlock = "Block Skill Value";
$combatHint_skillDodge = "Dodge Skill Value";
$combatHint_immobilized = "Immobilized";
$combatHint_chocking = "Chocking";

function getEffectCursorString(%effect_name, %val1, %val2)
{
   /*switch$(%effect_name)
   {   
   CS_Mod(value)
   CS_Coef(coef)
   noKnockdown 
   blockPenalty_Coef(turns, value, value_func)
   dodgePenalty_Coef(turns, value, value_func)
   thcPenalty_Coef(turns, value, value_func)
   passiveChance_Mod(value)   
   damage_Mod(value)
   damage_Extra(type)
   feint(knockdown=true/false)
               
   case "DR_Coef": //(coef)
      return "Bypass: " @ (100 - %val1 * 100) @ "%";
   case "knockdown": //(turns)
      return "Knockdown: " @ %val1 @ " turns";
   case "statPenalty": //(stat, value)
      return "Stat Penalty: " @ %val2 @ " [" @ statIDToString(%val1) @ "]";
   case "criticalDamage": // no params
      return "Critical Damage";
   case "cripple": //(turns)
      return "Cripple: " @ %val1 @ " turns";
   case "disarm": // no params
      return "Disarm";
   case "splitShield": // no params
      return "Split Shield";
   case "impale": //(turns)
      return "Impale: " @ %val1 @ " turns";
   case "immobilize": //(turns)
      return "Immobilize: " @ %val1 @ " turns";
   case "choking": //(turns)      
      return "Choking: " @ %val1 @ " turns";
   case "slowdown": //(turns)
      return "Slowdown: " @ %val1 @ " turns";
   case "bleeding": //(turns, damage)
      return "Bleeding: " @ %val2 @ " damage for " @ %val1 @ " turns";
   case "damage_Coef": // (coef)
      return "Savage Blow: Damage" @ (%val1 * 100) @ "%";
   }
   
   return "";*/
}

// Char Creation Screen
$CCS_background = "BACKGROUND";

// Alchemy Screen
$AS_items_profile = "KaratMediumBase";
$AS_low_skill_text = "Your Alchemy skill is too low. You need <amount> points in Alchemy to create it.";

// Trade Screen
$TS_equipped_sign = "[E]";

// Save/Load Screen
$SL_msg_save = "セーブ完了。";
$SL_msg_autosave = "オートセーブ完了。";

$SL_prerelease_char = "Beta Savegames";
$SL_unnamed_char = "Nameless Character";

$SL_unreadable_save_title = "Error";
$SL_unreadable_save_msg = "Incompatible (old format), or corrupted savegame.";

$SL_mismatched_mods_save_title = "Error";
$SL_mismatched_mods_save_msg = "This save uses different mods than those which are currently loaded.";

$SL_old_save_title = "Extreme Warning";
$SL_old_save_msg = "DO NOT LOAD THIS FILE if you want to play the game without issues. This save contains old data and is very likely to CRASH your game or BREAK your progression. We strongly recommend to start a new game.<br><br>Are you ABSOLUTELY sure you want to load this game?";

$SL_prerelease_save_title = "Warning";
$SL_prerelease_save_msg = "This is a pre-release save, it may be missing some data. We recommend to start a new game.<br><br>Are you sure you want to load this game?";

$SL_overwrite_title = "Overwrite?";
$SL_overwrite_msg = "Are you sure want to overwrite this saved game?";
$SL_delete_title = "Delete?";
$SL_delete_msg = "Are you sure want to delete this saved game?";

// Gameplay messages
$gameplay_msg_ambush_title = "Ambush";
$gameplay_msg_ambush_msg = "Leave the area?";

$gameplay_msg_leave_house = "Leave the house?";
$gameplay_msg_abandoned_house_title = "Abandoned House";
$gameplay_msg_darganus_house_title = "Darganus House";
$gameplay_msg_hector_house_title = "Hector's House";