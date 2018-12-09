using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Odyssey
{
    public class Button : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        public bool isPressed = false;

        public void OnPointerDown(PointerEventData eventData)
        {
            isPressed = true;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            isPressed = false;
        }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void SetPressed(bool state)
        {
            isPressed = state;
        }

        public bool Pressed()
        {
            return isPressed;
        }
    }
}