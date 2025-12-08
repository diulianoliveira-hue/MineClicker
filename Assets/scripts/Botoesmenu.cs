using UnityEngine;
using UnityEngine.SceneManagement;


public class Botoesmenu : MonoBehaviour {

  
	public string nomeDoFilho = "Configurações";


  	void Start()
    {

        FecharConfig();
    }


	public void mostrarConfig()
	{
 	      Transform filho = transform.Find(nomeDoFilho);
		filho.gameObject.SetActive(true);
	}

	
	public void FecharConfig()
 
     {
        Transform filho = transform.Find(nomeDoFilho);
		filho.gameObject.SetActive(false);
     }

	public void IniciarJogo()
	{

		SceneManager.LoadScene("GameScene");
	}

	public void VoltarAoMenu()
{
	SceneManager.LoadScene("MENU");
}
 
	public void SairDoJogo()
	{
		Application.Quit();
	}

	
	public void Configuracoes()
 	{
		SceneManager.LoadScene("CONFG");
	}


}
