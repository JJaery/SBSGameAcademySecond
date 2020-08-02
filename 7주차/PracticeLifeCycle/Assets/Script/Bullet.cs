using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEditor.Experimental.AssetImporters;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject owner;

    public float bulletSpeed = 0.5f;
    public float lifeTime = 3f;
    public float damage = 15f;

    private void Awake()
    {
        StartCoroutine(CheckLife());
    }

    IEnumerator CheckLife()
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        ///Vector3.right와 transform.right 의 차이점은 절대벡터냐 상대벡터냐 차이점입니다.
        transform.position += transform.right * bulletSpeed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == owner)
            return;

        Character targetScript = 
            collision.gameObject.GetComponent<Character>();

        if (targetScript != null)
        {
            targetScript.Hitted(this);
            Destroy(gameObject);
        }
    }
}
