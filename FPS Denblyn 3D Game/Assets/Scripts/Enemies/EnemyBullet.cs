using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class EnemyBullet : MonoBehaviour
{
    private Vector3 direction;
    private float speed;

    public void Init(Vector3 dir, float spd)
    {
        direction = dir.normalized;
        speed = spd;
    }

    private void Start()
    {
        StartCoroutine(DestroyBullet());
    }

    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FirstPersonController.beFired = true;
            GlobalHealth.healthValue -= 5;
            Destroy(gameObject);
        }
        else if (!other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

    IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
}
