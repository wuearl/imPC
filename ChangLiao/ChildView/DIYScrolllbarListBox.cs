﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangLiao.ChildView
{
    public class HideScrollListBox : CCWin.SkinControl.SkinListBox
    {
        private bool mShowScroll;
        protected override System.Windows.Forms.CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                if (!mShowScroll)
                    cp.Style = cp.Style & ~0x200000;
                return cp;
            }
        }
        public bool ShowScrollbar
        {
            get { return mShowScroll; }
            set
            {
                if (value != mShowScroll)
                {
                    mShowScroll = value;
                    if (IsHandleCreated)
                        RecreateHandle();
                }
            }
        }

       
    }
}
