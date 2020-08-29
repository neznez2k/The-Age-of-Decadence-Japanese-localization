//hints
$CS_defaultHint = "画面のさまざまな部分にカーソルを合わせると、詳細な情報が表示されます。";
$CS_costHint = "このスキルを上げるためのスキルポイント（ＳＰ）の現在のコスト。ＳＰは、まずespecialized poolから消費され、次にgeneral poolから消費されます。";
$CS_generalSpHint = "General SP is earned by completing quests and advancing the story. Can be spent on any skill once the especialized pool is drained.";
$CS_combatSpHint = "Combat SP is earned by surviving fights and in some occasions by especial training. Can only be spent on combat skills.";
$CS_civilSpHint = "Civil SP is earned by finding non-combat solutions to problems, achieving important peaceful feats, and in some occasions by especial training. Can only be spent on non-combat skills.";

//misc
$char_scr_unspent_stat_points_title = "警告！";
$char_scr_unspent_stat_points_msg = "未使用のステータスポイントがあり、続行すると消滅します。\n本当にキャラクターの作成を完了しますか？";
$char_scr_no_combat_sp  = "<spush><color:ff0000>Remove <value> combat skill points.<spop>";
$char_scr_no_civil_sp   = "<spush><color:ff0000>Remove <value> civil skill points.<spop>";

$char_scr_hl_green = "<spush><color:45a053>";
$char_scr_hl_red = "<spush><color:f12d45>";
$char_scr_THC_breakdown = "<spush><color:e2cc67>Base THC (To-Hit Chance) formula is (Attack - Defense + 50%)<spop>";
$char_scr_CSC_breakdown = "<spush><color:e2cc67>Base CSC (Critical Strike Chance) formula is (CS - vsCS)<spop>";

//attack rating hint
$char_scr_attack_type = "<spush><color:ffffff>Current Attack:<spop> ";
$char_scr_attack_stat = "<spush><color:ffffff>Preferred Stat:<spop> ";
$char_scr_attack_breakdown = "<spush><color:ffffff>Attack Rating Breakdown:  <att_total>  (Skill Level x 10:  <att_skill>  + Stat Bonus:  <att_stat>  + Training:  <att_training>  + Synergy:  <att_synergy>  + Perception:  <att_per>  + Weapon:  <att_weap_thc>  + Helmet:  <att_helmet>  + Shield:  <att_shield>  + Penalty:  <att_penalty> )";
$char_scr_attack_tags = "<att_total> <att_skill> <att_stat> <att_training> <att_synergy> <att_per> <att_weap_thc> <att_helmet> <att_shield> <att_penalty>";
$char_scr_attack_positive_is_good = "1 1 1 1 1 1 1 0 0 0";

//defense rating hint
$char_scr_defense_type = "<spush><color:ffffff>Current Defense:<spop> ";
$char_scr_defense_stat = "<spush><color:ffffff>Preferred Stat:<spop> ";
$char_scr_defense_tags = "<def_total> <def_base> <def_skill> <def_stat> <def_con> <def_training> <def_armor> <def_penalty>";
$char_scr_defense_breakdown = "<spush><color:ffffff>Defense Rating Breakdown:  <def_total>  (Base:  <def_base>  + Skill Level x 10:  <def_skill>  + Stat Bonus:  <def_stat>  + Constitution Bonus:  <def_con>  + Training:  <def_training>  + Armor Penalty:  <def_armor>  + Other Penalty:  <def_penalty> )";
$char_scr_defense_positive_is_good = "1 1 1 1 1 1 0 0";

//critical rating hit
$char_scr_CS_tags = "<cs_total> <cs_skill> <cs_training> <cs_weap_upg> <cs_weap_bonus>";
$char_scr_CS_breakdown = "<spush><color:ffffff> Critical Strike Rating Breakdown:  <cs_total>  (Skill Level x 15:  <cs_skill>  + Training:  <cs_training>  + Weapon Upgrades:  <cs_weap_upg>  + CS Weapon Bonus:  <cs_weap_bonus>)";
$char_scr_CS_positive_is_good = "1 1 1 1 1";

//hints
$char_scr_tip0 = "<spush><color:ffffff>短剣<spop> -短剣は暗殺者の商売の象徴となっているが、それには理由がある。剣や斧よりも小さくて軽いが、短剣は精密な武器であり、相手の弱点に素早く致命的な攻撃を仕掛けるのに最適で、服の中へ忍ばせておくのも簡単だ。";
$char_scr_tip1 = "<spush><color:ffffff>剣<spop> -多くの者にとって、典型的な戦士の武器である。熟練の剣士が手にする万能な道具で、ケメットの鎌からアシュカーンで好まれる両手用の包丁まで、それぞれの文化で様々なデザインのものを見ることができる。"; 
$char_scr_tip2 = "<spush><color:ffffff>斧<spop> -斧を振り回す技術は、太古の昔からほとんど変わることがない。力、勢い、重量のある金属の楔を組み合わせ、肉、骨、そして盾さえも裂く。";
$char_scr_tip3 = "<spush><color:ffffff>ハンマー<spop> -知られている中で最も古い武器の一つであるハンマーは、単純な目的のために設計されている。敵を打ち、殺す。ハンマーによる強力な打撃は、屈強な男さえも圧倒させることで知られている。";
$char_scr_tip4 = "<spush><color:ffffff>槍<spop> -槍は、単純な観察から生まれた。─怪我をしない最良の方法は、相手の間合いに入らないことである。敵と距離を保てる素晴らしい武器ではあるが、操るのに十分な空間がなければ扱いにくくなる。";
$char_scr_tip5 = "<spush><color:ffffff>弓<spop> -射手を恐れずにいられるのは、巨大な盾を持っている戦士だけだ。彼らだけが、射手が送り込む夥しいほどの矢の雨を、その盾で防ぐことができる。弓を好む者は軽装であることが多いが、そこにつけ込めるほど彼らに近付くことのできる相手はほとんどいない。";
$char_scr_tip6 = "<spush><color:ffffff>クロスボウ<spop> -弓と同じように、クロスボウは強力な遠距離の武器だ。そして、弓ほどのスピードや正確さ、飛距離がない一方で、クロスボウは純粋な攻撃力でそれを補っている。近距離では、クロスボウのボルトは、驚くほど強力な攻撃を繰り出すことができる。";
$char_scr_tip7 = "<spush><color:ffffff>投擲<spop> -機構による支援のある同族に比べると、威力で見劣りするために見過ごされがちだが、投擲武器は射程の短さと威力の乏しさを、より優れたスピードと小回りの良さによって補っている。投擲武器に熟練した戦士は、ミサイルで敵に文字通りの集中攻撃をすることが可能だ。";
$char_scr_tip8 = "<spush><color:ffffff>回避<spop> -戦士は、敵の攻撃を吸収するために様々な種類の鎧を身につけるが、多くの者は、そもそも攻撃を避けられるならその方がいいと考えている。残念ながら、この問題はちょっとしたトレードオフになっていて、装備しているのが頑丈な鎧であればあるほど、攻撃を避けるのは難しい。そしてもう一つ特筆すべきは、相手の攻撃をかわすことができれば、相手はバランスを崩し、反撃をしやすくなるということだ。各々の攻撃はブロックか回避で対処することができるが、両方を同時に行うことはできない。そのため、多くの戦士はこれらの防御スキルから一つに集中させることを選んでいる。";
$char_scr_tip9 = "<spush><color:ffffff>ブロック<spop> -無知な者は、一般にブロックといえばただ自分と相手の武器の間に盾を置くことだと考えているが、真の達人は、ブロックとはつまりは攻撃をそらすことであり、盾の角度を変えて相手の武器をいなすことなのだと知っている。各々の攻撃はブロックか回避で対処することができるが、両方を同時に行うことはできない。そのため、多くの戦士はこれらの防御スキルから一つに集中させることを選んでいる。";
$char_scr_tip10 = "<spush><color:ffffff>クリティカル<spop> -戦闘においては、他の多くのものと同様、量よりも質が重要である。一度、敵の急所によく狙いを定めた攻撃をすることは、十数回の表面的な傷を負わせる攻撃に匹敵する。賢い戦士は、一撃ごとの効力を最大化することを学ぶものだ。";
$char_scr_tip11 = "<spush><color:ffffff>隠密<spop> -誰にも気付かれずに移動する技術。一般に公開されていない場所へ行くには非常に便利で手間のかからない方法だ。このスキルはロックピックと併せることで最も効果的に機能する。 "; 
$char_scr_tip12 = "<spush><color:ffffff>変装<spop> -仕草や外見を変えることで、異なる人格を作る技術。自分自身であるだけでは不十分な場合に便利だが、膨大な衣装のストックが必要になるかもしれない。"; 
$char_scr_tip13 = "<spush><color:ffffff>窃盗<spop> -取引のようなものだが、相手に何かを与えなければならないというデメリットはない。盗賊ギルドの掟は、窃盗を防ぐためにある法律よりも寛容ではないということは忘れない方がいいだろう。";
$char_scr_tip14 = "<spush><color:ffffff>ロックピック<spop> -正しい鍵を使わずに素早く効率的に鍵を開ける、いかがわしい技術。富の再分配に熱心な者にとっては、非常に便利なスキルだ。";
$char_scr_tip15 = "<spush><color:ffffff>トラップ<spop> -トラップに関する理論的な知識と実践適用。一流の専門家は、よくできたトラップは小さな不便をもたらすどころか、侵入者をたちまち殺すこともできるという認識を持っている。だから君が常習的に不法侵入をするつもりなら、まずトラップを検出し解除する方法を学んだ方がいいだろう。"; 
$char_scr_tip16 = "<spush><color:ffffff>説得<spop> -論法と個人的な魅力によって、自分の利益になるような行動を他人に取らせることができる洗練された技術。";
$char_scr_tip17 = "<spush><color:ffffff>礼儀作法<spop> -儀礼的に適切な振る舞いと、それを自分の利益のためにどうやって適用するかに関する理解。 ";
$char_scr_tip18 = "<spush><color:ffffff>渡世術<spop> -抜け目のなさから人間不信に至るまでと、様々な特性の混合であり、人と接する機会が多い場合に最も役に立つスキル。 ";
$char_scr_tip19 = "<spush><color:ffffff>考古学<spop> -遙か昔の出来事や、古代の言語、忘れ去られた儀式、そして、神秘的な物についての知識と理解。ポストアポカリプスの世界では、常に勝者となる。";
$char_scr_tip20 = "<spush><color:ffffff>クラフト<spop> -クラフトに熟練した者は自分で装備品を作り、改良する知識を持っている。良いアイテムを買ったり拾ったりすることもできるが、希少な鉱石から鍛造され調整された刃に勝るものはない。";
$char_scr_tip21 = "<spush><color:ffffff>取引<spop> -あらゆる交渉事に関する理論と理解。値切る技術という以上に、取引はそれに従事する者に金の力を示し、隠れた機会を露わにし、全ての物には価格があるのだと教えてくれる。";
$char_scr_tip22 = "<spush><color:ffffff>錬金術<spop> -ありふれた有機物や非有機物のエレメントを魔法のアイテムに変換する神秘の技術。癒やしの膏薬や金属を破壊するポーション、燃える液体や黒い粉の火球を生成する。マッドサイエンティスト必携のスキルだ！";

