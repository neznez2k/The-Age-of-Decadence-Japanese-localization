$phrase_DamageLine_CS = "クリティカル！";
$phrase_DamageLine_bleeding = "出血！";
$phrase_DamageLine_poisoned = "Poisoned!";
$phrase_DamageLine_crippled = "Crippled!";
$phrase_DamageLine_burned = "On Fire!";
$phrase_DamageLine_acid = "Acid!";
$phrase_DamageLine_statpenalty = "ステータスダメージ！";
$phrase_DamageLine_armorpenalty = "鎧にダメージ！　ダメージ耐性が<amount>減少";
$phrase_DamageLine_missed = "ミス！";
$phrase_DamageLine_dodged = "回避！";
$phrase_DamageLine_blocked = "ブロック！";
$phrase_DamageLine_appenalty = "Staggered! AP reduced by <amount>";
$phrase_DamageLine_shield_bash = "シールドバッシュ！";
$phrase_DamageLine_push = "プッシュ！";
$phrase_DamageLine_CA = "反撃！";
$phrase_DamageLine_AoO = "追撃！";
$phrase_DamageLine_IA = "割り込み攻撃！";
$phrase_DamageLine_dodgepenalty = "回避ペナルティ！-<amount>（<turns>ターン）";
$phrase_DamageLine_blockpenalty = "ブロックペナルティ！-<amount>（<turns>ターン）";
$phrase_DamageLine_thcpenalty = "アタックペナルティ！-<amount>（<turns>ターン）";
$phrase_DamageLine_net = "拘束された！";
$phrase_DamageLine_bolas_head = "窒息！";
$phrase_DamageLine_bolas_legs = "移動不能！";
$phrase_DamageLine_SP = "+<amount> SP";

//neutral greetings
$phrase_CharacterBlock_neutral_greeting0 = "やあ。";
$phrase_CharacterBlock_neutral_greeting1 = "こんにちは、 <charname>。";

//friendly greetings
$phrase_CharacterBlock_friendly_greeting0 = "Glad to see you, <charname>!";
$phrase_CharacterBlock_friendly_greeting1 = "Hi there.";

// Barks

function bark_TRN_DaratanGuard(%ID)
{
	%text = "Keep moving.";
	if(aod.pc_member_daratan)
		%text = "\"Praetor!\" The guard salutes you with a clenched fist against his chest.";
	else if(aod.pc_member_guards)
		%text = "Watch yourself, soldier.";
	else if(aod.pc_member_thieves)
		%text = "Touch something and I'll chop your hand off.";
   sayPhrase(%ID, %text);
}

function bark_NPC_fulvio(%ID)
{
	%text = "If it's business, talk to Neleos.";
	if(aod.pc_member_assassins)
		%text = "Still alive, <charname>?";
   sayPhrase(%ID, %text);
}

function bark_TRN_TavernGuard(%ID)
{
	%RDM = getRandom(0, 2);
	switch(%RDM)
	{
		case 0: %text = "No loitering. It's a classy fucking establishment.";
		case 1: %text = "Invitations only.";
		case 2: %text = "The fuck you want?";
	}
	if(aod.pc_member_thieves)
	{
		%RDM = getRandom(0, 3);
		switch(%RDM)
		{
			case 0: %text = "Look at you, <charname>. All dressed up and nowhere to go.";
			case 1: %text = "Stay out of trouble, <charname>.";
			case 2: %text = "Cado's been asking about you.";
			case 3: %text = "Keeping busy?";
		}
	}
	else if(aod.pc_member_assassins)
		%text = "Don't fucking tell me you're here to *work*.";
	else if(aod.pc_member_daratan)
		%text = "Right this way, guv'ner.";
   sayPhrase(%ID, %text);
}

function bark_GEN_Guard(%ID)
{
	%RDM = getRandom(0, 2);
	switch(%RDM)
	{
		case 0: %text = "Whatcha looking at?";
		case 1: %text = "Is there a problem?";
		case 2: %text = "Move along.";
	}
	sayPhrase(%ID, %text);
}

function bark_TRN_citizen(%ID)
{
	%RDM = getRandom(0, 5);
	switch(%RDM)
	{
		case 0: %text = "Good day to you.";
		case 1: %text = "Can I help you?";
		case 2: %text = "What is it?";
		case 3: %text = "I'm waiting for someone.";
		case 4: %text = "Not right now.";
		case 5: %text = "Do I know you?";
	}
	if(aod.pc_member_daratan)
		%text = "My <lord/lady>.";
	sayPhrase(%ID, %text);
}

