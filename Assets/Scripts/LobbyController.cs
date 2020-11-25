using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace LobbyController
{
    public class LobbyController : MonoBehaviour
    {
        [SerializeField]
        Button buttonPlay, buttonLevel1, buttonLevel2, buttonLevel3;

        [SerializeField]
        GameObject levelSelectionPopup;

        private void Start()
        {
            buttonPlay.onClick.AddListener(LoadPopup);
            buttonLevel1.onClick.AddListener(() => LoadLevel(1));
            buttonLevel2.onClick.AddListener(() => LoadLevel(2));
            buttonLevel3.onClick.AddListener(() => LoadLevel(3));
        }

        private void LoadPopup()
        {
            buttonPlay.gameObject.SetActive(false);
            levelSelectionPopup.SetActive(true);
        }

        public void LoadLevel(int sceneBuildIndex)
        {
            SceneManager.LoadScene(sceneBuildIndex);
        }
    }
}
