using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace LoadLobby
{
    public class LoadLobby : MonoBehaviour
    {
        [SerializeField]
        Button goBackButton;

        void Start()
        {
            goBackButton.onClick.AddListener(LoadMasterScene);
        }

        private void LoadMasterScene()
        {
            SceneManager.LoadScene(0);
        }
    }
}
