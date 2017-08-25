using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Exploder.Utils;
using UnityEngine.UI;

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

    public GameObject[] P1Points;
    public GameObject[] P2Points;

    private int P1Deaths;
    private int P2Deaths;

    public Text WinTExt;

    public int TotalLives;

    public bool GamesStart = false;

    void Start()
    {
        Instance = this;
        MyAnim = this.gameObject.GetComponent<Animator>();
    }

    void Update()
    {

    }


    public void P1Died()
    {
        P1Points[P1Deaths].GetComponent<Animator>().SetTrigger("Die");
        P1Deaths++;
        SoundManager.Instance.Death();
        if (P1Deaths >= TotalLives)
        {
            WinTExt.text = "P2 Wins";
            ExploderSingleton.ExploderInstance.ExplodeObject(P1.GetComponentInChildren<ShipBase>().gameObject);
            MyAnim.SetTrigger("Won");
            Destroy(P2.GetComponentInChildren<ShipBase>().gameObject);
			Cursor.visible = true;
            PlayerSelecting = 1;
            SoundManager.Instance.End();
        }
    }

    public void P2Died()
    {
        P2Points[P2Deaths].GetComponent<Animator>().SetTrigger("Die");
        P2Deaths++;
        SoundManager.Instance.Death();
        if (P2Deaths >= TotalLives)
        {
            WinTExt.text = "P1 Wins";
            ExploderSingleton.ExploderInstance.ExplodeObject(P2.GetComponentInChildren<ShipBase>().gameObject);
            MyAnim.SetTrigger("Won");
            Destroy(P1.GetComponentInChildren<ShipBase>().gameObject);
			Cursor.visible = true;
            PlayerSelecting = 1;
            SoundManager.Instance.End();
        }
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
        SoundManager.Instance.CLicked();
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
        SoundManager.Instance.CLicked();
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
        SoundManager.Instance.CLicked();
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
        SoundManager.Instance.CLicked();
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
        SoundManager.Instance.CLicked();
    }


    public void MenuToSelect()
    {
        MyAnim.SetTrigger("ClickedPlay");
        Debug.Log("Pressed play"); SoundManager.Instance.CLicked();
    }

    public void P1Select()
    {
        MyAnim.SetTrigger("P1Selected"); SoundManager.Instance.CLicked();
    }

    public void P2Select()
    {
        MyAnim.SetTrigger("P2Selected");
        Invoke("StartGame", 1); SoundManager.Instance.CLicked();
    }
        
    void StartGame()
    {
        GamesStart = true;
        Cursor.visible = false; SoundManager.Instance.CLicked();
    }

    public void Quit()
    {
        SoundManager.Instance.CLicked();
        Application.Quit();
    }
}
