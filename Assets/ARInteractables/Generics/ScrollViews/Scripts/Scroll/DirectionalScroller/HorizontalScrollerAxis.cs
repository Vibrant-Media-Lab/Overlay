using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gamepad;

namespace Scroll.DirecitonalScroller
{
    public class HorizontalScrollerAxis : Scroller
    {
        [SerializeField]
        private Joystick joystick;

        public override void DoScroll(DIRECTION direction)
        {
            switch (direction)
            {
                case DIRECTION.DIRECTION1_POSITIVE:
                    HorizontalScroll(scrollSensitivity);
                    break;
                case DIRECTION.DIRECTION1_NEGATIVE:
                    HorizontalScroll(-scrollSensitivity);
                    break;
                default: break;
            }
        }

        private void HorizontalScroll(float amount)
        {
            scrollController.horizontalNormalizedPosition += amount;
        }

        private void Update()
        {
            HorizontalScroll(joystick.GetXAxis() * scrollSensitivity);
        }
    }
}