function bark_TRN_IG(%ID)
{
	%text = "Move along. Nothing to see here.";
	if(aod.pc_member_assassins)
	{
		%RDM = getRandom(0, 2);
		switch(%RDM)
		{
			case 0: %text = "Get out of here, backstabber.";
			case 1: %text = "We don't want your kind around here.";
			case 2: %text = "Ever killed anyone in a fair fight?";
		}
	}
	else if(aod.pc_member_daratan)
		%text = "Everything's in order here, Praetor.";
	else if(aod.pc_member_thieves)
		%text = "You're lucky we don't run this shithole... yet.";
	sayPhrase(%ID, %text);
}

function bark_TRN_slave(%ID)
{
	%text = "By your leave, <master/mistress>.";
	if(aod.pc_member_daratan)
		%text = "I live to serve, <master/mistress>.";
   sayPhrase(%ID, %text);
}

function bark_MTY_raider(%ID)
{
	if(aod.mty_meetingRaiders)
	{
		%RDM = getRandom(0, 3);
		switch(%RDM)
		{
			case 0: %text = "Talk to Daneus. He's back there.";
			case 1: %text = "Are you talking to me?";
			case 2: %text = "Great! More freeloaders!";
			case 3: %text = "The fuck you looking at?";
		}
	}
	
	if(aod.mty_RaidersWon)
	{
		%RDM = getRandom(0, 3);
		switch(%RDM)
		{
			case 0: %text = "Looking for Daneus? He's inside, waiting for you.";
			case 1: %text = "Fucking archers, eh? I thought we were as good as dead.";
			case 2: %text = "You did well, <charname>. Held your end and then some.";
			case 3: %text = "Now what?";
		}
	}
   sayPhrase(%ID, %text);
}

function bark_MTY_villager(%ID)
{
	%RDM = getRandom(0, 3);
	switch(%RDM)
	{
		case 0: %text = "If you need supplies, talk to the elder.";
		case 1: %text = "Thank you for saving us!";
		case 2: %text = "The vaults are sacred. You can't go there.";
		case 3: %text = "What if more raiders come?";
	}
   sayPhrase(%ID, %text);
}

function bark_MTY_GuardDoor(%ID)
{
	%RDM = getRandom(0, 2);
	switch(%RDM)
	{
		case 0: %text = "No outsider can enter the sacred vaults.";
		case 1: %text = "You can't go inside.";
		case 2: %text = "I'm watching you.";
	}
   sayPhrase(%ID, %text);
}

function bark_MTY_GuardElder(%ID)
{
	%RDM = getRandom(0, 2);
	switch(%RDM)
	{
		case 0: %text = "Outsiders aren't allowed to go inside.";
		case 1: %text = "If you have questions, talk to the Elder.";
		case 2: %text = "I'm watching you.";
	}
   sayPhrase(%ID, %text);
}

function bark_AbyssGuard(%ID)
{
	%text = "Show's over. Go back where you came from.";
	sayPhrase(%ID, %text);
}

$bark_merchant_food0 = "Wine boiled with honey!";
$bark_merchant_food1 = "Fresh bread!";
$bark_merchant_food2 = "Figs and apricots!";
$bark_merchant_food3 = "Salt fish, eggs, and cheese!";
$bark_merchant_food4 = "Goat meat - the cheapest prices!";
$bark_merchant_food5 = "Grains! The finest grains!";

//weapon advertisement
$phrase_CharacterBlock_weapon_advertisement0 = "Weapons! Fine weapons! Special price, just for you!";

//alchemy ads
$phrase_CharacterBlock_alchemy_advertisement0 = "Only in this store! The best and rarest herbs and minerals!";

//misc ads
$phrase_CharacterBlock_misc_advertisement0 = "Buy our goods while supplies last!";

//goaway's
$phrase_CharacterBlock_goaway0 = "Get out.";
$phrase_CharacterBlock_goaway1 = "Go away.";

//remove weapon!
$phrase_CharacterBlock_remove_weapon0 = "武器を捨てろ。すぐに！";

