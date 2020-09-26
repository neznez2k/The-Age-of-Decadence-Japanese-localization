// max $js_quest_text items = 32
// addQuest(TG2a);
// Vignette Quests

function Quest_VignetteLoremaster()
{
	$js_quest_text[0] = "フォン博士が君を待っている。";
	
	jsSetQuestName("序幕");

	jsSetQuestStatus("フォンと話す");
	jsAddQuestDesc(0);
}

function Quest_VignetteMerchant()
{
	$js_quest_text[0] = "ギルドマスターのリノスが君にしてもらいたい仕事があるようだ。彼を待たせてはいけない。";

	jsSetQuestName("序幕");

	jsSetQuestStatus("リノスと話す");
	jsAddQuestDesc(0);
}

function Quest_VignettePraetor()
{
	$js_quest_text[0] = "アンティダス卿が君の働きを必要としている。君は彼の唯一の希望だ。";
	
	jsSetQuestName("序幕");
	
	jsSetQuestStatus("アンティダスと話す");
	jsAddQuestDesc(0);
}

function Quest_VignetteGrifter()
{
	$js_quest_text[0] = "詐欺師仲間のペトラスが宿で会おうと言ってきた。";
	
	jsSetQuestName("序幕");
	
	jsSetQuestStatus("ペトラスと話す");
	jsAddQuestDesc(0);
}

function Quest_VignetteAssassin()
{
	$js_quest_text[0] = "ギルドマスターのネレオスが君にしてもらいたい仕事があるようだ。";
	$js_quest_text[1] = "物資を買ったら、宿へ行く。";
	$js_quest_text[2] = "準備ができたら部屋を出る。";
	
	jsSetQuestName("序幕");
	
	if(aod.jnl_vignette_assassin == 2)
	{
		jsSetQuestStatus("ギルドへ戻る");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_vignette_assassin == 1)
	{
		jsSetQuestStatus("宿へ行く");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_vignette_assassin == 0)
	{
		jsSetQuestStatus("ネレオスと話す");
		jsAddQuestDesc(0);
	}
}

function Quest_VignetteThief()
{
	$js_quest_text[0] = "ギルドマスターのカドが君にしてもらいたい仕事があるようだ。";
	$js_quest_text[1] = "準備ができたら部屋を出る。";
	
	jsSetQuestName("序幕");
	
	if(aod.jnl_vignette_thief == 1)
	{
		jsSetQuestStatus("ギルドへ戻る");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_vignette_thief == 0)
	{
		jsSetQuestStatus("カドと話す");
		jsAddQuestDesc(0);
	}
}

function Quest_VignetteMercenary()
{
	$js_quest_text[0] = "宿の主人が君を探している。";
	$js_quest_text[1] = "物資を買ったら、宿へ戻る。";
	$js_quest_text[2] = "準備ができたら部屋を出る。";
	$js_quest_text[3] = "準備ができたら宿へ戻る。";
	
	jsSetQuestName("序幕");
	
	if(aod.jnl_vignette_merc == 3)
	{
		jsSetQuestStatus("宿へ戻る");
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_vignette_merc == 2)
	{
		jsSetQuestStatus("部屋を出る");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_vignette_merc == 1)
	{
		jsSetQuestStatus("宿へ行く");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_vignette_merc == 0)
	{
		jsSetQuestStatus("宿の主人と話す");
		jsAddQuestDesc(0);
	}
}

function Quest_VignetteDrifter()
{
	$js_quest_text[0] = "隣の部屋の喧噪で君は目を覚ます。調査した方がいいかもしれない。";
	$js_quest_text[1] = "商人のヴァルダニスが、またとない怪しい依頼をしてきた。断ることもできるが。";
	$js_quest_text[2] = "準備ができたら宿へ戻る。";
	
	jsSetQuestName("序幕");
	
	if(aod.jnl_vignette_drifter == 2)
	{
		jsSetQuestStatus("宿へ戻る");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_vignette_drifter == 1)
	{
		jsSetQuestStatus("ヴァルダニスと話す");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_vignette_drifter == 0)
	{
		jsSetQuestStatus("見てくる");
		jsAddQuestDesc(0);
	}
}

function Quest_ProspectorAmulet()
{
	$js_quest_text[0] = "A prospector agreed to sell you his amulet. You can find him at the inn.";
	$js_quest_text[1] = "You bought a wondrous amulet from a prospector. You feel safer already.";
	
	jsSetQuestName("Prospector's Amulet");

	if(aod.quest_ProspectorAmulet_phase2)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(1);
	}
	else if(aod.quest_ProspectorAmulet_phase1c)
	{
		jsSetQuestStatus("Pay the prospector 200 imperials");
		jsAddQuestDesc(0);
	}
	else if(aod.quest_ProspectorAmulet_phase1b)
	{
		jsSetQuestStatus("Pay the prospector 300 imperials");
		jsAddQuestDesc(0);
	}
	else if(aod.quest_ProspectorAmulet_phase1a)
	{
		jsSetQuestStatus("Pay the prospector 500 imperials");
		jsAddQuestDesc(0);
	}
}

function Quest_Map()
{
	$js_quest_text[0] = "You acquired an old map. Before you decide what to do with it, it might be a good idea to show it to a local loremaster and get his opinion on it.";
	$js_quest_text[1] = "You took the map to Feng and it's good that you did. The map is worth a lot of money, and once Feng checks his scrolls, you'll know better what you're dealing with. It's not free, of course, but it's bound to pay off.";
	$js_quest_text[2] = "You took the map to Feng. The old charlatan put on his best act and tried to fleece you. In the end, you agreed on a reasonable price for his services.";
	$js_quest_text[3] = "The map leads to an ancient temple, but you'll need the Eye of Thor-Agoth - a powerful artefact, no doubt - to show you the way. Lucky for you, Feng has it and agreed to lend it to you for a hundred imperials.";
	$js_quest_text[4] = "Feng suggested showing the map to Lord Antidas of House Daratan. You can find him at the palace.";
	$js_quest_text[5] = "Feng didn't tell you much, but he suggested showing the map to Lord Antidas of House Daratan. You can find him at the palace.";
	$js_quest_text[6] = "Lord Antidas wants to talk to you about the map. You should go see him when you have a chance.";
	$js_quest_text[7] = "Lord Antidas sent you to Maadoran to find Domitius Ulpius, who had led one of the failed expeditions in search of the temple.";
	$js_quest_text[8] = "Domitius sent you to Ganezzar to talk with Gaius Laevinus, who might know the precise location of the mountain temple.";
	$js_quest_text[9] = "The cartographer gave you two possible locations leading to the temple: the dead river and Hellgate. You're getting closer.";
	$js_quest_text[10] = "Maybe a cartographer can help you with this map.";
	$js_quest_text[11] = "Perhaps one of the locals can shed some light on the map.";
	$js_quest_text[12] = "Abukar sent you to Domitius Ulpius. You can find him in the Arena district.";
	$js_quest_text[13] = "You finally reached the temple and found the tomb of Thor-Agoth.";
	
	jsSetQuestName("The Map");

	if(aod.jnl_map == 8)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(13);
	}
	else if(aod.jnl_map == 7)
	{
		jsSetQuestStatus("Reach the temple");
		jsAddQuestDesc(9);
	}
	else if((aod.npc_domitius_met == 0 && aod.quest_MQ_findDomitius == 0 && aod.global_beenToGanezzar) || (aod.npc_domitius_met == 0 && aod.mdn_destroyed))
	{
		jsSetQuestStatus("Look for a good cartographer in Ganezzar");
		jsAddQuestDesc(10);
	}
	else if(aod.jnl_map_phase6)
	{
		jsSetQuestStatus("Talk to Gaius Laevinus in Ganezzar");
		jsAddQuestDesc(8);
	}
	else if(aod.quest_map_phase5)
	{
		jsSetQuestStatus("Talk to Domitius Ulpius in Maadoran");
		jsAddQuestDesc(7);
	}
	else if(aod.quest_map_abukar == 1)
	{
		jsSetQuestStatus("Talk to Domitius Ulpius");
		jsAddQuestDesc(12);
	}
	else if(aod.global_beenToMaadoran)
	{
		jsSetQuestStatus("Find some information about the map");
		jsAddQuestDesc(11);
	}
	else if(aod.quest_map_phase4c)
	{
		jsSetQuestStatus("Talk to Lord Antidas");
		jsAddQuestDesc(6);
	}
	else if(aod.quest_map_phase4b)
	{
		jsSetQuestStatus("Show the map to Lord Antidas");
		jsAddQuestDesc(5);
	}
	else if(aod.quest_map_phase4a)
	{
		jsSetQuestStatus("Show the map to Lord Antidas");
		jsAddQuestDesc(4);
	}
	else if(aod.quest_map_phase3)
	{
		jsSetQuestStatus("Pay Feng 100 imperials");
		jsAddQuestDesc(3);
	}
	else if(aod.quest_map_phase2c)
	{
		jsSetQuestStatus("Pay Feng 25 imperials");
		jsAddQuestDesc(1);
	}
	else if(aod.quest_map_phase2b)
	{
		jsSetQuestStatus("Pay Feng 20 imperials");
		jsAddQuestDesc(2);
	}
	else if(aod.quest_map_phase2a)
	{
		jsSetQuestStatus("Pay Feng 50 imperials");
		jsAddQuestDesc(1);
	}
	else if(aod.quest_map_phase1)
	{
		jsSetQuestStatus("Show the map to loremaster Feng");
		jsAddQuestDesc(0);
	}
}

function Quest_Guildless()
{
	$js_quest_text[0] = "君は今のところ、どのギルドにも属していない。もしテロンで儲かる仕事にありつけなかったら、マードランのギルドマスターに相談しよう。";
	$js_quest_text[1] = "You aren't working for any guild at the moment. If you fail to find gainful employment in Maadoran, talk to Ganezzar's guildmasters.";
	$js_quest_text[2] = "You aren't working for any guild at the moment. Talk to Ganezzar's guildmasters if you're looking for a job.";
	
	jsSetQuestName("ギルドレス");
	
	if(aod.mdn_finished)
	{
		jsSetQuestStatus("他のギルドで運試しをする");
		jsAddQuestDesc(2);
	}
	else if(aod.trn_finished)
	{
		jsSetQuestStatus("Try your luck in another guild");
		jsAddQuestDesc(1);
	}
	else if(aod.trn_finished == false)
	{
		jsSetQuestStatus("Try your luck in another guild");
		jsAddQuestDesc(0);
	}
}

// TRN Misc Quests

function Quest_Einar()
{
	$js_quest_text[0] = "Feng mentioned that Einar, his former master, had discovered a safe way into the Abyss. His name is supposed to be some kind of key. Find out what it opens.";
	$js_quest_text[1] = "You reached the crater known as the Abyss. You can't help but gaze into the Abyss, wondering if it's also gazing into you.";
	$js_quest_text[2] = "You killed the god that was sleeping restlessly in a chamber deep under the city, reclaiming the Abyss for mankind.";
	$js_quest_text[3] = "Unwittingly, you managed to wake up the \'god\' that slept beneath the Abyss. Maddened by the centuries spent in the tank, the creature lashed out at the human hive around it, destroying the entire city. Well done.";
	
	jsSetQuestName("Mysteries of the Abyss");
	
	if(aod.mdn_destroyed)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_einar_phase3)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_einar_phase2)
	{
		jsSetQuestStatus("Make your way to the bottom of the crater");
		jsAddQuestDesc(1);
	}
	else if(aod.quest_einar_phase1)
	{
		jsSetQuestStatus("Find Einar's key");
		jsAddQuestDesc(0);
	}
}

function Quest_Job()
{
	$js_quest_text[0] = "You should put your skills to good use. If the Boatmen of Styx (the assassins' guild) and the Forty Thieves (the thieves' guild) are too fancy for you, talk to the Imperial Guards - they are always looking for people with your qualifications.";
	
	jsSetQuestName("Join a faction!");

	if(aod.quest_job_phase1)
	{
		jsSetQuestStatus("Tour the guilds and see if you find something you like");
		jsAddQuestDesc(0);
	}
}

function Quest_Cassius()
{
	$js_quest_text[0] = "Feng asked you to get rid of a rival loremaster named Cassius, who's just arrived to Teron on an invitation from Lord Antidas. You haven't agreed to anything yet.";
	$js_quest_text[1] = "Find a way to get rid of Cassius, Feng's rival. He's just arrived to Teron on an invitation from Lord Antidas and is probably still at the inn.";
	$js_quest_text[2] = "You killed Cassius, which is a simple but effective way to get rid of any man. Feng should be glad to hear that Cassius won't trouble him again.";
	$js_quest_text[3] = "You intimidated Cassius into leaving Teron. Feng should be glad to hear that Cassius won't trouble him again.";
	$js_quest_text[4] = "You double-crossed Feng and escorted Cassius to Lord Antidas, after he promised to teach you the secrets of metallurgy. Talk to him when you get a chance.";
	$js_quest_text[5] = "You killed Cassius, which is a simple but effective way to get rid of any man. Feng was glad to hear that Cassius won't trouble him again.";
	$js_quest_text[6] = "You intimidated Cassius into leaving Teron. Feng was glad to hear that Cassius won't trouble him again.";
	$js_quest_text[7] = "You double-crossed Feng and escorted Cassius to Lord Antidas. Talk to him when you get a chance.";
	
	jsSetQuestName("Loremasters' Rivalry");
	aod.quest_cassius_active = true;
	
	if(aod.jnl_cassius == 8) // 4d
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(7);
		aod.quest_cassius_active = false;
	}
	else if(aod.jnl_cassius == 7) // 4c
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(6);
		aod.quest_cassius_active = false;
	}
	else if(aod.jnl_cassius == 6) // 4b
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(5);
		aod.quest_cassius_active = false;
	}
	else if(aod.jnl_cassius == 5) // 4a
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
		aod.quest_cassius_active = false;
	}
	else if(aod.jnl_cassius == 4) // 3b
	{
		jsSetQuestStatus("Talk to Feng");
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_cassius == 3) // 3a
	{
		jsSetQuestStatus("Talk to Feng");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_cassius == 2)
	{
		jsSetQuestStatus("Get rid of Cassius, a rival loremaster");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_cassius == 1)
	{
		jsSetQuestStatus("Feng wants to get rid of a rival loremaster");
		jsAddQuestDesc(0);
	}
}

function Quest_GalboRing()
{
	$js_quest_text[0] = "Feng offered you to take a fake magic ring to Antidas. You haven't agreed to anything yet.";
	$js_quest_text[1] = "Offer the fake ring to Lord Antidas as a tribute.";
	$js_quest_text[2] = "Feng did his part and artfully convinced Antidas that the ring is real. You gained Antidas' favor and his ring, given to you in exchange.";
	$js_quest_text[3] = "With Feng gone, you had to deal with Cassius and defend both the ring's authenticity and your reputation. You managed to make Antidas doubt Cassius' arguments and he decided to hold on to the ring, just in case.";
	$js_quest_text[4] = "You failed to convince Lord Antidas that the ring is authentic.";
	$js_quest_text[5] = "With Feng gone, you had to deal with Cassius and defend both the ring's authenticity and your reputation. Unfortunately, you failed miserably.";
	$js_quest_text[6] = "As a result of your actions, Feng had to leave Teron in a hurry, taking the ring with him.";
	
	jsSetQuestName("Galbo's Ring");
	aod.quest_galbo_active = true;

	if(aod.quest_galbo_phase3e)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(6);
		aod.quest_galbo_active = false;
	}
	else if(aod.quest_galbo_phase3d)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(5);
		aod.quest_galbo_active = false;
	}
	else if(aod.quest_galbo_phase3c)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
		aod.quest_galbo_active = false;
	}
	else if(aod.quest_galbo_phase3b)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
		aod.quest_galbo_active = false;
	}
	else if(aod.quest_galbo_phase3a)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
		aod.quest_galbo_active = false;
	}
	else if(aod.quest_galbo_phase2)
	{
		jsSetQuestStatus("Talk to Antidas");
		jsAddQuestDesc(1);
	}
	else if(aod.quest_galbo_phase1)
	{
		jsSetQuestStatus("Talk to Feng");
		jsAddQuestDesc(0);
	}
}

// AG Questline

function Quest_AG1()
{
	$js_quest_text[0] = "Kill the spies in a house near the gate.";
	$js_quest_text[1] = "You killed the spies. Look for the reports and report back to Neleos.";
	$js_quest_text[2] = "You betrayed your guild for an opportunity to make a good impression on the most powerful Lord of the realm and have him in your debt. You have to escort the spy to Maadoran and ensure his safety.";
	$js_quest_text[3] = "The spies fooled you and skipped town. Oh well... what goes around, comes around, and that bit of kindness might just pay you back one day. You never know, of course, but wouldn't it be nice, if it did? After all, you could have killed them, but didn't. Right?";
	$js_quest_text[4] = "You killed the spies, but failed to find the reports.";
	$js_quest_text[5] = "You killed the spies and recovered the reports. Is there anything you can't do?";
	$js_quest_text[6] = "You killed two spies and made a deal with the third spy: his life for the reports. So, Neleos got what he paid you for - two dead spies and the reports, and Lord Gaelius didn't lose all three spies. If it's not a win-win, you don't know what is.";
	
	jsSetQuestName("The Aurelian Spies");
	aod.quest_ag1_active = true;

	if(aod.quest_ag1_phase3d)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(6);
		aod.quest_ag1_active = false;
	}
	else if(aod.quest_ag1_phase3c)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(5);
		aod.quest_ag1_active = false;
	}
	else if(aod.quest_ag1_phase3b)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
		aod.quest_ag1_active = false;
	}
	else if(aod.quest_ag1_phase3a)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
		aod.quest_ag1_active = false;
	}
	else if(aod.quest_ag1_phase2b)
	{
		jsSetQuestStatus("Escort the spy to Maadoran");
		jsAddQuestDesc(2);
	}
	else if(aod.quest_ag1_phase2a)
	{
		jsSetQuestStatus("Report back to Neleos");
		jsAddQuestDesc(1);
	}
	else if(aod.quest_ag1_phase1)
	{
		jsSetQuestStatus("Kill the spies");
		jsAddQuestDesc(0);
	}
}

function Quest_AG2()
{
	$js_quest_text[0] = "Report to Neleos when you are ready. You get a sudden feeling of impending doom, so get extra ready.";
	$js_quest_text[1] = "You assassinated Commander Marcus Carrinas and survived the attack on your guild.";
	$js_quest_text[2] = "Instead of killing the Commander, you shot your partner and walked away with 1,000 imperials - a payment for saving Carrinas' life.";
	$js_quest_text[3] = "Instead of killing the Commander, you shot your partner and offered your services to the Imperial Guards. You had to kill Neleos and the rest of the Boatmen to prove your skills.";
	$js_quest_text[4] = "Instead of killing the Commander, you shot your partner and offered your services to the Imperial Guards. You were asked to kill Neleos and the rest of the Boatmen to prove your skills, but you chose to disappear instead.";
	
	jsSetQuestName("Commander Marcus Carrinas");
	aod.quest_ag2_active = true;

	if(aod.quest_ag2_phase2d)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
		aod.quest_ag2_active = false;
	}
	else if(aod.quest_ag2_phase2c)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
		aod.quest_ag2_active = false;
	}
	else if(aod.quest_ag2_phase2b)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
		aod.quest_ag2_active = false;
	}
	else if(aod.quest_ag2_phase2a)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(1);
		aod.quest_ag2_active = false;
	}
	else if(aod.quest_ag2_phase1)
	{
		jsSetQuestStatus("Talk to Neleos");
		jsAddQuestDesc(0);
	}
}

function Quest_AG3()
{
	$js_quest_text[0] = "Kill the guards and enter the barracks.";
	$js_quest_text[1] = "You took part in a raid on the Imperial Guards' barracks, which wiped out most Guards and eliminated their presence in Teron. You were the only one who made it out alive, which guarantees you a warm welcome in Maadoran. If you're looking for work, that is.";
	$js_quest_text[2] = "You took part in a raid on the Imperial Guards' barracks, which wiped out most Guards and eliminated their presence in Teron. Fulvio and you were the only ones who made it out alive, which guarantees you a warm welcome in Maadoran. If you're looking for work, that is.";
	$js_quest_text[3] = "You took part in a raid on the Imperial Guards' barracks, which wiped out most Guards and eliminated their presence in Teron. You saved Neleos' life, but the Boatmen lost too many men and it would take awhile for Neleos to rebuild the guild. He'll put in a good word for you in Maadoran.";
	
	jsSetQuestName("Kill 'Em All");

	if(aod.quest_ag3_phase1c)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
	}
	else if(aod.quest_ag3_phase1b)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
	}
	else if(aod.quest_ag3_phase1a)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
	}
	else
	{
		jsSetQuestStatus("Enter the barracks");
		jsAddQuestDesc(0);
	}
}

