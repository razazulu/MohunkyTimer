using Android.App;
using Android.OS;
using Android.Views;


namespace MohunkyTimer.Droid.Fragments
{
    public class Fragment1 : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);
            View rootView = inflater.Inflate(Resource.Layout.TimerFragmentLayout, container, false);
            return rootView;
        }
    }
}

//A placeholder fragment containing a simple view.
/*
	    public static class PlaceholderFragment : Fragment
	    {
	    

	    public PlaceholderFragment() {
        }

        @Override
        public View onCreateView(LayoutInflater inflater, ViewGroup container,
                                 Bundle savedInstanceState) {
            View rootView = inflater.inflate(R.layout.fragment_main, container, false);
            SeekBar seekBarProgress, seekBarThickness;
            seekBarProgress = (SeekBar) rootView.findViewById(R.id.seekBar_progress);
            seekBarThickness = (SeekBar) rootView.findViewById(R.id.seekBar_thickness);
            final Button button = (Button) rootView.findViewById(R.id.button);
            final CircleProgressBar circleProgressBar = (CircleProgressBar) rootView.findViewById(R.id.custom_progressBar);
            //Using ColorPickerLibrary to pick color for our CustomProgressbar
            final ColorPickerDialog colorPickerDialog = new ColorPickerDialog();
            colorPickerDialog.initialize(
                    R.string.select_color,
                    new int[]{
                                Color.CYAN,
                                Color.DKGRAY,
                                Color.BLACK,
                                Color.BLUE,
                                Color.GREEN,
                                Color.MAGENTA,
                                Color.RED,
                                Color.GRAY,
                                Color.YELLOW},
                                Color.DKGRAY, 3, 2);

            colorPickerDialog.setOnColorSelectedListener(new ColorPickerSwatch.OnColorSelectedListener() {
                
 * @Override
                public void onColorSelected(int color) {
                    circleProgressBar.setColor(color);
                }
            });
            button.setOnClickListener(new View.OnClickListener() {
               
 * @Override
                public void onClick(View view) {
                    colorPickerDialog.show(getFragmentManager(), "color_picker");
                }
            });
            seekBarProgress.setProgress((int) circleProgressBar.getProgress());
            seekBarProgress.setOnSeekBarChangeListener(new SeekBar.OnSeekBarChangeListener() {
                @Override
                public void onProgressChanged(SeekBar seekBar, int i, boolean b) {
                    if(b)
                        circleProgressBar.setProgressWithAnimation(i);
                    else
                        circleProgressBar.setProgress(i);
                }

                @Override
                public void onStartTrackingTouch(SeekBar seekBar) {

                }

                @Override
                public void onStopTrackingTouch(SeekBar seekBar) {

                }
            });
            seekBarThickness.setProgress((int) circleProgressBar.getStrokeWidth());
            seekBarThickness.setOnSeekBarChangeListener(new SeekBar.OnSeekBarChangeListener() {
                
 * @Override
                public void onProgressChanged(SeekBar seekBar, int i, boolean b) {
                    circleProgressBar.setStrokeWidth(i);
                }

                @Override
                public void onStartTrackingTouch(SeekBar seekBar) {

                }

                @Override
                public void onStopTrackingTouch(SeekBar seekBar) {

                }
            });
            return rootView;
        }*/