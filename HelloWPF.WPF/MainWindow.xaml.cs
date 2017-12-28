using Xamarin.Forms.Platform.WPF;

namespace HelloWPF.WPF
{
	/// <summary>
	/// Logique d'interaction pour MainWindow.xaml
	/// </summary>
	public partial class MainWindow : FormsApplicationPage
	{
		public MainWindow()
		{
			InitializeComponent();
			Xamarin.Forms.Forms.Init();
			LoadApplication(new HelloWPF.App());
		}
	}
}
