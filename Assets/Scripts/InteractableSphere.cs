using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableSphere : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        gameObject.GetComponent<Transform>().localScale += new Vector3(1,1,1);
    }
}
