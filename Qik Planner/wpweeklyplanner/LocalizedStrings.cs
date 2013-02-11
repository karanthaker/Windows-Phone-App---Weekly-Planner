/*
Karan Thaker
karan.thaker@hotmail.com
 */

namespace wpweeklyplanner
{
    /// <summary>
    /// Helper class for accessing application resources from XAML, especially for localization
    /// </summary>
    public class LocalizedStrings
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public LocalizedStrings()
        {
        }

        /// <summary>
        /// Class variable for instance of AppResources
        /// </summary>
        private static wpweeklyplanner.AppResources localizedResources = new wpweeklyplanner.AppResources();

        /// <summary>
        /// Property for accessing AppResources
        /// </summary>
        public wpweeklyplanner.AppResources LocalizedResources { get { return localizedResources; } }

    }
}
