using UnityEngine;
using UnityEngine.Events;

namespace konsnos.SimpleTabSystem
{
    public class TabSystem : MonoBehaviour
    {
        public TabButton[] tabButtons;
        [field:SerializeField] public int CurrentTab { private set; get; } = 0;
        
        public UnityEvent<TabSystem> onTabChanged = new UnityEvent<TabSystem>();
        
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

            CurrentTab = index;
            onTabChanged?.Invoke(this);
        }
    }
}
