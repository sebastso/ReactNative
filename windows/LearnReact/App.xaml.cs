using ReactNative;
using System;
using Windows.System;

namespace LearnReact
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : ReactApplication
    {
        private readonly ReactNativeHost _host = new MainReactNativeHost();

        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
            openURL("http://www.hp.com/privacy");
        }
        public async void openURL(string url)
        {
            if (url == null)
            {
                //promise.Reject(new ArgumentNullException(nameof(url)));
                return;
            }

            if (!Uri.TryCreate(url, UriKind.Absolute, out var uri))
            {
                //promise.Reject(new ArgumentException(Invariant($"URL argument '{uri}' is not valid.")));
                return;
            }

            try
            {
                await Launcher.LaunchUriAsync(uri).AsTask().ConfigureAwait(false);
                //promise.Resolve(true);
            }
            catch (Exception ex)
            {
                LogThis(ex.Message + ex.StackTrace);
                //promise.Reject(new InvalidOperationException(
                 //   Invariant($"Could not open URL '{url}'."), ex));
            }
        }
        private async void LogThis(string message)
        {
            Windows.Storage.StorageFolder storageFolder =
    Windows.Storage.ApplicationData.Current.LocalFolder;
            Windows.Storage.StorageFile sampleFile =
                await storageFolder.CreateFileAsync("AppLogLogSony.txt",
                    Windows.Storage.CreationCollisionOption.ReplaceExisting);
            await Windows.Storage.FileIO.WriteTextAsync(sampleFile, message);
        }
        /// <summary>
        /// The React Native host.
        /// </summary>
        public override ReactNativeHost Host => _host;
    }
}