//synergy
$char_scr_synergy       = "<spush><color:ffffff>Synergy:<spop> For each point invested in <skill>, you get these attack bonuses:  ";
$char_scr_synergy_value = "<value> for <skill>";
$char_scr_synergy_color = "<spush><color:B063B0>";

//skill level
$char_scr_skill_level = "<spush><color:ffffff>Skill Level:<spop> ";
//skill: Dagger
$char_scr_skill0_level1    = " <spush><color:cc0000>[素人]<spop> 目を突いてしまう前にしまった方がいい。"; 
$char_scr_skill0_level2    = " <spush><color:cc4300>[見習い]<spop> You've learned to look menacing while holding a dagger. All you need is a good scowl."; 
$char_scr_skill0_level3    = " <spush><color:ffa800>[Journeyman]<spop> You've discovered that swinging your dagger wildly will only get you so far.";
$char_scr_skill0_level4    = " <spush><color:ffa800>[Journeyman]<spop> You've learned to hit targets. Most of the time. If they don't move.";
$char_scr_skill0_level5    = " <spush><color:ffcc00>[Proficient]<spop> You're getting the hang of it. Keep it up and you might become a good knife fighter one day."; 
$char_scr_skill0_level6    = " <spush><color:ffcc00>[Proficient]<spop> Better than average. And still alive. Better drink to that because the 'still alive' part might change without notice.";
$char_scr_skill0_level7    = " <spush><color:aeff00>[Adept]<spop> No one's laughing when you pull out a dagger now. They might not fear you yet, but no one is laughing.";
$char_scr_skill0_level8    = " <spush><color:aeff00>[Adept]<spop> You've become quite deadly with a dagger.";
$char_scr_skill0_level9    = " <spush><color:84ff00>[Expert]<spop> If you've unsheathed your blade, it's already too late to pray.";
$char_scr_skill0_level10   = " <spush><color:24ff00>[Master]<spop> You've mastered the art of knife fighting."; 

//skill: Sword
$char_scr_skill1_level1    = " <spush><color:cc0000>[Unskilled]<spop> You're fairly certain that you stab them with the pointy end.";
$char_scr_skill1_level2    = " <spush><color:cc4300>[Novice]<spop> You've added hacking and slashing to your repertoire of stabbing attacks.";
$char_scr_skill1_level3    = " <spush><color:ffa800>[Journeyman]<spop> You've discovered that swinging your sword wildly will only get you so far.";
$char_scr_skill1_level4    = " <spush><color:ffa800>[Journeyman]<spop> You've learned to hit targets. Most of the time. If they don't move.";
$char_scr_skill1_level5    = " <spush><color:ffcc00>[Proficient]<spop> You're getting the hang of it. Keep it up and you might become a good swordsman one day.";
$char_scr_skill1_level6    = " <spush><color:ffcc00>[Proficient]<spop> Better than average. And still alive. Better drink to that because the 'still alive' part might change without notice.";
$char_scr_skill1_level7    = " <spush><color:aeff00>[Adept]<spop> You're good with a sword. A lot of men died to make this dream a reality.";
$char_scr_skill1_level8    = " <spush><color:aeff00>[Adept]<spop> Your blade has become an extension of your arm.";
$char_scr_skill1_level9    = " <spush><color:84ff00>[Expert]<spop> If you've unsheathed your blade, it's already too late to pray.";
$char_scr_skill1_level10   = " <spush><color:24ff00>[Master]<spop> You've mastered the art of sword fighting.";

//skill: Axe
$char_scr_skill2_level1    = " <spush><color:cc0000>[Unskilled]<spop> Give it a swing. How hard can it be?";
$char_scr_skill2_level2    = " <spush><color:cc4300>[Novice]<spop> Your uncoordinated swipes throw you wildly off balance.";
$char_scr_skill2_level3    = " <spush><color:ffa800>[Journeyman]<spop> You've discovered that swinging your axe wildly will only get you so far.";
$char_scr_skill2_level4    = " <spush><color:ffa800>[Journeyman]<spop> If only they would stand still, eh?";
$char_scr_skill2_level5    = " <spush><color:ffcc00>[Proficient]<spop> Countless hours spent felling trees and men have helped to develop a fluid swing.";
$char_scr_skill2_level6    = " <spush><color:ffcc00>[Proficient]<spop> Your straightforward attacks are savage, but leave you wide open for a gutting.";
$char_scr_skill2_level7    = " <spush><color:aeff00>[Adept]<spop> Short, vicious chops cleave skulls and keep professional killers on their heels.";
$char_scr_skill2_level8    = " <spush><color:aeff00>[Adept]<spop> You welcome heavily armored prey. Few are quick enough to dodge, and the dead weight they carry offers scant protection from your axe blade.";
$char_scr_skill2_level9    = " <spush><color:84ff00>[Expert]<spop> The carnage you create with an axe is appalling. Blood spurts when shocked foes strike out at you with limbs they no longer possess.";
$char_scr_skill2_level10   = " <spush><color:24ff00>[Master]<spop> You've mastered the art of axe fighting.";

//skill: Hammer
$char_scr_skill3_level1    = " <spush><color:cc0000>[Unskilled]<spop> Give it a swing. How hard can it be?";
$char_scr_skill3_level2    = " <spush><color:cc4300>[Novice]<spop> Your uncoordinated swipes throw you wildly off balance.";
$char_scr_skill3_level3    = " <spush><color:ffa800>[Journeyman]<spop> You've discovered that swinging your hammer wildly will only get you so far.";
$char_scr_skill3_level4    = " <spush><color:ffa800>[Journeyman]<spop> If only they would stand still, eh?";
$char_scr_skill3_level5    = " <spush><color:ffcc00>[Proficient]<spop> Countless hours spent hammering on armor and shields have helped to develop a fluid swing.";
$char_scr_skill3_level6    = " <spush><color:ffcc00>[Proficient]<spop> Your straightforward attacks are savage, but leave you wide open for a gutting.";
$char_scr_skill3_level7    = " <spush><color:aeff00>[Adept]<spop> Short, vicious chops smash helmets and skulls and keep professional killers on their heels.";
$char_scr_skill3_level8    = " <spush><color:aeff00>[Adept]<spop> You welcome heavily armored prey. Few are quick enough to dodge, and the dead weight they carry offers scant protection from your doomhammer.";
$char_scr_skill3_level9    = " <spush><color:84ff00>[Expert]<spop> The trail of broken skulls and savagely dented metal you leave in your wake speaks of your skill.";
$char_scr_skill3_level10   = " <spush><color:24ff00>[Master]<spop> You've mastered the art of crushing skulls.";

