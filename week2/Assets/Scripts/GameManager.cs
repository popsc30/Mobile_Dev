using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject selectZoomie;
    public List<GameObject> zbs;
    private int live, couter, points;
    private int i;
    public float force;
    public Text text, score;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        points = 0;
        couter = 0;
        live = 4;
        force = 10f;
        text.text = "lives: " + live;
        score.text = "Scoring: " + points;
        resize();
    }

    public void ReduceLive()
    {
        live--;
        if(live < 1)
        {
            live = 0;
        }
        text.text = "lives: " + live;
    }

    // Update is called once per frame
    void Update()
    {
        couter++;
        points++;
        if (couter % 30 == 0)
        {
            couter = 0;
        }
        score.text = "Scoring: " + points;

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
