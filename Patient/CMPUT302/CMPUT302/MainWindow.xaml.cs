using System;
using System.Windows;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Kinect;
using System.Linq;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;
using InteractiveFloorGame;
using System.Windows.Input;
using System.Windows.Threading;


namespace CMPUT302
{
    public partial class MainWindow : Window
    {

        //Instantiate the Kinect runtime. Required to initialize the device.
        //IMPORTANT NOTE: You can pass the device ID here, in case more than one Kinect device is connected.
        KinectSensor sensor = KinectSensor.KinectSensors[0];
        byte[] pixelData;
        Skeleton[] skeletons;
        public Tuple<float, float, float, float> FloorClipPlane { get; private set; }
        Position LeftFoot = new Position();
        [DllImport ("user32")]
    public static extern int SetCursorPos (int x , int y); //It draws the cursor postion
            private const int MOUSEEVENTF_MOVE=0x0001;
            private const int MOUSEEVENTF_LEFTDOWN=0x0002;
            private const int MOUSEEVENTF_LEFTUP=0x0004;
            private const int MOUSEEVENTF_RIGHTDOWN=0x0008;
            private int Screen_Width =0;
            private int Screen_Height =0;
            private int CursorX = 0;
            private int CursorY = 0;
            private int CursorZ = 0;
            private int Half_Screen_Width = 0;
            private int Half_Screen_Height = 0;
            private int cntr = 0;
            private float pX = 0.01f;
            private float pY = 1.5f;
            private float pZ = 0;
            private float xPrcnt = .005f;
            private float zPrcnt = .01f;
            private float diffX = 0.0f;
            private float diffZ = 0.0f;
            private Caliberation cal = new Caliberation();
            public int Cx = 0;
            public int Cy = 0;
            public int Cz = 0;

            
           
       [DllImport ("user32.dll",CharSet=CharSet.Auto,CallingConvention=CallingConvention.StdCall)]
            
        public static extern void mouse_event(int dwFlags,int dx,int dy , int cButtons,int dwExtraInfo);
        public MainWindow()
        {

           
           InitializeComponent();
           this.Hide();
            var smoothing = new TransformSmoothParameters
            {
                Smoothing = 0.2f,
                Correction = 0.0f,
                Prediction = 0.0f,
                JitterRadius = 1.0f,
                MaxDeviationRadius = 0.5f
            };
           
            //Runtime initialization is handled when the window is opened. When the window
           // this.WindowState =  System.Windows.WindowState.Maximized;//Maximazes the Window
            Form1 f0 = new Form1();
            f0.WindowState = FormWindowState.Maximized; ;
            f0.Show();
            Screen_Width = Convert.ToInt32(System.Windows.SystemParameters.WorkArea.Width);
            Screen_Height = Convert.ToInt32(System.Windows.SystemParameters.WorkArea.Height);

            LeftFoot.setX(0);
            LeftFoot.setZ(0);
            Half_Screen_Width = Screen_Width/2;
            Half_Screen_Height = Screen_Height/2;
            cal.WinCord(Half_Screen_Width, Half_Screen_Height);
           
            SetCursorPos(Half_Screen_Width,Half_Screen_Height);//To set the Cursor at the Build time at the center of the Screen
            //is closed, the runtime MUST be unitialized.
            this.Loaded += new RoutedEventHandler(MainWindow_Loaded);
            this.Unloaded += new RoutedEventHandler(MainWindow_Unloaded);
            sensor.ColorStream.Enable();
            sensor.SkeletonStream.Enable(smoothing);//Uses the Smoothing Param.
          
           
              }
        
     
       
      
        //Mouse click function takes the current x and y of the mouse and preforms a click on the current postion 
        private void Mouseclick(int X,int Y)
        {
           
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0); // left click down 
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0); // left click up /released
            
        }
         
        //ProcessGestture tracks the  desired limbs and draws its postion on the screen
          private void ProcessGesture(Joint FootLeft)
          {
              Microsoft.Kinect.SkeletonPoint vector = new Microsoft.Kinect.SkeletonPoint();
            
                  // Note that the X & Y represents the vertical plane of the sensor
                  // Z represents the depth or the prependicular distance from the sensor plan
              Joint LeftStore = FootLeft;
              

                  vector.X = FootLeft.Position.X; //Gets the Feet postion  X-axis in meters 
                  vector.Z = FootLeft.Position.Z; ///Gets the Feet postion Z-axis in meters (depth: Patient distance from Sensor)
                  vector.Y = FootLeft.Position.Y; //Gets the Feet postion  Y-axis in meters
                  FootLeft.Position = vector;
                
                  /*
                  VX.Text = Convert.ToString(Math.Round(FootLeft.Position.X, 3));//Prints it on the patient screen
                  VY.Text = Convert.ToString(Math.Round(FootLeft.Position.Y, 3));//Prints it on the patient screen
                  VZ.Text = Convert.ToString(Math.Round(FootLeft.Position.Z, 3));//Prints it on the patient screen
                  */
                  vector.X = ScaleX(vector.X); //Sends the postion to the scale function to be able //please check the function comments
                  vector.Z = ScaleZ(vector.Z); // same as before 
                  vector.Y = ScaleZ(vector.Y); // same as before
                  if (cntr > 0)
                  {
                      diffX = Math.Abs(vector.X) - Math.Abs(pX); // Calculates difference between old & new reading
                      diffZ = Math.Abs(vector.Z) - Math.Abs(pZ); // Calculates difference between old & new reading
                      if (diffX / pX > xPrcnt) vector.X = pX;// Calculates the % of the change, > pre-set % takes the old value
                      if (diffZ / pZ > zPrcnt) vector.Z = pZ;// Same
                      cntr += 1;
                  }
                  FootLeft.Position = vector;
                  CursorX = Convert.ToInt32(vector.X);//convert the float points 32 bit signed integear 
                  CursorZ = Convert.ToInt32(vector.Z);
                  CursorY = -1 * Convert.ToInt32(vector.Y);
                  cal.setX(FootLeft.Position.X);
                  cal.setZ(FootLeft.Position.Z);
                //  cal.Counter();
                 // cal.WinCord(CursorX, CursorY);
                  Cx = CursorX;
                  Cz = CursorY;
                  Cz = CursorZ;
                  SetCursorPos(CursorX, CursorZ);
                  /*
                  ScreenW.Text = Convert.ToString(CursorX);
                  ScreenH.Text = Convert.ToString(CursorZ);
                  SetCursorPos(CursorX, CursorZ);
                  */
                  pX = vector.X;//Store old positions for smotthing 
                  pZ = vector.Z;//Store old positions for smotthing 
                  pY = vector.Y;//Store old positions for smotthing 

                  Thread.SpinWait(32);



                  //These below controls the circles which indicates the postions of patient if its too noear or far
                 /* if (MatrixMath.FootToFloor(FloorClipPlane, LeftStore) && !LeftFoot.SamePosition(LeftStore))
                  {
                      Mouseclick(CursorX, CursorZ);
                      LeftFoot.setX(LeftStore.Position.X);
                      LeftFoot.setZ(LeftStore.Position.Z);
                      Debug.WriteLine("MouseClick");
                      Debug.WriteLine(MatrixMath.FootToFloorVal(FloorClipPlane, FootLeft));
                  }
                  if (vector.Z < 265)
                  {
                      cal.RedSignalStatus(1);
                      cal.YellowSignalStatus(0);
                      cal.GreenSignalStatus(0);
                     
                  }
                  if (vector.Z > 265 & vector.Z < 435)
                  {
                      cal.RedSignalStatus(0);
                      cal.YellowSignalStatus(1);
                      cal.GreenSignalStatus(0);
                    
                  }
                  if (vector.Z > 435)
                  {
                      cal.RedSignalStatus(0);
                      cal.YellowSignalStatus(0);
                      cal.GreenSignalStatus(1);
                      
                  }*/
             
                  
              
          }