//skill: Spear
$char_scr_skill4_level1    = " <spush><color:cc0000>[Unskilled]<spop> You cooked a chicken on a spit once...";
$char_scr_skill4_level2    = " <spush><color:cc4300>[Novice]<spop> Just keep it pointed at the enemy and you'll be fine.";
$char_scr_skill4_level3    = " <spush><color:ffa800>[Journeyman]<spop> Turns out, there is more than one way to poke someone with a spear.";
$char_scr_skill4_level4    = " <spush><color:ffa800>[Journeyman]<spop> You've discovered that hitting something with an 8-foot stick isn't as easy as it seems.";
$char_scr_skill4_level5    = " <spush><color:ffcc00>[Proficient]<spop> You're getting the hang of it. The trick is to keep 'em out of your personal space.";
$char_scr_skill4_level6    = " <spush><color:ffcc00>[Proficient]<spop> Better than average. And still alive. Better drink to that because the 'still alive' part might change without notice.";
$char_scr_skill4_level7    = " <spush><color:aeff00>[Adept]<spop> You've become quite deadly with a spear.";
$char_scr_skill4_level8    = " <spush><color:aeff00>[Adept]<spop> Your spear has become an extension of your arm. A frighteningly long extension.";
$char_scr_skill4_level9    = " <spush><color:84ff00>[Expert]<spop> You're a one-man hedgehog formation.";
$char_scr_skill4_level10   = " <spush><color:24ff00>[Master]<spop> They call you The Scorpion.";

//skill: Bow
$char_scr_skill5_level1    = " <spush><color:cc0000>[Unskilled]<spop> The string makes a funny noise when you pull it.";
$char_scr_skill5_level2    = " <spush><color:cc4300>[Novice]<spop> You're more likely to hurt your forearm than to hit the target.";
$char_scr_skill5_level3    = " <spush><color:ffa800>[Journeyman]<spop> You can hit a stationary target. At close range. If there is no wind.";
$char_scr_skill5_level4    = " <spush><color:ffa800>[Journeyman]<spop> You're getting better. With a bit of luck, you can even hit moving targets.";
$char_scr_skill5_level5    = " <spush><color:ffcc00>[Proficient]<spop> You're getting the hang of it. Keep it up and you might become a good archer one day.";
$char_scr_skill5_level6    = " <spush><color:ffcc00>[Proficient]<spop> Better than average. And still alive. Better drink to that because the 'still alive' part might change without notice.";
$char_scr_skill5_level7    = " <spush><color:aeff00>[Adept]<spop> Finally, your arrows are beginning to strike true. Better late than never.";
$char_scr_skill5_level8    = " <spush><color:aeff00>[Adept]<spop> Few archers can match your skill.";
$char_scr_skill5_level9    = " <spush><color:84ff00>[Expert]<spop> You can hit a sparrow in the eye from two hundred yards. Blindfolded.";
$char_scr_skill5_level10   = " <spush><color:24ff00>[Master]<spop> They call you The Eagle Eye.";

//skill: Crossbow
$char_scr_skill6_level1    = " <spush><color:cc0000>[Unskilled]<spop> Aim in the general direction and pull the trigger? Got it!";
$char_scr_skill6_level2    = " <spush><color:cc4300>[Novice]<spop> You've learned to look menacing while holding a crossbow. All you need is a good scowl.";
$char_scr_skill6_level3    = " <spush><color:ffa800>[Journeyman]<spop> You can hit a stationary target. At close range. If there is no wind.";
$char_scr_skill6_level4    = " <spush><color:ffa800>[Journeyman]<spop> You're getting better. With a bit of luck, you can even hit moving targets.";
$char_scr_skill6_level5    = " <spush><color:ffcc00>[Proficient]<spop> You're getting the hang of it. Keep it up and you might become a good crossbowman one day.";
$char_scr_skill6_level6    = " <spush><color:ffcc00>[Proficient]<spop> Better than average. And still alive. Better drink to that because the 'still alive' part might change without notice.";
$char_scr_skill6_level7    = " <spush><color:aeff00>[Adept]<spop> Finally, your bolts are beginning to strike true. Better late than never.";
$char_scr_skill6_level8    = " <spush><color:aeff00>[Adept]<spop> Few crossbowmens can match your skill.";
$char_scr_skill6_level9    = " <spush><color:84ff00>[Expert]<spop> You can hit a sparrow in the eye from two hundred yards. Blindfolded.";
$char_scr_skill6_level10   = " <spush><color:24ff00>[Master]<spop> They call you The Eagle Eye.";

//skill: Throwing
$char_scr_skill7_level1    = " <spush><color:cc0000>[Unskilled]<spop> No, it's not the same as dropping the weapon.";
$char_scr_skill7_level2    = " <spush><color:cc4300>[Novice]<spop> Just keep throwing. You're bound to hit something.";
$char_scr_skill7_level3    = " <spush><color:ffa800>[Journeyman]<spop> You can hit a tree 7 times out of 10.";
$char_scr_skill7_level4    = " <spush><color:ffa800>[Journeyman]<spop> You're getting better. Any circus would be glad to have you.";
$char_scr_skill7_level5    = " <spush><color:ffcc00>[Proficient]<spop> You're getting the hang of it. Keep it up and you might become a good knife thrower one day.";
$char_scr_skill7_level6    = " <spush><color:ffcc00>[Proficient]<spop> Better than average. And still alive. Better drink to that because the 'still alive' part might change without notice.";
$char_scr_skill7_level7    = " <spush><color:aeff00>[Adept]<spop> You've become quite deadly with... well, anything you can throw.";
$char_scr_skill7_level8    = " <spush><color:aeff00>[Adept]<spop> Your invitation to the House of Flying Daggers is in the mail.";
$char_scr_skill7_level9    = " <spush><color:84ff00>[Expert]<spop> You can hit a sparrow in the eye from ten yards. Blindfolded.";
$char_scr_skill7_level10   = " <spush><color:24ff00>[Master]<spop> You've mastered the fine art of killing people from a safe distance.";

//skill: Dodge
$char_scr_skill8_level1    = " <spush><color:cc0000>[Unskilled]<spop> A quick prayer is the best way to avoid being hit.";
$char_scr_skill8_level2    = " <spush><color:cc4300>[Novice]<spop> A prayer helps, but moving out of the harm's way tends to help a bit more.";
$char_scr_skill8_level3    = " <spush><color:ffa800>[Journeyman]<spop> It's just a jump to the left and then a step to the right.";
$char_scr_skill8_level4    = " <spush><color:ffa800>[Journeyman]<spop> Practice - if you can dodge a wrench, you can dodge a bolt!";
$char_scr_skill8_level5    = " <spush><color:ffcc00>[Proficient]<spop> You're getting the hang of it. Keep it up and you might live a bit longer than you thought.";
$char_scr_skill8_level6    = " <spush><color:ffcc00>[Proficient]<spop> Better than average. And still alive. Better drink to that because the 'still alive' part might change without notice.";
$char_scr_skill8_level7    = " <spush><color:aeff00>[Adept]<spop> You've finally learned to read the telltale signs of an incoming attack.";
$char_scr_skill8_level8    = " <spush><color:aeff00>[Adept]<spop> You flow like water and bend like a reed.";
$char_scr_skill8_level9    = " <spush><color:84ff00>[Expert]<spop> You've become almost impossible to hit.";
$char_scr_skill8_level10   = " <spush><color:24ff00>[Master]<spop> They call you The Artful Dodger.";

//skill: Block
$char_scr_skill9_level1    = " <spush><color:cc0000>[Unskilled]<spop> A quick prayer is the best way to avoid being hit.";
$char_scr_skill9_level2    = " <spush><color:cc4300>[Novice]<spop> A prayer helps, but raising a shield every once in a while tends to help a bit more.";
$char_scr_skill9_level3    = " <spush><color:ffa800>[Journeyman]<spop> Just keep the shield raised - you never know when someone might take a swing at you.";
$char_scr_skill9_level4    = " <spush><color:ffa800>[Journeyman]<spop> Practice makes perfect - strike and block, strike and block, shield's up, shield's down...";
$char_scr_skill9_level5    = " <spush><color:ffcc00>[Proficient]<spop> You're getting the hang of it. Keep it up and you might live a bit longer than you thought.";
$char_scr_skill9_level6    = " <spush><color:ffcc00>[Proficient]<spop> Better than average. And still alive. Better drink to that because the 'still alive' part might change without notice.";
$char_scr_skill9_level7    = " <spush><color:aeff00>[Adept]<spop> You've finally learned to read the telltale signs of an incoming attack.";
$char_scr_skill9_level8    = " <spush><color:aeff00>[Adept]<spop> You're a one man shieldwall.";
$char_scr_skill9_level9    = " <spush><color:84ff00>[Expert]<spop> You've become almost impossible to hit.";
$char_scr_skill9_level10   = " <spush><color:24ff00>[Master]<spop> You've mastered the art of hiding behind a wooden board strapped to your arm.";

