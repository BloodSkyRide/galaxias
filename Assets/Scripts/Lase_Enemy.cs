using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Lase_Enemy : MonoBehaviour
{
    private Rigidbody2D RG;
    public float Speed = 5f;
    void Start()
    {
        RG = GetComponent<Rigidbody2D>(); // rigibody
    }

    void Update()
    {
        transform.Translate(Vector3.down * Speed * Time.deltaTime);
        Destroy(gameObject, 3f);
    }
}
