using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Paddle : MonoBehaviour {

    public int totalscore=0;
    public Text hud_score;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKey)
        {
            transform.position += new Vector3(1, 0, 0) * Input.GetAxis("Horizontal");
        }
        if (Input.GetKeyDown(KeyCode.Space)){
            FindObjectOfType<Ball>().UnStick();
        }
        UpdateUI();
    }
    public void UpdateUI()
    {
        hud_score.text = totalscore.ToString();
    }
    public void Score()
    {
        totalscore += 50;
    }
   
   
}
