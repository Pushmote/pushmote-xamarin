using ObjCRuntime;

[assembly: LinkWith ("PushmoteSDK.a", SmartLink = true, ForceLoad = true, Frameworks="CoreBluetooth CoreLocation Accelerate MediaPlayer")]
