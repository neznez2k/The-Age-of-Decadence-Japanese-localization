//--- OBJECT WRITE BEGIN ---
new SimGroup(SE_slides_group) {
   canSave = "1";
   canSaveDynamicFields = "1";

   new SimObject(slide0) {
      canSave = "1";
      canSaveDynamicFields = "1";
         script = "$SS_text = 3;";
         sid = "0";
         sname = "Slide 0";
         text0 = "<spush><font:Kinto Sans:20><color:FEFEFEFF>ようこそ　the Age of Decadence　へ！<spop>\n\n初めてゲームをプレイする場合は、まず戦闘のチュートリアルを試して、様々な攻撃タイプやステータス・スキルの効果に慣れるのが良いでしょう。\n\n戦闘は非常に難しいです。特に、逃げることができる戦闘に関しては。最初のプレイではスキルポイントをあまり広範に取らないことをお勧めします。ファイターでプレイしている場合は、システムをよく理解し、少ないリソースでプレイする方法を理解するまでは、２～３個の戦闘スキルに留めてください。\n\n勝ち目は常に薄く、チャンスをつかむには最善手を打たなければならないように感じるかもしれませんが、ゲームが提供する様々なツールを使うことで簡単に優位に立つことができます。\n\n以下のガイドでは、the Age of Decadenceのキャラクター、戦闘、クラフト、錬金術のシステムの最も重要な概念を簡単に説明しています。\n\n\n\n* * *\n\n<spush><font:Kinto Sans:16><color:FEFEFEFF>カメラはQとEか、真ん中のボタンを押してマウスを動かすことで回転できることに注意してください。<spop>";
         text_id0 = "3";
         type = "4";
   };
   new SimObject(slide1) {
      canSave = "1";
      canSaveDynamicFields = "1";
         script = "$SS_text = 1;";
         sid = "1";
         sname = "Slide 1";
         text0 = "<spush><font:Kinto Sans:20><color:FEFEFEFF>1. CHARACTER SYSTEM<spop>\n\nThere are six primary statistics defining a character\'s innate physical and mental abilities. Between them they determine the starting combat and civic skill pools, bonus Skill Points awarded, derived stats (Hit Points & Action Points), combat initiative, as well as modifiers for accuracy and reputation. They are also regularly checked in dialogue and interactive text segments to allow access to specific gameplay options.\n\n<lmargin%:10>Strength (STR) - determines a character\'s damage modifiers and maximum carry weight.\nDexterity (DEX) - determines a character\'s Action Points and combat initiative.\nConstitution (CON) - determines a character\'s Hit Points and poison/toxic resistance.\nPerception (PER) - determines a character\'s accuracy modifiers and combat initiative.\nIntelligence (INT) - determines a character\'s bonus Skill Points.\nCharisma (CHA) - determines a character\'s reputation modifiers.\n\n<lmargin%:0>Derived statistics:\n\n<lmargin%:10>Hit Points (HP) - determine how much damage a character can soak up before dying, you\'re dead if it reaches 0 or less. (HP = CON x 5 + 10)\nAction Points (AP) - determine how many actions a character can make during a combat turn. Different actions have varying action cost. (AP = DEX + 2)\n\n<lmargin%:0>Please note that once determined during the character creation phase, your character\'s HP will not be increased - unlike many other RPGs, there are no character progression levels and the HP value is static throughout the game. Consider your decisions carefully.";
         text_id0 = "1";
         type = "4";
   };
   new SimObject(slide2) {
      canSave = "1";
      canSaveDynamicFields = "1";
         script = "$SS_text = 1;";
         sid = "2";
         sname = "Slide 2";
         text0 = "<spush><font:Kinto Sans:20><color:FEFEFEFF>2. INTRODUCTION TO COMBAT<spop>\n\nThe combat in Age of Decadence is turn based, which means that each participant takes a turn and has a certain number of action points to use performing actions during each round. Once you enter combat, the fastest (or more perceptive or higher skilled) combatant will get to act first.\n\n<just:center>Scroll down\n\n<bitmap:scripts\\data\\slides\\help_combat.png>\n<sbreak>\n<just:left>When it\'s your turn, you will see a grid of squares surrounding your character. Take note of your hit points on the left and your action points on the right of your two weapon slots. On the far left is an information window that gives you more details about exactly what\'s going on during battle.\n\nBlue coloured squares are ones where you\'ve enough action points to move during this turn, and if you hover the mouse over one the action point cost of moving to that square will pop up. Green coloured squares are those you can attack with your currently selected weapon (slot highlighted in yellow) and this is dependent on weapon reach and remaining action points.\n\nMove the mouse over a potential target on a green square and the name of the target, their rough state of health, and the likelihood of hitting them will pop up. Dark green means you can move or attack that square and red means that you can do neither.\n\nYour character\'s Dexterity determines how many action points are available during each turn. Each action performed - swinging a sword, changing your equipment, throwing a net, moving away, etc - has an associated AP cost. For example, a normal attack with a dagger (a fast weapon) takes 3AP, while a normal attack with a two handed hammer (a slow weapon) takes 6AP. Accessing your inventory during combat is a free action, but making any changes to your equipment has an AP cost depending on the item. There are two weapon slots, so either two one-handed weapons or a single two-handed weapon can be equipped at a time. The weapon\'s damage, range, and AP cost (modified by your stats, attack type, and ammo type) are displayed in the weapon slot. Right-click on the weapon slot to open a menu with the available attack options.";
         text_id0 = "1";
         type = "4";
   };
   new SimObject(slide3) {
      canSave = "1";
      canSaveDynamicFields = "1";
         script = "$SS_text = 3;";
         sid = "3";
         sname = "Slide 3";
         text0 = "<spush><font:Kinto Sans:20><color:FEFEFEFF>3. ATTACK TYPES<spop>\n\nAll weapons (except for crossbows) have fast, regular, and power attack options.\n\n<lmargin%:10>Normal attacks - standard attacks that have no modifiers.\nFast attacks - cause less damage, cost one AP less, but are more difficult to avoid. Generally most effective against fast, lightly armored opponents.\nPower attacks - cause a lot more damage, cost an extra AP, but are easier to avoid. Generally most effective against slow, heavy armored opponents.\n\n<lmargin%:0>Aimed attacks sometimes cost some extra AP\'s, have different damage ranges, to-hit penalties, effects, and may have weapon class restrictions.\n\n<lmargin%:10>Head - penalty to attack on a successful hit, knockout for 2 turns and a penalty to Perception on a critical hit.\nTorso (targets armor\'s weak spots; swords, daggers, spears, ranged weapons only) - DR reduced by 30% on a successful hit, DR reduced by 70% and a penalty to Constitution on a critical hit.\nArms - penalty to attack on a successful hit, disarm and a penalty to Strength on a critical hit.\nLegs - penalty to dodge on a successful hit, cripple and a penalty to Dexterity on a critical hit.\n\nSpecial attacks: Whirlwind (melee weapons), Swing (two handed weapons except spears, half the range of whirlwind), Double Tap (two handed weapons except spears), Cleave (two handed weapons except spears, increased critical chance), Impale (spears only), Flurry (daggers only), Multishot (bows and throwing only), Burst (repeater crossbow only), Knockdown (hammers only), and Arterial Strike (daggers, swords, spears, and ranged only).\n\n<lmargin%:0>The versatility of crossbows comes from the different designs available: one-handed, double-shot, scoped, repeating with a magazine, etc. Unlike bows, crossbows have to be manually reloaded. You can right-click on a weapon to see the options available.\n\nYou can also use your shield to bash enemies and push them away, feint to trade places with your opponent, throwing nets and bolas to entangle or even choke your enemies.";
         text_id0 = "3";
         type = "4";
   };
   new SimObject(slide4) {
      canSave = "1";
      canSaveDynamicFields = "1";
         script = "$SS_text = 1;";
         sid = "4";
         sname = "Slide 4";
         text0 = "<spush><font:Kinto Sans:20><color:FEFEFEFF>4. CRITICAL STRIKES<spop>\n\nCritical strikes do more damage (20-40% extra damage tied to the size of your weapon), can cause bleeding, and even lower one of the physical stats on a successful roll.\n\nThe likelihood of critical strikes is governed by the attackers critical strike skill compared with the defenders \'vs critical\' score, which is the higher of armour vsCritical, shield vsCritical, or 0.6 x CS-skill. Strikes to the head are compared to the higher of the helmet vsCritical or 0.6 x CS-skill. It\'s very important once your character is pitted against more skilful and experienced opponents that they have some defense against critical strikes, as many fights are all but decided by well placed or lucky blows. Even if you\'re built like a tank, getting stabbed in the liver puts a crimp in anyone\'s style and longevity!";
         text_id0 = "1";
         type = "4";
   };
   new SimObject(slide5) {
      canSave = "1";
      canSaveDynamicFields = "1";
         script = "$SS_text = 1;";
         sid = "5";
         sname = "Slide 5";
         text0 = "<spush><font:Kinto Sans:20><color:FEFEFEFF>5. WEAPONS<spop>\n\nAll weapons have 3 important statistics: damage range, attack speed in action points, and reach. Additionally, crossbows have fire/reload speed and, in some cases, multishot capacity. Some weapons have special abilities like ignoring shields or cutting into the enemy\'s armor more effectively.\n\nThe game offers eight different types of weapon. Each type has its own passive trait that increases along with your skill with the weapon. The higher the skill, the higher the chance to score the special effect associated with your weapon.\n\n<lmargin%:10>Daggers - higher chance of critical strike when using aimed attacks.\nSwords - chance of causing bleeding (the effect stacks).\nAxes - increases critical strike damage.\nHammers - chance to dent armor, reducing its DR by 1.\nSpears - interrupt attempts to close in.\nBows - chance to cripple for 2 turns (double movement cost).\nCrossbows - chance to stagger your opponent (-3 AP).\nThrowing - chance to bypass armor.\n\n<lmargin%:0>Certain weapons offer special bonuses, such as a bonus to the passive effect of the weapon, a bonus to counter-attack, higher DR penetration (vsDR) or a to-hit bonus.";
         text_id0 = "1";
         type = "4";
   };
   new SimObject(slide6) {
      canSave = "1";
      canSaveDynamicFields = "1";
         script = "$SS_text = 1;";
         sid = "6";
         sname = "Slide 6";
         text0 = "<spush><font:Kinto Sans:20><color:FEFEFEFF>6. ARMOR<spop>\n\nArmor doesn\'t increase your chance to avoid attacks. In fact, it makes hits more likely as it reduces your mobility and makes it harder to dodge incoming attacks. However, armor absorbs some of the damage from attacks when you fail to dodge or block an attack successfully. Basically, using armor trades Dodge and Action Points for Damage Resistance.\n\nDifferent armor has different statistics, so you must consider carefully what your fighting style is and choose your equipment accordingly. Going for the heaviest armor and the biggest weapon may not be the best choice in the Age of Decadence.\n\nKey armor statistics:\n\nDamage resistance (DR) - how many points of damage from each attack this armor absorbs. For example, if DR is 6, then the first 6 points of damage per attack will be absorbed by the armor without any harm to your character. Note that damage reported in the info window is the amount of damage taken, after the amount absorbed by the armor has been subtracted, which is also reported.\n\nMax Action Points (Max AP) - the maximum amount of action points per turn. If the armor\'s maximum AP is 8, then even if you have 12AP, while you\'re wearing this armor your effective AP is 8.\n\nHardness - your armor can be damaged during attacks, Hardness measures its ability to resist such damage.\n\nArmor Penalty (to Dodge & Block Defense) - your armor reduces your mobility, so choose the right armor wisely and don\'t assume that bigger armor is better for all characters.\n\nSneak penalty - can be checked in some dialogue and interactive text segments.\n\nVersus critical (vsCritical) - protection against Critical Strikes (attacks that target weak armor spots and vital organs).";
         text_id0 = "1";
         type = "4";
   };
   new SimObject(slide7) {
      canSave = "1";
      canSaveDynamicFields = "1";
         script = "$SS_text = 1;";
         sid = "7";
         sname = "Slide 7";
         text0 = "<spush><font:Kinto Sans:20><color:FEFEFEFF>7. HELMETS<spop>\n\nHelmets protect the head of the wearer, however they do not add to overall defense. Their statistics are only utilised when struck on the head. Not all opponents will aim attacks at the head, but leaving it unprotected will definitely be considered an open invitation by many more experienced and skilled opponents.\n\nHelmet statistics:\n\nDamage resistance (DR) - usually less than most armor DR, so even if you fail to score a critical hit, you\'ll cause more damage if you can actually hit someone\'s head.\n\nHardness - measures your helmet ability to resist a damage during head aimed attacks.\n\nVersus critical (vsCritical) - the heavier the helmet, the better it protects you against critical strikes, but the more it limits your field of vision.\n\nTo-hit penalty - a helmet\'s design may limit your vision, thus reducing your to-hit chance.";
         text_id0 = "1";
         type = "4";
   };
   new SimObject(slide8) {
      canSave = "1";
      canSaveDynamicFields = "1";
         script = "$SS_text = 1;";
         sid = "8";
         sname = "Slide 8";
         text0 = "<spush><font:Kinto Sans:20><color:FEFEFEFF>8. SHIELDS<spop>\n\nShields are used for blocking incoming strikes depending on a fighters\' skill at blocking, and is an alternative to dodging attacks. Blocking is only used when holding a shield and having a block skill which is greater than dodge. All shields have a DR (damage resistance they can absorb) stat, which is offset by a to-hit penalty. Any novice can hide behind a tower shield, but the shield strapped to their arm will slow them down and they won\'t be able to attack as effectively as they would have without the shield. There are times when dodge characters may want to consider using a shield for the defense against critical strikes it gives them or ranged attacks, even with the associated armor and to-hit penalties.\n\nYou can also use your shield to bash enemies and push them away.\n\nShield statistics:\n\nDR, Hardness, Armor penalty, Sneak penalty, To-Hit penalty, Versus Critical (vsCritical), and Versus Ranged (vsRanged).\n\nArmor Penalty - your shield (just like your armor) reduces your mobility.\n\nVersus Ranged - shields provide superior protection against all ranged attacks, but certain weapons, like pila (plural of pilum) with 40% chance can go through shields, completely ignoring them.";
         text_id0 = "1";
         type = "4";
   };
   new SimObject(slide9) {
      canSave = "1";
      canSaveDynamicFields = "1";
         script = "$SS_text = 1;";
         sid = "9";
         sname = "Slide 9";
         text0 = "<spush><font:Kinto Sans:20><color:FEFEFEFF>9. AMMUNITION<spop>\n\nFor the sake of convenience, all arrows and bolts have been combined into \'universal ammo\'. Originally, the game had arrows and bolts, but 3 different types times 5 different metals times various alchemy upgrades times 2 (arrows/bolts) was too much to manage and one universal ammo was forged by the Elven Council.\n\nAmmunition types:\n\nRegular - standard ammunition.\n\nArmor piercing - causes less damage, but penetrates through armor better. DR is divided by 2 to determine the effective value, i.e. a DR8 armor will absorb 8 points of damage if shot at by regular ammo and only 4 points (8/2) if hit by armor-piercing ammo.\n\nJagged - causes more damage, but is easily stopped by armor. DR is multiplied by 2 to determine the effective value, i.e. a DR1 armor will absorb 2 points of damage, but a DR4 armor will absorb 8 points of damage.";
         text_id0 = "1";
         type = "4";
   };
   new SimObject(slide10) {
      canSave = "1";
      canSaveDynamicFields = "1";
         script = "$SS_text = 1;";
         sid = "10";
         sname = "Slide 10";
         text0 = "<spush><font:Kinto Sans:20><color:FEFEFEFF>10. INTRODUCTION TO CRAFTING<spop>\n\nYou can use the Crafting system to create weapons and armor using schematics (available from blacksmiths) and different material (metal ingots, wood, or leather). Weapons, armor, helmets, and shields can be crafted to increase their stats or lower penalties. The power and number of techniques you can apply to an item will grow with your Crafting skill.";
         text_id0 = "1";
         type = "4";
   };
   new SimObject(slide11) {
      canSave = "1";
      canSaveDynamicFields = "1";
         script = "$SS_text = 1;";
         sid = "11";
         sname = "Slide 11";
         text0 = "<spush><font:Kinto Sans:20><color:FEFEFEFF>11. TECHNIQUES<spop>\n\nYou can check the list of all available techniques from the full game in the journal.\n\nThere are five different metal types: bronze, iron, steel, blue steel, sky metal. Each \"higher\" metal increases the damage range or damage resistance by 1. So, whereas a bronze gladius does 5-8 points of damage, a iron gladius does 6-9, steel 7-10, and so on.\n\nThe Masterwork technique can help you improve your weapons\' passive ability further. The Balanced technique gives your weapon a THC (to-hit-chance) bonus. Hardness increases the chance of denting an enemy\'s armor, reducing the armor\'s DR. Serrated Edge increases your chance to score a critical strike.";
         text_id0 = "1";
         type = "4";
   };
   new SimObject(slide12) {
      canSave = "1";
      canSaveDynamicFields = "1";
         script = "$SS_text = 1;";
         sid = "12";
         sname = "Slide 12";
         text0 = "<spush><font:Kinto Sans:20><color:FEFEFEFF>12. CRAFTING AND DECOMPOSING<spop>\n\nTo craft an item, open your inventory and go to the crafting tab. Select an item from the list of available schematics, apply any known technique(s), select a metal type or component, and click Forge. When the item is ready, drag it back to the inventory.\n\nYou can also decompose (melt) weapons and armor to get metal ingots or components. There is a material loss when you decompose, the higher the skill the less metal you lose.\n\nFor example, if you find a blue steel heavy armor that weighs 35 pounds, but you would rather forge yourself a blue steel sword and a lighter armor, you can melt the heavy armor, losing, for example, 20% of the metal and getting 28 pounds of blue steel ingots, which you can use to craft yourself a broadsword (handar) - 3.5 pounds - and a cuirass (lorica musculata) - 20 pounds.";
         text_id0 = "1";
         type = "4";
   };
   new SimObject(slide13) {
      canSave = "1";
      canSaveDynamicFields = "1";
         script = "$SS_text = 1;";
         sid = "13";
         sname = "Slide 13";
         text0 = "<spush><font:Kinto Sans:20><color:FEFEFEFF>13. INTRODUCTION TO ALCHEMY<spop>\n\nYou can use the Alchemy system to create various potions that can temporarily improve or modify your character\'s abilities, poison to coat your weapons, and flasks/bombs that can be thrown at your enemies.\n\nYou will acquire different techniques by leveling up your skill, and you can gather reagents from plants and containers, or get them from traders. For a \"starter kit\", talk to the alchemist at Teron\'s inn when you start the game.\n\nThere are seven different techniques, plus two modifiers for each technique (i.e. 21 different items). You can create:\n\n-\tHealing salve\n-Restorative liniment\n-Regeneration potion\n-\tBerserk potion\n-Berserk potion (extended)\n-Berserk potion (hemostasis)\n-\tPoison\n-Poison (potent)\n-Antidote\n-\tNeurostimulant\n-Neurostimulat (extended)\n-Neurostimulant (eagle eye)\n-\tAcid\n-Acid (Strong)\n-Acid (Splash)\n-\tLiquid Fire\n-Liquid Fire (Strong)\n-Liquid Fire (Burning)\n-\tBlack Powder Bomb\n-Black Powder Bomb (strong)\n-Black Powder Bomb (fragmentation)\n\nTo create an alchemical item you need a base reagent. For example, to create a basic bomb, you need the black powder (drag it to the first slot on the alchemy screen). To create a fragmentation bomb that works better against armored opponents, you need to add iron balls (drag them to the second slot).\n\nKeep in mind that it\'s not just the raw damage that matters. The bomb, for example, can knock down your enemies, while the liquid fire can separate them, which is an invaluable ability.";
         text_id0 = "1";
         type = "4";
   };
};
//--- OBJECT WRITE END ---
