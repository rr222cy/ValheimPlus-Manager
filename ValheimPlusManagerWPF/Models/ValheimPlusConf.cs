﻿namespace ValheimPlusManager.Models
{
    public class ValheimPlusConf
    {
        #region ValheimPlusConfiguration
        public bool valheimPlusConfigurationEnabled { get; set; } = true;
        public bool mainMenuLogo { get; set; } = true;
        public bool serverBrowserAdvertisement { get; set; } = true;
        #endregion ValheimPlusConfiguration

        #region Advanced building mode
        public bool advancedBuildingModeEnabled { get; set; } = false;
        public string enterAdvancedBuildingMode { get; set; } = "F1";
        public string exitAdvancedBuildingMode { get; set; } = "F3";
        public string copyObjectRotation { get; set; } = "Keypad7";
        public string pasteObjectRotation { get; set; } = "Keypad8";
        public string increaseScrollSpeed { get; set; } = "KeypadPlus";
        public string decreaseScrollSpeed { get; set; } = "KeypadMinus";
        #endregion Advanced building mode

        #region Advanced editing mode
        public bool advancedEditingModeEnabled { get; set; } = false;
        public string enterAdvancedEditingMode { get; set; } = "Keypad0";
        public string resetAdvancedEditingMode { get; set; } = "F7";
        public string abortAndExitAdvancedEditingMode { get; set; } = "F8";
        public string confirmPlacementOfAdvancedEditingMode { get; set; } = "KeypadEnter";
        public string copyObjectRotationAEM { get; set; } = "Keypad7";
        public string pasteObjectRotationAEM { get; set; } = "Keypad8";
        public string increaseScrollSpeedAEM { get; set; } = "KeypadPlus";
        public string decreaseScrollSpeedAEM { get; set; } = "KeypadMinus";
        #endregion Advanced editing mode

        #region Armor
        public bool armorSettingsEnabled { get; set; } = false;
        public float helmetsArmor { get; set; } = 0;
        public float chestsArmor { get; set; } = 0;
        public float legsArmor { get; set; } = 0;
        public float capesArmor { get; set; } = 0;
        #endregion Armor

        #region Beehive
        public bool beehiveSettingsEnabled { get; set; } = false;
        public float honeyProductionSpeed { get; set; } = 1200;
        public int maximumHoneyPerBeehive { get; set; } = 4;
        public bool autoDepositHoney { get; set; } = false;
        public float autoDepositHoneyRange { get; set; } = 10;
        public bool showDurationBeehive { get; set; } = false;
        #endregion Beehive

        #region Building
        public bool buildingSettingsEnabled { get; set; } = false;
        public bool noInvalidPlacementRestriction { get; set; } = false;
        public bool noMysticalForcesPreventPlacementRestriction { get; set; } = false;
        public bool noWeatherDamage { get; set; } = false;
        public float maximumPlacementDistance { get; set; } = 5;
        public float pieceComfortRadius { get; set; } = 10;
        public bool alwaysDropResources { get; set; } = false;
        public bool alwaysDropExcludedResources { get; set; } = false;
        public bool enableAreaRepair { get; set; } = false;
        public float areaRepairRadius { get; set; } = 7.5f;
        #endregion Building

        #region Camera
        public bool cameraSettingsEnabled { get; set; } = false;
        public float cameraMaximumZoomDistance { get; set; } = 1146;
        public float cameraBoatMaximumZoomDistance { get; set; } = 6;
        public float cameraFOV { get; set; } = 65;
        #endregion Camera

        // Durability
        public bool durabilitySettingsEnabled { get; set; } = false;
        public float axesDurability { get; set; } = 0;
        public float pickaxesDurability { get; set; } = 0;
        public float hammerDurability { get; set; } = 0;
        public float cultivatorDurability { get; set; } = 0;
        public float hoeDurability { get; set; } = 0;
        public float weaponsDurability { get; set; } = 0;
        public float armorDurability { get; set; } = 0;
        public float bowsDurability { get; set; } = 0;
        public float shieldsDurability { get; set; } = 0;

        // Inventory
        public bool inventorySettingsEnabled { get; set; } = false;
        public bool inventoryFillTopToBottom { get; set; } = false;
        public int playerInventoryRows { get; set; } = 4;
        public int woodChestColumns { get; set; } = 5;
        public int woodChestRows { get; set; } = 2;
        public int personalChestColumns { get; set; } = 3;
        public int personalChestRows { get; set; } = 2;
        public int ironChestColumns { get; set; } = 8;
        public int ironChestRows { get; set; } = 3;
        public int cartInventoryColumns { get; set; } = 8;
        public int cartInventoryRows { get; set; } = 3;
        public int karveInventoryColumns { get; set; } = 2;
        public int karveInventoryRows { get; set; } = 2;
        public int longboatInventoryColumns { get; set; } = 8;
        public int longboatInventoryRows { get; set; } = 3;

        // Items
        public bool itemsSettingsEnabled { get; set; } = false;
        public bool noTeleportPrevention { get; set; } = false;
        public float baseItemWeightReduction { get; set; } = 0;
        public float itemStackMultiplier { get; set; } = 1;
        public int droppedItemOnGroundDurationInSeconds { get; set; } = 3600;

        // Fermenter
        public bool fermenterSettingsEnabled { get; set; } = false;
        public float fermenterDuration { get; set; } = 2400;
        public int fermenterItemsProduced { get; set; } = 4;
        public bool showFermenterDuration { get; set; } = false;

        // FireSource
        public bool fireSourceSettingsEnabled { get; set; } = false;
        public bool onlyTorches { get; set; } = false;

        // FirstPerson
        public bool firstPersonSettingsEnabled { get; set; } = false;
        public string hotkey { get; set; } = "F10";
        public string raiseFOVHotkey { get; set; } = "PageUp";
        public float defaultFOV { get; set; } = 65.0f;
        public string lowerFOVHotkey { get; set; } = "PageDown";

        // Food
        public bool foodSettingsEnabled { get; set; } = false;
        public float foodDurationMultiplier { get; set; } = 0;
        public bool disableFoodDegradation { get; set; } = false;

        // FreePlacementRotation
        public bool freePlacementRotationSettingsEnabled { get; set; } = false;
        public string rotateY { get; set; } = "LeftAlt";
        public string rotateX { get; set; } = "C";
        public string rotateZ { get; set; } = "V";
        public string copyRotationParallel { get; set; } = "F";
        public string copyRotationPerpendicular { get; set; } = "G";

        // Furnace
        public bool furnaceSettingsEnabled { get; set; } = false;
        public int maximumOre { get; set; } = 10;
        public int maximumCoal { get; set; } = 20;
        public int coalUsedPerProduct { get; set; } = 2;
        public float furnaceProductionSpeed { get; set; } = 30;
        public bool autoDepositFurnace { get; set; } = false;
        public float autoDepositRangeFurnace { get; set; } = 10;

        // Game
        public bool gameSettingsEnabled { get; set; } = false;
        public float gameDifficultyDamageScale { get; set; } = 0.4f;
        public float gameDifficultyHealthScale { get; set; } = 0.4f;
        public int extraPlayerCountNearby { get; set; } = 0;
        public int setFixedPlayerCountTo { get; set; } = 0;
        //public float autoSaveInterval { get; set; } = 1200;
        public int difficultyScaleRange { get; set; } = 200;
        public bool disablePortals { get; set; } = false;

        // Hotkeys
        public bool hotkeysSettingsEnabled { get; set; } = false;
        public string rollForwards { get; set; } = "F9";
        public string rollBackwards { get; set; } = "F10";

        // Hud
        public bool hudSettingsEnabled { get; set; } = false;
        public bool showRequiredItems { get; set; } = false;
        public bool experienceGainedNotifications { get; set; } = false;
        public float chatMessageDistance { get; set; }
        public bool displayStaminaValue { get; set; } = false;
        public bool removeDamageFlash { get; set; } = false;

        // Gathering
        public bool gatheringSettingsEnabled { get; set; } = false;
        public float woodGathering { get; set; } = 0;
        public float stoneGathering { get; set; } = 0;
        public float fineWoodGathering { get; set; } = 0;
        public float coreWoodGathering { get; set; } = 0;
        public float elderBarkGathering { get; set; } = 0;
        public float ironScrapGathering { get; set; } = 0;
        public float tinOreGathering { get; set; } = 0;
        public float copperOreGathering { get; set; } = 0;
        public float silverOreGathering { get; set; } = 0;
        public float chitinGathering { get; set; } = 0;
        public float dropChanceGathering { get; set; } = 0;

        // Kiln
        public bool kilnSettingsEnabled { get; set; } = false;
        public float kilnProductionSpeed { get; set; } = 30;
        public int maximumWood { get; set; } = 25;
        public bool autoDepositKiln { get; set; } = false;
        public float autoDepositRangeKiln { get; set; } = 10;

        // Map
        public bool mapSettingsEnabled { get; set; } = false;
        public bool shareMapProgression { get; set; } = false;
        public float exploreRadius { get; set; } = 100;
        public bool playerPositionPublicOnJoin { get; set; } = false;
        public bool preventPlayerFromTurningOffPublicPosition { get; set; } = false;
        public bool removeDeathPinOnTombstoneEmpty { get; set; } = false;

        // Player settings
        public bool playerSettingsEnabled { get; set; } = false;
        public float baseMaximumWeight { get; set; } = 300;
        public float baseMegingjordBuff { get; set; } = 150;
        public float baseAutoPickUpRange { get; set; } = 2;
        public bool disableCameraShake { get; set; } = false;
        public float baseUnarmedDamage { get; set; } = 0;
        public bool cropNotifier { get; set; } = false;
        public float restSecondsPerComfortLevel { get; set; } = 60;
        public float deathPenaltyMultiplier { get; set; } = 0;
        public bool autoRepair { get; set; } = false;
        //public float guardianBuffDuration { get; set; } = 300;
        //public float guardianBuffCooldown { get; set; } = 1200;

        // Server
        public bool serverSettingsEnabled { get; set; } = false;
        public int maxPlayers { get; set; } = 10;
        public bool disableServerPassword { get; set; } = false;
        public bool enforceConfiguration { get; set; } = true;
        public bool enforceMod { get; set; } = true;
        public bool serverSyncsConfig { get; set; } = true;
        public int dataRate { get; set; } = 60; // 60*1024 = 614440 == 60kbs

        // Shields
        public bool shieldsSettingsEnabled { get; set; } = false;
        public float blockRating { get; set; } = 0;

        // Smelter
        public bool smelterSettingsEnabled { get; set; } = false;
        public int smelterMaximumOre { get; set; } = 10;
        public int smelterMaximumCoal { get; set; } = 20;
        public int smelterCoalUsedPerProduct { get; set; } = 2;
        public float smelterProductionSpeed { get; set; } = 30;
        public bool smelterAutoDeposit { get; set; } = false;
        public float smelterAutoDepositRange { get; set; } = 10;

        // Stamina
        public bool staminaSettingsEnabled { get; set; } = false;
        public float dodgeStaminaUsage { get; set; } = 0;
        public float encumberedStaminaDrain { get; set; } = 0;
        public float jumpStaminaDrain { get; set; } = 0;
        public float runStaminaDrain { get; set; } = 0;
        public float sneakStaminaDrain { get; set; } = 0;
        public float staminaRegen { get; set; } = 0;
        public float staminaRegenDelay { get; set; } = 0;
        public float swimStaminaDrain { get; set; } = 0;

        // Stamina usage
        public bool staminaUsageSettingsEnabled { get; set; } = false;
        public float axes { get; set; } = 0;
        public float bows { get; set; } = 0;
        public float clubs { get; set; } = 0;
        public float knives { get; set; } = 0;
        public float pickaxes { get; set; } = 0;
        public float polearms { get; set; } = 0;
        public float spears { get; set; } = 0;
        public float swords { get; set; } = 0;
        public float unarmed { get; set; } = 0;
        public float hammer { get; set; } = 0;
        public float hoe { get; set; } = 0;
        public float cultivator { get; set; } = 0;

        // Workbench
        public bool workbenchSettingsEnabled { get; set; } = false;
        public float workbenchRange { get; set; } = 20;
        public float workbenchAttachmentRange { get; set; } = 5.0f;
        public bool disableRoofCheck { get; set; } = false;

        // Time
        public bool timeSettingsEnabled { get; set; } = false;
        public float totalDayTimeInSeconds { get; set; } = 1800;
        public float nightTimeSpeedMultiplier { get; set; } = 0;

        // Ward
        public bool wardSettingsEnabled { get; set; } = false;
        public float wardRange { get; set; } = 20;

        // Structural integrity
        public bool structuralIntegritySettingsEnabled { get; set; } = false;
        public float wood { get; set; } = 0;
        public float stone { get; set; } = 0;
        public float iron { get; set; } = 0;
        public float hardWood { get; set; } = 0;
        public bool disableStructuralIntegrity { get; set; } = false;
        public bool disableDamageToPlayerStructures { get; set; } = false;
        public bool disableDamageToPlayerBoats { get; set; } = false;

        // Experience
        public bool experienceSettingsEnabled { get; set; } = false;
        public float experienceSwords { get; set; } = 0;
        public float experienceKnives { get; set; } = 0;
        public float experienceClubs { get; set; } = 0;
        public float experiencePolearms { get; set; } = 0;
        public float experienceSpears { get; set; } = 0;
        public float experienceBlocking { get; set; } = 0;
        public float experienceAxes { get; set; } = 0;
        public float experienceBows { get; set; } = 0;
        public float experienceHammer { get; set; } = 0;
        public float experienceHoe { get; set; } = 0;
        public float experienceFireMagic { get; set; } = 0;
        public float experienceFrostMagic { get; set; } = 0;
        public float experienceUnarmed { get; set; } = 0;
        public float experiencePickaxes { get; set; } = 0;
        public float experienceWoodCutting { get; set; } = 0;
        public float experienceJump { get; set; } = 0;
        public float experienceSneak { get; set; } = 0;
        public float experienceRun { get; set; } = 0;
        public float experienceSwim { get; set; } = 0;

        // Wagon
        public bool wagonSettingsEnabled { get; set; } = false;
        public float wagonExtraMassFromItems { get; set; } = 0;
        public float wagonBaseMass { get; set; } = 20;
    }
}
