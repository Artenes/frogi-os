﻿using System;
using System.Windows.Forms;


namespace FROGI_OS
{
    public class TablessControl : TabControl
    {
        protected override void WndProc(ref Message m) {
            if (m.Msg == 0x1328 && !DesignMode)
            {
                m.Result = (IntPtr)1;
            }
            else {
                base.WndProc(ref m);
            }
        }


    }
}
