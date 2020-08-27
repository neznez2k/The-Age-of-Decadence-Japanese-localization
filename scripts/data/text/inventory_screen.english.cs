//cs defense hint
$inv_scr_cs_defense_breakdown = "Defence against Critical Strikes (vsCS):<br>- Natural - <cs_defense_skill><br>- Armor - <cs_defense_armor><br>- Shield - <cs_defense_shield><br>- Helmet - <cs_defense_helmet><br>The Natural and Shield vsCS values are cumulative with Armor and Helmet, depending on the targeted body part.";
$inv_scr_cs_defense_tags = "<cs_defense_skill> <cs_defense_armor> <cs_defense_shield> <cs_defense_helmet>";
$inv_scr_cs_defense_positive_is_good = "1 1 1 1";

//armor dr hint
$inv_scr_armor_dr_breakdown = "Damage Resistance (DR):\n- Armor - <dr_armor><br>- Helmet - <dr_helmet><br>DR values aren't cumulative. Helmet's DR (if any) is used to determine the damage received during attacks targeting your head. Armor's DR handles all other attacks.";
$inv_scr_armor_dr_tags = "<dr_armor> <dr_helmet>";
$inv_scr_armor_dr_positive_is_good = "1 1";

//item drop
$inv_screen_drop_message_title = "Confirm Drop";
$inv_screen_drop_message_text = "Are you sure want to drop this item?";

//actions journal
$inv_action_journal[0] = "EQUIP";
$inv_action_journal[1] = "REMOVE";
$inv_action_journal[2] = "MOVE";
$inv_action_journal[3] = "USE";
$inv_action_journal[4] = "RELOAD";
$inv_action_journal[5] = "UNLOAD";
$inv_action_journal[6] = "DROP";
loadStringCollection("InvActionJournal", "inv_action_journal");

//inv context menu
$inv_usage_string_equip = "EQUIP";
$inv_usage_string_remove = "REMOVE";
$inv_usage_string_use = "USE";
$inv_usage_string_use_on = "USE ON";
$inv_usage_string_reload_left = "RELOAD LEFT";
$inv_usage_string_reload_right = "RELOAD RIGHT";
$inv_usage_string_reload = "RELOAD";
$inv_usage_string_unload = "UNLOAD";
$inv_usage_string_drop = "DROP";
$inv_usage_string_interact = "INTERACT";

$inv_usage_reload_xbow_format = "RELOAD WITH <ammo> (<metal>) <poisoned> <sharpened> [<amount>/<capacity>]";