using UnityEngine;
using UnityEngine.UI;
using System;

public class SLIDER : MonoBehaviour
{
    public float Health { get => HP.value; set => health = value; }
    private float health;

    public Slider HP;

    public Text result;
    public Text sofarhp;


    private void Update()
    {
        if (Health <= 30)
        {
            result.text = "危險";
        }
        else if (Health <= 70)
        {
            result.text = "警告";
        }
        else
        {
            result.text = "安全";
        }

        sofarhp.text ="HP:" + HP.value.ToString("f0") + "/100";
    }
}
