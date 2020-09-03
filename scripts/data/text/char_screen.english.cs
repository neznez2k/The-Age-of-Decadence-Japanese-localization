//hints
$CS_defaultHint = "画面のさまざまな部分にカーソルを合わせると、詳細な情報が表示されます。";
$CS_costHint = "このスキルを上げるためのスキルポイント（ＳＰ）の現在のコスト。ＳＰは、まず専用ポイントから消費され、次に汎用ポイントが消費されます。";
$CS_generalSpHint = "汎用SPは、クエストをクリアしたり、ストーリーを進めることで獲得できます。全てのスキルに使用することができ、専用SPがなくなった後に消費されます。";
$CS_combatSpHint = "戦闘SPは、戦いを生き抜くことで獲得でき、場合によっては特別な訓練を受けることでも獲得できます。戦闘スキルにのみ使用できます。";
$CS_civilSpHint = "日常SPは、問題に対して非戦闘的な解決法を見つけたり、重要かつ平和的な偉業を成し遂げたり、場合によっては特別な訓練を受けることで獲得できます。非戦闘スキルにのみ使用できます。";

//misc
$char_scr_unspent_stat_points_title = "警告！";
$char_scr_unspent_stat_points_msg = "未使用のステータスポイントがあり、続行すると消滅します。\n本当にキャラクターの作成を完了しますか？";
$char_scr_no_combat_sp  = "<spush><color:ff0000>Remove <value> combat skill points.<spop>";
$char_scr_no_civil_sp   = "<spush><color:ff0000>Remove <value> civil skill points.<spop>";

$char_scr_hl_green = "<spush><color:45a053>";
$char_scr_hl_red = "<spush><color:f12d45>";
$char_scr_THC_breakdown = "<spush><color:e2cc67>基本THC（命中率）の計算式：攻撃－防御＋50%<spop>";
$char_scr_CSC_breakdown = "<spush><color:e2cc67>基本CSC（クリティカル率）の計算式：クリティカル率－クリティカル抵抗<spop>";

//attack rating hint
$char_scr_attack_type = "<spush><color:ffffff>現在の攻撃：　<spop> ";
$char_scr_attack_stat = "<spush><color:ffffff>推奨ステータス：　<spop> ";
$char_scr_attack_breakdown = "<spush><color:ffffff>攻撃点数の内訳：　<att_total>  （スキルレベル×10： <att_skill>  ＋ステータスボーナス： <att_stat>  ＋訓練： <att_training>  ＋シナジー： <att_synergy>  ＋知覚： <att_per>  ＋武器： <att_weap_thc>  ＋ヘルメット： <att_helmet>  ＋盾： <att_shield>  ＋ペナルティー： <att_penalty> ）";
$char_scr_attack_tags = "<att_total> <att_skill> <att_stat> <att_training> <att_synergy> <att_per> <att_weap_thc> <att_helmet> <att_shield> <att_penalty>";
$char_scr_attack_positive_is_good = "1 1 1 1 1 1 1 0 0 0";

//defense rating hint
$char_scr_defense_type = "<spush><color:ffffff>現在の防御：　<spop> ";
$char_scr_defense_stat = "<spush><color:ffffff>推奨ステータス：　<spop> ";
$char_scr_defense_tags = "<def_total> <def_base> <def_skill> <def_stat> <def_con> <def_training> <def_armor> <def_penalty>";
$char_scr_defense_breakdown = "<spush><color:ffffff>防御点数の内訳：　<def_total>  （基本ポイント： <def_base>  ＋スキルレベル×10： <def_skill>  ＋ステータスボーナス： <def_stat>  ＋体力ボーナス： <def_con>  ＋訓練： <def_training>  ＋アーマーペナルティ： <def_armor>  ＋その他ペナルティ： <def_penalty> ）";
$char_scr_defense_positive_is_good = "1 1 1 1 1 1 0 0";

//critical rating hit
$char_scr_CS_tags = "<cs_total> <cs_skill> <cs_training> <cs_weap_upg> <cs_weap_bonus>";
$char_scr_CS_breakdown = "<spush><color:ffffff> クリティカル点数の内訳：　<cs_total>  (スキルレベル×15： <cs_skill>  ＋訓練： <cs_training>  ＋武器のアップグレード： <cs_weap_upg>  ＋CS武器ボーナス： <cs_weap_bonus> ）";
$char_scr_CS_positive_is_good = "1 1 1 1 1";

//hints
$char_scr_tip0 = "<spush><color:ffffff>短剣<spop>-短剣は暗殺者の商売の象徴となっているが、それには理由がある。剣や斧よりも小さくて軽いが、短剣は精密な武器であり、相手の弱点に素早く致命的な攻撃を仕掛けるのに最適で、服の中へ忍ばせておくのも簡単だ。";
$char_scr_tip1 = "<spush><color:ffffff>剣<spop>-多くの者にとって、典型的な戦士の武器である。熟練の剣士が手にする万能な道具で、ケメットの鎌からアシュカーンで好まれる両手用の包丁まで、それぞれの文化で様々なデザインのものを見ることができる。"; 
$char_scr_tip2 = "<spush><color:ffffff>斧<spop>-斧を振り回す技術は、太古の昔からほとんど変わることがない。力、勢い、重量のある金属の楔を組み合わせ、肉、骨、そして盾さえも裂く。";
$char_scr_tip3 = "<spush><color:ffffff>ハンマー<spop>-知られている中で最も古い武器の一つであるハンマーは、単純な目的のために設計されている。敵を打ち、殺す。ハンマーによる強力な打撃は、屈強な男さえも圧倒させることで知られている。";
$char_scr_tip4 = "<spush><color:ffffff>槍<spop>-槍は、単純な観察から生まれた。─怪我をしない最良の方法は、相手の間合いに入らないことである。敵と距離を保てる素晴らしい武器ではあるが、操るのに十分な空間がなければ扱いにくくなる。";
$char_scr_tip5 = "<spush><color:ffffff>弓<spop>-射手を恐れずにいられるのは、巨大な盾を持っている戦士だけだ。彼らだけが、射手が送り込む夥しいほどの矢の雨を、その盾で防ぐことができる。弓を好む者は軽装であることが多いが、そこにつけ込めるほど彼らに近付くことのできる相手はほとんどいない。";
$char_scr_tip6 = "<spush><color:ffffff>クロスボウ<spop>-弓と同じように、クロスボウは強力な遠距離の武器だ。そして、弓ほどのスピードや正確さ、飛距離がない一方で、クロスボウは純粋な攻撃力でそれを補っている。近距離では、クロスボウのボルトは、驚くほど強力な攻撃を繰り出すことができる。";
$char_scr_tip7 = "<spush><color:ffffff>投擲<spop>-機構による支援のある同族に比べると、威力で見劣りするために見過ごされがちだが、投擲武器は射程の短さと威力の乏しさを、より優れたスピードと小回りの良さによって補っている。投擲武器に熟練した戦士は、ミサイルで敵に文字通りの集中攻撃をすることが可能だ。";
$char_scr_tip8 = "<spush><color:ffffff>回避<spop>-戦士は、敵の攻撃を吸収するために様々な種類の鎧を身につけるが、多くの者は、そもそも攻撃を避けられるならその方がいいと考えている。残念ながら、この問題はちょっとしたトレードオフになっていて、装備しているのが頑丈な鎧であればあるほど、攻撃を避けるのは難しい。そしてもう一つ特筆すべきは、相手の攻撃をかわすことができれば、相手はバランスを崩し、反撃をしやすくなるということだ。各々の攻撃はブロックか回避で対処することができるが、両方を同時に行うことはできない。そのため、多くの戦士はこれらの防御スキルから一つに集中させることを選んでいる。";
$char_scr_tip9 = "<spush><color:ffffff>ブロック<spop>-無知な者は、一般にブロックといえばただ自分と相手の武器の間に盾を置くことだと考えているが、真の達人は、ブロックとはつまりは攻撃をそらすことであり、盾の角度を変えて相手の武器をいなすことなのだと知っている。各々の攻撃はブロックか回避で対処することができるが、両方を同時に行うことはできない。そのため、多くの戦士はこれらの防御スキルから一つに集中させることを選んでいる。";
$char_scr_tip10 = "<spush><color:ffffff>クリティカルストライク<spop>-戦闘においては、他の多くのものと同様、量よりも質が重要である。一度、敵の急所によく狙いを定めた攻撃をすることは、十数回の表面的な傷を負わせる攻撃に匹敵する。賢い戦士は、一撃ごとの効力を最大化することを学ぶものだ。";
$char_scr_tip11 = "<spush><color:ffffff>隠密<spop>-誰にも気付かれずに移動する技術。一般に公開されていない場所へ行くには非常に便利で手間のかからない方法だ。このスキルはロックピックと併せることで最も効果的に機能する。 "; 
$char_scr_tip12 = "<spush><color:ffffff>変装<spop>-仕草や外見を変えることで、異なる人格を作る技術。自分自身であるだけでは不十分な場合に便利だが、膨大な衣装のストックが必要になるかもしれない。"; 
$char_scr_tip13 = "<spush><color:ffffff>窃盗<spop>-取引のようなものだが、相手に何かを与えなければならないというデメリットはない。盗賊ギルドの掟は、窃盗を防ぐためにある法律よりも寛容ではないということは忘れない方がいいだろう。";
$char_scr_tip14 = "<spush><color:ffffff>ロックピック<spop>-正しい鍵を使わずに素早く効率的に鍵を開ける、いかがわしい技術。富の再分配に熱心な者にとっては、非常に便利なスキルだ。";
$char_scr_tip15 = "<spush><color:ffffff>トラップ<spop>-トラップに関する理論的な知識と実践適用。一流の専門家は、よくできたトラップは小さな不便をもたらすどころか、侵入者をたちまち殺すこともできるという認識を持っている。だから君が常習的に不法侵入をするつもりなら、まずトラップを検出し解除する方法を学んだ方がいいだろう。"; 
$char_scr_tip16 = "<spush><color:ffffff>説得<spop>-論法と個人的な魅力によって、自分の利益になるような行動を他人に取らせることができる洗練された技術。";
$char_scr_tip17 = "<spush><color:ffffff>礼儀作法<spop>-儀礼的に適切な振る舞いと、それを自分の利益のためにどうやって適用するかに関する理解。 ";
$char_scr_tip18 = "<spush><color:ffffff>渡世術<spop>-抜け目のなさから人間不信に至るまでと、様々な特性の混合であり、人と接する機会が多い場合に最も役に立つスキル。 ";
$char_scr_tip19 = "<spush><color:ffffff>考古学<spop>-遙か昔の出来事や、古代の言語、忘れ去られた儀式、そして、神秘的な物についての知識と理解。ポストアポカリプスの世界では、常に勝者となる。";
$char_scr_tip20 = "<spush><color:ffffff>クラフト<spop>-クラフトに熟練した者は自分で装備品を作り、改良する知識を持っている。良いアイテムを買ったり拾ったりすることもできるが、希少な鉱石から鍛造され調整された刃に勝るものはない。";
$char_scr_tip21 = "<spush><color:ffffff>取引<spop>-あらゆる交渉事に関する理論と理解。値切る技術という以上に、取引はそれに従事する者に金の力を示し、隠れた機会を露わにし、全ての物には価格があるのだと教えてくれる。";
$char_scr_tip22 = "<spush><color:ffffff>錬金術<spop>-ありふれた有機物や非有機物のエレメントを魔法のアイテムに変換する神秘の技術。癒やしの膏薬や金属を破壊するポーション、燃える液体や黒い粉の火球を生成する。マッドサイエンティスト必携のスキルだ！";

