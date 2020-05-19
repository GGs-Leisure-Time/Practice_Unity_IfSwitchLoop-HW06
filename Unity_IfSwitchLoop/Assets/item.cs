using UnityEngine;
using UnityEngine.UI;

public class item : MonoBehaviour
{
    public InputField inputField;
    public Text result;

    private void Update()
    {
        result.text = inputField.text == "紅水" ? "恢復血量" : inputField.text == "藍水" ? "恢復魔力" : "無此道具";
    }
}
