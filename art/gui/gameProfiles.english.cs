//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// Game specific profiles are located here
//-----------------------------------------------------------------------------

singleton GizmoProfile(PlaceholderGizmoProfile)
{
   screenLength = 100;
};

singleton GuiControlProfile (GuiRTSContentProfile)
{
   fontType = "Noto Serif CJK JP";
   
   fontColor = "225 225 225";
   fontColorHL = "255 255 255";
   fontColorNA = "0 0 0";
   fontColorSEL = "200 200 200";
   
   fontColors[4] = "16 16 16";      //text shadow
   fontColors[5] = "255 225 155";   //text main color
   fontColors[6] = "225 10 10";     //text red
   
   fontSize = 25;
   
   category = "ITS";
   canKeyFocus = true;
   opaque = true;
   fillColor = "0 0 0";
   
   fontRescaling = true;
};

singleton GuiControlProfile (GuiRTSContentProfile_1080)
{
   fontType = "Noto Serif CJK JP";
   
   fontColor = "225 225 225";
   fontColorHL = "255 255 255";
   fontColorNA = "0 0 0";
   fontColorSEL = "200 200 200";
   
   fontColors[4] = "16 16 16";      //text shadow
   fontColors[5] = "255 225 155";   //text main color
   fontColors[6] = "225 10 10";     //text red
   
   fontSize = 30;
   
   category = "ITS";
   canKeyFocus = true;
   opaque = true;
   fillColor = "0 0 0";
   
   fontRescaling = true;
};

singleton GuiControlProfile (GuiRTSContentProfile_1440)
{
   fontType = "Noto Serif CJK JP";
   
   fontColor = "225 225 225";
   fontColorHL = "255 255 255";
   fontColorNA = "0 0 0";
   fontColorSEL = "200 200 200";
   
   fontColors[4] = "16 16 16";      //text shadow
   fontColors[5] = "255 225 155";   //text main color
   fontColors[6] = "225 10 10";     //text red
   
   fontSize = 37;
   
   category = "ITS";
   canKeyFocus = true;
   opaque = true;
   fillColor = "0 0 0";
   
   fontRescaling = true;
};


//
// Kolika text profiles ----------------------------------------
//

singleton GuiControlProfile (KokilaBase)
{
   fontType = "Noto Serif CJK JP";
   
   fontColor = "220 200 165";
   fontColorHL = "255 255 255";
   fontColorNA = "0 0 0";
   fontColorSEL = "200 200 200";
   
   fontColors[6] = "255 0 0"; //clseAttention
   
   category = "AoD";
};

//
// Candara text profiles ----------------------------------------
//

singleton GuiControlProfile (CandaraBase)
{
   fontType = "Noto Serif CJK JP";
   
   fontColor = "220 200 165";
   fontColorHL = "255 255 255";
   fontColorNA = "0 0 0";
   fontColorSEL = "200 200 200";
   
   fontColors[6] = "255 0 0"; //clseAttention
   
   category = "AoD";
   
   fontRescaling = true;
};

singleton GuiControlProfile (CandaraWhite)
{
   fontType = "Noto Serif CJK JP";
   
   fontColor = "255 255 255";
   fontColorHL = "255 255 255";
   fontColorNA = "0 0 0";
   fontColorSEL = "200 200 200";
   
   fontColors[6] = "255 0 0"; //clseAttention
   
   category = "AoD";
   
   fontRescaling = true;
};

singleton GuiControlProfile (Candara_12 : CandaraBase)
{
   fontSize = 15;

   justify = "left";
};

singleton GuiControlProfile (Candara_14 : CandaraBase)
{
   fontSize = 17;

   justify = "left";
};

singleton GuiControlProfile (Candara_14_Right : CandaraBase)
{
   fontSize = 18;

   justify = "right";
};

singleton GuiControlProfile (Candara_15 : CandaraBase)
{
   fontSize = 19;

   justify = "left";
};

singleton GuiControlProfile (Candara_16 : CandaraBase)
{
   fontSize = 20;

   justify = "left";
};

singleton GuiControlProfile (Candara_17 : CandaraBase)
{
   fontSize = 21;

   justify = "left";
};

singleton GuiControlProfile (Candara_18 : CandaraBase)
{
   fontSize = 22;

   justify = "left";
};

singleton GuiControlProfile (Candara_19 : CandaraBase)
{
   fontSize = 19;

   justify = "left";
};

singleton GuiControlProfile (Candara_20 : CandaraBase)
{
   fontSize = 25;

   justify = "left";
};

singleton GuiControlProfile (Candara_21 : CandaraBase)
{
   fontSize = 26;

   justify = "left";
};

