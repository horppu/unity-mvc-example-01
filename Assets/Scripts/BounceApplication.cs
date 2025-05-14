using UnityEngine;

using Models;
using Views;
using Controllers;

// Base class for all elements in this application.
public class BounceElement : MonoBehaviour
{
    // Gives access to the application and all instances.
    protected static BounceApplication App => FindFirstObjectByType<BounceApplication>();
}

// 10 Bounces Entry Point.
public class BounceApplication : MonoBehaviour
{
    // Reference to the root instances of the MVC.
    public BounceModel model;
    public BounceView view;
    public BounceController controller;

    private void Start()
    {
        model = FindFirstObjectByType<BounceModel>();
        view = FindFirstObjectByType<BounceView>();
        controller = FindFirstObjectByType<BounceController>();
    }
}
