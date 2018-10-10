using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeppets : MonoBehaviour
{
    public float rotationspeed = 360;
    public Color color;
    public SpriteRenderer rend;
    public float movespeed;
    public Color ship;
    public SpriteRenderer shipcolor;







    // Use this for initialization
    void Start()
    {   //Det gör att du början spelet på ett ranom ställe  
        transform.position=new Vector3(Random.Range(26f,-26.5f), Random.Range(15.8f,-15.8f));
        //Den här gör så att din movespeed blir randomserad
        movespeed = Random.Range(0.09f, 0.4f);

    }

    // Update is called once per frame
    void Update()
        
    {
        
        //om D trycks ner åker du höger och byter färg till blå
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -rotationspeed * Time.deltaTime);
            rend.color = new Color(0, 0, 1);

        }
        transform.Translate(0, movespeed, 0);
        //Om A trycks ner åker du vänster och byter färg till grön.
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, rotationspeed / 3 * Time.deltaTime);
            rend.color = new Color(0, 1, 0);
        }//om S trycks ner åker åker du dubbeltb så snabbt.
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -movespeed / 2, 0);

        }//när du trycker på space får skeppet en random färg
        if (Input.GetKey(KeyCode.Space))
        {
            ship = new Color(Random.value, Random.value, Random.value, 1f);
            shipcolor.color = ship;


        }//när skeppet åker ut ur skärmen warpa den tillbaka på andra sidan
        if (transform.position.y > 15.8f)
        {
            transform.position = new Vector3(transform.position.x, -15.8f);

        }
        if (transform.position.x > 26.5)
        {
            transform.position = new Vector3(-26.5f,transform.position.y);
        }
        if (transform.position.y < -15.8f)
        {
            transform.position = new Vector3(transform.position.x, 15.8f);

        }
        if (transform.position.x < -26.5)
        {
            transform.position = new Vector3(26.5f, transform.position.y);
        }

    }
}