singleton GuiControlProfile (Candara_22 : CandaraBase)
{
   fontSize = 27;

   justify = "left";
};

singleton GuiControlProfile (Candara_23 : CandaraBase)
{
   fontSize = 29;

   justify = "left";
};

singleton GuiControlProfile (Candara_24 : CandaraBase)
{
   fontSize = 30;

   justify = "left";
};

singleton GuiControlProfile (Candara_25 : CandaraBase)
{
   fontSize = 31;

   justify = "left";
};

singleton GuiControlProfile (Candara_26 : CandaraBase)
{
   fontSize = 32;

   justify = "left";
};

singleton GuiControlProfile (Candara_28 : CandaraBase) // 1440 Hint Character Creation
{
   fontSize = 35;

   justify = "left";
};

singleton GuiControlProfile (Candara_32 : CandaraBase) // 1440 Dialogue NPC
{
   fontSize = 40;

   justify = "left";
};

singleton GuiControlProfile (Candara_Center_12 : CandaraBase)
{
   fontSize = 15;

   justify = "center";
};

singleton GuiControlProfile (Candara_Center_16 : CandaraBase)
{
   fontSize = 20;

   justify = "center";
};

singleton GuiControlProfile (Candara_Center_17 : CandaraBase)
{
   fontSize = 21;

   justify = "center";
};

singleton GuiControlProfile (Candara_Center_18 : CandaraBase)
{
   fontSize = 22;

   justify = "center";
};

singleton GuiControlProfile (Candara_Center_19 : CandaraBase)
{
   fontSize = 24;

   justify = "center";
};

singleton GuiControlProfile (Candara_Center_20 : CandaraBase)
{
   fontSize = 25;

   justify = "center";
};

singleton GuiControlProfile (Candara_Center_22 : CandaraBase)
{
   fontSize = 27;

   justify = "center";
};

singleton GuiControlProfile (Candara_Center_24 : CandaraBase)
{
   fontSize = 30;

   justify = "center";
};

singleton GuiControlProfile (Candara_Center_26 : CandaraBase)
{
   fontSize = 32;

   justify = "center";
};

singleton GuiControlProfile (Candara_Autosize_17 : CandaraBase)
{
   fontSize = 21;

   justify = "left";
   autoSizeWidth = true;
   autoSizeHeight = true;
};

singleton GuiControlProfile (Candara_Autosize_18 : CandaraBase)
{
   fontSize = 22;

   justify = "left";
   autoSizeWidth = true;
   autoSizeHeight = true;
};

singleton GuiControlProfile (Candara_Autosize_19 : CandaraBase)
{
   fontSize = 24;

   justify = "left";
   autoSizeWidth = true;
   autoSizeHeight = true;
};

singleton GuiControlProfile (Candara_Autosize_20 : CandaraBase)
{
   fontSize = 25;

   justify = "left";
   autoSizeWidth = true;
   autoSizeHeight = true;
};

singleton GuiControlProfile (Candara_Autosize_22 : CandaraBase)
{
   fontSize = 27;

   justify = "left";
   autoSizeWidth = true;
   autoSizeHeight = true;
};

singleton GuiControlProfile (Candara_Autosize_24 : CandaraBase)
{
   fontSize = 30;

   justify = "left";
   autoSizeWidth = true;
   autoSizeHeight = true;
};

singleton GuiControlProfile (Candara_Autosize_32 : CandaraBase) // 1440 PC Dialogue
{
   fontSize = 40;

   justify = "left";
   autoSizeWidth = true;
   autoSizeHeight = true;
};

singleton GuiControlProfile (Candara_Autosize_17_White : CandaraWhite)
{
   fontSize = 21;

   justify = "left";
   autoSizeWidth = true;
   autoSizeHeight = true;
};

singleton GuiControlProfile (Candara_Autosize_18_White : CandaraWhite)
{
   fontSize = 22;

   justify = "left";
   autoSizeWidth = true;
   autoSizeHeight = true;
};

singleton GuiControlProfile (Candara_Autosize_19_White : CandaraWhite)
{
   fontSize = 24;

   justify = "left";
   autoSizeWidth = true;
   autoSizeHeight = true;
};

singleton GuiControlProfile (Candara_Autosize_20_White : CandaraWhite)
{
   fontSize = 25;

   justify = "left";
   autoSizeWidth = true;
   autoSizeHeight = true;
};

singleton GuiControlProfile (Candara_Autosize_22_White : CandaraWhite)
{
   fontSize = 27;

   justify = "left";
   autoSizeWidth = true;
   autoSizeHeight = true;
};

