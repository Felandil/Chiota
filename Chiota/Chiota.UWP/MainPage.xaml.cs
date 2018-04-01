﻿namespace Chiota.UWP
{
  /// <summary>
  /// An empty page that can be used on its own or navigated to within a Frame.
  /// </summary>
  public sealed partial class MainPage
  {
    public MainPage()
    {
      this.InitializeComponent();
      LoadApplication(new Chiota.App());
      ZXing.Net.Mobile.Forms.WindowsUniversal.ZXingScannerViewRenderer.Init();
    }
  }
}
