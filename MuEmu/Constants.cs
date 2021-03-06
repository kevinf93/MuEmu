﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MuEmu
{
    public enum TradeResult : byte
    {
        Error = 0,
        Ok = 1,
        InventoryFull = 2,
        CantTradeHarmonized = 4,
    }
    public enum StorageID
    {
        Equipament,
        Inventory = 12,
        PersonalShop = 76,
        ChaosBox,
        TradeBox,
    }

    public enum LoginStatus
    {
        NotLogged,
        Logged,
        Playing
    }

    public enum LoginResult : byte
    {
        Ok = 1,
        Fail,
        IsConnected,
        ServerFull,
        IsBanned,
        OldVersion,
        ConnectionError,
        ConnectionClosed3Fail,
        OnlyVIP,
        VipEnding,
        VipEnded,
        VipEnded2,

        OkWithItemBlock = 15,
    }

    public enum ControlCode : byte
    {
        Normal,
        CharacterBlock,
        ItemBlock,
        GameMaster = 0x20,
    }

    public enum Maps : byte
    {
        Lorencia,
        Dugeon,
        Davias,
        Noria,
        LostTower,
        Exile,
        Stadium,
        Atlans,
        Tarkan,
        DevilSquare,
        Icarus,
        BloodCastle1,
        BloodCastle2,
        BloodCastle3,
        BloodCastle4,
        BloodCastle5,
        BloodCastle6,
        BloodCastle7,
        ChaosCastle1,
        ChaosCastle2,
        ChaosCastle3,
        ChaosCastle4,
        ChaosCastle5,
        ChaosCastle6,
        Kalima1,
        Kalima2,
        Kalima3,
        Kalima4,
        Kalima5,
        Kalima6,
        ValleyofLoren,
        LandofTrial,
        DevilSquare2,
        Aida,
        Crywolf,
        // null
        Kalima7 = 36,
        Kantru1,
        Kantru2,
        Kantru3,
        SilentSwamp,
        BarracksofBalgass,
        BalgassRefuge,
        T43,
        T44,
        IllusionTemple1,
        IllusionTemple2,
        IllusionTemple3,
        IllusionTemple4,
        IllusionTemple5,
        IllusionTemple6,
        Elbeland,
        BloodCastle8,
        ChaosCastle7,
        // null
        // null
        SwampOfCalmness = 56,
        Raklion,
        Selupan,
        // null
        // null
        Buhwajang = 61,
        SantaTown,
        Vulcan,
        DuelArena,
        DoppelgangerSnow,
        DoppelgangerVulcan,
        DoppelgangerSea,
        DoppelgangerCrystals,
        ImperialGuardian1,
        ImperialGuardian2,
        ImperialGuardian3,
        ImperialGuardian4,
        LorenMarket = 79,
        Karutan1,
        Karutan2,
        DoppelgangerRenewal,
        Acheron = 91,
        ArkaWar,
        Debenter = 95,
        ArcaBattle,
        ChaosCastleSurvival,
        IllussionTempleLeague1,
        IllussionTempleLeague2,
        UrkMontain1,
        UrkMontain2,
        TormentedSquareoftheFittest,
        TormentedSquare1,
        TormentedSquare2,
        TormentedSquare3,
        TormentedSquare4,
        Nars = 110,
        Ferea = 112,
        NixieLake,
        LabyrinthEntrance,
        Labyrinth,
        DeepDungeon1,
        DeepDungeon2,
        DeepDungeon3,
        DeepDungeon4,
        DeepDungeon5,
        NewQuest,
        SwampOfDarkness,
        KuberaMineArea1,
        KuberaMineArea2,
        KuberaMineArea3,
        KuberaMineArea4,
        KuberaMineArea5,
        AbyssOfAtlas1,
        AbyssOfAtlas2,
        AbyssOfAtlas3,
        ScorchedCanyon,
        InvalidMap = 255,
    }

    public enum MapEvents : byte
    {
        GoldenInvasion = 3
    }

    public enum HackCheck : ushort
    {
        InvalidPacket = 0x0006,
        StrangePacket = 0xF300,
    }

    public enum HeroClass : byte
    {
        DarkWizard,
        SoulMaster,
        GranMaster,
        SoulWizard, //4TH Class
        DarkKnight = 0x10,
        BladeKnight,
        BladeMaster,
        DragonKnight, //4TH Class
        FaryElf = 0x20,
        MuseElf,
        HighElf,
        NobleElf, //4TH
        MagicGladiator = 0x30,
        DuelMaster,
        MagicKnight, //4TH
        DarkLord = 0x40,
        LordEmperator,
        EmpireLord,
        Summoner = 0x50,
        BlodySummoner,
        DimensionMaster,
        DimensionSummoner, //4TH
        RageFighter = 0x60,
        FistMaster,
        FistBlazer,//4TH
        GrowLancer = 0x70,
        MirageLancer,
        ShinningLancer, //4TH
        RuneWizard = 0x80,
        RuneSpellMaster,
        GrandRuneMaster, //4TH
    }

    public enum Equipament
    {
        RightHand,
        LeftHand,
        Helm,
        Armor,
        Pants,
        Gloves,
        Boots,
        Wings,
        Pet,
        Pendant,
        RightRing,
        LeftRing,
        End
    }


    [Flags]
    public enum ExcellentOptionArmor
    {
        None = 0,
        IncreaseZen = 1,//Increase Zen +40%
        DefenseSuccessRate = 2,//Defense Success rate +10%
        ReflectDamage = 4,//Reflect Damage +5%
        DamageDecrease = 8, //Damage Decrease +4%
        IncreaseMana = 16,//Increase Mana +4%
        IncreaseHP = 32,//Increase HP +4%
        FullItem = IncreaseZen | DefenseSuccessRate | ReflectDamage | DamageDecrease | IncreaseMana | IncreaseHP,
    }


    [Flags]
    public enum ExcellentOptionWeapons
    {
        None = 0,
        IncreaseManaRate = 1,//Increase Adquisition rate of Mana after hunting monsters Mana/8
        IncreaseLifeRate = 2,//Increase Adquisition rate of Mana after hunting monsters life/8
        IncreaseAttacking = 4,//Increase Attacking (Wizardry) speed + 7
        IncreaseWizardryRate = 8, //Increase Wizardry Dmg 2%
        IncreaseWizardry = 16,//Increase Wizardry Level/20
        ExcellentDmgRate = 32,//Excellent Dmg Rate 10%
        FullItem = IncreaseManaRate | IncreaseLifeRate | IncreaseAttacking | IncreaseWizardryRate | IncreaseWizardry | ExcellentDmgRate,
    }

    // Level*50+Type
    public enum SocketOption : byte
    {
        SocketFire = 0, //Attack/Wizardy Increase +57
        SocketWater = 1, //Block rating increase +14%
        SocketIce = 2, //Monster destruction for the Life increase +16250
        SocketWind = 3, //Automatic Life recovery increase +20
        SocketLightning = 4, //Exelen damage increase +40
        SocketGround = 5,

        SocketFire1 = 50, //Attack Speed Increase +11
        SocketWater1 = 51, //Defense Increase +42
        SocketIce1 = 52, //Monster destruction for the Mana increase +16250
        SocketWind1 = 53, //Maximum Life increase +8%
        SocketLightning1 = 54, //Exelen damage rate increase +14%
        SocketGround1 = 55,

        SocketFire2 = 100, //Maximum attack/Wizardy Increase +50
        SocketWater2 = 101, //Shield protection increase +30%
        SocketIce2 = 102, //Skill attack increase +50
        SocketWind2 = 103, //Maximim Mana increase +8%
        SocketLightning2 = 104, //Critical damage increase +50
        SocketGround2 = 105, //Hearth increase +38

        SocketFire3 = 150, //Minimum attack/Wizardy Increase +35
        SocketWater3 = 151, //Damage reduction +8%
        SocketIce3 = 152, //Attack rating increase +40
        SocketWind3 = 153, //Automatic Mana recovery increase +35
        SocketLightning3 = 154, //Critical damage rate increase +12%
        SocketGround3 = 155,

        SocketFire4 = 200, //Attack/Wizardy Increase +35
        SocketWater4 = 201, //Damage reflection +9%
        SocketIce4 = 202, //Item durability increase +38%
        SocketWind4 = 203, //Maximum AG increase +50
        SocketLightning4 = 204,
        SocketGround4 = 205,

        EmptySocket = 0xfe,
        None = 0xff
    }

    public enum GuildStatus : byte
    {
        Member,
        BattleMaster = 0x20,
        Assistant = 0x40,
        GuildMaster = 0x80,
        NoMember = 0xff
    }

    public enum GuildResult : byte
    {
        Fail = 0x00,
        Success = 0x01,
        CannotAcceptMoreMembers = 0x02,
        PlayerOffline = 0x03,
        NotGuildMaster = 0x04,
        HaveGuild = 0x05,
        InTransaction = 0x06,
        InsuficientLevel = 0x07,
        NotExist = 0x10,
        //UnionFail,
        NotExistPermission,
        NotExistExtraStatus,
        NotExistExtraType,
        ExistRelationshipUnion = 0x15,
        ExistRealtionshipRival,
        ExistUnion,
        ExistRival,
        NotExistUnion,
        NotExistRival,
        NotUnionMaster,
        NotRival,
        CannotBeUnionMaster,
        ExceedMaxUnionMembers,
        CancelRequest = 0x20,
        AllyMasterNoGems = 0xA1,
        DifferentGens = 0xA3,
    }

    public enum GuildRelation : byte
    {
        None,
        Union,
        Rival,
        UnionMaster = 4,
        RivalMaster = 8,
    }

    public enum LetterStatus : byte
    {
        Readed,
        UnReaded,
        New,
    }

    public enum RefillInfo : byte
    {
        MaxChanged = 0xFE,
        Update = 0xFD,
        Drink = 0xFF,
    }

    public enum PointAdd : byte
    {
        Strength,
        Agility,
        Vitality,
        Energy,
        Command,
    }

    public enum ClientCloseType : byte
    {
        CloseGame,
        SelectChar,
        ServerList,
    }

    public enum MoveItemFlags : byte
    {
        Inventory,
        Trade,
        Warehouse,
        ChaosBox,
        PersonalShop,
        DarkTrainer = 5,
    }

    public enum NoticeType : byte
    {
        Gold,
        Blue,
        Guild
    }

    public enum EventEnterType : byte
    {
        DevilSquare = 1,
        BloodCastle,
        ChaosCastle = 4,
        IllusionTemple,
    }

    public enum ObjectType
    {
        NPC,
        Monster,
        Gate,
    }

    public enum ObjectState
    {
        Regen,
        Live,
        Dying,
        Dying2,
        Die,
        WaitRegen,
    }

    public enum NPCAttributeType
    {
        Warehouse,
        Shop,
        Quest,
        Buff,
        Window,
        EventChips,
        MessengerAngel,
        KingAngel,
        GuildMaster,
        Kanturu,
        DevilSquare,
        ServerDivision,
    }

    public enum NPCWindow : byte
    {
        Shop = 0,
        Warehouse = 2,
        ChaosMachine = 3,
        DevilSquared = 4,
        MessengerAngel = 6,
        JewelMixer = 9,
        ChaosCard = 21,
        BlossomGovernor = 22,
        SokcetMaster = 23,
        SokcetResearcher = 24,
        LuckyCoins = 32,
        GateKeeper = 33,
        Sartigan = 35,
        LeoTheHelper = 38,
    }

    public enum AttributeType
    {
        Ice,
        Poison,
        Light,
        Fire,
        Earth,
        Wind,
        Water,
    }

    public enum TaxType : byte
    {
        Warehouse = 1,
        Shop,
    }

    public enum ServerCommandType : byte
    {
        Fireworks,
        EventMsg,
        DefaultMsg = 4,
        ServerDivision = 6,
        ShadowPhantom = 0x0D,
        DevilSquarePK = 0x37,
        BloodCastlePK,
        ChaosCastlePK,
    }

    public enum EventMsg : byte
    {
        YouNeedInvitationDS = 2,
        DevilStarted, //???
        DevilDisabled = 6, //???
        RunningBC = 0x14,
        YouNeedInvitationBC = 0x15,
        SucceedBC = 0x17,
        InvalidBC = 0x18,
        GoAheadBC = 0x2D,
        CompletedBC = 0x2E,
    }

    public enum DefaultMsg
    {
        Guard,
        DeviasMadam,
        Lala,
    }

    public enum TalkResult : byte
    {
        Shop,
        WareHouse = 2,
        DevilSquare = 4,
    }

    public enum DamageType : ushort
    {
        Regular,
        Excellent = 2,
        Critical,
        Beat,
        Poison,
        Reflect,
        White,
        Miss = 9,
        Double = 0x40,
        Combo = 0x80,
    }

    public enum SkillStates : byte
    {
        Attack = 1,
        Defense,
        ShadowPhantom,
        SoulBarrier,
        CriticalDamage,
        InfinityArrow,
        RecoverySpeed,
        SwellLife,
        SwellMana,
        PotionBless,
        PotionSoul,
        ss12,
        SS13,
        SS14,
        SS15,
        SS16,
        SS17,
        Transparency,
        SS19,
        SS20,
        AltarCanContract,
        AltarCantContract,
        AltarValidContract,
        AltarOfWolfCA,
        Admin,
        AltarOfWolfHCS,
        Invisible,
        GameMaster,
        SealAscencion,
        SealWealth,
        SealSustance,
        SS32,
        SS33,
        IllusionProtection,
        HAttackSpeed,
        HAttackPower,
        HDefensePower,
        HMaxLife,
        HMaxMana,
        SealAscencion2,
        SealWealth2,
        SealSustance2,
        SealMovement,
        ScrollQuick,
        ScrollDefense,
        ScrollDamage,
        ScrollPower,
        ScrollStamina,
        ScrollMana,
        ElixirPower,
        ElixirDefense,
        ElixirStamina,
        ElixirEnergy,
        ElixirCommand,
        Poison,
        Ice,
        IceArrow,
        DefenseDown,
        SS59,
        SS60,
        Stun,
        SS62,
        SS63,
        SS64,
        IllusionOorderOfBondage,
        SS66,
        SS67,
        SS68,
        SS69,
        SS70,
        SkillDamageDeflection,
        SkillSleep,
        SkillBlindness,
        SkillNeil,
        SkillSahamut,
        SkillNiceweek,
        SkillINNERBEIYSEYON,
        CherryManabuff,
        CherryLifebuff,
        CherryDamagebuff,
        SkillSwordPower,
        SkillMagicCircle,
        SkillSwordSlashEffect,
        SkillLightningStorm,
        SkillRedStorm,
        SkillCold,
        SealRed,
        SealYellow,
        USword,
        UTriangle,
        ImproveDefenseOfense,
        improveMaxLife,
        ImproveMana,
        ImproveDamage,
        ImrpoveDefense,
        improveAttackSpeed,
        ImproveBPRecovery,
        DuelInterface,
        SS99,
        SS100,
        SS101,
        SS102,
        DuelMedal,
    }

    public enum GateType : byte
    {
        Warp,
        Entrance,
        Exit,
    }

    public enum QuestState : byte
    {
        Clear,
        Reg,
        Complete,
        Unreg,
    }

    public enum QuestCompensation : byte
    {
        Statup = 200,
        Changeup,
        Plusstat,
        Comboskill,
        Master,
    }

    public enum DevilSquareState : byte
    {
        Close = 0,
        Open = 1,
        Playing = 2,
        None = 3,
        BeforeStart = 4,
        BeforeEnd = 5,
        Quit = 6,
        CCBeforeEnter = 10,
        CCBeforePlay = 11,
        CCBeforeEnd = 12
    }

    public enum ChaosBoxMixResult : byte
    {
        Fail,
        Success,
        InsufficientMoney,
        TooManyItems,
        LowLevelUser,
        LackingItems = 6,
        IncorrectItems,
        InvalidItemLevel,
        UserClassLow,
        NoBcCorrectItems,
        BcInsufficientMoney,
    }

    public enum ChaosMixType
    {
        Default = 0x1,
        DevilSquared = 0x2,
        Plus10 = 0x3,
        Plus11 = 0x4,
        Dinorant = 0x5,
        Fruit = 0x6,
        WingLv2 = 0x7,
        BloodCastle = 0x8,
        WingLv1 = 0xb,
        SetItem = 0xc,
        DrakHorse = 0xd,
        DarkSpirit = 0xe,
        BlessPotion = 0xf,
        SoulPotion = 0x10,
        LifeStone = 0x11,
        HTBox = 0x14,
        Plus12 = 0x16,
        Plus13 = 0x17,
        Cloak = 0x18,
        Fenrir1 = 0x19,
        Fenrir2 = 0x1a,
        Fenrir3 = 0x1b,
        Fenrir4 = 0x1c,
        CounpundPotionL1 = 0x1e,
        CounpundPotionL2 = 0x1f,
        CounpundPotionL3 = 0x20,
        JOHPurity = 0x21,
        JOHSmeltingItem = 0x22,
        JOHRestore = 0x23,
        Item380 = 0x24,
        LotteryMix = 0x25,
        OldPaper = 0x25,
        CondorFeather = 0x26,
        WingLv3 = 0x27,
        SeedExtract = 0x2a,
        SeedSphere = 0x2b,
        SeedCalc = 0x2c,
        Mix2 = 0x2d,
        Secromicom = 0x2e,
        Plus14 = 49,
        Plus15 = 50,
    };

    public enum ClientEffect : byte
    {
        RecoverShield = 3,
        LevelUp = 16,
        ShieldDamage = 17,
    }

    public enum PartyResults : byte
    {
        Fail,
        Success,
        PlayerOffline = 0x03,
        InAnotherParty = 0x04,
        RestrictedLevel = 0x05
    }

    public enum KanturuState : byte
    {
        None,
        BattleStandBy,
        BattleOfMaya,
        BattleOfNightmare,
        TowerOfRefinery,
    }

    public enum DuelResults : byte
    {
        NoError,
        Failed,
        InvalidUser,
        NonPKServer,
        NonDuelCSServer,
        ConnectionClosing,
        NotDuelMurderer,
        AlreadyDuelled,
        InvalidMap,
        LimitPacketTime,
        InvitedMyself,
        InvalidIndex,
        Disconnected,
        SelfDefense,
        GuildWar,
        RefuseInvitated,
        DuelMax,
        InvalidStatus,
        AlreadyDuelRequested,
        AlreadyDuelReserved,
        AlreadyDuelling,
        AlreadyDuelRequested1,
        AlreadyDuelReserved1,
        AlreadyDuelling1,
        InvalidChannelId,
        FailedEnter,
        NotExistUser,
        ObserverMax,
        LimitLevel,
        NotFoundMoveReqData,
        NotEnoughMoney
    }

    public enum PShopResult : byte
    {
        Disabled,
        Success,
        InvalidPosition,
        InvalidItem,
        InvalidPrice,
        LevelTooLow,
        ItemBlocked,
        LackOfZen,
        ExceedingZen,
    }
}