singleton GuiControlProfile (Candara_Autosize_24_White : CandaraWhite)
{
   fontSize = 30;

   justify = "left";
   autoSizeWidth = true;
   autoSizeHeight = true;
};

singleton GuiControlProfile (Candara_Autosize_32_White : CandaraWhite) // 1440 PC Dialogue
{
   fontSize = 40;

   justify = "left";
   autoSizeWidth = true;
   autoSizeHeight = true;
};

//
// KaratMedium text profiles ----------------------------------------
//
singleton GuiControlProfile (KaratMediumBase)
{
   fontType = "Kinto Sans";
   
   fontColor = "236 214 175";
   fontColorHL = "255 255 255";
   fontColorNA = "0 0 0";
   fontColorSEL = "200 200 200";
   
   fontColors[6] = "255 0 0"; //clseAttention
   
   category = "AoD";
};

singleton GuiControlProfile (KaratMediumDark)
{
   fontType = "Noto Serif CJK JP";
   
   fontColor = "171 150 97";
   fontColorHL = "255 225 154";
   fontColorNA = "0 0 0";
   fontColorSEL = "200 200 200";
   
   category = "AoD";
};

singleton GuiControlProfile (GuiMLTextNoSelectProfile : KaratMediumBase)
{
   modal = false;
};

singleton GuiControlProfile(GuiMLTextNoSelectProfile_KM20 : GuiMLTextNoSelectProfile)
{
   fontSize = "25";
};

singleton GuiControlProfile(GuiMLTextNoSelectProfile_KM16 : GuiMLTextNoSelectProfile)
{
   fontSize = "20";
};

// smaller text ---------------------------------------
singleton GuiControlProfile (fbText_11 : KaratMediumBase)
{
   fontSize = 14;

   justify = "left";
   autoSizeWidth = false; 
   autoSizeHeight = true;
};

singleton GuiControlProfile (fbText_12 : KaratMediumBase)
{
   fontSize = 15;

   justify = "left";
   autoSizeWidth = false; 
   autoSizeHeight = true;
};

singleton GuiControlProfile (fbText_13 : KaratMediumBase)
{
   fontSize = 16;

   justify = "left";
   autoSizeWidth = false; 
   autoSizeHeight = true;
};

// 14 pt text ---------------------------------------
singleton GuiControlProfile (fbText_14 : KaratMediumBase)
{
   fontSize = 17;

   justify = "left";
   autoSizeWidth = false; 
   autoSizeHeight = true;
};

singleton GuiControlProfile (fbText_15_Dark : KaratMediumDark)
{
   fontSize = 19;

   justify = "left";
};

singleton GuiControlProfile (fbText_17_Dark : KaratMediumDark)
{
   fontSize = 23;

   justify = "left";
};

singleton GuiControlProfile (fbTextAutosize_14 : KaratMediumBase)
{
   fontSize = 17;
   
   justify = "left";
   autoSizeWidth = true;
   autoSizeHeight = true;
};

singleton GuiControlProfile(fbTextRight_12 : KaratMediumBase)
{
   fontSize = 15;
   
   justify = "right";
   autoSizeWidth = false;
   autoSizeHeight = true;
};

singleton GuiControlProfile (fbTextRight_14 : KaratMediumBase)
{
   fontSize = 18;
   
   justify = "right";
   autoSizeWidth = false;
   autoSizeHeight = true;
};

singleton GuiControlProfile(fbTextCenter_14 : KaratMediumBase)
{
   fontSize = 17;
   
   justify = "center";
   autoSizeWidth = false;
   autoSizeHeight = true;
};

singleton GuiControlProfile(fbTextCenter_14_FResc : fbTextCenter_14)
{
   fontRescaling = true;
};


// 15 pt text ---------------------------------------
singleton GuiControlProfile (fbText_15 : KaratMediumBase)
{
   fontSize = 19;

   justify = "left";
   autoSizeWidth = false;
   autoSizeHeight = true;
};

singleton GuiControlProfile (fbTextAutosize_15 : KaratMediumBase)
{
   fontSize = 19;

   justify = "left";
   autoSizeWidth = true;
   autoSizeHeight = true;
};

singleton GuiControlProfile (fbTextCenter_15 : KaratMediumBase)
{
   fontSize = 19;

   justify = "center";
   autoSizeWidth = false;
   autoSizeHeight = true;
};

singleton GuiControlProfile(fbText_15_white : fbText_15)
{
   fontColors[0] = "254 254 254 255";
   fontColor = "254 254 254 255";
};

// 17 pt text ---------------------------------------
singleton GuiControlProfile (fbText_17 : KaratMediumBase)
{
   fontSize = 21;

   justify = "left";
   autoSizeWidth = false;
   autoSizeHeight = true;
};

