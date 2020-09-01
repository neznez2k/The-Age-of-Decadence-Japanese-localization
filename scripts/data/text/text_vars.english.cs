//General:

//<pc_name>
//<charname>
//<nl> = new line

//to add a PC-gender-dependent text var, use:
//addGenderVar("<tag>", "male value", "female value");
clearGenderVars();

addGenderVar("<him/her>", "him", "her");
addGenderVar("<Him/Her>", "Him", "Her");
addGenderVar("<his/her>", "his", "her");
addGenderVar("<His/Her>", "His", "Her");
addGenderVar("<he/she>", "he", "she");
addGenderVar("<He/She>", "He", "She");
addGenderVar("<himself/herself>", "himself", "herself");
addGenderVar("<man/woman>", "man", "woman");
addGenderVar("<men/women>", "men", "women");
addGenderVar("<Men/Women>", "Men", "Women");
addGenderVar("<lord/lady>", "lord", "lady");
addGenderVar("<Lord/Lady>", "Lord", "Lady");
addGenderVar("<boy/girl>", "boy", "girl");
addGenderVar("<master/mistress>", "master", "mistress");
addGenderVar("<Master/Mistress>", "Master", "Mistress");
addGenderVar("<son a bitch/bitch>", "son a bitch", "bitch");
addGenderVar("<brother/sister>", "brother", "sister");
addGenderVar("<Brother/Sister>", "Brother", "Sister");
addGenderVar("<son/daughter>", "son", "daughter");
addGenderVar("<son/girl>", "son", "girl");
addGenderVar("<guy/gal>", "guy", "gal");
addGenderVar("<God/Goddess>", "God", "Goddess");


//日本語実装用
addGenderVar("<ore/watashi>", "俺", "私");
addGenderVar("<kare/kanozyo>", "彼", "彼女");
addGenderVar("<omae/anata>", "お前", "あなた");
addGenderVar("<da/yo>", "だ", "よ");
addGenderVar("<da/no>", "だ", "の");
addGenderVar("<ka/no>", "か", "の");
addGenderVar("<mu/no>", "", "の");
addGenderVar("</si>", "", "し");
addGenderVar("</su>", "", "す");
addGenderVar("</tu>", "", "っ");
addGenderVar("</yo>", "", "よ");
addGenderVar("<mu/wa>", "", "わ");
addGenderVar("</ki>", "", "き");
addGenderVar("</na>", "", "な");
addGenderVar("</ne>", "", "ね");
addGenderVar("</ri>", "", "り");
addGenderVar("</ru>", "", "る");
addGenderVar("</i>", "", "い");
addGenderVar("</te>", "", "て");

addGenderVar("<i/>", "い", "");
addGenderVar("<u/>", "う", "");
addGenderVar("<ka/mu>", "か", "");
addGenderVar("<ku/>", "く", "");
addGenderVar("<ko/>", "こ", "");
addGenderVar("<n/mu>", "ん", "");
addGenderVar("<o/>", "お", "");
addGenderVar("<su/>", "す", "");
addGenderVar("<si/>", "し", "");
addGenderVar("<se/>", "せ", "");
addGenderVar("<da/>", "だ", "");
addGenderVar("<yo/>", "よ", "");
addGenderVar("<ke/>", "け", "");
addGenderVar("<re/>", "れ", "");
addGenderVar("<na/>", "な", "");
addGenderVar("<zo/>", "ぞ", "");



addGenderVar("<kurunda/kinasai>", "くるんだ", "きなさい");
addGenderVar("<darou/desyou>", "だろう", "でしょう");
addGenderVar("<kure/tyoudai>", "くれ", "ちょうだい");
addGenderVar("<daga/demo>", "だが", "でも");
addGenderVar("<yatta/ageta>", "やった", "あげた");
addGenderVar("</masyou>", "", "ましょう");
addGenderVar("<ro/nasai>", "ろ", "なさい");
addGenderVar("</nasai>", "", "なさい");
addGenderVar("<dayona/none>", "だよな", "のね");
addGenderVar("<ga/kedo>", "が", "けど");
addGenderVar("<dana/ne>", "だな", "ね");
addGenderVar("<nda/no>", "んだ", "の");
addGenderVar("<ndana/none>", "んだな", "のね");
addGenderVar("<runa/naide>", "るな", "ないで");
addGenderVar("<aa/ee>", "ああ", "ええ");
addGenderVar("<gaii/>", "がいい", "");



