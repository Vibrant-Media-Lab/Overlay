using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interaction.Iteractables
{
    public class Hyperlink : Interactable
    {
        [SerializeField]
        private string link;

        public override void Interact()
        {
            Debug.Log("Button pressed");
            Application.OpenURL(link);
        }
    }
}