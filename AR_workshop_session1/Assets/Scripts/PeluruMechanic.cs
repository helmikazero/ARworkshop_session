using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeluruMechanic : MonoBehaviour
{
    [SerializeField]
    private float lifeTime;

    [SerializeField]
    private ScoringSystem scoringSystem;

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
            Destroy(collision.gameObject);
            scoringSystem.AddScore();
        }

        Destroy(gameObject);
    }
}