//to add a conditional text var, use:
//addConditionalVar("<tag>", "condition", "if-true-value", "if-false-value");
//addConditionalVar("<test_tag>", "$a > $b", "if-true-value", "if-false-value");
clearConditionalVars();
addConditionalVar("<quest_mg2_mercato_help>", "dlgGetItemsCount(423) >= 1 && aod.quest_mg2_mercato_help && aod.quest_mg2_mercato_failure == false", "Mercato has offered to let you pass through the gate unquestioned if you can get your hands on the Imperial Guard armor. Once inside you\'re on your own, but new recruits shouldn\'t attract too much attention.", "");
addConditionalVar("<quest_mg2_cado_help>", "dlgGetItemsCount(423) >= 1 && aod.quest_mg2_cado_help && dlgGetItemsCount(2140) >= 1 && aod.quest_mg2_cado_failure == false", "Cado has provided you with an official Caer-Tor writ which should get you through the gate and give enough authority to keep the guards out of your way once you\'re inside.", "");
addConditionalVar("<nl_mercato_help>", "dlgGetItemsCount(423) >= 1 && aod.quest_mg2_mercato_help && aod.quest_mg2_mercato_failure == false", "", "");
addConditionalVar("<nl_cado_help>", "dlgGetItemsCount(423) >= 1 && aod.quest_mg2_cado_help && dlgGetItemsCount(2140) >= 1 && aod.quest_mg2_cado_failure == false", "", "");
addConditionalVar("<quest_mg2_forge>", "aod.quest_mg2_met_carrinas == false", "Also, you can try getting his signature in order to forge the proof.", "");
addConditionalVar("<quest_HD1_honorGain>", "aod.quest_hd1_wordGiven", "<just:center><color:ffe19b>*Word of Honor increased.*", "");
addConditionalVar("<quest_HD1_honorLost>", "aod.quest_hd1_wordGiven", "<just:center><color:ffe19b>*Word of Honor decreased.*", "");
addConditionalVar("<Gaelius/Serenas>", "aod.npc_gaelius_dead", "Serenas", "Gaelius");
addConditionalVar("<Feng/Cassius>", "aod.npc_feng_fledTeron", "Cassius", "Feng");
addConditionalVar("<healStatPrice>", "$statHealPrice == 150", 150, "<healStatPrice2>");
addConditionalVar("<healStatPrice2>", "$statHealPrice == 300", 300, "<healStatPrice3>");
addConditionalVar("<healStatPrice3>", "$statHealPrice == 450", 450, "<healStatPrice4>");
addConditionalVar("<healStatPrice4>", "$statHealPrice == 600", 600, "<healStatPrice5>");
addConditionalVar("<healStatPrice5>", "$statHealPrice == 750", 750, "<healStatPrice>");
addConditionalVar("<HitPointsHealPriceLow>", "aod.temp", $HitPointsHealPriceLow, $HitPointsHealPriceLow);
addConditionalVar("<HitPointsHealPriceMed>", "aod.temp", $HitPointsHealPriceMed, $HitPointsHealPriceMed);
addConditionalVar("<HitPointsHealPriceHigh>", "aod.temp", $HitPointsHealPriceHigh, $HitPointsHealPriceHigh);