//synergy
$char_scr_synergy       = "<spush><color:ffffff>シナジー:<spop> <skill> にポイントを注ぎ込むごとに、次の攻撃ボーナスを得る:  ";
$char_scr_synergy_value = "<skill> に <value>";
$char_scr_synergy_color = "<spush><color:B063B0>";

//skill level
$char_scr_skill_level = "<spush><color:ffffff>習熟度:<spop> ";
//skill: Dagger
$char_scr_skill0_level1    = " <spush><color:cc0000>[素人]<spop> 目を突いてしまう前にしまった方がいい。"; 
$char_scr_skill0_level2    = " <spush><color:cc4300>[見習い]<spop> 短剣を握っている間は強そうに見えるようになった。ただ相手を睨み付けていればいい。"; 
$char_scr_skill0_level3    = " <spush><color:ffa800>[一人前]<spop> 短剣を乱暴に振り回すだけでは限界があることに気付いた。";
$char_scr_skill0_level4    = " <spush><color:ffa800>[一人前]<spop> 標的に攻撃を当てることを学んだ。ほとんどの場合で。相手が動かなければ。";
$char_scr_skill0_level5    = " <spush><color:ffcc00>[上級者]<spop> コツをつかんできた。この調子なら、いつか良いナイフ使いになれるかもしれない。"; 
$char_scr_skill0_level6    = " <spush><color:ffcc00>[上級者]<spop> 平均よりはマシだ。そしてまだ生きている。「まだ生きている」の部分は、予告なく変わる可能性があるということを肝に命じた方がいいだろう。";
$char_scr_skill0_level7    = " <spush><color:aeff00>[名人]<spop> No one's laughing when you pull out a dagger now. They might not fear you yet, but no one is laughing.";
$char_scr_skill0_level8    = " <spush><color:aeff00>[名人]<spop> You've become quite deadly with a dagger.";
$char_scr_skill0_level9    = " <spush><color:84ff00>[達人]<spop> If you've unsheathed your blade, it's already too late to pray.";
$char_scr_skill0_level10   = " <spush><color:24ff00>[マスター]<spop> You've mastered the art of knife fighting."; 

//skill: Sword
$char_scr_skill1_level1    = " <spush><color:cc0000>[素人]<spop> まあ、尖っている先の方で突き刺すということはわかっているみたいだ。";
$char_scr_skill1_level2    = " <spush><color:cc4300>[見習い]<spop> 突き刺し攻撃に加えて、滅多切りと切り下ろしがレパートリーに加わった。";
$char_scr_skill1_level3    = " <spush><color:ffa800>[一人前]<spop> 剣を乱暴に振り回すだけでは限界があることに気付いた。";
$char_scr_skill1_level4    = " <spush><color:ffa800>[一人前]<spop> 標的に攻撃を当てることを学んだ。ほとんどの場合で。相手が動かなければ。";
$char_scr_skill1_level5    = " <spush><color:ffcc00>[上級者]<spop> コツをつかんできた。この調子なら、いつか良い剣士になれるかもしれない。";
$char_scr_skill1_level6    = " <spush><color:ffcc00>[上級者]<spop> 平均よりはマシだ。そしてまだ生きている。「まだ生きている」の部分は、予告なく変わる可能性があるということを肝に命じた方がいいだろう。";
$char_scr_skill1_level7    = " <spush><color:aeff00>[名人]<spop> You're good with a sword. A lot of men died to make this dream a reality.";
$char_scr_skill1_level8    = " <spush><color:aeff00>[名人]<spop> Your blade has become an extension of your arm.";
$char_scr_skill1_level9    = " <spush><color:84ff00>[達人]<spop> If you've unsheathed your blade, it's already too late to pray.";
$char_scr_skill1_level10   = " <spush><color:24ff00>[マスター]<spop> You've mastered the art of sword fighting.";

//skill: Axe
$char_scr_skill2_level1    = " <spush><color:cc0000>[素人]<spop> やってみろ。どれだけ難しいのか？";
$char_scr_skill2_level2    = " <spush><color:cc4300>[見習い]<spop> 君はぎこちなく斧を振り、激しくバランスを崩す。";
$char_scr_skill2_level3    = " <spush><color:ffa800>[一人前]<spop> 斧を乱暴に振り回すだけでは限界があることに気付いた。";
$char_scr_skill2_level4    = " <spush><color:ffa800>[一人前]<spop> 奴らがじっとしていてくれれば。そうだろう？";
$char_scr_skill2_level5    = " <spush><color:ffcc00>[上級者]<spop> 数え切れないほどの時間を費やし、木を伐り倒し、男たちは滑らかなスウィングを身につけてきた。";
$char_scr_skill2_level6    = " <spush><color:ffcc00>[上級者]<spop> 君の真っ直ぐな攻撃は苛烈だが、隙が多い。";
$char_scr_skill2_level7    = " <spush><color:aeff00>[名人]<spop> Short, vicious chops cleave skulls and keep professional killers on their heels.";
$char_scr_skill2_level8    = " <spush><color:aeff00>[名人]<spop> You welcome heavily armored prey. Few are quick enough to dodge, and the dead weight they carry offers scant protection from your axe blade.";
$char_scr_skill2_level9    = " <spush><color:84ff00>[達人]<spop> The carnage you create with an axe is appalling. Blood spurts when shocked foes strike out at you with limbs they no longer possess.";
$char_scr_skill2_level10   = " <spush><color:24ff00>[マスター]<spop> You've mastered the art of axe fighting.";