function Quest_AG_ArriveMDN()
{
	$js_quest_text[0] = "Go to Maadoran and report to the guildmaster of the Boatmen of Styx.";
	$js_quest_text[1] = "Go to the Trade District and talk to Darista, the guildmaster of the Boatmen of Styx.";
	
	jsSetQuestName("Reporting in");

	if(aod.global_beenToMaadoran)
	{
		jsSetQuestStatus("Talk to Darista");
		jsAddQuestDesc(1);
	}
	else
	{
		jsSetQuestStatus("Travel to Maadoran");
		jsAddQuestDesc(0);
	}
}

function Quest_AG_WorkMDN()
{
	$js_quest_text[0] = "If you need a job, talk to Darista, the guildmaster of the Boatmen of Styx.";
	
	jsSetQuestName("Getting new contracts");
	
	jsSetQuestStatus("Talk to Darista");
	jsAddQuestDesc(0);
}

function Quest_AG4()
{
	$js_quest_text[0] = "Talk to Hamza if you want to take part in the raid on the Slums.";
	$js_quest_text[1] = "Talk to Hamza when you're ready to go.";
	$js_quest_text[2] = "You couldn't get to the temple and had to turn back.";
	$js_quest_text[3] = "The way to the temple is now clear.";
	$js_quest_text[4] = "Look for the entrance - it has to be there somewhere.";
	$js_quest_text[5] = "Look for a way out.";
	$js_quest_text[6] = "You had to leave the gold behind and return to the guild empty-handed.";
	$js_quest_text[7] = "You managed to get the gold and bring it back to the guild.";
	
	jsSetQuestName("Antidas' Hoard");
	
	aod.quest_ag4_phase1a = true;

	if(aod.quest_ag4_phase4b)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(7);
	}
	else if(aod.quest_ag4_phase4a)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(6);
	}
	else if(aod.quest_ag4_phase3b)
	{
		jsSetQuestStatus("Bring the gold to the guild");
		jsAddQuestDesc(5);
	}
	else if(aod.quest_ag4_phase3a)
	{
		jsSetQuestStatus("Get inside the temple");
		jsAddQuestDesc(4);
	}
	else if(aod.quest_ag4_phase2c)
	{
		jsSetQuestStatus("Go to the temple");
		jsAddQuestDesc(3);
	}
	else if(aod.quest_ag4_phase2b)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
	}
	else if(aod.quest_ag4_phase2a)
	{
		jsSetQuestStatus("Return to the guild");
		jsAddQuestDesc(2);
	}
	else if(aod.quest_ag4_phase1b)
	{
		jsSetQuestStatus("Talk to Hamza");
		jsAddQuestDesc(1);
	}
	else if(aod.quest_ag4_phase1a)
	{
		jsSetQuestStatus("Talk to Hamza");
		jsAddQuestDesc(0);
	}
}

function Quest_AG5()
{
	$js_quest_text[0] = "Talk to Darista when you're ready to go.";
	$js_quest_text[1] = "Go inside and take care of Lorenza.";
	$js_quest_text[2] = "Your work here is done - Lorenza is dead.";
	$js_quest_text[3] = "You best get ready - Darista won't go down easily.";
	$js_quest_text[4] = "It's done. Darista is dead.";
	$js_quest_text[5] = "Instead of killing Lorenza, you betrayed your guild and killed Darista. Hopefully, it's going to work out somehow.";
	$js_quest_text[6] = "You killed Lorenza, eliminating one of the key players in the conspiracy against Lord Gaelius.";

	jsSetQuestName("The Black Widow");
	
	aod.jnl_ag5_phase1 = true;

	if(aod.jnl_ag5_phase4b)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(6);
	}
	else if(aod.jnl_ag5_phase4a)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(5);
	}
	else if(aod.jnl_ag5_phase3b)
	{
		jsSetQuestStatus("Return to Lorenza");
		jsAddQuestDesc(4);
	}
	else if(aod.jnl_ag5_phase3a)
	{
		jsSetQuestStatus("Kill Darista");
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_ag5_phase2b)
	{
		jsSetQuestStatus("Return to the guild");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_ag5_phase2a)
	{
		jsSetQuestStatus("Kill Lorenza");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_ag5_phase1)
	{
		jsSetQuestStatus("Talk to Darista");
		jsAddQuestDesc(0);
	}
}

function Quest_AG5a()
{
	$js_quest_text[0] = "You agreed to kill Gaelius for Levir. Accompany Darista to the palace and wait for an opportunity.";
	$js_quest_text[1] = "Gaelius and Darista are dead. Try to make it out of the palace alive.";
	$js_quest_text[2] = "You betrayed your guild and killed Darista and Gaelius. Hopefully, it's going to work out somehow.";
	$js_quest_text[3] = "You changed your mind and decided to stay loyal to Gaelius. Levir won't be too happy about it.";

	jsSetQuestName("Kingslayer");
	
	aod.jnl_ag5_phase1 = true;

	if(aod.jnl_ag5a_phase4)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_ag5a_phase3)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_ag5a_phase2)
	{
		jsSetQuestStatus("Escape from the palace");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_ag5a_phase1)
	{
		jsSetQuestStatus("Kill Gaelius");
		jsAddQuestDesc(0);
	}
}

function Quest_AG6()
{
	$js_quest_text[0] = "Talk to Darista when you're ready to take care of Serenas.";
	$js_quest_text[1] = "Pay Serenas a visit.";
	$js_quest_text[2] = "Let Darista know that Serenas won't be a problem anymore.";
	$js_quest_text[3] = "With Serenas gone and the conspiracy crushed, Lord Gaelius rules supreme over Maadoran.";

	jsSetQuestName("The Black Sheep");
	
	aod.jnl_ag6_phase1 = true;

	if(aod.jnl_ag6_phase4)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_ag6_phase2b)
	{
		jsSetQuestStatus("Report to Darista");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_ag6_phase2a)
	{
		jsSetQuestStatus("Kill Serenas");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_ag6_phase1)
	{
		jsSetQuestStatus("Talk to Darista");
		jsAddQuestDesc(0);
	}
}

// TG Questline

function Quest_TG1()
{
	$js_quest_text[0] = "Report to Cado for more work when you are ready.";
	$js_quest_text[1] = "You need to make sure that the guards will let a shipment through, when the guild needs to smuggle goods out of Teron. Talk to the guards and gather some information.";
	$js_quest_text[2] = "You had a good talk with the guards and gained some insight. Use what you've learned to come up with a solution.";
	$js_quest_text[3] = "You paid the guards to look the other way, when the guild is smuggling stolen goods.";
	$js_quest_text[4] = "You did a favour for Flavius, the Watch Commander. In return, he will instruct his men to look the other way, when the guild is smuggling stolen goods.";
	$js_quest_text[5] = "You managed to steal a shipping mandate from the Imperial Guards. The guards won't be able to touch your shipments.";
	$js_quest_text[6] = "You managed to forge a shipping mandate similar to the Imperial Guards' mandate. The guards won't be able to touch your shipments.";
	
	jsSetQuestName("Taking Care of Business");
	aod.quest_TG1_active = true;

	if(aod.quest_tg1_phase4d)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(6);
		aod.quest_TG1_active = false;
	}
	else if(aod.quest_tg1_phase4c)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(5);
		aod.quest_TG1_active = false;
	}
	else if(aod.quest_tg1_phase4b)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
		aod.quest_TG1_active = false;
	}
	else if(aod.quest_tg1_phase4a)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
		aod.quest_TG1_active = false;
	}
	else if(aod.quest_tg1_phase3)
	{
		jsSetQuestStatus("Weigh your options");
		jsAddQuestDesc(2);
	}
	else if(aod.quest_tg1_phase2)
	{
		jsSetQuestStatus("Talk to the gate guards");
		jsAddQuestDesc(1);
	}
	else if(aod.quest_tg1_phase1)
	{
		jsSetQuestStatus("Talk to Cado");
		jsAddQuestDesc(0);
	}
}

function Quest_TG1a()
{
	$js_quest_text[0] = "Flavius, the Watch Commander, has lost more than he can afford in a game of chance.";
	$js_quest_text[1] = "Flavius asked you to retrieve his promissory note from Kaeso's house, without alerting his attention.";
	$js_quest_text[2] = "You did a favour for Flavius, the Watch Commander. In return, he will instruct his men to look the other way, when the guild is smuggling stolen goods.";
	
	jsSetQuestName("Taking Care of Business");

	if(aod.quest_tg1a_phase3)
	{
		jsSetQuestStatus("Talk to Cado");
		jsAddQuestDesc(2);
	}
	else if(aod.quest_tg1a_phase2)
	{
		jsSetQuestStatus("Retrieve the promissory note for Flavius");
		jsAddQuestDesc(1);
	}
	else if(aod.quest_tg1a_phase1)
	{
		jsSetQuestStatus("Talk to Flavius");
		jsAddQuestDesc(0);
	}
}

function Quest_TG1b()
{
	$js_quest_text[0] = "The Imperial Guards have some kind of fancy mandate that make their shipments exempt from levies and attention. Sounds like a handy piece of paper.";
	$js_quest_text[1] = "You managed to steal a shipping mandate from the Imperial Guards. The guards won't be able to touch your shipments.";
	
	jsSetQuestName("Taking Care of Business");

	if(aod.quest_tg1b_phase2)
	{
		jsSetQuestStatus("Take the mandate to Cado");
		jsAddQuestDesc(1);
	}
	else if(aod.quest_tg1b_phase1)
	{
		jsSetQuestStatus("Try to get hold of the Mandate");
		jsAddQuestDesc(0);
	}
}

function Quest_TG1c()
{
	$js_quest_text[0] = "The Imperial Guards have some kind of fancy mandate that make their shipments exempt from levies and attention. Sounds like a handy piece of paper.";
	$js_quest_text[1] = "You need an official Daratan document in order to forge a proper-looking mandate.";
	$js_quest_text[2] = "Feng can provide you with an official document, but it will cost you. Not that you had a doubt.";
	$js_quest_text[3] = "Go to Cado and make the most authentic forgery you can.";
	
	jsSetQuestName("Taking Care of Business");

	if(aod.quest_tg1c_phase4)
	{
		jsSetQuestStatus("Talk to Cado");
		jsAddQuestDesc(3);
	}
	else if(aod.quest_tg1c_phase3c)
	{
		jsSetQuestStatus("Pay Feng 25 imperials");
		jsAddQuestDesc(2);
	}
	else if(aod.quest_tg1c_phase3b)
	{
		jsSetQuestStatus("Pay Feng 50 imperials");
		jsAddQuestDesc(2);
	}
	else if(aod.quest_tg1c_phase3a)
	{
		jsSetQuestStatus("Pay Feng 100 imperials");
		jsAddQuestDesc(2);
	}
	else if(aod.quest_tg1c_phase2)
	{
		jsSetQuestStatus("Talk to Feng");
		jsAddQuestDesc(1);
	}
	else if(aod.quest_tg1c_phase1)
	{
		jsSetQuestStatus("Talk to Cado about forging a mandate");
		jsAddQuestDesc(0);
	}
}

function Quest_TG1d()
{
	$js_quest_text[0] = "The guards' pay has been cut again. You could make a contribution to their welfare.";
	$js_quest_text[1] = "The guards refused your offer. If at first you don't succeed...";
	$js_quest_text[2] = "Bribe the gate guards to look the other way.";
	$js_quest_text[3] = "You paid the guards to look the other way, when the guild is smuggling stolen goods.";
	
	jsSetQuestName("Taking Care of Business");

	if(aod.quest_tg1d_phase3)
	{
		jsSetQuestStatus("Talk to Cado");
		jsAddQuestDesc(3);
	}
	else if(aod.quest_tg1d_phase2d)
	{
		jsSetQuestStatus("Pay the guards 250 imperials");
		jsAddQuestDesc(2);
	}
	else if(aod.quest_tg1d_phase2c)
	{
		jsSetQuestStatus("Pay the guards 150 imperials");
		jsAddQuestDesc(2);
	}
	else if(aod.quest_tg1d_phase2b)
	{
		jsSetQuestStatus("Pay the guards 50 imperials");
		jsAddQuestDesc(2);
	}
	else if(aod.quest_tg1d_phase2a)
	{
		jsSetQuestStatus("Pay the guards 100 imperials");
		jsAddQuestDesc(2);
	}
	else if(aod.quest_tg1d_phase1b)
	{
		jsSetQuestStatus("Talk to the guards");
		jsAddQuestDesc(1);
	}
	else if(aod.quest_tg1d_phase1a)
	{
		jsSetQuestStatus("Talk to the guards about their pay");
		jsAddQuestDesc(0);
	}
}

function Quest_TG2()
{
	$js_quest_text[0] = "Report to Cado for more work when you are ready.";
	$js_quest_text[1] = "Decide with Cado which course of action you should take with the ambush.";
	$js_quest_text[2] = "The plan is to ambush Linos' men delivering 50,000 in gold to Lord Antidas. Expect a lot of resistance and you won't be wrong.";
	$js_quest_text[3] = "The plan is to ambush Linos' men delivering 50,000 in gold to Lord Antidas. You volunteered to rig up some explosives, so there are going to be fireworks tonight.";
	$js_quest_text[4] = "The plan is to con Linos' men delivering 50,000 in gold to Lord Antidas into taking the gold to one of the Forty Thieves' safe houses. You'll do the talking.";
	$js_quest_text[5] = "You took part in an ambush on Linos' men who were delivering 50,000 in gold to Lord Antidas. All men, including the mercenaries working for the Commercium, were killed.";
	$js_quest_text[6] = "You conned Linos' men who were delivering 50,000 in gold to Lord Antidas into taking the gold to one of the Forty Thieves' safe houses. Unfortunately, a fight was unavoidable and Linos' men, including the mercenaries working for the Commercium, were killed.";
	$js_quest_text[7] = "You conned Linos' men who were delivering 50,000 in gold to Lord Antidas into taking the gold to one of the Forty Thieves' safe houses, and then stole it from under their noses, without shedding a drop of blood.";
	$js_quest_text[8] = "You conned Linos' men who were delivering 50,000 in gold to Lord Antidas into taking the gold to one of the Forty Thieves' safe houses, and then stole as much as you could from under their noses, without shedding a drop of blood.";
	
	jsSetQuestName("Linos' Gold");
	aod.quest_TG2_active = true;

	if(aod.quest_tg2_phase3d)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(8);
		aod.quest_TG2_active = false;
	}
	else if(aod.quest_tg2_phase3c)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(7);
		aod.quest_TG2_active = false;
	}
	else if(aod.quest_tg2_phase3b)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(6);
		aod.quest_TG2_active = false;
	}
	else if(aod.quest_tg2_phase3a)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(5);
		aod.quest_TG2_active = false;
	}
	else if(aod.quest_tg2_phase2c)
	{
		jsSetQuestStatus("Report to Cado when ready");
		jsAddQuestDesc(4);
	}
	else if(aod.quest_tg2_phase2b)
	{
		jsSetQuestStatus("Report to Cado when ready");
		jsAddQuestDesc(3);
	}
	else if(aod.quest_tg2_phase2a)
	{
		jsSetQuestStatus("Report to Cado when ready");
		jsAddQuestDesc(2);
	}
	else if(aod.quest_tg2_phase1a)
	{
		jsSetQuestStatus("Talk to Cado");
		jsAddQuestDesc(1);
	}
	else if(aod.quest_tg2_phase1)
	{
		jsSetQuestStatus("Talk to Cado");
		jsAddQuestDesc(0);
	}
}

function Quest_TG2a()
{
	$js_quest_text[0] = "Get a ring from a Commercium high ranking member.";
	$js_quest_text[1] = "You managed to steal a ring from a commercium merchant.";
	
	jsSetQuestName("Linos' Gold");

	if(aod.quest_tg2a_phase2)
	{
		jsSetQuestStatus("Report to Cado");
		jsAddQuestDesc(1);
	}
	else if(aod.quest_tg2a_phase1)
	{
		jsSetQuestStatus("Get the ring");
		jsAddQuestDesc(0);
	}
}

function Quest_TG3()
{
	$js_quest_text[0] = "Talk to Cado when you are ready to leave Teron.";
	$js_quest_text[1] = "Use the tools at your disposal to escape Teron with the gold.";
	$js_quest_text[2] = "You fought your way out of Teron, leaving nothing but corpses behind and cementing your reputation of a stone-cold killer. Not very subtle, but extremely effective.";
	$js_quest_text[3] = "Even though the town was sealed tighter than a drum, you managed to fast-talk your way past every obstacle that was standing between you and the open road.";
	$js_quest_text[4] = "Even though the town was sealed tighter than a drum, you managed to escape with the gold, talking your way through where you could and killing when you couldn't.";
	
	jsSetQuestName("Escape From Teron");

	if(aod.quest_tg3_phase3 && aod.quest_tg3_talk && aod.quest_tg3_fight == false)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
	}
	else if(aod.quest_tg3_phase3 && aod.quest_tg3_talk && aod.quest_tg3_fight)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
	}
	else if(aod.quest_tg3_phase3 && aod.quest_tg3_talk == false && aod.quest_tg3_fight)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
	}
	else if(aod.quest_tg3_phase2)
	{
		jsSetQuestStatus("Escape Teron!");
		jsAddQuestDesc(1);
	}
	else if(aod.quest_tg3_phase1)
	{
		jsSetQuestStatus("Talk to Cado");
		jsAddQuestDesc(0);
	}
}

function Quest_TG_ArriveMDN()
{
	$js_quest_text[0] = "Go to the Slums 'district' and talk to Levir, the guildmaster of the Forty Thieves.";
	
	jsSetQuestName("Discovering The Neighbourhood");
	
	aod.jnl_TG_ArriveMDN_phase1 = true;

	if(aod.jnl_TG_ArriveMDN_phase1)
	{
		jsSetQuestStatus("Talk to Levir");
		jsAddQuestDesc(0);
	}
}

function Quest_TG4()
{
	$js_quest_text[0] = "Talk to Levir when you're ready for some breaking & entering.";
	$js_quest_text[1] = "Unlock the pavilion and take a ride to the basement.";
	$js_quest_text[2] = "You managed to get the jar. Now, take it to Levir.";
	$js_quest_text[3] = "You couldn't get the jar. Can't win 'em all, right?";
	$js_quest_text[4] = "You delivered the jar to Levir. Is there anything you can't do?";
	
	jsSetQuestName("The Magic Jar");
	
	aod.jnl_tg4_phase1 = true;

	if(aod.jnl_tg4_phase6)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
	}
	else if(aod.jnl_tg4_phase5)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_tg4_phase4)
	{
		jsSetQuestStatus("Report to Levir");
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_tg4_phase3)
	{
		jsSetQuestStatus("Take the jar to Levir");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_tg4_phase2)
	{
		jsSetQuestStatus("Find the jar");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_tg4_phase1)
	{
		jsSetQuestStatus("Talk to Levir");
		jsAddQuestDesc(0);
	}
}

function Quest_TG5()
{
	$js_quest_text[0] = "Ask around the temple for Bassar. Levir mentioned that Isandros can show you around.";
	$js_quest_text[1] = "Talk to Isandros when you're ready.";
	$js_quest_text[2] = "The Boatmen are dead. You're still alive. All in all, not a bad day of work.";
	$js_quest_text[3] = "The Boatmen were just a decoy team. The other team used the distraction to pay Levir a visit.";
	
	jsSetQuestName("Welcome to the Slums!");
	
	aod.jnl_tg5_phase1 = true;

	if(aod.jnl_tg5_phase4)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_tg5_phase3)
	{
		jsSetQuestStatus("Report to Levir");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_tg5_phase2)
	{
		jsSetQuestStatus("Prepare for the attack");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_tg5_phase1)
	{
		jsSetQuestStatus("Find Bassar");
		jsAddQuestDesc(0);
	}
}

