using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingManager : MonoBehaviour
{
    public GameObject prefabPeluru;

    public Transform lokasiCamera;

    public Camera arCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Began)
            {
                Vector3 touchPos = arCamera.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, arCamera.transform.position.z + 0.1f));

                Vector3 dir = touchPos - arCamera.transform.position;

                dir.Normalize();

                GameObject peluruBaru = Instantiate(prefabPeluru, lokasiCamera.position, lokasiCamera.rotation);

                peluruBaru.GetComponent<Rigidbody>().velocity = dir * 10f;
            }

        }
    }
}
