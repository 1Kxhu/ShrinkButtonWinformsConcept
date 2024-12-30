using CuoreUI;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kchi
{
    public partial class ShrinkButton : UserControl
    {
        public ShrinkButton()
        {
            InitializeComponent();

            normalRect = ClientRectangle;
            normalRect.Inflate(-1, -1);

            Invalidate();
        }

        RectangleF normalRect = new RectangleF();
        RectangleF referenceRect = new RectangleF();
        RectangleF buttonRectangle = new RectangleF();

        SizeF currentOffset = new SizeF(0, 0);

        private float privateTargetSize = 0.75f;
        public float TargetSize
        {
            get
            {
                return privateTargetSize;
            }
            set
            {
                privateTargetSize = value;
                updateShrinkSize();
            }
        }

        private SizeF ShrinkSize { get; set; } = new SizeF(4, 4);

        private int privateAnimationDuration = 1000;
        public int AnimationDuration
        {
            get
            {
                return privateAnimationDuration;
            }
            set
            {
                privateAnimationDuration = value;
                updateShrinkSize();
            }
        }

        private Drawing.EasingTypes privateEasingType = Drawing.EasingTypes.QuadIn;
        public Drawing.EasingTypes EasingType
        {
            get
            {
                return privateEasingType;
            }
            set
            {
                privateEasingType = value;
            }
        }

        float timeToSpare = 0;

        void updateShrinkSize()
        {
            ShrinkSize = new SizeF(ClientRectangle.Size - new SizeF(ClientRectangle.Size.Width * privateTargetSize, ClientRectangle.Size.Height * privateTargetSize));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF currentRectangle;

            if (DesignMode)
            {
                currentRectangle = normalRect;
            }
            else
            {
                currentRectangle = buttonRectangle;
            }

            GraphicsPath background;
            if (Width > Height)
            {
                background = Helper.RoundRect(currentRectangle, (int)((currentRectangle.Height + 1) / 2));
            }
            else
            {
                background = Helper.RoundRect(currentRectangle, (int)((currentRectangle.Width + 1) / 2));
            }
            e.Graphics.FillPath(Brushes.Red, background);
            //e.Graphics.DrawString(Progress.ToString(), Font, Brushes.White, Point.Empty);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            buttonRectangle = normalRect;
            animate(AnimationDuration);
        }

        // [0; 1]
        float Progress = 0;

        private async void animate(int howMuchToSpare)
        {
            // prevent animations stacking on eachother
            if (timeToSpare > 0)
            {
                timeToSpare = 0;
                await Task.Delay(CuoreUI.Drawing.LazyInt32TimeDelta * 2);
            }

            timeToSpare = howMuchToSpare;
            currentOffset = ShrinkSize;
            float timePassedAnimating = 0;

            Progress = (timePassedAnimating + timeToSpare) / timeToSpare;

            float maxProgressRecorded = 1;

            // we can stop at a low value close enough to 0
            while (Progress > 0.025f && timeToSpare > 0)
            {
                Progress = (((((timePassedAnimating + timeToSpare) / timeToSpare) - 0.5f) * 2) * (AnimationDuration / (float)1000)) / maxProgressRecorded;
                maxProgressRecorded = Math.Max(maxProgressRecorded, Progress);

                // In = out, because Progress is reversed in our case
                // We could also set Progress to 1 - Progress if this gets annoying..
                float EasedProgress = (float)CuoreUI.Drawing.EasingFunctions.FromEasingType(EasingType, Progress);

                currentOffset = new SizeF(EasedProgress * -ShrinkSize.Width, EasedProgress * -ShrinkSize.Height);

                referenceRect = normalRect;
                referenceRect.Inflate(currentOffset);

                buttonRectangle = referenceRect;
                Refresh();

                timePassedAnimating -= CuoreUI.Drawing.LazyTimeDelta;
                await Task.Delay(CuoreUI.Drawing.LazyInt32TimeDelta);
            }

            timeToSpare = 0;
            Progress = 0;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            normalRect = ClientRectangle;
            normalRect.Inflate(-1, -1);

            referenceRect = normalRect;
            buttonRectangle = normalRect;

            normalRect.Inflate(-currentOffset.Width, -currentOffset.Height);
        }
    }
}