function Quest_TG6()
{
	$js_quest_text[0] = "Talk to Levir to set up the meeting with Cyrus.";
	$js_quest_text[1] = "Talk to Cyrus when you're ready to for some quality infiltrating. He should be somewhere near the palace.";
	$js_quest_text[2] = "Put on the guards' armor and enter the palace. Don't forget to hope for the best.";
	$js_quest_text[3] = "Gaelius is dead. It's time to get out.";
	$js_quest_text[4] = "Gaelius is dead, long lives the next Lord of House Aurelian. As long as he treads lightly, of course.";
	$js_quest_text[5] = "The guards saw through your disguise, forcing you to turn back. Might as well let Levir know.";
	$js_quest_text[6] = "You failed to assassinate Gaelius. In unrelated news, you're no longer employed by the guild. Perhaps, a different town would offer better opportunities... They say that Ganezzar is lovely this time of year.";
	$js_quest_text[7] = "Cyrus is dead. Return to Levir.";
	
	jsSetQuestName("Payback");
	
	aod.jnl_tg6_phase0 = true;

	if(aod.jnl_tg6_phase6)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
	}
	else if(aod.jnl_tg6_phase5)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(6);
	}
	else if(aod.jnl_tg6_phase4a)
	{
		jsSetQuestStatus("Report to Levir");
		jsAddQuestDesc(7);
	}
	else if(aod.jnl_tg6_phase4)
	{
		jsSetQuestStatus("Report to Levir");
		jsAddQuestDesc(5);
	}
	else if(aod.jnl_tg6_phase3)
	{
		jsSetQuestStatus("Report to Levir");
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_tg6_phase2)
	{
		jsSetQuestStatus("Disguise yourself as a guard and go to the palace");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_tg6_phase1)
	{
		jsSetQuestStatus("Talk to Cyrus");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_tg6_phase0)
	{
		jsSetQuestStatus("Talk to Levir");
		jsAddQuestDesc(0);
	}
}

function Quest_TG_ArriveGNZ()
{
	$js_quest_text[0] = "Find Glabrio, the guildmaster of the Ganezzar's chapter.";
	$js_quest_text[1] = "It appears Glabrio has his own ideas. If you want to stay in Ganezzar, you have to work for him, at least for now.";
	$js_quest_text[2] = "You're working for Glabrio now.";
	
	jsSetQuestName("Ganezzar");

	if(aod.jnl_TG_ArriveGNZ == 2)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_TG_ArriveGNZ == 1)
	{
		jsSetQuestStatus("Talk to Glabrio");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_TG_ArriveGNZ == 0)
	{
		jsSetQuestStatus("Travel to Ganezzar");
		jsAddQuestDesc(0);
	}
}

function Quest_TG_GNZ1()
{
	$js_quest_text[0] = "Glabrio tasked you with finding a way into Castle Ganezzar through the old tunnels. Talk to him when you're ready to go.";
	$js_quest_text[1] = "Navigate through the old tunnels and find a way into the castle.";
	$js_quest_text[2] = "You found a way into the castle. You can return to Glabrio now or take care of the guards while you're here.";
	$js_quest_text[3] = "The guards are dead. The way into the castle is clear.";
	$js_quest_text[4] = "You've found a way into the castle.";
	
	jsSetQuestName("The Mole-Rat");

	if(aod.jnl_TG_GNZ1 == 4)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
	}
	else if(aod.jnl_TG_GNZ1 == 3)
	{
		jsSetQuestStatus("Return to Glabrio");
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_TG_GNZ1 == 2)
	{
		jsSetQuestStatus("Take care of the guards or return to Glabrio");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_TG_GNZ1 == 1)
	{
		jsSetQuestStatus("Find a way into Castle Ganezzar");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_TG_GNZ1 == 0)
	{
		jsSetQuestStatus("Talk to Glabrio");
		jsAddQuestDesc(0);
	}
}

function Quest_TG8()
{
	$js_quest_text[0] = "Glabrio wants you to kill Faelan the Thrice Blessed. Talk to Glabrio when you're ready to kill Faelan or die trying.";
	$js_quest_text[1] = "Faelan is dead. Talk to Glabrio in the morning.";
	$js_quest_text[2] = "You killed Faelan, clearing a way for the Aurelian troops.";
	$js_quest_text[3] = "You were captured by Faelan and delivered to Meru who ordered you to lead the Aurelian forces into an ambush.";
	$js_quest_text[4] = "You told Glabrio that Faelan is dead, thus ready to lure the Aurelian troops into an ambush.";
	$js_quest_text[5] = "You tried to warn Glabrio about the ambush, but he took it the wrong way and ended up dead. The only option now is the gate tower.";
	$js_quest_text[6] = "You tried to warn Glabrio about the ambush, but he took it the wrong way and ended up dead along with his men.";
	
	jsSetQuestName("Don't Suffer a Witch to Live");

	if(aod.jnl_TG8 == 5)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(6);
	}
	else if(aod.jnl_TG8 == 4)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(5);
	}
	else if(aod.jnl_TG8 == 3)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
	}
	else if(aod.jnl_TG8 == 2)
	{
		jsSetQuestStatus("Report to Glabrio");
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_TG8 == 1)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
	}
	else if(aod.npc_faelan_dead)
	{
		jsSetQuestStatus("Report to Glabrio");
		jsAddQuestDesc(1);
	}
	else
	{
		jsSetQuestStatus("Kill Faelan the Thrice Blessed");
		jsAddQuestDesc(0);
	}
}

function Quest_TG9()
{
	$js_quest_text[0] = "Negotiate with Legatus Hagnon. Talk to Glabrio when you're ready.";
	$js_quest_text[1] = "Open the gates for the Aurelian forces.";
	$js_quest_text[2] = "Lure the Aurelian troops into Crassus' ambush or warn them.";
	$js_quest_text[3] = "Ganezzar has fallen.";
	$js_quest_text[4] = "The siege has been broken.";
	
	jsSetQuestName("The Siege");

	if(aod.jnl_TG9 == 3)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
	}
	else if(aod.jnl_TG9 == 2)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_TG9 == 1 && aod.jnl_TG8 == 5)
	{
		jsSetQuestStatus("Choose the side");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_TG9 == 1 && aod.jnl_TG8 < 5)
	{
		jsSetQuestStatus("Show the way");
		jsAddQuestDesc(1);
	}
	else
	{
		jsSetQuestStatus("Talk to Glabrio");
		jsAddQuestDesc(0);
	}
}

function Quest_TG_Levir_Temple()
{
	$js_quest_text[0] = "Talk to Levir about your next task.";
	$js_quest_text[1] = "Levir asked you to find the temple of Thor-Agoth.";
	$js_quest_text[2] = "You found the temple of Thor-Agoth for Levir.";
	
	jsSetQuestName("The Temple of Thor-Agoth");
	
	if(aod.jnl_TG_Levir_Temple == 2)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_TG_Levir_Temple == 1)
	{
		jsSetQuestStatus("Find the temple");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_TG_Levir_Temple == 0)
	{
		jsSetQuestStatus("Talk to Levir");
		jsAddQuestDesc(0);
	}
}

function Quest_TG_Senna_Temple()
{
	$js_quest_text[0] = "Talk to Senna about your reward.";
	$js_quest_text[1] = "Senna asked you to find the temple of Thor-Agoth.";
	$js_quest_text[2] = "You found the temple of Thor-Agoth for Senna.";
	
	jsSetQuestName("The Temple of Thor-Agoth");
	
	if(aod.jnl_TG_Senna_Temple == 2)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_TG_Senna_Temple == 1)
	{
		jsSetQuestStatus("Find the temple");
		jsAddQuestDesc(1);
	}
	else
	{
		jsSetQuestStatus("Talk to Senna");
		jsAddQuestDesc(0);
	}
}

function Quest_TG_Glabrio_Temple()
{
	$js_quest_text[0] = "All that's left to do is find that temple that everyone's talking about.";
	$js_quest_text[1] = "You found the temple of Thor-Agoth.";
	
	jsSetQuestName("The Temple of Thor-Agoth");
	
	if(aod.jnl_TG_Glabrio_Temple == 1)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(1);
	}
	else
	{
		jsSetQuestStatus("Find the temple");
		jsAddQuestDesc(0);
	}
}

// MG Questline

function Quest_MGTest()
{
	$js_quest_text[0] = "Linos asked you to find proof that the gate guards aren't trustworthy.";
	$js_quest_text[1] = "Bribe the guards to prove that they aren't to be trusted";
	$js_quest_text[2] = "Report your findings to Linos.";
	$js_quest_text[3] = "You passed the test and became a member of the Merchants Guild. You're living the dream!";
	
	jsSetQuestName("Linos' Test");
	aod.quest_MGTest_active = true;

	if(aod.quest_mgtest_phase4)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
		aod.quest_MGTest_active = false;
	}
	else if(aod.quest_mgtest_phase3)
	{
		jsSetQuestStatus("Talk to Linos");
		jsAddQuestDesc(2);
	}
	else if(aod.quest_mgtest_phase1b)
	{
		jsSetQuestStatus("Pay the guards 50 imperials");
		jsAddQuestDesc(1);
	}
	else if(aod.quest_mgtest_phase2a)
	{
		jsSetQuestStatus("Pay the guards 100 imperials");
		jsAddQuestDesc(1);
	}
	else if(aod.quest_mgtest_phase1)
	{
		jsSetQuestStatus("Talk to the gate guards");
		jsAddQuestDesc(0);
	}
}

function Quest_MG_WorkTRN()
{
	$js_quest_text[0] = "Talk to Linos about a new task. You can find him in the Commercium building at the trading plaza.";
	
	jsSetQuestName("Working hard or hardly working?");
	
	jsSetQuestStatus("Talk to Linos");
	jsAddQuestDesc(0);
}

function Quest_MG1()
{
	$js_quest_text[0] = "The Imperials Guards are up to something. Talk to Mercato and find out what he knows. You can find him in Cado's Tavern.";
	$js_quest_text[1] = "You failed to get the information for Linos and were thrown out of the Commercium without a second thought. Story of your life.";
	$js_quest_text[2] = "You failed to get the information for Linos, but managed to convince Linos that you are not entirely useless and were given another chance.";
	$js_quest_text[3] = "You managed to get the information from Mercato, but not without Cado's help. Someday - and you certainly hope that that day may never come - he will call upon you to do a service for him.";
	$js_quest_text[4] = "As someone who talks for a living, you had no difficulties pumping Mercato for information.";
	$js_quest_text[5] = "Despite Cado's help, you failed to get the information for Linos, but managed to convince Linos that you are not entirely useless and were given another chance. Someday - and you certainly hope that that day may never come - Cado will call upon you to do a service for him.";
	
	jsSetQuestName("A Friend in Need");
	aod.quest_MG1_active = true;

	if(aod.quest_mg1_phase3e)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(5);
		aod.quest_MG1_active = false;
	}
	else if(aod.quest_mg1_phase3d)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
		aod.quest_MG1_active = false;
	}
	else if(aod.quest_mg1_phase3c)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
		aod.quest_MG1_active = false;
	}
	else if(aod.quest_mg1_phase3b)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
		aod.quest_MG1_active = false;
	}
	else if(aod.quest_mg1_phase3a)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(1);
		aod.quest_MG1_active = false;
	}
	else if(aod.quest_mg1_phase2)
	{
		jsSetQuestStatus("Talk to Mercato");
		jsAddQuestDesc(0);
	}
}

function Quest_MG2()
{
	$js_quest_text[0] = "Commander Carrinas must be stopped. Talk to Neleos, the guildmaster of the Boatmen, about it.";
	$js_quest_text[1] = "You need to convince Antidas to place the hit on Commander Carrinas.";
	$js_quest_text[2] = "It's time to pay Carrinas a visit. After all, that's where all the evidence is.";
	$js_quest_text[3] = "You convinced Lord Antidas to give an order to assassinate Commander Carrinas without producing any evidence.";
	$js_quest_text[4] = "You managed to get inside the barracks and find Commander Carrinas' documents. They were more than enough to convince Lord Antidas to give an order to assassinate the Commander.";
	$js_quest_text[5] = "Using an unrelated document you got from Commander Carrinas, you forged the evidence. Your forgery was more than enough to convince Lord Antidas to give an order to assassinate Carrinas.";
	$js_quest_text[6] = "Smelling an opportunity, you changed sides and offered Commander Carrinas your services.";
	$js_quest_text[7] = "You failed to find the evidence and were thrown out of the Commercium without a second thought.";
	$js_quest_text[8] = "You got your hands on some incriminating evidence of Carrinas plans, Antidas will be pleased to see it.";
	
	jsSetQuestName("A Matter of Proof");
	aod.quest_MG2_active = true;

	if(aod.quest_mg2_phase3e)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(7);
		remQuest(MG2a);
		remQuest(MG2b);
		if(aod.quest_mg1_sign_document)
			remQuest(MG2c);
		aod.quest_MG2_active = false;
	}
	else if(aod.quest_mg2_phase3d)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(6);
		remQuest(MG2a);
		remQuest(MG2b);
		if(aod.quest_mg1_sign_document)
			remQuest(MG2c);
		aod.quest_MG2_active = false;
	}
	else if(aod.quest_mg2_phase3c)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(5);
		remQuest(MG2a);
		remQuest(MG2b);
		if(aod.quest_mg1_sign_document)
			remQuest(MG2c);
		aod.quest_MG2_active = false;
	}
	else if(aod.quest_mg2_phase3b)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
		remQuest(MG2a);
		remQuest(MG2b);
		if(aod.quest_mg1_sign_document)
			remQuest(MG2c);
		aod.quest_MG2_active = false;
	}
	else if(aod.quest_mg2_phase3a)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
		aod.quest_MG2_active = false;
	}
	else if(aod.quest_mg2_phase2a)
	{
		jsSetQuestStatus("Take the evidence to Antidas");
		jsAddQuestDesc(8);
		remQuest(MG2a);
		remQuest(MG2b);
		if(aod.quest_mg1_sign_document)
			remQuest(MG2c);
	}
	else if(aod.quest_mg2_phase2)
	{
		jsSetQuestStatus("Find the evidence");
		jsAddQuestDesc(2);
	}
	else if(aod.quest_mg2_phase1b)
	{
		jsSetQuestStatus("Talk to Antidas");
		jsAddQuestDesc(1);
	}
	else if(aod.quest_mg2_phase1a)
	{
		jsSetQuestStatus("Talk to Neleos");
		jsAddQuestDesc(0);
	}
}

function Quest_MG2a()
{
	$js_quest_text[0] = "You can't forge the evidence without a sample of Commander Carrinas' handwriting and signature.";
	$js_quest_text[1] = "You got a sample of Commander Carrinas' handwriting and signature. You can now try forging the evidence.";
	$js_quest_text[2] = "You forged the proof, and all that is left is to show it to Antidas.";
	
	jsSetQuestName("A Matter of Proof");

	if(aod.quest_mg2a_phase3)
	{
		jsSetQuestStatus("Talk to Antidas");
		jsAddQuestDesc(2);
	}
	
	else if(aod.quest_mg2a_phase2)
	{
		jsSetQuestStatus("Talk to Linos");
		jsAddQuestDesc(1);
	}
	
    else if(aod.quest_mg2a_phase1)
	{
		jsSetQuestStatus("Talk to Carrinas");
		jsAddQuestDesc(0);
	}
}

function Quest_MG2b()
{
	$js_quest_text[0] = "Antidas won't act until he has the evidence. See if Mercato can help you there.";
	$js_quest_text[1] = "Mercato will be waiting at the entrance to the barracks, but you need an Imperial Guards armor. Talk to old man Quintus.";
	$js_quest_text[2] = "Meet Mercato at the entrance to the barracks. He will let you in.";
	
	jsSetQuestName("A Matter of Proof");

	if(aod.quest_mg2b_phase3)
	{
		jsSetQuestStatus("Go to the barracks");
		jsAddQuestDesc(2);
	}
	else if(aod.quest_mg2b_phase2)
	{
		jsSetQuestStatus("Get the armor from Quintus");
		jsAddQuestDesc(1);
	}
	else if(aod.quest_mg2b_phase1)
	{
		jsSetQuestStatus("Talk to Mercato");
		jsAddQuestDesc(0);
	}
}

function Quest_MG2c()
{
	$js_quest_text[0] = "Cado should be able to help you get inside the barracks.";
	$js_quest_text[1] = "Cado gave you an Imperial Guards writ that will let you enter the barracks, but you will need the armor to look the part. You can buy one from him.";
	$js_quest_text[2] = "You got everything you needed from Cado to impersonate an Imperial Guards envoy.";
	
	jsSetQuestName("A Matter of Proof");
	
	if(aod.quest_mg2b_phase3)
	{
		jsSetQuestStatus("Go to the barracks");
		jsAddQuestDesc(2);
	}
	else if(aod.quest_mg2b_phase2)
	{
		jsSetQuestStatus("Pay Cado 100 imperials for the armor");
		jsAddQuestDesc(0);
	}
	else if(aod.quest_mg2b_phase1)
	{
		jsSetQuestStatus("Talk to Cado");
		jsAddQuestDesc(0);
	}
}

function Quest_MG3()
{
	$js_quest_text[0] = "The Imperial Guards can't be allowed to rebuild. Convince the remaining Guards to join House Daratan or convince Antidas to finish them off.";
	$js_quest_text[1] = "You convinced Mercato to take his men to Lord Antidas, which boosted House Daratan's strength.";
	$js_quest_text[2] = "You convinced Lord Antidas to wipe out the survivors of the Boatmen's raid.";
	$js_quest_text[3] = "Cado fucked you. He used the document you signed to steal a fortune in gold. You barely managed to convince Linos not to kill you, but you were expelled from the guild.";
	$js_quest_text[4] = "Cado fucked you. He used the document you signed to steal a fortune in gold. If not for your stellar reputation, you would have been dead.";
	
	jsSetQuestName("The Loose Ends");
	aod.quest_MG3_active = true;

	if(aod.quest_mg3_phase3d)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
		aod.quest_MG3_active = false;
	}
	else if(aod.quest_mg3_phase3c)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
		aod.quest_MG3_active = false;
	}
	else if(aod.quest_mg3_phase2b)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
		aod.quest_MG3_active = false;
	}
	else if(aod.quest_mg3_phase2a)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(1);
		aod.quest_MG3_active = false;
	}
	else if(aod.quest_mg3_phase1)
	{
		jsSetQuestStatus("Talk to Mercato and Antidas");
		jsAddQuestDesc(0);
	}
}

function Quest_MG_ArriveMDN()
{
	$js_quest_text[0] = "Guildmaster Strabos requested you by name. You should travel to Maadoran without delay.";
	$js_quest_text[1] = "Go to the Trade District and talk to Strabos, the guildmaster of the Commercium.";
	
	jsSetQuestName("The New Face");

	if(aod.global_beenToMaadoran)
	{
		jsSetQuestStatus("Talk to Strabos");
		jsAddQuestDesc(1);
	}
	else
	{
		jsSetQuestStatus("Travel to Maadoran");
		jsAddQuestDesc(0);
	}
}

function Quest_MG4()
{
	$js_quest_text[0] = "Strabos wants to replace Lord Gaelius with a weaker and more agreeable lord. Talk to the influental citizens: Lady Lorenza, Lord Senna, and Legatus Pavola, and enlist their support.";
	$js_quest_text[1] = "You secured the support of Lady Lorenza and Legatus Pavola.";
	$js_quest_text[2] = "You secured the support of Lord Senna and Legatus Pavola.";
	$js_quest_text[3] = "You secured the support of Lady Lorenza, Lord Senna, and Legatus Pavola.";
	
	jsSetQuestName("The Conspiracy");

	if(aod.jnl_mg4_phase2c)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
		remQuest(MG4a);
		remQuest(MG4b);
		remQuest(MG4c);
	}
	else if(aod.jnl_mg4_phase2b)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
		remQuest(MG4a);
		remQuest(MG4b);
		remQuest(MG4c);
	}
	else if(aod.jnl_mg4_phase2a)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(1);
		remQuest(MG4a);
		remQuest(MG4b);
		remQuest(MG4c);
	}
	else if(aod.jnl_mg4_phase1)
	{
		jsSetQuestStatus("Gather Support");
		jsAddQuestDesc(0);
	}
}

function Quest_MG4a()
{
	$js_quest_text[0] = "Like all prominent citizens, she resides in the Palace District.";
	$js_quest_text[1] = "You secured Lady Lorenza's support.";
	
	jsSetQuestName("The Conspiracy");

	if(aod.jnl_mg4a_phase1b)
		jsAddQuestDesc(1);
	
	else if(aod.jnl_mg4a_phase1)
	{
		jsSetQuestStatus("Talk to Lady Lorenza");
		jsAddQuestDesc(0);
	}
}

