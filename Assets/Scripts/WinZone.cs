using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (GameManager.Instance.hasKey)
            {
                GameManager.Instance.Win();
            }
            else
            {
                GameManager.Instance.FindKey();
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (GameManager.Instance.hasKey)
                Debug.Log("Do nothing");
            else
            {
                GameManager.Instance.DisableFindKey();
            }
        }
    }
}
