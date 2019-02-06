using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Peanut : MonoBehaviour
{
    [MenuItem("AssetDatabase/LoadAssetExample")]



    private void Start()
    {
        GameObject PindaPrefab = (GameObject)AssetDatabase.LoadAssetAtPath("Assets/Textures/texture.jpg", typeof(GameObject));
    }

    void Update ()
    {
    }
}
