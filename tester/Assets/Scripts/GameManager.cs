using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager Instance;

    private Animator MyAnim;

    private float PlayerSelecting = 1;

    public GameObject P1;
    public GameObject P2;


    public GameObject Fire;
    public GameObject Earth;
    public GameObject Water;
    public GameObject Light;
    public GameObject Life;

    public float P1Wins;
    public float P2Wins;

    public bool GamesStart = false;

    void Start ()
    {
        Instance = this;
        MyAnim = this.gameObject.GetComponent<Animator>();
	}
	
	void Update ()
    {
		
	}




    // button commands

    public void FireShipSelected()
    {
        if (PlayerSelecting == 1)
        {
            Instantiate( Fire,  P1.transform.position,  P1.transform.rotation, P1.transform);
            P1Select();
            PlayerSelecting++;
        }
        else
        {
            Instantiate(Fire, P2.transform.position, P2.transform.rotation, P2.transform);
            P2Select();
        }
    }

    public void EarthShipSelected()
    {
        if (PlayerSelecting == 1)
        {
            Instantiate(Earth, P1.transform.position, P1.transform.rotation, P1.transform);
            P1Select();
            PlayerSelecting++;
        }
        else
        {
            Instantiate(Earth, P2.transform.position, P2.transform.rotation, P2.transform);
            P2Select();
        }
    }
    public void WaterShipSelected()
    {
        if (PlayerSelecting == 1)
        {
            Instantiate(Water, P1.transform.position, P1.transform.rotation, P1.transform);
            P1Select();
            PlayerSelecting++;
        }
        else
        {
            Instantiate(Water, P2.transform.position, P2.transform.rotation, P2.transform);
            P2Select();
        }
    }
    public void LightShipSelected()
    {
        if (PlayerSelecting == 1)
        {
            Instantiate(Light, P1.transform.position, P1.transform.rotation, P1.transform);
            P1Select();
            PlayerSelecting++;
        }
        else
        {
            Instantiate(Light, P2.transform.position, P2.transform.rotation, P2.transform);
            P2Select();
        }
    }
    public void LifeShipSelected()
    {
        if (PlayerSelecting == 1)
        {
            Instantiate(Life, P1.transform.position, P1.transform.rotation, P1.transform);
            P1Select();
            PlayerSelecting++;
        }
        else
        {
            Instantiate(Life, P2.transform.position, P2.transform.rotation, P2.transform);
            P2Select();
        }
    }


    public void MenuToSelect()
    {
        MyAnim.SetTrigger("ClickedPlay");
        Debug.Log("Pressed play");
    }

    public void P1Select()
    {
        MyAnim.SetTrigger("P1Selected");
    }

    public void P2Select()
    {
        MyAnim.SetTrigger("P2Selected");
        Invoke("StartGame", 1);
    }
        
    void StartGame()
    {
        GamesStart = true;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