//skill: Hammer
$char_scr_skill3_level1    = " <spush><color:cc0000>[素人]<spop> やってみろ。どれだけ難しいのか？";
$char_scr_skill3_level2    = " <spush><color:cc4300>[見習い]<spop> 君はぎこちなくハンマーを振り、激しくバランスを崩す。";
$char_scr_skill3_level3    = " <spush><color:ffa800>[一人前]<spop> ハンマーを乱暴に振り回すだけでは限界があることに気付いた。";
$char_scr_skill3_level4    = " <spush><color:ffa800>[一人前]<spop> 奴らがじっとしていてくれれば。そうだろう？";
$char_scr_skill3_level5    = " <spush><color:ffcc00>[上級者]<spop> 数え切れないほどの時間を費やし、鎧や盾をハンマーで打つうちに、滑らかなスウィングが身に付いてきた。";
$char_scr_skill3_level6    = " <spush><color:ffcc00>[上級者]<spop> 君の真っ直ぐな攻撃は苛烈だが、隙が多い。";
$char_scr_skill3_level7    = " <spush><color:aeff00>[名人]<spop> Short, vicious chops smash helmets and skulls and keep professional killers on their heels.";
$char_scr_skill3_level8    = " <spush><color:aeff00>[名人]<spop> You welcome heavily armored prey. Few are quick enough to dodge, and the dead weight they carry offers scant protection from your doomhammer.";
$char_scr_skill3_level9    = " <spush><color:84ff00>[達人]<spop> The trail of broken skulls and savagely dented metal you leave in your wake speaks of your skill.";
$char_scr_skill3_level10   = " <spush><color:24ff00>[マスター]<spop> You've mastered the art of crushing skulls.";

//skill: Spear
$char_scr_skill4_level1    = " <spush><color:cc0000>[素人]<spop> 一度だけ、鶏を串に刺して調理したことはある…。";
$char_scr_skill4_level2    = " <spush><color:cc4300>[見習い]<spop> 敵に向けておきさえすれば大丈夫だ。";
$char_scr_skill4_level3    = " <spush><color:ffa800>[一人前]<spop> 槍で人を突く方法は一つだけじゃないことがわかった。";
$char_scr_skill4_level4    = " <spush><color:ffa800>[一人前]<spop> ８フィートの棒で何かを打つのは、思ったより簡単ではないことに気付いた。";
$char_scr_skill4_level5    = " <spush><color:ffcc00>[上級者]<spop> コツを掴んだ。大事なのは、敵をこちらに近付けないことだ。";
$char_scr_skill4_level6    = " <spush><color:ffcc00>[上級者]<spop> 平均よりはマシだ。そしてまだ生きている。「まだ生きている」の部分は、予告なく変わる可能性があるということを肝に命じた方がいいだろう。";
$char_scr_skill4_level7    = " <spush><color:aeff00>[名人]<spop> You've become quite deadly with a spear.";
$char_scr_skill4_level8    = " <spush><color:aeff00>[名人]<spop> Your spear has become an extension of your arm. A frighteningly long extension.";
$char_scr_skill4_level9    = " <spush><color:84ff00>[達人]<spop> You're a one-man hedgehog formation.";
$char_scr_skill4_level10   = " <spush><color:24ff00>[マスター]<spop> They call you The Scorpion.";

//skill: Bow
$char_scr_skill5_level1    = " <spush><color:cc0000>[素人]<spop> 君が弦を引くと変な音が出る。";
$char_scr_skill5_level2    = " <spush><color:cc4300>[見習い]<spop> 的に当てるよりも、前腕を痛めることの方が多い。";
$char_scr_skill5_level3    = " <spush><color:ffa800>[一人前]<spop> 静止した的に当てることができる。近距離で。風がなければ。";
$char_scr_skill5_level4    = " <spush><color:ffa800>[一人前]<spop> 上手くなってきた。ちょっと運が良ければ、動いている標的にも当てることができる。";
$char_scr_skill5_level5    = " <spush><color:ffcc00>[上級者]<spop> コツをつかんできた。この調子なら、いつか良い射手になれるかもしれない。";
$char_scr_skill5_level6    = " <spush><color:ffcc00>[上級者]<spop> 平均よりはマシだ。そしてまだ生きている。「まだ生きている」の部分は、予告なく変わる可能性があるということを肝に命じた方がいいだろう。";
$char_scr_skill5_level7    = " <spush><color:aeff00>[名人]<spop> Finally, your arrows are beginning to strike true. Better late than never.";
$char_scr_skill5_level8    = " <spush><color:aeff00>[名人]<spop> Few archers can match your skill.";
$char_scr_skill5_level9    = " <spush><color:84ff00>[達人]<spop> You can hit a sparrow in the eye from two hundred yards. Blindfolded.";
$char_scr_skill5_level10   = " <spush><color:24ff00>[マスター]<spop> They call you The 鷹の目.";

//skill: Crossbow
$char_scr_skill6_level1    = " <spush><color:cc0000>[素人]<spop> 大体の方向を合わせて引き金を引く？　わかった！";
$char_scr_skill6_level2    = " <spush><color:cc4300>[見習い]<spop> クロスボウを握っている間は強そうに見えるようになった。君はただ相手を睨み付けていればいい。";
$char_scr_skill6_level3    = " <spush><color:ffa800>[一人前]<spop> 静止した的に当てることができる。近距離で。風がなければ。";
$char_scr_skill6_level4    = " <spush><color:ffa800>[一人前]<spop> 上手くなってきた。ちょっと運が良ければ、動いている標的にも当てることができる。";
$char_scr_skill6_level5    = " <spush><color:ffcc00>[上級者]<spop> コツをつかんできた。この調子なら、いつか良いクロスボウ使いになれるかもしれない。";
$char_scr_skill6_level6    = " <spush><color:ffcc00>[上級者]<spop> 平均よりはマシだ。そしてまだ生きている。「まだ生きている」の部分は、予告なく変わる可能性があるということを肝に命じた方がいいだろう。";
$char_scr_skill6_level7    = " <spush><color:aeff00>[名人]<spop> Finally, your bolts are beginning to strike true. Better late than never.";
$char_scr_skill6_level8    = " <spush><color:aeff00>[名人]<spop> Few crossbowmens can match your skill.";
$char_scr_skill6_level9    = " <spush><color:84ff00>[達人]<spop> You can hit a sparrow in the eye from two hundred yards. Blindfolded.";
$char_scr_skill6_level10   = " <spush><color:24ff00>[マスター]<spop> They call you The 鷹の目.";

//skill: Throwing
$char_scr_skill7_level1    = " <spush><color:cc0000>[素人]<spop> いや、投擲は武器を落とすのとは違う。";
$char_scr_skill7_level2    = " <spush><color:cc4300>[見習い]<spop> 投げ続けるんだ。何かには当たるだろう。";
$char_scr_skill7_level3    = " <spush><color:ffa800>[一人前]<spop> １０回中７回は木に当てることができる。";
$char_scr_skill7_level4    = " <spush><color:ffa800>[一人前]<spop> 上手くなってきた。どこのサーカスでもやっていけるだろう。";
$char_scr_skill7_level5    = " <spush><color:ffcc00>[上級者]<spop> コツをつかんできた。この調子なら、いつか良い投げナイフ人になれるかもしれない。";
$char_scr_skill7_level6    = " <spush><color:ffcc00>[上級者]<spop> 平均よりはマシだ。そしてまだ生きている。「まだ生きている」の部分は、予告なく変わる可能性があるということを肝に命じた方がいいだろう。";
$char_scr_skill7_level7    = " <spush><color:aeff00>[名人]<spop> You've become quite deadly with... well, anything you can throw.";
$char_scr_skill7_level8    = " <spush><color:aeff00>[名人]<spop> Your invitation to the House of Flying Daggers is in the mail.";
$char_scr_skill7_level9    = " <spush><color:84ff00>[達人]<spop> You can hit a sparrow in the eye from ten yards. Blindfolded.";
$char_scr_skill7_level10   = " <spush><color:24ff00>[マスター]<spop> You've mastered the fine art of killing people from a safe distance.";

//skill: Dodge
$char_scr_skill8_level1    = " <spush><color:cc0000>[素人]<spop> 攻撃を避けるには、素早く祈るのが一番だ。";
$char_scr_skill8_level2    = " <spush><color:cc4300>[見習い]<spop> 祈るのもいいが、危険な場所から離れる方が少しは確率が上がるだろう。";
$char_scr_skill8_level3    = " <spush><color:ffa800>[一人前]<spop> 左にジャンプし、その後右に一歩進むだけだ。";
$char_scr_skill8_level4    = " <spush><color:ffa800>[一人前]<spop> 練習─レンチをかわすことができれば、ボルトをかわすこともできるぞ！";
$char_scr_skill8_level5    = " <spush><color:ffcc00>[上級者]<spop> コツをつかんできた。この調子なら、思ったよりも長生きできるかもしれない。";
$char_scr_skill8_level6    = " <spush><color:ffcc00>[上級者]<spop> 平均よりはマシだ。そしてまだ生きている。「まだ生きている」の部分は、予告なく変わる可能性があるということを肝に命じた方がいいだろう。";
$char_scr_skill8_level7    = " <spush><color:aeff00>[名人]<spop> You've finally learned to read the telltale signs of an incoming attack.";
$char_scr_skill8_level8    = " <spush><color:aeff00>[名人]<spop> You flow like water and bend like a reed.";
$char_scr_skill8_level9    = " <spush><color:84ff00>[達人]<spop> You've become almost impossible to hit.";
$char_scr_skill8_level10   = " <spush><color:24ff00>[マスター]<spop> They call you The Artful Dodger.";

