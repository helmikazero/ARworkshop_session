using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMenembak : MonoBehaviour
{
    public GameObject peluruPrefab;

    public float kecepatanPeluru = 10f;

    public Transform arCameraPos;

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
                Vector3 touchPos = arCamera.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, arCameraPos.position.z+0.1f));

                Vector3 dir = touchPos - arCameraPos.transform.position;

                dir.Normalize();

                GameObject peluruBaru = Instantiate(peluruPrefab, arCameraPos.position, arCameraPos.rotation);

                peluruBaru.GetComponent<Rigidbody>().velocity = dir * kecepatanPeluru;
            }
        }
    }
}
