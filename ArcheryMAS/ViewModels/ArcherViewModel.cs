using ArcheryMAS.Enitites;

namespace ArcheryMAS.ViewModels;

public class ArcherPersonViewModel
{
    public Archer Archer { get; set; }
    public Person Person { get; set; }
    private bool isSelected;

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

    public Action OnSelectionChanged { get; set; }
}