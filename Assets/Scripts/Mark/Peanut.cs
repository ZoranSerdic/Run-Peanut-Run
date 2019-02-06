using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Peanut : MonoBehaviour
{
    private GameObject PindaPrefab;
    private Vector3 SpawnPos;

    [MenuItem("AssetDatabase/LoadAssetExample")]

    private void Start()
    {
        PindaPrefab = (GameObject)AssetDatabase.LoadAssetAtPath("Assets/Prefab/Pindakaas_Prefab.prefab", typeof(GameObject));
    }

    public void Die()
    {
        SpawnPos = new Vector3(transform.position.x, -0.4f, transform.position.z);
        Instantiate(PindaPrefab, SpawnPos, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
