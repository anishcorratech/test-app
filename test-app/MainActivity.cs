using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace testapp
{
	[Activity (Label = "test-app", MainLauncher = true)]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			//Create the user interface in code
			var layout = new LinearLayout (this);
			layout.Orientation = Orientation.Vertical;

			var aLabel = new TextView (this);
			aLabel.Text = "Hello, Xamarin.Android";

			var aButton = new Button (this);      
			aButton.Text = "Say Hello";
			aButton.Click += (sender, e) => {
				aLabel.Text = "Hello from the button";
			};  
			layout.AddView (aLabel);
			layout.AddView (aButton);           
			SetContentView (layout);
		}
	}
}


