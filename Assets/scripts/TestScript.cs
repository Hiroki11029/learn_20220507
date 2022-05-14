using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    [SerializeField]
    private int index;
    [SerializeField]
    private bool isFlag;
    // Start is called before the first frame update
    void Start()
    {
        if (isFlag)
        {
            Init();
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void Init()
    {
        Debug.Log($"index={index}");
    }
}