//skill: Block
$char_scr_skill9_level1    = " <spush><color:cc0000>[素人]<spop> 攻撃を避けるには、素早く祈るのが一番だ。";
$char_scr_skill9_level2    = " <spush><color:cc4300>[見習い]<spop> 祈るのもいいが、たまには盾を上げてみると少しは確率が上がるだろう。";
$char_scr_skill9_level3    = " <spush><color:ffa800>[一人前]<spop> 盾を上げたままにしておけ─いつ攻撃されるか、君にはわからないのだ。";
$char_scr_skill9_level4    = " <spush><color:ffa800>[一人前]<spop> 訓練は嘘をつかない─攻撃とブロック、攻撃とブロック、盾は上、盾は下…。";
$char_scr_skill9_level5    = " <spush><color:ffcc00>[上級者]<spop> コツをつかんできた。この調子なら、思ったよりも長生きできるかもしれない。";
$char_scr_skill9_level6    = " <spush><color:ffcc00>[上級者]<spop> 平均よりはマシだ。そしてまだ生きている。「まだ生きている」の部分は、予告なく変わる可能性があるということを肝に命じた方がいいだろう。";
$char_scr_skill9_level7    = " <spush><color:aeff00>[名人]<spop> You've finally learned to read the telltale signs of an incoming attack.";
$char_scr_skill9_level8    = " <spush><color:aeff00>[名人]<spop> You're a one man shieldwall.";
$char_scr_skill9_level9    = " <spush><color:84ff00>[達人]<spop> You've become almost impossible to hit.";
$char_scr_skill9_level10   = " <spush><color:24ff00>[マスター]<spop> You've mastered the art of hiding behind a wooden board strapped to your arm.";

//skill: Critical Strike
$char_scr_skill10_level1    = " <spush><color:cc0000>[素人]<spop> 君は敵がいる方向に向かって大雑把に武器を振るう。";
$char_scr_skill10_level2    = " <spush><color:cc4300>[見習い]<spop> 攻撃をしている間は目を開けているのが良さそうだ。";
$char_scr_skill10_level3    = " <spush><color:ffa800>[一人前]<spop> 接触することを恐れて、君は相手が与えてくる物を何でも標的にする。";
$char_scr_skill10_level4    = " <spush><color:ffa800>[一人前]<spop> 相手の柔らかい部分を刺すとより効果的であると学んだ。";
$char_scr_skill10_level5    = " <spush><color:ffcc00>[上級者]<spop> 君と戦った相手は、ローブやライトアーマーを包帯や止血帯に改造した方がいいだろう。";
$char_scr_skill10_level6    = " <spush><color:ffcc00>[上級者]<spop> 無防備な者を殺す方が安全だと判断したため、君は天気の話をしながらの先制攻撃を企てる。";
$char_scr_skill10_level7    = " <spush><color:aeff00>[名人]<spop> It is too hard to work your blade through metal and leather; you scrutinize your opponents' armor for weaknesses.";
$char_scr_skill10_level8    = " <spush><color:aeff00>[名人]<spop> Through extensive experimentation, you have acquired a functional understanding of anatomy. Every attack you make is designed to cut tendons, sever arteries, or puncture organs.";
$char_scr_skill10_level9    = " <spush><color:84ff00>[達人]<spop> Even the most exceptional armor has flaws that you perceive and can exploit, given the opportunity.";
$char_scr_skill10_level10   = " <spush><color:24ff00>[マスター]<spop> Killing appears to be effortless for you. Your blade is drawn to the vitals of your victims.";

//skill: Sneak
$char_scr_skill11_level1    = " <spush><color:cc0000>[素人]<spop> 君が見えない相手なら、相手からも見えない。";
$char_scr_skill11_level2    = " <spush><color:cc4300>[見習い]<spop> 相手が見ていない間に動くんだ。頭いい！";
$char_scr_skill11_level3    = " <spush><color:ffa800>[一人前]<spop> 物音を立てると居場所がばれてしまうことに気付いた。";
$char_scr_skill11_level4    = " <spush><color:ffa800>[一人前]<spop> じっとしていてもいいし、静かにしていてもいい。";
$char_scr_skill11_level5    = " <spush><color:ffcc00>[上級者]<spop> コツをつかんできた。この調子なら、思ったよりも長生きできるかもしれない。";
$char_scr_skill11_level6    = " <spush><color:ffcc00>[上級者]<spop> 平均よりはマシだ。そしてまだ生きている。「まだ生きている」の部分は、予告なく変わる可能性があるということを肝に命じた方がいいだろう。";
$char_scr_skill11_level7    = " <spush><color:aeff00>[名人]<spop> Most won't see you coming.";
$char_scr_skill11_level8    = " <spush><color:aeff00>[名人]<spop> It'll take a trained eye to spot you.";
$char_scr_skill11_level9    = " <spush><color:84ff00>[達人]<spop> You can actually Hide in Plain Sight now.";
$char_scr_skill11_level10   = " <spush><color:24ff00>[マスター]<spop> You've mastered the art of getting into places with limited admission.";

//skill: Impersonate
$char_scr_skill12_level1    = " <spush><color:cc0000>[素人]<spop> 変装？　そんなものはカーニバルでバカがやることだ！";
$char_scr_skill12_level2    = " <spush><color:cc4300>[見習い]<spop> 熊のふりをしてやると、近所の子供たちは本当に喜んでくれる。";
$char_scr_skill12_level3    = " <spush><color:ffa800>[一人前]<spop> ちょっとした演技で人を納得させることができる。";
$char_scr_skill12_level4    = " <spush><color:ffa800>[一人前]<spop> 君は訛りを真似て人になりすます才能があることに気付いた。";
$char_scr_skill12_level5    = " <spush><color:ffcc00>[上級者]<spop> 悪魔は細部に宿ると気付いた─２ビットのキャラクターを好む者はいない。";
$char_scr_skill12_level6    = " <spush><color:ffcc00>[上級者]<spop> これは単なる仮想ではない─演技の技術だ。";
$char_scr_skill12_level7    = " <spush><color:aeff00>[名人]<spop> You could fool your own mother, if you have time to prepare.";
$char_scr_skill12_level8    = " <spush><color:aeff00>[名人]<spop> You can transform into any character at a moment's notice.";
$char_scr_skill12_level9    = " <spush><color:84ff00>[達人]<spop> Being anyone, anytime, anywhere - that is true freedom.";
$char_scr_skill12_level10   = " <spush><color:24ff00>[マスター]<spop> You've mastered the art of impersonating people.";

//skill: Stealing
$char_scr_skill13_level1    = " <spush><color:cc0000>[素人]<spop> おそらく、やっている間は人に見られたりしない方がいいだろう。";
$char_scr_skill13_level2    = " <spush><color:cc4300>[見習い]<spop> ああ、そうだ、指を素早く動かすんだ。誰が想像できただろうか？";
$char_scr_skill13_level3    = " <spush><color:ffa800>[一人前]<spop> 君の窃盗スタイルは、見張りから逃げることが多い。";
$char_scr_skill13_level4    = " <spush><color:ffa800>[一人前]<spop> 相手の気が逸れている時に盗む方がずっと簡単だということに気付いた。";
$char_scr_skill13_level5    = " <spush><color:ffcc00>[上級者]<spop> コツをつかんできた。この調子なら、いつか良い泥棒になれるかもしれない。";
$char_scr_skill13_level6    = " <spush><color:ffcc00>[上級者]<spop> 平均よりはマシだ。そしてまだ生きている。「まだ生きている」の部分は、予告なく変わる可能性があるということを肝に命じた方がいいだろう。";
$char_scr_skill13_level7    = " <spush><color:aeff00>[名人]<spop> You've become adept at using the slightest distraction to deprive a mark of their valuables.";
$char_scr_skill13_level8    = " <spush><color:aeff00>[名人]<spop> Rare is the thief whose fingers are as deft as yours.";
$char_scr_skill13_level9    = " <spush><color:84ff00>[達人]<spop> It's as if other people's possessions magically appear in your hands.";
$char_scr_skill13_level10   = " <spush><color:24ff00>[マスター]<spop> You've mastered the art of redistributing wealth.";