//something spotted
$phrase_CharacterBlock_something_spotted0 = "You!";
$phrase_CharacterBlock_something_spotted1 = "Fresh meat!";
$phrase_CharacterBlock_something_spotted2 = "Look who's here...";
$phrase_CharacterBlock_something_spotted3 = "What do we have here?";

$phrase_SpecterBlock_something_spotted0 = "警告。";

$phrase_BrokenStoneGuardianBlock_something_spotted0 = "警告。";

//enemy spotted!
$phrase_CharacterBlock_enemy_spotted0 = "面白いことになりそうだ。";
$phrase_CharacterBlock_enemy_spotted1 = "死ぬ覚悟をするんだな！";
$phrase_CharacterBlock_enemy_spotted2 = "痛めつけてやる！";
$phrase_CharacterBlock_enemy_spotted3 = "お前がどれだけ頑丈なのか見てやる！";
$phrase_CharacterBlock_enemy_spotted4 = "お前はここで終わりだ！";
$phrase_CharacterBlock_enemy_spotted5 = "簡単そうだな。";

$phrase_SpecterBlock_enemy_spotted0 = "侵入者を検知。";

$phrase_BrokenStoneGuardianBlock_enemy_spotted0 = "侵入者を排除。";

//character is bored
$phrase_CharacterBlock_bored0 = "Slow day...";

//Combat
//threats
$phrase_CharacterBlock_combat_generic0 = "おい、モタモタするな。";
$phrase_CharacterBlock_combat_generic1 = "お前は大したことなさそうだ。";
$phrase_CharacterBlock_combat_generic2 = "痛めつけてやる。";
$phrase_CharacterBlock_combat_generic3 = "さっさと終わらせてやる。";

//character feels pain
$phrase_CharacterBlock_combat_pain0 = "クソが！";
$phrase_CharacterBlock_combat_pain1 = "くそっ、負傷した！";
$phrase_CharacterBlock_combat_pain2 = "覚えてろよ！";
$phrase_CharacterBlock_combat_pain3 = "かすり傷だ！";
$phrase_CharacterBlock_combat_pain4 = "運が良かったな！";
$phrase_CharacterBlock_combat_pain5 = "ちくしょう！";

//successful attack
$phrase_CharacterBlock_combat_good_attack0 = "このッ、のろまが！";
$phrase_CharacterBlock_combat_good_attack1 = "すぐに終わらせてやる。";
$phrase_CharacterBlock_combat_good_attack2 = "お前は死んだも同然だ！";
$phrase_CharacterBlock_combat_good_attack3 = "That's gotta hurt!";
$phrase_CharacterBlock_combat_good_attack4 = "豚みたいに血が出てやがる！";
$phrase_CharacterBlock_combat_good_attack5 = "もう死ね！";
$phrase_CharacterBlock_combat_good_attack6 = "ハッ！";
$phrase_CharacterBlock_combat_good_attack7 = "長くはかからんよ。";
$phrase_CharacterBlock_combat_good_attack8 = "思ったより簡単だったな。";
$phrase_CharacterBlock_combat_good_attack9 = "羊の群れにでも戻れ！";

//vignettes
$phrase_vignettes_prof0 = "君はステュクスの漕手ギルドに足を踏み入れる。<nlo>この組織の合理的な性質はとてもわかりやすい。この部屋のどこにも警備の者はいないようだ。";
$phrase_vignettes_prof1 = "外には2人の盗賊が見張りに立っており、猿のような見た目をしていた。彼らは脇に寄り、君を中に招き入れる。<nlo>いつものように、この酒場は、笑ったり、言い争ったり、酒を飲む人で賑わっていた。<nlo>裏では戦利品がテーブルに山積みになっており、数えられたり、分けられたりするのを待っていた。<nlo>その部屋の一番奥で、カドは客を見張りながら仕事をしている。";
$phrase_vignettes_prof2 = "君はアンティダスの広間に立ち、富と権力の印に囲まれていた。<nlo>どちらを向いてもエキゾチックなタペストリーや絵画、珍しい花瓶や煌めく彫像を見ることができる。<nlo>そして絢爛とした柱が広間に建ち並び、アンティダス卿の座する玉座へと至る。";
$phrase_vignettes_prof3 = "こっちに来い、見習い。";
$phrase_vignettes_prof4 = "宿は客でいっぱいだ。何週間も、時には何ヶ月も旅をしてきた彼らは、不健康なほどの欲求を抱いていた。<nlo>彼らは安物のワインやストーブで調理された食事、そしてわずかな金でベッドを共にしてくれる女性を病的に求めている。";
$phrase_vignettes_prof5 = "隣の部屋の喧噪で、君は目を覚ます。";
$phrase_vignettes_prof6 = "宿は客でいっぱいだ。何週間も、時には何ヶ月も旅をしてきた彼らは、不健康なほどの欲求を抱いていた。<nlo>彼らは安物のワインやストーブで調理された食事、そしてわずかな金でベッドを共にしてくれる女性を病的に求めている。";
$phrase_vignettes_prof7 = "You are standing in the richly decorated halls of the Commercium.<nlo>Everywhere you look you see signs of wealth, from the silk and gold woven tapestries lining the walls to the gilded vases and intricately carved stonework.<nlo>If money is power, then the interiors are designed to convey the message that the Commercium is a very powerful guild.";

