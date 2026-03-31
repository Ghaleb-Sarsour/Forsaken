using UnityEngine;

public class BossDialogue : MonoBehaviour
{

		public BossStateMachine stateMachine;
		public GameObject text;

    // Update is called once per frame
    void Update() {
				if (stateMachine.IsStunned){
						text.SetActive(true);
				}
    }
}
