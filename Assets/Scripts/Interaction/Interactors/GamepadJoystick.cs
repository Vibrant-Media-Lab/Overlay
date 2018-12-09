using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interaction.Interactors
{
    public class GamepadJoystick : Interactor
    {
        [SerializeField]
        private string axisName;
        [SerializeField]
        private float joystickThreshold;
        [SerializeField]
        private bool joystickDirection;

        //private void Start()
        //{
        //    this.name = axisName;
        //}

        public override bool IsInteracting()
        {
            if (joystickDirection)
                return Input.GetAxisRaw(axisName) > joystickThreshold;
            else
                return Input.GetAxisRaw(axisName) < joystickThreshold;
        }
    }
}