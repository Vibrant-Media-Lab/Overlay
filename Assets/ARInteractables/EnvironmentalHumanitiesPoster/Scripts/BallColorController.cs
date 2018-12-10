using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Interaction;

namespace EnvironmentalHumanitiesPoster
{
    public class BallColorController : MonoBehaviour
    {
        [SerializeField]
        private Interactor colorCycleInteractor;

        [SerializeField]
        private GameObject colorCycleBall;

        private Renderer ballRenderer;

        [SerializeField]
        private List<Material> materialCycle;

        private int currentColor = 0;

        private bool waitForClick = false;

        // Use this for initialization
        void Start()
        {
            ballRenderer = colorCycleBall.GetComponent<Renderer>();
        }

        // Update is called once per frame
        void Update()
        {
            if (colorCycleInteractor.IsInteracting() && !waitForClick)
            {
                ballRenderer.material = materialCycle[currentColor];
                currentColor = (currentColor + 1) % materialCycle.Count;
                waitForClick = true;
            }

            if (!colorCycleInteractor.IsInteracting())
            {
                waitForClick = false;
            }
        }
    }
}