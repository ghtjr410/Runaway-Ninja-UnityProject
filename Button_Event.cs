using UnityEngine;


public class Button_Event : MonoBehaviour
{ 
    char A;


    
    bool m_IsCollision = false;
    GameObject collisionNote = null;

    void Awake()
    {
       
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        collisionNote = other.gameObject;

        
    }

    void OnTriggerExit2D(Collider2D other)
    {
        collisionNote = null;
        
    }



    void Update()
    {
        if( m_IsCollision && null != collisionNote)
        {
            GameManager.instance.IsCollision(collisionNote);
        }
    }
    public void OnDown()
    {
        m_IsCollision = true;

       


    }

    public void OnUp()
    {
       
        m_IsCollision = false;
    }
}