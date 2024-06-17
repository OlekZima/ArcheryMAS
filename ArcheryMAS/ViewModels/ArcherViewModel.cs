using ArcheryMAS.Enitites;

namespace ArcheryMAS.ViewModels;

/// <summary>
/// Class that represents the view model for the ArcherPerson entity.
/// Contains an Archer and a Person object, and bool value if the ArcherPerson is selected in the GUI.
/// </summary>
public class ArcherPersonViewModel
{
    /// <summary>
    /// Archer object.
    /// </summary>
    public Archer Archer { get; set; }

    /// <summary>
    /// Person object.
    /// </summary>
    public Person Person { get; set; }

    /// <summary>
    /// Bool value if the ArcherPerson is selected in the GUI.
    /// </summary>
    private bool isSelected;

    /// <summary>
    /// Property for the isSelected field.
    /// </summary>
    public bool IsSelected
    {
        get => isSelected;
        set
        {
            if (isSelected != value)
            {
                isSelected = value;
                OnSelectionChanged?.Invoke();
            }
        }
    }

    /// <summary>
    /// Action that is invoked when the selection is changed.
    /// </summary>
    public Action OnSelectionChanged { get; set; }
}