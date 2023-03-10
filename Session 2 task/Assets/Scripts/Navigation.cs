using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Navigation : MonoBehaviour
{
    [SerializeField] private Canvas Login_Screen = default;
    [SerializeField] private Canvas Registration_Screen = default;
    [SerializeField] private Canvas Point_Screen = default;
    [SerializeField] private Canvas Point_Screen_with_menuoptions = default;
    [SerializeField] private Canvas Table = default;
    [SerializeField] private Canvas Table_Exit = default;

    private void Start()
    {
        ShowScreen(Login_Screen);
    }

    public void ShowRegistrationScreen()
    {
        ShowScreen(Registration_Screen);
    }

    public void ShowLoginScreen()
    {
        ShowScreen(Login_Screen);
    }

    public void ShowPointScreen()
    {
        ShowScreen(Point_Screen);
    }

    public void ShowPointScreenWithMenuOptions()
    {
        ShowScreen(Point_Screen_with_menuoptions);
    }

    public void ShowTableScreen()
    {
        ShowScreen(Table);
    }

    public void ShowTableExitScreen()
    {
        ShowScreen(Table_Exit);
    }

    private void ShowScreen(Canvas screen)
    {
        Login_Screen.enabled = false;
        Registration_Screen.enabled = false;
        Point_Screen.enabled = false;
        Point_Screen_with_menuoptions.enabled = false;
        Table.enabled = false;
        Table_Exit.enabled = false;

        screen.enabled = true;
    }
}
