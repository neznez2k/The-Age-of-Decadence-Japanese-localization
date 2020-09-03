//Main Menu
$quit_confirm_caption = "確認";
$quit_confirm_message = "本当に終了しますか？";

//Loading Screen
$loading_objects = "LOADING OBJECTS";

//Play GUI
$cursor_string[0] = "AP";
$cursor_string[1] = "IA（割込攻撃）";
$cursor_string[2] = "AoO（追撃率）";
loadStringCollection("Cursor Strings", "cursor_string");

// Cursor hint
$cursor_hint[0] = "HP";
$cursor_hint[1] = "THC（命中率）";
$cursor_hint[2] = "CS（クリティカル率）";
$cursor_hint[3] = "ADC（アーマーダメージ率）";
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

$ammo_desc[0] = "通常";
$ammo_desc[1] = "逆鉤";
$ammo_desc[2] = "鋭刃";
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
$attack_string[12] = "唐竹割り";
$attack_string[13] = "ダブルタップ";
$attack_string[14] = "疾風突き";
$attack_string[15] = "串刺し";
$attack_string[16] = "旋風斬";
$attack_string[17] = "マルチショット";
$attack_string[18] = "バースト";
$attack_string[19] = "エンタングル";
$attack_string[20] = "酸投げ";
$attack_string[21] = "投げる：脚";
$attack_string[22] = "投げる：頭";
$attack_string[23] = "フェイント";
$attack_string[24] = "シールドバッシュ";
$attack_string[25] = "フラスコ投げ";
$attack_string[26] = "爆弾投げ";
$attack_string[27] = "旋風斬";
$attack_string[28] = "QUICK JAB";
$attack_string[29] = "SNIPE";
$attack_string[30] = "THROW OPPONENT";
$attack_string[31] = "スラッシュ";
$attack_string[32] = "強攻撃";
$attack_string[33] = "ダブルストライク";
$attack_string[34] = "サソリの爪（通常）";
$attack_string[35] = "サソリの尾";
$attack_string[36] = "強攻撃";
$attack_string[37] = "トリプルストライク";
$attack_string[38] = "プッシュ";
$attack_string[39] = "ELDER GOD HAND ATTACK";
$attack_string[40] = "ELDER TENTACLE ATTACK";
$attack_string[41] = "ELDER MIND ATTACK REGULAR";
$attack_string[42] = "ELDER MIND ATTACK SHIELDED";
$attack_string[43] = "酸投げ";
$attack_string[44] = "ノックダウン";
$attack_string[45] = "ノックダウン";
$attack_string[46] = "オオムカデ";
$attack_string[47] = "旋風斬";
$attack_string[48] = "旋風斬";
loadStringCollection("Usage Mode Strings", "attack_string");

$playgui_item_tooltip_format =   "<font:Kinto Sans Bold:25>" @
                                 "<spush><color:FFFFFF>効果<spop><br>" @ 
                                 "<font:Kinto Sans:25><spush><color:AB9661><effect><spop><br>" @
                                 "<font:Kinto Sans Bold:25><spush><color:FFFFFF>クリティカル効果<spop><br>" @
                                 "<font:Kinto Sans:25><spush><color:AB9661><critical_effect><spop><br>";
