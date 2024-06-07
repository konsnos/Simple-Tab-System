using UnityEngine;
using UnityEngine.UI;

namespace konsnos.SimpleTabSystem
{
    public class TabButton : MonoBehaviour
    {
        private Image _image;
        private Button _button;

        [SerializeField] private Color selectedColor;
        [SerializeField] private Color unselectedColor;
        
        [field:SerializeField] public GameObject Content { get; private set; }

        private bool _isSelected;
        private bool _initialised;

        public Button.ButtonClickedEvent OnClick
        {
            get
            {
                Initialise();
                return _button.onClick;
            }
        }

        private void Initialise()
        {
            if (_initialised) return;

            _image = GetComponent<Image>();
            _button = GetComponent<Button>();
            _initialised = true;
        }

        public void SetSelected(bool selected)
        {
            Initialise();

            _isSelected = selected;
            _image.color = _isSelected ? selectedColor : unselectedColor;
            Content.SetActive(_isSelected);
        }
    }
}