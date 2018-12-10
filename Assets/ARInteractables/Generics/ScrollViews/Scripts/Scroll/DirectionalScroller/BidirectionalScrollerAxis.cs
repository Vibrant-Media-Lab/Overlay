using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gamepad;

namespace Scroll.DirecitonalScroller
{
    public class BidirectionalScrollerAxis : Scroller
    {
        [SerializeField]
        private Joystick joystick;

        public override void DoScroll(DIRECTION direction)
        {
            switch (direction)
            {
                case DIRECTION.DIRECTION1_POSITIVE:
                    VerticalScroll(scrollSensitivity);
                    break;
                case DIRECTION.DIRECTION1_NEGATIVE:
                    VerticalScroll(-scrollSensitivity);
                    break;
                case DIRECTION.DIRECTION2_POSITIVE:
                    HorizontalScroll(scrollSensitivity);
                    break;
                case DIRECTION.DIRECTION2_NEGATIVE:
                    HorizontalScroll(-scrollSensitivity);
                    break;
            }
        }

        private void VerticalScroll(float amount)
        {
            scrollController.verticalNormalizedPosition += amount;
        }

        private void HorizontalScroll(float amount)
        {
            scrollController.horizontalNormalizedPosition += amount;
        }

        private void Update()
        {
            HorizontalScroll(joystick.GetXAxis() * scrollSensitivity);
            VerticalScroll(joystick.GetYAxis() * scrollSensitivity);
        }
    }
}