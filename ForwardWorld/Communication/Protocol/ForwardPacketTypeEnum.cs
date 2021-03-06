﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//@Author NightWolf
//This is a file from Project $safeprojectname$

namespace Crystal.WorldServer.Communication.Protocol
{
    public enum ForwardPacketTypeEnum
    {
        HelloKeyMessage = 1,
        SecureKeyMessage = 2,
        PlayerCommingMessage = 3,
        PlayerCreatedCharacterMessage = 4,
        PlayerDeletedCharacterMessage = 5,
        PlayerConnectedMessage = 6,
        PlayerDisconnectedMessage = 7,
        WorldSave = 8,
        WorldSaveFinished = 9,
        WorldMaintenance = 10,
        WorldMaintenanceFinished = 11,
        ClientShopPointUpdateMessage = 12,
        KickPlayerMessage = 13,
        NIGHTWORLD_ClientInfos = 14,
        NIGHTWORLD_CrashServer = 15,
        NIGHTWORLD_PromoteAccount = 16,
    }
}
