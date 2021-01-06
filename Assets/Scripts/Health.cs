using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health; //number of fullHearts
    public int numOfHearts; //number of total hearts

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    void Update()
    {
        if (health > numOfHearts) //if health is bigger than
        {
            health = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health) //controls type of heart
            {
                hearts[i].sprite = fullHeart;
            }
            else
                hearts[i].sprite = emptyHeart;

            if (i < numOfHearts) //controls visibility
            {
                hearts[i].enabled = true;
            }
            else
                hearts[i].enabled = false;
        }
    }
}
