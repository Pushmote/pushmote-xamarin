# pushmote-xamarin

Pushmote iOS &amp; Android Bindings for Xamarin 

## How to add Pushmote to Xamarin iOS Project

Click [here](https://github.com/Pushmote/pushmote-xamarin/archive/master.zip) to download repository as a zip file.

Add PushmoteSDK-iOSBinding project to your solution.

Click Edit References from Project menu.

Add PushmoteSDK-iOSBinding as a reference to your project.

Add Pushmote.StartWithApplicationId and Pushmote.HandleNotification calls in AppDelegate.cs

        public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
		{
			Pushmote.StartWithApplicationId ("YOUR_APP_KEY");

			// Override point for customization after application launch.
			// If not required for your application you can safely delete this method

			return true;
		}

		public override void ReceivedLocalNotification (UIApplication application, UILocalNotification notification)
		{
			Pushmote.HandleNotification (notification);
		}
		
Add NSLocationAlwaysUsageDescription to your .plist file.

    <key>NSLocationAlwaysUsageDescription</key>
    <string>This is required for iBeacon experience.</string>


## How to add Pushmote to Xamarin Android Project

Click [here](https://github.com/Pushmote/pushmote-xamarin/archive/master.zip) to download repository as a zip file.

Add PushmoteSDK-AndroidBinding project to your solution.

Click Edit References from Project menu.

Add PushmoteSDK-AndroidBinding as a reference to your project.

Add Pushmote.Start call to MainActivity.cs

		protected override void OnCreate (Bundle savedInstanceState)
		{
         ..
			Xamarin.Insights.Initialize (XamarinInsights.ApiKey, this);
			..
			Pushmote.Start(Pushmote.HWProvider.Estimote, this, "YOUR_APP_KEY");
  	}
  	
  	protected override void OnStart (Bundle savedInstanceState)
		{
			base.OnStart (savedInstanceState);
			Pushmote.BringToForeground ();
		}

		protected override void OnStop (Bundle savedInstanceState)
		{
			base.OnStop (savedInstanceState);
			Pushmote.SendToBackground ();
		}

Add permissions/uses-feature and service definition in AndroidManifest.xml

  	<application android:allowBackup="true" android:icon="@mipmap/icon" android:label="@string/app_name">
  	        <service
              android:name="com.estimote.sdk.service.BeaconService"
              android:exported="false" />
  
  	</application>

	  <uses-feature
        android:name="android.hardware.bluetooth_le"
        android:required="false" />
      <!-- Needed for Bluetooth low energy scanning. -->
      <uses-permission android:name="android.permission.BLUETOOTH" />
      <uses-permission android:name="android.permission.BLUETOOTH_ADMIN" />
      <!-- Needed for Estimote Cloud. -->
      <uses-permission android:name="android.permission.INTERNET" />
      <uses-permission android:name="android.permission.ACCESS_NETWORK_STATE" />
