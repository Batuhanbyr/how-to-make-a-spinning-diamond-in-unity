using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    [Header("-------- object to rotate --------")]
    public GameObject Diamondd;

    void Update()
    {
        Diamondd.transform.Rotate(new Vector3(0, 0, 8)); // Diamond spin 
        Diamondd.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY |
                RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY; // We freeze the positions so that the parent does not change shape according to the object it takes.
    }
}

