using System.Collections;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class animationcontroller_CFP : MonoBehaviour
{

    public GameObject Player;
    public GameObject Cutscene_GO;
    public GameObject BlackTransition_GO;

    public FirstPersonController movement_script;

    public void RunCutscene()
    {

        StartCoroutine(Cutscene_CO());

    }

    IEnumerator Cutscene_CO()
    {

        BlackTransition_GO.SetActive(true);
        movement_script.enabled = false;

        yield return new WaitForSeconds(1f);

        Cutscene_GO.SetActive(true);
        Player.SetActive(false);

        yield return new WaitForSeconds(3f);

        BlackTransition_GO.SetActive(false);

    }


}
