using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interaction.Interactors
{
    public class KeyboardKey : Interactor
    {
        [SerializeField]
        private readonly KeyCode keycode;

        public override bool IsInteracting()
        {
            return Input.GetKey(keycode);
        }
    }
}