function Quest_MG4b()
{
	$js_quest_text[0] = "Like all prominent citizens, he resides in the Palace District.";
	$js_quest_text[1] = "You failed to get Lord Senna's support.";
	$js_quest_text[2] = "You secured Lord Senna's support.";
	
	jsSetQuestName("The Conspiracy");

	if(aod.jnl_mg4b_phase2b)
		jsAddQuestDesc(2);
	
	else if(aod.jnl_mg4b_phase2a)
		jsAddQuestDesc(1);
	
	else if(aod.jnl_mg4b_phase1)
	{
		jsSetQuestStatus("Talk to Lord Senna");
		jsAddQuestDesc(0);
	}
}

function Quest_MG4c()
{
	$js_quest_text[0] = "You can find him at the Imperial Guards' barracks in the Arena District.";
	$js_quest_text[1] = "You failed to get Legatus Pavola's support.";
	$js_quest_text[2] = "Maybe after the arrest of his soldiers, Legatus Pavola will be more agreeable.";
	$js_quest_text[3] = "You secured Legatus Pavola's support.";
	
	jsSetQuestName("The Conspiracy");

	if(aod.jnl_mg4c_phase3)
		jsAddQuestDesc(3);
	
	else if(aod.jnl_mg4c_phase2b)
	{
		jsSetQuestStatus("Talk to Legatus Pavola");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_mg4c_phase2a)
		jsAddQuestDesc(1);
	
	else if(aod.jnl_mg4c_phase1)
	{
		jsSetQuestStatus("Talk to Legatus Pavola");
		jsAddQuestDesc(0);
	}
}

function Quest_MG5()
{
	$js_quest_text[0] = "The Boatmen are on the hunt for the conspirator. Strabos gave them your name and set up a meeting between you and Hamza, the Boatmen's second-in-command.";
	$js_quest_text[1] = "Survive the meeting with Hamza.";
	$js_quest_text[2] = "You gave up Lorenza to save your own life. Seemed like a pretty good deal.";
	$js_quest_text[3] = "You gave up Senna to save your own life. Seemed like a pretty good deal.";
	$js_quest_text[4] = "You fed Hamza a random name and sent him on a wild-goose chase. By the time he'll realize what happened, Gaelius will be dead.";
	$js_quest_text[5] = "You convinced Legatus Pavola to use this opportunity to avenge the attack in Teron. The Boatmen walked into a trap and were killed.";
	$js_quest_text[6] = "You successfully manipulated Hamza into turning on his own guildmaster, which will buy Strabos enough time to finish what he started.";
	$js_quest_text[7] = "You gave up the only ally you managed to recruit. The conspiracy is pretty much dead now and Strabos won't be too happy about it. On the plus side, you're still alive.";
	$js_quest_text[8] = "The Boatmen have been dealt with, and as a result, Gaelius is dead and his nephew sits on the throne.";
	$js_quest_text[9] = "You failed. Not a believer in second chances, Strabos threw you out. Perhaps, a different town would offer better opportunities... They say that Ganezzar is lovely this time of year.";
	
	jsSetQuestName("A Game of Cat & Mouse");
	
	aod.jnl_mg5_phase1 = true;

	if(aod.jnl_mg5_phase4)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(9);
		if(aod.jnl_mg5a_phase2 == 0)
			remQuest(MG5a);
	}
	else if(aod.jnl_mg5_phase3)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(8);
		if(aod.jnl_mg5a_phase2 == 0)
			remQuest(MG5a);
	}
	else if(aod.jnl_mg5_phase2f)
	{
		jsSetQuestStatus("Report to Strabos");
		jsAddQuestDesc(7);
	}
	else if(aod.jnl_mg5_phase2e)
	{
		jsSetQuestStatus("Report to Strabos");
		jsAddQuestDesc(6);
	}
	else if(aod.jnl_mg5_phase2d)
	{
		jsSetQuestStatus("Report to Strabos");
		jsAddQuestDesc(5);
	}
	else if(aod.jnl_mg5_phase2c)
	{
		jsSetQuestStatus("Report to Strabos");
		jsAddQuestDesc(4);
	}
	else if(aod.jnl_mg5_phase2b)
	{
		jsSetQuestStatus("Report to Strabos");
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_mg5_phase2a)
	{
		jsSetQuestStatus("Report to Strabos");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_mg5_phase1a)
	{
		jsSetQuestStatus("Deal with Hamza");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_mg5_phase1)
	{
		jsSetQuestStatus("Talk to Strabos when you're ready");
		jsAddQuestDesc(0);
	}
}

function Quest_MG5a()
{
	$js_quest_text[0] = "Talk to Legatus Pavola if you need some muscle to handle the Boatmen.";
	$js_quest_text[1] = "You convinced Legatus Pavola to use this opportunity to avenge the attack in Teron. Things will get ugly fast, so you best come prepared.";
	
	jsSetQuestName("A Game of Cat & Mouse");
	
	aod.jnl_mg5a_phase1 = true;

	if(aod.jnl_mg5a_phase2)
		jsAddQuestDesc(1);
	
	else if(aod.jnl_mg5a_phase1)
	{
		jsSetQuestStatus("Talk to Pavola");
		jsAddQuestDesc(0);
	}
}

function Quest_MG6()
{
	$js_quest_text[0] = "Lord Serenas isn't eager to fulfill his promises. Surely, there is something you can do to set him straight.";
	$js_quest_text[1] = "Lady Lorenza is holding Serenas' strings. Talk to her - maybe she will be reasonable.";
	$js_quest_text[2] = "Lord Senna is holding Serenas' strings. Talk to him - maybe he will be reasonable.";
	$js_quest_text[3] = "You failed to convince Lord Serenas to do anything for Strabos.";
	$js_quest_text[4] = "You convinced Lord Serenas to share the executive power between Lady Lorenza and Strabos. Lorenza should be grateful.";
	$js_quest_text[5] = "You convinced Lady Lorenza to make Strabos her pet Magistratus with limited powers.";
	$js_quest_text[6] = "You convinced Lord Senna to make Strabos his pet Magistratus with limited powers.";
	$js_quest_text[7] = "You failed to make any power-sharing deal for Strabos.";
	$js_quest_text[8] = "You convinced Lord Serenas to make Strabos a new Magistratus.";
	$js_quest_text[9] = "Thanks to your efforts, Strabos has risen far above his station, becoming the city's new Magistratus and a de-facto ruler of the city.";
	$js_quest_text[10] = "You failed. Not a big believer in second chances, Strabos threw you out. Perhaps, a different town would offer better opportunities... They say that Ganezzar is lovely this time of year.";
	$js_quest_text[11] = "You figured that it's too soon for Strabos to rule alone and cut Lorenza into the deal. For now, Strabos will have to be satisfied with the role of her pet Magistratus.";
	$js_quest_text[12] = "You got your reward from Lorenza for \"holding Strabos back\". It's time to talk to Strabos.";
	$js_quest_text[13] = "You failed to convince Lorenza that you did anything to help her cause. It's time to talk to Strabos.";
	
	jsSetQuestName("The Politics");
	
	aod.jnl_mg6_phase1 = true;

	if(aod.jnl_mg6_phase4)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(10);
	}
	else if(aod.jnl_mg6_phase3)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(9);
	}
	else if(aod.jnl_mg6_phase2k)
	{
		jsSetQuestStatus("Report to Strabos");
		jsAddQuestDesc(12);
	}
	else if(aod.jnl_mg6_phase2j)
	{
		jsSetQuestStatus("Report to Strabos");
		jsAddQuestDesc(13);
	}
	else if(aod.jnl_mg6_phase2i)
	{
		jsSetQuestStatus("Report to Strabos");
		jsAddQuestDesc(11);
	}
	else if(aod.jnl_mg6_phase2h)
	{
		jsSetQuestStatus("Report to Strabos");
		jsAddQuestDesc(8);
	}
	else if(aod.jnl_mg6_phase2g)
	{
		jsSetQuestStatus("Report to Strabos");
		jsAddQuestDesc(7);
	}
	else if(aod.jnl_mg6_phase2f)
	{
		jsSetQuestStatus("Report to Strabos");
		jsAddQuestDesc(6);
	}
	else if(aod.jnl_mg6_phase2e)
	{
		jsSetQuestStatus("Report to Strabos");
		jsAddQuestDesc(5);
	}
	else if(aod.jnl_mg6_phase2d)
	{
		jsSetQuestStatus("Talk to Lady Lorenza");
		jsAddQuestDesc(4);
	}
	else if(aod.jnl_mg6_phase2c)
	{
		jsSetQuestStatus("Report to Strabos");
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_mg6_phase2b)
	{
		jsSetQuestStatus("Talk to Lord Senna");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_mg6_phase2a)
	{
		jsSetQuestStatus("Talk to Lady Lorenza");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_mg6_phase1)
	{
		jsSetQuestStatus("Talk to Lord Serenas");
		jsAddQuestDesc(0);
	}
}

// HD Questline

function Quest_HD0()
{
	$js_quest_text[0] = "Dellar asked you to inform Feng that his services are no longer needed.";
	$js_quest_text[1] = "You informed Feng that his services were no longer needed. Cassius should be waiting at the inn.";
	$js_quest_text[2] = "Find a way to get rid of Cassius, Feng's rival, or take him to Dellar. He's should be waiting at the inn.";
	$js_quest_text[3] = "You killed Cassius, which is a simple but effective way to get rid of any man. Feng should be glad to hear that Cassius won't trouble him again.";
	$js_quest_text[4] = "You escorted Cassius to Lord Antidas. Talk to him when you get a chance.";
	$js_quest_text[5] = "You went against Antidas' wishes and got rid of Cassius. Feng was glad to hear that Cassius won't trouble him again.";
	$js_quest_text[6] = "You intimidated Cassius into leaving Teron. Feng should be glad to hear that Cassius won't trouble him again.";
	$js_quest_text[7] = "Feng was glad to hear that Cassius won't trouble him again. You should tell Dellar that Cassius is gone.";
	
	jsSetQuestName("The new loremaster");
	aod.quest_HD0_active = true;

	if(aod.jnl_hd0 == 7) // END - Got Rid of Cassius
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(5);
		aod.quest_HD0_active = false;
	}
	else if(aod.jnl_hd0 == 6) // END - Escorted Cassius
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
		aod.quest_HD0_active = false;
	}
	else if(aod.jnl_hd0 == 8) // Report to Dellar that Cassius is gone.
	{
		jsSetQuestStatus("Talk to Dellar");
		jsAddQuestDesc(7);
	}
	else if(aod.jnl_hd0 == 5) // Intimidated Cassius
	{
		jsSetQuestStatus("Talk to Feng");
		jsAddQuestDesc(6);
	}
	else if(aod.jnl_hd0 == 4) // Killed Cassius
	{
		jsSetQuestStatus("Talk to Feng");
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_hd0 == 3) // Talked with Feng about getting rid of Cassius
	{
		jsSetQuestStatus("Deal with Cassius");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_hd0 == 2) // If you didn't hear out Feng
	{
		jsSetQuestStatus("Take Cassius to Dellar");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_hd0 == 1) // Before Talking to Feng
	{
		jsSetQuestStatus("Tell Feng his services are no longer needed");
		jsAddQuestDesc(0);
	}
}

function Quest_HD1()
{
	$js_quest_text[0] = "One of the caravan masters reported seeing a small group of Aurelian legionaries escorting a man. Talk to Dellar to get their location and intercept them.";
	$js_quest_text[1] = "You intercepted Aurelian legionaries escorting loremaster Sohrab to the dig site nearby and escorted him to Teron. Unfortunately, Sohrab died during the interrogation.";
	$js_quest_text[2] = "You intercepted Aurelian legionaries escorting loremaster Sohrab to the dig site nearby and escorted him to Teron. You managed to convince him to give you the mantra required to operate or sabotage the ore smelter in the Aurelian camp.";
	$js_quest_text[3] = "You intercepted Aurelian legionaries escorting loremaster Sohrab to the dig site nearby and escorted him to Teron. You managed to convince him to give you the mantra required to operate, and even produce blue steel, or sabotage the ore smelter in the Aurelian camp.";
	
	jsSetQuestName("The Art of Receiving Visitors");
	aod.quest_HD1_active = true;

	if(aod.quest_hd1_phase2c)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
		aod.quest_HD1_active = false;
	}
	else if(aod.quest_hd1_phase2b)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
		aod.quest_HD1_active = false;
	}
	else if(aod.quest_hd1_phase2a)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(1);
		aod.quest_HD1_active = false;
	}
	else if(aod.quest_hd1_phase1)
	{
		jsSetQuestStatus("Talk to Dellar");
		jsAddQuestDesc(0);
	}
}

function Quest_HD2()
{
	$js_quest_text[0] = "You must lure Commander Carrinas out of the fort to give the Boatmen a chance to terminate him and his plans.";
	$js_quest_text[1] = "You managed to lure Commander Carrinas to the inn. Talk to Dellar when you're ready to finish it.";
	$js_quest_text[2] = "You failed to lure Commander Carrinas out of the fort and he will move against House Daratan soon. Talk to Dellar when you are ready.";
	$js_quest_text[3] = "You managed to put Carrinas into the line of fire in a way that didn't make House Daratan's involvement obvious. Carrinas died and his plans died with him.";
	$js_quest_text[4] = "You provoked Carrinas' guards to give the shooters a clear line of fire. Carrinas died, but House Daratan was implicated in his death.";
	$js_quest_text[5] = "You lost control over loremaster Sohrab, which almost got you killed, but, coincidentally, gave the shooters a clear line of fire. Carrinas died, but House Daratan was implicated in his death, and you were thrown out for incompetence.";
	$js_quest_text[6] = "You betrayed House Daratan and joined the Imperial Guards.";
	$js_quest_text[7] = "You killed Carrinas all by yourself.";
	
	jsSetQuestName("Out Into the Open");
	aod.quest_HD2_active = true;

	if(aod.jnl_hd2 == 7)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(7);
		aod.quest_HD2_active = false;
		remQuest(HD2a);
	}
	else if(aod.jnl_hd2 == 6)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(6);
		aod.quest_HD2_active = false;
		remQuest(HD2a);
	}
	else if(aod.jnl_hd2 == 5)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(5);
		aod.quest_HD2_active = false;
		remQuest(HD2a);
	}
	else if(aod.jnl_hd2 == 4)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
		aod.quest_HD2_active = false;
		remQuest(HD2a);
	}
	else if(aod.jnl_hd2 == 3)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
		aod.quest_HD2_active = false;
		remQuest(HD2a);
	}
	else if(aod.jnl_hd2 == 222) // Not Implemented - Lead to palace fight
	{
		jsSetQuestStatus("Talk to Dellar");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_hd2 == 2)
	{
		jsSetQuestStatus("Talk to Dellar");
		jsAddQuestDesc(1);
		aod.quest_hd2a_phase1a = 1;
	}
	else if(aod.jnl_hd2 == 1)
	{
		jsSetQuestStatus("Talk to Carrinas");
		jsAddQuestDesc(0);
	}
}

function Quest_HD2a()
{
	$js_quest_text[0] = "Getting Carrinas out of the barracks requires an ace up your sleeve. If you ever need an ace, Cado is the man to see.";
	$js_quest_text[1] = "There is a gang in the shantytown that's giving Cado some trouble. Deal with them to gain the favor of the guildmaster.";
	$js_quest_text[2] = "The gang has been dealt with. Go back to Cado.";
	$js_quest_text[3] = "You got a document from Caer-Tor that will make the conversation with Carrinas much easier.";
	$js_quest_text[4] = "Even though Carrinas has already agreed to meet you, it wouldn't hurt to have another option. If you ever need an ace up your sleeve, Cado is the man to see.";
	
	jsSetQuestName("Out Into the Open");
	
	if(aod.quest_hd2a_phase4)
	{
		jsSetQuestStatus("Lure Carrinas to the inn and show him the writ");
		jsAddQuestDesc(3);
	}
	
	else if(aod.quest_hd2a_phase3)
	{
		jsSetQuestStatus("Talk to Cado");
		jsAddQuestDesc(2);
	}
	
	else if(aod.quest_hd2a_phase2)
	{
		jsSetQuestStatus("Deal with the gang in Shanty Town");
		jsAddQuestDesc(1);
	}
	
	else if(aod.quest_hd2a_phase1a)
	{
		jsSetQuestStatus("Talk to Cado");
		jsAddQuestDesc(4);
	}

	else if(aod.quest_hd2a_phase1)
	{
		jsSetQuestStatus("Talk to Cado");
		jsAddQuestDesc(0);
	}
}

function Quest_HD3()
{
	$js_quest_text[0] = "Talk to Lord Serenas or one of his advisors: Lady Lorenza, Lord Senna or Master Strabos.";
	$js_quest_text[1] = "You secured the support of one of Serenas' advisors. Talk to Serenas to seal the deal.";
	$js_quest_text[2] = "You single-handedly improved the relationship between House Aurelian and House Daratan.";
	
	jsSetQuestName("The Alliance");
	
	aod.jnl_HD3_phase1 = true;

	if(aod.jnl_HD3_phase3)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
		remQuest(HD3a);
		remQuest(HD3b);
		remQuest(HD3c);
	}
	else if(aod.jnl_HD3_phase2)
	{
		jsSetQuestStatus("Talk to Serenas");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_HD3_phase1)
	{
		jsSetQuestStatus("Negotiate peace between House Aurelian and House Daratan");
		jsAddQuestDesc(0);
	}
}

function Quest_HD3a()
{
	$js_quest_text[0] = "Like all prominent citizens, she resides in the Palace District.";
	$js_quest_text[1] = "Lorenza drives a hard bargain - the price for her support is Senna's head.";
	$js_quest_text[2] = "Lord Senna is dead. Lorenza will be pleased.";
	
	jsSetQuestName("The Alliance");
	
	aod.jnl_HD3a_phase1 = true;

	if(aod.jnl_HD3a_phase4)
		jsAddQuestDesc(2);
	else if(aod.jnl_HD3a_phase3)
	{
		jsSetQuestStatus("Talk to Lady Lorenza");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_HD3a_phase2)
	{
		jsSetQuestStatus("Kill Lord Senna");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_HD3a_phase1)
	{
		jsSetQuestStatus("Talk to Lady Lorenza");
		jsAddQuestDesc(0);
	}
}

function Quest_HD3b()
{
	$js_quest_text[0] = "Like all prominent citizens, he resides in the Palace District.";
	$js_quest_text[1] = "It appears that Lord Senna doesn't want to make any deals with House Daratan.";
	
	jsSetQuestName("The Alliance");
	
	aod.jnl_HD3b_phase1 = true;

	if(aod.jnl_HD3b_phase2)
		jsAddQuestDesc(1);
	else if(aod.jnl_HD3b_phase1)
	{
		jsSetQuestStatus("Talk to Lord Senna");
		jsAddQuestDesc(0);
	}
}

function Quest_HD3c()
{
	$js_quest_text[0] = "Go to the Trade District and talk to Strabos, the guildmaster of the Commercium.";
	$js_quest_text[1] = "Turns out master Strabos wants to become Lord Strabos. Talk to Serenas and see what the protocol says.";
	
	jsSetQuestName("The Alliance");
	
	aod.jnl_HD3c_phase1 = true;

	if(aod.jnl_HD3c_phase2)
		jsAddQuestDesc(1);
	else if(aod.jnl_HD3c_phase1)
	{
		jsSetQuestStatus("Talk to Master Strabos");
		jsAddQuestDesc(0);
	}
}

function Quest_HD4()
{
	$js_quest_text[0] = "Talk to Serenas' advisors or Legatus Pavola and get them on board.";
	$js_quest_text[1] = "Let Serenas know that his plan has been approved. Let the clean up begin.";
	$js_quest_text[2] = "You decided that the raid would have been a disaster and sided against it. Serenas wasn't impressed.";
	$js_quest_text[3] = "The city is in chaos. House Aurelian has weakened greatly.";
	
	jsSetQuestName("A New Broom Sweeps Clean");
	
	aod.jnl_HD4_phase1 = true;

	if(aod.jnl_HD4_phase4)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
		remQuest(HD4a);
		remQuest(HD4b);
		remQuest(HD4c);
	}
	else if(aod.jnl_HD4_phase3)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
		remQuest(HD4a);
		remQuest(HD4b);
		remQuest(HD4c);
	}
	else if(aod.jnl_HD4_phase2)
	{
		jsSetQuestStatus("Talk to Serenas");
		jsAddQuestDesc(1);
		remQuest(HD4a);
		remQuest(HD4b);
		remQuest(HD4c);
	}
	else if(aod.jnl_HD4_phase1)
	{
		jsSetQuestStatus("Clean up the Slums");
		jsAddQuestDesc(0);
	}
}

