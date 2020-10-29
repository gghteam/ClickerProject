using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Player player;
    [SerializeField]
    private Text textMoney;

    private string jsonString = "";
    private string filePath = "";
    private void Awake()
    {
        player = new Player();
        filePath = string.Concat(Application.persistentDataPath,"/", "SaveLunch.txt");
        Debug.Log("filePath : " + filePath);
        OnClickLoad();
    }
    public void OnClick()
    {
        player.money += player.moneyPerClick;
        UpdateMoney();
    }

    public void UpdateMoney()
    {
        textMoney.text = string.Format("{0}원", player.money);
    }
    public void OnClickSave()
    {
        jsonString = JsonUtility.ToJson(player);
        FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
        byte[] data = Encoding.UTF8.GetBytes(jsonString);

        fs.Write(data, 0, data.Length);
        fs.Close();
    }

    public void OnClickLoad()
    {
        FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
        byte[] data = new byte[fs.Length];
        fs.Read(data, 0, data.Length);
        fs.Close();

        jsonString = Encoding.UTF8.GetString(data);
        player = JsonUtility.FromJson<Player>(jsonString);

        UpdateMoney();
    }

    private void OnApplicationQuit()
    {
        OnClickSave();
    }
}