//Map Warnings
$phrase_map_leave_teron_01 = "テロンを出ますか？";
$phrase_map_leave_teron_02 = "Are you sure that you want to leave Teron? Any unsolved events will unfold without you.";
$phrase_map_leave_teron_03 = "Are you sure that you want to leave Teron? The Guards will take over the town if you don't help stop them.";
$phrase_map_leave_maadoran_01 = "Leave Maadoran?";
$phrase_map_leave_maadoran_02 = "Are you sure that you want to leave Maadoran? Any unsolved events will unfold without you.";
$phrase_map_leave_maadoran_HD = "You'd better talk to Serenas before you leave. His Lordship won't wait for you forever.";
$phrase_map_leave_maadoran_IG = "If you leave now, the events will unfold without you and you'll be expelled from the Imperial Guards.";
$phrase_map_leave_maadoran_MG = "If you leave now, the events will unfold without you and you'll be expelled from the Commercium.";
$phrase_map_leave_maadoran_AG = "If you leave now, the events will unfold without you and you'll be expelled from the Boatmen of Styx.";
$phrase_map_leave_maadoran_TG = "If you leave now, the events will unfold without you and you'll be expelled from the Forty Thieves.";
$phrase_map_leave_ganezzar_01 = "Leave for the temple?";
$phrase_map_leave_ganezzar_02 = "Are you sure that you want to leave for the temple? Any unsolved events will unfold without you.";
$phrase_map_teron_closed_01 = "Teron";
$phrase_map_teron_closed_02 = "You were expelled from Teron.";
$phrase_map_maadoran_closed_01 = "Maadoran";
$phrase_map_maadoran_closed_02 = "You were expelled from Maadoran.";
$phrase_map_maadoran_destroyed_01 = "Maadoran";
$phrase_map_maadoran_destroyed_02 = "You've awakened Galath-Athazor and destroyed Maadoran.";
$phrase_map_HA_destroyed_01 = "Maadoran";
$phrase_map_HA_destroyed_02 = "You were expelled from Maadoran. With the Imperial Guards patrolling the streets, it's not safe for you to return.";
$phrase_map_CT_closed_01 = "Caer-Tor";
$phrase_map_CT_closed_02 = "You're no longer welcome in Caer-Tor.";
$phrase_map_pass_closed_01 = "Harran's Pass";
$phrase_map_pass_closed_02 = "The Harran's Pass has been overrun by the Ordu. There's nothing left there.";
$phrase_map_arch_closed_01 = "The Arch";
$phrase_map_arch_closed_02 = "The arch has been reburied as per Gaelius' orders. Once again it rests deep beneath the sands, waiting to be rediscovered.";
$phrase_map_hangar_closed_01 = "Old Facility";
$phrase_map_hangar_closed_02 = "Now that the airship is gone, there's no reason to go back there.";

