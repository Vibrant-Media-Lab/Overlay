using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interaction
{
    public abstract class Interactor : MonoBehaviour
    {
        public string InteractorName;

        public abstract bool IsInteracting();
    }
}