//skill: Lockpicking
$char_scr_skill14_level1    = " <spush><color:cc0000>[素人]<spop> 一度、錆びた釘を使って納屋に侵入したことがあった。本当だ。";
$char_scr_skill14_level2    = " <spush><color:cc4300>[見習い]<spop> 錠前を破る一番良い方法は、近くの岩の下にあるスペアキーを探すことだ。";
$char_scr_skill14_level3    = " <spush><color:ffa800>[一人前]<spop> 簡単な錠前や、鍵のかかっていないドアを苦もなく開けられる。";
$char_scr_skill14_level4    = " <spush><color:ffa800>[一人前]<spop> 錠前への理解が深まるごとに、君のスキルも向上していく。";
$char_scr_skill14_level5    = " <spush><color:ffcc00>[上級者]<spop> コツをつかんできた。この調子なら、いつか良い鍵屋になれるかもしれない。";
$char_scr_skill14_level6    = " <spush><color:ffcc00>[上級者]<spop> 一般に使われている錠の機構と、その弱点を知っている。";
$char_scr_skill14_level7    = " <spush><color:aeff00>[名人]<spop> What one man locked, another can unlock. In theory.";
$char_scr_skill14_level8    = " <spush><color:aeff00>[名人]<spop> Locks are a minor inconvenience to you.";
$char_scr_skill14_level9    = " <spush><color:84ff00>[達人]<spop> Like pulling out a radish in wet weather. ";
$char_scr_skill14_level10   = " <spush><color:24ff00>[マスター]<spop> If there is a lock that you can't open, you haven't seen it yet.";

//skill: Traps
$char_scr_skill15_level1    = " <spush><color:cc0000>[素人]<spop> 君の考えた罠は、釘を刺した板だ。";
$char_scr_skill15_level2    = " <spush><color:cc4300>[見習い]<spop> 君はトラップを見つけるのが得意だ。辛い方法でなら。";
$char_scr_skill15_level3    = " <spush><color:ffa800>[一人前]<spop> トラップにも種類があることを学んだ。そして傷跡たちに名前をつけた。";
$char_scr_skill15_level4    = " <spush><color:ffa800>[一人前]<spop> １０個のうち４個のトラップを解除できる。残りの６つのトラップで確実に死ぬが、君は「グラスの中にまだ半分も入っている」と考えられる奴だ。";
$char_scr_skill15_level5    = " <spush><color:ffcc00>[上級者]<spop> コツをつかんできた。この調子なら、思ったよりも長生きできるかもしれない";
$char_scr_skill15_level6    = " <spush><color:ffcc00>[上級者]<spop> 平均よりはマシだ。そしてまだ生きている。「まだ生きている」の部分は、予告なく変わる可能性があるということを肝に命じた方がいいだろう。";
$char_scr_skill15_level7    = " <spush><color:aeff00>[名人]<spop> What one man armed, another can disarm. In theory.";
$char_scr_skill15_level8    = " <spush><color:aeff00>[名人]<spop> You're getting pretty good at this trap thing.";
$char_scr_skill15_level9    = " <spush><color:84ff00>[達人]<spop> When it comes to traps, you have a sixth sense.";
$char_scr_skill15_level10   = " <spush><color:24ff00>[マスター]<spop> You can spot and disarm any trap.";

//skill: Persuasion
$char_scr_skill16_level1    = " <spush><color:cc0000>[素人]<spop> 他の霊長類とコミュニケーションをとることができる。";
$char_scr_skill16_level2    = " <spush><color:cc4300>[見習い]<spop> 霊長類は適切に選ばれた言葉に良く反応することに気付いた。";
$char_scr_skill16_level3    = " <spush><color:ffa800>[一人前]<spop> より良い演説効果を得るために言葉を連ねることを学んだ。";
$char_scr_skill16_level4    = " <spush><color:ffa800>[一人前]<spop> 君を信じたがっている人を説得する方法を学んだ。";
$char_scr_skill16_level5    = " <spush><color:ffcc00>[上級者]<spop> イソップ爺さんは正しかったことに気付いた。説得は暴力よりも効果的だ。";
$char_scr_skill16_level6    = " <spush><color:ffcc00>[上級者]<spop> 友達を作って人に影響を与える方法がやっとわかった。";
$char_scr_skill16_level7    = " <spush><color:aeff00>[名人]<spop> You've realized that persuasion is merely a prerequisite to manipulation.";
$char_scr_skill16_level8    = " <spush><color:aeff00>[名人]<spop> You will make a great 'used carts' salesman one day.";
$char_scr_skill16_level9    = " <spush><color:84ff00>[達人]<spop> People are an open book to you and you can talk them into just about anything. ";
$char_scr_skill16_level10   = " <spush><color:24ff00>[マスター]<spop> Your ability to influence minds is uncanny. Keep it up and they will burn you for witchcraft.";

//skill: Etiquette
$char_scr_skill17_level1    = " <spush><color:cc0000>[素人]<spop> 自分の名前を出しながら、組織の中でこの才能を定期的に誇示することができる。";
$char_scr_skill17_level2    = " <spush><color:cc4300>[見習い]<spop> くしゃみをするときに口を覆う。ほとんどの場合。";
$char_scr_skill17_level3    = " <spush><color:ffa800>[一人前]<spop> 月に一度以上入浴する君の習慣は、むしろ退廃的だと思われている。";
$char_scr_skill17_level4    = " <spush><color:ffa800>[一人前]<spop> 売春婦たちは君をとてもおしゃれだと思っている。";
$char_scr_skill17_level5    = " <spush><color:ffcc00>[上級者]<spop> もう友人に恥ずかしい思いをさせることは全くない。";
$char_scr_skill17_level6    = " <spush><color:ffcc00>[上級者]<spop> どのフォークから始めればいいのか、ほとんど理解できている。";
$char_scr_skill17_level7    = " <spush><color:aeff00>[名人]<spop> You've definitely figured out the forks. The spoons are another story.";
$char_scr_skill17_level8    = " <spush><color:aeff00>[名人]<spop> Upon greeting a landed equestrian, it is proper to doff your cap so.";
$char_scr_skill17_level9    = " <spush><color:84ff00>[達人]<spop> You move among society's wealthy elite without embarrassment.";
$char_scr_skill17_level10   = " <spush><color:24ff00>[マスター]<spop> You confidently participate in the most esoteric social rituals.";

//skill: Streetwise
$char_scr_skill18_level1    = " <spush><color:cc0000>[素人]<spop> 仲間の善良さを全く疑っていない。";
$char_scr_skill18_level2    = " <spush><color:cc4300>[見習い]<spop> 君は新しい橋の自慢の持ち主だ。";
$char_scr_skill18_level3    = " <spush><color:ffa800>[一人前]<spop> お金を貸した相手は可能な限り早く返してくれると信じている。";
$char_scr_skill18_level4    = " <spush><color:ffa800>[一人前]<spop> 一部の人間が君に対して正直ではないのではないかと疑い始めた。";
$char_scr_skill18_level5    = " <spush><color:ffcc00>[上級者]<spop> 一度騙すは君の恥、二度騙すは…まあ、大事なのは、もう騙されないってことだ、そうだろ？";
$char_scr_skill18_level6    = " <spush><color:ffcc00>[上級者]<spop> 信じているなら嘘ではない。";
$char_scr_skill18_level7    = " <spush><color:aeff00>[名人]<spop> You've discovered that people respond best to lies they want to hear.";
$char_scr_skill18_level8    = " <spush><color:aeff00>[名人]<spop> You've learned to play on people's fears, honor, ambitions, beliefs, and other useful qualities.";
$char_scr_skill18_level9    = " <spush><color:84ff00>[達人]<spop> Some people turn water into wine, you turn lies into truth. Arguably, yours is a more useful talent.";
$char_scr_skill18_level10   = " <spush><color:24ff00>[マスター]<spop> Your ability to manipulate people is uncanny. Keep it up and they will burn you for witchcraft.";

//skill: Lore
$char_scr_skill19_level1    = " <spush><color:cc0000>[素人]<spop> 自分の名前を書くことができる。";
$char_scr_skill19_level2    = " <spush><color:cc4300>[見習い]<spop> 君は巻物を見るのが好きだ。特に絵が描かれているものが。";
$char_scr_skill19_level3    = " <spush><color:ffa800>[一人前]<spop> 考古学者になるための鍵は、古い物には価値があるかもしれないと知ることだ。";
$char_scr_skill19_level4    = " <spush><color:ffa800>[一人前]<spop> 知識は力であると気付いた。君の学習意欲はかつてないほど高まっている。";
$char_scr_skill19_level5    = " <spush><color:ffcc00>[上級者]<spop> 髭を生やすことを検討している。考えにふけりながら撫でるために。";
$char_scr_skill19_level6    = " <spush><color:ffcc00>[上級者]<spop> 過去について多くのことを学び、学んだことがより多くを求める原動力となる。";
$char_scr_skill19_level7    = " <spush><color:aeff00>[名人]<spop> You're a linguist, historian, forger, and mechanic. In short, you're a loremaster.";
$char_scr_skill19_level8    = " <spush><color:aeff00>[名人]<spop> You've learned much: from steamworks to magick obscura.";
$char_scr_skill19_level9    = " <spush><color:84ff00>[達人]<spop> You know... everything.";
$char_scr_skill19_level10   = " <spush><color:24ff00>[マスター]<spop> You're wiser than men who think that they know everything, for you realize that you know nothing.";

