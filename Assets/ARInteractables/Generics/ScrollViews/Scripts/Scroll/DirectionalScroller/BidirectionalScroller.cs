using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Interaction;

namespace Scroll.DirecitonalScroller
{
    public class BidirectionalScroller : Scroller
    {
        [SerializeField]
        [Tooltip("Positive direction is 'up'")]
        private Interactor upInteractor;
        [SerializeField]
        [Tooltip("Negative direction is 'down'")]
        private Interactor downInteractor;
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
            if (upInteractor.IsInteracting())
            {
                DoScroll(DIRECTION.DIRECTION1_POSITIVE);
            }

            if (downInteractor.IsInteracting())
            {
                DoScroll(DIRECTION.DIRECTION1_NEGATIVE);
            }

            if (leftInteractor.IsInteracting())
            {
                DoScroll(DIRECTION.DIRECTION2_NEGATIVE);
            }

            if (rightInteractor.IsInteracting())
            {
                DoScroll(DIRECTION.DIRECTION2_POSITIVE);
            }
        }
    }
}