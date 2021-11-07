using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Camera cam;

    void Update()
    {
        transform.position = cam.transform.position;
    }
}