//skill: Crafting
$char_scr_skill20_level1    = " <spush><color:cc0000>[素人]<spop> 鍛冶屋なら、君に蛇腹の操作を任せてもらえるかもしれない。<br><br><spush><color:ffffff>次のレベルでアンロック:<spop><color:EBEB00> ブロンズの加工 - 良質な武器と鎧 - 武器の調整 - 鎧と盾の強化 - 武器の研磨。";
$char_scr_skill20_level2    = " <spush><color:cc4300>[見習い]<spop> 蹄鉄！　ブロンズの釘！ 安いぞ！<br><br><spush><color:ffffff>アンロック:<spop><color:47FF47> ブロンズの加工 - 良質な武器と鎧 - 武器の調整 - 鎧と盾の強化 - 武器の研磨。<br><spush><color:ffffff>次のレベルでアンロック:<spop><color:EBEB00> 良質な盾 - 硬化した刃硬化した刃 - 鋸状の刃 - 硬化した鎧と盾.";
$char_scr_skill20_level3    = " <spush><color:ffa800>[一人前]<spop> 農夫の道具を修理して食べていける。<br><br><spush><color:ffffff>アンロック:<spop><color:47FF47> 良質な盾 - 硬化した刃 - 鋸状の刃 - 硬化した鎧と盾.<br><spush><color:ffffff>次のレベルでアンロック:<spop><color:EBEB00> 鉄の加工 - 輝く盾 - 二つの技スロット.<br><spush><color:ffffff>次のレベルで向上:<spop><color:EBEB00> 良質な武器と鎧 - 武器の調整 - 鎧と盾の強化 - 武器の研磨。";
$char_scr_skill20_level4    = " <spush><color:ffa800>[一人前]<spop> 鉄の秘密を解き明かした！　敵はきっと怯えているに違いない。<br><br><spush><color:ffffff>アンロック:<spop><color:47FF47> 鉄の加工 - 輝く盾 - 二つの技スロット。<br><spush><color:ffffff>向上:<spop><color:47FF47> 良質な武器と鎧 - 武器の調整 - 鎧と盾の強化 - 武器の研磨。<br><spush><color:ffffff>次のレベルでアンロック:<spop><color:EBEB00> 輝く鎧。<br><spush><color:ffffff>次のレベルで向上:<spop><color:EBEB00> 良質な盾 - 硬化した刃 - 鋸状の刃 - 硬化した鎧と盾。";
$char_scr_skill20_level5    = " <spush><color:ffcc00>[上級者]<spop> コツをつかんできた。この調子なら、いつか良い鍛冶屋になれるかもしれない。<br><br><spush><color:ffffff>アンロック:<spop><color:47FF47> 輝く鎧。<br><spush><color:ffffff>向上:<spop><color:47FF47> 良質な盾 - 硬化した刃 - 鋸状の刃 - 硬化した鎧と盾。<br><spush><color:ffffff>次のレベルでアンロック:<spop><color:EBEB00> 鋼の加工。<br><spush><color:ffffff>次のレベルで向上:<spop><color:EBEB00> 良質な武器と鎧 - 武器の調整 - 鎧と盾の強化 - 武器の研磨。";
$char_scr_skill20_level6    = " <spush><color:ffcc00>[上級者]<spop> 鋼─最も高貴な金属─は君にその秘密を明け渡した。素晴らしい成功だ！<br><br><spush><color:ffffff>アンロック:<spop><color:47FF47> 鋼の加工。<br><spush><color:ffffff>向上:<spop><color:47FF47> 良質な武器と鎧 - 武器の調整 - 鎧と盾の強化 - 武器の研磨.<br><spush><color:ffffff>次のレベルで向上:<spop><color:EBEB00> 良質な盾 - 硬化した刃 - 鋸状の刃 - 硬化した鎧と盾。";
$char_scr_skill20_level7    = " <spush><color:aeff00>[名人]<spop> Few smiths are as good as you are.<br><br><spush><color:ffffff>向上:<spop><color:47FF47> 良質な盾 - 硬化した刃 - 鋸状の刃 - 硬化した鎧と盾.<br><spush><color:ffffff>次のレベルでアンロック:<spop><color:EBEB00> Blue 鋼の加工 - Three technique slots.<br><spush><color:ffffff>次のレベルで向上:<spop><color:EBEB00> 良質な武器と鎧 - 武器の調整 - 鎧と盾の強化 - 武器の研磨 - 輝く盾.";
$char_scr_skill20_level8    = " <spush><color:aeff00>[名人]<spop> Forget about steel. Blue steel is where it's at and you've just figured out how to do it!<br><br><spush><color:ffffff>アンロック:<spop><color:47FF47> Blue 鋼の加工 - Three technique slots.<br><spush><color:ffffff>向上:<spop><color:47FF47> 良質な武器と鎧 - 武器の調整 - 鎧と盾の強化 - 武器の研磨 - 輝く盾.<br><spush><color:ffffff>次のレベルで向上:<spop><color:EBEB00> 良質な盾 - 硬化した刃 - 鋸状の刃 - 硬化した鎧と盾.";
$char_scr_skill20_level9    = " <spush><color:84ff00>[達人]<spop> Your reputation as a smith precedes you.<br><br><spush><color:ffffff>向上:<spop><color:47FF47> 良質な盾 - 硬化した刃 - 鋸状の刃 - 硬化した鎧と盾.<br><spush><color:ffffff>次のレベルでアンロック:<spop><color:EBEB00> Sky metal working - Four technique slots.<br> <spush><color:ffffff>次のレベルで向上:<spop><color:EBEB00> Masterwork weapons, shields and armor - 硬化した刃 - 鋸状の刃 - 武器の調整 - 武器の研磨 - 輝く鎧 and shields - Hardened armor and shields - 鎧と盾の強化.";
$char_scr_skill20_level10   = " <spush><color:24ff00>[マスター]<spop> Your weapons are flawless. If on your journey, you should encounter God, God will be cut.<br><br><spush><color:ffffff>アンロック:<spop><color:47FF47> Sky metal working - four technique slots.<br><spush><color:ffffff>向上:<spop><color:47FF47> Masterwork weapons, shields and armor - 硬化した刃 - 鋸状の刃 - 武器の調整 - 武器の研磨 - 輝く鎧 and shields - Hardened armor and shields - 鎧と盾の強化.";

//skill: Trading
$char_scr_skill21_level1    = " <spush><color:cc0000>[素人]<spop> この魔法の豆はいい買い物だった。本当に！<br><br><spush><color:ffffff>技能:<spop><spush><color:47FF47> 15%の値で売却 - 125%の値で購入。<br><spop><spush><color:ffffff>次のレベルの技能:<spop><spush><color:EBEB00> 20%の値で売却 - 125%の値で購入";
$char_scr_skill21_level2    = " <spush><color:cc4300>[見習い]<spop> 特定の商人が商品の価値を誇張しているのではないかと疑い始めた。<br><br><spush><color:ffffff>技能:<spop><spush><color:47FF47> 20%の値で売却 - 125%の値で購入。<br><spop><spush><color:ffffff>次のレベルの技能:<spop><spush><color:EBEB00> 25%の値で売却 - 120%の値で購入。";
$char_scr_skill21_level3    = " <spush><color:ffa800>[一人前]<spop> 話がうますぎて本当だと思えないのなら、そうなんだろう。<br><br><spush><color:ffffff>技能:<spop><spush><color:47FF47> 25%の値で売却 - 120%の値で購入。<br><spop><spush><color:ffffff>次のレベルの技能:<spop><spush><color:EBEB00> 30%の値で売却 - 120%の値で購入。";
$char_scr_skill21_level4    = " <spush><color:ffa800>[一人前]<spop> 安く買って、高く売る、それがコツだ。<br><br><spush><color:ffffff>技能:<spop><spush><color:47FF47> 30%の値で売却 - 120%の値で購入。<br><spop><spush><color:ffffff>次のレベルの技能:<spop><spush><color:EBEB00> 35%の値で売却 - 115%の値で購入。";
$char_scr_skill21_level5    = " <spush><color:ffcc00>[上級者]<spop> 君は今や本物の商人だ。そろばんも何もかも手に入れた。<br><br><spush><color:ffffff>技能:<spop><spush><color:47FF47> 35%の値で売却 - 115%の値で購入。<br><spop><spush><color:ffffff>次のレベルの技能:<spop><spush><color:EBEB00> 45%の値で売却 - 115%の値で購入。";
$char_scr_skill21_level6    = " <spush><color:ffcc00>[上級者]<spop> 一つの金貨を二つに変えるやり方を学んだ。繊細で強力な魔法だ。<br><br><spush><color:ffffff>技能:<spop><spush><color:47FF47> 45%の値で売却 - 115%の値で購入。<br><spop><spush><color:ffffff>次のレベルの技能:<spop><spush><color:EBEB00> 55%の値で売却 - 110%の値で購入。";
$char_scr_skill21_level7    = " <spush><color:aeff00>[名人]<spop> You've learned that people aren't really buying the goods, they're buying how the goods make them feel.<br><br><spush><color:ffffff>技能:<spop><spush><color:47FF47> 55%の値で売却 - 110%の値で購入。<br><spop><spush><color:ffffff>次のレベルの技能:<spop><spush><color:EBEB00> 65%の値で売却 - 110%の値で購入。";
$char_scr_skill21_level8    = " <spush><color:aeff00>[名人]<spop> People check that their coin pouches are still attached to their belts when you smile.<br><br><spush><color:ffffff>技能:<spop><spush><color:47FF47> 65%の値で売却 - 110%の値で購入。<br><spop><spush><color:ffffff>次のレベルの技能:<spop><spush><color:EBEB00> 75%の値で売却 - 105%の値で購入。";
$char_scr_skill21_level9    = " <spush><color:84ff00>[達人]<spop> They say that everything you touch turns to gold.<br><br><spush><color:ffffff>技能:<spop><spush><color:47FF47> 75%の値で売却 - 105%の値で購入。<br><spop><spush><color:ffffff>次のレベルの技能:<spop><spush><color:EBEB00> 90%の値で売却 - 100%の値で購入。";
$char_scr_skill21_level10   = " <spush><color:24ff00>[マスター]<spop> Money is the lifeblood of the world. And you drink deeply.<br><br><spush><color:ffffff>技能:<spop><spush><color:47FF47> 90%の値で売却 - 100%の値で購入。";

