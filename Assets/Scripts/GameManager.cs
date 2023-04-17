using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text timeText;
    public GameObject card;
    float time;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 16; i++)
        {
            GameObject newCard = Instantiate(card);
            // newCard를 cards 안으로 옮겨줘
            newCard.transform.parent = GameObject.Find("cards").transform;
            float x = (i / 4) * 1.4f - 2.1f;
            float y = (i % 4) * 1.4f - 3.0f;
            newCard.transform.position = new Vector3(x, y, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        timeText.text = time.ToString("N2");
    }
}
