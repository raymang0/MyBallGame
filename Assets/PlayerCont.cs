using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerCont : MonoBehaviour {

    private Rigidbody rb;
    private float count;
    private int ballCount;
    int numCount;

    public float speed;
    public float gameTime;
    public float ballSize;
    public Text loseText;
    public Text timeText;
    public Text levelText;
    
  
    void Start(){
        rb = GetComponent<Rigidbody>();
        gameTime = Time.time + 2.0f;
        loseText.text = "";
        levelText.text = "Level: 1";
        count = 0;
        ballCount = 1;
        ballSize = 1.5f;
        setScoreText();
        

    }

    void Update()
    {
        count = Time.time;
        float ballTotal = Random.Range(1.0f, ballSize); //(1.0f, 5.0f)
        if (Time.time > gameTime)
        {
            for (int i = 0; i < ballCount; i++)
            {
                GameObject spheres = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                spheres.AddComponent<Rigidbody>();
                //    spheres.transform.Rotate(0,0,90);
                spheres.transform.position = new Vector3(Random.Range(-10.0f, 10.0f), 30, -40);
                spheres.transform.localScale += new Vector3(ballTotal, ballTotal, ballTotal);
                spheres.GetComponent<Renderer>().material.color = Color.green;
                gameTime += 1.0f;
                Destroy(spheres, 9);
                //}
                if (numCount > 20 && numCount < 40)
                {
                    levelText.text = "Level: 2";
                    spheres.GetComponent<Renderer>().material.color = Color.red;
                    ballSize = 5.0f;
                }
                else if (numCount >= 40) 
                {
                    levelText.text = "Level: 3";
                    spheres.GetComponent<Renderer>().material.color = Color.cyan;
                    ballCount = 2;
                }
            }
        }
        setScoreText();
    }
    

	void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown("space"))
        {
            transform.Translate(Vector3.up * 20 * Time.deltaTime, Space.World);
        }

        Vector3 movement = new Vector3(-moveHorizontal, 0.0f);

        rb.AddForce(movement * speed);

      
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Sphere")
        {
            gameObject.SetActive(false);
            loseText.text = "Your Score: " + numCount.ToString();
        }
    }

    void setScoreText() {
        numCount = (int)count;
        timeText.text = "Score: " + numCount.ToString();
    }
}
