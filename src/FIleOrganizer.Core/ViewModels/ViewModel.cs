using System.Xml.Serialization;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace FIleOrganizer.Core.ViewModels;

public class ViewModel : ObservableObject
{
    /// <summary>
    /// Initializes the view model. Called once per view model instance after the InitializeComponent method.
    /// </summary>
    public virtual void Initialize() { }
    
    [XmlIgnore]
    public bool IsViewLoaded { get; private set; }
    
    /// <summary>Initializes the view model (should be called in the view's Loaded event). </summary>
    public void CallOnLoaded()
    {
        if (IsViewLoaded) return;
        OnLoaded();
        IsViewLoaded = true;
    }

    /// <summary>Cleans up the view model (should be called in the view's Unloaded event). </summary>
    public void CallOnUnloaded()
    {
        if (!IsViewLoaded) return;
        OnUnloaded();
        IsViewLoaded = false;
    }

    /// <summary>Implementation of the initialization method. 
    /// If the view model is already initialized the method is not called again by the Initialize method. </summary>
    protected virtual void OnLoaded() { }

    /// <summary>Implementation of the clean up method. 
    /// If the view model is already cleaned up the method is not called again by the Cleanup method. </summary>
    protected virtual void OnUnloaded() { }
}