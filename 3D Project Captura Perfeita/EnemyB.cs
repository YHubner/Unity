using UnityEngine;
using System.Collections;

public class EnemyB : MonoBehaviour {




    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update()
    {
}




	public void OnTriggerEnter (Collider hit) {
	
		if (hit.gameObject.tag == "SignalObject") {
			GameObject.FindWithTag("EnemyRegular").GetComponent<EnemyBehaviour>().movimento = true;
// fazer o inimigo ir até o objeto, olhar por 5 segundos e voltar á sua posição de origem
		}
	}
public void OnTriggerExit(Collider hit)
{

		if (hit.gameObject.tag == "SignalObject")
    {
			GameObject.FindWithTag("Enemy").GetComponent<EnemyBehaviour>().movimento = false;
    }
}
}
