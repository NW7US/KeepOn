﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace KeepOn
{
    public static class Native
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);

        [Flags]
        public enum EXECUTION_STATE : uint
        {
            // Enables away mode. This value must be specified with ES_CONTINUOUS.
            // Away mode should be used only by media-recording and media-distribution applications
            // that must perform critical background processing on desktop computers
            // while the computer appears to be sleeping. See Remarks.
            ES_AWAYMODE_REQUIRED = 0x00000040,

            // Informs the system that the state being set should remain in effect
            // until the next call that uses ES_CONTINUOUS and one of the other state flags is cleared.
            ES_CONTINUOUS = 0x80000000,

            // Forces the display to be on by resetting the display idle timer.
            ES_DISPLAY_REQUIRED = 0x00000002,

            // Forces the system to be in the working state by resetting the system idle timer.
            ES_SYSTEM_REQUIRED = 0x00000001

            // Legacy flag, should not be used.
            // This value is not supported. If ES_USER_PRESENT is combined with other esFlags values,
            // the call will fail and none of the specified states will be set.
            //// ES_USER_PRESENT = 0x00000004
        }
    }
}
