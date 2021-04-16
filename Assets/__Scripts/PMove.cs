using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PMove : MonoBehaviour
{
    // int variable to keep track of score
    int counter;
    // Text element to show score to user
    public Text score;
    // Update is called once per frame
    public Rigidbody player;

    void Start() {
        player = GetComponent<Rigidbody>();
        // set counter to 0
        counter = 0;
    }

    void Update()
    {
        // show user current score
        score.text = "Score: " + counter.ToString();
        // speed is zero if no arrow input
        // set up movement
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // go right with right arrow
            player.AddForce(50f, 0, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            // go left with left arrow
            player.AddForce(-50f, 0, 0);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            // go forwards with up arrow
            player.AddForce(0, 0, 50f);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            // go back with down arrow
            player.AddForce(0, 0, -50f);
        }
        
    }
    // collision with pickup detection
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickupCube"))
        {
            // make pickup cube disappear on collision with player
            other.gameObject.SetActive(false);
            // increase score by 1
            counter++;
        }
        else if (other.gameObject.CompareTag("PickupCapsule"))
        {
            // make pickup capsule disappear on collision with player
            other.gameObject.SetActive(false);
            // increase score by 2
            counter += 2;
        }
        else if (other.gameObject.CompareTag("PickupCylinder"))
        {
            // make pickup cylinder disappear on collision with player
            other.gameObject.SetActive(false);
            // increase score by 3
            counter += 3;
        }
        

        // check if game is over
        if (counter >= 18)
        {
            StartCoroutine(Restart());
        }

    }

    IEnumerator Restart()
    {
        // freeze player
        player.constraints = RigidbodyConstraints.FreezePosition;
        // pause
        yield return new WaitForSeconds(3f);
        // restart game
        SceneManager.LoadScene("Minigame");
    }

}
