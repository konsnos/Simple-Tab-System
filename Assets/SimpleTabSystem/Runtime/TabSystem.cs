using UnityEngine;
using UnityEngine.Events;

namespace konsnos.SimpleTabSystem
{
    public class TabSystem : MonoBehaviour
    {
        public TabButton[] tabButtons;
        [field:SerializeField] public int CurrentTab { private set; get; } = 0;
        
        /// <summary>
        /// Event triggered when the active tab changes. Passes the index of the newly selected tab as a parameter.
        /// </summary>
        public UnityEvent<int> onTabChanged = new UnityEvent<int>();
        
        public void Start()
        {
            Enable();
            ShowTab(CurrentTab);
        }

        private void Enable()
        {
            for (var i = 0; i < tabButtons.Length; i++)
            {
                var index = i;
                tabButtons[i].OnClick.AddListener(() => ShowTab(index));
            }
        }

        public void ShowTab(int index)
        {
            for (var i = 0; i < tabButtons.Length; i++)
            {
                tabButtons[i].SetSelected(i == index);
            }

            CurrentTab = index;
            onTabChanged?.Invoke(CurrentTab);
        }
    }
}