function Quest_HD4a()
{
	$js_quest_text[0] = "Try to get her support.";
	
	jsSetQuestName("A New Broom Sweeps Clean");
	
	jsSetQuestStatus("Talk to Lady Lorenza");
	jsAddQuestDesc(0);
}

function Quest_HD4b()
{
	$js_quest_text[0] = "Try to get his support. You can find him at the Imperial Guards' barracks in the Arena District.";
	
	jsSetQuestName("A New Broom Sweeps Clean");
	
	jsSetQuestStatus("Talk to Legatus Pavola");
	jsAddQuestDesc(0);
}

function Quest_HD4c()
{
	$js_quest_text[0] = "Try to get his support.";
	
	jsSetQuestName("A New Broom Sweeps Clean");
	
	jsSetQuestStatus("Talk to Master Strabos");
	jsAddQuestDesc(0);
}

// TRN HD Quests

function Quest_TeronBandit()
{
	$js_quest_text[0] = "Dellar asked you to investigate a raiders' camp nearby.";
	$js_quest_text[1] = "Talk to the raiders and see what they want.";
	$js_quest_text[2] = "You negotiated with the raiders a ransom of 1000 imperials. Try to convince Dellar to pay it or look for alternate solutions.";
	$js_quest_text[3] = "You negotiated with the raiders a ransom of 500 imperials. Try to convince Dellar to pay it or look for alternate solutions.";
	$js_quest_text[4] = "You killed the leader and intimidated the rest of the raiders.";
	$js_quest_text[5] = "You convinced Dellar to pay the ransom to release the hostage.";
	$js_quest_text[6] = "You killed the raiders and took the hostage back to Teron.";
	$js_quest_text[7] = "You convinced Cado to step in and deal with the raiders.";
	$js_quest_text[8] = "You convinced the raiders to attack the Aurelian outpost, killing two birds with one stone.";
	$js_quest_text[9] = "You gave Dellar as much info as you could about the camp, but it wasn't enough and the hostage died.";
	$js_quest_text[10] = "You gave Dellar as much info as you could about the camp, which was enough to surprise the raiders and secure the hostage.";
	$js_quest_text[11] = "The raiders are dead, you should take the hostage back to Teron.";
	
	jsSetQuestName("The Raiders");
	aod.quest_teronBandit_active = true;

	if(aod.quest_teronBandit_phase4g)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(10);
		aod.quest_teronBandit_active = false;
	}
	else if(aod.quest_teronBandit_phase4f)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(9);
		aod.quest_teronBandit_active = false;
	}
	else if(aod.quest_teronBandit_phase4e)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(8);
		aod.quest_teronBandit_active = false;
	}
	else if(aod.quest_teronBandit_phase4d)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(7);
		aod.quest_teronBandit_active = false;
	}
	else if(aod.quest_teronBandit_phase4c)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(6);
		aod.quest_teronBandit_active = false;
	}
	else if(aod.quest_teronBandit_phase4b)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(5);
		aod.quest_teronBandit_active = false;
	}
	else if(aod.quest_teronBandit_phase4a)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
		aod.quest_teronBandit_active = false;
	}
	else if(aod.quest_teronBandit_phase3c)
	{
		jsSetQuestStatus("Talk to the hostage");
		jsAddQuestDesc(11);
	}
	else if(aod.quest_teronBandit_phase3b)
	{
		jsSetQuestStatus("Return to Dellar");
		jsAddQuestDesc(3);
	}
	else if(aod.quest_teronBandit_phase3a)
	{
		jsSetQuestStatus("Return to Dellar");
		jsAddQuestDesc(2);
	}
	else if(aod.quest_teronBandit_phase2)
	{
		jsSetQuestStatus("Visit the raiders' camp");
		jsAddQuestDesc(1);
	}
	else if(aod.quest_teronBandit_phase1)
	{
		jsSetQuestStatus("Talk to Dellar");
		jsAddQuestDesc(0);
	}
}

function Quest_TeronOutpost()
{
	$js_quest_text[0] = "Dellar asked you to investigate an Aurelian outpost nearby.";
	$js_quest_text[1] = "Find a way to get inside and see what the Aurelians are up to. Dellar mentioned that loremaster Sohrab was heading there, so maybe you can get yourself a nice robe and see where it gets you.";
	$js_quest_text[2] = "You killed a few Aurelian legionaries, but there are more men inside. It's time to finish the job.";
	$js_quest_text[3] = "You killed a few Aurelian legionaries and workers, but there are more men outside. It's time to finish the job.";
	$js_quest_text[4] = "You managed to kill the Aurelian men. Report to Dellar.";
	$js_quest_text[5] = "You used the raiders to wipe out the Aurelian men and managed to get the smelter going.";
	$js_quest_text[6] = "You used the raiders to wipe out the Aurelian men, but you couldn't do much with the smelter.";
	$js_quest_text[7] = "You managed to get inside the mine and get the smelter going, which earned you a one-way trip to Maadoran.";
	$js_quest_text[8] = "You managed to get inside the mine and blow up the smelter, sealing the mine.";
	$js_quest_text[9] = "You managed to kill the Aurelian men, but you couldn't do much with the smelter.";
	$js_quest_text[10] = "You managed to kill the Aurelian men and get the smelter going.";
	$js_quest_text[11] = "You managed to steal the power tube, rending the mine inoperable.";
	$js_quest_text[12] = "The outpost's guards have been poisoned. They are undoubtedly aware that it's not an accident and will attack anyone who comes close.";
	
	
	jsSetQuestName("The Aurelian Outpost");
	aod.quest_TeronOutpost_active = true;

	if(aod.quest_teronOutpost_phase4g)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(11);
		aod.quest_TeronOutpost_active = false;
		if(aod.quest_mineWine_phase5 == 0)
			remQuest(MineWine);
	}
	else if(aod.quest_teronOutpost_phase4f)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(10);
		aod.quest_TeronOutpost_active = false;
		if(aod.quest_mineWine_phase5 == 0)
			remQuest(MineWine);
	}
	else if(aod.quest_teronOutpost_phase4e)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(9);
		aod.quest_TeronOutpost_active = false;
		if(aod.quest_mineWine_phase5 == 0)
			remQuest(MineWine);
	}
	else if(aod.quest_teronOutpost_phase4d)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(8);
		aod.quest_TeronOutpost_active = false;
		if(aod.quest_mineWine_phase5 == 0)
			remQuest(MineWine);
	}
	else if(aod.quest_teronOutpost_phase4c)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(7);
		aod.quest_TeronOutpost_active = false;
		if(aod.quest_mineWine_phase5 == 0)
			remQuest(MineWine);
	}
	else if(aod.quest_teronOutpost_phase4b)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(6);
		aod.quest_TeronOutpost_active = false;
		if(aod.quest_mineWine_phase5 == 0)
			remQuest(MineWine);
	}
	else if(aod.quest_teronOutpost_phase4a)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(5);
		aod.quest_TeronOutpost_active = false;
		if(aod.quest_mineWine_phase5 == 0)
			remQuest(MineWine);
	}
	else if(aod.quest_teronOutpost_phase3c)
	{
		jsSetQuestStatus("Report to Dellar");
		jsAddQuestDesc(4);
	}
	else if(aod.quest_teronOutpost_phase3b)
	{
		jsSetQuestStatus("Finish the job");
		jsAddQuestDesc(3);
	}
	else if(aod.quest_teronOutpost_phase3a)
	{
		jsSetQuestStatus("Finish the job");
		jsAddQuestDesc(2);
	}
	else if(aod.quest_mineWine_phase5)
	{
		jsSetQuestStatus("Attack the outpost");
		jsAddQuestDesc(12);
	}
	else if(aod.quest_teronOutpost_phase2)
	{
		jsSetQuestStatus("Investigate the outpost");
		jsAddQuestDesc(1);
	}
	else if(aod.quest_teronOutpost_phase1)
	{
		jsSetQuestStatus("Talk to Dellar");
		jsAddQuestDesc(0);
	}
}

function Quest_MineWine()
{
	$js_quest_text[0] = "Talk to Rhaskos about the supplies. You can find him in the shanty town.";
	$js_quest_text[1] = "You need to get some poison to spike the wine.";
	$js_quest_text[2] = "You have the poison, now all that is left is to spike the wine.";
	$js_quest_text[3] = "Find a way to deliver the wine to the outpost.";
	$js_quest_text[4] = "You poisoned the mining outpost, making the upcoming battle easier.";

	jsSetQuestName("The outpost supplies");
	aod.quest_mineWine_active = true;

	if(aod.quest_mineWine_phase5)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
		aod.quest_mineWine_active = false;
	}
	else if(aod.quest_mineWine_phase4)
	{
		jsSetQuestStatus("Deliver the wine");
		jsAddQuestDesc(3);
	}
	else if(aod.quest_mineWine_phase3)
	{
		jsSetQuestStatus("Spike the wine");
		jsAddQuestDesc(2);
	}
	else if(aod.quest_mineWine_phase2)
	{
		jsSetQuestStatus("Get some poison");
		jsAddQuestDesc(1);
	}
	else if(aod.quest_mineWine_phase1)
	{
		jsSetQuestStatus("Talk to Rhaskos");
		jsAddQuestDesc(0);
	}
}

// IG Questline

function Quest_IG1()
{
	$js_quest_text[0] = "Dressed as a raider, you attacked one of the Commercium's caravans to give the Imperial Guards a pretext to seize the power from House Daratan.";
	
	jsSetQuestName("The End Justifies the Means");

	if(aod.quest_ig1_phase1)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(0);
	}
}

function Quest_IG2()
{
	$js_quest_text[0] = "Talk to the Centurion for your next assignment. He is outside the barracks.";
	$js_quest_text[1] = "You took part in coordinated attacks on Teron's towers aimed to gain control over the town's perimeter and seal House Daratan's forces inside.";
	
	jsSetQuestName("The Wind Sweeping Through Towers...");
	aod.quest_IG2_active = true;

	if(aod.quest_ig2_phase2)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(1);
		aod.quest_IG2_active = false;
	}
	
	else if(aod.quest_ig2_phase1)
	{
		jsSetQuestStatus("Talk to the Centurion");
		jsAddQuestDesc(0);
	}
}

function Quest_IG3()
{
	$js_quest_text[0] = "Talk to the Centurion when you are ready to deliver the ultimatum.";
	$js_quest_text[1] = "Talk to Carrinas when you are ready to deliver the ultimatum.";
	$js_quest_text[2] = "You convinced Lord Antidas and Commander Carrinas to forge an alliance, which granted Carrinas the much needed legitimacy.";
	$js_quest_text[3] = "You provoked Lord Antidas to attack the Imperial Guards delegation. In a fight that ensued Lord Antidas and his men were killed, which put Teron under Commander Carrinas' control.";
	$js_quest_text[4] = "Seizing the opportunity, you grabbed the 'alliance' documents and headed for Maadoran.";
	
	jsSetQuestName("Serving a Notice");
	
	if(aod.quest_ig3 == 4)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
	}
	else if(aod.quest_ig3 == 3)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
	}
	else if(aod.quest_ig3 == 2)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
	}
	
	else if(aod.quest_ig3 == 1)
	{
		jsSetQuestStatus("Talk to Carrinas");
		jsAddQuestDesc(1);
	}
	
	else if(aod.quest_ig3 == 0)
	{
		jsSetQuestStatus("Talk to the Centurion");
		jsAddQuestDesc(0);
	}
}

function Quest_IG3_PostPalace()
{
	$js_quest_text[0] = "Your training is complete. Carrinas is waiting for you outside the barracks.";
	
	jsSetQuestName("Reporting for duty");
	
	jsSetQuestStatus("Talk to Carrinas");
	jsAddQuestDesc(0);
}

function Quest_IG_ArriveMDN()
{
	$js_quest_text[0] = "Go to the Arena District and talk to Legatus Pavola.";
	
	jsSetQuestName("Reporting for Duty");
	
	jsSetQuestStatus("Report to Legatus Pavola");
	jsAddQuestDesc(0);
}

function Quest_IG4()
{
	$js_quest_text[0] = "You were assigned to protect Master Strabos, the guildmaster of the Commercium, in exchange for vital information. You can find him in the Trade District.";
	$js_quest_text[1] = "Protect Master Strabos against all threats.";
	$js_quest_text[2] = "You killed Hamza, the famed assassin, and learned that Gaelius made a deal with the Ordu. Share the good news with Pavola.";
	$js_quest_text[3] = "You saved Strabos' arse and learned that Gaelius made a deal with the Ordu. Before heading out to save the world, enjoy the hospitality of Maadoran and visit a whorehouse or two - they make the world worth saving.";
	$js_quest_text[4] = "You let Hamza kill Strabos. Gaelius should be very grateful.";
	
	jsSetQuestName("The Bodyguard");

	aod.quest_ig4_phase1 = true;

	if(aod.jnl_ig4_phase5)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
	}
	else if(aod.quest_ig4_phase4)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
	}
	else if(aod.quest_ig4_phase3)
	{
		jsSetQuestStatus("Report to Legatus Pavola");
		jsAddQuestDesc(2);
	}
	else if(aod.quest_ig4_phase2)
	{
		jsSetQuestStatus("Protect Strabos");
		jsAddQuestDesc(1);
	}
	else if(aod.quest_ig4_phase1)
	{
		jsSetQuestStatus("Talk to Strabos");
		jsAddQuestDesc(0);
	}
}

function Quest_IG5()
{
	$js_quest_text[0] = "Travel to Harran's Pass in the northern mountains.";
	$js_quest_text[1] = "Try to weaken the Ordu.";
	$js_quest_text[2] = "The Ordu are coming. Switch to Plan B - pray for divine intervention.";
	$js_quest_text[3] = "You convinced the Ordu to stay on the plains.";
	$js_quest_text[4] = "You convinced the Ordu to stay on the plains, but send a small group to attack the pass and make you a war hero.";
	
	jsSetQuestName("The Ordu Are Coming!");

	aod.jnl_ig5_phase1 = true;

	if(aod.jnl_ig5_phase5)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
	}
	else if(aod.jnl_ig5_phase4)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_ig5_phase3)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_ig5_phase2)
	{
		jsSetQuestStatus("Weaken the Ordu");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_ig5_phase1)
	{
		jsSetQuestStatus("Travel to Harran's Pass");
		jsAddQuestDesc(0);
	}
}

function Quest_IG6()
{
	$js_quest_text[0] = "Boost the Pass' defenses.";
	$js_quest_text[1] = "You survived the attack on the pass! Your place in history is assured.";
	
	jsSetQuestName("You Shall Not Pass");

	aod.jnl_ig6_phase1 = true;

	if(aod.jnl_ig6_phase2)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_ig6_phase1)
	{
		jsSetQuestStatus("Prepare for the attack");
		jsAddQuestDesc(0);
	}
}

function Quest_IG_CaerTor()
{
	$js_quest_text[0] = "Paullus isn't convinced and wants another test. Talk to Legatus Raenas to get the ball rolling.";
	$js_quest_text[1] = "Convince at least two of Raenas' Centurions to accept you. Talk to Centurion Barnus, Farro, and Diocletus.";
	$js_quest_text[2] = "You got two votes - enough to pass the test.";
	$js_quest_text[3] = "You got all three votes - more than enough to prove yourself.";
	$js_quest_text[4] = "Raenas accepted you as a centurion and gave you five men. Report back to Paullus.";
	
	jsSetQuestName("Office Politics");
	
	if(aod.quest_IG_CaerTor == 2)
	{
		jsSetQuestStatus("Talk to Paullus");
		jsAddQuestDesc(4);
	}
	else if(aod.quest_CT01_votes >= 3)
	{
		jsSetQuestStatus("Talk to Raenas");
		jsAddQuestDesc(3);
	}
	else if(aod.quest_CT01_votes >= 2)
	{
		jsSetQuestStatus("Talk to Raenas");
		jsAddQuestDesc(2);
	}
	else if(aod.quest_IG_CaerTor == 1)
	{
		jsSetQuestStatus("Talk to the centurions");
		jsAddQuestDesc(1);
	}
	else if(aod.quest_IG_CaerTor == 0)
	{
		jsSetQuestStatus("Talk to Raenas");
		jsAddQuestDesc(0);
	}
}

function Quest_IG_ArriveGNZ()
{
	$js_quest_text[0] = "Dux Paullus loaned you to Lord Meru for a mission of great importance. Pack your things, soldier, you're going to Ganezzar.";
	$js_quest_text[1] = "Meru told you about Al-Akia, the birthplace of the Gods.";
	
	jsSetQuestName("Ganezzar");

	if(aod.jnl_IG_ArriveGNZ == 1)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_IG_ArriveGNZ == 0)
	{
		jsSetQuestStatus("Report to Meru");
		jsAddQuestDesc(0);
	}
}

function Quest_IG_GNZ1()
{
	$js_quest_text[0] = "Report to Meru when you're ready to join the expedition.";
	$js_quest_text[1] = "Explore the lower levels of Al-Akia.";
	$js_quest_text[2] = "The ritual chamber and the machinery appear to be intact.";
	$js_quest_text[3] = "While you were sight-seeing, Aurelian forces attacked the expedition.";
	$js_quest_text[4] = "Return to Ganezzar and report to Meru.";
	$js_quest_text[5] = "You explored the ruins of Al-Akia and started a war. Not bad for a day's work.";
	
	jsSetQuestName("The Birthplace of the Gods");

	if(aod.jnl_IG_GNZ1 == 6)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(5);
	}
	else if(aod.jnl_IG_GNZ1 == 5)
	{
		jsSetQuestStatus("Report to Meru");
		jsAddQuestDesc(4);
	}
	else if(aod.jnl_IG_GNZ1 == 4)
	{
		jsSetQuestStatus("Return to Ganezzar");
		jsAddQuestDesc(4);
	}
	else if(aod.jnl_IG_GNZ1 == 3)
	{
		jsSetQuestStatus("Get past the Aurelian soldiers");
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_IG_GNZ1 == 2)
	{
		jsSetQuestStatus("Return topside");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_IG_GNZ1 == 1)
	{
		jsSetQuestStatus("Explore the complex");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_IG_GNZ1 == 0)
	{
		jsSetQuestStatus("Report to Meru");
		jsAddQuestDesc(0);
	}
}

function Quest_IG_GNZ1_Thieves()
{
	$js_quest_text[0] = "You agreed to kill some guards for Glabrio to pay for your way into the city.";
	$js_quest_text[1] = "The guards are dead. Glabrio had better keep his end of the deal.";
	$js_quest_text[2] = "You killed Glabrio and his crew. They were in your way and you were in a hurry.";
	
	jsSetQuestName("The Birthplace of the Gods");

	if(aod.jnl_IG_GNZ1_thieves == 2)
	{
		jsSetQuestStatus("Exit the tunnels");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_IG_GNZ1_thieves == 1)
	{
		jsSetQuestStatus("Return to Glabrio");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_IG_GNZ1_thieves == 0)
	{
		jsSetQuestStatus("Kill the guards");
		jsAddQuestDesc(0);
	}
}

function Quest_IG_GNZ2()
{
	$js_quest_text[0] = "Return to Caer-Tor and discuss the situation with Paullus.";
	$js_quest_text[1] = "Talk to Carrinas about breaking the siege.";
	$js_quest_text[2] = "For a brief moment the future of the Imperial Guards and House Crassus was in your hands. Hopefully, you've made the right choice.";
	
	jsSetQuestName("Backing the Winner");

	if(aod.jnl_IG_GNZ2 == 2)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_IG_GNZ2 == 1)
	{
		jsSetQuestStatus("Talk to Carrinas");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_IG_GNZ2 == 0)
	{
		jsSetQuestStatus("Talk to Paullus");
		jsAddQuestDesc(0);
	}
}