singleton GuiControlProfile (fbTextAutosize_17 : KaratMediumBase)
{
   fontSize = 21;

   justify = "left";
   autoSizeWidth = true;
   autoSizeHeight = true;
};

singleton GuiControlProfile (fbTextCenter_17 : KaratMediumBase)
{
   fontSize = 21;

   justify = "center";
   autoSizeWidth = false;
   autoSizeHeight = true;
};

singleton GuiControlProfile(fbText_17_white : fbText_17)
{
   fontColors[0] = "254 254 254 255";
   fontColor = "254 254 254 255";
};

// 19 pt text ---------------------------------------
singleton GuiControlProfile (fbText_19 : KaratMediumBase)
{
   fontSize = 23;

   justify = "left";
   autoSizeWidth = false;
   autoSizeHeight = true;
};

singleton GuiControlProfile (fbTextAutosize_19 : KaratMediumBase)
{
   fontSize = 23;

   justify = "left";
   autoSizeWidth = true;
   autoSizeHeight = true;
};

singleton GuiControlProfile (fbTextCenter_19 : KaratMediumBase)
{
   fontSize = 23;

   justify = "center";
   autoSizeWidth = false;
   autoSizeHeight = true;
};

singleton GuiControlProfile(fbText_19_white : fbText_19)
{
   fontColors[0] = "254 254 254 255";
   fontColor = "254 254 254 255";
};



//
// Charlemagne text profiles ----------------------------------------
//
singleton GuiControlProfile (CharlemagneBase)
{
   fontType = "Kinto Sans";
   
   fontColor = "236 214 175";
   fontColorHL = "255 255 255";
   fontColorNA = "0 0 0";
   fontColorSEL = "200 200 200";
   
   autoSizeHeight = "0";
   
   category = "AoD";
   fontColors[0] = "236 214 175 255";
   fontColors[1] = "255 255 255 255";
   fontColors[3] = "200 200 200 255";
   
   fontRescaling = true;
};

singleton GuiControlProfile(GuiMLTextProfile_CM18 : CharlemagneBase)
{
   modal = "1";

   fontColors[4] = "236 214 175 255";
   fontColors[5] = "255 255 255 255";
   fontColorLink = "236 214 175 255";
   fontColorLinkHL = "255 255 255 255";
   fontSize = "16";
};

singleton GuiControlProfile (CharlemagneDark)
{
   fontType = "Noto Serif CJK JP";
   
   fontColor = "171 150 97";
   fontColorHL = "255 225 154";
   fontColorNA = "0 0 0";
   fontColorSEL = "200 200 200";
   
   category = "AoD";
   fontColors[0] = "171 150 97 255";
   fontColors[1] = "255 225 154 255";
   fontColors[3] = "200 200 200 255";
};

singleton GuiControlProfile(CharlemagneDark_Left_12 : CharlemagneDark)
{
   fontSize = "12";
   justify = "Left";
};

singleton GuiControlProfile(CharlemagneDark_Left_16 : CharlemagneDark)
{
   fontSize = "20";
   justify = "Left";
};

singleton GuiControlProfile(CharlemagneDark_Left_20 : CharlemagneDark)
{
   fontSize = "26";
   justify = "Left";
};

singleton GuiControlProfile(CharlemagneDark_Left_25 : CharlemagneDark)
{
   fontSize = "31";
   justify = "Left";
};

singleton GuiControlProfile(CharlemagneDark_Left_30 : CharlemagneDark)
{
   fontSize = "37";
   justify = "Left";
};

singleton GuiControlProfile(CharlemagneDark_Center_16 : CharlemagneDark)
{
   fontSize = "20";
   justify = "Center";
};

singleton GuiControlProfile(Charlemagne_Center_12 : CharlemagneBase)
{
   fontSize = "15";
   justify = "Center";
   fontColors[6] = "255 18 0 255";
};

singleton GuiControlProfile(Charlemagne_Center_14 : CharlemagneBase)
{
   fontSize = "17";
   justify = "Center";
   bevelColorHL = "255 18 0 255";
   bevelColorLL = "255 18 0 255";
   fontColors[6] = "255 18 0 255";
};

singleton GuiControlProfile(Charlemagne_Center_16 : CharlemagneBase)
{
   fontSize = "20";
   justify = "Center";
};

singleton GuiControlProfile(Charlemagne_Left_12 : CharlemagneBase)
{
   fontSize = "15";
   justify = "Left";
};

singleton GuiControlProfile(Charlemagne_Left_16 : CharlemagneBase)
{
   fontSize = "20";
   justify = "Left";
};

