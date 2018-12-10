using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interaction.Interactors
{
    public class ScreenButton : Interactor
    {
        [SerializeField]
        private Button screenButton;

        public override bool IsInteracting()
        {
            throw new System.NotImplementedException();
        }
    }
}