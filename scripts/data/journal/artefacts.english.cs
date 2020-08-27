function Artefact_Sphere()
{
   $js_item_name[0] = "Sphere";
   $js_item_desc[0] = "A small grooved sphere made of grey metal you don't recognize. The grooves are too deep and precise to be purely decorative.";   
   
   jsSetItemImage("art/gui/journal/sphere.png");
   jsSetItemName(0);
   jsSetItemDesc(0);
}

function Artefact_Respirator1()
{
   $js_item_name[0] = "Prospector's Amulet";
   $js_item_desc[0] = "Adorned with beads and engraved with runes, it appears to be a ceremonial bowl of some sort. Strangely warped, but that isn't unusual for artefacts of the Old Empire. Who knows what arcane forces had been unleashed on it? Two small, metal drums are affixed to the underside, too awkwardly angled to be supports for the bowl. Reservoirs, perhaps, containers of sacred liquid for the bowl?";
   $js_item_name[1] = "Respirator";
   $js_item_desc[1] = "A breathing apparatus of the Old Empire. When charged with magical energies, it will allow you to breath in toxic environments. A valuable artefact, it's been handed down the generations from father to son. The magic powering up the device eventually ran out and the purpose was lost. All that was remembered is that it was a powerful charm protecting its wearer from unseen danger.";
   
   jsSetItemImage("art/gui/journal/respirator_01.png");
   
   if (aod.artefact_respirator1_identified == false)
   {
      jsSetItemName(0);
      jsSetItemDesc(0);
   }
   else
   {
      jsSetItemName(1);
      jsSetItemDesc(1);
   }
}

function Artefact_Respirator2()
{
   $js_item_name[0] = "Strange Device";
   $js_item_desc[0] = "A strange device of unknown purpose.";
   $js_item_name[1] = "Respirator";
   $js_item_desc[1] = "A breathing apparatus of the Old Empire. When charged with magical energies, it will allow you to breath in toxic environments.";
   
   jsSetItemImage("art/gui/journal/respirator_02.png");
   
   if (aod.artefact_respirator2_identified == false)
   {
      jsSetItemName(0);
      jsSetItemDesc(0);
   }
   else
   {
      jsSetItemName(1);
      jsSetItemDesc(1);
   }
}

function Artefact_Eye_ThorAgoth()
{
   $js_item_name[0] = "The Eye of Thor-Agoth";
   $js_item_desc[0] = "A large, round tri color crystal framed in gold. The center of the crystal is completely black, making it look like an eye.";   
   
   jsSetItemImage("art/gui/journal/eye_thor_agoth.png");
   jsSetItemName(0);
   jsSetItemDesc(0);
}

function Artefact_Power_Tube()
{
   $js_item_name[0] = "Power Tube";
   $js_item_desc[0] = "A small glass tube encased in elaborate metal framework. The tube is very warm to the touch and contains what appears to be constantly shifting liquid fire. The Magi of old used to craft such holy vessels to contain the essence of the divine, the very breath of a God. It is said that with such a relic one can breathe life into any machine. Truly, a rare and valuable find.";
   
   jsSetItemImage("art/gui/journal/powerTube.png");
   jsSetItemName(0);
   jsSetItemDesc(0);
}

function Artefact_Jellyfish()
{
   $js_item_name[0] = "Jellyfish Artefact";
   $js_item_desc[0] = "A crystal semi-sphere, encased in a metal dome. Thin metal rods of varying lengths protrude from the bottom, reminding you of a jellyfish. The crystal, despite having been buried under brick and stagnant water for centuries, glows with a pure, blue light.";
   
   jsSetItemImage("art/gui/journal/jellyfish.png");
   jsSetItemName(0);
   jsSetItemDesc(0);
}

function Artefact_Helmet_Destiny()
{
   $js_item_name[0] = "Helm of Destiny";
   $js_item_desc[0] = "The famous Helm of Destiny. Contrary to your expectations, it's an unadorned helmet made of grey metal. When you put it on, you heard a voice, strange and distant, as if coming over a great distance. It said one word – Ganezzar.";
   
   jsSetItemImage("art/gui/journal/Helmet_Destiny.png");
   jsSetItemName(0);
   jsSetItemDesc(0);
}

function Artefact_Demon_Core()
{
   $js_item_name[0] = "Demon Core";
   $js_item_desc[0] = "A heavy, glowing stone, radiating heat. It's the power core that sustained and animated the stone guardian of the tower.";
   
   jsSetItemImage("art/gui/journal/demonCore.png");
   jsSetItemName(0);
   jsSetItemDesc(0);
}

function Artefact_Crimson_Eye()
{
   $js_item_name[0] = "Mysterious Reliquary";
   $js_item_desc[0] = "A heavy, glowing red sphere, encased in a bronze reliquary.";
   $js_item_name[1] = "The Crimson Eye";
   $js_item_desc[1] = "A heavy, glowing red sphere, encased in a bronze reliquary. It's a key to the tower of Zamedi. ";
   
   jsSetItemImage("art/gui/journal/crimsonEye.png");
   
   if (aod.artefact_crimsonEye_identified == false)
   {
      jsSetItemName(0);
      jsSetItemDesc(0);
   }
   else
   {
      jsSetItemName(1);
      jsSetItemDesc(1);
   }
}

