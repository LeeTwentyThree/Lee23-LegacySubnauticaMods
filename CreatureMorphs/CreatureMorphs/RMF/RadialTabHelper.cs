using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections.Generic;

internal static class RadialTabHelper
{
    public class Selector
    {
        public string name;
        public string buttonName;
        public Button.ButtonClickedEvent onPress;

        public Selector(string name, Button.ButtonClickedEvent onPress)
        {
            this.name = name;
            buttonName = name;
            this.onPress = onPress;
        }

        public Selector(string name, string buttonName, Button.ButtonClickedEvent onPress)
        {
            this.name = name;
            this.buttonName = buttonName;
            this.onPress = onPress;
        }
    }

    public static void SetupRadialTab(GameObject canvas, params Selector[] selectors)
    {
        canvas.SetActive(false);
        var menu = canvas.transform.GetChild(0).gameObject.AddComponent<RMF_RadialMenu>();
        menu.selectionFollowerContainer = canvas.transform.GetChild(0).GetChild(1).GetComponent<RectTransform>();
        menu.textLabel = canvas.transform.GetChild(0).Find("Label").GetComponent<Text>();
        var buttons = canvas.GetComponentsInChildren<Button>();
        var elements = new RMF_RadialMenuElement[buttons.Length];
        for (int i = 0; i < buttons.Length; i++)
        {
            var element = buttons[i].transform.parent.gameObject.AddComponent<RMF_RadialMenuElement>();
            element.button = buttons[i];
            element.button.onClick = selectors[i].onPress;
            element.label = selectors[i].name;
            element.GetComponentInChildren<Text>().name = selectors[i].buttonName;
            elements[i] = element;
        }
        menu.elements = new List<RMF_RadialMenuElement>(elements);
        canvas.SetActive(true);
    }
}