//skill: Critical Strike
$char_scr_skill10_level1    = " <spush><color:cc0000>[Unskilled]<spop> You flail your weapon in the general direction of your enemies.";
$char_scr_skill10_level2    = " <spush><color:cc4300>[Novice]<spop> Keeping your eyes open while you attack seems to help.";
$char_scr_skill10_level3    = " <spush><color:ffa800>[Journeyman]<spop> Predominantly concerned with making contact, you target whatever your opponent gives you.";
$char_scr_skill10_level4    = " <spush><color:ffa800>[Journeyman]<spop> You've learned that it's more effective to stab their squishy parts.";
$char_scr_skill10_level5    = " <spush><color:ffcc00>[Proficient]<spop> Your victims would be better off if they refashioned their robes and light armor into bandages and tourniquets.";
$char_scr_skill10_level6    = " <spush><color:ffcc00>[Proficient]<spop> Recognizing that it's safer to kill the defenseless, you plan preemptive strikes while inquiring about the weather.";
$char_scr_skill10_level7    = " <spush><color:aeff00>[Adept]<spop> It is too hard to work your blade through metal and leather; you scrutinize your opponents' armor for weaknesses.";
$char_scr_skill10_level8    = " <spush><color:aeff00>[Adept]<spop> Through extensive experimentation, you have acquired a functional understanding of anatomy. Every attack you make is designed to cut tendons, sever arteries, or puncture organs.";
$char_scr_skill10_level9    = " <spush><color:84ff00>[Expert]<spop> Even the most exceptional armor has flaws that you perceive and can exploit, given the opportunity.";
$char_scr_skill10_level10   = " <spush><color:24ff00>[Master]<spop> Killing appears to be effortless for you. Your blade is drawn to the vitals of your victims.";

//skill: Sneak
$char_scr_skill11_level1    = " <spush><color:cc0000>[Unskilled]<spop> If you can't see them, they can't see you.";
$char_scr_skill11_level2    = " <spush><color:cc4300>[Novice]<spop> Move while they're not looking. Genius!";
$char_scr_skill11_level3    = " <spush><color:ffa800>[Journeyman]<spop> You've discovered that making noise is a dead giveaway. Dead giveaway.";
$char_scr_skill11_level4    = " <spush><color:ffa800>[Journeyman]<spop> You can stay still and be silent.";
$char_scr_skill11_level5    = " <spush><color:ffcc00>[Proficient]<spop> You're getting the hang of it. Keep it up and you might live a bit longer than you thought.";
$char_scr_skill11_level6    = " <spush><color:ffcc00>[Proficient]<spop> Better than average. And still alive. Better drink to that because the 'still alive' part might change without notice.";
$char_scr_skill11_level7    = " <spush><color:aeff00>[Adept]<spop> Most won't see you coming.";
$char_scr_skill11_level8    = " <spush><color:aeff00>[Adept]<spop> It'll take a trained eye to spot you.";
$char_scr_skill11_level9    = " <spush><color:84ff00>[Expert]<spop> You can actually Hide in Plain Sight now.";
$char_scr_skill11_level10   = " <spush><color:24ff00>[Master]<spop> You've mastered the art of getting into places with limited admission.";

//skill: Impersonate
$char_scr_skill12_level1    = " <spush><color:cc0000>[Unskilled]<spop> Disguise? That's what fools do during carnivals!";
$char_scr_skill12_level2    = " <spush><color:cc4300>[Novice]<spop> The neighbor's children really liked it when you pretended to be a bear.";
$char_scr_skill12_level3    = " <spush><color:ffa800>[Journeyman]<spop> A little acting can go a long way to convince people.";
$char_scr_skill12_level4    = " <spush><color:ffa800>[Journeyman]<spop> You've discovered that you have a talent for imitating accents and impersonating people.";
$char_scr_skill12_level5    = " <spush><color:ffcc00>[Proficient]<spop> You've realized that the devil is in the details - nobody likes a two-bit character.";
$char_scr_skill12_level6    = " <spush><color:ffcc00>[Proficient]<spop> It's more than disguise - it's a performance art.";
$char_scr_skill12_level7    = " <spush><color:aeff00>[Adept]<spop> You could fool your own mother, if you have time to prepare.";
$char_scr_skill12_level8    = " <spush><color:aeff00>[Adept]<spop> You can transform into any character at a moment's notice.";
$char_scr_skill12_level9    = " <spush><color:84ff00>[Expert]<spop> Being anyone, anytime, anywhere - that is true freedom.";
$char_scr_skill12_level10   = " <spush><color:24ff00>[Master]<spop> You've mastered the art of impersonating people.";

//skill: Stealing
$char_scr_skill13_level1    = " <spush><color:cc0000>[Unskilled]<spop> Maybe they shouldn't be looking while you're at it.";
$char_scr_skill13_level2    = " <spush><color:cc4300>[Novice]<spop> Ah, yes, move your fingers quickly. Who would have guessed?";
$char_scr_skill13_level3    = " <spush><color:ffa800>[Journeyman]<spop> Your style of thievery involves a lot of running away from guards.";
$char_scr_skill13_level4    = " <spush><color:ffa800>[Journeyman]<spop> You've realized that stealing people's stuff is much easier when they are somehow distracted.";
$char_scr_skill13_level5    = " <spush><color:ffcc00>[Proficient]<spop> You're getting the hang of it. Keep it up and you might actually become a good thief one day.";
$char_scr_skill13_level6    = " <spush><color:ffcc00>[Proficient]<spop> Better than average. And still alive. Better drink to that because the 'still alive' part might change without notice.";
$char_scr_skill13_level7    = " <spush><color:aeff00>[Adept]<spop> You've become adept at using the slightest distraction to deprive a mark of their valuables.";
$char_scr_skill13_level8    = " <spush><color:aeff00>[Adept]<spop> Rare is the thief whose fingers are as deft as yours.";
$char_scr_skill13_level9    = " <spush><color:84ff00>[Expert]<spop> It's as if other people's possessions magically appear in your hands.";
$char_scr_skill13_level10   = " <spush><color:24ff00>[Master]<spop> You've mastered the art of redistributing wealth.";

//skill: Lockpicking
$char_scr_skill14_level1    = " <spush><color:cc0000>[Unskilled]<spop> You used a rusty nail to break into a barn once. True story.";
$char_scr_skill14_level2    = " <spush><color:cc4300>[Novice]<spop> The best way to defeat a lock is to look for a spare key under rocks nearby.";
$char_scr_skill14_level3    = " <spush><color:ffa800>[Journeyman]<spop> You can easily open simple locks and doors left unlocked.";
$char_scr_skill14_level4    = " <spush><color:ffa800>[Journeyman]<spop> As your understanding of locks grows, so do your skills.";
$char_scr_skill14_level5    = " <spush><color:ffcc00>[Proficient]<spop> You're getting the hang of it. Keep it up and you might become a good locksmith one day.";
$char_scr_skill14_level6    = " <spush><color:ffcc00>[Proficient]<spop> You know the most common locking mechanisms and their weaknesses.";
$char_scr_skill14_level7    = " <spush><color:aeff00>[Adept]<spop> What one man locked, another can unlock. In theory.";
$char_scr_skill14_level8    = " <spush><color:aeff00>[Adept]<spop> Locks are a minor inconvenience to you.";
$char_scr_skill14_level9    = " <spush><color:84ff00>[Expert]<spop> Like pulling out a radish in wet weather. ";
$char_scr_skill14_level10   = " <spush><color:24ff00>[Master]<spop> If there is a lock that you can't open, you haven't seen it yet.";

//skill: Traps
$char_scr_skill15_level1    = " <spush><color:cc0000>[Unskilled]<spop> Your idea of a trap is a board with a nail in it.";
$char_scr_skill15_level2    = " <spush><color:cc4300>[Novice]<spop> You are good at finding traps. The hard way.";
$char_scr_skill15_level3    = " <spush><color:ffa800>[Journeyman]<spop> You've learned that there are different kinds of traps. You named your scars after them.";
$char_scr_skill15_level4    = " <spush><color:ffa800>[Journeyman]<spop> You can disarm 4 out of 10 traps. The other 6 traps will surely kill you, but you're a 'glass half full' kinda guy.";
$char_scr_skill15_level5    = " <spush><color:ffcc00>[Proficient]<spop> You're getting the hang of it. Keep it up and you might live a bit longer than you thought.";
$char_scr_skill15_level6    = " <spush><color:ffcc00>[Proficient]<spop> Better than average. And still alive. Better drink to that because the 'still alive' part might change without notice.";
$char_scr_skill15_level7    = " <spush><color:aeff00>[Adept]<spop> What one man armed, another can disarm. In theory.";
$char_scr_skill15_level8    = " <spush><color:aeff00>[Adept]<spop> You're getting pretty good at this trap thing.";
$char_scr_skill15_level9    = " <spush><color:84ff00>[Expert]<spop> When it comes to traps, you have a sixth sense.";
$char_scr_skill15_level10   = " <spush><color:24ff00>[Master]<spop> You can spot and disarm any trap.";

