using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gamepad
{
    public class Joystick : MonoBehaviour
    {

        [SerializeField]
        private string x_axis;
        [SerializeField]
        private string y_axis;

        [SerializeField]
        private bool flip_x_axis;
        [SerializeField]
        private bool flip_y_axis;

        public float GetXAxis()
        {
            return Input.GetAxis(x_axis) * (flip_x_axis ? -1 : 1);
        }

        public float GetYAxis()
        {
            return Input.GetAxis(y_axis) * (flip_y_axis ? -1 : 1);
        }

    }
}