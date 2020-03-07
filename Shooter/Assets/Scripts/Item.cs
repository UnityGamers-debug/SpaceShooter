using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public string itemName; //Вводим имена в inspector
    private int _score;

    public Text scoretext;

    private void Start()
    {
        scoretext.text = "0";
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Item collected: " + itemName);
        Destroy(this.gameObject);
        if (itemName == "health")
        {//проверяем, является ли объект здоровьем
            PlayerCharacter player = other.GetComponent<PlayerCharacter>();
            if (player != null)
            {//проверяем, является ли объект PlayerCharacter
                player.ChangeHealth(250);
            }
        }
        if (itemName == "cube")
        {//проверяем, является ли объект здоровьем
            _score++;
            scoretext.text = _score.ToString();
            Debug.Log("Score: " + _score);
        }
    }
}