//skill: Persuasion
$char_scr_skill16_level1    = " <spush><color:cc0000>[Unskilled]<spop> You're able to communicate with other primates.";
$char_scr_skill16_level2    = " <spush><color:cc4300>[Novice]<spop> You've discovered that the primates respond better to well-chosen words.";
$char_scr_skill16_level3    = " <spush><color:ffa800>[Journeyman]<spop> You've learned to string words together for greater oratory effect.";
$char_scr_skill16_level4    = " <spush><color:ffa800>[Journeyman]<spop> You're learned how to convince those who want to believe you.";
$char_scr_skill16_level5    = " <spush><color:ffcc00>[Proficient]<spop> You've realized that Old Man Aesop was right: persuasion IS more effective than brute force.";
$char_scr_skill16_level6    = " <spush><color:ffcc00>[Proficient]<spop> You've finally figured out how to win friends and influence people.";
$char_scr_skill16_level7    = " <spush><color:aeff00>[Adept]<spop> You've realized that persuasion is merely a prerequisite to manipulation.";
$char_scr_skill16_level8    = " <spush><color:aeff00>[Adept]<spop> You will make a great 'used carts' salesman one day.";
$char_scr_skill16_level9    = " <spush><color:84ff00>[Expert]<spop> People are an open book to you and you can talk them into just about anything. ";
$char_scr_skill16_level10   = " <spush><color:24ff00>[Master]<spop> Your ability to influence minds is uncanny. Keep it up and they will burn you for witchcraft.";

//skill: Etiquette
$char_scr_skill17_level1    = " <spush><color:cc0000>[Unskilled]<spop> You can belch your own name, and regularly demonstrate this talent in company.";
$char_scr_skill17_level2    = " <spush><color:cc4300>[Novice]<spop> You cover your mouth when you sneeze. Most of the time.";
$char_scr_skill17_level3    = " <spush><color:ffa800>[Journeyman]<spop> Your habit of bathing more than once a month is considered rather decadent.";
$char_scr_skill17_level4    = " <spush><color:ffa800>[Journeyman]<spop> The brothel whores consider you to be quite fancy.";
$char_scr_skill17_level5    = " <spush><color:ffcc00>[Proficient]<spop> You're no longer a complete embarrassment to your friends.";
$char_scr_skill17_level6    = " <spush><color:ffcc00>[Proficient]<spop> You've almost figured out which fork you're supposed to start with.";
$char_scr_skill17_level7    = " <spush><color:aeff00>[Adept]<spop> You've definitely figured out the forks. The spoons are another story.";
$char_scr_skill17_level8    = " <spush><color:aeff00>[Adept]<spop> Upon greeting a landed equestrian, it is proper to doff your cap so.";
$char_scr_skill17_level9    = " <spush><color:84ff00>[Expert]<spop> You move among society's wealthy elite without embarrassment.";
$char_scr_skill17_level10   = " <spush><color:24ff00>[Master]<spop> You confidently participate in the most esoteric social rituals.";

//skill: Streetwise
$char_scr_skill18_level1    = " <spush><color:cc0000>[Unskilled]<spop> You have absolute faith in the goodness of your fellow man.";
$char_scr_skill18_level2    = " <spush><color:cc4300>[Novice]<spop> You're the proud owner of a new bridge.";
$char_scr_skill18_level3    = " <spush><color:ffa800>[Journeyman]<spop> You're sure they'll pay you back as soon as they're able to.";
$char_scr_skill18_level4    = " <spush><color:ffa800>[Journeyman]<spop> You're beginning to suspect that some folk are being less than honest with you.";
$char_scr_skill18_level5    = " <spush><color:ffcc00>[Proficient]<spop> Fool me once, shame on you. Fool me twice...well, the point is, you can't fool me, right?";
$char_scr_skill18_level6    = " <spush><color:ffcc00>[Proficient]<spop> It's not a lie if you believe it.";
$char_scr_skill18_level7    = " <spush><color:aeff00>[Adept]<spop> You've discovered that people respond best to lies they want to hear.";
$char_scr_skill18_level8    = " <spush><color:aeff00>[Adept]<spop> You've learned to play on people's fears, honor, ambitions, beliefs, and other useful qualities.";
$char_scr_skill18_level9    = " <spush><color:84ff00>[Expert]<spop> Some people turn water into wine, you turn lies into truth. Arguably, yours is a more useful talent.";
$char_scr_skill18_level10   = " <spush><color:24ff00>[Master]<spop> Your ability to manipulate people is uncanny. Keep it up and they will burn you for witchcraft.";

//skill: Lore
$char_scr_skill19_level1    = " <spush><color:cc0000>[Unskilled]<spop> You can write your own name.";
$char_scr_skill19_level2    = " <spush><color:cc4300>[Novice]<spop> You like looking through scrolls, especially the ones with drawings.";
$char_scr_skill19_level3    = " <spush><color:ffa800>[Journeyman]<spop> The key to being a loremaster is knowing that if it's old, it's probably valuable.";
$char_scr_skill19_level4    = " <spush><color:ffa800>[Journeyman]<spop> You've realized that knowledge is power. Your enthusiasm for learning has never been greater.";
$char_scr_skill19_level5    = " <spush><color:ffcc00>[Proficient]<spop> You're considering growing a beard. For stroking thoughtfully.";
$char_scr_skill19_level6    = " <spush><color:ffcc00>[Proficient]<spop> You've learned much about the past and what you've learned drives you to seek more.";
$char_scr_skill19_level7    = " <spush><color:aeff00>[Adept]<spop> You're a linguist, historian, forger, and mechanic. In short, you're a loremaster.";
$char_scr_skill19_level8    = " <spush><color:aeff00>[Adept]<spop> You've learned much: from steamworks to magick obscura.";
$char_scr_skill19_level9    = " <spush><color:84ff00>[Expert]<spop> You know... everything.";
$char_scr_skill19_level10   = " <spush><color:24ff00>[Master]<spop> You're wiser than men who think that they know everything, for you realize that you know nothing.";

