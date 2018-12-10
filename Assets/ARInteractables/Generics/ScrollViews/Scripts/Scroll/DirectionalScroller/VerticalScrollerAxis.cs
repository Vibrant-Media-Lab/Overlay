using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gamepad;

namespace Scroll.DirecitonalScroller
{
    public class VerticalScrollerAxis : Scroller
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
                default:
                    break;
            }
        }

        private void VerticalScroll(float amount)
        {
            scrollController.verticalNormalizedPosition += amount;
        }

        private void Update()
        {
            VerticalScroll(joystick.GetYAxis() * scrollSensitivity);
        }
    }
}