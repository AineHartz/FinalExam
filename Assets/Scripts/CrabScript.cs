using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CrabScript : MonoBehaviour
{
    public int hp;
    public TMPro.TextMeshProUGUI hpText;
    public UnityEngine.UI.Slider hpSlider;
    public GameObject enemy;
    private float waitTime = 1.0f;
    public bool won = false;

    void Start()
    {
        hp = 500;
    }


    void Update()
    {
        waitTime = waitTime - Time.deltaTime;

        if(waitTime <= 0 && !won)
        {
            attack();
        }

        if (Input.GetKeyDown(KeyCode.Space) && !won)
        {
            takeDamage();
        }

        display();
    }

    public void takeDamage()
    {
        hp -= 10;
    }

    public void attack()
    {
        enemy.GetComponent<AccordianScript>().hp -= 25;
        waitTime = 1.0f;
    }

    public void display()
    {
        hpText.text = "Current HP: " + hp;
        hpSlider.value = hp;
    }
}
