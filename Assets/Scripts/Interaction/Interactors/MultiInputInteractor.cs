using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Interaction.Interactors
{
    public class MultiInputInteractor : Interactor
    {
        [SerializeField]
        private bool requiresAll = false;
        [SerializeField]
        private List<Interactor> interactors;

        public override bool IsInteracting()
        {
            //Debug.Log("Some interaction: " + interactors[0].IsInteracting());
            if (requiresAll)
            {
                return interactors.All(c => c.IsInteracting());
            }
            else
            {
                return interactors.Any(c => c.IsInteracting());
            }

        }
    }
}