//Endings Variables
//addConditionalVar("<ending_GNZ_faction_HA_3>", "aod.npc_antidas_dead", "", "");
addConditionalVar("<ending_temple_faction_Rep_IG_1>", "dlgGetRep(guards) >= 15", "Even though your rank is a result of political maneuvering rather than battlefield victories, your devotion to the Imperial Guards cannot be ignored, not when Paullus needs officers he can rely on. Paullus grants you command of an Aurelian legion when their Legatus dies during a 'training exercise'. You will make the most of this chance to prove yourself, all you can ask for these days.", "When the dust settles it becomes clear that Paullus has little use for an untested Legatus who owes his rank to political maneuvering rather than battlefield victories.<br><br>You're demoted to Centurion, given a hundred new recruits and sent to patrol the wasteland. Your losses in the first month are devastating. Between the Ordu, disease, and desertion, you are left with less than half your forces, but those that remain are tough as nails. If you can make it through the fire, the wasteland just might make a commander out of you yet.");
addConditionalVar("<ending_temple_faction_Rep_IG_2>", "dlgGetRep(guards) >= 15", "Though your rank reflects political maneuvering rather than battlefield victories, reliable officers are in short supply. Paullus makes you one of the first Adepti, a warrior-priest assigned to Raenas' legion. Each day before their daily drills you instruct the soldiers in a simplified version of the Creed, giving them a purpose beyond obedience and slaughter, and so binding them tightly to the Grand Magister.", "When the dust settles it becomes clear that Paullus has little use for an untested Legatus who owes his rank to political maneuvering rather than battlefield victories.<br><br>You're demoted to Centurion and given a hundred newly recruited zealots and an inexperienced Adeptus. Your life's work now is to harass unbelievers and turn fidgety zealots into disciplined fighting men. The Adeptus's job is to bind your men closer to the Grand Magister of their new Order, though to you he is most useful as an added barrier between a knife and your back. Unfortunately, you doubt he will survive the week, and then it will just be you and the zealots.");
addConditionalVar("<ending_temple_faction_Rep_AG_1>", "dlgGetRep(assassins) >= 15", "Officially, your position is that of Quaestor, reporting to the Magistratus of Ganezzar. In reality, you're head of the local branch of the Boatmen, tasked with preventing the spread of Meru's faith and rooting out and eliminating zealots. The first week was the hardest, but your men worked day and night to prod the preachers, their more violent adherents, and a few dozen noble sympathizers on their way out of the city. Some chose the road to the desert, others the road from which there is no return. The Creed yet persists in a few silent quarters - the Empire wasn't leveled overnight after all - but you've only just gotten started.", "Even though Hamza would have failed without you, your moment of hesitation was never forgotten. Still, Hamza vouched for you and it was decided you're too valuable a field agent to retire, so you get to keep your job. Whenever you feel bitter, remind yourself of the alternative: sharing a shallow trench and two sacks of quicklime with a few other inconvenient enemies of the guild.");
addConditionalVar("<ending_temple_faction_Rep_TG_1>", "aod.ending_GNZ_faction_TG == 1", "Siding with Glabrio doesn't work out the way you had planned. After fucking it up with the zealots, Glabrio is forced to retreat to the only safe place, the tunnels. You have no choice but to follow him into a dark, damp exile. With Levir's contract on your head, you're pinned like a rat, forced to listen to Glabrio casting blame, hour after hour, in every direction but one. Maybe in a few months it will be safe to creep through the city, gather whatever supplies you can carry on your back and escape to the wasteland. If you're lucky.", "<ending_temple_faction_Rep_TG_2>");
addConditionalVar("<ending_temple_faction_Rep_TG_2>", "dlgGetRep(thieves) >= 15", "Your service and dedication are not forgotten when it comes time to dole out the spoils of victory. Levir gives you Lowtown the way a lord grants land and title to one of his knights. All that's asked of you in return is to rebuild the guild, find enforcers to keep the populace in line, extract the zealots holed up deep in the tunnels, and collect taxes on behalf of the king. Not quite what you had dreamed of, but still better than your competitors.", "Levir gives Lowtown to that rat bastard Bassar like leftovers scraped from the master's plate. If Bassar has any appreciation for the work you've done in helping him move up the ladder, he keeps it carefully hidden. After you make the mistake of not concealing your own feelings on the matter, he decides you need straightening out. Your next assignment waits you out on the street.");
addConditionalVar("<ending_temple_faction_Rep_TG_3>", "aod.ending_GNZ_faction_TG == 1", "Siding with Glabrio doesn't work out the way you had planned. After fucking it up with the zealots, Glabrio is forced to retreat to the only safe place, the tunnels. You have no choice but to follow him into a dark, damp exile. With the contract on your head for killing Levir, you're pinned like a rat, forced to listen to Glabrio casting blame, hour after hour, in every direction but one. Maybe in a few months it will be safe to creep through the city, gather whatever supplies you can carry on your back and escape to the wasteland. If you're lucky.", "Your service to House Aurelian isn't forgotten but even lord Senna can't shield you from Bassar's assassins. Twice they come after you and twice they fail but the second attempt leaves you with a crossbow bolt stuck in your shoulder blade. Rather than tempt your fate the third time, you leave the city in a hurry, heading for one of the remote settlements. Hopefully, you'd be safe there for a while. ");
addConditionalVar("<ending_temple_faction_Rep_MG_1>", "dlgGetRep(commercium) >= 15", "While Strabos did not deem you fit for the rank of Magistratus, your dedication has not been forgotten. Strabos recalls you to Maadoran to serve as his personal assistant. The man is not an easy master, and the list of your responsibilities would wear all but the longest scroll, but if you can last a few years, the promise of advancement remains.", "Maseus gets Ganezzar, Athanasius retains his position despite all his scheming, and Strabos is granted everything he desired on a silver platter. You get a pat on the head and are forgotten like a stray cat. Eventually, Maseus takes pity on you and offers you a job shifting papers and tallying accounts. It's not much, but it's better than the street.");
addConditionalVar("<ending_temple_faction_Rep_HD_1>", "dlgGetRep(loyalty) >= 1", "You could have run but your honor wouldn't allow it. Why should Dellar have all the fun anyway? So you stayed, standing next to Dellar and waiting until the bastards poured in through the gate. You could tell they didn't want to fight, but what choice did they have? Come and get some.<br><br>You went down during the second attack when the ground was slippery with blood. When you opened your eyes, you were on a cross. Dellar was nailed to a cross on the other side of the road, dead. Lucky bastard...", "You could have stayed and died for Antidas, but life's too short to die for other people. So you slip out of Teron when nobody is looking. When the Imperial Guards come to deal with Antidas once and for all, you're already far away.<br><br>What the future holds for a praetor without lord is unclear, but at least you're alive, which is more than could be said about your former brethren.");

