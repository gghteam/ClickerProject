using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Player player;
    private string jsonString = "";
    private void Awake()
    {
        player = new Player();
    }

    public void OnClickSave()
    {
        jsonString = JsonUtility.ToJson(player);
        Debug.Log("JSON : " + jsonString);
    }

    public void OnClickLoad()
    {
        player = JsonUtility.FromJson<Player>(jsonString);
    }
}


