using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Interaction;

namespace EnvironmentalHumanitiesPoster
{
    public class BallSwapController : MonoBehaviour
    {
        [SerializeField]
        private Interactor ballSwapInteractor;

        [SerializeField]
        private GameObject topBall;
        [SerializeField]
        private GameObject bottomBall;

        private Vector3 topBallStartingPosition;
        private Vector3 bottomBallStartingPosition;

        // Use this for initialization
        void Start()
        {
            topBallStartingPosition = topBall.transform.localPosition;
            bottomBallStartingPosition = bottomBall.transform.localPosition;
        }

        // Update is called once per frame
        void Update()
        {
            if (ballSwapInteractor.IsInteracting())
            {
                topBall.transform.localPosition = bottomBallStartingPosition;
                bottomBall.transform.localPosition = topBallStartingPosition;
            }
            else
            {
                topBall.transform.localPosition = topBallStartingPosition;
                bottomBall.transform.localPosition = bottomBallStartingPosition;
            }
        }
    }
}