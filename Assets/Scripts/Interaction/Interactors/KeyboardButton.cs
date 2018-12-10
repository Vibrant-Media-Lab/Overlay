using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interaction.Interactors
{
    public class KeyboardButton : Interactor
    {
        [SerializeField]
        private string buttonName;

        public override bool IsInteracting()
        {
            return Input.GetButton(buttonName);
        }
    }
}