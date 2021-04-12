using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{


    private Text cLevelText, nLevelText;
    private Image fill;

    private int level;
    private float startDistance, distance;
    private GameObject player, finish,hand;

    private TextMesh levelNo;
    // Start is called before the first frame update
    void Awake()
    {
        cLevelText = GameObject.Find("CurrentLevelText").GetComponent<Text>();
        nLevelText = GameObject.Find("NextLevelText").GetComponent<Text>();
        fill = GameObject.Find("Fill").GetComponent<Image>();

        player = GameObject.Find("Player");
        finish = GameObject.Find("Finish");

        levelNo = GameObject.Find("LevelNo").GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Start()
    {
        level = PlayerPrefs.GetInt("Level");
        levelNo.text = "LEVEL" + level;

        nLevelText.text = level + 1 + "";
        cLevelText.text = level.ToString();

        startDistance = Vector3.Distance(player.transform.position, finish.transform.position);
        //SceneManager.LoadScene("level" + level);
    }

    private void Update()
    {
        distance = Vector3.Distance(player.transform.position, finish.transform.position);
        if(player.transform.position.z < finish.transform.position.z)
            fill.fillAmount = 1 - (distance / startDistance);
    }

    public void RemoveUI()
    {
        hand.SetActive(false);
    }
}
