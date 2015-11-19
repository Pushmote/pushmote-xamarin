using Foundation;
using UIKit;

namespace PushmoteSDK
{
	// @interface Pushmote : NSObject
	[BaseType (typeof(NSObject))]
	interface Pushmote
	{
		// +(void)startWithApplicationId:(NSString *)appId;
		[Static]
		[Export ("startWithApplicationId:")]
		void StartWithApplicationId (string appId);

		// +(void)handleNotification:(UILocalNotification *)notification;
		[Static]
		[Export ("handleNotification:")]
		void HandleNotification (UILocalNotification notification);

		// +(void)simulateAction;
		[Static]
		[Export ("simulateAction")]
		void SimulateAction ();
	}
}
