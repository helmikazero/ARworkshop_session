using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeluruMechanic : MonoBehaviour
{
    public float lifeTime;
    public ScoringSystem scoringSystem;

    void Start()
    {
        scoringSystem = GameObject.FindObjectOfType<ScoringSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if(lifeTime > 0)
        {
            lifeTime -= Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            scoringSystem.AddScore();
            Destroy(collision.gameObject);
        }

        Destroy(gameObject);
    }
}
