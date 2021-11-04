using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerSystem : MonoBehaviour
{
    [SerializeField]
    private Camera cam;

    [SerializeField]
    private Transform borderOne;
    [SerializeField]
    private Transform borderTwo;

    [SerializeField]
    private Transform target;

    [SerializeField]
    private float timer;
    [SerializeField]
    private float timerMax;

    [SerializeField]
    private Vector3 borderOnePos;
    [SerializeField]
    private Vector3 borderTwoPos;

    void Start()
    {
        timer = timerMax;

        borderOnePos = new Vector3(1.75f, 1.05f, 1.96f);
        borderTwoPos = new Vector3(-1.75f, -1.05f, 3.92f);

        borderOne.position = cam.transform.TransformDirection(borderOnePos - cam.transform.position);
        borderTwo.position = cam.transform.TransformDirection(borderTwoPos - cam.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            var position = new Vector3(Random.Range(borderOne.position.x, borderTwo.position.x), Random.Range(borderOne.position.y, borderTwo.position.y), Random.Range(borderOne.position.z, borderTwo.position.z));
            Instantiate(target, position, Quaternion.identity);
            timer = timerMax;
        }
    }
}
