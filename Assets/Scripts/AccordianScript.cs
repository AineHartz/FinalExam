using UnityEngine;
using UnityEngine.UI;

public class AccordianScript : MonoBehaviour
{
    public int hp;
    public TMPro.TextMeshProUGUI hpText;
    public Slider hpSlider;

    void Start()
    {
        hp = 500;
    }

    void Update()
    {
        display();
    }
    public void display()
    {
        hpText.text = "Current HP: " + hp;
        hpSlider.value = hp;
    }
}
