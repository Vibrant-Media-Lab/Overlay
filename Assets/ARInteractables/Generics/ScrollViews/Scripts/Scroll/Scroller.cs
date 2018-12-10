using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Scroll
{

    public enum DIRECTION
    {
        DIRECTION1_POSITIVE,
        DIRECTION1_NEGATIVE,
        DIRECTION2_POSITIVE,
        DIRECTION2_NEGATIVE
    }

    public abstract class Scroller : MonoBehaviour
    {
        [SerializeField]
        protected ScrollRect scrollController;
        [SerializeField]
        protected float scrollSensitivity;

        private void Start()
        {
            if(scrollController == null)
            {
                scrollController = GetComponent<ScrollRect>();
            }
        }

        public abstract void DoScroll(DIRECTION direction);
    }
}