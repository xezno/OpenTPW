﻿// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable IdentifierTypo

namespace OpenTPW.RSSEQ
{
    // Some opcodes are missing entirely, and I'm pretty sure
    // ADDOBJ_2 and ADDOBJ_3 aren't actually ADDOBJ at all.
    // TODO: investigate further
    public enum Opcode
    {
        INIT = 0,
        CRIT_LOCK = 1,
        CRIT_UNLOCK = 2,
        COPY = 3,
        SUB = 5,
        ENDSLICE = 6,
        GETTIME = 7,
        ADDOBJ = 8,
        KILLOBJ = 10,
        FADEOBJ = 11,
        ADDOBJ_2 = 12,
        EVENT = 13,
        FLUSHANIM = 15,
        TRIGANIM = 16,
        WAITANIM = 17,
        LOOPANIM = 18,
        TRIGWAITANIM = 19,
        TURBO = 21,
        TRIGANIM_CH = 23,
        LOOPANIM_CH = 25,
        GETANIM_CH = 27,
        RAND = 28,
        JSR = 29,
        RETURN = 30,
        BRANCH = 31,
        BRANCH_Z = 32,
        BRANCH_NZ = 33,
        BRANCH_NV = 34,
        BRANCH_PV = 35,
        NAME = 37,
        TEST = 38,
        CMP = 39,
        HUSH = 42,
        HOP = 43,
        WAIT = 44,
        WAIT4ANIM = 46,
        ADD = 47,
        DIV = 49,
        MOD = 50,
        ADDOBJ_3 = 51,
        TOUR = 53,
        BUMP = 54,
        COAST = 55,
        ADDHEAD = 56,
        DELHEAD = 57,
        LIMBO = 58,
        UNLIMBO = 59,
        FORCEUNLIMBO = 60,
        INLIMBO = 61,
        LIMBOSPACE = 62,
        SPAWNCHILD = 63,
        SPAWNSOUND = 64,
        REMOVECHILD = 65,
        SETVARINCHILD = 66,
        GETVARINCHILD = 67,
        GETVARINPARENT = 69,
        SETBOUNCENODE = 70,
        BOUNCESETBASE = 71,
        BOUNCE = 72,
        UNBOUNCE = 73,
        FORCEUNBOUNCE = 74,
        BOUNCING = 75,
        WALKON = 76,
        WALKOFF = 77,
        WALKGET = 78,
        WALKST_FLOAT = 79,
        WALKFLOATSTAT = 80,
        WALKFLOATSTOP = 81,
        STARTSCREAM = 86,
        STOPSCREAM = 87,
        SINGLESCREAM = 88,
        SCREAMLEVEL = 89,
        FINDSCRIPTRAND = 90,
        SETREMOTEVAR = 92,
        REPAIREFFECT = 93,
        SETTIMER = 95,
        GETTIMER = 96,
        HOUR = 100,
        MIN = 101,
        SEC = 102,
        SETREVERB = 103,
        DIPMUSIC = 104,
        SPARK = 105
    }
}