//-------------------------------------------------------------------
        void runtime_SkeletonFrameReady(object sender, SkeletonFrameReadyEventArgs e)
        {
            bool receivedData = false;

            using (SkeletonFrame SFrame = e.OpenSkeletonFrame())
            {
                if (SFrame == null)
                {
                    // The image processing took too long. More than 2 frames behind.
                }
                else
                {
                    skeletons = new Skeleton[SFrame.SkeletonArrayLength];
                    SFrame.CopySkeletonDataTo(skeletons);
                    receivedData = true;
                    FloorClipPlane = SFrame.FloorClipPlane;
                }
            }

            if (receivedData)
            {

                Skeleton currentSkeleton = (from s in skeletons
                                            where s.TrackingState == SkeletonTrackingState.Tracked
                                            select s).FirstOrDefault();

                if (currentSkeleton != null)
                {
                   //Tracks the left leg //later modified ,depending on which leg to be tracked
                    ProcessGesture(currentSkeleton.Joints[JointType.FootLeft]);
                }
            }
        }

    // ScaleX & ScaleZ are used to convert the position measured in meters 
    // to screen pixel position, calculated based on screen resolution defined "Half_Screen_Width
    // The primary screen position is shifted to the center of the screen, as the maximum range Horizontly
    // and vertically is 4m x 4m, then The Half_Screen_Width is divided by 2f (float).  
       private float ScaleX(float position)
        {
            float value = 0;
            value = ((Half_Screen_Width / 2.2f) * position) + Half_Screen_Width;
            if (value > Screen_Width) value = Screen_Width;// To control the Screen Width Flickering 
            return value;
        }

       private float ScaleZ(float position)
       {
           float value = 0;
           value = ((Half_Screen_Height/2.2f) * position);
           if (value > Screen_Height) value = Screen_Height; // To control the Screen Height Flickering 
           return value;
       }

        
        void MainWindow_Unloaded(object sender, RoutedEventArgs e)
        {
            sensor.Stop();
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            sensor.SkeletonFrameReady += runtime_SkeletonFrameReady;
            sensor.Start();
        }

        

       

        
       
    }
}
