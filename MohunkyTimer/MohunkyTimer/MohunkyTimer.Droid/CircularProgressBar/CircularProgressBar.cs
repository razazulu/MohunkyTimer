using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace MohunkyTimer.Droid.CircularProgressBar
{
    public class CircularProgressBar : View
    {
        
        #region Fields

        //ProgressBar's line thickness
        private float strokeWidth = 4;
        private float progress = 0;
        private int min = 0;
        private int max = 100;
        //Start the progress at 12 o'clock
        private int startAngle = -90;
        private Color color = Color.DarkGray;
        private RectF rectF;
        private Paint backgroundPaint;
        private Paint foregroundPaint;

        #endregion

        #region Methods
        public CircularProgressBar(Context context, IAttributeSet attrs)
            : base(context, attrs)
        {
            Initilize(context, attrs);
        }

        private void Initilize(Context context, IAttributeSet attrs)
        {
            rectF = new RectF();
            TypedArray typedArray = context.Theme.ObtainStyledAttributes(
                    attrs,
                    Resource.Styleable.CircleProgressBar,
                    0, 0);

            //Reading values from the XML layout
            try
            {
                strokeWidth = typedArray.GetDimension(Resource.Styleable.CircleProgressBar_progressBarThickness, strokeWidth);
                progress = typedArray.GetFloat(Resource.Styleable.CircleProgressBar_progress, progress);
                color = typedArray.GetColor(Resource.Styleable.CircleProgressBar_progressbarColor, color);
                min = typedArray.GetInt(Resource.Styleable.CircleProgressBar_min, min);
                max = typedArray.GetInt(Resource.Styleable.CircleProgressBar_max, max);
            }
            finally
            {
                typedArray.Recycle();
            }

            backgroundPaint = new Paint();
            backgroundPaint.AntiAlias = true;
            backgroundPaint.Color = color;
            backgroundPaint.SetStyle(Paint.Style.Stroke);
            backgroundPaint.StrokeWidth = strokeWidth;

            foregroundPaint = new Paint();
            foregroundPaint.AntiAlias = true;
            foregroundPaint.Color = color;
            foregroundPaint.SetStyle(Paint.Style.Stroke);
            foregroundPaint.StrokeWidth = strokeWidth;
        }

        #region Overrides
        protected override void OnDraw(Canvas canvas)
        {
            base.OnDraw(canvas);
        }

        protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
        {
            base.OnMeasure(widthMeasureSpec, heightMeasureSpec);
        }
        #endregion

        #endregion

        #region Properties / Access

        public float GetStrokeWidth()
        {
            return strokeWidth;
        }

        public void SetStrokeWidth(float strokeWidth)
        {
            this.strokeWidth = strokeWidth;
            backgroundPaint.StrokeWidth = strokeWidth;
            foregroundPaint.StrokeWidth = strokeWidth;
            Invalidate();
            //Because it should recalculate its bounds
            RequestLayout();
        }

        public float GetProgress()
        {
            return progress;
        }

        public void SetProgress(float progress)
        {
            this.progress = progress;
            Invalidate();
        }

        public int GetMin()
        {
            return min;
        }

        public void SetMin(int min)
        {
            this.min = min;
            Invalidate();
        }

        public int GetMax()
        {
            return max;
        }

        public void SetMax(int max)
        {
            this.max = max;
            Invalidate();
        }

        public int GetColor()
        {
            return color;
        }

        public void SetColor(Color color)
        {
            this.color = color;
            backgroundPaint.Color = color;
            foregroundPaint.Color = color;
            Invalidate();
            RequestLayout();
        }

        #endregion
    }

    public class TestTextView : TextView
    {
        public TestTextView(Context context, IAttributeSet attrs)
            : base(context, attrs)
        {
            
        }
    }
}