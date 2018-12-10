using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Interaction;

namespace Scroll.DirecitonalScroller
{
    public class VerticalScroller : Scroller
    {
        [SerializeField]
        [Tooltip("Positive direction is 'up'")]
        private Interactor upInteractor;
        [SerializeField]
        [Tooltip("Negative direction is 'down'")]
        private Interactor downInteractor;

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
            if (upInteractor.IsInteracting()){
                DoScroll(DIRECTION.DIRECTION1_POSITIVE);
            }

            if (downInteractor.IsInteracting())
            {
                DoScroll(DIRECTION.DIRECTION1_NEGATIVE);
            }
        }
    }
}