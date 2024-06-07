using UnityEngine;

namespace konsnos.SimpleTabSystem
{
    public class TabSystem : MonoBehaviour
    {
        public TabButton[] tabButtons;
        [SerializeField] private int defaultTab = 0;
        
        public void Start()
        {
            Enable();
            ShowTab(0);
        }

        private void Enable()
        {
            for (int i = 0; i < tabButtons.Length; i++)
            {
                int index = i;
                tabButtons[i].OnClick.AddListener(() => ShowTab(index));
            }
        }

        public void ShowTab(int index)
        {
            for (int i = 0; i < tabButtons.Length; i++)
            {
                tabButtons[i].SetSelected(i == index);
            }
        }
    }
}