//Fast
$attack_tooltip_effect[0] = "- 低ダメージ<br>- 命中率　＋15% <br>- クリティカル率  - 15% <br>- アーマーダメージ率　 - 15%";
$attack_tooltip_critical_effect[0] = " - ダメージ耐性貫通 <br>- クリティカルダメージ";
//Regular
$attack_tooltip_effect[1] = "- 通常ダメージ";
$attack_tooltip_critical_effect[1] = " - ダメージ耐性貫通 <br>- クリティカルダメージ";
//Power
$attack_tooltip_effect[2] = "- 高ダメージ <br>- 命中率　 - 15% <br>- クリティカル率 　＋15% <br>- アーマーダメージ率　＋15%";
$attack_tooltip_critical_effect[2] = " - ダメージ耐性貫通 <br>- クリティカルダメージ";
//Throw
$attack_tooltip_effect[3] = "- 高ダメージ <br>- 命中率　-10% <br>- クリティカル率 　+10% <br>- アーマーダメージ率　+15% <br>- パッシブ率 +5%";
$attack_tooltip_critical_effect[3] = " - クリティカルダメージ";
//Aimed: Head
$attack_tooltip_effect[4] = "- 高ダメージ <br>- 命中率　  - 25%<br>- クリティカル率 　 - 15%<br>- アタックペナルティ(THC)<br>- 合計： 5% + （武器AP-3） x2% （3ターンの間）";
$attack_tooltip_critical_effect[4] = "- 2ターンの間ノックダウン、1タイル分投げ出される<br>- 知覚が1減少 <br>- 最小で1ポイントのダメージ<br>- クリティカルダメージ<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>クリティカル率の計算式<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>（クリティカル率-クリティカル抵抗） + （筋力-7） x10";
//Arterial Strike
$attack_tooltip_effect[5] = "- 高ダメージ <br>- 命中率　 -25% <br>- アーマーダメージ率　-25%<br>- クリティカル率 　-25%";
$attack_tooltip_critical_effect[5] = " - ダメージ耐性貫通 <br>- クリティカルダメージ <br>- 出血：4ダメージ （3ターンの間）<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>クリティカル率の計算式<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>（クリティカル率-クリティカル抵抗） + （知覚-7） x10";
//Aimed: Torso
$attack_tooltip_effect[6] = "- 通常ダメージ <br>- 命中率　 -10% <br>- 30%のダメージ耐性貫通 ";
$attack_tooltip_critical_effect[6] = " - 70%のダメージ耐性貫通 <br>- 鎧のダメージ耐性が2減少 <br>- クリティカルダメージ <br>- 体力が1減少<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>クリティカル率の計算式<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>（クリティカル率-クリティカル抵抗） + （知覚-7） x10";
//Aimed: Legs
$attack_tooltip_effect[7] = "- 低ダメージ <br>- 命中率　 -10% <br>- アーマーダメージ率　-50% <br>- 回避にペナルティ<br>- 合計： 5% + （武器AP-3） x5% （3ターンの間）";
$attack_tooltip_critical_effect[7] = "- 回避に2倍のペナルティ<br>- 巧緻が1減少<br>- 2ターンの間無力化 （移動コスト2倍）<br>- 最小で1ポイントのダメージ<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>クリティカル率の計算式<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>（クリティカル率-クリティカル抵抗） + （筋力-7） x10";
//Aimed: Arms
$attack_tooltip_effect[8] = "- 低ダメージ <br>- 命中率　 -10% <br>- アーマーダメージ率　-50% <br>- アタックペナルティ(THC)<br>- 合計： 5% + （武器AP-3） x5% （3ターンの間）";
$attack_tooltip_critical_effect[8] = "- アタックに2倍のペナルティ(THC)<br>- 筋力が1減少<br>- 武装解除（ハンドスロットから武器を取り除く）<br>- 最小で1ポイントのダメージ<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>クリティカル率の計算式<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>（クリティカル率-クリティカル抵抗） + （筋力-7） x10";
//Aimed: Legs - Ranged
$attack_tooltip_effect[9] = "- 低ダメージ <br>- 命中率　 -10% <br>- アーマーダメージ率　-50% <br>- 回避にペナルティ<br>- 合計： 5% + （武器AP-3） x5% （3ターンの間）";
$attack_tooltip_critical_effect[9] = "- 回避に2倍のペナルティ<br>- 巧緻が1減少<br>- 2ターンの間無力化 （移動コスト2倍）<br>- 最小で1ポイントのダメージ<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>クリティカル率の計算式<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>（クリティカル率-クリティカル抵抗） + （知覚-7） x10";
//Aimed: Arms - Ranged
$attack_tooltip_effect[10] = "- 低ダメージ <br>- 命中率　 -10% <br>- アーマーダメージ率　-50% <br>- アタックペナルティ(THC)<br>- 合計： 5% + （武器AP-3） x5% （3ターンの間）";
$attack_tooltip_critical_effect[10] = "- アタックに2倍のペナルティ(THC)<br>- 筋力が1減少<br>- 武装解除（ハンドスロットから武器を取り除く）<br>- 最小で1ポイントのダメージ<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>クリティカル率の計算式<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>（クリティカル率-クリティカル抵抗） + （知覚-7） x10";
//Swing
$attack_tooltip_effect[11] = "- 通常ダメージ <br>- 命中率　 -10%<br>- アーマーダメージ率　-10%<br>- キャラクターの前方の3タイルに及ぶ";
$attack_tooltip_critical_effect[11] = " - クリティカルダメージ <br>- 1ターンの間ノックダウン、 2タイル分投げ出される<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>クリティカル率の計算式<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>（クリティカル率-クリティカル抵抗） + （筋力-7） x10";
//Cleave
$attack_tooltip_effect[12] = "- 高ダメージ <br>- 命中率　 -20% <br>- クリティカル率 　+35% <br>- アーマーダメージ率　+25%";
$attack_tooltip_critical_effect[12] = " - ダメージ耐性貫通 <br>- クリティカルダメージ<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>クリティカル率の計算式<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>（クリティカル率-クリティカル抵抗） + （筋力-7） x10";
//Double Tap
$attack_tooltip_effect[13] = "- 2回攻撃 <br>- 低ダメージ 全ての攻撃でマイナス2ポイント<br>- 命中率　 +15% <br>- クリティカル率 　-15%<br>- アーマーダメージ率　-15%";
$attack_tooltip_critical_effect[13] = " - ダメージ耐性貫通 <br>- クリティカルダメージ";
//Flurry
$attack_tooltip_effect[14] = "- 3回攻撃 <br>- 低ダメージ 全ての攻撃でマイナス1ポイント<br>- 命中率　 +15% <br>- クリティカル率 　-15%<br>- アーマーダメージ率　-25%";
$attack_tooltip_critical_effect[14] = " - ダメージ耐性貫通 <br>- クリティカルダメージ";
//Impale
$attack_tooltip_effect[15] = "- 高ダメージ <br>- 命中率　 -10%";
$attack_tooltip_critical_effect[15] = " - ダメージ耐性貫通 <br>- クリティカルダメージ <br>- 2ターンの間敵の動きを止める <br>- 体力に1ポイントのダメージ<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>クリティカル率の計算式<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>（クリティカル率-クリティカル抵抗） + （筋力-7） x10";
//Whirlwind
$attack_tooltip_effect[16] = "- 低ダメージ <br>- 命中率　 -20%<br>- アーマーダメージ率　-20%<br>- クリティカル率 　-20%<br>- 周囲の8マス全ての敵に同時に攻撃可能";
$attack_tooltip_critical_effect[16] = " - クリティカルダメージ <br>- 1ターンの間ノックダウン、1タイル分投げ出される<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>クリティカル率の計算式<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>（クリティカル率-クリティカル抵抗） + （筋力-7） x10";
//Multishot
$attack_tooltip_effect[17] = "- 低ダメージ <br>- 命中率　 +10% <br>- 扇状に3本の矢を放つ";
$attack_tooltip_critical_effect[17] = " - クリティカルダメージ";
//Burst
$attack_tooltip_effect[18] = "- 通常ダメージ <br>- 命中率　 +10% <br>- 連続で5本のボルトを放つ";
$attack_tooltip_critical_effect[18] = " - クリティカルダメージ";
//Entangle
$attack_tooltip_effect[19] = "- ダメージなし <br>- 相手のTHC（命中率）と回避を20ポイント下げる（1ターンの間）<br>- 次のターンで6AP失う";
$attack_tooltip_critical_effect[19] = "- 相手のTHC（命中率）と回避を20ポイント下げる（2ターンの間） <br>- 次のターンで6AP失う<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>クリティカル率の計算式<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>（投擲 -（相手の巧緻 - 7）） x10";
//Throw Acid
$attack_tooltip_effect[20] = "- 相手の鎧にダメージ";
$attack_tooltip_critical_effect[20] = "- なし";
//Throw Bolas: Legs
$attack_tooltip_effect[21] = "- ダメージなし <br>- 相手を移動不能にする（1ターンの間）<br>- 次のターンで6AP失う<br>- 回避にペナルティ 100%（1ターンの間）";
$attack_tooltip_critical_effect[21] = "- 相手を移動不能にする（2ターンの間）<br>- 次のターンで6AP失う<br>- 回避にペナルティ 100%（2ターンの間）<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>クリティカル率の計算式<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>（投擲 -（相手の巧緻 - 7）） x10";
//Throw Bolas: Head
$attack_tooltip_effect[22] = "- ダメージなし <br>- 相手を窒息させる（1ターンの間）<br>- 次のターンで8AP失う<br>- ブロックと回避にペナルティ 100%（2ターンの間）";
$attack_tooltip_critical_effect[22] = "- 相手を窒息させる（2ターンの間）<br>- 次のターンで8AP失う<br>- ブロックと回避にペナルティ 100% （3ターンの間）<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>クリティカル率の計算式<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>（投擲 -（相手の巧緻 - 7）） x10";
//Feint
$attack_tooltip_effect[23] = "- ダメージなし <br>- 敵と場所を入れ替える<br>- アーマーダメージ率　-100%<br>- 命中率は回避 x10";
$attack_tooltip_critical_effect[23] = "- 敵と場所を入れ替える、ノックダウン<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>クリティカル率の計算式<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>（（筋力-7） - （相手の体力-7）） x5";
//Shield Bash
$attack_tooltip_effect[24] = "- ダメージなし <br>- 敵を1タイル押し出す";
$attack_tooltip_critical_effect[24] = "- 1ターンの間ノックダウン、1タイル分投げ出される<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>クリティカル率の計算式<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>（（筋力-7） - （相手の体力-7）） x5";
//Throw Liquid Fire
$attack_tooltip_effect[25] = "- 炎で相手を攻撃し、ダメージ耐性を無視する<br>- タイルに火がつく<br>- 十字型の攻撃範囲";
$attack_tooltip_critical_effect[25] = "- なし";
//Throw Bomb
$attack_tooltip_effect[26] = "- 爆風で相手を攻撃";
$attack_tooltip_critical_effect[26] = "- 1ターンの間ノックダウン、2-3タイル分投げ出される<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>クリティカル率の計算式<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>- 基礎ポイント: 25 + 爆心地ボーナス - （相手の体力-6） x25<br>- 爆心地ならクリティカル率 50%アップ。 爆心地から離れるとこの値は低くなる。";
//Whirlwind - Blades
$attack_tooltip_effect[27] = "- 低ダメージ <br>- 命中率　 -15%<br>- アーマーダメージ率　-25%<br>- クリティカル率 　-25%<br>- 周囲の8マス全ての敵に同時に攻撃可能";
$attack_tooltip_critical_effect[27] = " - クリティカルダメージ <br><font:Kinto Sans Bold:25><spush><color:FFFFFF>クリティカル率の計算式<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>（クリティカル率-クリティカル抵抗） + （知覚-7） x10";
//Quick Jab
$attack_tooltip_effect[28] = "- 低ダメージ、 25%<br>- 命中率　 +15%<br>- アーマーダメージ率　-50%";
$attack_tooltip_critical_effect[28] = "使わない";
//Snipe
$attack_tooltip_effect[29] = "- 高ダメージ <br>- 命中率　 -10%<br>- クリティカル率 　+50% <br>- 相手が遠くなるほどTHC（命中率）が増加";
$attack_tooltip_critical_effect[29] = " - ダメージ耐性貫通 <br>- クリティカルダメージ";
//Feint - Throw Opponent
//$attack_tooltip_effect[30] = "- ダメージなし <br>- 敵と場所を入れ替える, knockdown<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>クリティカル率の計算式<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>（クリティカル率-クリティカル抵抗） + (（武器AP-3） x2 + (STR-6) - (Victim CON-6)) x5";
//$attack_tooltip_critical_effect[30] = "- なし";
//Stone Guardian - Slash
$attack_tooltip_effect[31] = "- 通常ダメージ";
$attack_tooltip_critical_effect[31] = " - ダメージ耐性貫通 <br>- クリティカルダメージ<br>- 1ターンの間ノックダウン、1タイル分投げ出される";
//Stone Guardian - Power
$attack_tooltip_effect[32] = "- 高ダメージ <br>- 命中率　 -15% <br>- クリティカル率 　+15% <br>- アーマーダメージ率　+15%";
$attack_tooltip_critical_effect[32] = " - ダメージ耐性貫通 <br>- クリティカルダメージ<br>- 鎧のダメージ耐性が2減少";
//Stone Guardian - Double Strike
$attack_tooltip_effect[33] = "- 2回攻撃 <br>- 低ダメージ 全ての攻撃でマイナス2ポイント<br>- 命中率　 +15% <br>- クリティカル率 　-15%<br>- アーマーダメージ率　-15%";
$attack_tooltip_critical_effect[33] = " - ダメージ耐性貫通 <br>- クリティカルダメージ";
//Construct - Leg Attack
$attack_tooltip_effect[36] = "- 高ダメージ <br>- 命中率　 -15% <br>- クリティカル率 　+15% <br>- アーマーダメージ率　+15%";
$attack_tooltip_critical_effect[36] = " - ダメージ耐性貫通 <br>- クリティカルダメージ<br>- 鎧のダメージ耐性が2減少";
//Construct - Triple Strike
$attack_tooltip_effect[37] = "- 3回攻撃 <br>- 低ダメージ <br>- 命中率　 +15% <br>- クリティカル率 　-15%<br>- アーマーダメージ率　-15%";
$attack_tooltip_critical_effect[37] = " - ダメージ耐性貫通 <br>- クリティカルダメージ";
//Push
$attack_tooltip_effect[38] = "- ダメージなし <br>- 敵を1タイル押し出す<br>- 命中率は筋力 x10";
$attack_tooltip_critical_effect[38] = "- なし";
//Throw Acid - Splash
$attack_tooltip_effect[43] = "- 相手の鎧にダメージ<br>- 十字型の攻撃範囲";
$attack_tooltip_critical_effect[43] = "- なし";
//Hammer Knockdown
$attack_tooltip_effect[44] = "- 低ダメージ <br>- 1ターンの間ノックダウン、1タイル分投げ出される <br>- 命中率　 -10%";
$attack_tooltip_critical_effect[44] = "- 2ターンの間ノックダウン、1タイル分投げ出される <br><font:Kinto Sans Bold:25><spush><color:FFFFFF>クリティカル率の計算式<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>（クリティカル率-クリティカル抵抗） + （筋力-7） x10";
//Strong Hammer Knockdown
$attack_tooltip_effect[45] = "- 低ダメージ <br>- 1ターンの間ノックダウン、1タイル分投げ出される <br>- 命中率　 -10% <br>- クリティカル率 　+25%";
$attack_tooltip_critical_effect[45] = "- 2ターンの間ノックダウン、1タイル分投げ出される <br><font:Kinto Sans Bold:25><spush><color:FFFFFF>クリティカル率の計算式<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>（クリティカル率-クリティカル抵抗） + （筋力-7） x10";
//Whirlwind - 1H
$attack_tooltip_effect[47] = "- 低ダメージ <br>- 命中率　 -20%<br>- アーマーダメージ率　-20%<br>- クリティカル率 　-20%<br>- キャラクターの周囲4マス全てに同時に攻撃可能";
$attack_tooltip_critical_effect[47] = " - クリティカルダメージ <br>- 1ターンの間ノックダウン、1タイル分投げ出される<br><font:Kinto Sans Bold:25><spush><color:FFFFFF>クリティカル率の計算式<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>（クリティカル率-クリティカル抵抗） + （筋力-7） x10";
//Whirlwind - Blades 1H
$attack_tooltip_effect[48] = "- 低ダメージ <br>- 命中率　 -15%<br>- アーマーダメージ率　-25%<br>- クリティカル率 　-25%<br>- キャラクターの周囲4マス全てに同時に攻撃可能";
$attack_tooltip_critical_effect[48] = " - クリティカルダメージ <br><font:Kinto Sans Bold:25><spush><color:FFFFFF>クリティカル率の計算式<spop><br><font:Kinto Sans Bold:25><spush><color:AB9661>（クリティカル率-クリティカル抵抗） + （知覚-7） x10";

