using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class RMF_RadialMenuElement : MonoBehaviour
{

    [HideInInspector]
    public RectTransform rt;
    [HideInInspector]
    public RMF_RadialMenu parentRM;

    [Tooltip("Each radial element needs a button. This is generally a child one level below this primary radial element game object.")]
    public Button button;

    [Tooltip("This is the text label that will appear in the center of the radial menu when this option is moused over. Best to keep it short.")]
    public string label;

    [HideInInspector]
    public float angleMin, angleMax;

    [HideInInspector]
    public float angleOffset;

    [HideInInspector]
    public bool active = false;

    [HideInInspector]
    public int assignedIndex = 0;
    // Use this for initialization

    private CanvasGroup cg;

    void Awake()
    {

        rt = gameObject.GetComponent<RectTransform>();

        if (gameObject.GetComponent<CanvasGroup>() == null)
            cg = gameObject.AddComponent<CanvasGroup>();
        else
            cg = gameObject.GetComponent<CanvasGroup>();


        if (rt == null)
            Debug.LogError("Radial Menu: Rect Transform for radial element " + gameObject.name + " could not be found. Please ensure this is an object parented to a canvas.");

        if (button == null)
            Debug.LogError("Radial Menu: No button attached to " + gameObject.name + "!");

    }

    void Start()
    {

        rt.rotation = Quaternion.Euler(0, 0, -angleOffset); //Apply rotation determined by the parent radial menu.

        //If we're using lazy selection, we don't want our normal mouse-over effects interfering, so we turn raycasts off.
        if (parentRM.useLazySelection)
            cg.blocksRaycasts = false;
        else
        {

            //Otherwise, we have to do some magic with events to get the label stuff working on mouse-over.

            EventTrigger t;

            if (button.GetComponent<EventTrigger>() == null)
            {
                t = button.gameObject.AddComponent<EventTrigger>();
                t.triggers = new System.Collections.Generic.List<EventTrigger.Entry>();
            }
            else
                t = button.GetComponent<EventTrigger>();



            EventTrigger.Entry enter = new EventTrigger.Entry();
            enter.eventID = EventTriggerType.PointerEnter;
            enter.callback.AddListener((eventData) => { setParentMenuLable(label); });


            EventTrigger.Entry exit = new EventTrigger.Entry();
            exit.eventID = EventTriggerType.PointerExit;
            exit.callback.AddListener((eventData) => { setParentMenuLable(""); });

            t.triggers.Add(enter);
            t.triggers.Add(exit);



        }

    }

    //Used by the parent radial menu to set up all the approprate angles. Affects master Z rotation and the active angles for lazy selection.
    public void setAllAngles(float offset, float baseOffset)
    {

        angleOffset = offset;
        angleMin = offset - (baseOffset / 2f);
        angleMax = offset + (baseOffset / 2f);

    }

    //Highlights this button. Unity's default button wasn't really meant to be controlled through code so event handlers are necessary here.
    //I would highly recommend not messing with this stuff unless you know what you're doing, if one event handler is wrong then the whole thing can break.
    public void highlightThisElement(PointerEventData p)
    {

        ExecuteEvents.Execute(button.gameObject, p, ExecuteEvents.selectHandler);
        active = true;
        setParentMenuLable(label);

    }

    //Sets the label of the parent menu. Is set to public so you can call this elsewhere if you need to show a special label for something.
    public void setParentMenuLable(string l)
    {

        if (parentRM.textLabel != null)
            parentRM.textLabel.text = l;


    }


    //Unhighlights the button, and if lazy selection is off, will reset the menu's label.
    public void unHighlightThisElement(PointerEventData p)
    {

        ExecuteEvents.Execute(button.gameObject, p, ExecuteEvents.deselectHandler);
        active = false;

        if (!parentRM.useLazySelection)
            setParentMenuLable(" ");


    }
}