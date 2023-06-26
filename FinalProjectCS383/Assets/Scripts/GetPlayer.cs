using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPlayer : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player = null;
    void Start()
    {
        player = GameManager.getPlayer;
        
    }

    // Update is called once per frame
    void Update()
    {
        //player = GameManager.getPlayer;
        //player = this.gameObject;
        player = GameManager.getPlayer;
        //Debug.LogError(player);
        //DontDestroyOnLoad(player);
    }
}
