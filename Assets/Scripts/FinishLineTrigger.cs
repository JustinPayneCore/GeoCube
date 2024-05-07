using UnityEngine;

public class FinishLineTrigger : MonoBehaviour
{

    // If the Player enters the finish line trigger, complete the level.
    public void OnTriggerEnter(Collider other)
    {
        // WIP make it pull up a level complete stage & add buttons to go to next stage.
        FindObjectOfType<GameManager>().CompleteLevel();
    }
}