function getGanezzarWarning()
{
	if(isQuestAdded(HD3) && isQuestComplete(HD3) == 0 || isQuestAdded(HD4) && isQuestComplete(HD4) == 0)
		MessageBoxYesNo($phrase_map_leave_maadoran_01, $phrase_map_leave_maadoran_HD, "leaveMaadoran(Ganezzar);", "");
	else if(aod.pc_member_guards)
		MessageBoxYesNo($phrase_map_leave_maadoran_01, $phrase_map_leave_maadoran_IG, "leaveMaadoran(Ganezzar);", "");
	else if(aod.pc_member_commercium)
		MessageBoxYesNo($phrase_map_leave_maadoran_01, $phrase_map_leave_maadoran_MG, "leaveMaadoran(Ganezzar);", "");
	else if(aod.pc_member_assassins)
		MessageBoxYesNo($phrase_map_leave_maadoran_01, $phrase_map_leave_maadoran_AG, "leaveMaadoran(Ganezzar);", "");
	else if(aod.pc_member_thieves)
		MessageBoxYesNo($phrase_map_leave_maadoran_01, $phrase_map_leave_maadoran_TG, "leaveMaadoran(Ganezzar);", "");
	else 
		MessageBoxYesNo($phrase_map_leave_maadoran_01, $phrase_map_leave_maadoran_02, "leaveMaadoran(Ganezzar);", "");
}

//specific, unique phrases
$phrase_special0 = "Test.";
$phrase_no_weapon = "Run for your lives!";

$phrase_belgutai_down = "Belgutai is down!";
$phrase_eagle_killed_belgutai = "The Eagle warriors killed Belgutai!";
$phrase_noyan_dead = "The Noyan is dead!";
$phrase_check_tiberius = "I should check on Tiberius.";
$phrase_TG4_FindJar = "You find the chest with the artefacts without any difficulty.<nlo>It's reinforced with black lead, but left unlocked. Inside, there are several compartments, one for each artefact.<nlo>The artefacts are wrapped in linen, but you can see the glow emanating from some of them through the fabric.<nlo>Suddenly, you feel light-headed and nauseated. You find the jar, take it, and close the chest.";
$phrase_IG3_antidas_dead = "Antidas is dead!";
$phrase_IG6_belgutaiBattleCry0 = "Kill them all!";
$phrase_IG6_belgutaiBattleCry1 = "Lead us!";
$phrase_IG6_belgutaiBattleCry2 = "Uragh!";
$phrase_IG6_belgutaiBattleCry3 = "For the khan!";

$phrase_END_XP_takeAntidas = "Take Antidas alive!";
$phrase_END_XP_takeMeru =  "Take Meru alive!";
$phrase_END_XP_takeGaelius =  "Take Gaelius alive!";
$phrase_END_XP_takePaullus =  "Take Paullus alive!";
$phrase_END_XP_takeNoble =  "Take the noble alive!";

$phrase_END_XP_MDN_title = "Desert near Maadoran";
$phrase_END_XP_MDN_desc = "Leave the area?";
$phrase_END_XP_RIV_title = "The Dead River";
$phrase_END_XP_RIV_desc = "Go to the temple?";
$phrase_END_XP_HGT_title = "Hellgate";
$phrase_END_XP_HGT_desc = "Leave the area?";

//Descriptions

$phrase_temple_desc1 = "You see a man slumped at the bottom of the tank. He isn't moving.";
$phrase_temple_desc2 = "You see a floating body covered in some kind of fungus. Not a pretty picture.";
$phrase_temple_desc3 = "The liquid is too murky to see anything.";
$phrase_temple_desc4 = "A life support system?";
$phrase_temple_desc5 = "You see what seems like human remains inside. Another experiment?";
$phrase_temple_desc6 = "Animal-headed statues. Warriors in power armor? Something else?";
$phrase_temple_desc7 = "The shelves are nearly empty. The few remaining scrolls have no value whatsoever.";

$phrase_innkeepers_rentRoom = "お部屋を利用されるなら、まずお支払いをお願いします！";
$phrase_innPlayer_rentRoom = "Talk to the innkeeper if you need a room to store your things.";
$phrase_graciusRoom = "グラシアスが殺された部屋だ。まだ誰も借りたがらない。";
$phrase_innExploration_oldClothes = "Old, washed out clothes and dead insects. If you had to pick one, you'd go with the insects.";
$phrase_shelvesExploration_scrolls = "Fashionable scrolls: popular philosophers, questionable poetry, erotic tales.";
$phrase_stallExploration_food1 = "Compost-grown fruits and vegetables. The smell alone can stop any thief.";
$phrase_stallExploration_food2 = "Wheat, rice, and various baked goods.";
$phrase_stallExploration_carpet1 = "Carpets for every imaginable occasion, including novelty carpet bags.";

// 