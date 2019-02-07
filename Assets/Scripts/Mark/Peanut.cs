using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Peanut : MonoBehaviour
{
    [SerializeField]
    private GameObject PindaPrefab;
    private Vector3 SpawnPos;

    public void Die()
    {
        SpawnPos = new Vector3(transform.position.x, -0.4f, transform.position.z);
        Instantiate(PindaPrefab, SpawnPos, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
