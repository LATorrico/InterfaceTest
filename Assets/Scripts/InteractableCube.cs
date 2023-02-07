using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableCube : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV(Random.Range(0.0f, 1.0f), 1.0f);
    }
}
