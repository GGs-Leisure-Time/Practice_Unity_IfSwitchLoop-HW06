using UnityEngine;
using UnityEngine.UI;

public class Practice3 : MonoBehaviour
{

    public GameObject Cube;

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < (i + 1); j++)
            {
                Vector3 pos = new Vector3(i*2 , j*2, 50);
                Instantiate(Cube, pos, Quaternion.identity);
            }    
        }
    }


}
