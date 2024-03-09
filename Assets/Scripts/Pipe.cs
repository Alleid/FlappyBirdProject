using Edgar.Unity.Examples;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Pipe :MonoBehaviour, IInteractable
{

    private void Awake()
    {
        GetComponent<Collider2D>().isTrigger = true;
    }
}