addConditionalVar("[success]", "$pref::AoD::hideDlgTags", "", "<spush><color:45a053>[成功]<spop> ");
addConditionalVar("[failure]", "$pref::AoD::hideDlgTags", "", "<spush><color:f12d45>[失敗]<spop> ");
addConditionalVar("[partial success]", "$pref::AoD::hideDlgTags", "", "<spush><color:45a053>[一部成功]<spop> ");
addConditionalVar("[great success!]", "$pref::AoD::hideDlgTags", "", "<spush><color:45a053>[大成功！]<spop> ");

addConditionalVar("[strength success]", "$pref::AoD::hideDlgTags", "", "<spush><color:45a053>[筋力 成功]<spop> ");
addConditionalVar("[strength failure]", "$pref::AoD::hideDlgTags", "", "<spush><color:f12d45>[筋力 失敗]<spop> ");
addConditionalVar("[dexterity success]", "$pref::AoD::hideDlgTags", "", "<spush><color:45a053>[巧緻 成功]<spop> ");
addConditionalVar("[dexterity failure]", "$pref::AoD::hideDlgTags", "", "<spush><color:f12d45>[巧緻 失敗]<spop> ");
addConditionalVar("[constitution success]", "$pref::AoD::hideDlgTags", "", "<spush><color:45a053>[体力 成功]<spop> ");
addConditionalVar("[constitution failure]", "$pref::AoD::hideDlgTags", "", "<spush><color:f12d45>[体力 失敗]<spop> ");
addConditionalVar("[perception success]", "$pref::AoD::hideDlgTags", "", "<spush><color:45a053>[知覚 成功]<spop> ");
addConditionalVar("[perception failure]", "$pref::AoD::hideDlgTags", "", "<spush><color:f12d45>[知覚 失敗]<spop> ");
addConditionalVar("[intelligence success]", "$pref::AoD::hideDlgTags", "", "<spush><color:45a053>[知力 成功]<spop> ");
addConditionalVar("[intelligence failure]", "$pref::AoD::hideDlgTags", "", "<spush><color:f12d45>[知力 失敗]<spop> ");
addConditionalVar("[charisma success]", "$pref::AoD::hideDlgTags", "", "<spush><color:45a053>[魅力 成功]<spop> ");
addConditionalVar("[charisma failure]", "$pref::AoD::hideDlgTags", "", "<spush><color:f12d45>[魅力 失敗]<spop> ");

