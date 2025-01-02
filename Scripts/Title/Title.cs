using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour {

	public Animation ani;

	

	public void Rot()
	{
        ani.Play("Rot");

    }

	public void Open()
	{
        ani.Play("Open");
    }

    public void StartGame()
    {
        Application.LoadLevel(0);
    }

    public void OnClick()
    {
        ani.Play("Close");
    }
}
