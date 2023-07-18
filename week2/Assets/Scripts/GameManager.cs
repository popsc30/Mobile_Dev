using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject selectZoomie;
    public List<GameObject> zbs;
    private int i;
    public float force;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        force = 10f;
        resize();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("right"))
        {
            reset();
            if (i == 4)
            {
                i = 0;
            }
            i++;
            selectZoomie = zbs[i];
            resize();
        }else if (Input.GetKeyDown("left"))
        {
            reset();
            if (i == -1)
            {
                i = 3;
            }
            i--;
            selectZoomie = zbs[i];
            resize();
        }
        if (Input.GetKeyDown("up"))
        {
            Rigidbody rb = selectZoomie.GetComponent<Rigidbody>();
            rb.AddForce(new Vector3(0f, 0f, force), ForceMode.Impulse);
        }
    }

    void resize()
    {
        selectZoomie.transform.localScale = new Vector3(1.53f, 1.53f, 1.53f);
    }

    void reset()
    {
        selectZoomie.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }
}