function Artefact_Magic_Jar()
{
   $js_item_name[0] = "Magic Jar";
   $js_item_desc[0] = "A strange, softly glowing jar.";
   $js_item_name[1] = "Healing Canister";
   $js_item_desc[1] = "A strange, softly glowing jar. Such canisters were said to contain alchemical compounds that could alter or repair “cells”, whatever they might be.";
   
   jsSetItemImage("art/gui/journal/Magic_Jar.png");
   
   if (aod.artefact_magicJar_identified == false)
   {
      jsSetItemName(0);
      jsSetItemDesc(0);
   }
   else
   {
      jsSetItemName(1);
      jsSetItemDesc(1);
   }
}

function Artefact_Nullifier()
{
   $js_item_name[0] = "Mysterious Artefact";
   $js_item_desc[0] = "A delicate, golden device with a small dial and a couple of buttons. There is a symbol on the other side – a circle with a diagonal line through it. A null?";
   
    jsSetItemImage("art/gui/journal/Nullifier.png");
   jsSetItemName(0);
   jsSetItemDesc(0);
}

function Artefact_Mechanical_Eye()
{
   $js_item_name[0] = "Mechanical Eye";
   $js_item_desc[0] = "The ball of this fancy fake eye is a cloudy blue, a gem unlike any you have seen.  The back of the device has eight hinged, outward-curving grips around the circumference, which on insertion would anchor it in the empty socket permanently.  The long, metal tube protruding from the back is a bit of a mystery. You notice it's hollow, and about wide enough to fit the thick nerve that runs to the back of a living eye.";
   
   jsSetItemImage("art/gui/journal/Mechanical_Eye.png");
   jsSetItemName(0);
   jsSetItemDesc(0);
}

function Artefact_Gem()
{
   $js_item_name[0] = "Yellow Sapphire";
   $js_item_desc[0] = "A rare yellow sapphire cut to perfection. The center of the gem is very dark, almost making it look like an eye.";
   
    jsSetItemImage("art/gui/journal/Gem.png");
   jsSetItemName(0);
   jsSetItemDesc(0);
}

function Artefact_Metal_Glove()
{
   $js_item_name[0] = "Metal Glove";
   $js_item_desc[0] = "A strange, metal glove of unknown purpose. It takes three 'tubes' to power it up, so whatever the glove does requires a lot of magical energy.";
   $js_item_name[1] = "Ghost Hand";
   $js_item_desc[1] = "It was said that some machines could never function in this world for they required different laws of physics. Thus, the Magi had built them in realms that exist elsewhere. They called them the Ghost Worlds and used devices such as this one to bridge the gap between these worlds and ours.";
   
    jsSetItemImage("art/gui/journal/Metal_Glove.png");
   
   if (aod.artefact_metalglove_identified == false)
   {
      jsSetItemName(0);
      jsSetItemDesc(0);
   }
   else
   {
      jsSetItemName(1);
      jsSetItemDesc(1);
   }
}

function Artefact_Tower_Ring()
{
   $js_item_name[0] = "Magus Ring";
   $js_item_desc[0] = "The ring is heavier than it looks and has three rotating bands with markings on them. Its purpose is unknown.";
   $js_item_name[1] = "Magis Ring";
   $js_item_desc[1] = "The ring is heavier than it looks and has three rotating bands with markings on them. The markings on the bands indicate distance and power level. The ring doesn't control the stone guardian directly, but it controls the core.";
   
    jsSetItemImage("art/gui/journal/Tower_Ring.png");
   
   if (aod.artefact_towerring_identified == false)
   {
      jsSetItemName(0);
      jsSetItemDesc(0);
   }
   else
   {
      jsSetItemName(1);
      jsSetItemDesc(1);
   }
}

function Artefact_Surgical_Kit()
{
   $js_item_name[0] = "Surgical Kit";
   $js_item_desc[0] = "The case contains a folded section of parchment and what looks like a set of surgical instruments. There are both smooth and serrated blades of various sizes, hooks to part flesh, a drill with different bits, a few unpleasantly large needles, and a strange metal syringe that incorporates a dead power tube. Every item is gleaming and sharp, as if begging to be used for the first time.";
   
   jsSetItemImage("art/gui/journal/surgicalKit.png");
   jsSetItemName(0);
   jsSetItemDesc(0);
}

function Artefact_Aegis()
{
   $js_item_name[0] = "Aegis of the Magi";
   $js_item_desc[0] = "A strange suit of armor.";
   $js_item_name[1] = "Aegis of the Magi";
   $js_item_desc[1] = "This armor was designed to protect its wearer from harm in otherworldly realms.";
   
    jsSetItemImage("art/gui/journal/aegisOfTheMagi.png");
   
   if (aod.artefact_aegis_identified == false)
   {
      jsSetItemName(0);
      jsSetItemDesc(0);
   }
   else
   {
      jsSetItemName(1);
      jsSetItemDesc(1);
   }
}