$combatHint_conditionalMod_header = "<b>状態補正</b>";

$combatHint_skill = "基礎スキル値";
$combatHint_stat = "ステータス補正";
$combatHint_weapTraining = "訓練";
$combatHint_weapSynergy = "シナジー";
$combatHint_perceptionEffect = "知覚";
$combatHint_weapThcMod = "武器補正";
$combatHint_thcPenalty = "負傷";
$combatHint_shieldThcPenalty = "盾";
$combatHint_helmetThcPenalty = "ヘルメット";
$combatHint_neurostimBonus = "神経刺激";
$combatHint_berserkPenalty = "バーサーク";
$combatHint_netted = "網にかかっている";
$combatHint_armorPenalty = "アーマーペナルティ";
$combatHint_defPenalty = "防御ペナルティ";
$combatHint_mobilityBonus = "機動力ボーナス";
$combatHint_weapVsBlock = "ブロック抵抗";
$combatHint_vsRanged = "遠距離抵抗";
$combatHint_con = "体力ボーナス";

// THC Hint
$combatHint_baseThc = "基礎命中率";
$combatHint_pureAtt = "攻撃";
$combatHint_pureDef = "防御";
$combatHint_rangePenalty = "遠距離ペナルティ";
$combatHint_attackThcMod = "攻撃命中率補正";
$combatHint_facingBonus = "方向ボーナス";
$combatHint_isKnockedDown = "ノックダウン";
$combatHint_netted = "網にかかっている";
$combatHint_dexBonus = "巧緻ボーナス";
$combatHint_skillBlock = "ブロックスキル値";
$combatHint_skillDodge = "回避スキル値";
$combatHint_immobilized = "移動不能";
$combatHint_chocking = "窒息";

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
$SL_unnamed_char = "名前のないキャラクター";