//skill: Alchemy
$char_scr_skill22_level1    = " <spush><color:cc0000>[素人]<spop> 味を見れば塩がわかる。<br><br><spush><color:ffffff>次のレベルでアンロック:<spop><color:EBEB00> 癒やしの膏薬 - 狂戦士のポーション - 毒の小瓶。";
$char_scr_skill22_level2    = " <spush><color:cc4300>[見習い]<spop> 混ぜた物が煙を出し始めたら、それはまずい。学んだ教訓。<br><br><spush><color:ffffff>アンロック:<spop><color:47FF47> 癒やしの膏薬 - 狂戦士のポーション - 毒の小瓶。<br><spush><color:ffffff>次のレベルでアンロック:<spop><color:EBEB00> 液状の火 - 神経刺激剤 - 解毒薬。";
$char_scr_skill22_level3    = " <spush><color:ffa800>[一人前]<spop> 君の味方は敵と同じぐらい、君の調合薬を恐れている。<br><br><spush><color:ffffff>アンロック:<spop><color:47FF47> 液状の火 - 酸の小瓶 - 神経刺激剤 - 解毒薬。<br><spush><color:ffffff>次のレベルでアンロック:<spop><color:EBEB00> 回復用の塗布剤 - 黒色火薬爆弾 - 水増しされた神経刺激剤。<br><spush><color:ffffff>次のレベルで向上:<spop><color:EBEB00> 癒やしの膏薬 - 狂戦士のポーション - 毒。";
$char_scr_skill22_level4    = " <spush><color:ffa800>[一人前]<spop> 君の舌はそんな色でいいのか？<br><br><spush><color:ffffff>アンロック:<spop><color:47FF47> 回復用の塗布剤 - 黒色火薬爆弾 - 水増しされた神経刺激剤。<br><spush><color:ffffff>向上:<spop><color:47FF47> 癒やしの膏薬 - 狂戦士のポーション - 毒.<br><spush><color:ffffff>次のレベルでアンロック:<spop><color:EBEB00> 水増しされた狂戦士のポーション - 狂戦士のポーション 止血薬。<br><spush><color:ffffff>次のレベルで向上:<spop><color:EBEB00> 神経刺激剤 - 酸の小瓶 - 液状の火。";
$char_scr_skill22_level5    = " <spush><color:ffcc00>[上級者]<spop> 最後に眉毛があったのはいつだったか思い出せない。<br><br><spush><color:ffffff>アンロック:<spop><color:47FF47> 水増しされた狂戦士のポーション - 狂戦士のポーション 止血薬。<br><spush><color:ffffff>向上:<spop><color:47FF47> 神経刺激剤 - 酸の小瓶 - 液状の火.<br><spush><color:ffffff>次のレベルでアンロック:<spop><color:EBEB00> 鷹の目 神経刺激剤 - Splash 酸の小瓶 - 強化された液状の火。<br><spush><color:ffffff>次のレベルで向上:<spop><color:EBEB00> 癒やしの膏薬 - 回復用の塗布剤 - 狂戦士のポーション - 毒の小瓶。";
$char_scr_skill22_level6    = " <spush><color:ffcc00>[上級者]<spop> 硫黄の匂いが出てくることはない。<br><br><spush><color:ffffff>アンロック:<spop><color:47FF47> 鷹の目 神経刺激剤 - Splash 酸の小瓶 - 強化された液状の火.<br><spush><color:ffffff>向上:<spop><color:47FF47> 癒やしの膏薬 - 回復用の塗布剤 - 狂戦士のポーション - 毒の小瓶.<br><spush><color:ffffff>次のレベルでアンロック:<spop><color:EBEB00> 黒色火薬爆弾の手榴弾 - リジェネレーションポーション。<br><spush><color:ffffff>次のレベルで向上:<spop><color:EBEB00> 狂戦士のポーション 止血薬 - 神経刺激剤 - 解毒薬 - 酸の小瓶 - 液状の火 - 黒色火薬爆弾.";
$char_scr_skill22_level7    = " <spush><color:aeff00>[名人]<spop> Healing potions make great hangover cures, you've discovered.<br><br><spush><color:ffffff>アンロック:<spop><color:47FF47> 黒色火薬爆弾の手榴弾 - リジェネレーションポーション.<br><spush><color:ffffff>向上:<spop><color:47FF47> 狂戦士のポーション 止血薬 - 神経刺激剤 - 解毒薬 - 酸の小瓶 - 液状の火 - 黒色火薬爆弾.<br><spush><color:ffffff>次のレベルでアンロック:<spop><color:EBEB00> Burning 液状の火 - 強化された黒色火薬爆弾.<br><spush><color:ffffff>次のレベルで向上:<spop><color:EBEB00> 癒やしの膏薬 - 回復用の塗布剤 - 狂戦士のポーション - 水増しされた神経刺激剤 - 毒の小瓶.";
$char_scr_skill22_level8    = " <spush><color:aeff00>[名人]<spop> You've got a potion for any situation.<br><br><spush><color:ffffff>アンロック:<spop><color:47FF47> Burning 液状の火 - 強化された黒色火薬爆弾.<br><spush><color:ffffff>向上:<spop><color:47FF47> 癒やしの膏薬 - 回復用の塗布剤 - 狂戦士のポーション - 水増しされた神経刺激剤 - 毒の小瓶.<br><spush><color:ffffff>次のレベルでアンロック:<spop><color:EBEB00> 強化された酸の小瓶 - Potent 毒の小瓶.<br><spush><color:ffffff>次のレベルで向上:<spop><color:EBEB00> 水増しされた狂戦士のポーション - 神経刺激剤 - 液状の火 - 酸の小瓶 - 黒色火薬爆弾の手榴弾.";
$char_scr_skill22_level9    = " <spush><color:84ff00>[達人]<spop> Matter is your plaything, you bend it to your will.<br><br><spush><color:ffffff>アンロック:<spop><color:47FF47> 強化された酸の小瓶 - Potent 毒の小瓶.<br><spush><color:ffffff>向上:<spop><color:47FF47> 水増しされた狂戦士のポーション - 神経刺激剤 - 液状の火 - 酸の小瓶 - 黒色火薬爆弾の手榴弾.<br><spush><color:ffffff>次のレベルで向上:<spop><color:EBEB00> 癒やしの膏薬 - 回復用の塗布剤 - リジェネレーションポーション - 狂戦士のポーション - 狂戦士のポーション 止血薬 - 神経刺激剤 - 鷹の目 神経刺激剤 - 毒の小瓶 - 酸の小瓶 - 液状の火 - 黒色火薬爆弾.";
$char_scr_skill22_level10   = " <spush><color:24ff00>[マスター]<spop> You start wondering why people refer to all the great scientists as mad. Must be jealousy.<br><br><spush><color:ffffff>向上:<spop><color:47FF47> 癒やしの膏薬 - 回復用の塗布剤 - リジェネレーションポーション - 狂戦士のポーション - 狂戦士のポーション 止血薬 - 神経刺激剤 - 鷹の目 神経刺激剤 - 毒の小瓶 - 酸の小瓶 - 液状の火 - 黒色火薬爆弾.";

//abilities
$char_scr_abilities = "<spush><color:ffffff>技能: <spop> ";
$char_scr_abilities_color = "<spush><color:47FF47>";

//next level abilities
$char_scr_next_lvl_abilities = "<spush><color:ffffff>次のレベルの技能: <spop> ";
$char_scr_next_lvl_abilities_color = "<spush><color:EBEB00>";

