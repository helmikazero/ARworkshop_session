using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMenembak : MonoBehaviour
{
    public GameObject peluruPrefab;

    public float kecepatanPeluru;

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

                Debug.Log("MENCET BERHASIL");
                Vector3 touchPos = arCamera.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, arCamera.transform.position.z + 0.1f));

                Vector3 dir = touchPos - arCameraPos.position;
                dir.Normalize();

                GameObject peluruBaru = Instantiate(peluruPrefab, arCameraPos.position, arCameraPos.rotation);

                peluruBaru.GetComponent<Rigidbody>().velocity = dir * kecepatanPeluru;
            }
        }

    }
}