singleton GuiControlProfile(Charlemagne_Left_20 : CharlemagneBase)
{
   fontSize = "27";
   justify = "Left";
};

singleton GuiControlProfile(Charlemagne_Center_20 : CharlemagneBase)
{
   fontSize = "25";
   justify = "Center";
   bevelColorHL = "255 18 0 255";
   bevelColorLL = "255 18 0 255";
   fontColors[4] = "255 0 255 255";
   fontColorLink = "255 0 255 255";
   fontColors[5] = "255 0 255 255";
   fontColors[8] = "255 0 255 255";
   fontColorLinkHL = "255 0 255 255";
   fontColors[9] = "255 0 255 255";
   fontColors[6] = "255 18 0 255";
};

singleton GuiControlProfile(Charlemagne_Center_25 : CharlemagneBase)
{
   fontSize = "31";
   justify = "Center";
   bevelColorHL = "255 18 0 255";
   bevelColorLL = "255 18 0 255";
   fontColors[4] = "255 0 255 255";
   fontColorLink = "255 0 255 255";
   fontColors[5] = "255 0 255 255";
   fontColors[8] = "255 0 255 255";
   fontColorLinkHL = "255 0 255 255";
   fontColors[9] = "255 0 255 255";
   fontColors[6] = "255 18 0 255";
};

singleton GuiControlProfile(Charlemagne_Center_29 : CharlemagneBase)
{
   fontSize = "36";
   justify = "Center";
   bevelColorHL = "255 0 255 255";
   bevelColorLL = "255 0 255 255";
   fontColors[6] = "255 18 0 255";
};

singleton GuiControlProfile(Charlemagne_Center_32 : CharlemagneBase)
{
   fontSize = "40";
   justify = "Center";
   bevelColorHL = "255 0 255 255";
   bevelColorLL = "255 0 255 255";
   fontColors[6] = "255 18 0 255";
};

singleton GuiControlProfile(Charlemagne_Center_35 : CharlemagneBase)
{
   fontSize = "43";
   justify = "Center";
   fontColors[6] = "255 18 0 255";
};

singleton GuiControlProfile(Charlemagne_Center_35 : CharlemagneBase)
{
   fontSize = "43";
   justify = "Center";
};

singleton GuiControlProfile(Charlemagne_Center_38 : CharlemagneBase)
{
   fontSize = "47";
   justify = "Center";
};

singleton GuiControlProfile(Charlemagne_Center_40 : CharlemagneBase)
{
   fontSize = "50";
   justify = "Center";
};

//-------------------------------------------------
// TextBox

singleton GuiControlProfile (TextBoxMsgProfile : Candara_18)
{
	modal = true;
	fontColors[1] = "220 200 165"; // Normal feedback - Player attacks
	fontColors[2] = "170 150 115"; // NPC vs PC attacks.
	fontColors[3] = "120 100 65"; // NPC vs NPC attacks.
	fontColors[4] = "175 0 0"; // Red
	fontColors[5] = "255 200 0"; // Gold
	fontColors[6] = "0 175 0"; // Green
};

singleton GuiControlProfile (TextBoxMsgProfile1080 : Candara_20)
{
	modal = true;
	fontColors[1] = "220 200 165"; // Normal feedback - Player attacks
	fontColors[2] = "170 150 115"; // NPC vs PC attacks.
	fontColors[3] = "120 100 65"; // NPC vs NPC attacks.
	fontColors[4] = "175 0 0"; // Red
	fontColors[5] = "255 200 0"; // Gold
	fontColors[6] = "0 175 0"; // Green
};

singleton GuiControlProfile (TextBoxMsgProfile1440 : Candara_24)
{
	modal = true;
	fontColors[1] = "220 200 165"; // Normal feedback - Player attacks
	fontColors[2] = "170 150 115"; // NPC vs PC attacks.
	fontColors[3] = "120 100 65"; // NPC vs NPC attacks.
	fontColors[4] = "175 0 0"; // Red
	fontColors[5] = "255 200 0"; // Gold
	fontColors[6] = "0 175 0"; // Green
};

singleton GuiControlProfile (TextBoxScrollProfile)
{
   opaque = false;
   border = false;
   borderColor = "0 0 0";
   bitmap = "./fbScroll";
   hasBitmapArray = true;
   
   
   category = "AoD";
};

//--------------------------------------------------
// Scroll

singleton GuiControlProfile (fbScrollProfile)
{
   opaque = false;
   border = false;
   hasBitmapArray = true;
   bitmap = "./fbScroll";
   
   category = "AoD";
};

