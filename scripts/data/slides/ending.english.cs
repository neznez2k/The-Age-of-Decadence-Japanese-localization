﻿//--- OBJECT WRITE BEGIN ---
new SimGroup(SE_slides_group) {
   canSave = "1";
   canSaveDynamicFields = "1";

   new SimObject(slide0) {
      canSave = "1";
      canSaveDynamicFields = "1";
         script = "TRN_EndingSlides_Main();";
         sid = "0";
         sname = "Teron Endings";
         text0 = "The dream of restoring the Empire dies with Lord Antidas, as does any hope of saving House Daratan from fading into the history scrolls.\n\nWith Antidas finally out of the way, the Imperial Guards seize control of Teron, establishing martial law and press-ganging the remnants of Antidas\' men into service. Thieves, beggars, and other \'undesirable\' elements are rounded up and crucified outside the gates as a warning to others.\n\nProving that success is never punished, Caer-Tor chooses to back Commander Carrinas, shifting the balance of power away from House Aurelian and weakening their grip on the region.\n\nThe new regime imposes heavy taxes and restrictions on the Commercium\'s operations in Teron. Unable to secure the favour it once enjoyed, the guild\'s power and influence start to wane.";
         text1 = "Taking the demise of the Imperial Guards at the hands of the Boatmen as a good omen, Lord Antidas steps up the recruitment efforts of House Daratan. Pardons are granted to bandits and raiders willing to serve the House and mercenaries are hired en masse with the Commercium\'s gold.\n\nWithout the Imperial Guards to keep the newly-arrived fighting men in check, the town quickly descends into near-lawlessness, becoming little more than a camped mercenary army, waiting for the order to march.\n\nThough Antidas seems to hold the reigns of the Sellsword Legion, it is the Commercium who pays their wages, and the only loyalty a mercenary truly recognises is to the one who pays him. By becoming the paymaster for the entire Legion, the Commercium effectively becomes Antidas\' shadow partner, greatly expanding their influence and control over local trade.\n\nBacked by that Legion, the Commercium\'s influence grows rapidly alongside their control over local trade. Bored and seeking entertainment, the camped mercenaries spend their coins at the Commercium\'s establishments almost as quickly as they earn them, making it a very profitable enterprise indeed.";
         text2 = "The unexpected alliance between House Daratan and the Imperial Guards sends ripples across the region. On the surface, it seems that Antidas has gained battle-hardened veterans and Carrinas has gained the much needed legitimacy. Regardless of which man is actually calling the shots, the news means war and has to be taken seriously.\n\nThe Imperial Guards tighten up the security in Teron, but stop short of declaring martial law. Caer-Tor chooses to back Commander Carrinas, shifting the balance of power away from House Aurelian and weakening their grip on the region.\n\nStruggling under the burden of the new taxes imposed on its operations in Teron, the Commercium manages to retain the favour of Lord Antidas, allowing the guild to keep control over the local trade.";
         text3 = "News that the Imperial Guards have recognised Lord Antidas as the rightful Emperor sends ripples of shock throughout the region. On the surface, it seems that Antidas has gained battle-hardened veterans and Carrinas has gained the much needed legitimacy. Regardless of which man is actually calling the shots, the news means war and has to be taken seriously.\n\nThe Imperial Guards tighten up the security in Teron but stop short of declaring martial law. Caer-Tor remains cautiously silent, showing their unwillingness to recognize Antidas as the Emperor and leaving Carrinas on his own, at least for the time being.\n\nStruggling under the burden of the new taxes imposed on its operations in Teron, the Commercium manages to retain the favour of Lord Antidas, allowing the guild to keep control over the local trade.";
         text4 = "Using a staged attack as a pretext, the Imperial Guards take over Teron\'s gate and the towers. A \"delegation\" of veteran Guards sent to deliver an ultimatum provokes Lord Antidas in his own palace and manages to kill him in the ensuing fight. His death brings an end to the dreams of restoring the Empire, as well as any hope of saving House Daratan from fading into the history scrolls.\n\nWith Antidas finally out of the way, the Imperial Guards seize control of Teron, establishing martial law and press-ganging the remnants of Antidas\' men into service. Thieves, beggars, and other \'undesirable\' elements are rounded up and crucified outside the gates as a warning to others.\n\nProving that success is never punished, Caer-Tor chooses to back Commander Carrinas, shifting the balance of power away from House Aurelian and weakening their grip on the region.\n\nThe new regime imposes heavy taxes and restrictions on the Commercium\'s operations in Teron. Unable to secure the favour it once enjoyed, the guild\'s power and influence start to wane.";
         text5 = "The assassination of Commander Carrinas by one of House Daratan\'s praetors triggers a wave of condemnation. Both Caer-Tor and House Aurelian paint Lord Antidas as a warmonger who sent his butchers to cowardly slay a man entrusted with keeping peace and both promise to do everything in their power to prevent further attacks. \n\nFinding himself isolated, Lord Antidas steps up the recruitment efforts of House Daratan. The Imperial Guards respond by increasing patrols, making sure that only a handful of men for hire reach Teron. \n\nFor everyone else, the life in Teron remains the same. The guilds continue about their business. A newly appointed Commander arrives to Teron, but unlike his predecessor, he lacks grand designs and ambitions. The Commercium finds the new Commander very agreeable and his mandate to build up strength most profitable.";
         text_id0 = "1";
         text_id1 = "2";
         text_id2 = "3";
         text_id3 = "4";
         text_id4 = "5";
         text_id5 = "6";
         type = "1";
   };
   new SimObject(slide1) {
      canSave = "1";
      canSaveDynamicFields = "1";
         appear_check = "aod.ending_faction_AG";
         script = "$SS_image = \"ending_ag.png\";\n$SS_text = 1;";
         sid = "1";
         sname = "AG";
         text0 = "In light of the deadly raid on the barracks, the assassination of the Imperial Guards\' Commander is seen as an attack on the Imperial Guards. Abruptly, the Boatmen\'s decades-long policy of non-involvement is ended, creating tensions and polarizing the guild.\n\nThe Maadoran branch openly joins House Aurelian, claiming to be restoring the guild to what it once was. News of the Maadoran assassins becoming Lord Gaelius\' regiment brings unease to factions across the region.\n\nEmbarrassed, the Ganezzar branch attempts to distance themselves from the events in Teron and Maadoran, reinforcing their commitment to the policy of non-involvement. They brand their Maadoran brethren as sell-outs and condemn Neleos\' ambitions and poor judgement, striving to maintain their independence.";
         text_id0 = "1";
         type = "1";
   };
   new SimObject(slide2) {
      canSave = "1";
      canSaveDynamicFields = "1";
         appear_check = "aod.ending_faction_TG";
         script = "$SS_image = \"ending_TG.png\";\n\nif (aod.ending_faction_TG_01)\n $SS_text = 1;\nelse\n $SS_text = 2;";
         sid = "2";
         sname = "TG";
         text0 = "The infamous Slums of Maadoran are a maze-like district of makeshift houses built among ruins that stretch on for miles. The domain of the Forty Thieves, the Slums have always been known as a kingdom of beggars and thieves - the proverbial rock-bottom one ends up at after too many wrong choices. It is a lawless place, avoided even by guards, which makes it a perfect place to hide something.\n\nBy the time the Commercium\'s gold reaches Maadoran and disappears inside the Slums, the rumors have transformed a crate of gold into a king\'s ransom. Sellswords and cutthroats alike are taunted by the stories of chests overflowing with unimaginable wealth, ripe for the taking.\n\nBefore long, bands of rough looking men begin arriving in Maadoran, showing a strong interest in the Slums. The impatient ones venture in, never to be seen again. The rest simply wait for the right opportunity, as the city is slowly heading toward the boiling point.";
         text1 = "The infamous Slums of Maadoran are a maze-like district of makeshift houses built among ruins that stretch on for miles. The domain of the Forty Thieves, the Slums have always been known as a kingdom of beggars and thieves - the proverbial rock-bottom one ends up at after too many wrong choices. It is a lawless place, avoided even by guards, which makes it a perfect place to hide something.\n\nBy the time the Commercium\'s gold reaches Maadoran and disappears inside the Slums, the rumors have transformed few crates of gold into a king\'s ransom. Sellswords and cutthroats alike are taunted by the stories of chests overflowing with unimaginable wealth, ripe for the taking.\n\nBefore long, bands of rough looking men begin arriving in Maadoran, showing a strong interest in the Slums. The impatient ones venture in, never to be seen again. The rest simply wait for the right opportunity, as the city is slowly heading toward the boiling point.";
         text_id0 = "1";
         text_id1 = "2";
         type = "1";
   };
   new SimObject(slide3) {
      canSave = "1";
      canSaveDynamicFields = "1";
         appear_check = "aod.ending_faction_IG";
         script = "$SS_image = \"ending_ig.png\";\n$SS_text = 1;";
         sid = "3";
         sname = "IG";
         text0 = "When the Empire fell, the combined might of seven Noble Houses that survived the war was enough to keep what was left of the Imperial Army in check. Since then, the Imperial Guards have grown in power, while the strength of the Noble Houses has diminished.\n\nThe events in Teron tell Lord Gaelius that the scales have once again been tipped. House Crassus is too pre-occupied with the occult and shows no interest in reality, leaving the task of reining in the Imperial Guards to House Aurelian. Alone, he doesn\'t stand a chance, and good allies are in short supply these days. Neither sellswords nor Meru\'s fanatics can be relied on. With no other alternative, Gaelius sends messengers to the Ordu.\n\nConfident that the Ordu will accept his proposal, Gaelius is planning to use them as his private army able to easily keep the Imperial Guards - and everyone else - at bay. All that stands between him and his dreams is the mountain range that acts as a natural border between the southern cities and the wasteland. The only pass, high in the mountains, is held by a small detachment of the Guards.\n\nThe Ordu tribes are the old foe, responsible for much bloodshed in the past. Until the Ordu army is through the pass, ready to do his bidding, Gaelius can\'t afford to aid them. With nothing to be done, but wait, Gaelius\' only hope is that the Ordu won\'t be spotted until it\'s too late. He is aware of the risks associated with bringing a foreign and volatile army to Maadoran, but the growing threat of the Imperial Guards leaves him no choice.";
         text_id0 = "1";
         type = "1";
   };
   new SimObject(slide4) {
      canSave = "1";
      canSaveDynamicFields = "1";
         appear_check = "aod.ending_faction_MG";
         script = "$SS_image = \"ending_mg.png\";\n$SS_text = 1;";
         sid = "4";
         sname = "MG";
         text0 = "Emboldened by their success in Teron, the \"lords\" of Commercium set their sights on Maadoran. Lord Gaelius can\'t be controlled; ergo he must be replaced by someone more suitable. What the city needs is someone who will show proper respect to the guildmasters and perhaps even listen to an occasional piece of advice, or two.\n\nSerenas, Lord Gaelius\' nephew, is a perfect candidate. He has the blood claim, he\'s young, weak, and already owes a fortune to the Commercium. Still, replacing the most powerful man in the realm isn\'t an easy task and must be handled very delicately.\n\nTemporary alliances, disavowed the moment the goal is achieved, must be made. Assurances must be given. Most importantly, Lord Gaelius and the Imperial Guards must be distracted and look the other way while the magic happens.";
         text_id0 = "1";
         type = "1";
   };
   new SimObject(slide6) {
      canSave = "1";
      canSaveDynamicFields = "1";
         appear_check = "aod.ending_loremaster";
         script = "$SS_portrait0 = \"cassius.png\";\n$SS_portrait1 = \"feng.png\";\n$SS_portrait2 = \"sohrab.png\";\n\nif (aod.ending_character_cassius_01)\n{\n if (aod.npc_antidas_dead)\n \t  $SS_text0 = 7;\n else\n  $SS_text0 = 1;\n}\n\nif (aod.ending_character_cassius_02)\n{\n if (aod.npc_antidas_dead)\n \t  $SS_text0 = 7;\n else\n  $SS_text0 = 2;\n}\n\nif (aod.ending_character_cassius_03)\n{\n if (aod.npc_antidas_dead)\n \t  $SS_text0 = 7;\n else\n  $SS_text0 = 8;\n}\n\nif (aod.ending_character_feng_01)\n $SS_text1 = 3;\n\nif (aod.ending_character_feng_02)\n{\n\t if (aod.npc_antidas_dead)\n {\n  $SS_text1 = 6;\n  aod.npc_feng_fledTeron = true;\n }\n else\n\t  $SS_text1 = 4;\n}\n\nif (aod.ending_character_feng_03)\n $SS_text1 = 9;\n\nif (aod.ending_character_sohrab_01)\n $SS_text2 = 5;";
         sid = "6";
         sname = "Loremasters";
         text0 = "You double-crossed Feng and helped Cassius to replace him as Lord Antidas\' personal loremaster. Unfortunately, there is little for him to do in Teron, thus House Daratan does not benefit from Cassius\' vast knowledge of the lore of the olden days.";
         text1 = "Unwittingly, you double-crossed Feng and helped Cassius to replace him as Lord Antidas\' personal loremaster. Unfortunately, there is little for him to do in Teron, thus House Daratan does not benefit from Cassius\' vast knowledge of the lore of the olden days.";
         text2 = "Master Feng has managed to escape, and according to rumors, has resurfaced in Ganezzar, quickly gaining Lord Meru\'s trust and favour.";
         text3 = "You managed to get rid of Cassius, which secured Feng\'s position as Lord Antidas\' personal loremaster. While his homemade artefacts would fail to pass the scrutiny of a true loremaster, the trinkets inspire Lord Antidas with a sense of infallibility.";
         text4 = "Unfortunately, loremaster Sohrab didn\'t make it out alive and his knowledge of the old world\'s machines died with him.";
         text5 = "When the news of Lord Antidas\' death reached master Feng, he promptly left Teron and, according to rumors, has resurfaced in Ganezzar, quickly gaining Lord Meru\'s trust and favour.";
         text6 = "After Lord Antidas\' demise, loremaster Cassius decided to stay in Teron and do what Feng used to do, but without any lies or embellishment. Unfortunately, there is little money to be made in telling the truth. Two weeks later, Cassius reluctantly tells a hopeful farmer the words he wants to hear.";
         text7 = "Master Cassius has replaced Feng, becoming Lord Antidas\' personal loremaster. Unfortunately, there is little for him to do in Teron, thus House Daratan does not benefit from Cassius\' vast knowledge of the lore of the olden days.";
         text8 = "Failing to get rid of Cassius, master Feng has left Teron, and according to rumors, has resurfaced in Ganezzar, quickly gaining Lord Meru\'s trust and favour.";
         text_id0 = "1";
         text_id1 = "2";
         text_id2 = "3";
         text_id3 = "4";
         text_id4 = "5";
         text_id5 = "6";
         text_id6 = "7";
         text_id7 = "8";
         text_id8 = "9";
         type = "0";
   };
   new SimObject(slide7) {
      canSave = "1";
      canSaveDynamicFields = "1";
         appear_check = "aod.ending_sidequest";
         script = "if(aod.ending_npc_militiades_01)\n{\n$SS_text0 = 1;\n$SS_portrait0 = \"miltiades.png\";\n}\n\nif(aod.ending_npc_preacher_01)\n{\n $SS_text1 = 2;\n $SS_portrait1 = \"meru.png\";\n}\nelse if(aod.ending_npc_preacher_02)\n{\n $SS_text1 = 3;\n $SS_portrait1 = \"meru.png\";\n}\n\nif(aod.ending_npc_livia_01)\n{\n $SS_text2 = 4;\n $SS_portrait2 = \"livia.png\";\n}";
         sid = "7";
         sname = "Side Quests";
         text0 = "Despite being burned twice by Miltiades, you let him live and agree to participate in his next \"it\'s gonna be big\" scheme, completely unaware that you\'re going to be the star of the show. The good news is that it is going to be big. The bad news... well, you like surprises, don\'t you?";
         text1 = "You\'ve made a good impression on a preacher of Ganezzar. Should you ever end up in Ganezzar, you will be well received by Lord Meru.";
         text2 = "Using his own beliefs against him, you\'ve managed to convince a preacher of Ganezzar that you\'re the Chosen One. As a result, you can expect assistance from every faithful and a warm reception in Ganezzar, should you stick to your role.";
         text3 = "Believing that some people deserve a second chance, you\'ve spared Livia\'s life and sent her to Cado. He agreed that the girl can be more than a petty two-bit con-artist and decided to send her to Maadoran to be properly trained.";
         text_id0 = "1";
         text_id1 = "2";
         text_id2 = "3";
         text_id3 = "4";
         type = "0";
   };
   new SimObject(slide8) {
      canSave = "1";
      canSaveDynamicFields = "1";
         appear_check = "aod.ending_banditOupost";
         script = "if(aod.ending_outpost_tube && aod.npc_antidas_dead == false)\n $SS_text0 = 4;\n\nif(aod.quest_teronMine_aurelianLeft && aod.npc_antidas_dead == false)\n $SS_text0 = 3;\n\nif(aod.ending_outpost_attacked && aod.npc_antidas_dead == false)\n $SS_text0 = 5;\n\nif(aod.ending_outpost_blewUp && aod.npc_antidas_dead == false)\n $SS_text0 = 6;\n\nif(aod.ending_outpost_fixAurelian)\n $SS_text0 = 7;\n\nif(aod.ending_outpost_witness)\n{\n $SS_text1 = 1;\n $SS_portrait1 = \"gaelius.png\";\n}\n\nif(aod.ending_bandit_01)\n{\n$SS_text2 = 2;\n$SS_portrait2 = \"esbenus.png\";\n}";
         sid = "8";
         sname = "Outpost & Bandit";
         text0 = "Greatly exaggerated rumors of your involvement in the Aurelian outpost\'s massacre have reached Maadoran and made quite an impression on Lord Gaelius of House Aurelian. Although he\'s never met you, he\'s heard enough to start wondering why you\'re still alive, which is an easy problem to fix.";
         text1 = "You let Esbenus go when he was at your mercy. He put the money you gave him to good use - gathering a large group of raiders and proceeding to make a name for himself, raiding and pillaging, but staying away from Teron. No matter how you look at it, he owes you.";
         text2 = "The Aurelians report that the machines failed to start and the initial assessments of the site\'s potential were overstated. They quietly seal the entrance and leave the outpost without delay.";
         text3 = "Rather than admit that a valuable relic has disappeared on their watch, the Aurelians decide to report that the machines failed to start and the initial assessments of the site\'s potential were overstated. They quietly seal the entrance and leave the outpost without delay.";
         text4 = "When the news of the attack reaches Maadoran, House Daratan expresses their regret at the senseless bloodshed and reminds House Aurelian about the dangers of operating that far from Maadoran. Lord Antidas assures the citizens of Maadoran that the raiders have been dealt with and the mine has been taken under Daratan\'s control to safeguard the machines.";
         text5 = "When the news of the accident reaches Maadoran, House Daratan expresses their regret at the senseless loss of lives and cautions House Aurelian against toying with forces beyond their understanding, especially that close to Teron.\n\nThe note does little to quell the growing rumors that the Aurelians had found \"dangerous magicks\" there, but had to seal the mine to prevent the magicks from falling into the wrong hands. It isn\'t long before unscrupulous prospectors move into the abandoned camp and start digging in.";
         text6 = "Fixing the smelter has presented you with an opportunity to make a strong impression on, and prove your value to, the most powerful Lord of the realm. Although you were given little choice in the matter, you\'re now on your way to Maadoran.";
         text_id0 = "1";
         text_id1 = "2";
         text_id2 = "3";
         text_id3 = "4";
         text_id4 = "5";
         text_id5 = "6";
         text_id6 = "7";
         type = "0";
   };
   new SimObject(slide9) {
      canSave = "1";
      canSaveDynamicFields = "1";
         appear_check = "aod.ending_mgChoices";
         script = "$SS_portrait0 = \"mercato.png\";\n$SS_portrait1 = \"carrinas.png\";\n\nif(aod.ending_mg_mercato_01)\n$SS_text0 = 1;\nelse if(aod.ending_mg_mercato_02)\n$SS_text0 = 2;\n\nif(aod.ending_mg_carrinas_01)\n$SS_text1 = 3;\nelse if(aod.ending_mg_carrinas_02)\n$SS_text1 = 4;";
         sid = "9";
         sname = "MG Choices";
         text0 = "You have convinced Mercato to join House Daratan. When the Sellsword Legion is formed, Mercato and his men take key positions, enforcing military discipline and training them to fight like a proper legion. As his control over the legion grows, Commercium\'s influence wanes.";
         text1 = "You have forced Mercato to join House Daratan. When the Sellsword Legion is formed, Mercato and his men take key positions, enforcing military discipline and training them to fight like a proper legion. Not a man to be crossed, he holds a grudge against the Commercium, acting against their interests whenever he can. As his control over the legion grows, Commercium\'s influence wanes.";
         text2 = "Ever an opportunist, you betrayed your guild and switched sides, aiding Commander Carrinas instead of stopping him.";
         text3 = "Ever an opportunist, you betrayed your guild and switched sides, aiding Commander Carrinas instead of stopping him. Your talents came in handy, helping Carrinas to negotiate a deal with Lord Antidas and gain much needed legitimacy.";
         text_id0 = "1";
         text_id1 = "2";
         text_id2 = "3";
         text_id3 = "4";
         type = "0";
   };
   new SimObject(slide10) {
      canSave = "1";
      canSaveDynamicFields = "1";
         appear_check = "aod.ending_igChoices";
         script = "if (aod.ending_antidas_emperor)\n{\n $SS_portrait0 = \"antidas.png\";\n $SS_text0 = 1;\n}\n\nif (aod.ending_tookDocuments)\n{\n $SS_text0 = 2;\n}";
         sid = "10";
         sname = "IG & MG";
         text0 = "While your clever ploy has made Lord Antidas an Emperor in name only, names do have power. The recognition of Antidas\' stature sets the wheels in motion, giving him a path to follow.";
         text1 = "Acting on impulse, you took the document outlining the terms of the alliance between Lord Antidas and Commander Carrinas, and left Teron without delay. Betraying the confidence of such powerful men will undoubtedly cost you, but if you play your cards right, the document will elevate you far beyond their reach.";
         text_id0 = "1";
         text_id1 = "2";
         type = "0";
   };
   new SimObject(slide13) {
      canSave = "1";
      canSaveDynamicFields = "1";
         appear_check = "aod.ending_agChoices";
         script = "if(aod.ending_ag_01)\n{\n$SS_text0 = 1;\n$SS_portrait0 = \"gaelius.png\";\n}\nelse if(aod.ending_ag_02 && aod.npc_antidas_dead == false)\n{\n$SS_text0 = 2;\n}\n\nif(aod.ending_ag_03)\n{\n$SS_text1 = 3;\n$SS_portrait1 = \"carrinas.png\";\n}\nelse if(aod.ending_ag_04)\n{\n$SS_text1 = 4;\n$SS_portrait1 = \"carrinas.png\";\n}\nelse if(aod.ending_ag_05)\n$SS_text1 = 5;\n\nif(aod.ending_ag_06)\n{\n$SS_text2 = 6;\n$SS_portrait2 = \"neleos.png\";\n}";
         sid = "13";
         sname = "AG Choices";
         text0 = "You have betrayed and dishonoured your guild, but who can blame you? An opportunity to make a good impression on the most powerful Lord of the realm and have him in your debt doesn\'t come often.";
         text1 = "Trying to impress Neleos, you made a deal with one of Gaelius\' spies - his life for the reports. Unfortunately, it was a bad judgement call on your part. What the spy had learned was enough to expose a weakness in Antidas\' defences and set a plan for his assassination in motion.";
         text2 = "Ever an opportunist, you betrayed your guild and killed your partner to save Commander Carrinas\' life. Unfortunately, your grand gesture wasn\'t enough to be admitted into the Imperial Guards\' ranks and you were forced to return and kill your brothers to prove that you\'re worth a damn. Your betrayal has assured Carrinas\' victory and shortened your life expectancy.";
         text3 = "Ever an opportunist, you betrayed your guild and killed your partner to save Commander Carrinas\' life. He paid enough to make it worth the trouble and you left Teron with plenty of money in your pockets. Your betrayal has assured Carrinas\' victory and shortened your life expectancy.";
         text4 = "You saved Coltan\'s life during the Imperial Guards\' attack on your guild. The old alchemist left Teron, but should you run into him, he will, undoubtedly, remember the favour.";
         text5 = "You saved Neleos\' life during the raid on the Imperial Guards\' barracks. The former guildmaster of the Boatmen disappeared shortly after, but, hopefully, your paths will cross again.";
         text_id0 = "1";
         text_id1 = "2";
         text_id2 = "3";
         text_id3 = "4";
         text_id4 = "5";
         text_id5 = "6";
         type = "0";
   };
};
//--- OBJECT WRITE END ---