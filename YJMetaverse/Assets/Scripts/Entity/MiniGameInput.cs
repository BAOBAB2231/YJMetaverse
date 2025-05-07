using UnityEngine;

public class MiniGameInput : MonoBehaviour
{
    public string miniGameSceneName = "FlappyBirdScene";
    public GameObject interactionPopup;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (CanEnterMiniGame()) // ������ Ȯ�� (��: UI�� ���� ���� ��)
            {
                EnterMiniGame();
            }
        }
    }

    private bool CanEnterMiniGame()
    {
        // ����: ��ȣ�ۿ� ���� ������ �� �ְ�, UI�� ���� ���� �� ��
        return interactionPopup.activeSelf;
    }

    private void EnterMiniGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(miniGameSceneName);
    }
}

