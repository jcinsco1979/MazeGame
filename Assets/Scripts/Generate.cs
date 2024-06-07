using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
    public static int index;
    [SerializeField] GameObject prefab;
    [ContextMenu("Gen")]
    void Gen()
    {
        GameObject g=  Instantiate(prefab, this.transform);
        g.transform.localPosition = Vector3.zero;
        g.transform.rotation = Quaternion.identity;
        g.transform.localScale = Vector3.one;
        g.transform.parent = this.transform.parent;
        g.transform.name = "Floor_" + index;
        index++;
        Destroy(this.gameObject);


    }
}
