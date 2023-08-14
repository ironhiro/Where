namespace WhereIsIt;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
	}


    protected override void OnNavigated(ShellNavigatedEventArgs args)
    {
        base.OnNavigated(args);

        var shellItem = Shell.Current?.CurrentItem;
        string title = shellItem?.Title;
        int iterationCount = 0;

        while (shellItem != null
        && title == null)
        {
            title = shellItem.Title;
            shellItem = shellItem.CurrentItem;

            iterationCount++;
        }

        myLabel.Text = title;
    }
}

