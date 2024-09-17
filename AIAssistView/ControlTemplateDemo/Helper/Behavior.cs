
namespace ControlTemplate
{
    class SampleViewBehavior : Behavior<ContentPage>
    {
        #region Fields
        internal ControlTemplateViewModel? viewModel;
        private Border? rootBorder;
        private ContentPage? contentPage;
        double padding = DeviceInfo.Platform == DevicePlatform.WinUI ? 25 : 125;

        #endregion

        #region Overrides
        protected override void OnAttachedTo(ContentPage bindable)
        {
            rootBorder = bindable.FindByName<Border>("rootBorder");
            contentPage = bindable;
            viewModel = bindable.BindingContext as ControlTemplateViewModel;
#if WINDOWS || MACCATALYST
            contentPage.PropertyChanged += this.View_PropertyChanged!;
#endif
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(ContentPage bindable)
        {
#if WINDOWS || MACCATALYST
            contentPage!.PropertyChanged -= View_PropertyChanged!;
#endif
            viewModel = null;
            contentPage = null;
            base.OnDetachingFrom(bindable);
        }

        #endregion

        #region CallBacks
#if WINDOWS || MACCATALYST
        private void View_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {

            if (e.PropertyName == "Height" && viewModel != null && contentPage != null)
            {
                double borderHeight = 0;
#if WINDOWS
                borderHeight = contentPage.Height - padding;
#elif MACCATALYST
               borderHeight = contentPage.Height - ( 2 * padding );
#endif
                rootBorder!.HeightRequest = borderHeight;
            }

        }
#endif
        #endregion
    }
}