$SL_unreadable_save_title = "Error";
$SL_unreadable_save_msg = "Incompatible (old format), or corrupted savegame.";

$SL_mismatched_mods_save_title = "Error";
$SL_mismatched_mods_save_msg = "This save uses different mods than those which are currently loaded.";

$SL_old_save_title = "Extreme Warning";
$SL_old_save_msg = "DO NOT LOAD THIS FILE if you want to play the game without issues. This save contains old data and is very likely to CRASH your game or BREAK your progression. We strongly recommend to start a new game.<br><br>Are you ABSOLUTELY sure you want to load this game?";

$SL_prerelease_save_title = "Warning";
$SL_prerelease_save_msg = "This is a pre-release save, it may be missing some data. We recommend to start a new game.<br><br>Are you sure you want to load this game?";

$SL_overwrite_title = "上書きしますか？";
$SL_overwrite_msg = "本当にこのデータに上書きしますか？";
$SL_delete_title = "削除しますか？";
$SL_delete_msg = "本当にこのデータを削除しますか？";

// Gameplay messages
$gameplay_msg_ambush_title = "Ambush";
$gameplay_msg_ambush_msg = "Leave the area?";

$gameplay_msg_leave_house = "Leave the house?";
$gameplay_msg_abandoned_house_title = "Abandoned House";
$gameplay_msg_darganus_house_title = "Darganus House";
$gameplay_msg_hector_house_title = "Hector's House";