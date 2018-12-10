using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interaction.Interactors
{
    public class GamepadButton : Interactor
    {
        [SerializeField]
        private KeyCode buttonName;

        public override bool IsInteracting()
        {
            return Input.GetKey(buttonName);
        }
    }
}