//--- OBJECT WRITE BEGIN ---
new SimGroup(SE_slides_group) {
   canSave = "1";
   canSaveDynamicFields = "1";

   new SimObject(slide2) {
      canSave = "1";
      canSaveDynamicFields = "1";
         script = "$SS_image = \"vignette_worldIntro.png\";\n$SS_text = 1;";
         sid = "2";
         sname = "World Intro";
         text0 = "\n<just:center>この世界と、かつて世界を支配していた帝国は廃墟と化していた。在りし日には貴族の家は地方を支配し巨大な軍隊を率いていたが、今では崩壊した都市国家にまで衰えた。そして帝国軍の残党である帝国衛兵たちは今や貴族間の戦争を防ぐ抑止力として活動している。\n\n古き日の知識は忘れ去られた。行商人は何の価値もない古代の商品を無知な者たちに売り捌き、貴族たちはその価値をほとんど理解できていないにもかかわらず、アーティファクトを探しては溜め込んでいる。狂信的な神秘主義が徐々に支持を得ており、長年にわたる怨嗟が表面化し始める。戦争が近いのだと推測する者もいれば、それを積極的に勧める者もいた。\n\nこのような時代は、普通の人間には苦痛しかもたらさない。しかし、ある種の決意をした人間にとっては、一生に二度と訪れない機会を与えてくれる時代でもある。チャンスを逃すまいと決意し、富を、力を、栄光を、危険を厭わず求める者たちにとっては。\n\n";
         text_id0 = "1";
         type = "5";
   };
   new SimObject(slide3) {
      canSave = "1";
      canSaveDynamicFields = "1";
         script = "$SS_image = \"vignette_teronIntro.png\";\n$SS_text = 1;";
         sid = "3";
         sname = "Town Intro";
         text0 = "\n<just:center>君の冒険はテロン─旅人や隊商の主な行路からは遠く離れた、崩れかけた小さな町─から始まる。もう１００年ほど前から滅びかけており、住民の努力によってのみ生かされている町だ。壊れた石造物はその場しのぎの木造建築に置き換えられ、古い廃墟から新しい町が徐々に現れてきているような印象を与えている。\n\nテロンと同じように、この町を支配する貴族の家も昔は良い日々を送っていた。帝国を崩壊させた戦争と、その戦争がもたらした荒廃以前の時代ならばダラタン家は最も力のある家の一つだったが、今や昔、時代は変わった。今日では、地元のギルドに対する支配力を辛うじて維持する程度の力しかない。\n\n";
         text_id0 = "1";
         type = "5";
   };
   new SimObject(slide1) {
      canSave = "1";
      canSaveDynamicFields = "1";
         script = "switch(aod.professionID)\n\t\t\t{\n\t\t\tcase 0: $SS_image = \"ending_ag.png\"; $SS_text = 1;\n\t\t\tcase 1: $SS_image = \"ending_tg.png\"; $SS_text = 3;\n\t\t\tcase 2: $SS_image = \"ending_daratan.png\"; $SS_text = 6;\n\t\t\tcase 3: $SS_image = \"start_vignette_01.png\"; $SS_text = 4;\n\t\t\tcase 4: $SS_image = \"start_vignette_01.png\"; $SS_text = 8;\n\t\t\tcase 5: $SS_image = \"start_vignette_01.png\"; $SS_text = 7;\n\t\t\tcase 6: $SS_image = \"start_vignette_01.png\"; $SS_text = 2;\n\t\t\tcase 7: $SS_image = \"ending_mg.png\"; $SS_text = 5;\ncase 8: $SS_image = \"start_vignette_01.png\"; $SS_text = 9;\n\t\t\t}";
         sid = "1";
         sname = "Vignettes";
         text0 = "君はステュクスの漕手のギルドマスターであるネレロスの元で働いて生計を立てている。君は人の背中に刃物を突き刺しても全く不快な気持ちにならないというユニークな才能を生かそうと決心し、真面目な仕事を求めて数ヶ月前にこのギルドに加入した。\n\nThe Boatmen was a good outfit that went back a long way. In the olden days,皇帝直属の衛兵がいた。彼らは皇帝を守るという本来の任務とは別に、潜入と暗殺のエキスパートとして訓練されていた。 多くの政治的、軍事的な敵対者たちが夜の狂喜の中の死や、説明のつかない不幸に遭遇し、帝国の長年にわたる安定を確保した。帝国の崩壊後、仕える主がいないため、衛兵たちは滅びた帝国の混沌へと散っていった。  外の世界に出ると、世界が荒廃していても、彼らの平和維持活動には大きな需要があった。 暗殺教団が設立され、その一群は誉れ高き名を帯びることになる。「ステュクスの漕手」と。";
         text1 = "君は宿の客に”護衛サービス”を提供して生計を立てている。まだ若く、何も知らない頃は君は酒と喧嘩に明け暮れていた。君はその技を認められ、宿の仕事を依頼された。今では、酔っ払って手に負えなくなった客を蹴散らすことで給金をもらい、宿のおごりで酒を飲めるようになっている。";
         text2 = "You make a living stealing for Cado, the guildmaster of the Forty Thieves. In your youth, you broke your back for every coin. That was until you realized that kind of work wasn\'t for you. You began stealing whatever you could, getting bolder and bolder, until you were caught - not by guards, but by Cado\'s men, which was a lot worse. Instead of getting your legs broken, you were offered a job, which you eagerly accepted.\n\nThe Forty Thieves guild is a large and seemingly indefatigable network of thieves, smugglers, and other criminally inclined citizens. The guild operates in every town and traces its origin to the early days of the Empire. It is said that in the past, the forty kingpins of the forty largest towns used to coordinate the network. Opinions are divided as to the relations and ties of the Forty Thieves of yore and its current incarnation, but the name persists.\n\nIn Teron, the guild operates out of a local tavern - a popular destination for people who feel at home in dark alleys and the shadier parts of town. People like you.";
         text3 = "子供の頃、君は古き日の話を聞くのが大好きだった。人間と共に戦う神々、半神のごとき力を振るう魔術師、そして卑劣なクァンタリが呼び出した魔物達。だからチャンスが巡ってきたとき、君は地元の考古学者であるフォンに弟子入りをした。\n\n考古学者は常に必要とされている。未来から得られるものは少ないが、過去から得られるものは豊潤にして潤沢である。君はただどこを掘って何をするのかを知っていればいいだけだ。そして、そここそが考古学者の活躍できる場所である。彼らは技術を習得するために、廃墟を掘り返したり、古代の手稿を─しばしば内容を理解せずに─写し取ったり、戦前の知識の断片を売買したり、古そうに見えるものは何でも鑑定していた。魔術師が姿を消して久しいが、彼らが作った機械は未だに残っており、それを復活させる知識を持っている可能性があるのは考古学者たちだけだ。";
         text4 = "君はコンメルキウムのボスであるリノスの元で働いている。You make a living working for Linos, the head of the Commercium. Growing up in Teron, you often passed by the trading plaza where you\'d see the merchant\'s guild - the only building that wasn\'t falling apart, but stood proudly, displaying the power and confidence of its masters. From the first time you laid eyes on it, you knew that was where you wanted to be.\n\nThe Commercium isn\'t as old as the other guilds. It doesn\'t boast of an impressive lineage, but then again, it doesn\'t need to. It was an upstart, a new player that managed to do well when everything else was struggling to make ends meet. In a few decades, a small, but ambitious and ruthless trading company eliminated or absorbed everyone else in the trading game, becoming one of the most powerful guilds in the region.";
         text5 = "それでも、ダラタン家に仕えないかと申し入れを受けたとき、君はひざまずいて忠誠を誓い、認められたことと、己の身分には過ぎた地位を与えられたことに感謝した。アンティダス卿が立ち上がるよう命じ、君はゆっくりと身を起こすと、初めて頭を高く上げ、他の執政官達を同輩として見やる。そしてその使命と職責を実感し、圧倒されたのだった。";
         text6 = "君は丁度いいタイミングで地平線の向こうにテロンを見つける──水筒には、数滴の水しか残っていなかったのだ。君は長い間旅をしていて、人との接触も恋しくなっていたが、それでもテロンに数日居れば、なぜ自分が一つのところに長く滞在していないのかを思い出せるだろうと確信していた。";
         text7 = "君は数日前にテロンに到着した。君を迎えてくれたのは、磔にされた男たちの列──略奪者を遠ざけるための粗末なトーテムだった。なぜ誰も彼も略奪者になりたがるのか、君には理解できなかった。ただ頼んだだけで喜んで金を渡してくれるカモがいるのに、なぜ人を殺す必要がある？　もちろん、頼み方というものはある。だがその点においては君はいつだって達者だった。";
         text8 = "You arrived to Teron a few days ago. It greeted you with rows of crucified men that served as crude totems to keep the raiders away. Violence - your kind of language. You always were lucky when it came to killing folks, although a loremaster who did a reading claimed that you have a rare element of awesome in your blood, which kind of made sense to you. After all, you\'re clearly and undeniably awesome and other people just aren\'t.\n\nWhen people asked you where you served and what exactly it was that you were a veteran of, you ignored them, hoping to pass for the strong, silent type. The truth was that somehow you weren\'t entirely sure yourself. Perhaps it was your destiny that made you better than everyone else. You\'ve always known that you were meant for great things and it would be awfully inconvenient if you kept dying in every fight, wouldn\'t it?\n\nSo, you booked a room at a local inn hoping for a good night sleep. You were unfortunately awakened in the middle of the night by some ruckus. In a fit of rage, you stormed into a room next door and in the heat of an argument, you killed some trader, his bodyguard, and an assassin. The trader had a mysterious map on him and you were always a sucker for mystery. You grabbed it and went to the nearest loremaster.";
         text_id0 = "1";
         text_id1 = "2";
         text_id2 = "3";
         text_id3 = "4";
         text_id4 = "5";
         text_id5 = "6";
         text_id6 = "7";
         text_id7 = "8";
         text_id8 = "9";
         type = "1";
   };
};
//--- OBJECT WRITE END ---