singleton GuiControlProfile (fbInvScrollProfile)
{
   opaque = false;
   border = false;
   hasBitmapArray = true;
   bitmap = "./fbScroll3";
   
   category = "AoD";
};

singleton GuiControlProfile(fbMapScrollProfile)
{
   opaque = true;
   fillcolor = "0 0 0";
   hasBitmapArray = false;
   
   category = "AoD";
};

//--------------------------------------------------
// Edit

singleton GuiControlProfile (fbTransTextEditProfile)
{
   opaque = false;
   fontSize = 21;
   fillColor = "203 113 76";
   fillColorHL = "128 128 128";
   border = 0;
   borderThickness = 0;
   borderColor = "0 0 0";
   fontColor = "236 214 175";
   fontColorHL = "117 76 35";
   fontColorSEL = "255 255 255";
   fontColorNA = "128 128 128";
   cursorColor = "236 214 175";
   textOffset = "0 0";
   autoSizeWidth = false;
   autoSizeHeight = true;
   tab = true;
   canKeyFocus = true;
   
   category = "AoD";
};

singleton GuiControlProfile (fbSpin : fbTransTextEditProfile)
{
	fontSize = 21;
	bitmap = "./fbSpin";
	numbersOnly = true;
	autoSizeWidth = false;
	autoSizeHeight = false;
};

singleton GuiControlProfile( fbTransTextEditProfileCM_12 : Candara_Center_12)
{
   opaque = false;  
   cursorColor = "236 214 175";
   
   textOffset = "0 0";
   autoSizeWidth = false;
   autoSizeHeight = true;
   
   tab = true;
   canKeyFocus = true;
   
   category = "AoD";
};

singleton GuiControlProfile( fbTransTextEditProfileCM_16 : Candara_Center_16)
{
   opaque = false;  
   cursorColor = "236 214 175";
   
   textOffset = "0 0";
   autoSizeWidth = false;
   autoSizeHeight = true;
   
   tab = true;
   canKeyFocus = true;
   
   category = "AoD";
};

singleton GuiControlProfile( fbTransTextEditProfileCM_20 : Candara_Center_20)
{
   opaque = false;  
   cursorColor = "236 214 175";
   
   textOffset = "0 0";
   autoSizeWidth = false;
   autoSizeHeight = true;
   
   tab = true;
   canKeyFocus = true;
   
   category = "AoD";
};

//--------------------------------------------------
// fbSaveItemCtrl

singleton GuiControlProfile (fbSaveItemCtrlProfile : fbText_17)
{
	opaque = false;
	border = true;
	borderColor = "100 100 100";
	fontSize = 21;
	fillColor = "80 80 80 128";
	canKeyFocus = false;
	tab = false;
	
	category = "AoD";
};

//--------------------------------------------------
// Buttons

singleton GuiControlProfile (fbButtonStoneClick)
{
	soundButtonDown = "AudioButtonStoneClick";
};

singleton GuiControlProfile (fbButtonTradeClick)
{
	soundButtonDown = "AudioButtonTradeClick";
};

singleton GuiControlProfile (fbButtonTransferClick)
{
	soundButtonDown = "AudioButtonTransferClick";
};

singleton GuiControlProfile (fbButtonClick)
{
	soundButtonDown = "AudioButtonClick";
};


//--------------------------------------------------
// Progress Ctrl

singleton GuiControlProfile(fbProgressProfile)
{
   opaque = false;
   fillColor = "220 0 0 100";
   border = true;
   borderColor = "236 214 175";
   
   category = "AoD";
};

//--------------------------------------------------
// Bitmap Frame Ctrl

singleton GuiControlProfile (fbBitmapFrameProfile)
{
	opaque = false;
	border = 0;
	fillColor = "242 241 240";
	fillColorHL = "221 221 221";
	fillColorNA = "200 200 200";
	fontColor = "50 50 50";
	fontColorHL = "0 0 0";
	bitmap = "./fbFrame";
	hasBitmapArray = true;
	justify = "left";
	
	category = "AoD";
};

//-------------------------------------------------
// Tabs

singleton GuiControlProfile(fbTabBook_15)
{
	fontType = "Noto Serif CJK JP";
	fontSize = 21;
	fontColor = "173 156 100";
	fontColorHL = "255 227 177";
	fontColorSEL = "255 239 178";
	
	justify = "center";
	opaque = false;
	drawBackground = false;
	
	category = "AoD";
};

//-------------------------------------------------
// ComboBox / DropDownList / PopUpMenu

