using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Interaction;

namespace Scroll.DirecitonalScroller
{
    public class HorizontalScroller : Scroller
    {
        [SerializeField]
        [Tooltip("Negative direction is 'left'")]
        private Interactor leftInteractor;
        [SerializeField]
        [Tooltip("Positive direction is 'right'")]
        private Interactor rightInteractor;

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
            }
        }

        private void HorizontalScroll(float amount)
        {
            scrollController.horizontalNormalizedPosition += amount;
        }

        private void Update()
        {
            if (leftInteractor.IsInteracting())
            {
                DoScroll(DIRECTION.DIRECTION1_NEGATIVE);
            }

            if (rightInteractor.IsInteracting())
            {
                DoScroll(DIRECTION.DIRECTION1_POSITIVE);
            }
        }
    }
}