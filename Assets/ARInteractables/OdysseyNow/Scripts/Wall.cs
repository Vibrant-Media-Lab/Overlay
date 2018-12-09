using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Odyssey
{
    public class Wall : MonoBehaviour
    {

        private List<GameObject> touching;

        // Use this for initialization
        void Start()
        {
            touching = new List<GameObject>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnColliderEnter(Collision collision)
        {
            touching.Add(collision.gameObject);
            Debug.Log(collision.gameObject + " entered");
        }

        private void OnCollisionExit(Collision collision)
        {
            touching.Remove(collision.gameObject);
            Debug.Log(collision.gameObject + " exited");
        }

        public bool inContactWith(GameObject gameObject)
        {
            return touching.Contains(gameObject);
        }
    }
}