addConditionalVar("[constitution/intelligence failure]", "$pref::AoD::hideDlgTags", "", "<spush><color:f12d45>[体力/知力 失敗]<spop> ");
addConditionalVar("[constitution/intelligence success]", "$pref::AoD::hideDlgTags", "", "<spush><color:45a053>[体力/知力 成功]<spop> ");

addConditionalVar("[lore success]", "$pref::AoD::hideDlgTags", "", "<spush><color:45a053>[考古学 成功]<spop> ");
addConditionalVar("[lore failure]", "$pref::AoD::hideDlgTags", "", "<spush><color:f12d45>[考古学 失敗]<spop> ");
addConditionalVar("[crafting success]", "$pref::AoD::hideDlgTags", "", "<spush><color:45a053>[クラフト 成功]<spop> ");
addConditionalVar("[crafting failure]", "$pref::AoD::hideDlgTags", "", "<spush><color:f12d45>[クラフト 失敗]<spop> ");
addConditionalVar("[etiquette success]", "$pref::AoD::hideDlgTags", "", "<spush><color:45a053>[礼儀作法 成功]<spop> ");
addConditionalVar("[trading success]", "$pref::AoD::hideDlgTags", "", "<spush><color:45a053>[取引 成功]<spop> ");
addConditionalVar("[streetwise success]", "$pref::AoD::hideDlgTags", "", "<spush><color:45a053>[渡世術 成功]<spop> ");
addConditionalVar("[persuasion success]", "$pref::AoD::hideDlgTags", "", "<spush><color:45a053>[説得 成功]<spop> ");
addConditionalVar("[impersonate success]", "$pref::AoD::hideDlgTags", "", "<spush><color:45a053>[変装 成功]<spop> ");
addConditionalVar("[alchemy success]", "$pref::AoD::hideDlgTags", "", "<spush><color:45a053>[錬金術 成功]<spop> ");
addConditionalVar("[sneak success]", "$pref::AoD::hideDlgTags", "", "<spush><color:45a053>[隠密 成功]<spop> ");
addConditionalVar("[sneak failure]", "$pref::AoD::hideDlgTags", "", "<spush><color:f12d45>[隠密 失敗]<spop> ");
addConditionalVar("[traps success]", "$pref::AoD::hideDlgTags", "", "<spush><color:45a053>[トラップ 成功]<spop> ");
addConditionalVar("[traps failure]", "$pref::AoD::hideDlgTags", "", "<spush><color:f12d45>[トラップ 失敗]<spop> ");
addConditionalVar("[lockpick success]", "$pref::AoD::hideDlgTags", "", "<spush><color:45a053>[ロックピック 成功]<spop> ");
addConditionalVar("[lockpick failure]", "$pref::AoD::hideDlgTags", "", "<spush><color:f12d45>[ロックピック 失敗]<spop> ");
addConditionalVar("[steal success]", "$pref::AoD::hideDlgTags", "", "<spush><color:45a053>[窃盗 成功]<spop> ");

addConditionalVar("[melee success]", "$pref::AoD::hideDlgTags", "", "<spush><color:45a053>[melee 成功]<spop> ");
addConditionalVar("[ranged success]", "$pref::AoD::hideDlgTags", "", "<spush><color:45a053>[ranged 成功]<spop> ");
addConditionalVar("[dodge success]", "$pref::AoD::hideDlgTags", "", "<spush><color:45a053>[回避 成功]<spop> ");
addConditionalVar("[dodge failure]", "$pref::AoD::hideDlgTags", "", "<spush><color:f12d45>[回避 失敗]<spop> ");
addConditionalVar("[block success]", "$pref::AoD::hideDlgTags", "", "<spush><color:45a053>[ブロック 成功]<spop> ");
addConditionalVar("[block failure]", "$pref::AoD::hideDlgTags", "", "<spush><color:45a053>[ブロック 失敗]<spop> ");
addConditionalVar("[critical strike success]", "$pref::AoD::hideDlgTags", "", "<spush><color:45a053>[クリティカル 成功]<spop> ");
addConditionalVar("[critical strike failure]", "$pref::AoD::hideDlgTags", "", "<spush><color:f12d45>[クリティカル 失敗]<spop> ");

