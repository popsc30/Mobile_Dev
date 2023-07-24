using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiveManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager gameManager;
    public List<GameObject> zms;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        gameManager.ReduceLive();
        var index = gameManager.zbs.IndexOf(other.gameObject);
        other.gameObject.transform.position = zms[index].transform.position;
       /* if (other.gameObject.tag == "YellowTag")
        {
            other.gameObject.transform.position = zms[0].transform.position;
        }
        else if (other.gameObject.tag == "BlueTag")
        {
            other.gameObject.transform.position = zms[1].transform.position;
        }
        else if (other.gameObject.tag == "GreenTag")
        {
            other.gameObject.transform.position = zms[2].transform.position;
        }
        else if (other.gameObject.tag == "RedTag")
        {
            other.gameObject.transform.position = zms[3].transform.position;
        }*/
    }
}
