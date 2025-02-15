

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
 
public class UI : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI pointsText;
    public GameObject defeatUI;
 
    void Update()
    {
        pointsText.text = player.points.ToString();
 
        if (player == null)
        {
            defeatUI.SetActive(true);
        }
    }
 
    public void OnClickRestart() {
 
        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index);
    }
}