addConditionalVar("[aurelian reputation success]", "$pref::AoD::hideDlgTags", "", "<spush><color:45a053>[aurelian reputation 成功]<spop> ");
addConditionalVar("[aurelian reputation failure]", "$pref::AoD::hideDlgTags", "", "<spush><color:f12d45>[aurelian reputation 失敗]<spop> ");
addConditionalVar("[crassus reputation success]", "$pref::AoD::hideDlgTags", "", "<spush><color:45a053>[crassus reputation 成功]<spop> ");
addConditionalVar("[crassus reputation failure]", "$pref::AoD::hideDlgTags", "", "<spush><color:f12d45>[crassus reputation 失敗]<spop> ");
addConditionalVar("[commercium reputation success]", "$pref::AoD::hideDlgTags", "", "<spush><color:45a053>[commercium reputation 成功]<spop> ");
addConditionalVar("[commercium reputation failure]", "$pref::AoD::hideDlgTags", "", "<spush><color:f12d45>[commercium reputation 失敗]<spop> ");
addConditionalVar("[reputation success]", "$pref::AoD::hideDlgTags", "", "<spush><color:45a053>[reputation 成功]<spop> ");
addConditionalVar("[reputation failure]", "$pref::AoD::hideDlgTags", "", "<spush><color:f12d45>[reputation 失敗]<spop> ");
addConditionalVar("[reputation: Forty Thieves]", "$pref::AoD::hideDlgTags", "", "<spush><color:45a053>[reputation: Forty Thieves]<spop> ");

addConditionalVar("[word of honor success]", "$pref::AoD::hideDlgTags", "", "<spush><color:45a053>[word of honor 成功]<spop> ");
addConditionalVar("[word of honor failure]", "$pref::AoD::hideDlgTags", "", "<spush><color:f12d45>[word of honor 失敗]<spop> ");
addConditionalVar("[intimidate success]", "$pref::AoD::hideDlgTags", "", "<spush><color:45a053>[intimidate 成功]<spop> ");

addConditionalVar("[traps]", "$pref::AoD::hideDlgTags", "", "<spush><color:f0f0f0>[トラップ]<spop> ");
addConditionalVar("[sneak]", "$pref::AoD::hideDlgTags", "", "<spush><color:f0f0f0>[隠密]<spop> ");
addConditionalVar("[lockpick]", "$pref::AoD::hideDlgTags", "", "<spush><color:f0f0f0>[ロックピック]<spop> ");
addConditionalVar("[steal]", "$pref::AoD::hideDlgTags", "", "<spush><color:f0f0f0>[窃盗]<spop> ");
addConditionalVar("[persuasion]", "$pref::AoD::hideDlgTags", "", "<spush><color:f0f0f0>[説得]<spop> ");
addConditionalVar("[streetwise]", "$pref::AoD::hideDlgTags", "", "<spush><color:f0f0f0>[渡世術]<spop> ");
addConditionalVar("[impersonate]", "$pref::AoD::hideDlgTags", "", "<spush><color:f0f0f0>[変装]<spop> ");
addConditionalVar("[etiquette]", "$pref::AoD::hideDlgTags", "", "<spush><color:f0f0f0>[礼儀作法]<spop> ");
addConditionalVar("[alchemy]", "$pref::AoD::hideDlgTags", "", "<spush><color:f0f0f0>[錬金術]<spop> ");
addConditionalVar("[crafting]", "$pref::AoD::hideDlgTags", "", "<spush><color:f0f0f0>[クラフト]<spop> ");
addConditionalVar("[lore]", "$pref::AoD::hideDlgTags", "", "<spush><color:f0f0f0>[考古学]<spop> ");
addConditionalVar("[trading]", "$pref::AoD::hideDlgTags", "", "<spush><color:f0f0f0>[取引]<spop> ");

