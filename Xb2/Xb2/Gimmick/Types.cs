﻿using System.Collections.Generic;

namespace Xb2.Gimmick
{
    public static class Types
    {
        public static string[] GimmickFieldNames = {
            "enemy",
            "enemy",
            "enemy",
            "npc",
            "npc",
            "npc",
            "mapObj",
            "mapObj",
            "mapObj",
            "tbox",
            "event",
            "enemy",
            "fieldLock",
            "effect",
            "effect",
            "se",
            "se",
            "se",
            "mob",
            "mob",
            "mob",
            "landmark",
            "",
            "",
            "formPc",
            "formPc",
            "formPcEv",
            "formPcEv",
            "collection",
            "areaBgm",
            "areaWeather",
            "salvage",
            "",
            "mapGimmick",
            "precious",
            "grave",
            "kizunaTalk",
            "jump",
            "warp",
            "squad",
            "squad",
            "door",
            "elevator",
            "elevator",
            "mapJump",
            "fieldVolume",
            "climbing",
            "blade",
            "dmgGimmick",
            "dmgGimmick",
            "dmgGimmick",
            "dmgGimmick",
            "",
            "enemy",
            "footPrint",
            "footPrint",
            "antiBladeArea",
            "tutorial",
            "enemyWave",
            "battleChallenge",
            "mapObj",
            "npc",
            "campPop",
            "sealedStone"
        };

        public static Dictionary<string, string> GimmickIds = new Dictionary<string, string>
        {
            ["ABLA"] = "GmkAntiBladeArea",
            ["AWTR"] = "GmkAreaWeather",
            ["BCRP"] = "GmkBattleChallengePortal",
            ["BCRW"] = "GmkBattleChallengeReward",
            ["BGAR"] = "GmkAreaBgm",
            ["BLAD"] = "GmkBlade",
            ["BTCL"] = "GmkBattleChallenge",
            ["BTLC"] = "GmkBattleLock",
            ["CAMP"] = "GmkCamp",
            ["CLCT"] = "GmkCollection",
            ["CLMB"] = "GmkClimbing",
            ["CTPT"] = "GmkRoutePoint",
            ["CURV"] = "GmkRoute",
            ["DMEF"] = "GmkDmgEffect",
            ["DMGM"] = "GmkDmgGimmick",
            ["DMPH"] = "GmkDmgPhantom",
            ["DMSE"] = "GmkDmgSe",
            ["DOOR"] = "GmkDoor",
            ["EFCT"] = "GmkEffect",
            ["EFLC"] = "GmkEffectLocator",
            ["ELLC"] = "GmkElevatorLocator",
            ["ELVT"] = "GmkElevator",
            ["ENEM"] = "GmkEnemy",
            ["ENEW"] = "GmkEnemyWave",
            ["ENRP"] = "GmkRoutedEnemyPoint",
            ["EVNT"] = "GmkEvent",
            ["FDLC"] = "GmkFieldLock",
            ["FRNP"] = "TGmkFormPcnpc",
            ["FRPC"] = "TGmkFormPc",
            ["FVLM"] = "GmkFieldVolume",
            ["GRAV"] = "GmkGrave",
            ["JUMP"] = "GmkJump",
            ["KZNT"] = "GmkKizunaTalk",
            ["LDMK"] = "GmkLandmark",
            ["MAPG"] = "GmkMapGimmick",
            ["MAPO"] = "GmkMapObj",
            ["MOB"] = "GmkMob",
            ["MPJP"] = "GmkMapJump",
            ["NPC"] = "GmkNpc",
            ["PRCS"] = "GmkPrecious",
            ["RENM"] = "GmkRoutedEnemy",
            ["RFPP"] = "GmkRoutedFootPrintPoint",
            ["RFPT"] = "GmkRoutedFootPrint",
            ["RMOB"] = "GmkRoutedMob",
            ["RMPO"] = "GmkRoutedMapObj",
            ["RNPC"] = "GmkRoutedNpc",
            ["SALV"] = "GmkSalvage",
            ["SELN"] = "GmkSeLine",
            ["SLDS"] = "GmkSealedStone",
            ["SLLC"] = "GmkSalvageLocator",
            ["SLPT"] = "GmkSeLinePoint",
            ["SNDE"] = "GmkSe",
            ["SQLD"] = "GmkSquadLeader",
            ["SQMB"] = "GmkSquadMember",
            ["TBOX"] = "GmkTbox",
            ["TGPT"] = "GmkTargetPoint",
            ["TRGR"] = "GmkTrigger",
            ["TUTO"] = "GmkTutorial",
            ["WARP"] = "GmkWarp",
        };
    }

    public enum GimmickType
    {
        Enemy,
        RoutedEnemy,
        RoutedEnemyPoint,
        Npc,
        RoutedNpc,
        Type5,
        MapObj,
        RoutedMapObj,
        Type8,
        Tbox,
        Event,
        BattleLock,
        FieldLock,
        Effect,
        EffectLocator,
        Se,
        SeLine,
        SeLinePoint,
        Mob,
        RoutedMob,
        Type20,
        Landmark,
        Route,
        RoutePoint,
        Type24,
        Type25,
        Type26,
        Type27,
        Collection,
        AreaBgm,
        AreaWeather,
        Salvage,
        SalvageLocator,
        MapGimmick,
        Precious,
        Grave,
        KizunaTalk,
        Jump,
        Warp,
        SquadLeader,
        SquadMember,
        Door,
        Elevator,
        ElevatorLocator,
        MapJump,
        FieldVolume,
        Climbing,
        Blade,
        DmgGimmick,
        DmgPhantom,
        DmgEffect,
        DmgSe,
        Trigger,
        TargetPoint,
        RoutedFootPrint,
        RoutedFootPrintPoint,
        AntiBladeArea,
        Tutorial,
        EnemyWave,
        BattleChallenge,
        BattleChallengeReward,
        BattleChallengePortal,
        Camp,
        SealedStone
    }
}
