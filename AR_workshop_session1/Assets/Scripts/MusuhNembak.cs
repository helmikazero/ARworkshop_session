using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusuhNembak : MonoBehaviour
{
    public Transform player;
    public Transform gunPos;
    public Vector2 fireRate = new Vector2(0.3f,0.3f);

    public float kecepatanPeluru = 5f;

    public GameObject prefabPeluru;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);

        if(fireRate.x > 0)
        {
            fireRate.x -= Time.deltaTime;
        }
        else
        {
            GameObject newPeluru = Instantiate(prefabPeluru, gunPos.position, gunPos.rotation);

            newPeluru.GetComponent<Rigidbody>().velocity = gunPos.TransformDirection(Vector3.forward * kecepatanPeluru);


            fireRate.x = fireRate.y;
        }
    }
}
