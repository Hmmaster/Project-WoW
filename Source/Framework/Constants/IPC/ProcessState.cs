﻿// Copyright (c) Arctium Emulation.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Framework.Constants.IPC
{
    public enum ProcessState : byte
    {
        None    = 0,
        Start   = 1,
        Stop    = 2,
        Started = 3,
        Stopped = 4,
        Hanging = 5
    }
}
