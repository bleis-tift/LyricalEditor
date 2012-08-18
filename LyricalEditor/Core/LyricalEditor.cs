using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using bleistift.LyricalEditor.Options;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Editor;

namespace bleistift.LyricalEditor.Core
{
    class LyricalEditor
    {
        readonly IWpfTextView view;
        readonly Detail detail;
        readonly IAdornmentLayer adornmentLayer;

        int crntImageIndex = 0;
        string imageFile;

        static string SelectFile(Detail detail, int index)
        {
            if (detail == null || detail.Images.Count == 0)
                return null;

            if (detail.IsRandom)
            {
                var rand = new Random(DateTime.Now.Millisecond);
                return detail.Images[rand.Next(detail.Images.Count)];
            }
            if (!detail.IsSlideShow)
                return detail.Images[0];
            return detail.Images[index];
        }

        /// <summary>
        /// Creates a square image and attaches an event handler to the layout changed event that
        /// adds the the square in the upper right-hand corner of the TextView via the adornment layer
        /// </summary>
        /// <param name="view">The <see cref="IWpfTextView"/> upon which the adornment will be drawn</param>
        public LyricalEditor(IWpfTextView view, IEnumerable<Detail> details)
        {
            this.view = view;
            var doc =
                view.TextDataModel.DocumentBuffer.Properties.GetProperty<ITextDocument>(typeof(ITextDocument));
            var file = doc.FilePath;

            detail = details.FirstOrDefault(d => Regex.IsMatch(file, d.RuleRegex));
            imageFile = SelectFile(detail, 0);

            //Grab a reference to the adornment layer that this adornment should be added to
            this.adornmentLayer = view.GetAdornmentLayer("LyricalEditor");
            
            view.ViewportHeightChanged += delegate { this.onSizeChange(); };
            view.ViewportWidthChanged += delegate { this.onSizeChange(); };

            if (detail.IsSlideShow)
            {
                timer.Interval = TimeSpan.FromSeconds((double)detail.SlideShowTiming);
                timer.Tick += delegate
                {
                    crntImageIndex++;
                    if (crntImageIndex >= detail.Images.Count)
                        crntImageIndex = 0;
                    imageFile = SelectFile(detail, crntImageIndex);
                    SetImage();
                };
                timer.Start();
            }
            view.Closed += delegate { timer.Stop(); };
            view.GotAggregateFocus += delegate { if (detail.IsSlideShow) timer.Start(); };
            view.LostAggregateFocus += delegate { if (detail.IsSlideShow) timer.Stop(); };
        }
        DispatcherTimer timer = new DispatcherTimer(DispatcherPriority.Normal);

        void SetImage()
        {
            //clear the adornment layer of previous adornments
            adornmentLayer.RemoveAllAdornments();

            //Place the image in the top right hand corner of the Viewport
            var img = new Image
            {
                Stretch = Stretch.Uniform,
                HorizontalAlignment = System.Windows.HorizontalAlignment.Right,
                MinHeight = 200,
                Height = view.ViewportHeight,
                Source = new BitmapImage(new Uri(imageFile, UriKind.Absolute))
            };

            //Canvas.SetRight(img, view.ViewportRight);
            //Canvas.SetBottom(img, view.ViewportBottom);
            var orgWidth = img.Source.Width;
            var ratio = img.Height / img.Source.Height;
            var width = orgWidth * ratio;
            Canvas.SetLeft(img, view.ViewportWidth - width);
            Canvas.SetTop(img, 0);

            adornmentLayer.Opacity = detail.Opacity / 100.0;

            //add the image to the adornment layer and make it relative to the viewport
            adornmentLayer.AddAdornment(AdornmentPositioningBehavior.ViewportRelative, null, null, img, null);
        }

        public void onSizeChange()
        {
            if (detail == null || !detail.Images.Any())
                return;

            SetImage();
        }
    }
}
