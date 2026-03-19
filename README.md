# DotnetCommunityToolkitReproducingPopupPageLeavingBehavior

To reproduce: Build and run the project in debug mode and click the button. The popup should appear. However, OnDisappearing will also fire, indicating that the main page has been navigated away from, which should not occur.
