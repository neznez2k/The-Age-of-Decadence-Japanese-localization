//--- OBJECT WRITE BEGIN ---
new SimGroup(SE_slides_group) {
   canSave = "1";
   canSaveDynamicFields = "1";

   new SimObject(slide0) {
      canSave = "1";
      canSaveDynamicFields = "1";
         script = "if(aod.gnz_siegeIntro)\n{\n$SS_text = 1;\n$SS_image = \"start_gnz_01.png\";\n}\nelse if(aod.gnz_siegeComing)\n{\n$SS_text = 3;\n$SS_image = \"start_gnz_03.png\";\naod.gnz_siegeComing = false;\n}\nelse if(aod.quest_ig8_introGanezzar)\n{\n$SS_text = 4;\n$SS_image = \"start_gnz_04.png\";\n}\nelse\n{\n$SS_text = 2;\n$SS_image = \"start_gnz_02.png\";\n}";
         sid = "0";
         sname = "Slide 0";
         text0 = "<just:center>Beyond the embers of your dying campfire, you first mistook the lights of the holy city for a new constellation, so high were they above the horizon. Over the next two days the craggy profile of Castle Ganezzar sets the caravan\'s course, as if it were a lighthouse guiding you across the plain.\n\nThe city\'s magic and mystery fades, however, as you come closer. The famous citadel squats grim and unadorned atop its massive hill, with the city arranged in cascading levels on the slopes beneath, like rings of fungus choking the last vestiges of life from a ruined tree.\n\nCloser still, a shroud of smoke about the base of the hill marks the ordered chaos of a military camp. The purple banners snapping in the unforgiving plains wind proclaim this sea of tents the domain of House Aurelian. The siege of Ganezzar has begun.";
         text1 = "\n<just:center>Beyond the embers of your dying campfire, you first mistook the lights of the holy city for a new constellation, so high were they above the horizon. Over the next two days the craggy profile of Castle Ganezzar sets the caravan\'s course, as if it were a lighthouse guiding you across the plain.\n\nThe city\'s magic and mystery fades, however, as you come closer. The famous citadel squats grim and unadorned atop its massive hill, with the city arranged in cascading levels on the slopes beneath, like rings of fungus choking the last vestiges of life from a ruined tree.";
         text2 = "\n<just:center>On the third day of your journey a dust storm forces you to seek shelter and wait it out. The storm cloud seems to follow you, hanging over the horizon. It takes you a while to realize that it\'s not a cloud but an army on the move, heading to the same place you are - Ganezzar.\n\nWhatever secrets Al-Akia holds, House Aurelian is clearly prepared to start a war to keep them buried. ";
         text3 = "\n<just:center>You realize that things went horribly wrong when you return to Ganezzar and see a multitude of campfires and tents, Aurelian standards flying above them. An attack on your expedition was one thing - the Aurelians were always touchy when it came to ruins and magic, but laying a siege to Ganezzar is an entirely different story, signaling a major escalation and willingness to prevent House Crassus from poking in ruins ever again.";
         text_id0 = "1";
         text_id1 = "2";
         text_id2 = "3";
         text_id3 = "4";
         type = "5";
   };
};
//--- OBJECT WRITE END ---
