using UnityEngine;

public class cutscenetrigger_CFP : MonoBehaviour
{

    public animationcontroller_CFP controller;

    private bool AlreadyRanAnimation = false;

    private void OnTriggerEnter(Collider other)
    {
        
        if(AlreadyRanAnimation == false)
        {

            AlreadyRanAnimation = true;

            controller.RunCutscene();

        }

    }


}
