using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cocos2d;

namespace tests
{
    public class PageTransitionBackward : CCTransitionPageTurn
    {
        public PageTransitionBackward (float t, CCScene s) : base (t, s, true)
        {
            CCDirector.SharedDirector.SetDepthTest(true);
        }
    }
}