singleton GuiControlProfile(fbPopUpMenuTechProfile : GuiPopUpMenuProfile)
{
	bitmap = "art/gui/fbDropdownTech.png";
	profileForChildren = fbPopUpMenuTechProfile;
   
	fontType = "Noto Serif CJK JP";
	fontSize = 20;
	fontColor = "173 156 100";
	fontColorHL = "255 227 177";
	fontColorSEL = "255 239 178";
   
	fillColor = "15 14 13 255";
	fillColorHL = "15 14 13 255";
	fillColorNA = "15 14 13 255";
   
	category = "AoD";
   fillColorSEL = "25 24 23 255";
   border = "0";
   borderThickness = "-1";
   borderColor = "255 227 177 255";
   borderColorHL = "255 227 177 50";
   borderColorNA = "255 227 177 255";
   fontColors[0] = "173 156 100 255";
   fontColors[1] = "255 227 177 255";
   fontColors[2] = "173 156 100 255";
   fontColors[3] = "255 239 178 255";
   fontColorNA = "173 156 100 255";
};

singleton GuiControlProfile(fbTextListSchemes : fbPopUpMenuTechProfile)
{
	fontRescaling = true;
};

//--------------------------------------------------
// Window Ctrl

singleton GuiControlProfile (fbWindowProfile)
{
	opaque = false;
   	border = 2;
   	fillColor = "10 10 10 200";
   	fillColorHL = "221 221 221";
   	fillColorNA = "200 200 200";
   	fontColor = "220 200 165";
   	fontColorHL = "0 0 0";
     bevelColorHL = "255 255 255";
     bevelColorLL = "0 0 0";
   	text = "untitled";
   	bitmap = "./window";
   	textOffset = "8 4";
   	hasBitmapArray = true;
   	justify = "left";
   	yPositionOffset = "21";
	
	category = "AoD";
};

singleton GuiControlProfile (fbWindowBlackProfile)
{
	opaque = false;
   	border = 2;
   	fillColor = "10 10 10";
   	fillColorHL = "221 221 221";
   	fillColorNA = "200 200 200";
   	fontColor = "220 200 165";
   	fontColorHL = "0 0 0";
     bevelColorHL = "255 255 255";
     bevelColorLL = "0 0 0";
   	text = "untitled";
   	bitmap = "./windowBlack";
   	textOffset = "8 4";
   	hasBitmapArray = true;
   	justify = "left";
   	yPositionOffset = "21";
	
	category = "AoD";
};

singleton GuiControlProfile(FbGuiButtonProfile)
{
   opaque = true;
   border = true;
	 
   fontColor = "220 200 165";
   fontColorHL = "220 200 165";
	 fontColorNA = "200 200 200";
	 //fontColorSEL ="0 0 0";
   fixedExtent = false;
   justify = "center";
   canKeyFocus = false;
	bitmap = "./button";
   hasBitmapArray = false;
   category = "Core";
};

singleton GuiControlProfile(FbMapTextButtonProfile)
{
   opaque = true;
   border = "1";
	 
   fontColor = "253 224 176 255";
   fontColorHL = "245 241 233 255";
	 fontColorNA = "101 101 101 255";
	 //fontColorSEL ="0 0 0";
   fixedExtent = 0;
   justify = "center";
   canKeyFocus = false;
   hasBitmapArray = "0";
   category = "Core";
   fontType = "Noto Serif CJK JP";
   fontSize = "37";
   fontColors[0] = "253 224 176 255";
   fontColors[1] = "245 241 233 255";
   fontColors[2] = "101 101 101 255";
   drawBackground = "1";
   fillColor = "242 218 158 255";
   fillColorHL = "228 228 235 255";
   fillColorNA = "255 255 255 255";
   fillColorSEL = "98 100 137 255";
   bitmap = "art/gui/maps/images/cityMapButtonBackground.png";
};

singleton GuiControlProfile( AoDGuiRolloutProfile )
{
   border = 1;
   borderColor = "25 25 25";
  
   hasBitmapArray = true;
   bitmap = "art/gui/aodRollout";
  
   textoffset = "30 0";
   category = "AoD";
   fontColors[0] = "255 225 150 255";
   fontColors[1] = "255 225 150 255";
   fontColors[2] = "255 225 150 255";
   fontColors[3] = "255 225 150 255";
   fontColors[4] = "255 225 150 255";
   fontColors[5] = "255 225 150 255";
   fontColor = "255 225 150 255";
   fontColorHL = "255 225 150 255";
   fontColorNA = "255 225 150 255";
   fontColorSEL = "255 225 150 255";
   fontColorLink = "255 225 150 255";
   fontColorLinkHL = "255 225 150 255";
   fillColor = "25 25 25 255";
   fillColorHL = "25 25 25 255";
   fillColorNA = "25 25 25 255";
   fillColorSEL = "25 25 25 255";
};

