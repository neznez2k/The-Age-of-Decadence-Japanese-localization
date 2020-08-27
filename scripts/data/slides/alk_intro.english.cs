//--- OBJECT WRITE BEGIN ---
new SimGroup(SE_slides_group) {
   canSave = "1";
   canSaveDynamicFields = "1";

   new SimObject(slide0) {
      canSave = "1";
      canSaveDynamicFields = "1";
         script = "if(aod.quest_GNZ_MS_status == 4 || aod.pc_member_daratan)\n{\n$SS_text = 2;\n$SS_image = \"start_alk_01.png\";\n}\nelse if(aod.pc_member_guards)\n{\n$SS_text = 3;\n$SS_image = \"start_alk_01.png\";\n}\nelse\n{\n$SS_text = 1;\n$SS_image = \"start_alk_01.png\";\n}\n";
         sid = "0";
         sname = "Slide 0";
         text0 = "<just:center>On the morning of your departure you discover you\'ll be traveling in the company of four grizzled loremasters and, surprisingly, a small detachment of Imperial Guards.\n\nDuring the journey you learn these loremasters aren\'t your typical weekend market hucksters. They learned their trade the old fashioned way, robbing tombs and fighting off brigands. They are also in charge of the expedition, dictating where and when the party will stop in order to accommodate the constant referencing of stars and landmarks against their maps. These consultations regularly lead to heated arguments, almost to the point of blows, all in a language only they understand. The Guards simply keep to themselves.\n\nSix long days under the naked sun bring your group to the ruins of Al-Akia, which at first seem to consist of nothing but a miniature pyramid, barely taller than a grown man. A closer examination of the area reveals four other derelict structures peeking out from the sand, equidistant from the central edifice.";
         text1 = "<just:center>On the morning of your departure you discover you\'ll be traveling in the company of four grizzled loremasters and a small detachment of Crassus Guards.\n\nDuring the journey you learn these loremasters aren\'t your typical weekend market hucksters. They learned their trade the old fashioned way, robbing tombs and fighting off brigands. They are also in charge of the expedition, dictating where and when the party will stop in order to accommodate the constant referencing of stars and landmarks against their maps. These consultations regularly lead to heated arguments, almost to the point of blows, all in a language only they understand. The Guards simply keep to themselves.\n\nSix long days under the naked sun bring your group to the ruins of Al-Akia, which at first seem to consist of nothing but a miniature pyramid, barely taller than a grown man. A closer examination of the area reveals four other derelict structures peeking out from the sand, equidistant from the central edifice.";
         text2 = "<just:center>On the morning of your departure you discover you\'ll be traveling in the company of four grizzled loremasters.\n\nDuring the journey you learn these loremasters aren\'t your typical weekend market hucksters. They learned their trade the old fashioned way, robbing tombs and fighting off brigands. They are also in charge of the expedition, dictating where and when the party will stop in order to accommodate the constant referencing of stars and landmarks against their maps. These consultations regularly lead to heated arguments, almost to the point of blows, all in a language only they understand. The Guards simply keep to themselves.\n\nSix long days under the naked sun bring your group to the ruins of Al-Akia, which at first seem to consist of nothing but a miniature pyramid, barely taller than a grown man. A closer examination of the area reveals four other derelict structures peeking out from the sand, equidistant from the central edifice.";
         text_id0 = "1";
         text_id1 = "2";
         text_id2 = "3";
         type = "5";
   };
};
//--- OBJECT WRITE END ---
