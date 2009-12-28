/// COPYRIGHT 2009 by the Open Rails project.
/// This code is provided to enable you to contribute improvements to the open rails program.  
/// Use of the code for any other purpose or distribution of the code to anyone else
/// is prohibited without specific written permission from admin@openrails.org.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;
using System.Diagnostics;
using System.Threading;
using System.Text;
using System.Windows.Forms;

namespace ORTS
{
    /// <summary>
    /// Displays Viewer frame rate and Viewer.Text debug messages in the upper left corner of the screen.
    /// </summary>
    public class InfoDisplay
    {
        StringBuilder TextBuilder = new StringBuilder();
        Matrix Matrix = Matrix.Identity;
        SpriteBatchMaterial Material;
        TextPrimitive TextPrimitive = new TextPrimitive();
        Viewer3D Viewer;
        int InfoAmount = 1;
        private double lastUpdateTime = 0;   // update text message only 10 times per second

        int processors = System.Environment.ProcessorCount;

        public InfoDisplay( Viewer3D viewer )
        {
            Viewer = viewer;
            // Create a new SpriteBatch, which can be used to draw text.
            Material = (SpriteBatchMaterial) Materials.Load( Viewer.RenderProcess, "SpriteBatch" );
            TextPrimitive.Material = Material;
            TextPrimitive.Color = Color.Yellow;
            TextPrimitive.Location = new Vector2(10, 10);
        }

        public void HandleUserInput(ElapsedTime elapsedTime)
        {
            if (UserInput.IsPressed(Microsoft.Xna.Framework.Input.Keys.F5))
            {
                ++InfoAmount;
                if (InfoAmount > 2)
                    InfoAmount = 0;
            }
        }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public void PrepareFrame(RenderFrame frame, ElapsedTime elapsedTime)
        {
            if (Program.RealTime - lastUpdateTime > 0.1)
            {
                lastUpdateTime = Program.RealTime;
                UpdateText();
            }
            TextPrimitive.Text = TextBuilder.ToString();
            frame.AddPrimitive( Material, TextPrimitive, ref Matrix);
        }


        public void UpdateText()
        {
            TextBuilder.Length = 0;

            if (InfoAmount > 0)
            {
                AddBasicInfo();
            }
            if (InfoAmount > 1)
            {
                AddDebugInfo();
            }
        }



        private void AddBasicInfo()
        {
            string clockTimeString = FormattedTime(Viewer.Simulator.ClockTime);

            TextBuilder.Append("Version = "); TextBuilder.AppendLine(Program.Version);
            TextBuilder.Append("Time = "); TextBuilder.AppendLine(clockTimeString);
            TextBuilder.Append("Direction = "); TextBuilder.AppendLine((Viewer.Simulator.PlayerLocomotive.Forward ? "FORWARD\n" : "REVERSE\n"));
            TextBuilder.Append("Throttle = "); TextBuilder.AppendLine(Viewer.Simulator.PlayerLocomotive.ThrottlePercent.ToString());
            TextBuilder.Append("Brake = "); TextBuilder.AppendLine(Viewer.Simulator.PlayerTrain.TrainBrakePercent.ToString());
            TextBuilder.Append("Speed = "); TextBuilder.AppendLine(MpH.FromMpS(Math.Abs(Viewer.Simulator.PlayerLocomotive.SpeedMpS)).ToString("F1"));
            TextBuilder.AppendLine();
            TextBuilder.Append("FPS = "); TextBuilder.AppendLine(Math.Round(Viewer.RenderProcess.SmoothedFrameRate).ToString());
        }


        [Conditional("DEBUG")]
        private void AddDebugInfo()
        {
            // Memory Useage
            long memory = System.Diagnostics.Process.GetCurrentProcess().WorkingSet64;

            TextBuilder.AppendLine();
            TextBuilder.Append("Build = "); TextBuilder.AppendLine(Application.ProductVersion);
            TextBuilder.Append("Memory = "); TextBuilder.AppendLine(memory.ToString());
            TextBuilder.Append("Jitter = "); TextBuilder.AppendLine(Viewer.RenderProcess.SmoothJitter.ToString("F4"));
            TextBuilder.Append("Primitives = "); TextBuilder.AppendLine(Viewer.RenderProcess.PrimitivesPerFrame.ToString());
            TextBuilder.Append("StateChanges = "); TextBuilder.AppendLine(Viewer.RenderProcess.RenderStateChangesPerFrame.ToString());
            TextBuilder.Append("ImageChanges = "); TextBuilder.AppendLine(Viewer.RenderProcess.ImageChangesPerFrame.ToString());
            TextBuilder.Append("Processors = "); TextBuilder.AppendLine(processors.ToString());
            TextBuilder.Append("Render Process % = "); TextBuilder.AppendLine( string.Format( "{0,3}",Viewer.RenderProcess.RenderUtilizationPercent ));
            TextBuilder.Append("Update Process % = "); 
            if( Viewer.UpdaterProcess != null )
                TextBuilder.AppendLine( string.Format( "{0,3}", Viewer.UpdaterProcess.UtilizationPercent));
            else
                TextBuilder.AppendLine( "NA" );
            TextBuilder.Append("Loader Process % = "); TextBuilder.AppendLine( string.Format( "{0,3}",Viewer.LoaderProcess.UtilizationPercent));
        }

        string FormattedTime(double clockTimeSeconds)
        {
            int hour = (int)(clockTimeSeconds / (60.0 * 60.0));
            clockTimeSeconds -= hour * 60.0 * 60.0;
            int minute = (int)(clockTimeSeconds / 60.0);
            clockTimeSeconds -= minute * 60.0;
            int seconds = (int)clockTimeSeconds;

            return string.Format("{0:D2}:{1:D2}:{2:D2}", hour, minute, seconds);
        }


    } // Class Info Display

    public class TextPrimitive : RenderPrimitive
    {
        public SpriteBatchMaterial Material;
        public string Text;
        public Color Color;
        public Vector2 Location;

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public void Draw(GraphicsDevice graphicsDevice)
        {
            Material.SpriteBatch.DrawString(Material.DefaultFont, Text, Location, Color );
        }
    }
}