//skill: Crafting
$char_scr_skill20_level1    = " <spush><color:cc0000>[Unskilled]<spop> A blacksmith could entrust you to operate the bellows.<br><br><spush><color:ffffff>Next Level Unlocks:<spop><color:EBEB00> Bronze working - Masterwork weapons and armors - Balanced weapons - Reinforced armors and shields - Sharpen Weapons.";
$char_scr_skill20_level2    = " <spush><color:cc4300>[Novice]<spop> Horseshoes! Bronze nails! Cheap!<br><br><spush><color:ffffff>Unlocks:<spop><color:47FF47> Bronze working - Masterwork weapons and armors - Balanced weapons - Reinforced armors and shields - Sharpen Weapons.<br><spush><color:ffffff>Next Level Unlocks:<spop><color:EBEB00> Masterwork Shields - Hardened edge - Serrated edge - Hardened armors and shields.";
$char_scr_skill20_level3    = " <spush><color:ffa800>[Journeyman]<spop> You can make a decent living fixing farmers' tools.<br><br><spush><color:ffffff>Unlocks:<spop><color:47FF47> Masterwork Shields - Hardened edge - Serrated edge - Hardened armors and shields.<br><spush><color:ffffff>Next Level Unlocks:<spop><color:EBEB00> Iron working - Lightened Shields - Two technique slots.<br><spush><color:ffffff>Next Level Improves:<spop><color:EBEB00> Masterwork weapons and armor - Balanced weapons - Reinforced armor and Shields - Sharpen Weapons.";
$char_scr_skill20_level4    = " <spush><color:ffa800>[Journeyman]<spop> You've unlocked the secrets of iron! Your enemies must be terrified.<br><br><spush><color:ffffff>Unlocks:<spop><color:47FF47> Iron working - Lightened Shields - Two technique slots.<br><spush><color:ffffff>Improves:<spop><color:47FF47> Masterwork weapons and armor - Balanced weapons - Reinforced armor and Shields - Sharpen Weapons.<br><spush><color:ffffff>Next Level Unlocks:<spop><color:EBEB00> Lightened Armors.<br><spush><color:ffffff>Next Level Improves:<spop><color:EBEB00> Masterwork Shields - Hardened edge - Serrated edge - Hardened armors and shields.";
$char_scr_skill20_level5    = " <spush><color:ffcc00>[Proficient]<spop> You're getting the hang of it. Keep it up and you might become a good smith one day.<br><br><spush><color:ffffff>Unlocks:<spop><color:47FF47> Lightened armor.<br><spush><color:ffffff>Improves:<spop><color:47FF47> Masterwork Shields - Hardened edge - Serrated edge - Hardened armors and shields.<br><spush><color:ffffff>Next Level Unlocks:<spop><color:EBEB00> Steel working.<br><spush><color:ffffff>Next Level Improves:<spop><color:EBEB00> Masterwork weapons and armor - Balanced weapons - Reinforced armor and Shields - Sharpen Weapons.";
$char_scr_skill20_level6    = " <spush><color:ffcc00>[Proficient]<spop> Steel - the noblest of metals - has surrendered its secrets to you. Great success!<br><br><spush><color:ffffff>Unlocks:<spop><color:47FF47> Steel working.<br><spush><color:ffffff>Improves:<spop><color:47FF47> Masterwork weapons and armor - Balanced weapons - Reinforced armor and Shields - Sharpen Weapons.<br><spush><color:ffffff>Next Level Improves:<spop><color:EBEB00> Masterwork Shields - Hardened edge - Serrated edge - Hardened armors and shields.";
$char_scr_skill20_level7    = " <spush><color:aeff00>[Adept]<spop> Few smiths are as good as you are.<br><br><spush><color:ffffff>Improves:<spop><color:47FF47> Masterwork Shields - Hardened edge - Serrated edge - Hardened armors and shields.<br><spush><color:ffffff>Next Level Unlocks:<spop><color:EBEB00> Blue steel working - Three technique slots.<br><spush><color:ffffff>Next Level Improves:<spop><color:EBEB00> Masterwork weapons and armor - Balanced weapons - Reinforced armor and Shields - Sharpen Weapons - Lightened Shields.";
$char_scr_skill20_level8    = " <spush><color:aeff00>[Adept]<spop> Forget about steel. Blue steel is where it's at and you've just figured out how to do it!<br><br><spush><color:ffffff>Unlocks:<spop><color:47FF47> Blue steel working - Three technique slots.<br><spush><color:ffffff>Improves:<spop><color:47FF47> Masterwork weapons and armor - Balanced weapons - Reinforced armor and Shields - Sharpen Weapons - Lightened Shields.<br><spush><color:ffffff>Next Level Improves:<spop><color:EBEB00> Masterwork Shields - Hardened edge - Serrated edge - Hardened armors and shields.";
$char_scr_skill20_level9    = " <spush><color:84ff00>[Expert]<spop> Your reputation as a smith precedes you.<br><br><spush><color:ffffff>Improves:<spop><color:47FF47> Masterwork Shields - Hardened edge - Serrated edge - Hardened armors and shields.<br><spush><color:ffffff>Next Level Unlocks:<spop><color:EBEB00> Sky metal working - Four technique slots.<br> <spush><color:ffffff>Next Level Improves:<spop><color:EBEB00> Masterwork weapons, shields and armor - Hardened Edge - Serrated Edge - Balanced weapons - Sharpen Weapons - Lightened armor and shields - Hardened armor and shields - Reinforced armor and shields.";
$char_scr_skill20_level10   = " <spush><color:24ff00>[Master]<spop> Your weapons are flawless. If on your journey, you should encounter God, God will be cut.<br><br><spush><color:ffffff>Unlocks:<spop><color:47FF47> Sky metal working - four technique slots.<br><spush><color:ffffff>Improves:<spop><color:47FF47> Masterwork weapons, shields and armor - Hardened Edge - Serrated Edge - Balanced weapons - Sharpen Weapons - Lightened armor and shields - Hardened armor and shields - Reinforced armor and shields.";

//skill: Trading
$char_scr_skill21_level1    = " <spush><color:cc0000>[Unskilled]<spop> You got a good deal on those magic beans. Really!<br><br><spush><color:ffffff>Abilities:<spop><spush><color:47FF47> Sells for 15% of value - Buys for 125% of value.<br><spop><spush><color:ffffff>Next Level Abilities:<spop><spush><color:EBEB00> Sells for 20% of value - Buys for 125% of value.";
$char_scr_skill21_level2    = " <spush><color:cc4300>[Novice]<spop> You're beginning to suspect that certain merchants may be exaggerating the value of their wares.<br><br><spush><color:ffffff>Abilities:<spop><spush><color:47FF47> Sells for 20% of value - Buys for 125% of value.<br><spop><spush><color:ffffff>Next Level Abilities:<spop><spush><color:EBEB00> Sells for 25% of value - Buys for 120% of value.";
$char_scr_skill21_level3    = " <spush><color:ffa800>[Journeyman]<spop> If it sounds too good to be true, it probably is.<br><br><spush><color:ffffff>Abilities:<spop><spush><color:47FF47> Sells for 25% of value - Buys for 120% of value.<br><spop><spush><color:ffffff>Next Level Abilities:<spop><spush><color:EBEB00> Sells for 30% of value - Buys for 120% of value.";
$char_scr_skill21_level4    = " <spush><color:ffa800>[Journeyman]<spop> Buy low, sell high, that's the trick.<br><br><spush><color:ffffff>Abilities:<spop><spush><color:47FF47> Sells for 30% of value - Buys for 120% of value.<br><spop><spush><color:ffffff>Next Level Abilities:<spop><spush><color:EBEB00> Sells for 35% of value - Buys for 115% of value.";
$char_scr_skill21_level5    = " <spush><color:ffcc00>[Proficient]<spop> You're a real merchant now. You've got the abacus and everything.<br><br><spush><color:ffffff>Abilities:<spop><spush><color:47FF47> Sells for 35% of value - Buys for 115% of value.<br><spop><spush><color:ffffff>Next Level Abilities:<spop><spush><color:EBEB00> Sells for 45% of value - Buys for 115% of value.";
$char_scr_skill21_level6    = " <spush><color:ffcc00>[Proficient]<spop> You've learned the trick of turning one gold piece into two. A subtle and powerful magic.<br><br><spush><color:ffffff>Abilities:<spop><spush><color:47FF47> Sells for 45% of value - Buys for 115% of value.<br><spop><spush><color:ffffff>Next Level Abilities:<spop><spush><color:EBEB00> Sells for 55% of value - Buys for 110% of value.";
$char_scr_skill21_level7    = " <spush><color:aeff00>[Adept]<spop> You've learned that people aren't really buying the goods, they're buying how the goods make them feel.<br><br><spush><color:ffffff>Abilities:<spop><spush><color:47FF47> Sells for 55% of value - Buys for 110% of value.<br><spop><spush><color:ffffff>Next Level Abilities:<spop><spush><color:EBEB00> Sells for 65% of value - Buys for 110% of value.";
$char_scr_skill21_level8    = " <spush><color:aeff00>[Adept]<spop> People check that their coin pouches are still attached to their belts when you smile.<br><br><spush><color:ffffff>Abilities:<spop><spush><color:47FF47> Sells for 65% of value - Buys for 110% of value.<br><spop><spush><color:ffffff>Next Level Abilities:<spop><spush><color:EBEB00> Sells for 75% of value - Buys for 105% of value.";
$char_scr_skill21_level9    = " <spush><color:84ff00>[Expert]<spop> They say that everything you touch turns to gold.<br><br><spush><color:ffffff>Abilities:<spop><spush><color:47FF47> Sells for 75% of value - Buys for 105% of value.<br><spop><spush><color:ffffff>Next Level Abilities:<spop><spush><color:EBEB00> Sells for 90% of value - Buys for 100% of value.";
$char_scr_skill21_level10   = " <spush><color:24ff00>[Master]<spop> Money is the lifeblood of the world. And you drink deeply.<br><br><spush><color:ffffff>Abilities:<spop><spush><color:47FF47> Sells for 90% of value - Buys for 100% of value.";

