using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManager Instance;
    
    private void Awake()
    {
        Instance = this;
    }
    [SerializeField] GameObject WinText;
    [SerializeField] GameObject FindKeyText;
    [SerializeField] GameObject WinParticle;
    public bool hasKey = false;

    public void Win()
    {
        WinText.SetActive(true);
        WinParticle.SetActive(true);
    }
    public void Haskey()
    {
        hasKey = true;
    }
    public void FindKey()
    {
        FindKeyText.SetActive(true);
    }
    public void DisableFindKey()
    {

        FindKeyText.SetActive(false);
    }
}