addConditionalVar("[bow]", "$pref::AoD::hideDlgTags", "", "<spush><color:f0f0f0>[弓]<spop> ");
addConditionalVar("[crossbow]", "$pref::AoD::hideDlgTags", "", "<spush><color:f0f0f0>[クロスボウ]<spop> ");
addConditionalVar("[throwing]", "$pref::AoD::hideDlgTags", "", "<spush><color:f0f0f0>[投擲]<spop> ");
addConditionalVar("[dodge]", "$pref::AoD::hideDlgTags", "", "<spush><color:f0f0f0>[回避]<spop> ");
addConditionalVar("[block]", "$pref::AoD::hideDlgTags", "", "<spush><color:f0f0f0>[ブロック]<spop> ");
addConditionalVar("[critical strike]", "$pref::AoD::hideDlgTags", "", "<spush><color:f0f0f0>[クリティカル]<spop> ");
addConditionalVar("[melee]", "$pref::AoD::hideDlgTags", "", "<spush><color:f0f0f0>[melee]<spop> ");
addConditionalVar("[ranged]", "$pref::AoD::hideDlgTags", "", "<spush><color:f0f0f0>[ranged]<spop> ");
addConditionalVar("[defense]", "$pref::AoD::hideDlgTags", "", "<spush><color:f0f0f0>[defense]<spop> ");
addConditionalVar("[body count]", "$pref::AoD::hideDlgTags", "", "<spush><color:f0f0f0>[body count]<spop> ");
addConditionalVar("[intimidate]", "$pref::AoD::hideDlgTags", "", "<spush><color:f0f0f0>[intimidate]<spop> ");
addConditionalVar("[word of honor]", "$pref::AoD::hideDlgTags", "", "<spush><color:f0f0f0>[word of honor]<spop> ");
addConditionalVar("[black powder]", "$pref::AoD::hideDlgTags", "", "<spush><color:f0f0f0>[black powder]<spop> ");

addConditionalVar("[strength]", "$pref::AoD::hideDlgTags", "", "<spush><color:f0f0f0>[筋力]<spop> ");
addConditionalVar("[dexterity]", "$pref::AoD::hideDlgTags", "", "<spush><color:f0f0f0>[巧緻]<spop> ");
addConditionalVar("[constitution]", "$pref::AoD::hideDlgTags", "", "<spush><color:f0f0f0>[体力]<spop> ");
addConditionalVar("[perception]", "$pref::AoD::hideDlgTags", "", "<spush><color:f0f0f0>[知覚]<spop> ");
addConditionalVar("[intelligence]", "$pref::AoD::hideDlgTags", "", "<spush><color:f0f0f0>[知力]<spop> ");
addConditionalVar("[charisma]", "$pref::AoD::hideDlgTags", "", "<spush><color:f0f0f0>[魅力]<spop> ");

addConditionalVar("[assassin]", "$pref::AoD::hideDlgTags", "", "<spush><color:ffc62c>[暗殺者]<spop> ");
addConditionalVar("[praetor]", "$pref::AoD::hideDlgTags", "", "<spush><color:ffc62c>[執政官]<spop> ");
addConditionalVar("[thief]", "$pref::AoD::hideDlgTags", "", "<spush><color:ffc62c>[盗賊]<spop> ");
addConditionalVar("[guard]", "$pref::AoD::hideDlgTags", "", "<spush><color:ffc62c>[衛兵]<spop> ");
addConditionalVar("[merchant]", "$pref::AoD::hideDlgTags", "", "<spush><color:ffc62c>[商人]<spop> ");
addConditionalVar("[grifter]", "$pref::AoD::hideDlgTags", "", "<spush><color:ffc62c>[詐欺師]<spop> ");
addConditionalVar("[chosen one]", "$pref::AoD::hideDlgTags", "", "<spush><color:ffc62c>[選ばれし者]<spop> ");
addConditionalVar("[Mind Shield]", "$pref::AoD::hideDlgTags", "", "<spush><color:ffc62c>[Mind Shield]<spop> ");
addConditionalVar("[stat damage]", "$pref::AoD::hideDlgTags", "", "<spush><color:f0f0f0>[stat damage]<spop> ");
addConditionalVar("{TEMP}", "aod.none", "", "");

//Combat:

//<attacker> = attacker NPC name
//<attacker_s> = attacker NPC name + 's. Examples: Elhoim's, Titus'
//<victim>
//<victim_s>
//<amount> = inflicted damage
//<DR> = resisted damage
//<type> = potion type
//<npc> = charname of the one who drank a potion
//<chance> = numerical value of passive weapon effect chance
//<attacker_heshe>
//<attacker_himher>
//<attacker_hisher>
//<victim_heshe>
//<victim_himher>
//<victim_hisher>