$char_scr_skill0_abilities    = "<value>% 狙いを定めた攻撃のクリティカル率が高くなる<spop>";
$char_scr_skill1_abilities    = "<value>% の確率で出血を起こす─２ターンの間３ダメージ<spop>";
$char_scr_skill2_abilities    = "<value>% クリティカルダメージの増加<spop>";
$char_scr_skill3_abilities    = "<value>% の確率で敵のダメージ耐性を２DR弱体化させる<spop>";
$char_scr_skill4_abilities    = "<value>% の確率で近接の間合いに入ろうとする敵を妨害する<spop>";
$char_scr_skill5_abilities    = "<value>% の確率で速度低下─移動コストが増加する<spop>";
$char_scr_skill6_abilities    = "<value>% の確率で相手をよろめかせる─３APのペナルティ<spop>";
$char_scr_skill7_abilities    = "<value>% の確率でダメージ耐性を貫通する<spop>";
$char_scr_skill8_abilities    = "<value>% の確率で近接攻撃を回避した後に反撃する<spop>";
$char_scr_skill9_abilities    = "<value>% の確率で攻撃を逸らし全てのダメージをブロック<spop>";
$char_scr_skill10_abilities   = "<value>% の確率でクリティカル時に出血を起こす<spop>";
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

$char_scr_stat_tip0 = "<spush><color:ffffff>筋力<spop> - キャラクター作成時の戦闘スキルポイント量に影響し、ダメージ補正と最大積載量を決定する。ゲーム内の会話とインタラトのチェックに使用される。";
$char_scr_stat_tip1 = "<spush><color:ffffff>巧緻<spop> - キャラクター作成時の戦闘スキルポイント量に影響し、戦闘中のアクションポイントと順番を決定する。ゲーム内の会話とインタラトのチェックに使用される。";
$char_scr_stat_tip2 = "<spush><color:ffffff>体力<spop> - キャラクター作成時の戦闘スキルポイント量に影響し、キャラクターのヒットポイントと毒やその他の有害な物質に対する耐性を決定する（特定の場所を探索する能力に影響）。ゲーム内の会話とインタラトのチェックに使用される。";
$char_scr_stat_tip3 = "<spush><color:ffffff>知覚<spop> - キャラクター作成時の非戦闘スキルポイント量に影響し、 全ての武器と遠距離武器の精密さの補正を決定し、隠されたものを見つけるのに役立つ。 ゲーム内の会話とインタラトのチェックに使用される。";
$char_scr_stat_tip4 = "<spush><color:ffffff>知力<spop> - キャラクター作成時の非戦闘スキルポイント量に影響し、ポーナススキルポイントを決定する。ゲーム内の会話とインタラトのチェックに使用される。このボーナススキルポイントは、クエストをクリアしたときのみ加算され、敵や通行人を殺したときには加算されない。";
$char_scr_stat_tip5 = "<spush><color:ffffff>魅力<spop> - キャラクター作成時の非戦闘スキルポイント量に影響し、反応や評判の補正を決定する。会話中で頻繁にチェックがあるステータス。";

$char_scr_rep_tip0 = "かつては７つの州と２０以上の軍団を支配し、最も規模の大きく影響力のあった貴族の家であるダラタン家は戦争中にほとんど破壊された。今日では、ダラタン家に仕える者は１００人にも満たず、疑いようもなく良き日を見てきたテロンという名の小さな町を支配している。内部の者の中には最後のあえぎを絞り出すかのように、いかなる犠牲を払ってでも権力のバランスを変えて高貴な家を復活させるために、最後の戦いに向けて備えている者もいる。";
$char_scr_rep_tip1 = "アウレリアン家の主な軍隊は戦争の間、遠く離れた植民地で最も激しく血にまみれた戦場から離れ、秩序を維持していた。世界が壊滅し社会が混沌とする中で、ガエリウス将軍は最も戦略的な要塞や町を強固に支配するために迅速に動いた。今日、アウレリアン家は、古い要塞の周りに建てられた町マードランの残骸の７０％を支配し、彼らに有利なパワーバランスを保つためにあらゆる努力をしている。こうしたアウレリアン家の現在の地位に対して、他の家は恨みを抱いている。";
$char_scr_rep_tip2 = "戦争や政治から手を引いたクラッスス家は、科学と神秘の研究、特に存在の次元の研究に専念していた。その結果、彼らはポータルとその動力源となる多くの機械を構築し、召喚の分野に貢献した。末期にはほとんどの魔道士が死に、この家からは知恵と研究、明晰さを担う者たちが奪われた。今日では、クラッスス家は適切な崇拝と神々の復古を呼び掛けている。";
$char_scr_rep_tip3 = "帝国軍の残党から結成された帝国衛兵は、独立した影響力のある強力な勢力であり、秩序を維持し、貴族間の戦争が起きるのを防いでいる。貴族の家が策謀、諜報、防謀で小競り合いをしている一方で、この衛兵たちはそれよりも理想主義的である。彼らの一番重要な目的は、帝国にかつての栄光を取り戻すことだ。それが今の世界ではどれだけ現実離れして見えようとも。";
$char_scr_rep_tip4 = "四十盗賊ギルドは盗賊と密輸業者、その他犯罪傾向のある市民たちの大規模で疲れを知らないように見える巨大なネットワークで、あらゆる町で活動しており、その起源を帝国初期にまでさかのぼる。かつては４０の大都市の４０の中心人物がそのネットワークをまとめていたとも言われている。往年の四十盗賊と現在の形の四十盗賊との関係や繋がりについては諸説あるが、その名は今も残っている。";
$char_scr_rep_tip5 = "交易と商人のギルドは常に存在してきたが、剣の力によってもたらされた災厄の影で、金の力は国事に対してはるかに大きい影響力を持つようになった。主要な商人は今や全ての交易を総括し、管理している。キャラバン、関税、鉱山、そして市場はコンメルキウムの恩恵のみで運営されている。前哨地や辺境の村では独立している商人は今も存在しているが、町での交易に危険や問題がないわけではない。";
$char_scr_rep_tip6 = "帝国の黎明期には、皇帝直属の衛兵がいた。彼らは皇帝を守るという本来の任務とは別に、潜入と暗殺のエキスパートとして訓練されていた。 多くの政治的、軍事的な敵対者たちが夜の狂喜の中の死や、説明のつかない不幸に遭遇し、帝国の長年にわたる安定を確保した。帝国の崩壊後、仕える主がいないため、衛兵たちは滅びた帝国の混沌へと散っていった。  外の世界に出ると、世界が荒廃していても、彼らの平和維持活動には大きな需要があった。 暗殺教団が設立され、後にその一群は誉れ高き名を帯びることになる。「ステュクスの漕手」と。";
$char_scr_rep_tip7 = "<spush><color:ffffff>骸の数<spop> - 君と出会った人々の中でどれだけの人間が死んだのか、君の殺しに関しての抵抗のなさを示す。";
$char_scr_rep_tip8 = "<spush><color:ffffff>戦闘<spop> - どれだけの命を奪ったかではなく、どれだけ不可能な状況に立ち向かい、生き延びてきたかだ。伊達じゃない。";
$char_scr_rep_tip9 = "<spush><color:ffffff>仲裁者<spop> - 君が平和的に解決をしようと努めたことを示す。人によっては、とても心強いと感じるかもしれない。";
$char_scr_rep_tip10 = "<spush><color:ffffff>忠誠<spop> - 忠誠心と、沈みゆく船と運命を共にするのか、それともネズミのように逃げ出すタイプなのかを測る。だがそれでも、見逃すことのできない機会というものはある。";
$char_scr_rep_tip11 = "<spush><color:ffffff>名声<spop> - 君の評判と影響力を測る。君は名の知られた冒険者か？　野心的な新進気鋭か？　尊敬を集めているのか？　この項目が君に教えてくれるだろう（そして、注目しているであろう他の者たちにも）。";
$char_scr_rep_tip12 = "<spush><color:ffffff>誓いの言葉<spop> - 一度した約束をどれだけ守っているかを測る。己の言葉を裏切ることがなければ、より信頼してくれる人もいるかもしれない。";

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
$char_scr_misc_tip2 = "ステータスポイントは、キャラクター生成時にのみ配分できます。クリティカルストライクは、物理属性のステータスを減少させる傷を負う可能性があります。ヒーラーの所へ行くことで通常の状態に戻ることができます。";
$char_scr_misc_tip3 = "Your background is not a Character Class. It doesn't affect skill values or character progression. Your background affects your intial standing with various factions and will determine how your adventure begins. It is also checked in dialogues.";
$char_scr_misc_tip4 = "<spush><color:ffffff>Weapon Synergy<spop>- Increasing one weapon skill gives various bonuses to all other weapon skills, reflecting your growing combat skills and experience. The numbers show the total amount of SP added to each skill through synergy effects.";