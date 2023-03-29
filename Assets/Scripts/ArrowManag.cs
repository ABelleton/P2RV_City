using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowManag : MonoBehaviour
{
    //public CanvasRenderer cr1;
    /*public Image r;
    public Image l;
    public Image s;*/
    public GameObject[] checkpoints;
    public GameObject Player;
    public GameObject compass;

    private int n;
    private int index;

    private Vector3 position;
    private Vector3 orientation;
    private Vector3 up;
    private Vector3 objective;

/*    public GameObject r;
    public GameObject l;
    public GameObject s;*/

    private float angle;
    private float previousAngle;
    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        n = checkpoints.Length;
        index = 0;

        position = Player.transform.position;
        orientation = Player.transform.forward;
        up = Player.transform.up;
        objective = checkpoints[0].transform.position;

        angle = 0;
        previousAngle = 0;
        distance = 0;

        /*GameObject.Find("right").SetActive(false); 
        GameObject.Find("left").SetActive(false); 
        GameObject.Find("straight").SetActive(false);*/
        /*r = GetComponent<Image>();
        l = GetComponent<Image>();
        s = GetComponent<Image>();*/
        /*r = GetComponent<Canvas>();
        l = GetComponent<Canvas>();
        s = GetComponent<Canvas>();*/

/*        r.GetComponent<CanvasRenderer>().SetAlpha(0f);
        l.GetComponent<CanvasRenderer>().SetAlpha(0f);
        s.GetComponent<CanvasRenderer>().SetAlpha(0f);*/

    }

    // Update is called once per frame
    void Update()
    {
        position = Player.transform.position;
        orientation = Player.transform.forward;
        up = Player.transform.up;
        objective = checkpoints[index].transform.position;

        previousAngle = angle;
        angle = Vector3.SignedAngle(orientation, objective - position, up);

        distance = (objective - position).magnitude;

        //Debug.Log(angle);


        //méthode bourrin : apparait/disparait juste --> marche pas
        /*if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //cr1
            GameObject.Find("right").SetActive(true);
            GameObject.Find("left").SetActive(false);
            GameObject.Find("straight").SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GameObject.Find("right").SetActive(false);
            GameObject.Find("left").SetActive(true);
            GameObject.Find("straight").SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)&& GameObject.Find("right").activeInHierarchy==false&& GameObject.Find("left").activeInHierarchy==false)
        {
            GameObject.Find("straight").SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && GameObject.Find("right").activeInHierarchy == true)
        {
            GameObject.Find("right").SetActive(false);
            GameObject.Find("straight").SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && GameObject.Find("left").activeInHierarchy == true)
        {
            GameObject.Find("left").SetActive(false);
            GameObject.Find("straight").SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            GameObject.Find("right").SetActive(false);
            GameObject.Find("left").SetActive(false);
            GameObject.Find("straight").SetActive(false);
        }*/
        /*
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            s.color = new Color(s.color.r, s.color.g, s.color.b, 1f);
            r.color = new Color(r.color.r, r.color.g, r.color.b, 0f);
            l.color = new Color(l.color.r, l.color.g, l.color.b, 0f);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            s.color = new Color(s.color.r, s.color.g, s.color.b, 0f);
            r.color = new Color(r.color.r, r.color.g, r.color.b, 1f);
            l.color = new Color(l.color.r, l.color.g, l.color.b, 0f);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            s.color = new Color(s.color.r, s.color.g, s.color.b, 0f);
            r.color = new Color(r.color.r, r.color.g, r.color.b, 0f);
            l.color = new Color(l.color.r, l.color.g, l.color.b, 1f);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            s.color = new Color(s.color.r, s.color.g, s.color.b, 0f);
            r.color = new Color(r.color.r, r.color.g, r.color.b, 0f);
            l.color = new Color(l.color.r, l.color.g, l.color.b, 0f);
        }*/

        compass.GetComponent<CanvasRenderer>().transform.RotateAround(compass.transform.position, compass.transform.forward, previousAngle - angle);

        if (distance < 1) {
            index++;
            if (index >= n)
            {
                index = 0;
            }
        }



/*        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            r.GetComponent<CanvasRenderer>().SetAlpha(0f);
            l.GetComponent<CanvasRenderer>().SetAlpha(0f); 
            s.GetComponent<CanvasRenderer>().SetAlpha(1f);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            r.GetComponent<CanvasRenderer>().SetAlpha(1f);
            l.GetComponent<CanvasRenderer>().SetAlpha(0f);
            s.GetComponent<CanvasRenderer>().SetAlpha(0f);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            r.GetComponent<CanvasRenderer>().SetAlpha(0f);
            l.GetComponent<CanvasRenderer>().SetAlpha(1f);
            s.GetComponent<CanvasRenderer>().SetAlpha(0f);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            r.GetComponent<CanvasRenderer>().SetAlpha(0f);
            l.GetComponent<CanvasRenderer>().SetAlpha(0f);
            s.GetComponent<CanvasRenderer>().SetAlpha(0f);
        }*/
    }
}