function Quest_IG_GNZ3()
{
	$js_quest_text[0] = "You charged into the breach and lived to tell the tale.";
	$js_quest_text[1] = "You infiltrated the tower and opened the gate.";
	$js_quest_text[2] = "You killed Legatus Hagnon in his own tent.";
	
	jsSetQuestName("The Siege");

	if(aod.jnl_IG_GNZ3 == 2)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_IG_GNZ3 == 1)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_IG_GNZ3 == 0)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(0);
	}
}

function Quest_IG_Paullus_Temple()
{
	$js_quest_text[0] = "Report to Paullus. You can find him in Maadoran's palace.";
	$js_quest_text[1] = "Report to Paullus. You can find him in Caer-Tor.";
	$js_quest_text[2] = "Paullus has asked you to find the temple of Thor-Agoth.";
	$js_quest_text[3] = "You found the temple of Thor-Agoth for Paullus.";
	
	jsSetQuestName("The Temple of Thor-Agoth");
	
	if(aod.jnl_IG_Paullus_Temple == 2)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_IG_Paullus_Temple == 1)
	{
		jsSetQuestStatus("Find the temple");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_IG_Paullus_Temple == 0)
	{
		jsSetQuestStatus("Talk to Paullus");
		if(aod.ending_gnz_IG_joins_HA)
			jsAddQuestDesc(0);
		else
			jsAddQuestDesc(1);
	}
}

function Quest_IG_Carrinas_Temple()
{
	$js_quest_text[0] = "Report to Carrinas. You can find him at the castle.";
	$js_quest_text[1] = "Carrinas has asked you to find the temple of Thor-Agoth.";
	$js_quest_text[2] = "You found the temple of Thor-Agoth for Carrinas.";
	
	jsSetQuestName("The Temple of Thor-Agoth");
	
	if(aod.jnl_IG_Carrinas_Temple == 2)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_IG_Carrinas_Temple == 1)
	{
		jsSetQuestStatus("Find the temple");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_IG_Carrinas_Temple == 0)
	{
		jsSetQuestStatus("Talk to Carrinas");
		jsAddQuestDesc(0);
	}
}

// TRN Misc Quests

function Quest_AemolasGold()
{
	$js_quest_text[0] = "Aemolas asked you to retrieve his gold from the settlement that was attacked by raiders.";
	$js_quest_text[1] = "You brought the gold to Aemolas as promised.";
	$js_quest_text[2] = "You let Mykkos kill Aemolas.";
	$js_quest_text[3] = "You double-crossed Mykkos and killed him, saving Aemolas' life.";
	$js_quest_text[4] = "You double-crossed Mykkos and killed him, but Aemolas didn't survive the battle.";
	
	jsSetQuestName("Aemolas' Gold");

	if(aod.jnl_AemolasGold == 4)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
	}
	else if(aod.jnl_AemolasGold == 3)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_AemolasGold == 2)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_AemolasGold == 1)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_AemolasGold == 0)
	{
		jsSetQuestStatus("Find the gold");
		jsAddQuestDesc(0);
	}
}

// MDN Misc Quests

function Quest_Militiades()
{
	$js_quest_text[0] = "If you're up for another exciting adventure, look Miltiades up when you go to Maadoran. You never know, it might be big.";
	$js_quest_text[1] = "Maadoran is a big city. You wonder where he might be...";
	$js_quest_text[2] = "Miltiades had a falling out with his partner. He wants you to visit him and get the money.";
	$js_quest_text[3] = "Miltiades crossed the Forty Thieves and you decided to leave him to his long overdue fate.";
	$js_quest_text[4] = "Miltiades actually paid you his debt. Oh, and it's Lord Miltiades now. His Lordship promised to send for you when your skills will come in handy again.";
	$js_quest_text[5] = "After some considerations, you decided to leave Miltiades to his long overdue fate.";
	
	jsSetQuestName("Fool Me Twice...");
	
	aod.jnl_Militiades_phase1 = true;

	if(aod.jnl_Militiades_phase6)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(5);
	}
	else if(aod.jnl_Militiades_phase5)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
	}
	else if(aod.jnl_Militiades_phase4)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_Militiades_phase3)
	{
		jsSetQuestStatus("Talk to Miltiades");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_Militiades_phase2)
	{
		jsSetQuestStatus("Find Miltiades in Maadoran");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_Militiades_phase1)
	{
		jsSetQuestStatus("Find Miltiades in Maadoran");
		jsAddQuestDesc(0);
	}
}

function Quest_GrainOfTruth()
{
	$js_quest_text[0] = "Investigate the strange drawing in Lord Gaelius' library.";
	$js_quest_text[1] = "The drawing depicts a place called Al-Akia.";
	
	jsSetQuestName("The Grain of Truth");

	if(aod.quest_grainTruth_status >= 3)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(1);
	}
	else
	{
		jsSetQuestStatus("Obtain a copy of the drawing");
		jsAddQuestDesc(0);
	}
}

function Quest_Basil()
{
	$js_quest_text[0] = "Talk to Basileios. The word on the street is that he has problems and helping people with problems is your specialty. He owns a tavern near the arena.";
	$js_quest_text[1] = "Quintus owns a whorehouse in the northern part of the Arena District.";
	$js_quest_text[2] = "Talk to Basil and Quintus and let them know that they are safe for now.";
	$js_quest_text[3] = "You have a feeling that it's far from over yet, but it's no longer your problem.";
	$js_quest_text[4] = "You left Basil to his fate. That's one way to solve a problem.";
	
	jsSetQuestName("Problem Solving");
	
	aod.jnl_basil_phase1 = true;
	
	if(aod.jnl_basil_phase5)
	{
		// jsSetQuestStatus("Keep an eye on Basil's tavern");
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_basil_phase4)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
	}
	else if(aod.jnl_basil_phase3)
	{
		jsSetQuestStatus("Talk to Basil");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_basil_phase2)
	{
		jsSetQuestStatus("Talk to Quintus");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_basil_phase1)
	{
		jsSetQuestStatus("Talk to Basileios");
		jsAddQuestDesc(0);
	}
}

function Quest_Basil_TG()
{
	$js_quest_text[0] = "It's time to check on your good friend Basil in Maadoran.";
	$js_quest_text[1] = "Check on Quintus as well.";
	$js_quest_text[2] = "Return to Basil and let him know what transpired.";
	$js_quest_text[3] = "Keep an eye on Basil.";
	$js_quest_text[4] = "The Forty Thieves want a meeting.";
	$js_quest_text[5] = "The meeting didn't go as planned. Return to Basil.";
	$js_quest_text[6] = "The Forty Thieves invited you to another meeting. You declined.";
	$js_quest_text[7] = "The Forty Thieves invited you to another meeting. Things got out of hand and you killed their enforcer and his men.";
	$js_quest_text[8] = "The Forty Thieves invited you to another meeting. You made a deal with them.";
	// Endings
	$js_quest_text[9] = "The Forty Thieves won't bother Basil in the near future.";
	$js_quest_text[10] = "The Forty Thieves won't bother Basil in the near future. From now on he's paying you.";
	$js_quest_text[11] = "You're working for the Forty Thieves now, collecting money.";
	$js_quest_text[12] = "You walked into an ambush. Probably not your first ambush and definitely not the last.";
	
	jsSetQuestName("More Problem Solving");
	
	if(aod.jnl_basil_TG == 12)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(12);
	}
	else if(aod.jnl_basil_TG == 11)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(11);
	}
	else if(aod.jnl_basil_TG == 10)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(10);
	}
	else if(aod.jnl_basil_TG == 9)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(9);
	}
	else if(aod.jnl_basil_TG == 8)
	{
		jsSetQuestStatus("Talk to Basil");
		jsAddQuestDesc(8);
	}
	else if(aod.jnl_basil_TG == 7)
	{
		jsSetQuestStatus("Talk to Basil");
		jsAddQuestDesc(7);
	}
	else if(aod.jnl_basil_TG == 6)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(6);
	}
	else if(aod.jnl_basil_TG == 5)
	{
		jsSetQuestStatus("Talk to Basil");
		jsAddQuestDesc(5);
	}
	else if(aod.jnl_basil_TG == 4)
	{
		jsSetQuestStatus("Go to the meeting with the Forty Thieves");
		jsAddQuestDesc(4);
	}
	else if(aod.jnl_basil_TG == 3)
	{
		jsSetQuestStatus("Keep an eye on Basil's tavern");
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_basil_TG == 2)
	{
		jsSetQuestStatus("Talk to Basil");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_basil_TG == 1)
	{
		jsSetQuestStatus("Talk to Quintus");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_basil_TG == 0)
	{
		jsSetQuestStatus("Talk to Basileios");
		jsAddQuestDesc(0);
	}
}

function Quest_Kemnebi()
{
	$js_quest_text[0] = "Gracius sent you to Kemnebi in Maadoran if you're looking for work.";
	$js_quest_text[1] = "Basil sent you to Kemnebi if you're looking for work.";
	$js_quest_text[2] = "Talk to Kemnebi when're ready to leave in search of fortune and glory.";
	$js_quest_text[3] = "You decided that the fight with The Hundred Swords' mercs is not your fight and returned to Maadoran.";
	$js_quest_text[4] = "You met the infamous Hundred Swords in battle and lived to tell the tale.";
	
	jsSetQuestName("Down On Luck");
	
	if(aod.jnl_kemnebi_phase4)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
	}
	else if(aod.jnl_kemnebi_phase3)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_kemnebi_phase2)
	{
		jsSetQuestStatus("Talk to Kemnebi");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_kemnebi_phase1b)
	{
		jsSetQuestStatus("Talk to Kemnebi");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_kemnebi_phase1a)
	{
		jsSetQuestStatus("Talk to Kemnebi");
		jsAddQuestDesc(0);
	}
}

function Quest_Package()
{
	$js_quest_text[0] = "You can find Neros' establishment deep in the Slums.";
	$js_quest_text[1] = "The fucker almost got you killed, but now you know his name. It's payback time!";
	$js_quest_text[2] = "You saved Neros' life. Not that it's something worth bragging about.";
	$js_quest_text[3] = "The fucker almost got you killed. You doubt that you'll see him again though.";
	$js_quest_text[4] = "Well, at least you got some money for your trouble.";
	$js_quest_text[5] = "You killed the young man and his father. Justice was served!";
	$js_quest_text[6] = "What a day... The kid almost got you killed and Neros didn't want to pay you what's right for saving his lousy life. Well, Neros is dead and the kid is next, now you know his name. It's payback time!";
	
	jsSetQuestName("The Package");
	
	aod.jnl_package_phase1 = true;
	
	if(aod.jnl_package_phase6)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(5);
	}
	else if(aod.jnl_package_phase5)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
	}
	else if(aod.jnl_package_phase4)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_package_phase3)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_package_phase2a)
	{
		jsSetQuestStatus("Find the youth");
		jsAddQuestDesc(6);
	}
	else if(aod.jnl_package_phase2)
	{
		jsSetQuestStatus("Find the youth");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_package_phase1)
	{
		jsSetQuestStatus("Deliver the package to Neros");
		jsAddQuestDesc(0);
	}
}

function Quest_Amerius()
{
	$js_quest_text[0] = "Ask Valla to give Amerius his house back.";
	$js_quest_text[1] = "Valla is gone. Tell Amerius that he can have his house back.";
	$js_quest_text[2] = "Justice has been served.";
	$js_quest_text[3] = "You made a deal with Valla instead. Find Esdras in Ganezzar and talk to him about the armor.";
	$js_quest_text[4] = "The power armor is in a local warehouse, guarded by mercenaries. Talk to Esdras when you're ready to go.";
	$js_quest_text[5] = "You've got the power armor. Return to Marcus Valla.";
	$js_quest_text[6] = "You've completed your dealings with Marcus Valla.";
	
	jsSetQuestName("The Rightful Owner");
	
	aod.jnl_amerius_phase1 = true;
	
	if(aod.jnl_amerius == 6)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(6);
	}
	else if(aod.jnl_amerius == 5)
	{
		jsSetQuestStatus("Talk to Valla");
		jsAddQuestDesc(5);
	}
	else if(aod.jnl_amerius == 4)
	{
		jsSetQuestStatus("Talk to Esdras");
		jsAddQuestDesc(4);
	}
	else if(aod.jnl_amerius == 3)
	{
		jsSetQuestStatus("Talk to Esdras");
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_amerius == 2)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_amerius == 1)
	{
		jsSetQuestStatus("Talk to Amerius");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_amerius == 0)
	{
		jsSetQuestStatus("Talk to Valla");
		jsAddQuestDesc(0);
	}
}

function Quest_Arena()
{
	$js_quest_text[0] = "Maadoran is famous for its arena. You should visit it while you're in the city.";
	$js_quest_text[1] = "Vitus suggested to crack a few skulls at the arena. The pass isn't going anywhere, so might as well show the peasants what the Imperial Guards are made of.";
	$js_quest_text[2] = "Talk to the Arena Master when you're ready to fight.";
	$js_quest_text[3] = "The Arena Master needs some time to set up new fights. Talk to Basileios in the mean time.";
	$js_quest_text[4] = "You are the new champion. Well done!";
	
	jsSetQuestName("The Arena");
	
	aod.jnl_arena_phase1 = true;
	
	if(aod.jnl_arena_phase5)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
	}
	else if(aod.jnl_arena_phase4)
	{
		jsSetQuestStatus("Solve Basil's problems");
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_arena_phase3)
	{
		jsSetQuestStatus("Talk to the Arena Master");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_arena_phase2)
	{
		jsSetQuestStatus("Talk to the Arena Master");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_arena_phase1)
	{
		jsSetQuestStatus("Talk to the Arena Master");
		jsAddQuestDesc(0);
	}
}

function Quest_Arena_Challengers()
{
	$js_quest_text[0] = "Talk to the Arena Master when you're in Maadoran.";
	$js_quest_text[1] = "Talk to the Arena Master when you're ready to fight.";
	$js_quest_text[2] = "You successfully defended your title. For now.";
	
	jsSetQuestName("The Challengers");
	
	aod.jnl_arena_phase1 = true;
	
	if(aod.arena_challengers == 3)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
	}
	else if(aod.arena_challengers == 2)
	{
		jsSetQuestStatus("Talk to the Arena Master");
		jsAddQuestDesc(1);
	}
	else if(aod.arena_challengers == 1)
	{
		jsSetQuestStatus("Talk to the Arena Master");
		jsAddQuestDesc(0);
	}
}

function Quest_theGem()
{
	$js_quest_text[0] = "Nasir asked you to see Silvanus about a rare sapphire. You can find him in the Palace district.";
	$js_quest_text[1] = "You have acquired the sapphire.";
	$js_quest_text[2] = "You have delivered the gem to Nasir.";
	
	jsSetQuestName("The Gem");
	
	if(aod.npc_nasir_gaveGem)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
	}
	else if(dlgOwnsItem(2007))
	{
		jsSetQuestStatus("Talk to Nasir");
		jsAddQuestDesc(1);
	}
	else if(aod.npc_nasir_accepted)
	{
		jsSetQuestStatus("Visit Silvanus' house");
		jsAddQuestDesc(0);
	}
}

// Locations Quests

/*function Quest_Hellgate()
{
	$js_quest_text[0] = "Find out what happened to Esbenus' men.[To be continued...]";
	
	jsSetQuestName("Hellgate");

	if(aod.quest_Hellgate == 1)
	{
		jsSetQuestStatus("Find Hellgate - an ancient temple built into a mountain");
		jsAddQuestDesc(0);
	}
}*/

function Quest_Zamedi()
{
	$js_quest_text[0] = "You learned the location of the ruins of Zamedi.";
	$js_quest_text[1] = "Gaelius sent you to the ruins of Zamedi and gave you a key for the tower.";
	$js_quest_text[2] = "The guardian of the tower asked you to get him a ring from the upper level.";
	$js_quest_text[3] = "You slain the demon of the tower.";
	$js_quest_text[4] = "You convinced the demon to let you live.";
	$js_quest_text[5] = "You escaped from the demon and the tower. Hopefully, you won't see him again.";
	
	jsSetQuestName("The Tower of Zamedi");
	
	aod.jnl_Zamedi_phase1 = true;

	if(aod.jnl_Zamedi_phase6)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(5);
	}
	else if(aod.jnl_Zamedi_phase5)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
	}
	else if(aod.jnl_Zamedi_phase4)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_Zamedi_phase3)
	{
		jsSetQuestStatus("Find the ring and take it to the demon");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_Zamedi_phase2)
	{
		jsSetQuestStatus("Explore the ruins");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_Zamedi_phase1)
	{
		jsSetQuestStatus("Explore the ruins");
		jsAddQuestDesc(0);
	}
}

function Quest_Saross()
{
	$js_quest_text[0] = "You discovered the location of the Imperial Library of Saross.";
	$js_quest_text[1] = "You found an old generator missing a few parts. If you can get it up and running, you'd be able to explore the library better.";
	$js_quest_text[2] = "You fixed the generator but found nothing of interest yet.";
	$js_quest_text[3] = "You found a hidden chamber containing ancient tablets.";
	
	jsSetQuestName("The Library of Saross");
	
	aod.jnl_Saross_phase1 = true;

	if(aod.jnl_Saross_end_01)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_Saross_phase3)
	{
		jsSetQuestStatus("Explore the ruins");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_Saross_phase2)
	{
		jsSetQuestStatus("Fix the generator");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_Saross_phase1)
	{
		jsSetQuestStatus("Explore the ruins");
		jsAddQuestDesc(0);
	}
}

function Quest_Inferiae()
{
	$js_quest_text[0] = "You discovered the location of the village of Inferiae.";
	$js_quest_text[1] = "You arrived to Inferiae and met its lovely inhabitants.";
	$js_quest_text[2] = "You discovered the remains of an ancient tower, buried under the village.";
	$js_quest_text[3] = "You escaped the tower via a portal, discovering the remains of the master of the tower.";
	
	jsSetQuestName("Inferiae");
	
	aod.jnl_inferiae_phase1 = true;

	if(aod.jnl_inferiae_end_01)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_inferiae_phase3)
	{
		jsSetQuestStatus("Explore the buried tower");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_inferiae_phase2)
	{
		jsSetQuestStatus("Explore the village");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_inferiae_phase1)
	{
		jsSetQuestStatus("Explore the village");
		jsAddQuestDesc(0);
	}
}

function Quest_theArch()
{
	$js_quest_text[0] = "You discovered the location of an ancient arch.";
	$js_quest_text[1] = "You arrived to the site and ran into your old friend Esbenus.";
	$js_quest_text[2] = "You explored the site and the arch but found nothing of interest.";
	$js_quest_text[3] = "You discovered the \"ghost\" machines powering up the arch but couldn't activate them.";
	$js_quest_text[4] = "The site is now abandoned.";
	$js_quest_text[5] = "You had an interesting conversation with an otherworldly being.";
	
	jsSetQuestName("The Arch");
	
	aod.jnl_arch_phase1 = true;

	if(aod.jnl_arch_end_02)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(5);
	}
	else if(aod.jnl_arch_end_01)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
	}
	else if(aod.jnl_arch_phase4)
	{
		jsSetQuestStatus("Activate the machines");
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_arch_phase3)
	{
		jsSetQuestStatus("Examine the arch");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_arch_phase2)
	{
		jsSetQuestStatus("Deal with Esbenus");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_arch_phase1)
	{
		jsSetQuestStatus("Explore the site");
		jsAddQuestDesc(0);
	}
}

function Quest_ElixirMonastery()
{
	$js_quest_text[0] = "You discovered the location of a mountain monastery rumored to have a powerful elixir.";
	$js_quest_text[1] = "The monastery is under siege by raiders lured by the rumors and the promise of riches.";
	$js_quest_text[2] = "You've dealt with the raiders, saving the monastery from harm.";
	$js_quest_text[3] = "Find Daneus and get your fair share.";
	$js_quest_text[4] = "The monastery was pillaged. If the elixir exists, it was taken by the raiders.";
	$js_quest_text[5] = "You obtained the elixir.";
	$js_quest_text[6] = "You left the monastery empty-handed.";
	$js_quest_text[7] = "You told the healer that the elixir wasn't there.";
	$js_quest_text[8] = "You gave the elixir to the healer and gained a regeneration potion as your reward.";
	
	jsSetQuestName("The Elixir");

	if(aod.jnl_elixir == 8)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(8);
	}
	else if(aod.jnl_elixir == 7)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(7);
	}
	else if(aod.jnl_elixir == 6)
	{
		jsSetQuestStatus("Talk to the healer");
		jsAddQuestDesc(6);
	}
	else if(aod.jnl_elixir == 5)
	{
		jsSetQuestStatus("Talk to the healer");
		jsAddQuestDesc(5);
	}
	else if(aod.jnl_elixir == 4)
	{
		jsSetQuestStatus("Talk to the healer");
		jsAddQuestDesc(4);
	}
	else if(aod.jnl_elixir == 3)
	{
		jsSetQuestStatus("Talk to Daneus");
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_elixir == 2)
	{
		jsSetQuestStatus("Explore the monastery");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_elixir == 1)
	{
		jsSetQuestStatus("Deal with the raiders");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_elixir == 0)
	{
		jsSetQuestStatus("Obtain the elixir");
		jsAddQuestDesc(0);
	}
}

