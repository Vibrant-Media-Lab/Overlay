using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Interaction;
using UnityEditor;

namespace Odyssey
{
    //[CustomEditor(typeof(PlayerController))]
    //public class MyScriptEditor : Editor
    //{
    //    override public void OnInspectorGUI()
    //    {
    //        //PlayerController myScript = target as PlayerController;

    //        //myScript.leftButton = GUILayout.TextField(myScript.leftButton, "LeftButton");

    //        //if (myScript.flag)
    //        //    myScript.i = EditorGUILayout.IntSlider("I field:", myScript.i, 1, 100);

    //    }
    //}

    public class PlayerController : MonoBehaviour
    {

        public float speed = 1f;

        public Interactor leftButton;
        public Interactor rightButton;
        public Interactor upButton;
        public Interactor downButton;

        private Wall LeftWall;
        private Wall RightWall;
        private Wall TopWall;
        private Wall BottomWall;

        public GameManager gameManager;

        private float localYStart;

        private void Start()
        {
            localYStart = transform.localPosition.y;

            if(LeftWall == null)
            {
                LeftWall = gameManager.LeftWall;
            }
            if(RightWall == null)
            {
                RightWall = gameManager.RightWall;
            }
            if(TopWall == null)
            {
                TopWall = gameManager.TopWall;
            }
            if(BottomWall == null)
            {
                BottomWall = gameManager.BottomWall;
            }
        }

        // Update is called once per frame
        void Update()
        {
            float updatedZ = transform.localPosition.z;
            float updatedX = transform.localPosition.x;

            if (leftButton.IsInteracting() && notInLeftWall())
            {
                updatedX -= speed;
            }

            if (rightButton.IsInteracting() && notInRightWall())
            {
                updatedX += speed;
            }

            if (upButton.IsInteracting() && notInTopWall())
            {
                updatedZ += speed;
            }

            if (downButton.IsInteracting() && notInBottomWall())
            {
                updatedZ -= speed;
            }

            transform.localPosition = new Vector3(updatedX, localYStart, updatedZ);
        }

        private bool notInBottomWall()
        {
            return !collidedWith(BottomWall);
        }

        private bool notInTopWall()
        {
            return !collidedWith(TopWall);
        }

        private bool notInRightWall()
        {
            return !collidedWith(RightWall);
        }

        private bool notInLeftWall()
        {
            return !collidedWith(LeftWall);
        }

        private bool collidedWith(Wall bottomWall)
        {
            return bottomWall.inContactWith(gameObject);
        }
    }

}