//skill: Alchemy
$char_scr_skill22_level1    = " <spush><color:cc0000>[Unskilled]<spop> You can tell salt by the taste alone.<br><br><spush><color:ffffff>Next Level Unlocks:<spop><color:EBEB00> Healing salve - Berserk potion - Poison vial.";
$char_scr_skill22_level2    = " <spush><color:cc4300>[Novice]<spop> When the mixture starts smoking, that's bad. Lesson learned.<br><br><spush><color:ffffff>Unlocks:<spop><color:47FF47> Healing salve - Berserk potion - Poison vial.<br><spush><color:ffffff>Next Level Unlocks:<spop><color:EBEB00> Liquid fire - Neurostimulant - Antidote.";
$char_scr_skill22_level3    = " <spush><color:ffa800>[Journeyman]<spop> Your allies fear your concoctions almost as much as your enemies.<br><br><spush><color:ffffff>Unlocks:<spop><color:47FF47> Liquid fire - Acid Vial - Neurostimulant - Antidote.<br><spush><color:ffffff>Next Level Unlocks:<spop><color:EBEB00> Restorative Liniment - Black Powder Bomb - Extended Neurostimulant.<br><spush><color:ffffff>Next Level Improves:<spop><color:EBEB00> Healing salve - Berserk potion - Poison.";
$char_scr_skill22_level4    = " <spush><color:ffa800>[Journeyman]<spop> Should your tongue be that colour?<br><br><spush><color:ffffff>Unlocks:<spop><color:47FF47> Restorative Liniment - Black Powder Bomb - Extended Neurostimulant.<br><spush><color:ffffff>Improves:<spop><color:47FF47> Healing salve - Berserk potion - Poison.<br><spush><color:ffffff>Next Level Unlocks:<spop><color:EBEB00> Extended berserk potion - Berserk Potion Hemostasis.<br><spush><color:ffffff>Next Level Improves:<spop><color:EBEB00> Neurostimulant - Acid Vial - Liquid fire.";
$char_scr_skill22_level5    = " <spush><color:ffcc00>[Proficient]<spop> You can't remember the last time you had eyebrows.<br><br><spush><color:ffffff>Unlocks:<spop><color:47FF47> Extended berserk potion - Berserk Potion Hemostasis.<br><spush><color:ffffff>Improves:<spop><color:47FF47> Neurostimulant - Acid Vial - Liquid fire.<br><spush><color:ffffff>Next Level Unlocks:<spop><color:EBEB00> Eagle Eye Neurostimulant - Splash Acid Vial - Strong liquid fire.<br><spush><color:ffffff>Next Level Improves:<spop><color:EBEB00> Healing salve - Restorative Liniment - Berserk potion - Poison vial.";
$char_scr_skill22_level6    = " <spush><color:ffcc00>[Proficient]<spop> The smell of sulphur's never coming out.<br><br><spush><color:ffffff>Unlocks:<spop><color:47FF47> Eagle Eye Neurostimulant - Splash Acid Vial - Strong liquid fire.<br><spush><color:ffffff>Improves:<spop><color:47FF47> Healing salve - Restorative Liniment - Berserk Potion - Poison Vial.<br><spush><color:ffffff>Next Level Unlocks:<spop><color:EBEB00> Black powder bomb frag - Regeneration potion.<br><spush><color:ffffff>Next Level Improves:<spop><color:EBEB00> Berserk Potion Hemostasis - Neurostimulant - Antidote - Acid vial - Liquid fire - Black powder bomb.";
$char_scr_skill22_level7    = " <spush><color:aeff00>[Adept]<spop> Healing potions make great hangover cures, you've discovered.<br><br><spush><color:ffffff>Unlocks:<spop><color:47FF47> Black powder bomb frag - Regeneration potion.<br><spush><color:ffffff>Improves:<spop><color:47FF47> Berserk Potion Hemostasis - Neurostimulant - Antidote - Acid vial - Liquid fire - Black powder bomb.<br><spush><color:ffffff>Next Level Unlocks:<spop><color:EBEB00> Burning liquid fire - Strong black powder bomb.<br><spush><color:ffffff>Next Level Improves:<spop><color:EBEB00> Healing salve - Restorative Liniment - Berserk potion - Extended Neurostimulant - Poison vial.";
$char_scr_skill22_level8    = " <spush><color:aeff00>[Adept]<spop> You've got a potion for any situation.<br><br><spush><color:ffffff>Unlocks:<spop><color:47FF47> Burning liquid fire - Strong black powder bomb.<br><spush><color:ffffff>Improves:<spop><color:47FF47> Healing salve - Restorative Liniment - Berserk potion - Extended Neurostimulant - Poison vial.<br><spush><color:ffffff>Next Level Unlocks:<spop><color:EBEB00> Strong Acid Vial - Potent poison vial.<br><spush><color:ffffff>Next Level Improves:<spop><color:EBEB00> Extended berserk potion - Neurostimulant - Liquid fire - Acid Vial - Black powder bomb frag.";
$char_scr_skill22_level9    = " <spush><color:84ff00>[Expert]<spop> Matter is your plaything, you bend it to your will.<br><br><spush><color:ffffff>Unlocks:<spop><color:47FF47> Strong Acid Vial - Potent poison vial.<br><spush><color:ffffff>Improves:<spop><color:47FF47> Extended berserk potion - Neurostimulant - Liquid fire - Acid Vial - Black powder bomb frag.<br><spush><color:ffffff>Next Level Improves:<spop><color:EBEB00> Healing salve - Restorative Liniment - Regeneration potion - Berserk potion - Berserk Potion Hemostasis - Neurostimulant - Eagle Eye Neurostimulant - Poison Vial - Acid Vial - Liquid fire - Black powder bomb.";
$char_scr_skill22_level10   = " <spush><color:24ff00>[Master]<spop> You start wondering why people refer to all the great scientists as mad. Must be jealousy.<br><br><spush><color:ffffff>Improves:<spop><color:47FF47> Healing salve - Restorative Liniment - Regeneration potion - Berserk potion - Berserk Potion Hemostasis - Neurostimulant - Eagle Eye Neurostimulant - Poison Vial - Acid Vial - Liquid fire - Black powder bomb.";

//abilities
$char_scr_abilities = "<spush><color:ffffff>Abilities: <spop> ";
$char_scr_abilities_color = "<spush><color:47FF47>";

//next level abilities
$char_scr_next_lvl_abilities = "<spush><color:ffffff>Next Level Abilities: <spop> ";
$char_scr_next_lvl_abilities_color = "<spush><color:EBEB00>";

$char_scr_skill0_abilities    = "<value>% higher chance of critical strike for aimed attack<spop>";
$char_scr_skill1_abilities    = "<value>% chance of causing bleeding - 3 damage for 2 turns<spop>";
$char_scr_skill2_abilities    = "<value>% increase in critical strike damage<spop>";
$char_scr_skill3_abilities    = "<value>% chance to dent opponent's armor by 2 DR<spop>";
$char_scr_skill4_abilities    = "<value>% chance to interrupt an opponent's attempt to get within melee range<spop>";
$char_scr_skill5_abilities    = "<value>% chance of causing slowdown - Increased movement cost <spop>";
$char_scr_skill6_abilities    = "<value>% chance to stagger your opponent - 3AP penalty<spop>";
$char_scr_skill7_abilities    = "<value>% chance to bypass armor<spop>";
$char_scr_skill8_abilities    = "<value>% chance to counter-attack after dodging a melee attack<spop>";
$char_scr_skill9_abilities    = "<value>% chance to block all damage, glancing it off your shield<spop>";
$char_scr_skill10_abilities   = "<value>% chance to cause bleeding on a critical strike<spop>";
$char_scr_skill11_abilities   = "<value>% increase in CS<spop>";
$char_scr_skill12_abilities   = "<value>% increase in CS<spop>";
$char_scr_skill13_abilities   = "<value>% increase in CS<spop>";
$char_scr_skill14_abilities   = "<value>% increase in CS<spop>";
$char_scr_skill15_abilities   = "<value>% increase in CS<spop>";
$char_scr_skill16_abilities   = "<value>% increase in CS<spop>";
$char_scr_skill17_abilities   = "<value>% increase in CS<spop>";
$char_scr_skill18_abilities   = "<value>% increase in CS<spop>";
$char_scr_skill19_abilities   = "<value>% increase in CS<spop>";
$char_scr_skill20_abilities   = "<value>% increase in CS<spop>";
$char_scr_skill21_abilities   = "<value>% increase in CS<spop>";
$char_scr_skill22_abilities   = "<value>% increase in CS<spop>";

$char_scr_stat_tip0 = "<spush><color:ffffff>Strength<spop> - Influences the Combat skill points' pool during character generation and determines damage modifiers and maximum carry weight. It is checked in dialogues and interactions with the gameworld.";
$char_scr_stat_tip1 = "<spush><color:ffffff>Dexterity<spop> - Influences the Combat skill points' pool during character generation and determines Action Points and sequence in combat. It is checked in dialogues and interactions with the gameworld.";
$char_scr_stat_tip2 = "<spush><color:ffffff>Constitution<spop> - Influences the Combat skill points' pool during character generation and determines your character's Hit Points and resistance to poison and other harmful substances (which will affect your ability to explore certain locations). It is checked in dialogues and interactions with the gameworld.";
$char_scr_stat_tip3 = "<spush><color:ffffff>Perception<spop> - Influences the Non-Combat skill points' pool during character generation, determines the accuracy modifiers for all weapons and range modifiers for ranged weapons, and helps you spot things which would remain hidden otherwise. It is checked in dialogues and interactions with the gameworld.";
$char_scr_stat_tip4 = "<spush><color:ffffff>Intelligence<spop> - Influences the Non-Combat skill points' pool during character generation and determines bonus skill points. It is checked in dialogues and interactions with the gameworld. The bonus skill points are added only to points earned by completing quests, not to points earned for killing enemies and passerby.";
$char_scr_stat_tip5 = "<spush><color:ffffff>Charisma<spop> - Influences the Non-Combat skill points' pool during character generation and determines reaction and reputation modifiers. It is frequently checked in dialogues.";