function Quest_DivineSpear()
{
	$js_quest_text[0] = "Bennie is seeking the Divine Spear. If you agree to find it for him, he will help you get past the constructs.";
	$js_quest_text[1] = "Find that spear for Bennie to fulfil your part of the bargain.";
	$js_quest_text[2] = "You found the 'spear'.";
	$js_quest_text[3] = "You gave the Divine Spear to Bennie, as promised. Hopefully, you'll be far away when he smites his enemies with it.";
	
	jsSetQuestName("The Divine Spear");
	
	if(aod.npc_bennie_spear)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
	}
	else if(dlgOwnsItem(2230))
	{
		jsSetQuestStatus("Talk to Bennie");
		jsAddQuestDesc(2);
	}
	else if(aod.npc_bennie_deal)
	{
		jsSetQuestStatus("Find the spear");
		jsAddQuestDesc(1);
	}
	else
	{
		jsSetQuestStatus("Talk to Bennie");
		jsAddQuestDesc(0);
	}
}

// HA Questline

function Quest_HA1()
{
	$js_quest_text[0] = "Investigate an old tomb on the road to Ganezzar. It may be Darius' final resting place.";
	$js_quest_text[1] = "You found a secret door. Now find a way to open it.";
	$js_quest_text[2] = "You found the hidden chamber!";
	$js_quest_text[3] = "The Helm of Destiny is yours.";
	$js_quest_text[4] = "You gave the helmet to Gaelius. He was suitably impressed with your 'getting things done' attitude.";
	$js_quest_text[5] = "You told Gaelius that if the helmet is there, it's buried under a ton of rock and sand.";
	
	jsSetQuestName("The Helm of Destiny");
	
	aod.jnl_HA1_phase1 = true;
	
	if(aod.jnl_HA1_phase6)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(5);
	}
	else if(aod.jnl_HA1_phase5)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
	}
	else if(aod.jnl_HA1_phase4)
	{
		jsSetQuestStatus("Take the helmet to Gaelius");
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_HA1_phase3)
	{
		jsSetQuestStatus("Recover the Helm of Destiny");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_HA1_phase2)
	{
		jsSetQuestStatus("Find a way to open the door");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_HA1_phase1)
	{
		jsSetQuestStatus("Find Darius' Tomb");
		jsAddQuestDesc(0);
	}
}

function Quest_HA2()
{
	$js_quest_text[0] = "Travel to Harran's pass in the northern mountains and then to the plains beyond the pass.";
	$js_quest_text[1] = "The Ordu are divided by inner squabbles. See if you can speed things up a bit.";
	$js_quest_text[2] = "You are stuck at the pass, with the imperial guards reinforcements coming. Find a way to get through them.";
	$js_quest_text[3] = "The Ordu won't go to Maadoran after all. Oh well...";
	$js_quest_text[4] = "The Ordu were slaughtered at the pass. Fortunately, Carbo let you live to deliver a message, so the trip wasn't a total loss.";
	$js_quest_text[5] = "You managed to bring the Ordu to Maadoran. There'd better be some rejoicing.";
	
	jsSetQuestName("Fetching an Army");

	aod.jnl_HA2_phase1 = true;

	if(aod.jnl_HA2_phase6)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(5);
	}
	else if(aod.jnl_HA2_phase5)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
	}
	else if(aod.jnl_HA2_phase4)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_HA2_phase3)
	{
		jsSetQuestStatus("Guide the Ordu to Maadoran");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_HA2_phase2)
	{
		jsSetQuestStatus("Guide the Ordu to Maadoran");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_HA2_phase1)
	{
		jsSetQuestStatus("Travel to Harran's Pass");
		jsAddQuestDesc(0);
	}
}

function Quest_HA_ArriveGNZ()
{
	$js_quest_text[0] = "Ganezzar is under siege. Travel there and assess the situation.";
	$js_quest_text[1] = "Enter Ganezzar and make your introductions to lord Meru.";
	$js_quest_text[2] = "Meru told you about Al-Akia, the birthplace of the Gods.";
	
	jsSetQuestName("Ganezzar");

	if(aod.jnl_HA_ArriveGNZ == 3)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
	}
	else if(aod.global_beenToGanezzar)
	{
		jsSetQuestStatus("Talk to Meru");
		jsAddQuestDesc(1);
	}
	else
	{
		jsSetQuestStatus("Travel to Ganezzar");
		jsAddQuestDesc(0);
	}
}

function Quest_HA_GNZ()
{
	$js_quest_text[0] = "Report your findings to lord Gaelius.";
	$js_quest_text[1] = "Travel to Caer-Tor to secure Dux Paullus' help.";
	$js_quest_text[2] = "Dux Paullus has rejected your offer. You failed your mission.";
	$js_quest_text[3] = "You made a deal with Dux Paullus.";
	$js_quest_text[4] = "You killed Meru in Al-Akia, ending the siege.";
	
	jsSetQuestName("Taking Ganezzar");

	if(aod.ending_gnz_MeruDiesAlAkia)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
	}
	else if(aod.jnl_HA_GNZ == 3)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_HA_GNZ == 2)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_HA_GNZ == 1)
	{
		jsSetQuestStatus("Talk to Paullus");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_HA_GNZ == 0)
	{
		jsSetQuestStatus("Return to Gaelius");
		jsAddQuestDesc(0);
	}
}

// HC Al-Akia Questline

function quest_HC_AlAkia()
{
	$js_quest_text[0] = "Meru offered you to join his House and serve the Gods.";
	$js_quest_text[1] = "You've agreed to accompany Meru to Al-Akia. Talk to him when you're ready to leave.";
	$js_quest_text[2] = "Find the main chamber.";
	$js_quest_text[3] = "Fortunately or unfortunately, Meru died during the ritual.";
	$js_quest_text[4] = "You killed Balzaar's new host - the lord of House Crassus.";
	$js_quest_text[5] = "Meru is dead and House Crassus is no more.";
	$js_quest_text[6] = "Congratulations, you're Balzaar's new first acolyte.";
	
	jsSetQuestName("The Birthplace of the Gods");

	if(aod.jnl_HC_AlAkia == 6)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(6);
	}
	else if(aod.jnl_HC_AlAkia == 5)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(5);
	}
	else if(aod.jnl_HC_AlAkia == 4)
	{
		jsSetQuestStatus("Leave Al-Akia");
		jsAddQuestDesc(4);
	}
	else if(aod.jnl_HC_AlAkia == 3)
	{
		jsSetQuestStatus("Leave Al-Akia");
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_HC_AlAkia == 2)
	{
		jsSetQuestStatus("Explore Al-Akia");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_HC_AlAkia == 1)
	{
		jsSetQuestStatus("Talk to Meru");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_HC_AlAkia == 0)
	{
		jsSetQuestStatus("Talk to Meru");
		jsAddQuestDesc(0);
	}
}

function Quest_MS_AlAkia()
{
	$js_quest_text[0] = "Lord Meru asked you to join the expedition to Al-Akia. Report to him when you're ready to leave.";
	$js_quest_text[1] = "Wait for the Legatus to return. Talk to the loremasters in the meantime.";
	$js_quest_text[2] = "You ran away during an attack, leaving the rest of the expedition to die. Return to Ganezzar and report to Meru.";
	$js_quest_text[3] = "You convinced the Aurelian soldiers to leave the ruins alone. Return to Ganezzar and report to Meru.";
	$js_quest_text[4] = "You and the Imperial Guards managed to repel an attack and secured the ruins. Return to Ganezzar and report to Meru.";
	$js_quest_text[5] = "The underground complex is intact.";
	
	jsSetQuestName("The Birthplace of the Gods");

	if(aod.jnl_MS_AlAkia == 5)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(5);
	}
	else if(aod.jnl_MS_AlAkia == 4)
	{
		jsSetQuestStatus("Report to Meru");
		jsAddQuestDesc(4);
	}
	else if(aod.jnl_MS_AlAkia == 3)
	{
		jsSetQuestStatus("Report to Meru");
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_MS_AlAkia == 2)
	{
		jsSetQuestStatus("Report to Meru");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_MS_AlAkia == 1)
	{
		jsSetQuestStatus("Talk to the loremasters");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_MS_AlAkia == 0)
	{
		jsSetQuestStatus("Talk to Meru");
		jsAddQuestDesc(0);
	}
}

// AG GNZ Questline

function Quest_AG_ArriveGNZ()
{
	$js_quest_text[0] = "Report to Legatus Hagnon upon arrival to Ganezzar.";
	$js_quest_text[1] = "Visit the Boatmen's Guild.";
	$js_quest_text[2] = "Pay Varro, the former guildmaster, a visit. You'll find him in the Castle.";
	$js_quest_text[3] = "Welcome to Ganezzar, Inquisitor.";
	
	jsSetQuestName("Ganezzar");

	if(aod.jnl_AG_ArriveGNZ == 3)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_AG_ArriveGNZ == 2)
	{
		jsSetQuestStatus("Talk to Varro");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_AG_ArriveGNZ == 1)
	{
		jsSetQuestStatus("Find the guildhouse");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_AG_ArriveGNZ == 0)
	{
		jsSetQuestStatus("Travel to Ganezzar");
		jsAddQuestDesc(0);
	}
}

function Quest_AG_GNZ1()
{
	$js_quest_text[0] = "Varro asked you to kill Legatus Hagnon to demoralize the Aurelian forces. Talk to Varro when you're ready to go.";
	$js_quest_text[1] = "Get out of the tent. Now!";
	$js_quest_text[2] = "You killed Legatus Hagnon and his bodyguards in his own tent.";
	
	jsSetQuestName("Those that Come with a Sword");

	if(aod.jnl_AG_GNZ1 == 2)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_AG_GNZ1 == 1)
	{
		jsSetQuestStatus("Return to Ganezzar");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_AG_GNZ1 == 0)
	{
		jsSetQuestStatus("Talk to Varro");
		jsAddQuestDesc(0);
	}
}

function Quest_AG_GNZ2()
{
	$js_quest_text[0] = "Talk to Varro for your next assignment.";
	$js_quest_text[1] = "It's time to take Faelan out. Talk to Varro when you're ready.";
	$js_quest_text[2] = "Faelan's dead. Report to Varro in the morning.";
	$js_quest_text[3] = "You killed Faelan, strengthening Varro's position.";
	
	jsSetQuestName("Don't Suffer a Witch to Live");

	if(aod.jnl_AG_GNZ2 == 3)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_AG_GNZ2 == 2)
	{
		jsSetQuestStatus("Report to Varro");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_AG_GNZ2 == 1)
	{
		jsSetQuestStatus("Kill Faelan the Thrice Blessed");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_AG_GNZ2 == 0)
	{
		jsSetQuestStatus("Talk to Varro");
		jsAddQuestDesc(0);
	}
}

function Quest_AG_GNZ3()
{
	$js_quest_text[0] = "Investigate the Boatmen's Guild.";
	$js_quest_text[1] = "Hamza and his men are dead. Return to Varro.";
	$js_quest_text[2] = "Meru's dead. It's over.";	
	$js_quest_text[3] = "You killed Hamza and his men, securing House Crassus.";
	$js_quest_text[4] = "You joined Hamza and helped him kill Meru and Varro.";
	
	jsSetQuestName("It Ain't the Roads We Take...");

	if(aod.jnl_AG9 == 4)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
	}
	else if(aod.jnl_AG9 == 3)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_AG9 == 2)
	{
		jsSetQuestStatus("Leave the castle");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_AG9 == 1)
	{
		jsSetQuestStatus("Report to Varro");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_AG9 == 0)
	{
		jsSetQuestStatus("Kill the assassins");
		jsAddQuestDesc(0);
	}
}

function Quest_AG_Varro_Temple()
{
	$js_quest_text[0] = "You killed Hamza. Talk to Varro.";
	$js_quest_text[1] = "Meru wants a word. Don't keep him waiting.";
	$js_quest_text[2] = "Varro asked you to find the temple of Thor-Agoth for Meru.";
	$js_quest_text[3] = "You found the temple of Thor-Agoth for Meru.";
	
	jsSetQuestName("The Temple of Thor-Agoth");
	
	if(aod.jnl_AG_Varro_Temple == 3)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_AG_Varro_Temple == 2)
	{
		jsSetQuestStatus("Find the temple");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_AG_Varro_Temple == 1)
	{
		jsSetQuestStatus("Talk to Meru");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_AG_Varro_Temple == 0)
	{
		jsSetQuestStatus("Talk to Varro");
		jsAddQuestDesc(0);
	}
}

function Quest_AG_Darista_Temple()
{
	$js_quest_text[0] = "Talk to Darista about your next task.";
	$js_quest_text[1] = "Darista asked you to find the temple of Thor-Agoth.";
	$js_quest_text[2] = "You found the temple of Thor-Agoth for Darista.";
	
	jsSetQuestName("The Temple of Thor-Agoth");
	
	if(aod.jnl_TG_Darista_Temple == 2)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_TG_Darista_Temple == 1)
	{
		jsSetQuestStatus("Find the temple");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_TG_Darista_Temple == 0)
	{
		jsSetQuestStatus("Talk to Darista");
		jsAddQuestDesc(0);
	}
}

// MG GNZ Questline

function Quest_MG_ArriveGNZ()
{
	$js_quest_text[0] = "Strabos sent you to Ganezzar to discuss master Athanasius' concerns.";
	$js_quest_text[1] = "Strabos kicked you out. Perhaps you'll have better luck in Ganezzar.";
	$js_quest_text[2] = "Talk to Athanasius, the guildmaster of the local chapter. You can find him in the Temple district.";
	$js_quest_text[3] = "Welcome to Ganezzar, agent.";
	
	jsSetQuestName("Ganezzar");

	if(aod.jnl_MG_ArriveGNZ == 4)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_MG_ArriveGNZ == 3)
	{
		jsSetQuestStatus("Talk to Athanasius");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_MG_ArriveGNZ == 2)
	{
		jsSetQuestStatus("Travel to Ganezzar");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_MG_ArriveGNZ == 1)
	{
		jsSetQuestStatus("Travel to Ganezzar");
		jsAddQuestDesc(0);
	}
}

function Quest_MG_GNZ1()
{
	$js_quest_text[0] = "Talk to Meru and gain his trust. You might want to increase your reputation with House Crassus before seeking an audience.";
	$js_quest_text[1] = "You failed to impress Meru. Return to Athanasius.";
	$js_quest_text[2] = "Athanasius wants you to perform a few miracles. Let him know when you're ready.";
	$js_quest_text[3] = "Your miracle working left much to be desired and failed to impress Meru. Return to Athanasius.";
	$js_quest_text[4] = "Your miracle working impressed the locals but failed to make a lasting impression on Meru. Return to Athanasius.";
	$js_quest_text[5] = "Your miracle working left much to be desired but you managed to make a good impression on Meru. Return to Athanasius.";
	$js_quest_text[6] = "Your miracle working impressed the locals and made a good impression on Meru. Return to Athanasius.";
	$js_quest_text[7] = "You refused to take Meru's test and be judged by the Gods. Meru was disappointed but he still asked you to join an expedition to Al-Akia.";
	$js_quest_text[8] = "You passed the final test, proving once and for all that you're the Chosen one, blessed and beloved by the Gods.";
	$js_quest_text[9] = "Disappointed by your failures, Athanasius doesn't require your services anymore. It's a polite way of saying you're fired.";
	
	jsSetQuestName("Miracle Worker");

	if(aod.jnl_MG_GNZ1 == 10)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(9);
	}
	else if(aod.jnl_MG_GNZ1 == 9)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(8);
	}
	else if(aod.jnl_MG_GNZ1 == 8)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(7);
	}
	else if(aod.jnl_MG_GNZ1 == 7)
	{
		jsSetQuestStatus("Explore the star chamber");
		jsAddQuestDesc(6);
	}
	else if(aod.jnl_MG_GNZ1 == 6)
	{
		jsSetQuestStatus("Explore the star chamber");
		jsAddQuestDesc(5);
	}
	else if(aod.jnl_MG_GNZ1 == 5)
	{
		jsSetQuestStatus("Talk to Athanasius");
		jsAddQuestDesc(4);
	}
	else if(aod.jnl_MG_GNZ1 == 4)
	{
		jsSetQuestStatus("Talk to Athanasius");
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_MG_GNZ1 == 3)
	{
		jsSetQuestStatus("Heal the sick and the wretched");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_MG_GNZ1 == 2)
	{
		jsSetQuestStatus("Talk to Athanasius");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_MG_GNZ1 == 1)
	{
		jsSetQuestStatus("Talk to Meru");
		jsAddQuestDesc(0);
	}
}

function Quest_MG_GNZ2()
{
	$js_quest_text[0] = "Lord Meru asked you to join the expedition to Al-Akia. Report to him when you're ready to leave.";
	$js_quest_text[1] = "Wait for the Legatus to return. Talk to the loremasters in the meantime.";
	$js_quest_text[2] = "You ran away during an attack, leaving the rest of the expedition to die. Return to Ganezzar and report to Meru.";
	$js_quest_text[3] = "You convinced the Aurelian soldiers to leave the ruins alone. Return to Ganezzar and report to Meru.";
	$js_quest_text[4] = "You and the Imperial Guards managed to repel an attack and secured the ruins. Return to Ganezzar and report to Meru.";
	$js_quest_text[5] = "The underground complex is intact but Ganezzar has been besieged.";
	
	jsSetQuestName("The Birthplace of the Gods");

	if(aod.jnl_MG_GNZ2 == 5)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(5);
	}
	else if(aod.jnl_MG_GNZ2 == 4)
	{
		jsSetQuestStatus("Report to Meru");
		jsAddQuestDesc(4);
	}
	else if(aod.jnl_MG_GNZ2 == 3)
	{
		jsSetQuestStatus("Report to Meru");
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_MG_GNZ2 == 2)
	{
		jsSetQuestStatus("Report to Meru");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_MG_GNZ2 == 1)
	{
		jsSetQuestStatus("Talk to the loremasters");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_MG_GNZ2 == 0)
	{
		jsSetQuestStatus("Talk to Meru");
		jsAddQuestDesc(0);
	}
}

function Quest_MG_GNZ3()
{
	$js_quest_text[0] = "Meru asked you to convince Dux Paullus to break the siege.";
	$js_quest_text[1] = "Meru asked you to convince Dux Paullus to break the siege. Maseus informed you that Strabos ordered you to convince Paullus to side with House Aurelian.";
	$js_quest_text[2] = "You failed to convince Paullus to join the fight.";
	$js_quest_text[3] = "The siege has been broken.";
	$js_quest_text[4] = "Ganezzar has fallen.";
	
	jsSetQuestName("Breaking the Siege");

	if(aod.jnl_MG_GNZ3 == 4)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
	}
	else if(aod.jnl_MG_GNZ3 == 3)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_MG_GNZ3 == 2)
	{
		jsSetQuestStatus("Find another way to break the siege");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_MG_GNZ3 == 1)
	{
		jsSetQuestStatus("Talk to Paullus");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_MG_GNZ3 == 0)
	{
		jsSetQuestStatus("Travel to Caer-Tor");
		jsAddQuestDesc(0);
	}
}

function Quest_MG_GNZ3_Teron()
{
	$js_quest_text[0] = "Talk to Antidas about breaking the siege.";
	$js_quest_text[1] = "Antidas refused to aid Meru. Convince Linos to give you the Sellsword Legion.";
	$js_quest_text[2] = "Linos will cover the expenses if you convince Mercato to break the siege.";
	$js_quest_text[3] = "Linos will cover the expenses if you convince Brandir to break the siege.";
	$js_quest_text[4] = "You failed to find any allies in Teron.";
	
	jsSetQuestName("Breaking the Siege");

	if(aod.jnl_MG_GNZ3_Teron == 4)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
	}
	else if(aod.jnl_MG_GNZ3_Teron == 3)
	{
		jsSetQuestStatus("Talk to Brandir");
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_MG_GNZ3_Teron == 2)
	{
		jsSetQuestStatus("Talk to Mercato");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_MG_GNZ3_Teron == 1)
	{
		jsSetQuestStatus("Talk to Linos");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_MG_GNZ3_Teron == 0)
	{
		jsSetQuestStatus("Talk to Antidas");
		jsAddQuestDesc(0);
	}
}