singleton GuiControlProfile( AoDGuiSliderProfile : GuiSliderProfile )
{
   bitmap = "./aod_slider";
   category = "AoD";
};

singleton GuiControlProfile( AoDGuiButtonProfile : GuiButtonProfile )
{
   bitmap = "./aod_button";

   fontType = "Noto Serif CJK JP"; 
   fontColor = "132 113 74";
   fontColorHL = "132 113 74";
	fontColorNA = "200 200 200";
	//fontColorSEL ="0 0 0";
    
   category = "AoD";
};
 
singleton GuiControlProfile( AoDGuiCheckBoxProfile : GuiCheckBoxProfile )
{
   fillColor = "232 232 232";   
   borderColor = "100 100 100";
   
   fontType = "Noto Serif CJK JP";   
   fontColor = "220 200 165";
   fontColorHL = "255 255 255";
   fontColorNA = "64 64 64";
   fontColorSEL = "200 200 200";
	   
   bitmap = "./aod_checkbox";
   
   category = "AoD";
   fontRescaling = true;
};

singleton GuiControlProfile( AoDGuiPopUpMenuProfile : GuiPopUpMenuProfile )
{
   /*fixedExtent    = true;
   hasBitmapArray = true;
   textOffset     = "6 4";*/

   fillColor      = "85 80 73";
   fillColorHL    = "112 100 79";
   fillColorSEL   = "75 69 57";
   fillColorNA    = "85 80 73";

   fontType = "Noto Serif CJK JP";   
   fontColor = "220 200 165";
   fontColorHL = "255 255 255";
   fontColorNA = "220 200 165";
   fontColorSEL = "200 200 200";

   border         = 0;

   profileForChildren = AoDGuiPopUpMenuBorderProfile;

   bitmap = "./aod_dropdown";
   
   category = "AoD";
};

singleton GuiControlProfile( AoDGuiPopUpMenuBorderProfile : GuiPopupMenuItemBorder  )
{
   textOffset     = "6 1";

   fillColor      = "85 80 73";
   fillColorHL    = "112 100 79";
   fillColorSEL   = "75 69 57";
   fillColorNA    = "85 80 73";

   fontType = "Noto Serif CJK JP";   
   fontColor = "220 200 165";
   fontColorHL = "255 255 255";
   fontColorNA = "220 200 165";
   fontColorSEL = "200 200 200";

   border         = 0;

   category = "AoD";
};

singleton GuiControlProfile( AoDGuiNumericDropSliderTextProfile : GuiNumericDropSliderTextProfile  )
{
   textOffset     = "6 1";

   fillColor      = "0 0 0 0";
   fillColorHL    = "0 0 0 0";
   fillColorSEL   = "0 0 0 0";
   fillColorNA    = "0 0 0 0";

   fontType = "Noto Serif CJK JP";   
   fontColor = "220 200 165";
   fontColorHL = "255 255 255";
   fontColorNA = "220 200 165";
   fontColorSEL = "0 0 0 0";
   
   border = 1;
   bordercolor = "220 200 165";
   //bitmap = "./aod_textedit_sliderbox";
   
   category = "AoD";
};

singleton GuiControlProfile( AoDTextListProfile : CharlemagneDark  )
{
	fontColorHL = "255 227 177";
	fontColorSEL = "255 239 178";
   fontColorNA = "127 127 127 255";
   
	//fillColor = "15 14 13 255";
	fillColorHL = "15 14 13 255";
	//fillColorNA = "127 127 127 255";
   //fillColorSEL = "255 255 255 255";
  
   //fontColors[0] = "173 156 100 255";
   //fontColors[1] = "255 227 177 255";
   //fontColors[2] = "173 156 100 255";
   //fontColors[3] = "255 239 178 255";
   //fontColorNA = "173 156 100 255";
   
   category = "AoD";
};

singleton GuiControlProfile(PGHelpProfile : GuiMLTextProfile)
{
   fontType = "Noto Serif CJK JP";
   fontSize = "21";
   fontColors[0] = "238 238 238 255";
   fontColor = "238 238 238 255";
   category = "AoD";
};

singleton GuiControlProfile(CS_1080_CostNumber : Charlemagne_Center_25)
{
   fontSize = "25";
   fontColors[0] = "254 209 95 255";
   fontColor = "254 209 95 255";
};

singleton GuiControlProfile(Charlemagne_Center_22 : Charlemagne_Center_25)
{
   fontSize = "27";
};

singleton GuiControlProfile(PGHelpProfile_600h : PGHelpProfile)
{
   fontSize = "17";
};