$char_scr_rep_tip0 = "かつては７つの州と２０以上の軍団を支配し、最も規模の大きく影響力のあった貴族の家であるダラタン家は戦争中にほとんど破壊された。今日では、ダラタン家に仕える者は１００人にも満たず、疑いようもなく良き日を見てきたテロンという名の小さな町を支配している。内部の者の中には最後のあえぎを絞り出すかのように、いかなる犠牲を払ってでも権力のバランスを変えて高貴な家を復活させるために、最後の戦いに向けて備えている者もいる。";
$char_scr_rep_tip1 = "アウレリアン家の主な軍隊は戦争の間、遠く離れた植民地で最も激しく血にまみれた戦場から離れ、秩序を維持していた。世界が壊滅し社会が混沌とする中で、ガエリウス将軍は最も戦略的な要塞や町を強固に支配するために迅速に動いた。今日、アウレリアン家は、古い要塞の周りに建てられた町マードランの残骸の７０％を支配し、彼らに有利なパワーバランスを保つためにあらゆる努力をしている。こうしたアウレリアン家の現在の地位に対して、他の家は恨みを抱いている。";
$char_scr_rep_tip2 = "戦争や政治から手を引いたクラッスス家は、科学と神秘の研究、特に存在の次元の研究に専念していた。その結果、彼らはポータルとその動力源となる多くの機械を構築し、召喚の分野に貢献した。末期にはほとんどの魔道士が死に、この家からは知恵と研究、明晰さを担う者たちが奪われた。今日では、クラッスス家は適切な崇拝と神々の復古を呼び掛けている。";
$char_scr_rep_tip3 = "帝国軍の残党から結成された帝国衛兵は、独立した影響力のある強力な勢力であり、秩序を維持し、貴族間の戦争が起きるのを防いでいる。貴族の家が策謀、諜報、防謀で小競り合いをしている一方で、この衛兵たちはそれよりも理想主義的である。彼らの一番重要な目的は、帝国にかつての栄光を取り戻すことだ。それが今の世界ではどれだけ現実離れして見えようとも。";
$char_scr_rep_tip4 = "四十盗賊ギルドは盗賊と密輸業者、その他犯罪傾向のある市民たちの大規模で疲れを知らないように見える巨大なネットワークで、あらゆる町で活動しており、その起源を帝国初期にまでさかのぼる。かつては４０の大都市の４０の中心人物がそのネットワークをまとめていたとも言われている。往年の四十盗賊と現在の形の四十盗賊との関係や繋がりについては諸説あるが、その名は今も残っている。";
$char_scr_rep_tip5 = "交易と商人のギルドは常に存在してきたが、剣の力によってもたらされた災厄の影で、金の力は国事に対してはるかに大きい影響力を持つようになった。主要な商人は今や全ての交易を総括し、管理している。キャラバン、関税、鉱山、そして市場はコンメルキウムの恩恵のみで運営されている。前哨地や辺境の村では独立している商人は今も存在しているが、町での交易に危険や問題がないわけではない。";
$char_scr_rep_tip6 = "帝国の黎明期には、皇帝直属の衛兵がいた。彼らは皇帝を守るという本来の任務とは別に、潜入と暗殺のエキスパートとして訓練されていた。 多くの政治的、軍事的な敵対者たちが夜の狂喜の中の死や、説明のつかない不幸に遭遇し、帝国の長年にわたる安定を確保した。帝国の崩壊後、仕える主がいないため、衛兵たちは滅びた帝国の混沌へと散っていった。  外の世界に出ると、世界が荒廃していても、彼らの平和維持活動には大きな需要があった。 暗殺教団が設立され、後にその一群は誉れ高き名を帯びることになる。「ステュクスの漕手」と。";
$char_scr_rep_tip7 = "<spush><color:ffffff>Body count<spop> - Tells everyone how many people that crossed your path ended up dead and shows that you aren't squeamish when it comes to killing.";
$char_scr_rep_tip8 = "<spush><color:ffffff>Combat<spop> - It's not about how many lives you've taken, it's about how many times you've gone up against impossible odds and lived to tell the tale. It's the real deal.";
$char_scr_rep_tip9 = "<spush><color:ffffff>Peacemaker<spop> - It tells people that you prefer to seek peaceful solutions. Some people may find it very reassuring.";
$char_scr_rep_tip10 = "<spush><color:ffffff>Loyalty<spop> - Measures your loyalty and whether or not you're the type who goes down with the ship or jumps it like a rat. Then again, some opportunities simply can't be missed.";
$char_scr_rep_tip11 = "<spush><color:ffffff>Prestige<spop> - Measures your fame and influence. Are you an adventurer of great renown? An ambitious up-and-comer? Do you command respect? This stat will tell you (and other people who might be paying attention).";
$char_scr_rep_tip12 = "<spush><color:ffffff>Word of Honor<spop> - Measures how well you keep your word once it's given. Some people might trust you more if your word is your bond.";

$char_scr_bg_tip0 = "<spush><color:ffffff>暗殺者<spop>─外交が失敗すると、暗殺はしばしば唯一の手段となる。紛争を最小限の流血で解決する能力で名高く尊敬されている暗殺者は、社会のあらゆる階層で高い需要がある。流される原因が些細な争いであろうと国の問題であろうと、血は血である。";
$char_scr_bg_tip1 = "<spush><color:ffffff>盗賊<spop>─社会の構造に関係なく、法の外で自らの行動規範に従って生きることを好む者は常に存在する。盗賊にとって、荒廃した世界はチャンスの世界である。権力を求める者たちが欺かれ財を奪われる一方で、盗賊たちは彼らが粗末に扱う富からかなりの利益を得ている。";
$char_scr_bg_tip2 = "<spush><color:ffffff>執政官<spop>─貴族の家は自分たちの利益のために奉仕する有望な人材を常に探しており、多様な技能を持った野心的な者を側仕えに昇格させている。多くの者はある程度の武術を身につけ、流血の栄光と利得を辛抱強く待つが、一方でより穏やかな外交術を好み、貴族の宮廷では目立たないが大きな役割を果たす者もいる。";
$char_scr_bg_tip3 = "<spush><color:ffffff>考古学者<spop>─戦前の知識や技術を保存し、理解することは儲かるビジネスである。人々は過去の灰の中に救いを見いだすようになり、市場は古い帝国の物で溢れかえっているが、そのほとんどは実際には何の価値もない。 常に価値のある物を探し、商品を分類し鑑定する、考古学者はこの取引の最前線に立っている。";
$char_scr_bg_tip4 = "<spush><color:ffffff>詐欺師<spop>─多くの盗賊は徒党を組み暗闇の中で行動することを好むが、詐欺師にはギルドの掟のために社会の法と取引する理由はない。彼らは個人的な魅力と説得力を駆使して騙されやすい人間を食い物にしており、この詐欺師の技が見破られることはめったにない。";
$char_scr_bg_tip5 = "<spush><color:ffffff>放浪者<spop>─ほとんどの人間にとっては、何かに属し、自分のものと言える場所を持つことに焦点が置かれるが、放浪者はそのような感情を示すことはない。自由を何よりも重んじ、誰にも仕えず、その代わりに何の枷もなくひと所に留まらずに自由に動き回ることを好む。";
$char_scr_bg_tip6 = "<spush><color:ffffff>傭兵<spop>─争いが絶えない世界では、武術に長けた者には仕事がいくらでもある。傭兵のほとんどは個人の客と私的に契約を結んでいるが、貴族の家の大きな陰謀に巻き込まれることもある。金次第である彼らの忠誠は、最高額を入札した者に置かれる。";
$char_scr_bg_tip7 = "<spush><color:ffffff>商人<spop>─あらゆる貴族の権力と領地をめぐる争いの裏には、尊敬され恐れられた商人の金がある。商人は単なる物売り以上に、市場全体とそれに依存する者を操作している。人、情報、親切な行為には価格があるが、その真の価値を知っているのは商人だけである。";

$char_scr_misc_tip0 = "性別はステータスには影響しません。会話において異なる選択が可能になることがあります。";
$char_scr_misc_tip1 = "初期のスキルポイント（ＳＰ）はステータスの配分によって異なります。STR、DEX、CONは戦闘ＳＰを増加させ、PER、INT、CHAは日常ＳＰを増加させます。ゲームを開始した後は、クエストを完了したり敵を倒したりすることでＳＰを得ることができます。INTが高いと得られるＳＰの量が多くなります。";
$char_scr_misc_tip2 = "Stat points can only be distributed among attributes at character generation. Critical strikes may cause wounds that reduce your physical attribute stats; visiting a healer allows you to restore them to normal.";
$char_scr_misc_tip3 = "Your background is not a Character Class. It doesn't affect skill values or character progression. Your background affects your intial standing with various factions and will determine how your adventure begins. It is also checked in dialogues.";
$char_scr_misc_tip4 = "<spush><color:ffffff>Weapon Synergy<spop> - Increasing one weapon skill gives various bonuses to all other weapon skills, reflecting your growing combat skills and experience. The numbers show the total amount of SP added to each skill through synergy effects.";