function Quest_MG_Kill_Faelan()
{
	$js_quest_text[0] = "Athanasius wants Faelan killed. Talk to Varro about it.";
	$js_quest_text[1] = "Varro agreed to kill Faelan when the right opportunity comes along.";
	$js_quest_text[2] = "Varro refused to kill Faelan. If you really want Faelan gone, you'll have to do it yourself.";
	$js_quest_text[3] = "You killed Faelan. Let Athanasius know.";
	$js_quest_text[4] = "Faelan is dead.";
	$js_quest_text[5] = "Varro promised to kill Faelan when the time is right.";
	
	jsSetQuestName("Don't Suffer a Witch to Live");
	
	if(aod.quest_mg_killFaelan == 8)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
	}
	else if(aod.quest_mg_killFaelan == 6)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(5);
	}
	else if(aod.npc_faelan_dead && aod.quest_mg_killFaelan == 5)
	{
		jsSetQuestStatus("Talk to Athanasius");
		jsAddQuestDesc(3);
	}
	else if(aod.quest_mg_killFaelan == 5)
	{
		jsSetQuestStatus("Talk to Athanasius");
		jsAddQuestDesc(2);
	}
	else if(aod.quest_mg_killFaelan == 3)
	{
		jsSetQuestStatus("Talk to Athanasius");
		jsAddQuestDesc(2);
	}
	else if(aod.quest_mg_killFaelan == 4)
	{
		jsSetQuestStatus("Talk to Athanasius");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_MG_killFaelan == 0)
	{
		jsSetQuestStatus("Talk to Varro");
		jsAddQuestDesc(0);
	}
}

function Quest_MG_Athan_Temple()
{
	$js_quest_text[0] = "Talk to Athanasius about your next assignment.";
	$js_quest_text[1] = "Athanasius asked you to find the temple of Thor-Agoth for Meru.";
	$js_quest_text[2] = "You found the temple of Thor-Agoth for Meru.";
	
	jsSetQuestName("The Temple of Thor-Agoth");
	
	if(aod.jnl_MG_Athan_Temple == 2)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_MG_Athan_Temple == 1)
	{
		jsSetQuestStatus("Find the temple");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_MG_Athan_Temple == 0)
	{
		jsSetQuestStatus("Talk to Athanasius");
		jsAddQuestDesc(0);
	}
}

function Quest_MG_Strabos_Temple()
{
	$js_quest_text[0] = "Talk to Strabos about your next assignment.";
	$js_quest_text[1] = "Strabos asked you to find the temple of Thor-Agoth.";
	$js_quest_text[2] = "You found the temple of Thor-Agoth for Strabos.";
	
	jsSetQuestName("The Temple of Thor-Agoth");
	
	if(aod.jnl_MG_Strabos_Temple == 2)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_MG_Strabos_Temple == 1)
	{
		jsSetQuestStatus("Find the temple");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_MG_Strabos_Temple == 0)
	{
		jsSetQuestStatus("Talk to Strabos");
		jsAddQuestDesc(0);
	}
}

// HD GNZ Questline

function Quest_HD_ArriveGNZ()
{
	$js_quest_text[0] = "House Aurelian has fallen and you're no longer welcome in Maadoran. It's time to visit Ganezzar.";
	$js_quest_text[1] = "Lord Serenas the Victorius rules Maadoran now. It's time to visit Ganezzar.";
	$js_quest_text[2] = "You saved Gaelius' life in Maadoran, but remained loyal to House Daratan. It's time to visit Ganezzar.";
	$js_quest_text[3] = "Talk to Meru. You can find him at the castle overlooking the city.";
	$js_quest_text[4] = "Meru told you about Al-Akia, the birthplace of the Gods.";
	
	jsSetQuestName("Ganezzar");

	if(aod.jnl_HD_ArriveGNZ == 3)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
	}
	else if(aod.global_beenToGanezzar)
	{
		jsSetQuestStatus("Talk to Meru");
		jsAddQuestDesc(3);
	}

	else if(aod.jnl_HD_ArriveGNZ == 2)
	{
		jsSetQuestStatus("Travel to Ganezzar");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_HD_ArriveGNZ == 1)
	{
		jsSetQuestStatus("Travel to Ganezzar");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_HD_ArriveGNZ == 0)
	{
		jsSetQuestStatus("Travel to Ganezzar");
		jsAddQuestDesc(0);
	}
}

function Quest_MDN_HA_Destroyed_GNZ()
{
	$js_quest_text[0] = "Talk to Lord Meru and tell him what happened in Maadoran.";
	// $js_quest_text[1] = "Seek an ancient Oracle and find the location of Al-Akia.";
	// $js_quest_text[2] = "The good news is that you've discovered the location of Al-Akia. The bad news is that you've discovered a lot more than that.";
	$js_quest_text[3] = "Meru was pleased to hear that Maadoran was laid to waste for offending the Gods.";
	
	jsSetQuestName("Ganezzar");

	if(aod.jnl_MDN_HA_Destroyed_GNZ == 1)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
	}
	else
	{
		jsSetQuestStatus("Talk to Meru");
		jsAddQuestDesc(0);
	}
}

function Quest_AlAkia_Generic()
{
	$js_quest_text[0] = "Report to Meru when you're ready to join the expedition.";
	$js_quest_text[1] = "Explore the complex.";
	$js_quest_text[2] = "You explored the ruins of Al-Akia. The machines are intact.";
	
	jsSetQuestName("The Birthplace of the Gods");

	aod.jnl_AlAkia_Generic = 1;

	if(aod.jnl_AlAkia_Generic == 3)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_AlAkia_Generic == 2)
	{
		jsSetQuestStatus("Return to Ganezzar");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_AlAkia_Generic == 1)
	{
		jsSetQuestStatus("Talk to Meru");
		jsAddQuestDesc(0);
	}
}

function quest_HD_GNZ_Siege()
{
	$js_quest_text[0] = "Ganezzar is under siege, which presents you with different opportunities. Either talk to Antidas about joining the fight or accept Meru's offer to join his House and serve the Gods.";
	$js_quest_text[1] = "You convinced Antidas to make an alliance with House Aurelian.";
	$js_quest_text[2] = "You failed to convince Antidas to get involved. You can still accept Meru's offer or focus on finding the temple.";
	
	jsSetQuestName("The Enemy of My Enemy");
	
	if(aod.jnl_HD_gnz_siege == 2)
	{
		jsSetQuestStatus("Talk to Meru or find the temple");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_HD_gnz_siege == 1)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_HD_gnz_siege == 0)
	{
		jsSetQuestStatus("Talk to Meru or Antidas");
		jsAddQuestDesc(0);
	}
}

function Quest_AlAkia_HD()
{
	$js_quest_text[0] = "Meru invited you to accompany his men to Al-Akia. Let him know when you're ready to leave.";
	$js_quest_text[1] = "Wait for the Legatus to return. Talk to the loremasters in the meantime.";
	$js_quest_text[2] = "You've dealt with Aurelian soldiers. Return to Ganezzar.";
	$js_quest_text[3] = "You've informed Meru that the Al-Akia's machines are intact.";
	
	jsSetQuestName("The Birthplace of the Gods");

	if(aod.jnl_AlAkia_HD == 0)
		aod.jnl_AlAkia_HD = 1;

	if(aod.jnl_AlAkia_HD == 4)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_AlAkia_HD == 3)
	{
		jsSetQuestStatus("Return to Ganezzar and talk to Meru");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_AlAkia_HD == 2)
	{
		jsSetQuestStatus("Talk to the loremasters");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_AlAkia_HD == 1)
	{
		jsSetQuestStatus("Talk to Meru");
		jsAddQuestDesc(0);
	}
}

function quest_HD_AlAkiaFate()
{
	$js_quest_text[0] = "Meru offered you to join his House and accompany him to Al-Akia. You can go there to see what's all the fuss is about or return to Antidas.";
	// Antidas' Path
	$js_quest_text[1] = "You convinced Antidas to destroy the ruins of Al-Akia. Talk to him when you're ready to leave.";
	$js_quest_text[2] = "House Crassus' soldiers control the ruins. Deal with them.";
	$js_quest_text[3] = "The Crassus' soldiers have been dealt with. Approach the tower and set the explosives.";
	$js_quest_text[4] = "You destroyed Al-Akia.";
	// Meru's Path
	$js_quest_text[5] = "You agreed to travel to Al-Akia. Talk to Meru when you're ready to leave.";
	$js_quest_text[6] = "Find the main chamber.";
	$js_quest_text[7] = "Meru's dead. Report the news to Antidas.";
	$js_quest_text[8] = "You killed Balzaar's new host - the former First Acolyte. Report the news to Antidas.";
	$js_quest_text[9] = "Antidas was pleased to hear that his old enemy is no more.";
	$js_quest_text[10] = "You're now an acolyte of Balzaar. Congratulations.";
	
	jsSetQuestName("The Birthplace of the Gods");

	if(aod.jnl_HD_AlAkiaFate == 0)
		aod.jnl_HD_AlAkiaFate = 1;

	if(aod.jnl_HD_AlAkiaFate == 11)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(10);
	}
	else if(aod.jnl_HD_AlAkiaFate == 10)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(9);
	}
	else if(aod.jnl_HD_AlAkiaFate == 9)
	{
		jsSetQuestStatus("Leave Al-Akia");
		jsAddQuestDesc(8);
	}
	else if(aod.jnl_HD_AlAkiaFate == 8)
	{
		jsSetQuestStatus("Leave Al-Akia");
		jsAddQuestDesc(7);
	}
	else if(aod.jnl_HD_AlAkiaFate == 7)
	{
		jsSetQuestStatus("Explore Al-Akia");
		jsAddQuestDesc(6);
	}
	else if(aod.jnl_HD_AlAkiaFate == 6)
	{
		jsSetQuestStatus("Talk to Meru");
		jsAddQuestDesc(5);
	}
	else if(aod.jnl_HD_AlAkiaFate == 5)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
	}
	else if(aod.jnl_HD_AlAkiaFate == 4)
	{
		jsSetQuestStatus("Blow up Al-Akia");
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_HD_AlAkiaFate == 3)
	{
		jsSetQuestStatus("Deal with the Crassus' soldiers");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_HD_AlAkiaFate == 2)
	{
		jsSetQuestStatus("Talk to Antidas");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_HD_AlAkiaFate == 1)
	{
		jsSetQuestStatus("Talk to Meru or Antidas");
		jsAddQuestDesc(0);
	}
}

function Quest_Antidas_Temple()
{
	$js_quest_text[0] = "Talk to Antidas about your next task.";
	$js_quest_text[1] = "Antidas asked you to find the temple of Thor-Agoth.";
	$js_quest_text[2] = "You found the temple of Thor-Agoth for Antidas.";
	
	jsSetQuestName("The Temple of Thor-Agoth");
	
	if(aod.jnl_Antidas_Temple == 2)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_Antidas_Temple == 1)
	{
		jsSetQuestStatus("Find the temple");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_Antidas_Temple == 0)
	{
		jsSetQuestStatus("Talk to Antidas");
		jsAddQuestDesc(0);
	}
}

// HC GNZ Questline

function Quest_AlAkia_Meru()
{
	$js_quest_text[0] = "Report to Meru when you're ready to accompany him to Al-Akia.";
	$js_quest_text[1] = "Find the sacred chamber.";
	$js_quest_text[2] = "An ancient ritual took place in Al-Akia."; // {TEMP}
	
	jsSetQuestName("Kingdom of the Gods");

	if(aod.jnl_AlAkia_Meru == 2)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_AlAkia_Meru == 1)
	{
		jsSetQuestStatus("Find the sacred chamber");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_AlAkia_Meru == 0)
	{
		jsSetQuestStatus("Talk to Meru");
		jsAddQuestDesc(0);
	}
}

function Quest_Meru_Temple()
{
	$js_quest_text[0] = "Meru asked you to find the temple of Thor-Agoth.";
	$js_quest_text[1] = "You found the temple of Thor-Agoth for Meru.";
	
	jsSetQuestName("The Temple of Thor-Agoth");
	
	if(aod.jnl_Meru_Temple == 1)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(1);
	}
	else
	{
		jsSetQuestStatus("Find the temple");
		jsAddQuestDesc(0);
	}
}

// GNZ Misc Quests

function Quest_GNZ_Elias()
{
	$js_quest_text[0] = "Some zealots are looking for a man named Elias. Something to keep in mind.";
	
	jsSetQuestName("The Crossroads");

	jsSetQuestStatus("Find Elias");
	jsAddQuestDesc(0);
}

function Quest_GNZ_Hector_01()
{
	$js_quest_text[0] = "Talk to Hector, a man of certain influence in Lowtown.";
	$js_quest_text[1] = "Berengarius has a store in the Temple district. Pay him a visit.";
	$js_quest_text[2] = "Your job here is done, return to Hector.";
	$js_quest_text[3] = "You've successfully extorted money from Berengarius.";
	
	jsSetQuestName("Power to the People");

	if(aod.jnl_GNZ_Hector_01 == 3)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_GNZ_Hector_01 == 2)
	{
		jsSetQuestStatus("Talk to Hector");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_GNZ_Hector_01 == 1)
	{
		jsSetQuestStatus("Talk to Berengarius");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_GNZ_Hector_01 == 0)
	{
		jsSetQuestStatus("Talk to Hector");
		jsAddQuestDesc(0);
	}
}

function Quest_GNZ_Hector_02()
{
	$js_quest_text[0] = "Hector wants you to kill Darganus. Talk to him when you're ready.";
	$js_quest_text[1] = "Darganus is dead. Your job here is done, return to Hector.";
	$js_quest_text[2] = "You killed lord Darganus for Hector.";
	
	jsSetQuestName("Power to the People");

	if(aod.jnl_GNZ_Hector_02 == 2)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_GNZ_Hector_02 == 1)
	{
		jsSetQuestStatus("Talk to Hector");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_GNZ_Hector_02 == 0)
	{
		jsSetQuestStatus("Talk to Hector");
		jsAddQuestDesc(0);
	}
}

function Quest_GNZ_Hector_03()
{
	$js_quest_text[0] = "Talk to Hector. He might have more work for you.";
	$js_quest_text[1] = "Hector asked you to get rid of Miltiades. You can find him at the inn in the Temple district.";
	$js_quest_text[2] = "Miltiades is gone. Report to Hector."; 
	$js_quest_text[3] = "You got rid of Miltiades for Hector.";
	$js_quest_text[4] = "Miltiades killed Hector, forcing you to side with him.";
	$js_quest_text[5] = "Miltiades killed Hector, forcing you to fight the zealots. You did what you should have done a long time ago - killed Miltiades.";
	
	jsSetQuestName("Lord Miltiades");

	if(aod.jnl_GNZ_Hector_03 == 5)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(5);
	}
	else if(aod.jnl_GNZ_Hector_03 == 4)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
	}
	else if(aod.jnl_GNZ_Hector_03 == 3)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_GNZ_Hector_03 == 2)
	{
		jsSetQuestStatus("Talk to Hector");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_GNZ_Hector_03 == 1)
	{
		jsSetQuestStatus("Talk to Miltiades");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_GNZ_Hector_03 == 0)
	{
		jsSetQuestStatus("Talk to Hector");
		jsAddQuestDesc(0);
	}
}

function Quest_GNZ_Darganus_01()
{
	$js_quest_text[0] = "Talk to Lord Darganus in the Temple district";
	$js_quest_text[1] = "Berengarius has a store in the Temple district. Pay him a visit.";
	$js_quest_text[2] = "You killed the zealot. Report your success to Darganus.";
	$js_quest_text[3] = "You decided to spare the zealot girl. She sent you to Hector, a man of certain influence in Lowtown.";
	$js_quest_text[4] = "You stopped the zealots harassing local traders.";
	$js_quest_text[5] = "You decided to leave Berengarius to his fate after all.";
	
	jsSetQuestName("Noblesse Oblige");

	if(aod.jnl_GNZ_Darganus_01 == 5)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_GNZ_Darganus_01 == 4)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_GNZ_Darganus_01 == 3)
	{
		jsSetQuestStatus("Talk to Hector");
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_GNZ_Darganus_01 == 2)
	{
		jsSetQuestStatus("Talk to Darganus");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_GNZ_Darganus_01 == 1)
	{
		jsSetQuestStatus("Talk to Berengarius");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_GNZ_Darganus_01 == 0)
	{
		jsSetQuestStatus("Talk to Darganus");
		jsAddQuestDesc(0);
	}
}

function Quest_GNZ_Darganus_02()
{
	$js_quest_text[0] = "Visit Pancratius, a new Lowtown preacher. His house is near the gates.";
	$js_quest_text[1] = "You killed Pancratius and his followers. Return to Darganus.";
	$js_quest_text[2] = "You agreed to kill Hector in exchange for Pancratius' support.";
	$js_quest_text[3] = "Hector is dead. Let Pancratius know.";
	$js_quest_text[4] = "You reached an understanding with Pancratius. Let Darganus know you did what he asked.";
	$js_quest_text[5] = "You killed Pancratius and his followers.";
	$js_quest_text[6] = "You killed Hector and Pancratius took his place.";
	
	jsSetQuestName("Noblesse Oblige");

	if(aod.jnl_GNZ_Darganus_02 == 6)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(6);
	}
	else if(aod.jnl_GNZ_Darganus_02 == 5)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(5);
	}
	else if(aod.jnl_GNZ_Darganus_02 == 4)
	{
		jsSetQuestStatus("Talk to Darganus");
		jsAddQuestDesc(4);
	}
	else if(aod.jnl_GNZ_Darganus_02 == 3)
	{
		jsSetQuestStatus("Talk to Pancratius");
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_GNZ_Darganus_02 == 2)
	{
		jsSetQuestStatus("Kill Hector");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_GNZ_Darganus_02 == 1)
	{
		jsSetQuestStatus("Talk to Darganus");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_GNZ_Darganus_02 == 0)
	{
		jsSetQuestStatus("Talk to Pancratius");
		jsAddQuestDesc(0);
	}
}

function Quest_GNZ_Darganus_03()
{
	$js_quest_text[0] = "Talk to Darganus. He might have more work for you.";
	$js_quest_text[1] = "Miltiades wants you to incite the zealots into attacking the Temple district.";
	$js_quest_text[2] = "Miltiades wants you to incite the zealots into attacking the Temple district.";
	$js_quest_text[3] = "Miltiades\' plan backfired, forcing him to renounce his \'lordship\' to impress the zealots and move to Lowtown.";
	$js_quest_text[4] = "Miltiades\' gamble paid off. Darganus is dead and Miltiades is the new protector of all that is noble.";
	$js_quest_text[5] = "In the end you sided with Darganus, forcing Miltiades to seek refuge in Lowtown.";
	$js_quest_text[6] = "You failed to incite the zealots.";
	$js_quest_text[7] = "You warned Darganus of Miltiades' plot.";
	
	jsSetQuestName("Lord Miltiades");

	if(aod.jnl_GNZ_Darganus_03 == 7)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(7);
	}
	else if(aod.jnl_GNZ_Darganus_03 == 6)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(6);
	}
	else if(aod.jnl_GNZ_Darganus_03 == 5)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(5);
	}
	else if(aod.jnl_GNZ_Darganus_03 == 4)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(4);
	}
	else if(aod.jnl_GNZ_Darganus_03 == 3)
	{
		jsSetQuestComplete(true);
		jsAddQuestDesc(3);
	}
	else if(aod.jnl_GNZ_Darganus_03 == 2)
	{
		jsSetQuestStatus("Talk to Pancratius");
		jsAddQuestDesc(2);
	}
	else if(aod.jnl_GNZ_Darganus_03 == 1)
	{
		jsSetQuestStatus("Talk to Hector");
		jsAddQuestDesc(1);
	}
	else if(aod.jnl_GNZ_Darganus_03 == 0)
	{
		jsSetQuestStatus("Talk to Darganus");
		jsAddQuestDesc(0);
	}
}