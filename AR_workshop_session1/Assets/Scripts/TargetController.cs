using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    [SerializeField]
    private float kecepatan;

    [SerializeField]
    private Transform player;

    [SerializeField]
    private ScoringSystem scoringSystem;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        scoringSystem = GameObject.FindObjectOfType<ScoringSystem>();
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, kecepatan);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            scoringSystem.TakeDamage();
        }
    }
}
